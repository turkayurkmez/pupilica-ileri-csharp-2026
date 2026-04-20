namespace Display.Aplplication
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
            menuStrip1 = new MenuStrip();
            pluginsToolStripMenuItem = new ToolStripMenuItem();
            pluginAddMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            numericUpDownWidth = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            numericUpDownX = new NumericUpDown();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { pluginsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // pluginsToolStripMenuItem
            // 
            pluginsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pluginAddMenuItem });
            pluginsToolStripMenuItem.Name = "pluginsToolStripMenuItem";
            pluginsToolStripMenuItem.Size = new Size(70, 24);
            pluginsToolStripMenuItem.Text = "Plugins";
            // 
            // pluginAddMenuItem
            // 
            pluginAddMenuItem.Name = "pluginAddMenuItem";
            pluginAddMenuItem.Size = new Size(164, 26);
            pluginAddMenuItem.Text = "Plugin Ekle";
            pluginAddMenuItem.Click += pluginAddMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(numericUpDownWidth);
            splitContainer1.Panel1.Controls.Add(numericUpDownY);
            splitContainer1.Panel1.Controls.Add(numericUpDownX);
            splitContainer1.Size = new Size(800, 422);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 1;
            // 
            // numericUpDownWidth
            // 
            numericUpDownWidth.Location = new Point(30, 97);
            numericUpDownWidth.Name = "numericUpDownWidth";
            numericUpDownWidth.Size = new Size(150, 27);
            numericUpDownWidth.TabIndex = 2;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(30, 64);
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(150, 27);
            numericUpDownY.TabIndex = 1;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(30, 31);
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(150, 27);
            numericUpDownX.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDownWidth).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem pluginsToolStripMenuItem;
        private ToolStripMenuItem pluginAddMenuItem;
        private SplitContainer splitContainer1;
        private NumericUpDown numericUpDownWidth;
        private NumericUpDown numericUpDownY;
        private NumericUpDown numericUpDownX;
    }
}
