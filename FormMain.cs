namespace OutlookGraphAPIExample
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private async void ButtonTodayEvents_Click(object? sender, EventArgs e)
        {
            textBoxResults.Clear();
            if (await Outlook.GraphGetDaySchedule(textBoxClientId.Text, textBoxTenantId.Text, DateTime.Now)
                is List<Microsoft.Graph.Models.Event> events)
            {
                textBoxResults.Text = string.Join(",", [
                    .. from item in events
                       select item.Subject ?? ""
                ]);
            }
        }
    }
}
