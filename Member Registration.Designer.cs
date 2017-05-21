namespace Library
{
    partial class Member_Registration
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnList = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.Şifre = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnMemberDel = new System.Windows.Forms.Button();
            this.btnMemberUpd = new System.Windows.Forms.Button();
            this.btnRec = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMemberSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rdbtnad = new System.Windows.Forms.RadioButton();
            this.rdbtnuye = new System.Windows.Forms.RadioButton();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(317, 30);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(624, 395);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.DarkRed;
            this.btnList.FlatAppearance.BorderSize = 0;
            this.btnList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Image = global::Library.Properties.Resources.users_icon;
            this.btnList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnList.Location = new System.Drawing.Point(44, 329);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(120, 45);
            this.btnList.TabIndex = 28;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(54, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mail : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(54, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Telefon : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(54, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Adres : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adı : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "TC No : ";
            // 
            // txtMail
            // 
            this.txtMail.BackColor = System.Drawing.SystemColors.Info;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(153, 237);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(158, 23);
            this.txtMail.TabIndex = 19;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Info;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAddress.Location = new System.Drawing.Point(153, 117);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(158, 85);
            this.txtAddress.TabIndex = 17;
            // 
            // txtMemberName
            // 
            this.txtMemberName.BackColor = System.Drawing.SystemColors.Info;
            this.txtMemberName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMemberName.Location = new System.Drawing.Point(153, 59);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(158, 23);
            this.txtMemberName.TabIndex = 16;
            this.txtMemberName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberName_KeyPress);
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTcNo.Location = new System.Drawing.Point(153, 30);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(158, 23);
            this.txtTcNo.TabIndex = 15;
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // Şifre
            // 
            this.Şifre.AutoSize = true;
            this.Şifre.BackColor = System.Drawing.Color.Transparent;
            this.Şifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Şifre.Location = new System.Drawing.Point(54, 269);
            this.Şifre.Name = "Şifre";
            this.Şifre.Size = new System.Drawing.Size(57, 17);
            this.Şifre.TabIndex = 31;
            this.Şifre.Text = "Şifre : ";
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.SystemColors.Info;
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPass.Location = new System.Drawing.Point(153, 266);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(158, 23);
            this.txtPass.TabIndex = 30;
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            // 
            // btnMemberDel
            // 
            this.btnMemberDel.BackColor = System.Drawing.Color.DarkRed;
            this.btnMemberDel.FlatAppearance.BorderSize = 0;
            this.btnMemberDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnMemberDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemberDel.ForeColor = System.Drawing.Color.White;
            this.btnMemberDel.Image = global::Library.Properties.Resources.user_delete_icon;
            this.btnMemberDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMemberDel.Location = new System.Drawing.Point(44, 380);
            this.btnMemberDel.Name = "btnMemberDel";
            this.btnMemberDel.Size = new System.Drawing.Size(120, 45);
            this.btnMemberDel.TabIndex = 32;
            this.btnMemberDel.Text = "Sil";
            this.btnMemberDel.UseVisualStyleBackColor = false;
            this.btnMemberDel.Click += new System.EventHandler(this.btnMemberDel_Click);
            // 
            // btnMemberUpd
            // 
            this.btnMemberUpd.BackColor = System.Drawing.Color.DarkRed;
            this.btnMemberUpd.FlatAppearance.BorderSize = 0;
            this.btnMemberUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnMemberUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemberUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMemberUpd.ForeColor = System.Drawing.Color.White;
            this.btnMemberUpd.Image = global::Library.Properties.Resources.user_settings_icon;
            this.btnMemberUpd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMemberUpd.Location = new System.Drawing.Point(191, 380);
            this.btnMemberUpd.Name = "btnMemberUpd";
            this.btnMemberUpd.Size = new System.Drawing.Size(120, 45);
            this.btnMemberUpd.TabIndex = 33;
            this.btnMemberUpd.Text = "Güncelle";
            this.btnMemberUpd.UseVisualStyleBackColor = false;
            this.btnMemberUpd.Click += new System.EventHandler(this.btnMemberUpd_Click);
            // 
            // btnRec
            // 
            this.btnRec.BackColor = System.Drawing.Color.DarkRed;
            this.btnRec.FlatAppearance.BorderSize = 0;
            this.btnRec.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRec.ForeColor = System.Drawing.Color.White;
            this.btnRec.Image = global::Library.Properties.Resources.user_add_icon;
            this.btnRec.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRec.Location = new System.Drawing.Point(191, 329);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(120, 45);
            this.btnRec.TabIndex = 27;
            this.btnRec.Text = "Kaydet";
            this.btnRec.UseVisualStyleBackColor = false;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(54, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Soyad : ";
            // 
            // txtMemberSurname
            // 
            this.txtMemberSurname.BackColor = System.Drawing.SystemColors.Info;
            this.txtMemberSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMemberSurname.Location = new System.Drawing.Point(153, 88);
            this.txtMemberSurname.Name = "txtMemberSurname";
            this.txtMemberSurname.Size = new System.Drawing.Size(158, 23);
            this.txtMemberSurname.TabIndex = 34;
            this.txtMemberSurname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMemberSurname_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(54, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "Yetki : ";
            // 
            // rdbtnad
            // 
            this.rdbtnad.AutoSize = true;
            this.rdbtnad.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnad.Location = new System.Drawing.Point(153, 303);
            this.rdbtnad.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnad.Name = "rdbtnad";
            this.rdbtnad.Size = new System.Drawing.Size(70, 21);
            this.rdbtnad.TabIndex = 38;
            this.rdbtnad.TabStop = true;
            this.rdbtnad.Text = "Admin";
            this.rdbtnad.UseVisualStyleBackColor = false;
            // 
            // rdbtnuye
            // 
            this.rdbtnuye.AutoSize = true;
            this.rdbtnuye.BackColor = System.Drawing.Color.Transparent;
            this.rdbtnuye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtnuye.Location = new System.Drawing.Point(257, 303);
            this.rdbtnuye.Margin = new System.Windows.Forms.Padding(2);
            this.rdbtnuye.Name = "rdbtnuye";
            this.rdbtnuye.Size = new System.Drawing.Size(54, 21);
            this.rdbtnuye.TabIndex = 39;
            this.rdbtnuye.TabStop = true;
            this.rdbtnuye.Text = "Üye";
            this.rdbtnuye.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Info;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPhone.Location = new System.Drawing.Point(153, 208);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(158, 23);
            this.txtPhone.TabIndex = 40;
            // 
            // Member_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.Ekran_Alıntısı1;
            this.ClientSize = new System.Drawing.Size(953, 437);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.rdbtnuye);
            this.Controls.Add(this.rdbtnad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMemberSurname);
            this.Controls.Add(this.btnMemberUpd);
            this.Controls.Add(this.btnMemberDel);
            this.Controls.Add(this.Şifre);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.txtTcNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Member_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member_Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Member_Registration_FormClosed);
            this.Load += new System.EventHandler(this.Member_Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label Şifre;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnMemberDel;
        private System.Windows.Forms.Button btnMemberUpd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMemberSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rdbtnad;
        private System.Windows.Forms.RadioButton rdbtnuye;
        private System.Windows.Forms.MaskedTextBox txtPhone;
    }
}