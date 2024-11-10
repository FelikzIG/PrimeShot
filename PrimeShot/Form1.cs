using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeShot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void CaptureFullscreen()
        {
            //Hide form to not interrupt screenshot
            this.Hide();

            Random random = new Random();
            int randomInRange = random.Next(1, 100000);  // Generates a number between 1 and 100.000, used for generating a random file name

            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            

            using (Bitmap bitmap = new Bitmap(screenBounds.Width, screenBounds.Height))
            {
                // Draw the graphics of the selected monitor to the bitmap
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(screenBounds.Left, screenBounds.Top), Point.Empty, screenBounds.Size);
                }

                //Save the screenshot as a Jpg image
                var uniqueFileName = Properties.Settings.Default.saveTo + "/" + randomInRange + "." + Properties.Settings.Default.fileType;
                try
                {
                    if (Properties.Settings.Default.fileType == "png")
                    {
                        bitmap.Save(uniqueFileName, ImageFormat.Png);
                        MessageBox.Show("Screenshot saved to " + uniqueFileName);
                        this.Show();
                    }
                    else if (Properties.Settings.Default.fileType == "jpg")
                    {
                        bitmap.Save(uniqueFileName, ImageFormat.Jpeg);
                        MessageBox.Show("Screenshot saved to " + uniqueFileName);
                        this.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    this.Show();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CaptureFullscreen();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings conf = new settings();
            conf.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScreenshotForm customRegionForm = new ScreenshotForm();
            customRegionForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about aboutPrime = new about();
            aboutPrime.Show();
        }
    }
}
