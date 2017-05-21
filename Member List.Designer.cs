namespace Library
{
    partial class Member_List
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnMembers = new System.Windows.Forms.Button();
            this.btn_MemberDel = new System.Windows.Forms.Button();
            this.btn_MemberUpd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(674, 255);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 62);
            this.button1.TabIndex = 11;
            this.button1.Text = "Profili Gör";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMembers
            // 
            this.btnMembers.BackColor = System.Drawing.Color.DarkRed;
            this.btnMembers.FlatAppearance.BorderSize = 0;
            this.btnMembers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMembers.ForeColor = System.Drawing.Color.White;
            this.btnMembers.Image = global::Library.Properties.Resources.user_add_icon;
            this.btnMembers.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMembers.Location = new System.Drawing.Point(182, 9);
            this.btnMembers.Name = "btnMembers";
            this.btnMembers.Size = new System.Drawing.Size(164, 62);
            this.btnMembers.TabIndex = 10;
            this.btnMembers.Text = "Üye Ekle";
            this.btnMembers.UseVisualStyleBackColor = false;
            this.btnMembers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_MemberDel
            // 
            this.btn_MemberDel.BackColor = System.Drawing.Color.DarkRed;
            this.btn_MemberDel.FlatAppearance.BorderSize = 0;
            this.btn_MemberDel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_MemberDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MemberDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MemberDel.ForeColor = System.Drawing.Color.White;
            this.btn_MemberDel.Image = global::Library.Properties.Resources.user_delete_icon;
            this.btn_MemberDel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemberDel.Location = new System.Drawing.Point(522, 9);
            this.btn_MemberDel.Name = "btn_MemberDel";
            this.btn_MemberDel.Size = new System.Drawing.Size(164, 62);
            this.btn_MemberDel.TabIndex = 8;
            this.btn_MemberDel.Text = "Üye Sil";
            this.btn_MemberDel.UseVisualStyleBackColor = false;
            this.btn_MemberDel.Click += new System.EventHandler(this.btn_MemberDel_Click);
            // 
            // btn_MemberUpd
            // 
            this.btn_MemberUpd.BackColor = System.Drawing.Color.DarkRed;
            this.btn_MemberUpd.FlatAppearance.BorderSize = 0;
            this.btn_MemberUpd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btn_MemberUpd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MemberUpd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_MemberUpd.ForeColor = System.Drawing.Color.White;
            this.btn_MemberUpd.Image = global::Library.Properties.Resources.user_settings_icon;
            this.btn_MemberUpd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MemberUpd.Location = new System.Drawing.Point(352, 9);
            this.btn_MemberUpd.Name = "btn_MemberUpd";
            this.btn_MemberUpd.Size = new System.Drawing.Size(164, 62);
            this.btn_MemberUpd.TabIndex = 7;
            this.btn_MemberUpd.Text = "Üye Güncelle";
            this.btn_MemberUpd.UseVisualStyleBackColor = false;
            this.btn_MemberUpd.Click += new System.EventHandler(this.btn_MemberUpd_Click);
            // 
            // Member_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Library.Properties.Resources.Ekran_Alıntısı1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(698, 356);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnMembers);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_MemberDel);
            this.Controls.Add(this.btn_MemberUpd);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Member_List";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member_List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Member_List_FormClosed);
            this.Load += new System.EventHandler(this.Member_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_MemberDel;
        private System.Windows.Forms.Button btn_MemberUpd;
        
        private System.Windows.Forms.Button btnMembers;
       
       
        private System.Windows.Forms.Button button1;
    }
}