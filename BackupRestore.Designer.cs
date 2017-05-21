namespace Library
{
    partial class BackupRestore
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
            this.Restore = new System.Windows.Forms.GroupBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestoreBrowse = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.Restore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Restore
            // 
            this.Restore.BackColor = System.Drawing.Color.Transparent;
            this.Restore.Controls.Add(this.btnRestore);
            this.Restore.Controls.Add(this.btnRestoreBrowse);
            this.Restore.Controls.Add(this.textBox4);
            this.Restore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Restore.ForeColor = System.Drawing.Color.Gold;
            this.Restore.Location = new System.Drawing.Point(12, 202);
            this.Restore.Name = "Restore";
            this.Restore.Size = new System.Drawing.Size(548, 156);
            this.Restore.TabIndex = 3;
            this.Restore.TabStop = false;
            this.Restore.Text = "Backup Restore";
            // 
            // btnRestore
            // 
            this.btnRestore.BackColor = System.Drawing.Color.DarkRed;
            this.btnRestore.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestore.FlatAppearance.BorderSize = 3;
            this.btnRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestore.Location = new System.Drawing.Point(428, 57);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(100, 30);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Geri Yükle";
            this.btnRestore.UseVisualStyleBackColor = false;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnRestoreBrowse
            // 
            this.btnRestoreBrowse.BackColor = System.Drawing.Color.DarkRed;
            this.btnRestoreBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRestoreBrowse.FlatAppearance.BorderSize = 3;
            this.btnRestoreBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnRestoreBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreBrowse.Location = new System.Drawing.Point(428, 28);
            this.btnRestoreBrowse.Name = "btnRestoreBrowse";
            this.btnRestoreBrowse.Size = new System.Drawing.Size(100, 30);
            this.btnRestoreBrowse.TabIndex = 2;
            this.btnRestoreBrowse.Text = "Gözat";
            this.btnRestoreBrowse.UseVisualStyleBackColor = false;
            this.btnRestoreBrowse.Click += new System.EventHandler(this.btnRestoreBrowse_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(139, 31);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(271, 23);
            this.textBox4.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnBackup);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // btnBackup
            // 
            this.btnBackup.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackup.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBackup.FlatAppearance.BorderSize = 3;
            this.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackup.Location = new System.Drawing.Point(428, 73);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(100, 30);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = false;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(139, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 23);
            this.textBox1.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkRed;
            this.btnBrowse.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBrowse.FlatAppearance.BorderSize = 3;
            this.btnBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(428, 36);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Gözat";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // BackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.server;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 374);
            this.Controls.Add(this.Restore);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackupRestore";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BackupRestore_FormClosed);
            this.Load += new System.EventHandler(this.BackupRestore_Load);
            this.Restore.ResumeLayout(false);
            this.Restore.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Restore;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestoreBrowse;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox textBox1;
    }
}