namespace BackgroundChanger
{
    partial class Form1
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
            this.StartConverting = new System.Windows.Forms.Button();
            this.changingBackground = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartConverting
            // 
            this.StartConverting.Location = new System.Drawing.Point(302, 130);
            this.StartConverting.Name = "StartConverting";
            this.StartConverting.Size = new System.Drawing.Size(250, 150);
            this.StartConverting.TabIndex = 0;
            this.StartConverting.Text = "Start Converting";
            this.StartConverting.UseVisualStyleBackColor = true;
            this.StartConverting.Click += new System.EventHandler(this.StartConverting_Click);
            // 
            // changingBackground
            // 
            this.changingBackground.AutoSize = true;
            this.changingBackground.Location = new System.Drawing.Point(359, 350);
            this.changingBackground.Name = "changingBackground";
            this.changingBackground.Size = new System.Drawing.Size(132, 17);
            this.changingBackground.TabIndex = 1;
            this.changingBackground.Text = "Changing Background";
            this.changingBackground.UseVisualStyleBackColor = true;
            this.changingBackground.CheckedChanged += new System.EventHandler(this.changingBackground_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(593, 208);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(120, 72);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open Photo";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.changingBackground);
            this.Controls.Add(this.StartConverting);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartConverting;
        private System.Windows.Forms.CheckBox changingBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
    }
}

