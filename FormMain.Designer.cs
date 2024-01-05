namespace OutlookGraphAPIExample
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonTodayEvents = new Button();
            labelTenantId = new Label();
            labelClientId = new Label();
            textBoxTenantId = new TextBox();
            textBoxClientId = new TextBox();
            textBoxResults = new TextBox();
            SuspendLayout();
            // 
            // buttonTodayEvents
            // 
            buttonTodayEvents.Location = new Point(387, 9);
            buttonTodayEvents.Name = "buttonTodayEvents";
            buttonTodayEvents.Size = new Size(99, 32);
            buttonTodayEvents.TabIndex = 0;
            buttonTodayEvents.Text = "Today Events";
            buttonTodayEvents.UseVisualStyleBackColor = true;
            buttonTodayEvents.Click += ButtonTodayEvents_Click;
            // 
            // labelTenantId
            // 
            labelTenantId.AutoSize = true;
            labelTenantId.Location = new Point(21, 12);
            labelTenantId.Name = "labelTenantId";
            labelTenantId.Size = new Size(52, 15);
            labelTenantId.TabIndex = 1;
            labelTenantId.Text = "TenantId";
            // 
            // labelClientId
            // 
            labelClientId.AutoSize = true;
            labelClientId.Location = new Point(21, 41);
            labelClientId.Name = "labelClientId";
            labelClientId.Size = new Size(47, 15);
            labelClientId.TabIndex = 2;
            labelClientId.Text = "ClientId";
            // 
            // textBoxTenantId
            // 
            textBoxTenantId.Location = new Point(94, 9);
            textBoxTenantId.Name = "textBoxTenantId";
            textBoxTenantId.Size = new Size(291, 23);
            textBoxTenantId.TabIndex = 3;
            // 
            // textBoxClientId
            // 
            textBoxClientId.Location = new Point(94, 38);
            textBoxClientId.Name = "textBoxClientId";
            textBoxClientId.Size = new Size(291, 23);
            textBoxClientId.TabIndex = 4;
            // 
            // textBoxResults
            // 
            textBoxResults.Location = new Point(21, 84);
            textBoxResults.Multiline = true;
            textBoxResults.Name = "textBoxResults";
            textBoxResults.Size = new Size(465, 250);
            textBoxResults.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 351);
            Controls.Add(buttonTodayEvents);
            Controls.Add(textBoxTenantId);
            Controls.Add(textBoxClientId);
            Controls.Add(labelClientId);
            Controls.Add(labelTenantId);
            Controls.Add(textBoxResults);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            Text = "OutlookGraphAPIExample";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTodayEvents;
        private Label labelTenantId;
        private Label labelClientId;
        private TextBox textBoxTenantId;
        private TextBox textBoxClientId;
        private TextBox textBoxResults;
    }
}
