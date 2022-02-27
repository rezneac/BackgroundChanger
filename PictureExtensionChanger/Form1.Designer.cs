namespace PictureExtensionChanger
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.stretchPicture = new System.Windows.Forms.CheckBox();
            this.imageExtension = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.convertToLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // StartConverting
            // 
            this.StartConverting.Location = new System.Drawing.Point(532, 366);
            this.StartConverting.Name = "StartConverting";
            this.StartConverting.Size = new System.Drawing.Size(129, 72);
            this.StartConverting.TabIndex = 0;
            this.StartConverting.Text = "Start Converting";
            this.StartConverting.UseVisualStyleBackColor = true;
            this.StartConverting.Click += new System.EventHandler(this.StartConverting_Click);
            // 
            // changingBackground
            // 
            this.changingBackground.AutoSize = true;
            this.changingBackground.Location = new System.Drawing.Point(348, 421);
            this.changingBackground.Name = "changingBackground";
            this.changingBackground.Size = new System.Drawing.Size(178, 17);
            this.changingBackground.TabIndex = 1;
            this.changingBackground.Text = "Changing Windows background";
            this.changingBackground.UseVisualStyleBackColor = true;
            this.changingBackground.CheckedChanged += new System.EventHandler(this.changingBackground_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "HEIC files (*.heic)|*.heic|JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP F" +
    "iles (*.bmp)|*.bmp|All files (*.*)|*.*";
            // 
            // openFile
            // 
            this.openFile.Location = new System.Drawing.Point(668, 366);
            this.openFile.Name = "openFile";
            this.openFile.Size = new System.Drawing.Size(120, 72);
            this.openFile.TabIndex = 2;
            this.openFile.Text = "Open Photo";
            this.openFile.UseVisualStyleBackColor = true;
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(48, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(740, 348);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // stretchPicture
            // 
            this.stretchPicture.AutoSize = true;
            this.stretchPicture.Location = new System.Drawing.Point(348, 395);
            this.stretchPicture.Name = "stretchPicture";
            this.stretchPicture.Size = new System.Drawing.Size(60, 17);
            this.stretchPicture.TabIndex = 4;
            this.stretchPicture.Text = "Stretch";
            this.stretchPicture.UseVisualStyleBackColor = true;
            this.stretchPicture.CheckedChanged += new System.EventHandler(this.stretchPicture_CheckedChanged);
            // 
            // imageExtension
            // 
            this.imageExtension.AutoSize = true;
            this.imageExtension.Location = new System.Drawing.Point(45, 396);
            this.imageExtension.Name = "imageExtension";
            this.imageExtension.Size = new System.Drawing.Size(117, 13);
            this.imageExtension.TabIndex = 5;
            this.imageExtension.Text = "Image Extension: None";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "JPEG",
            "PNG",
            "heic"});
            this.comboBox1.Location = new System.Drawing.Point(251, 393);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(87, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // convertToLabel
            // 
            this.convertToLabel.AutoSize = true;
            this.convertToLabel.Location = new System.Drawing.Point(190, 396);
            this.convertToLabel.Name = "convertToLabel";
            this.convertToLabel.Size = new System.Drawing.Size(59, 13);
            this.convertToLabel.TabIndex = 7;
            this.convertToLabel.Text = "Convert to:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.convertToLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.imageExtension);
            this.Controls.Add(this.stretchPicture);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.openFile);
            this.Controls.Add(this.changingBackground);
            this.Controls.Add(this.StartConverting);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartConverting;
        private System.Windows.Forms.CheckBox changingBackground;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openFile;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.CheckBox stretchPicture;
        private System.Windows.Forms.Label imageExtension;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label convertToLabel;
    }
}

