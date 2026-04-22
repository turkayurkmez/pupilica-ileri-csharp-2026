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
            for (int i = 0; i <= 100_000; i++)
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
            thread.Start(10_000);

            thread.Join();
            MessageBox.Show("Thread Döngüsü bitti");
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

        private void buttonSample_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sample çalışıyor!");
        }

        private void buttonTask_Click(object sender, EventArgs e)
        {
            //.net'in Thread Pool üzerinde çalışan, yönetilen bir iş birimidir.
            //

            var task = Task.Run(() => loopWithTask(10_000));
            if (task.IsCompleted)
            {
                MessageBox.Show("task bitti");
            }

        }

        void loopWithTask(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                labelTask.Text = i.ToString();
                progressBarTask.Value = i / 100;
            }
            //Thread.Sleep(1);


        }

        //Aman dikkat!!! Sadece Event Handler (aşağıdaki gibi) Task döndürmemeliler.

        private async void buttonAsyncTask_Click(object sender, EventArgs e)
        {
            buttonAsyncTask.Enabled = false;
            await loopWithAsync(10000);
            MessageBox.Show("async çağrı tamamlandı");
            buttonAsyncTask.Enabled = true;
        }

        //normal bir metod, async olması için mutlaka Task döndürmeli.
        async Task loopWithAsync(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                labelAsyncAwait.Text = i.ToString();
                progressBarAsyncAwait.Value = i / 100;

                //UI thread'den bağımsız çalış ve ona "nefes aldır"
                await Task.Delay(10);
            }
            //Thread.Sleep(1);


        }

        //İptal sinyalini yöneten kaynak.
        //Start butonu her seferinde yeni token oluşturur.
        //Stop buton, var olan token'ı iptal sinyali gönderir
        //Her ikisi de bu nedenle cancellationTokenSource nesnesine erişmeli
        CancellationTokenSource cancellationTokenSource;
        private async void buttonStart_Click(object sender, EventArgs e)
        {
          
            cancellationTokenSource = new CancellationTokenSource();
            try
            {
               //await  Task.Run(() => { loopWithCancellableAsync(100000); },cancellationTokenSource.Token);
                await loopWithCancellableAsync(100000, cancellationTokenSource.Token);

            }
            catch (OperationCanceledException)
            {
                MessageBox.Show("task iptal edildi");


            }
            finally
            {
                cancellationTokenSource.Dispose();
            }
        }


       async Task loopWithCancellableAsync(int number, CancellationToken cancellationToken)
        {
           
            for (int i = 0; i <= number; i++)
            {
                cancellationToken.ThrowIfCancellationRequested();

                labelCalncellable.Text = i.ToString();
                progressBarCancelable.Value = i / 1000;

                //if (cancellationToken.IsCancellationRequested)
                //{
                //    //MessageBox.Show("iptal edildi!");
                //   // labelState.Text = "Task iptal edildi!";
                //}

                //UI thread'den bağımsız çalış ve ona "nefes aldır"
                await Task.Delay(10);

            }
            //Thread.Sleep(1);
          //  return Task.CompletedTask;

        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
