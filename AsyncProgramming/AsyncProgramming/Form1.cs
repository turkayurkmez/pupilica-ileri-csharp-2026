namespace AsyncProgramming
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100000; i++)
            {
                labelSync.Text = i.ToString();
                progressBarSync.Value = i / 1000;

            }

            MessageBox.Show("Döngü bitti");
        }


        Thread thread = null;
        private void buttonThread_Click(object sender, EventArgs e)
        {
            thread = new Thread(new ParameterizedThreadStart(loopWithThread));
            thread.Start(10000);

            //thread.Join();
           // MessageBox.Show("Thread Döngüsü bitti");
        }

        void loopWithThread(object number)
        {
            int x = (int)number;
            for (int i = 0; i < x; i++)
            {
                labelThread.Text = i.ToString();
                progressBarThread.Value = i / 100;
            }
        }
    }
}
