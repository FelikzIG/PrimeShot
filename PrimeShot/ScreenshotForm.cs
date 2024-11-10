using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeShot
{
    public partial class ScreenshotForm : Form
    {
        private bool isDragging = false;
        private Point startPoint;
        private Rectangle selectionRectangle;
        private Bitmap screenshotBitmap;
        public ScreenshotForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            this.BackColor = Color.Black; // This can be any color
            //this.TransparencyKey = Color.Magenta;
            this.Opacity = 0.08;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.MouseDown += ScreenshotForm_MouseDown;
            this.MouseMove += ScreenshotForm_MouseMove;
            this.MouseUp += ScreenshotForm_MouseUp;
        }

        // Mouse down event to start the selection
        private void ScreenshotForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = e.Location;
            }
        }

        // Mouse move event to update the selection area
        private void ScreenshotForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int width = e.X - startPoint.X;
                int height = e.Y - startPoint.Y;
                selectionRectangle = new Rectangle(startPoint.X, startPoint.Y, width, height);
                this.Invalidate(); // Redraw the form to show the selection rectangle
            }
        }

        // Mouse up event to finalize the selection
        private void ScreenshotForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                isDragging = false;
                CaptureSelectedRegion();
            }
        }

        // Captures the screenshot of the selected region
        private void CaptureSelectedRegion()
        {
            Random random = new Random();
            int randomInRange = random.Next(1, 100000);  // Generates a number between 1 and 100.000, used for generating a random file name
            if (selectionRectangle.Width > 0 && selectionRectangle.Height > 0)
            {
                try
                {
                    // Create a bitmap of the selected area
                    screenshotBitmap = new Bitmap(selectionRectangle.Width, selectionRectangle.Height);
                    using (Graphics g = Graphics.FromImage(screenshotBitmap))
                    {
                        g.CopyFromScreen(selectionRectangle.Location, Point.Empty, selectionRectangle.Size);
                    }

                    var uniqueFileName = Properties.Settings.Default.saveTo + "/" + randomInRange + "." + Properties.Settings.Default.fileType;
                    try
                    {
                        if(Properties.Settings.Default.fileType == "png")
                        {
                            screenshotBitmap.Save(uniqueFileName, ImageFormat.Png);
                            MessageBox.Show("Screenshot saved to " + uniqueFileName);
                            this.Show();
                        }
                        else if (Properties.Settings.Default.fileType == "jpg")
                        {
                            screenshotBitmap.Save(uniqueFileName, ImageFormat.Jpeg);
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
                catch (Exception ex)
                {
                    MessageBox.Show("Error capturing screenshot: " + ex.Message);
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                }
            }
            else
            {
                MessageBox.Show("No region selected.");
            }

            // Close the form after capturing the screenshot
            this.Close();
        }

        // Override the OnPaint method to draw the selection rectangle
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (isDragging)
            {
                using (Pen selectionPen = new Pen(Color.Red, 3))
                {
                    e.Graphics.DrawRectangle(selectionPen, selectionRectangle);
                }
            }
        }

        private void ScreenshotForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
