using System;
using Excel=Microsoft.Office.Interop.Excel;
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
using System.IO;



namespace Library
{
    public partial class GiveBookList : Form
    {
        
        public GiveBookList()
        {
            InitializeComponent();
        }
        
        DateTime tarih;
        private void GiveBookList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDbDataSet13.Profile' table. You can move, or remove it, as needed.

            dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
            dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
            dataGridView3.DataSource = tools.list("Select * from Borrowed").DataSet.Tables[0];
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTc.Text) || String.IsNullOrWhiteSpace(txtMemberName.Text) || String.IsNullOrWhiteSpace(txtMemberLastname.Text) || String.IsNullOrWhiteSpace(txtBook.Text) || String.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {

                    // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                    SqlCommand cmd = new SqlCommand("INSERT INTO Borrowed (Tc,BookId,BookName,MemberName,MemberLastname,Date,ReceivingDate) VALUES (@tc,@id,@bookName,@name,@lastname,@date,@recdate)", tools.Con);


                    // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                    cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                    cmd.Parameters.AddWithValue("@id", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@bookName", txtBook.Text);
                    cmd.Parameters.AddWithValue("@name", txtMemberName.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtMemberLastname.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);


                    SqlCommand cmd2 = new SqlCommand("UPDATE  BooksTb SET BookUsed= @BookUsed, TeslimSuresi= @countdata where BookId=@id", tools.Con);
                    cmd2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                    cmd2.Parameters.AddWithValue("@BookUsed", 1);

                    if (tools.Con.State == ConnectionState.Closed)
                    {
                        tools.Con.Open();
                    }

                    if (dataGridView1.CurrentRow.Cells[4].Value.ToString() == "True")
                    {

                        MessageBox.Show("Kitap zaten verilmiştir");
                    }
                    else if (dataGridView2.CurrentRow.Cells[0].Value.ToString() == dataGridView3.CurrentRow.Cells[0].Value.ToString())
                    {

                        MessageBox.Show("Zaten almış olduğunuz bir kitap bulunmaktadır.Daha Fazla kitap alamazsınız!");

                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {

                        MessageBox.Show("Teslim süresi seçiniz..!");

                    }
                    else if (radioButton1.Checked == true)
                    {

                        tarih = dateTimePicker1.Value.AddDays(Double.Parse((radioButton1.Text)));
                        cmd2.Parameters.AddWithValue("@countdata", radioButton1.Text);
                        cmd.Parameters.AddWithValue("@recdate", tarih);


                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Profile (Tc,BookId,BookName,MemberName,MemberLastname,Date,RDate) VALUES (@tc,@id,@bookName,@name,@lastname,@date,@recdate1)", tools.Con);
                        cmd3.Parameters.AddWithValue("@tc", dataGridView2.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@bookName", dataGridView1.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@name", dataGridView2.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@lastname", dataGridView2.CurrentRow.Cells[2].Value);
                        cmd3.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                        cmd3.Parameters.AddWithValue("recdate1", tarih);
                        cmd3.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show(txtBook.Text + " kitabı " + txtMemberName.Text + " adlı üyeye teslim edilmiştir. ");
                        dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
                        dataGridView3.DataSource = tools.list("Select * from Borrowed").DataSet.Tables[0];


                        tools.Con.Close();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Profile (Tc,BookId,BookName,MemberName,MemberLastname) VALUES (@tc,@id,@bookName,@name,@lastname)", tools.Con);
                        cmd3.Parameters.AddWithValue("@tc", dataGridView2.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@bookName", dataGridView1.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@name", dataGridView2.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@lastname", dataGridView2.CurrentRow.Cells[2].Value);
                        // cmd3.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                        tarih = dateTimePicker1.Value.AddDays(Double.Parse((radioButton2.Text)));
                        // cmd3.Parameters.AddWithValue("recdate1",(tarih));

                        cmd3.ExecuteNonQuery();

                        cmd2.Parameters.AddWithValue("@countdata", radioButton2.Text);
                        cmd.Parameters.AddWithValue("@recdate", tarih);


                        cmd3.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();


                        MessageBox.Show(txtBook.Text + " kitabı " + txtMemberName.Text + " adlı üyeye teslim edilmiştir. ");
                        dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
                        dataGridView3.DataSource = tools.list("Select * from Borrowed").DataSet.Tables[0];


                        tools.Con.Close();
                    }
                }


                catch (Exception)
                {

                    MessageBox.Show("Ödünç kitap tablosu boş...İlk kitap eklenmiştir");
                    SqlCommand cmd = new SqlCommand("INSERT INTO Borrowed (Tc,BookId,BookName,MemberName,MemberLastname,Date,ReceivingDate) VALUES (@tc,@id,@bookName,@name,@lastname,@date,@recdate)", tools.Con);


                    // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                    cmd.Parameters.AddWithValue("@tc", txtTc.Text);
                    cmd.Parameters.AddWithValue("@id", txtBarcode.Text);
                    cmd.Parameters.AddWithValue("@bookName", txtBook.Text);
                    cmd.Parameters.AddWithValue("@name", txtMemberName.Text);
                    cmd.Parameters.AddWithValue("@lastname", txtMemberLastname.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);


                    SqlCommand cmd2 = new SqlCommand("UPDATE  BooksTb SET BookUsed= @BookUsed, TeslimSuresi= @countdata where BookId=@id", tools.Con);
                    cmd2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                    cmd2.Parameters.AddWithValue("@BookUsed", 1);


                    if (tools.Con.State == ConnectionState.Closed)
                    {
                        tools.Con.Open();

                    }
                    else if (radioButton1.Checked == false && radioButton2.Checked == false)
                    {

                        MessageBox.Show("Teslim süresi seçiniz..!");

                    }
                    else if (radioButton1.Checked == true)
                    {

                        tarih = dateTimePicker1.Value.AddDays(Double.Parse((radioButton1.Text)));
                        cmd2.Parameters.AddWithValue("@countdata", radioButton1.Text);
                        cmd.Parameters.AddWithValue("@recdate", tarih);


                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Profile (Tc,BookId,BookName,MemberName,MemberLastname,Date,RDate) VALUES (@tc,@id,@bookName,@name,@lastname,@date,@recdate1)", tools.Con);
                        cmd3.Parameters.AddWithValue("@tc", dataGridView2.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@bookName", dataGridView1.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@name", dataGridView2.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@lastname", dataGridView2.CurrentRow.Cells[2].Value);
                        cmd3.Parameters.AddWithValue("@date", dateTimePicker1.Value);

                        cmd3.Parameters.AddWithValue("recdate1", tarih);
                        cmd3.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show(txtBook.Text + " kitabı " + txtMemberName.Text + " adlı üyeye teslim edilmiştir. ");
                        dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
                        dataGridView3.DataSource = tools.list("Select * from Borrowed").DataSet.Tables[0];


                        tools.Con.Close();
                    }
                    else if (radioButton2.Checked == true)
                    {
                        SqlCommand cmd3 = new SqlCommand("INSERT INTO Profile (Tc,BookId,BookName,MemberName,MemberLastname) VALUES (@tc,@id,@bookName,@name,@lastname)", tools.Con);
                        cmd3.Parameters.AddWithValue("@tc", dataGridView2.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                        cmd3.Parameters.AddWithValue("@bookName", dataGridView1.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@name", dataGridView2.CurrentRow.Cells[1].Value);
                        cmd3.Parameters.AddWithValue("@lastname", dataGridView2.CurrentRow.Cells[2].Value);
                        // cmd3.Parameters.AddWithValue("@date", dateTimePicker1.Value.ToString());
                        tarih = dateTimePicker1.Value.AddDays(Double.Parse((radioButton2.Text)));
                        // cmd3.Parameters.AddWithValue("recdate1",(tarih));

                        cmd3.ExecuteNonQuery();

                        cmd2.Parameters.AddWithValue("@countdata", radioButton2.Text);
                        cmd.Parameters.AddWithValue("@recdate", tarih);


                        cmd3.ExecuteNonQuery();
                        cmd.ExecuteNonQuery();
                        cmd2.ExecuteNonQuery();


                        MessageBox.Show(txtBook.Text + " kitabı " + txtMemberName.Text + " adlı üyeye teslim edilmiştir. ");
                        dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
                        dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
                        dataGridView3.DataSource = tools.list("Select * from Borrowed").DataSet.Tables[0];


                        tools.Con.Close();
                    }
                }
            }

            
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            txtBook.Text= dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBarcode.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtMemberName.Text= dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtMemberLastname.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtMail.Text = dataGridView2.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        public int GunFarkikBul(DateTime dt1, DateTime dt2)

        {

            TimeSpan zaman = new TimeSpan(); // zaman farkını bulmak adına kullanılacak olan nesne

            zaman = dt1 - dt2;//metoda gelen 2 tarih arasındaki fark

            return Math.Abs(zaman.Days); // 2 tarih arasındaki farkın kaç gün olduğu döndürülüyor.

        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

            DateTime dt1 = new DateTime(); // 2 tane tarih girişi için üretilen TarihZaman nesneleri

            DateTime dt2 = new DateTime();

            dt1 = DateTime.Parse(dataGridView3.CurrentRow.Cells[5].Value.ToString()); // takvimde seçilen tarihler nesnelere aktarılıyor.

            dt2 = DateTime.Now;
            TimeSpan GunFarkiBul = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()).Subtract(DateTime.Now);
            GunFarkiBul = dt1 - dt2;
                if (GunFarkiBul.Days<0)

            {
                MessageBox.Show("Teslim Günü Bitti");
                MailMessage mail = new MailMessage();
                SmtpClient server = new SmtpClient();
                server.Credentials = new System.Net.NetworkCredential("belediyegop@gmail.com", "gop123456");
                server.Port = 25;
                server.Host = "smtp.gmail.com";
                server.EnableSsl = true;
                mail.To.Add(txtMail.Text);
                mail.From = new MailAddress("belediyegop@gmail.com");
                mail.Subject = "Gaziosmapaşa Belediyesi Kütüphane";
                mail.Body = "Sayın" + " " + txtMemberName.Text.ToString() + " " +txtMemberLastname.Text.ToString() + " " +txtBook.Text.ToString()+" "+ "adlı kitabın teslim süresi geçmiştir getirmenizi rica ederiz.";
                server.Send(mail);
            }

           MessageBox.Show(GunFarkiBul.Days.ToString() + " gün"); //textbox'a da çağrılan metod yardımıyla
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtTc.Text) || String.IsNullOrWhiteSpace(txtMemberName.Text) || String.IsNullOrWhiteSpace(txtMemberLastname.Text) || String.IsNullOrWhiteSpace(txtBook.Text) || String.IsNullOrWhiteSpace(txtBarcode.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Excel.Application uygulama = new Excel.Application();
                uygulama.Visible = true;
                object Missing = Type.Missing;
                Microsoft.Office.Interop.Excel.Workbook kitap = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
                Microsoft.Office.Interop.Excel.Worksheet Sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)kitap.Sheets[1];
                int sutun = 1;
                int satir = 1;
                for (int j = 0; j < dataGridView3.ColumnCount; j++)
                {
                    Microsoft.Office.Interop.Excel.Range myrange = (Excel.Range)Sheet1.Cells[satir, sutun + j];
                    myrange.Value2 = dataGridView3.Columns[j].HeaderText;

                }
                satir++;
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {
                    {
                        for (int j = 0; j < dataGridView3.Columns.Count; j++)
                        {
                            Excel.Range range = (Excel.Range)Sheet1.Cells[satir + i, sutun + j];
                            range.Value2 = dataGridView3[j, i].Value == null ? "" : dataGridView3[j, i].Value.ToString();
                            range.Select();
                        }
                    }
                }
                
            }
            

            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTc_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetter(e.KeyChar);
        }

        private void txtTc_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }

        private void GiveBookList_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }
    }
    }

    
