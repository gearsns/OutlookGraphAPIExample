using Azure.Core;
using Azure.Identity;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using System.Diagnostics;
using System.Text;
using Application = System.Windows.Forms.Application;
using Process = System.Diagnostics.Process;

namespace OutlookGraphAPIExample
{
    internal class Outlook
    {
        private static FormGraphUserCode? formUserCode;

        private static Form? FirstForm => Application.OpenForms[0];
        private static void GraphCloseForm()
        {
            if (formUserCode is not null && !formUserCode.IsDisposed)
            {
                FirstForm?.Invoke(formUserCode.Close);
            }
        }
        private static async Task<GraphServiceClient?> GraphConnect(string ClientId, string TenantId)
        {
            FirstForm?.Invoke(() => { formUserCode = new(); });
            string[] GraphUserScopes = ["Calendars.ReadWrite", "Calendars.Read.Shared"];
            DeviceCodeCredentialOptions options = new()
            {
                TokenCachePersistenceOptions = new TokenCachePersistenceOptions
                {
                    Name = TenantId
                },
                ClientId = ClientId,
                TenantId = TenantId,
                DeviceCodeCallback = (info, cancel) =>
                {
                    _ = Process.Start(new ProcessStartInfo()
                    {
                        FileName = info.VerificationUri.AbsoluteUri,
                        UseShellExecute = true,
                    });
                    FirstForm?.Invoke(() => { formUserCode?.Show(info.UserCode); });
                    return Task.FromResult(0);
                },
            };
            DeviceCodeCredential? _deviceCodeCredential = null;
            try
            {
                if (Properties.Settings.Default.GraphToken.Length > 0)
                {
                    using MemoryStream fileStream = new(Encoding.UTF8.GetBytes(Properties.Settings.Default.GraphToken));
                    AuthenticationRecord ar = await AuthenticationRecord.DeserializeAsync(fileStream);
                    if (ar.ClientId != ClientId || ar.TenantId != TenantId)
                    {
                        throw new Exception();
                    }
                    options.AuthenticationRecord = ar;
                    _deviceCodeCredential = new DeviceCodeCredential(options);
                }
            }
            catch { }
            try
            {
                if (_deviceCodeCredential is null)
                {
                    _deviceCodeCredential = new DeviceCodeCredential(options);
                    AuthenticationRecord authenticationRecord = await _deviceCodeCredential.AuthenticateAsync(
                        new TokenRequestContext(GraphUserScopes)
                        , null == formUserCode ? default : formUserCode.Token());
                    using MemoryStream fileStream = new();
                    await authenticationRecord.SerializeAsync(fileStream);
                    Properties.Settings.Default.GraphToken = Encoding.UTF8.GetString(fileStream.ToArray());
                }
                GraphCloseForm();
            }
            catch
            {
                GraphCloseForm();
                return null;
            }
            return new GraphServiceClient(_deviceCodeCredential, GraphUserScopes);
        }
        private static async Task<List<Event>?> GraphGetDaySchedule(GraphServiceClient graphClient, DateTime dateTime)
        {
            DateTime dateTimeUTC = DateTime.Parse(dateTime.ToString("yyyy-MM-dd")).ToUniversalTime();
            EventCollectionResponse? result = await graphClient.Me.CalendarView.GetAsync((requestConfiguration) =>
            {
                requestConfiguration.QueryParameters.StartDateTime = dateTimeUTC.ToString("yyyy-MM-ddTHH:mm:ssZ");
                requestConfiguration.QueryParameters.EndDateTime = dateTimeUTC.AddDays(+1).ToString("yyyy-MM-ddTHH:mm:ssZ");
                requestConfiguration.QueryParameters.Top = 100;
                requestConfiguration.QueryParameters.Orderby = ["start/dateTime"];
            });
            GraphCloseForm();
            if (result != null && result.Value != null)
            {
                return result.Value;
            }
            return null;
        }
        public static async Task<List<Event>?> GraphGetDaySchedule(string ClientId, string TenantId, DateTime dateTime)
        {
            GraphServiceClient? graphClient = await GraphConnect(ClientId, TenantId);
            return graphClient is null ? null : await GraphGetDaySchedule(graphClient, dateTime);
        }
    }
}
