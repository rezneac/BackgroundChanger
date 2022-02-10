using BackgroundChanger.Properties;
using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace BackgroundChanger
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
            convertingImage();

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
                MessageBox.Show("Error changing picture" +
                    path + ".\n" + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void convertingImage()
        {

            using (var images = new MagickImageCollection())
            {

                images.Read(pathToPhoto);

                var page = 1;
                foreach (var image in images)
                {
                    // Write page to file that contains the page number
                    image.Write(pathToPhoto + page + ".jpg");
                    page++;
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
                
                //pathToPhoto.Load(openFileDialog1.FileName);
            }
        }
    }
}
