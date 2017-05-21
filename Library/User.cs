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

namespace Library
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }
        int Rnd1, Rnd2;
        public string tc;
        private void User_Load(object sender, EventArgs e)
        {
            Random rndStr = new Random();
            Rnd1 = rndStr.Next(1, 5);
            Rnd2 = rndStr.Next(1, 10);
            lblCaptcha.Text = Rnd1.ToString() + " + " + Rnd2.ToString();
            TbTc.Text = Login.tc;
            TbPswrd.Focus();
        }

        private void txtCaptcha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string tckimlik;

                try
                {
                    tckimlik = TbTc.Text.ToString();
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
                try
                {
                    if (int.Parse(txtCaptcha.Text) == (Rnd1 + Rnd2))
                    {

                        SqlCommand Command = new SqlCommand("SELECT * FROM UserTb WHERE Tc= '" + TbTc.Text + "'", tools.Con);

                        if (tools.Con.State == ConnectionState.Closed)
                            tools.Con.Open();
                        SqlDataReader Output = Command.ExecuteReader();
                        if (TbTc.Text == "" || TbPswrd.Text == "" || txtCaptcha.Text == "")
                        {
                            MessageBox.Show("Alanlar Boş Geçilemez Tekrar Deneyin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (Output.Read())
                        {


                           if (TbPswrd.Text == Output["Password"].ToString().Trim())
                            {

                                MessageBox.Show("Hoşgeldiniz: " + Output["Name"] + "  " + Output["Lastname"].ToString());
                               
                                UserBooks usr = new UserBooks();
                                usr.Show();
                                this.Hide();
                            }
                            else
                                LblWarning.Text = "ŞİFRE YANLIŞ";
                        }
                        else { LblWarning.Text = "SİSTEMDE BÖYLE BİR KULANICI KAYITLI DEĞİL"; }
                        tools.Con.Close();
                    }
                    else
                        LblWarning.Text = "Lütfen sayıların toplamını doğru giriniz.";
                }

                catch (Exception)
                {
                    MessageBox.Show("Alanlar Boş Geçilemez Kontrol Ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tckimlik;

                try
                {
                    tckimlik = TbTc.Text.ToString();
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
                try
                {
                    if (int.Parse(txtCaptcha.Text) == (Rnd1 + Rnd2))
                    {

                        SqlCommand Command = new SqlCommand("SELECT * FROM UserTb WHERE Tc= '" + TbTc.Text + "'", tools.Con);

                        if (tools.Con.State == ConnectionState.Closed)
                            tools.Con.Open();
                        SqlDataReader Output = Command.ExecuteReader();
                        if (TbTc.Text == "" || TbPswrd.Text == "" || txtCaptcha.Text == "")
                        {
                            MessageBox.Show("Alanlar Boş Geçilemez Tekrar Deneyin !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if (Output.Read())
                        {


                           if (TbPswrd.Text == Output["Password"].ToString().Trim())
                            {

                                MessageBox.Show("Hoşgeldiniz: " + Output["Name"] + "  " + Output["Lastname"].ToString());
                               
                                UserBooks usr = new UserBooks();
                                usr.Show();
                                this.Hide();
                            }
                            else
                                LblWarning.Text = "ŞİFRE YANLIŞ";
                        }
                        else { LblWarning.Text = "SİSTEMDE BÖYLE BİR KULANICI KAYITLI DEĞİL"; }
                        tools.Con.Close();
                    }
                    else
                        LblWarning.Text = "Lütfen sayıların toplamını doğru giriniz.";
                }

                catch (Exception)
                {
                    MessageBox.Show("Alanlar Boş Geçilemez Kontrol Ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        private void User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login log = new Login();
            log.Show();
        }
    }
}
