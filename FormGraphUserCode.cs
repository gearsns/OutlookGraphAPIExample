namespace OutlookGraphAPIExample
{
    public partial class FormGraphUserCode : Form
    {
        private Point mousePoint = new();
        private readonly CancellationTokenSource cancellationTokenSource = new();
        public FormGraphUserCode()
        {
            InitializeComponent();
        }

        public CancellationToken Token() => cancellationTokenSource.Token;
        public void Show(string code)
        {
            textBoxCode.Text = code;
            Show();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
            Close();
        }

        private void FormGraphUserCode_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                mousePoint = new Point(e.X, e.Y);
            }
        }

        private void FormGraphUserCode_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - mousePoint.X;
                Top += e.Y - mousePoint.Y;
            }
        }
    }
}
