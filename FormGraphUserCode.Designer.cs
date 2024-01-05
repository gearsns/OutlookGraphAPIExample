namespace OutlookGraphAPIExample
{
    partial class FormGraphUserCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxCode = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(96, 25);
            label2.TabIndex = 7;
            label2.Text = "Authentication";
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.Brown;
            buttonCancel.FlatAppearance.BorderSize = 0;
            buttonCancel.FlatStyle = FlatStyle.Flat;
            buttonCancel.ForeColor = Color.White;
            buttonCancel.Location = new Point(171, 44);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 6;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 5;
            label1.Text = "Code";
            // 
            // textBoxCode
            // 
            textBoxCode.Location = new Point(64, 44);
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ReadOnly = true;
            textBoxCode.Size = new Size(100, 23);
            textBoxCode.TabIndex = 4;
            // 
            // FormGraphUserCode
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(259, 81);
            Controls.Add(label2);
            Controls.Add(buttonCancel);
            Controls.Add(label1);
            Controls.Add(textBoxCode);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGraphUserCode";
            Text = "FormGraphUserCode";
            MouseDown += FormGraphUserCode_MouseDown;
            MouseMove += FormGraphUserCode_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBoxCode;
    }
}