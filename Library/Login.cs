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
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Library
{
    public partial class Login : Form
    {


        public Login()
        {
            InitializeComponent();
        }

        public static string tc;
        public static User user = new User();
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2202:Do not dispose objects multiple times")]
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tools.Con.State == ConnectionState.Closed)
            {
                tools.Con.Open();
            }
            string tckimlik;

            try
            {
                tckimlik = txtId.Text.ToString();
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


                if (String.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "Hata",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string sql = "SELECT * FROM UserTb WHERE Tc=@tc and Password=@pass";

                    SqlCommand cmd = new SqlCommand(sql, tools.Con);

                    cmd.Parameters.AddWithValue("@tc", txtId.Text);
                    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    string Authority = dr["Authority"].ToString();
                    string Password = dr["Password"].ToString();
                    label3.Text = dr["Name"].ToString() + " " + dr["LastName"].ToString();

                    dr.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);


                    da.Fill(dt);

                    if (dt.Rows.Count > 0 && Authority == "True" && txtPass.Text == Password)
                    {
                        btntfirstLogin.Visible = false;
                        progressBar1.Visible = true;
                        label2.Visible = true;
                        txtPass.Visible = true;
                        btntfirstLogin.Visible = true;
                        btnLogin.Visible = false;
                        dr.Close();
                        timer1.Start();
                    }
                    else if (dt.Rows.Count > 0 && Authority == "False" && txtPass.Text == Password)
                    {


                        tc = txtId.Text;
                        User user = new User();
                        user.Show();
                        this.Hide();
                        dr.Close();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToShortDateString();
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                progressBar1.Visible = true;
                btnLogin_Click(sender, new EventArgs());
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (tools.Con.State == ConnectionState.Closed)
                        tools.Con.Open();
                    string tckimlik;

                    try
                    {
                        tckimlik = txtId.Text.ToString();
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


                        if (String.IsNullOrWhiteSpace(txtId.Text))
                        {
                            MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "..:: HATA ::..",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {

                            string sql = "SELECT * FROM UserTb WHERE Tc=@tc";

                            SqlCommand cmd = new SqlCommand(sql, tools.Con);

                            cmd.Parameters.AddWithValue("@tc", txtId.Text);
                            //    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                            SqlDataReader dr = cmd.ExecuteReader();
                            dr.Read();
                            string Authority = dr["Authority"].ToString();
                            label3.Text = dr["Name"].ToString() + " " + dr["LastName"].ToString();
                            dr.Close();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);


                            da.Fill(dt);

                            if (dt.Rows.Count > 0 && Authority == "True")
                            {

                                label2.Visible = true;
                                txtPass.Visible = true;
                                btntfirstLogin.Visible = true;
                                txtPass.Focus();

                            }
                            else if (dt.Rows.Count > 0 && Authority == "False")
                            {
                                tc = txtId.Text;
                                User user = new User();
                                user.Show();
                                this.Hide();
                            }
                        }

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Veritabanında böyle bir Tc No bulunamadı !");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); ;
            }
        }
        private void btnUserReg_Click(object sender, EventArgs e)
        {
            User_Registration UReg = new User_Registration();
            UReg.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            string tckimlik;

            try
            {
                tckimlik = txtId.Text.ToString();
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

                tc = txtId.Text.ToString();
                if (String.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Giriş Başarısız! Eksiksiz Giriniz!", "..:: HATA ::..",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    string sql = "SELECT * FROM UserTb WHERE Tc=@tc";

                    SqlCommand cmd = new SqlCommand(sql, tools.Con);

                    cmd.Parameters.AddWithValue("@tc", txtId.Text);
                    //    cmd.Parameters.AddWithValue("@pass", txtPass.Text);
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    string Authority = dr["Authority"].ToString();
                    label3.Text = dr["Name"].ToString() + " " + dr["LastName"].ToString();
                    dr.Close();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);


                    da.Fill(dt);

                    if (dt.Rows.Count > 0 && Authority == "True")
                    {

                        label2.Visible = true;
                        txtPass.Visible = true;
                        btnLogin.Visible = true;
                        txtPass.Focus();


                    }
                    else if (dt.Rows.Count > 0 && Authority == "False")
                    {
                        user.Show();
                    }
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanında böyle bir Tc No bulunamadı");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MainForm main = new MainForm();
                main.Show();             
                MessageBox.Show("Hoşgeldin " + label3.Text);
                this.Hide();
                progressBar1.Value = 0;  
            }


        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}