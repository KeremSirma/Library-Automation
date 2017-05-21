namespace Library
{
    partial class MainForm
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
            this.btnReceiptBook = new System.Windows.Forms.Button();
            this.btnGive = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_BookList = new System.Windows.Forms.Button();
            this.btn_MemList = new System.Windows.Forms.Button();
            this.btn_MemRec = new System.Windows.Forms.Button();
            this.btn_BookRec = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBackupRestore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReceiptBook
            // 
            this.btnReceiptBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnReceiptBook.FlatAppearance.BorderSize = 0;
            this.btnReceiptBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnReceiptBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiptBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceiptBook.ForeColor = System.Drawing.Color.White;
            this.btnReceiptBook.Image = global::Library.Properties.Resources.book_previous_icon;
            this.btnReceiptBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReceiptBook.Location = new System.Drawing.Point(377, 238);
            this.btnReceiptBook.Name = "btnReceiptBook";
            this.btnReceiptBook.Size = new System.Drawing.Size(200, 45);
            this.btnReceiptBook.TabIndex = 32;
            this.btnReceiptBook.Text = "Kitap Teslim Al";
            this.btnReceiptBook.UseVisualStyleBackColor = false;
            this.btnReceiptBook.Click += new System.EventHandler(this.btnReceiptBook_Click);
            // 
            // btnGive
            // 
            this.btnGive.BackColor = System.Drawing.Color.DarkRed;
            this.btnGive.FlatAppearance.BorderSize = 0;
            this.btnGive.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnGive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGive.ForeColor = System.Drawing.Color.White;
            this.btnGive.Image = global::Library.Properties.Resources.book_go_icon;
            this.btnGive.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGive.Location = new System.Drawing.Point(165, 238);
            this.btnGive.Name = "btnGive";
            this.btnGive.Size = new System.Drawing.Size(200, 45);
            this.btnGive.TabIndex = 31;
            this.btnGive.Text = "Kitap Teslim Et";
            this.btnGive.UseVisualStyleBackColor = false;
            this.btnGive.Click += new System.EventHandler(this.btnGive_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.DarkRed;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Image = global::Library.Properties.Resources.blue_cross_icon;
            this.btn_exit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.Location = new System.Drawing.Point(377, 307);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 45);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Çıkış Yap";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_BookList
            // 
            this.btn_BookList.BackColor = System.Drawing.Color.DarkRed;
            this.btn_BookList.FlatAppearance.BorderSize = 0;
            this.btn_BookList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_BookList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BookList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BookList.ForeColor = System.Drawing.Color.White;
            this.btn_BookList.Image = global::Library.Properties.Resources.books_stack_icon;
            this.btn_BookList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BookList.Location = new System.Drawing.Point(165, 168);
            this.btn_BookList.Name = "btn_BookList";
            this.btn_BookList.Size = new System.Drawing.Size(198, 45);
            this.btn_BookList.TabIndex = 8;
            this.btn_BookList.Text = "Kitap Listesi";
            this.btn_BookList.UseVisualStyleBackColor = false;
            this.btn_BookList.Click += new System.EventHandler(this.btn_BookList_Click);
            // 
            // btn_MemList
            // 
            this.btn_MemList.BackColor = System.Drawing.Color.DarkRed;
            this.btn_MemList.FlatAppearance.BorderSize = 0;
            this.btn_MemList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_MemList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MemList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MemList.ForeColor = System.Drawing.Color.White;
            this.btn_MemList.Image = global::Library.Properties.Resources.users_icon;
            this.btn_MemList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemList.Location = new System.Drawing.Point(377, 168);
            this.btn_MemList.Name = "btn_MemList";
            this.btn_MemList.Size = new System.Drawing.Size(200, 45);
            this.btn_MemList.TabIndex = 7;
            this.btn_MemList.Text = "Üye Liste";
            this.btn_MemList.UseVisualStyleBackColor = false;
            this.btn_MemList.Click += new System.EventHandler(this.btn_MemList_Click);
            // 
            // btn_MemRec
            // 
            this.btn_MemRec.BackColor = System.Drawing.Color.DarkRed;
            this.btn_MemRec.FlatAppearance.BorderSize = 0;
            this.btn_MemRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_MemRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MemRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MemRec.ForeColor = System.Drawing.Color.White;
            this.btn_MemRec.Image = global::Library.Properties.Resources.Icojam_Blue_Bits_User_add;
            this.btn_MemRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemRec.Location = new System.Drawing.Point(377, 98);
            this.btn_MemRec.Name = "btn_MemRec";
            this.btn_MemRec.Size = new System.Drawing.Size(200, 45);
            this.btn_MemRec.TabIndex = 6;
            this.btn_MemRec.Text = "Üye Kayıt";
            this.btn_MemRec.UseVisualStyleBackColor = false;
            this.btn_MemRec.Click += new System.EventHandler(this.btn_MemRec_Click);
            // 
            // btn_BookRec
            // 
            this.btn_BookRec.BackColor = System.Drawing.Color.DarkRed;
            this.btn_BookRec.FlatAppearance.BorderSize = 0;
            this.btn_BookRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_BookRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BookRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_BookRec.ForeColor = System.Drawing.Color.White;
            this.btn_BookRec.Image = global::Library.Properties.Resources.book_add_icon;
            this.btn_BookRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BookRec.Location = new System.Drawing.Point(165, 98);
            this.btn_BookRec.Name = "btn_BookRec";
            this.btn_BookRec.Size = new System.Drawing.Size(198, 45);
            this.btn_BookRec.TabIndex = 5;
            this.btn_BookRec.Text = "Kitap Kayıt";
            this.btn_BookRec.UseVisualStyleBackColor = false;
            this.btn_BookRec.Click += new System.EventHandler(this.btn_BookRec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Library.Properties.Resources.gop_logo;
            this.pictureBox1.Location = new System.Drawing.Point(147, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Library.Properties.Resources.Facebook_create;
            this.pictureBox2.Location = new System.Drawing.Point(305, 418);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = global::Library.Properties.Resources.twitter_logo;
            this.pictureBox3.Location = new System.Drawing.Point(478, 418);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(119, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // btnBackupRestore
            // 
            this.btnBackupRestore.BackColor = System.Drawing.Color.DarkRed;
            this.btnBackupRestore.FlatAppearance.BorderSize = 0;
            this.btnBackupRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnBackupRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBackupRestore.ForeColor = System.Drawing.Color.White;
            this.btnBackupRestore.Image = global::Library.Properties.Resources.books_stack_icon;
            this.btnBackupRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBackupRestore.Location = new System.Drawing.Point(165, 307);
            this.btnBackupRestore.Name = "btnBackupRestore";
            this.btnBackupRestore.Size = new System.Drawing.Size(200, 45);
            this.btnBackupRestore.TabIndex = 36;
            this.btnBackupRestore.Text = "Yedekle/Geri Yükle";
            this.btnBackupRestore.UseVisualStyleBackColor = false;
            this.btnBackupRestore.Click += new System.EventHandler(this.btnBackupRestore_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.Ekran_Alıntısı;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(726, 510);
            this.ControlBox = false;
            this.Controls.Add(this.btnBackupRestore);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnReceiptBook);
            this.Controls.Add(this.btnGive);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_BookList);
            this.Controls.Add(this.btn_MemList);
            this.Controls.Add(this.btn_MemRec);
            this.Controls.Add(this.btn_BookRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_BookList;
        private System.Windows.Forms.Button btn_MemList;
        private System.Windows.Forms.Button btn_MemRec;
        private System.Windows.Forms.Button btn_BookRec;
        private System.Windows.Forms.Button btnGive;
        private System.Windows.Forms.Button btnReceiptBook;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnBackupRestore;
    }
}