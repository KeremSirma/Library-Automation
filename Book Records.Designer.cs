namespace Library
{
    partial class Book_Records
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdBook = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btn_BookRec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtOku = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtSummary = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 351);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(725, 204);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(110, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Tür";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(110, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Sayfa Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(110, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Yazar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(110, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kitap Adı";
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.SystemColors.Info;
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtType.Location = new System.Drawing.Point(233, 268);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(128, 23);
            this.txtType.TabIndex = 17;
            this.txtType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtType_KeyPress);
            // 
            // txtPage
            // 
            this.txtPage.BackColor = System.Drawing.SystemColors.Info;
            this.txtPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPage.Location = new System.Drawing.Point(233, 217);
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(128, 23);
            this.txtPage.TabIndex = 16;
            this.txtPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPage_KeyPress);
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Info;
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAuthor.Location = new System.Drawing.Point(233, 170);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(128, 23);
            this.txtAuthor.TabIndex = 15;
            this.txtAuthor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAuthor_KeyPress);
            // 
            // txtBookName
            // 
            this.txtBookName.BackColor = System.Drawing.SystemColors.Info;
            this.txtBookName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtBookName.Location = new System.Drawing.Point(233, 125);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(128, 23);
            this.txtBookName.TabIndex = 14;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Kürk Mantolu Madonna",
            "Uçurtma Avcısı",
            "Suç ve Ceza",
            "Simyacı",
            "Şeker Portakalı",
            "Diriliş",
            "Vadideki Zambak",
            "Bülbülü Öldürmek",
            "İki Esir",
            "Budala",
            "Zamanımızın Bir Kahramanı",
            "Dorian Gray\'in Portresi ",
            "İki Şehrin Hikayesi",
            "Garcia\'ya Mektup",
            "Ateş Suyu",
            "Savaş Yolu",
            "Büyük Tuzak",
            "Gölge Adam",
            "Zehirli Balta",
            "Gemi Avcıları",
            "Vudu İntikamı",
            "Cheyenne Kanı",
            "Anket Tokmakçısı",
            "Veronika Ölmek İstiyor",
            "Kiraze",
            "Üç Aynalı Kırk Oda",
            "Çocukluğum",
            "Bir Reklamcının İtirafları",
            "Fotoğraflar Siyah Beyaz Anılar Renkli",
            "Şeytan",
            "Hayat Roman",
            "Mavi Saçlı Kız",
            "Kristal Denizaltı",
            "Martin Eden",
            "Kara Kitap",
            "Tol",
            "Sattleri Ayarlama Enstitüsü",
            "Pinhan",
            "Veba",
            "Dorian Gray\'in Portresi",
            "Suskunlar",
            "Benim Adım Kırmızı",
            "Savaş Ve Barış",
            "Gülün Adı",
            "Yüzüklerin Efendisi Serisi",
            "Savaş Ve Barış",
            "Sineklerin Tanrısı",
            "1984",
            "Puslu Kıtalar Atlası",
            "Gülüşün Ve Unutuşun Kitabı",
            "Şibumi",
            "Yabancı",
            "Çalıkuşu",
            "Kpss Genel Yetenek Genel Kültür Türkçe",
            "Kpss Genel Yetenek Genel Kültür Matematik",
            "Kpss Genel Yetenek Genel Kültür Vatandaşlık Bilgisi",
            "Kpss Genel Yetenek Genel Kültür Tarih",
            "Mahallenin En Şık Abileri",
            "Ölü Canlar",
            "Spor Bir Hikayedir"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearch.Location = new System.Drawing.Point(532, 36);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(139, 23);
            this.txtSearch.TabIndex = 26;
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkRed;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = global::Library.Properties.Resources.books_stack_icon;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(56, 300);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(170, 45);
            this.btnList.TabIndex = 30;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.DarkRed;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Image = global::Library.Properties.Resources.book_go_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.Location = new System.Drawing.Point(690, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(99, 32);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Ara";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdBook
            // 
            this.btnUpdBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnUpdBook.FlatAppearance.BorderSize = 0;
            this.btnUpdBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnUpdBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdBook.ForeColor = System.Drawing.Color.White;
            this.btnUpdBook.Image = global::Library.Properties.Resources.book_edit_icon;
            this.btnUpdBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdBook.Location = new System.Drawing.Point(611, 300);
            this.btnUpdBook.Name = "btnUpdBook";
            this.btnUpdBook.Size = new System.Drawing.Size(170, 45);
            this.btnUpdBook.TabIndex = 25;
            this.btnUpdBook.Text = "Kitap Güncelle";
            this.btnUpdBook.UseVisualStyleBackColor = false;
            this.btnUpdBook.Click += new System.EventHandler(this.btnUpdBook_Click);
            // 
            // btnDelBook
            // 
            this.btnDelBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelBook.FlatAppearance.BorderSize = 0;
            this.btnDelBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnDelBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelBook.ForeColor = System.Drawing.Color.White;
            this.btnDelBook.Image = global::Library.Properties.Resources.book_delete_icon;
            this.btnDelBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelBook.Location = new System.Drawing.Point(435, 300);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(170, 45);
            this.btnDelBook.TabIndex = 24;
            this.btnDelBook.Text = "Kitap Sil";
            this.btnDelBook.UseVisualStyleBackColor = false;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
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
            this.btn_BookRec.Location = new System.Drawing.Point(232, 300);
            this.btn_BookRec.Name = "btn_BookRec";
            this.btn_BookRec.Size = new System.Drawing.Size(170, 45);
            this.btn_BookRec.TabIndex = 12;
            this.btn_BookRec.Text = "Kaydet";
            this.btn_BookRec.UseVisualStyleBackColor = false;
            this.btn_BookRec.Click += new System.EventHandler(this.btn_BookRec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(583, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Kitap Özeti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(451, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Kitap Ara";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Library.Properties.Resources.book_add_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(81, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 42);
            this.button1.TabIndex = 36;
            this.button1.Text = "Resim Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(268, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(392, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(10, 20);
            this.textBox1.TabIndex = 38;
            this.textBox1.Visible = false;
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
            this.txtOku.Location = new System.Drawing.Point(682, 80);
            this.txtOku.Name = "txtOku";
            this.txtOku.Size = new System.Drawing.Size(75, 32);
            this.txtOku.TabIndex = 40;
            this.txtOku.Text = "Oku";
            this.txtOku.UseVisualStyleBackColor = false;
            this.txtOku.Click += new System.EventHandler(this.txtOku_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(182, 339);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(489, 241);
            this.webBrowser1.TabIndex = 41;
            this.webBrowser1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtSummary
            // 
            this.txtSummary.BackColor = System.Drawing.SystemColors.Info;
            this.txtSummary.Location = new System.Drawing.Point(490, 123);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(267, 171);
            this.txtSummary.TabIndex = 42;
            this.txtSummary.Text = "";
            this.txtSummary.TextChanged += new System.EventHandler(this.txtSummary_TextChanged_1);
            // 
            // Book_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.bookrec;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 579);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.txtOku);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnUpdBook);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.btn_BookRec);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Book_Records";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Records";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Book_Records_FormClosed);
            this.Load += new System.EventHandler(this.Book_Records_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Button btn_BookRec;

        private System.Windows.Forms.Button btnUpdBook;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button txtOku;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox txtSummary;
    }
}