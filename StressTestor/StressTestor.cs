namespace StressTestor
{
    public partial class Form1 : Form
    {

        StressTest t;

        public Form1()
        {
            InitializeComponent();
        }

        public void Stop()
        {
            if (t == null)
            {
                lblStatus.Text = "Not running";
                return;
            }

            t.Stop();
            t = null;
        }

        public void Go()
        {
            if (t != null)
            {
                lblStatus.Text = "Already running - stop first";
                return;
            }

            lblStatus.Text = "Running";
            int threads = 10;
            int.TryParse(txtThreads.Text, out threads);

            int delay = 1000;
            int.TryParse(txtDelay.Text, out delay);

            int count = 10;
            int.TryParse(txtCount.Text, out count);

            string url = txtURL.Text;

            t = new StressTest(threads, delay, count);

            t.Log = (string message) =>
            {
                Invoke(() =>
                {
                    lstLog.Items.Add(message);
                });
            };

            t.Go(url);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Go();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstLog.Items.Clear();
        }
    }
}
