namespace Library
{
    partial class List_Of_Book
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
            this.btnUpdBook = new System.Windows.Forms.Button();
            this.btnDelBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.btnUpdBook.Location = new System.Drawing.Point(335, 12);
            this.btnUpdBook.Name = "btnUpdBook";
            this.btnUpdBook.Size = new System.Drawing.Size(180, 62);
            this.btnUpdBook.TabIndex = 7;
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
            this.btnDelBook.Location = new System.Drawing.Point(179, 12);
            this.btnDelBook.Name = "btnDelBook";
            this.btnDelBook.Size = new System.Drawing.Size(150, 62);
            this.btnDelBook.TabIndex = 6;
            this.btnDelBook.Text = "Kitap Sil";
            this.btnDelBook.UseVisualStyleBackColor = false;
            this.btnDelBook.Click += new System.EventHandler(this.btnDelBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.DarkRed;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.Image = global::Library.Properties.Resources.book_add_icon;
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.Location = new System.Drawing.Point(12, 12);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(164, 62);
            this.btnAddBook.TabIndex = 5;
            this.btnAddBook.Text = "Kitap Ekle";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkRed;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(521, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 62);
            this.button2.TabIndex = 32;
            this.button2.Text = "Bu Kitap Nerede ?";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(656, 12);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 62);
            this.button1.TabIndex = 38;
            this.button1.Text = "Teslime Kalan Gün Sayısı";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(834, 339);
            this.dataGridView1.TabIndex = 39;
            // 
            // List_Of_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.Ekran_Alıntısı1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 436);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnUpdBook);
            this.Controls.Add(this.btnDelBook);
            this.Controls.Add(this.btnAddBook);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "List_Of_Book";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List_Of_Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.List_Of_Book_FormClosed);
            this.Load += new System.EventHandler(this.List_Of_Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUpdBook;
        private System.Windows.Forms.Button btnDelBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button button2;
        
        
        
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}