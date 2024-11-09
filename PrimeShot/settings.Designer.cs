namespace PrimeShot
{
    partial class settings
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
            this.label1 = new System.Windows.Forms.Label();
            this.savePath = new System.Windows.Forms.TextBox();
            this.browse = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ftpSettings = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.server = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ftpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save screenshots to:";
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(16, 32);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(349, 26);
            this.savePath.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(371, 29);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(104, 33);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(16, 64);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(184, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Upload to FTP server";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ftpSettings
            // 
            this.ftpSettings.Controls.Add(this.textBox1);
            this.ftpSettings.Controls.Add(this.server);
            this.ftpSettings.Location = new System.Drawing.Point(16, 94);
            this.ftpSettings.Name = "ftpSettings";
            this.ftpSettings.Size = new System.Drawing.Size(459, 311);
            this.ftpSettings.TabIndex = 4;
            this.ftpSettings.TabStop = false;
            this.ftpSettings.Text = "FTP settings";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(26, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 26);
            this.textBox1.TabIndex = 1;
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Location = new System.Drawing.Point(22, 32);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(134, 20);
            this.server.TabIndex = 0;
            this.server.Text = "Server hostname:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(577, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ftpSettings);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "settings";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.settings_Load);
            this.ftpSettings.ResumeLayout(false);
            this.ftpSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox savePath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox ftpSettings;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label server;
        private System.Windows.Forms.Button button1;
    }
}