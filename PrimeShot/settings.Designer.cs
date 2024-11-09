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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ftpSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save screenshots to:";
            // 
            // savePath
            // 
            this.savePath.Location = new System.Drawing.Point(11, 21);
            this.savePath.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.savePath.Name = "savePath";
            this.savePath.ReadOnly = true;
            this.savePath.Size = new System.Drawing.Size(234, 20);
            this.savePath.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(247, 19);
            this.browse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(69, 21);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse...";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 42);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Upload to FTP server";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ftpSettings
            // 
            this.ftpSettings.Controls.Add(this.textBox1);
            this.ftpSettings.Controls.Add(this.server);
            this.ftpSettings.Location = new System.Drawing.Point(11, 61);
            this.ftpSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ftpSettings.Name = "ftpSettings";
            this.ftpSettings.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ftpSettings.Size = new System.Drawing.Size(306, 202);
            this.ftpSettings.TabIndex = 4;
            this.ftpSettings.TabStop = false;
            this.ftpSettings.Text = "FTP settings";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 36);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 1;
            // 
            // server
            // 
            this.server.AutoSize = true;
            this.server.Location = new System.Drawing.Point(15, 21);
            this.server.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(90, 13);
            this.server.TabIndex = 0;
            this.server.Text = "Server hostname:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 237);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save changes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Screenshot filetype:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "jpg",
            "png"});
            this.comboBox1.Location = new System.Drawing.Point(321, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 271);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ftpSettings);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.savePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}