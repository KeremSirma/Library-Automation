namespace Library
{
    partial class MainLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLogin));
            this.btnMemberLog = new System.Windows.Forms.Button();
            this.btnAdminLog = new System.Windows.Forms.Button();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMemberLog
            // 
            this.btnMemberLog.Location = new System.Drawing.Point(135, 145);
            this.btnMemberLog.Name = "btnMemberLog";
            this.btnMemberLog.Size = new System.Drawing.Size(130, 50);
            this.btnMemberLog.TabIndex = 0;
            this.btnMemberLog.Text = "Üye Girişi";
            this.btnMemberLog.UseVisualStyleBackColor = true;
            this.btnMemberLog.Click += new System.EventHandler(this.btnMemberLog_Click);
            // 
            // btnAdminLog
            // 
            this.btnAdminLog.Location = new System.Drawing.Point(135, 218);
            this.btnAdminLog.Name = "btnAdminLog";
            this.btnAdminLog.Size = new System.Drawing.Size(130, 50);
            this.btnAdminLog.TabIndex = 1;
            this.btnAdminLog.Text = "Yönetici Girişi";
            this.btnAdminLog.UseVisualStyleBackColor = true;
            this.btnAdminLog.Click += new System.EventHandler(this.btnAdminLog_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(107, 4);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(187, 128);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 23;
            this.pictureBox9.TabStop = false;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.blogbackground11;
            this.ClientSize = new System.Drawing.Size(399, 276);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.btnAdminLog);
            this.Controls.Add(this.btnMemberLog);
            this.Name = "MainLogin";
            this.Text = "MainLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMemberLog;
        private System.Windows.Forms.Button btnAdminLog;
        private System.Windows.Forms.PictureBox pictureBox9;
    }
}