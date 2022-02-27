using ImageMagick;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PictureExtensionChanger
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern Int32 SystemParametersInfo(UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

        private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
        private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
        private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

        bool allowToChangePicture = false;

        string pathToPhoto;


        public Form1()
        {
            InitializeComponent();

        }

        private void StartConverting_Click(object sender, EventArgs e)
        {
            Object selectedExtension = comboBox1.SelectedItem;
            string selectedExtensionString = selectedExtension.ToString();

            convertingImage(selectedExtensionString);

            changingWindowsBackground(pathToPhoto, true);
        }

        private void changingWindowsBackground(string path, bool update_registry)
        {
            try
            {
                // Set the desktop background to this file.
                if (allowToChangePicture)
                {

                    SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
                        SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);

                    MessageBox.Show("Background image changed",
                        "Operation successful", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error changing picture." +
                    path + ".\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void convertingImage(string selectedExtensionString)
        {

            using (var images = new MagickImageCollection())
            {

                images.Read(pathToPhoto);

                var page = 1;
                foreach (var image in images)
                {
                   if (selectedExtensionString == "JPEG")
                    {
                        // Write page to file that contains the page number
                        image.Write(pathToPhoto + page + ".jpg");
                        page++;
                    }
                    else if (selectedExtensionString == "PNG")
                    {
                        // Write page to file that contains the page number
                        image.Write(pathToPhoto + page + ".png");
                        page++;
                    }
                    else if (selectedExtensionString == "heic")
                    {
                        // Write page to file that contains the page number
                        image.Write(pathToPhoto + page + ".heic");
                        page++;
                    }
                    
                }
            }
        }

        private void changingBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (changingBackground.Checked)
            {
                allowToChangePicture = true;
            }            
        }

        private void openFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pathToPhoto = openFileDialog1.FileName;

                gettingExtensionFormat();

                try
                {
                    pictureBox.Load(openFileDialog1.FileName);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                }
                catch (Exception ex)
                {
                    MessageBox.Show (ex.Message,
                        "Error to preview picture", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
               
            }
        }

        private void gettingExtensionFormat()
        {
            // Read from file
            var info = new MagickImageInfo(pathToPhoto);

            Console.WriteLine(info.Width);
            Console.WriteLine(info.Height);
            Console.WriteLine(info.ColorSpace);
            Console.WriteLine(info.Format);
            imageExtension.Text = $"Image Extension: {info.Format}";
        }

        private void stretchPicture_CheckedChanged(object sender, EventArgs e)
        {
            if (stretchPicture.Checked)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                pictureBox.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
