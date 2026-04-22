namespace AsyncProgramming
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            progressBarSync = new ProgressBar();
            buttonSync = new Button();
            labelSync = new Label();
            groupBox2 = new GroupBox();
            progressBarThread = new ProgressBar();
            buttonThread = new Button();
            labelThread = new Label();
            buttonSample = new Button();
            groupBox3 = new GroupBox();
            progressBarTask = new ProgressBar();
            buttonTask = new Button();
            labelTask = new Label();
            groupBox4 = new GroupBox();
            progressBarAsyncAwait = new ProgressBar();
            buttonAsyncTask = new Button();
            labelAsyncAwait = new Label();
            groupBox5 = new GroupBox();
            buttonStop = new Button();
            progressBarCancelable = new ProgressBar();
            buttonStart = new Button();
            labelCalncellable = new Label();
            labelState = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(progressBarSync);
            groupBox1.Controls.Add(buttonSync);
            groupBox1.Controls.Add(labelSync);
            groupBox1.Location = new Point(57, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(335, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Senkron";
            // 
            // progressBarSync
            // 
            progressBarSync.Location = new Point(40, 168);
            progressBarSync.Name = "progressBarSync";
            progressBarSync.Size = new Size(232, 29);
            progressBarSync.TabIndex = 2;
            // 
            // buttonSync
            // 
            buttonSync.Location = new Point(102, 87);
            buttonSync.Name = "buttonSync";
            buttonSync.Size = new Size(94, 29);
            buttonSync.TabIndex = 1;
            buttonSync.Text = "Senkron";
            buttonSync.UseVisualStyleBackColor = true;
            buttonSync.Click += buttonSync_Click;
            // 
            // labelSync
            // 
            labelSync.AutoSize = true;
            labelSync.Location = new Point(135, 130);
            labelSync.Name = "labelSync";
            labelSync.Size = new Size(17, 20);
            labelSync.TabIndex = 0;
            labelSync.Text = "0";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(progressBarThread);
            groupBox2.Controls.Add(buttonThread);
            groupBox2.Controls.Add(labelThread);
            groupBox2.Location = new Point(432, 80);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(335, 247);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "ASenkron - Thread";
            // 
            // progressBarThread
            // 
            progressBarThread.Location = new Point(40, 168);
            progressBarThread.Name = "progressBarThread";
            progressBarThread.Size = new Size(232, 29);
            progressBarThread.TabIndex = 2;
            // 
            // buttonThread
            // 
            buttonThread.Location = new Point(102, 87);
            buttonThread.Name = "buttonThread";
            buttonThread.Size = new Size(151, 29);
            buttonThread.TabIndex = 1;
            buttonThread.Text = "Thread'i Başlat";
            buttonThread.UseVisualStyleBackColor = true;
            buttonThread.Click += buttonThread_Click;
            // 
            // labelThread
            // 
            labelThread.AutoSize = true;
            labelThread.Location = new Point(158, 130);
            labelThread.Name = "labelThread";
            labelThread.Size = new Size(17, 20);
            labelThread.TabIndex = 0;
            labelThread.Text = "0";
            // 
            // buttonSample
            // 
            buttonSample.Location = new Point(799, 31);
            buttonSample.Name = "buttonSample";
            buttonSample.Size = new Size(94, 29);
            buttonSample.TabIndex = 4;
            buttonSample.Text = "Sample";
            buttonSample.UseVisualStyleBackColor = true;
            buttonSample.Click += buttonSample_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(progressBarTask);
            groupBox3.Controls.Add(buttonTask);
            groupBox3.Controls.Add(labelTask);
            groupBox3.Location = new Point(786, 80);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(335, 247);
            groupBox3.TabIndex = 4;
            groupBox3.TabStop = false;
            groupBox3.Text = "ASenkron - Task";
            // 
            // progressBarTask
            // 
            progressBarTask.Location = new Point(40, 168);
            progressBarTask.Name = "progressBarTask";
            progressBarTask.Size = new Size(251, 29);
            progressBarTask.TabIndex = 2;
            // 
            // buttonTask
            // 
            buttonTask.Location = new Point(102, 87);
            buttonTask.Name = "buttonTask";
            buttonTask.Size = new Size(151, 29);
            buttonTask.TabIndex = 1;
            buttonTask.Text = "Task'ı Başlat";
            buttonTask.UseVisualStyleBackColor = true;
            buttonTask.Click += buttonTask_Click;
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(158, 130);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(17, 20);
            labelTask.TabIndex = 0;
            labelTask.Text = "0";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(progressBarAsyncAwait);
            groupBox4.Controls.Add(buttonAsyncTask);
            groupBox4.Controls.Add(labelAsyncAwait);
            groupBox4.Location = new Point(1129, 80);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(335, 247);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "ASenkron - Async / Await";
            // 
            // progressBarAsyncAwait
            // 
            progressBarAsyncAwait.Location = new Point(40, 168);
            progressBarAsyncAwait.Name = "progressBarAsyncAwait";
            progressBarAsyncAwait.Size = new Size(251, 29);
            progressBarAsyncAwait.TabIndex = 2;
            // 
            // buttonAsyncTask
            // 
            buttonAsyncTask.Location = new Point(102, 87);
            buttonAsyncTask.Name = "buttonAsyncTask";
            buttonAsyncTask.Size = new Size(151, 29);
            buttonAsyncTask.TabIndex = 1;
            buttonAsyncTask.Text = "await kullanımı";
            buttonAsyncTask.UseVisualStyleBackColor = true;
            buttonAsyncTask.Click += buttonAsyncTask_Click;
            // 
            // labelAsyncAwait
            // 
            labelAsyncAwait.AutoSize = true;
            labelAsyncAwait.Location = new Point(158, 130);
            labelAsyncAwait.Name = "labelAsyncAwait";
            labelAsyncAwait.Size = new Size(17, 20);
            labelAsyncAwait.TabIndex = 0;
            labelAsyncAwait.Text = "0";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(labelState);
            groupBox5.Controls.Add(buttonStop);
            groupBox5.Controls.Add(progressBarCancelable);
            groupBox5.Controls.Add(buttonStart);
            groupBox5.Controls.Add(labelCalncellable);
            groupBox5.Location = new Point(590, 397);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(371, 247);
            groupBox5.TabIndex = 6;
            groupBox5.TabStop = false;
            groupBox5.Text = "ASenkron - Async / Await - İptal edilebilir";
            // 
            // buttonStop
            // 
            buttonStop.Location = new Point(197, 84);
            buttonStop.Name = "buttonStop";
            buttonStop.Size = new Size(151, 29);
            buttonStop.TabIndex = 3;
            buttonStop.Text = "durdur";
            buttonStop.UseVisualStyleBackColor = true;
            buttonStop.Click += buttonStop_Click;
            // 
            // progressBarCancelable
            // 
            progressBarCancelable.Location = new Point(52, 169);
            progressBarCancelable.Name = "progressBarCancelable";
            progressBarCancelable.Size = new Size(251, 29);
            progressBarCancelable.TabIndex = 2;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(40, 84);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(151, 29);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "başlat";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // labelCalncellable
            // 
            labelCalncellable.AutoSize = true;
            labelCalncellable.Location = new Point(158, 130);
            labelCalncellable.Name = "labelCalncellable";
            labelCalncellable.Size = new Size(17, 20);
            labelCalncellable.TabIndex = 0;
            labelCalncellable.Text = "0";
            // 
            // labelState
            // 
            labelState.AutoSize = true;
            labelState.Location = new Point(168, 44);
            labelState.Name = "labelState";
            labelState.Size = new Size(50, 20);
            labelState.TabIndex = 4;
            labelState.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 743);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(buttonSample);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ProgressBar progressBarSync;
        private Button buttonSync;
        private Label labelSync;
        private GroupBox groupBox2;
        private ProgressBar progressBarThread;
        private Button buttonThread;
        private Label labelThread;
        private Button buttonSample;
        private GroupBox groupBox3;
        private ProgressBar progressBarTask;
        private Button buttonTask;
        private Label labelTask;
        private GroupBox groupBox4;
        private ProgressBar progressBarAsyncAwait;
        private Button buttonAsyncTask;
        private Label labelAsyncAwait;
        private GroupBox groupBox5;
        private ProgressBar progressBarCancelable;
        private Button buttonStart;
        private Label labelCalncellable;
        private Button buttonStop;
        private Label labelState;
    }
}
