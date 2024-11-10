using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeShot
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Set save path to application user settings
            FolderBrowserDialog browserDialog = new FolderBrowserDialog();
            DialogResult result = browserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string selectedFolder = browserDialog.SelectedPath;
                Properties.Settings.Default.saveTo = selectedFolder;
                savePath.Text = selectedFolder;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Save application user settings
            Properties.Settings.Default.fileType = comboBox1.Text;
            Properties.Settings.Default.Save();
        }

        private void settings_Load(object sender, EventArgs e)
        {
            //Load save path from application user settings
            savePath.Text = Properties.Settings.Default.saveTo;
        }
    }
}
