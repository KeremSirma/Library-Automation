using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.Mail;

namespace Library
{
    public partial class Member_Registration : Form
    {
        public Member_Registration()
        {
            InitializeComponent();
        }

        public void Member_Registration_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];

        }

        private void btnRec_Click(object sender, EventArgs e)
        {
            try
            {
            string metin = Convert.ToString(txtMail.Text);
            int i = metin.IndexOf("@"); //indexof,aranan karakterin indeksini döndürür
            string tckimlik;
            tckimlik = txtTcNo.Text;
            int index = 0;
            int toplam = 0;
            foreach (char n in tckimlik)
            {
                if (index < 10)
                {
                    toplam += Convert.ToInt32(char.ToString(n));
                }
                index++;
            }
            if (toplam % 10 != Convert.ToInt32(tckimlik[10].ToString())||string.IsNullOrWhiteSpace(txtMemberName.Text) || string.IsNullOrWhiteSpace(txtMemberSurname.Text) || string.IsNullOrWhiteSpace(txtTcNo.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
                    {
                        MessageBox.Show("Geçersiz TC Kimlik Numarası veya Alanlar Boş !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                else if (i == -1) //eğer yoksa -1 döndürür
                {
                    MessageBox.Show("Lütfen mail formatına uygun bir mail adresi giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                            
                            SqlCommand cmd = new SqlCommand("INSERT INTO UserTb (Tc,Name,LastName,Location,Phone,Mail,Password,Authority) VALUES (@tc,@name,@lastname,@location,@phone,@mail,@pass,@aut)", tools.Con);
                            if (txtTcNo.Text == dataGridView1.CurrentRow.Cells[1].Value.ToString())
                            {
                                MessageBox.Show("Böyle bir tc kimlik no ile kullanıcı zaten mevcut");
                            }
                            else
                            {

                                cmd.Parameters.AddWithValue("@tc", txtTcNo.Text);
                                cmd.Parameters.AddWithValue("@name", txtMemberName.Text);
                                cmd.Parameters.AddWithValue("@lastname", txtMemberSurname.Text);
                                cmd.Parameters.AddWithValue("@location", txtAddress.Text);
                                cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                                cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                                cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                                MailMessage mail = new MailMessage();
                                SmtpClient server = new SmtpClient();
                                server.Credentials = new System.Net.NetworkCredential("belediyegop@gmail.com", "gop123456");
                                server.Port = 587;
                                server.Host = "smtp.gmail.com";
                                server.EnableSsl = true;
                                mail.To.Add(txtMail.Text);
                                mail.From = new MailAddress("belediyegop@gmail.com");
                                mail.Subject = "Gaziosmapaşa Belediyesi Kütüphane";
                                mail.Body = "Sayın" + " " + txtMemberName.Text.ToString() + " " + txtMemberSurname.Text.ToString() + " " + "Gaziosmapaşa Belediyesi Kütüphane Giriş Şifresi" + " " + txtPass.Text.ToString() + " " + "ile giriş Yapabilirsiniz.";
                                server.Send(mail);
                                MessageBox.Show(txtMemberName.Text + " " + txtMemberSurname.Text + " Tc Kimlik Numaranız ve " + txtPass.Text + " şifrenizle giriş yapabilirsiniz.");  
                                if (rdbtnad.Checked == true)
                                {
                                    cmd.Parameters.AddWithValue("@aut", "True");
                                    cmd.ExecuteNonQuery();
                                    dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];

                                }
                                else if (rdbtnuye.Checked == true)
                                {

                                    cmd.Parameters.AddWithValue("@aut", "False");
                                    cmd.ExecuteNonQuery();
                                    dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];

                                }
                                dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                                MessageBox.Show("Eklendi.");
                                tools.Con.Close();
                            }
                        }

                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }

        }


        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];

        }

        private void btnMemberDel_Click(object sender, EventArgs e)
        {
            try
            {

                // bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
                SqlCommand cmd = new SqlCommand("DELETE FROM UserTb WHERE Id=@id", tools.Con);


                // Fare ile seçili satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);


                // Bağlantı kapalı ise açılır:
                if (tools.Con.State == ConnectionState.Closed)
                {
                    tools.Con.Open();
                }


                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                tools.Con.Close();


                dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];


                // Silindi mesajı gösterilir:
                MessageBox.Show("Silindi.");
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {
                MessageBox.Show("Hata olustu!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMemberUpd_Click(object sender, EventArgs e)
        {
            if (tools.Con.State == ConnectionState.Closed)
            {
                tools.Con.Open();
            }
            string tckimlik;

            try
            {
                tckimlik = txtTcNo.Text.ToString();
                int index = 0;
                int toplam = 0;
                foreach (char n in tckimlik)
                {
                    if (index < 10)
                    {
                        toplam += Convert.ToInt32(char.ToString(n));
                    }
                    index++;
                }
                if (toplam % 10 != Convert.ToInt32(tckimlik[10].ToString()))
                {
                    MessageBox.Show("Geçersiz TC Kimlik Numarası");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Girdiğiniz Tc Kimlik Numarası 11 Haneli Değil");
            }
            string metin = Convert.ToString(txtMail.Text);
            int i = metin.IndexOf("@"); //indexof,aranan karakterin indeksini döndürür
            if (i == -1) //eğer yoksa -1 döndürür
            {
                MessageBox.Show("Lütfen mail formatına uygun bir mail adresi giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtMemberName.Text) || string.IsNullOrWhiteSpace(txtMemberSurname.Text) || string.IsNullOrWhiteSpace(txtTcNo.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtMail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
                {
                    MessageBox.Show("Alanlar Boş Geçilemez !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                    SqlCommand Cmd = new SqlCommand("UPDATE UserTb SET Tc=@tc,Name=@name,Lastname=@last,Location=@location, Phone=@phone,Mail=@mail,Password=@pass,Authority=@aut WHERE Id = @id", tools.Con);
                    // SqlCommand Cmd="UPDATE UserTb SET Tc='" + txtTcNo.Text + "',stokModeli='" + txtMemberName.Text + "',stokSeriNo='" + txtMemberSurname.Text + "',stokAdedi='" + txtAddress.Text + "',stokTarih='" + txtPhone.Text + "',kayitYapan='" + txtMail.Text + "',dosyaAdi='" + txtPass.Text + "' WHERE Tc=" + tc
                    // Fare ile seçilmiş satırın değeri @id'ye aktarılır:
                    Cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    Cmd.Parameters.AddWithValue("@tc", txtTcNo.Text);
                    Cmd.Parameters.AddWithValue("@name", txtMemberName.Text);
                    Cmd.Parameters.AddWithValue("@last", txtMemberSurname.Text);
                    Cmd.Parameters.AddWithValue("@location", txtAddress.Text);
                    Cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    Cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                    Cmd.Parameters.AddWithValue("@pass", txtPass.Text);



                    if (rdbtnad.Checked == true)
                    {
                        Cmd.Parameters.AddWithValue("@aut", "True");
                        Cmd.ExecuteNonQuery();
                        //sqlcom.ExecuteNonQuery();
                        dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        MessageBox.Show("Güncellendi.");

                        tools.Con.Close();
                    }
                    else if (rdbtnuye.Checked == true)
                    {
                        Cmd.Parameters.AddWithValue("@aut", "False");
                        Cmd.ExecuteNonQuery();
                        //sqlcom.ExecuteNonQuery();
                        dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        MessageBox.Show("Güncellendi.");

                        tools.Con.Close();
                    }
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMail.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtPhone.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAddress.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtPass.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtMemberSurname.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMemberName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTcNo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void txtMemberSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void Member_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }

    }
}

