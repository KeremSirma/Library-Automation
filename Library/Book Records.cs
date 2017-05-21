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
    public partial class Book_Records : Form
    {


        public Book_Records()
        {
            InitializeComponent();
        }
        private void Book_Records_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://responsivevoice.org/text-to-speech-languages/konusma-turkce-metin/");
            webBrowser1.ScriptErrorsSuppressed = true;
            dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];  
        }

        private void btn_BookRec_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookName.Text) || String.IsNullOrWhiteSpace(txtAuthor.Text) || String.IsNullOrWhiteSpace(txtPage.Text) || String.IsNullOrWhiteSpace(txtType.Text) || String.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("INSERT INTO BooksTb (BookName,BookKind,BookPage,BookAuthor,BookSummary,BookPL) VALUES (@bookName,@BookKind,@page,@author,@summary,@bookpl)", tools.Con);

                    cmd.Parameters.AddWithValue("@bookName", txtBookName.Text);
                    cmd.Parameters.AddWithValue("@BookKind", txtType.Text);
                    cmd.Parameters.AddWithValue("@page", txtPage.Text);
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@summary", txtSummary.Text);
                    cmd.Parameters.AddWithValue("bookpl",textBox1.Text);

                    if (tools.Con.State == ConnectionState.Closed)
                    {
                        tools.Con.Open();
                    }


                    cmd.ExecuteNonQuery();

                    tools.Con.Close();


                    dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];

                    MessageBox.Show("Eklendi.");
                    textBox1.Clear();
                    txtBookName.Clear();
                    txtAuthor.Clear();
                    txtPage.Clear();
                    txtSummary.Clear();
                    txtType.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Boş Geçilemez Alanları Kontrol Ediniz !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


        }

        private void btnDelBook_Click(object sender, EventArgs e)
        {
            DialogResult sil = MessageBox.Show("Bu işlem geri alınamaz !", "Silmek İstiyor Musunuz ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sil == DialogResult.Yes)
            {
                try
                {

                    // bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:
                    SqlCommand cmd = new SqlCommand("DELETE FROM BooksTb WHERE BookId=@id", tools.Con);


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

                    dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];


                    // Silindi mesajı gösterilir:
                    MessageBox.Show("Silindi.");
                }


             // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
                catch (SqlException)
                {
                    MessageBox.Show("Hata olustu!");
                }

            }
            else if (sil == DialogResult.No)
            {
                MessageBox.Show("İşlemi İptal Ettiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }


        }

        private void btnUpdBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBookName.Text) || String.IsNullOrWhiteSpace(txtAuthor.Text) || String.IsNullOrWhiteSpace(txtPage.Text) || String.IsNullOrWhiteSpace(txtType.Text) || String.IsNullOrWhiteSpace(txtSummary.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                    SqlCommand Cmd = new SqlCommand("UPDATE BooksTb SET BookName=@name,BookKind=@type,BookPage=@page,BookAuthor=@author,BookSummary=@summary,BookPL=@bookpl WHERE BookId=@id ", tools.Con);


                    // Fare ile seçilmiş satırın değeri @id'ye aktarılır:
                    Cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);


                    // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:


                    Cmd.Parameters.AddWithValue("@name", txtBookName.Text);
                    Cmd.Parameters.AddWithValue("@type", txtType.Text);
                    Cmd.Parameters.AddWithValue("@page", txtPage.Text);
                    Cmd.Parameters.AddWithValue("@author", txtAuthor.Text);

                    Cmd.Parameters.AddWithValue("@summary", txtSummary.Text);
                    Cmd.Parameters.AddWithValue("@bookpl",textBox1.Text);




                    // Bağlantı kapalı ise açılır:
                    if (tools.Con.State == ConnectionState.Closed)
                    {
                        tools.Con.Open();
                    }


                    // Sorgu çalıştırılır:
                    Cmd.ExecuteNonQuery();

                    // Bağlantı kapatılır:
                    tools.Con.Close();


                    dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];



                    // Güncellendi mesajı gösterilir:
                    MessageBox.Show("Güncellendi.");


                }
                // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
                catch (SqlException)
                {
                    MessageBox.Show("Hata olustu!");
                }
            }


        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");
            SqlCommand Cmd = new SqlCommand();
            SqlDataAdapter adaptor = new SqlDataAdapter();
            DataSet ds = new DataSet();

            int number;
            int value;
            ds.Clear();
            adaptor.SelectCommand = new SqlCommand("select * from BooksTb where BookName Like'" + txtSearch.Text.ToString() + "'", Con);
            adaptor.Fill(ds);


            value = ds.Tables[0].Rows.Count;
            MessageBox.Show("Bulunan Kayıt Adedi :" + Convert.ToString(value));
            if (value >= 1)
            {
                number = 0;
                while (number != value)
                {
                    txtBookName.Text = Convert.ToString(ds.Tables[0].Rows[0]["BookName"]);
                    DialogResult Ds = MessageBox.Show("Aradığınız Kayıt Bu mu? " + txtBookName.Text.ToString(), "Library 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Ds == DialogResult.Yes)
                    {
                        txtBookName.Text = Convert.ToString(ds.Tables[0].Rows[0]["BookName"]);
                        txtAuthor.Text = Convert.ToString(ds.Tables[0].Rows[0]["BookAuthor"]);
                        txtPage.Text = Convert.ToString(ds.Tables[0].Rows[0]["BookPage"]);
                        txtType.Text = Convert.ToString(ds.Tables[0].Rows[0]["BookKind"]);
                        break;
                    }
                    else
                    {
                        number++;
                        MessageBox.Show("Başka Kayıt Bulunmamaktadır.");
                    }

                }
                if (number == value - 1)
                {
                    MessageBox.Show("Aradığınız Kayıttan Veritabanında Başka Yok");
                }


            }
            else
            {
                MessageBox.Show("Aradığınız Kayttan Veritabanında" + value.ToString() + "Tane Bulundu", "Library V 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Con.Close();

        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSummary.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            txtType.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtPage.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtAuthor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtBookName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            pictureBox1.ImageLocation = textBox1.Text;
        }

        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void txtAuthor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void txtType_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Resim Seç";
            fd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fd.OpenFile());
                textBox1.Text = fd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOku_Click(object sender, EventArgs e)
        {

            webBrowser1.Document.GetElementById("text").InnerText = txtSummary.Text;

            webBrowser1.Document.GetElementById("playbutton").InvokeMember("click");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //txtSummary.Text = webBrowser1.Document.GetElementById("text").InnerText;
            
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSummary_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("text").InvokeMember("select");

            }
            catch (Exception)
            {

                throw;
            } 
        }

        private void Book_Records_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }
    }
}
