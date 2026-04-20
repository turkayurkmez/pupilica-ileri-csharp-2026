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
            this.progressBarThread = new ProgressBar();
            buttonThread = new Button();
            labelThread = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
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
            groupBox2.Controls.Add(this.progressBarThread);
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
            this.progressBarThread.Location = new Point(40, 168);
            this.progressBarThread.Name = "progressBarThread";
            this.progressBarThread.Size = new Size(232, 29);
            this.progressBarThread.TabIndex = 2;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 475);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
