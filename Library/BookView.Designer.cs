namespace Library
{
    partial class BookView
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
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPageNumber = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtOku = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.BackColor = System.Drawing.Color.Transparent;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookName.Location = new System.Drawing.Point(242, 80);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(52, 17);
            this.lblBookName.TabIndex = 1;
            this.lblBookName.Text = "label1";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Location = new System.Drawing.Point(242, 131);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(52, 17);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "label2";
            // 
            // lblPageNumber
            // 
            this.lblPageNumber.AutoSize = true;
            this.lblPageNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPageNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPageNumber.Location = new System.Drawing.Point(242, 184);
            this.lblPageNumber.Name = "lblPageNumber";
            this.lblPageNumber.Size = new System.Drawing.Size(52, 17);
            this.lblPageNumber.TabIndex = 3;
            this.lblPageNumber.Text = "label3";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.BackColor = System.Drawing.Color.Transparent;
            this.lblType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblType.Location = new System.Drawing.Point(242, 230);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(52, 17);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "label4";
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.SystemColors.Info;
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSummary.ForeColor = System.Drawing.Color.Black;
            this.txtSummary.Location = new System.Drawing.Point(529, 12);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(403, 301);
            this.txtSummary.TabIndex = 5;
            this.txtSummary.Text = "";
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtOku
            // 
            this.txtOku.BackColor = System.Drawing.Color.DarkRed;
            this.txtOku.FlatAppearance.BorderSize = 0;
            this.txtOku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.txtOku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtOku.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOku.ForeColor = System.Drawing.Color.White;
            this.txtOku.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txtOku.Location = new System.Drawing.Point(317, 264);
            this.txtOku.Name = "txtOku";
            this.txtOku.Size = new System.Drawing.Size(143, 49);
            this.txtOku.TabIndex = 41;
            this.txtOku.Text = "Sesli Oku";
            this.txtOku.UseVisualStyleBackColor = false;
            this.txtOku.Click += new System.EventHandler(this.txtOku_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(631, 167);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(31, 34);
            this.webBrowser1.TabIndex = 42;
            // 
            // BookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.Ekran_Alıntısı1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 336);
            this.Controls.Add(this.txtOku);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblPageNumber);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webBrowser1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimizeBox = false;
            this.Name = "BookView";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookView";
            this.Load += new System.EventHandler(this.BookView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPageNumber;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RichTextBox txtSummary;
        private System.Windows.Forms.Button txtOku;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}