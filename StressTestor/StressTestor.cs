namespace StressTestor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int threads = 10;
            int.TryParse(txtThreads.Text, out threads);

            int delay = 1000;
            int.TryParse(txtDelay.Text, out delay);
        }
    }
}
