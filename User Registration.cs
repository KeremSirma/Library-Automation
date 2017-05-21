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
    public partial class User_Registration : Form
    {
        public User_Registration()
        {
            InitializeComponent();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            try
            {
            string metin = Convert.ToString(txtMail.Text);
            int i = metin.IndexOf("@"); //indexof,aranan karakterin indeksini döndürür
            string tckimlik;

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
            if (toplam % 10 != Convert.ToInt32(tckimlik[10].ToString())||String.IsNullOrWhiteSpace(txtTcNo.Text) || String.IsNullOrWhiteSpace(txtMemberName.Text) || String.IsNullOrWhiteSpace(txtMemberSurname.Text) || String.IsNullOrWhiteSpace(txtAddress.Text) || String.IsNullOrWhiteSpace(txtPhone.Text) || String.IsNullOrWhiteSpace(txtMail.Text) || String.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Geçersiz TC Kimlik Numarası veya Alanlar Boş !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
             else if (i == -1) //eğer yoksa -1 döndürür
             {
                MessageBox.Show("Lütfen mail formatına uygun bir mail adresi giriniz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }


                            tools.Con.Open();
                            SqlCommand cmd2 = new SqlCommand("Select Tc From UserTb where Tc=@tc", tools.Con);
                            SqlCommand cmd = new SqlCommand("INSERT INTO UserTb (Tc,Name,LastName,Location,Phone,Mail,Password,Authority) VALUES (@tc,@name,@lastname,@location,@phone,@mail,@pass,@aut)", tools.Con);

                            cmd.Parameters.AddWithValue("@tc", txtTcNo.Text.ToString());
                            cmd.Parameters.AddWithValue("@name", txtMemberName.Text);
                            cmd.Parameters.AddWithValue("@lastname", txtMemberSurname.Text);
                            cmd.Parameters.AddWithValue("@location", txtAddress.Text);
                            cmd.Parameters.AddWithValue("@phone", txtPhone.Text.ToString());
                            cmd.Parameters.AddWithValue("@mail", txtMail.Text);
                            cmd.Parameters.AddWithValue("@pass", txtPass.Text.ToString());
                            cmd.Parameters.AddWithValue("@aut", "False");
                            
                            btnReg.Text = "Lütfen Bekleyiniz ...";
                            btnReg.Enabled = false;   
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
                            MessageBox.Show("Üye kaydınız başarıyla yapılmıştır.");
                            MessageBox.Show(txtMemberName.Text + " " + txtMemberSurname.Text + " Tc Kimlik Numaranız ve " + txtPass.Text + " şifrenizle giriş yapabilirsiniz.");
                            MessageBox.Show("Giriş ekranına yönlendiriliyorsunuz");
                            cmd.ExecuteNonQuery();
                            Login log = new Login();
                            log.Show();
                            this.Close();



                        }
            catch (Exception ex)
            {
                MessageBox.Show("Alanları Kontrol Ediniz"+ex.Message);
            }   
                }

               

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMemberName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                             && !char.IsSeparator(e.KeyChar);
        }

        private void txtMemberSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void User_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.A)&&e.KeyChar==Convert.ToChar(Keys.F1))
            {
                MainForm ac = new MainForm();
                ac.Show();
            }
        }
                
    }
}
