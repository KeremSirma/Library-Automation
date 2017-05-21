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

namespace Library
{
    public partial class UserBooks : Form
    {
        

        public UserBooks()
        {
            InitializeComponent();
        }
        public static string image, bookname, author, pagenumber, type, summary;
        public int TotalBook;
        public List<int> rndlist = new List<int>();
        
        private void btnHomePage_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(Environment.TickCount);
            int rndNmbr = rnd.Next(TotalBook);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);        
            SqlCommand cmd = new SqlCommand("Select count(*) From BooksTb", tools.Con);
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();


            TotalBook = Convert.ToInt32(cmd.ExecuteScalar());
            lblToplamKitap.Text = "Toplam Kitap: " + TotalBook.ToString();
            tools.Con.Close();
            rndNmbr = rnd.Next(TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[1] = rndNmbr;

            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output = Command.ExecuteReader();
            if (Output.Read())
            {
                pictureBox1.Image = Image.FromFile(Output["BookPL"].ToString());
                label1.Text = Output["BookName"].ToString().Trim();

            }

            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[2] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command2 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output2 = Command2.ExecuteReader();
            if (Output2.Read())
            {
                pictureBox2.Image = Image.FromFile(Output2["BookPL"].ToString());
                label2.Text = Output2["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[3] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command3 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output3 = Command3.ExecuteReader();
            if (Output3.Read())
            {
                pictureBox3.Image = Image.FromFile(Output3["BookPL"].ToString());
                label3.Text = Output3["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[4] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command4 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output4 = Command4.ExecuteReader();
            if (Output4.Read())
            {
                pictureBox4.Image = Image.FromFile(Output4["BookPL"].ToString());
                label4.Text = Output4["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[5] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command5 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output5 = Command5.ExecuteReader();
            if (Output5.Read())
            {
                pictureBox5.Image = Image.FromFile(Output5["BookPL"].ToString().Trim());
                label5.Text = Output5["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[6] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command6 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output6 = Command6.ExecuteReader();
            if (Output6.Read())
            {
                pictureBox6.Image = Image.FromFile(Output6["BookPL"].ToString().Trim());
                label6.Text = Output6["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[7] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command7 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output7 = Command7.ExecuteReader();
            if (Output7.Read())
            {
                pictureBox7.Image = Image.FromFile(Output7["BookPL"].ToString().Trim());
                label7.Text = Output7["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[8] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command8 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output8 = Command8.ExecuteReader();
            if (Output8.Read())
            {
                pictureBox8.Image = Image.FromFile(Output8["BookPL"].ToString().Trim());
                label8.Text = Output8["BookName"].ToString().Trim();

            }
            tools.Con.Close(); ;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

      public void UserBooks_Load(object sender, EventArgs e)
        {
            
            Random rnd = new Random();
            int rndNmbr = rnd.Next(1, 8);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            rndlist.Add(0);
            SqlCommand cmd = new SqlCommand("Select count(*) From BooksTb", tools.Con);
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();


            TotalBook = Convert.ToInt32(cmd.ExecuteScalar());
            lblToplamKitap.Text = "Toplam Kitap: " + TotalBook.ToString();
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[0] = rndNmbr;

            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output = Command.ExecuteReader();
            if (Output.Read())
            {
                pictureBox1.Image = Image.FromFile(Output["BookPL"].ToString());
                label1.Text = Output["BookName"].ToString().Trim();

            }

            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[2] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command2 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output2 = Command2.ExecuteReader();
            if (Output2.Read())
            {
                pictureBox2.Image = Image.FromFile(Output2["BookPL"].ToString());
                label2.Text = Output2["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[3] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command3 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output3 = Command3.ExecuteReader();
            if (Output3.Read())
            {
                pictureBox3.Image = Image.FromFile(Output3["BookPL"].ToString());
                label3.Text = Output3["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[4] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command4 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output4 = Command4.ExecuteReader();
            if (Output4.Read())
            {
                pictureBox4.Image = Image.FromFile(Output4["BookPL"].ToString());
                label4.Text = Output4["BookName"].ToString().Trim();

            }
            tools.Con.Close();

            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[5] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command5 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output5 = Command5.ExecuteReader();
            if (Output5.Read())
            {
                pictureBox5.Image = Image.FromFile(Output5["BookPL"].ToString().Trim());
                label5.Text = Output5["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[6] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command6 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output6 = Command6.ExecuteReader();
            if (Output6.Read())
            {
                pictureBox6.Image = Image.FromFile(Output6["BookPL"].ToString().Trim());
                label6.Text = Output6["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[7] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command7 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output7 = Command7.ExecuteReader();
            if (Output7.Read())
            {
                pictureBox7.Image = Image.FromFile(Output7["BookPL"].ToString().Trim());
                label7.Text = Output7["BookName"].ToString().Trim();

            }
            tools.Con.Close();
            rndNmbr = rnd.Next(1, TotalBook);
            rndlist.Add(rndNmbr);
            rndlist[8] = rndNmbr;
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();
            SqlCommand Command8 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndNmbr + "'", tools.Con);
            SqlDataReader Output8 = Command8.ExecuteReader();
            if (Output8.Read())
            {
                pictureBox8.Image = Image.FromFile(Output8["BookPL"].ToString().Trim());
                label8.Text = Output8["BookName"].ToString().Trim();

            }
            tools.Con.Close();
        }

      private void button1_MouseHover(object sender, EventArgs e)
      {
          
      }

      private void button1_MouseUp(object sender, MouseEventArgs e)
      {
          
      }

      private void button1_MouseMove(object sender, MouseEventArgs e)
      {
          button1.Visible = true;
      }

      private void pictureBox1_MouseHover(object sender, EventArgs e)
      {
          button1.Visible = true;
      }

      private void pictureBox1_MouseLeave(object sender, EventArgs e)
      {
          
      }

      private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
      {
          button1.Visible = false;
      }

      private void pictureBox2_MouseHover(object sender, EventArgs e)
      {
          button2.Visible = true;
      }

      private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
      {
          button2.Visible = false;
      }

      private void pictureBox3_MouseHover(object sender, EventArgs e)
      {
          button3.Visible = true;
      }

      private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
      {
          button3.Visible = false;
      }

      private void button1_Click(object sender, EventArgs e)
      {
          
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[0] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = ""+Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button2_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[2] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button3_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[3] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button4_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[4] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void pictureBox4_MouseHover(object sender, EventArgs e)
      {
          button4.Visible = true;
      }

      private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
      {
          button4.Visible = false;
      }

      private void pictureBox5_MouseHover(object sender, EventArgs e)
      {
          button5.Visible = true;
      }

      private void pictureBox5_MouseMove(object sender, MouseEventArgs e)
      {
          button5.Visible = false;
      }

      private void pictureBox6_MouseHover(object sender, EventArgs e)
      {
          button6.Visible = true;
      }

      private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
      {
          button6.Visible = false;
      }

      private void pictureBox7_MouseHover(object sender, EventArgs e)
      {
          button7.Visible = true;
      }

      private void pictureBox7_MouseMove(object sender, MouseEventArgs e)
      {
          button7.Visible = false;
      }

      private void pictureBox8_MouseHover(object sender, EventArgs e)
      {
          button8.Visible = true;
      }

      private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
      {
          button8.Visible = false;
      }

      private void button5_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[5] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button6_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[6] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button7_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[7] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void button8_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
              tools.Con.Open();
          SqlCommand Command1 = new SqlCommand("SELECT * FROM BooksTb WHERE BookId= '" + rndlist[8] + "'", tools.Con);
          SqlDataReader Output1 = Command1.ExecuteReader();
          if (Output1.Read())
          {
              summary = Output1["BookSummary"].ToString().Trim();
              bookname = "Kitap adı: " + Output1["BookName"].ToString().Trim();
              author = "Yazarı: " + Output1["BookAuthor"].ToString().Trim();
              pagenumber = "Sayfa Sayısı: " + Output1["BookPage"].ToString().Trim();
              image = "" + Output1["BookPL"].ToString().Trim();
          }
          BookView view = new BookView();
          view.Show();
          tools.Con.Close();
      }

      private void btnAra_Click(object sender, EventArgs e)
      {
          if (tools.Con.State == ConnectionState.Closed)
          {
              tools.Con.Open();
          }
          SqlCommand komut = new SqlCommand("Select * From BooksTb where BookName like '%" + txtSearch.Text + "%'", tools.Con);
          SqlDataAdapter da = new SqlDataAdapter(komut);
          DataSet ds = new DataSet();
          da.Fill(ds);
          dataGridView1.DataSource = ds.Tables[0];
          tools.Con.Close();
          if (txtSearch.Text.Trim() == "")
          {
              MessageBox.Show("Alan Boş Geçilemez !", "Tekrar Kontrol Et", MessageBoxButtons.OK, MessageBoxIcon.Warning);
          }
          if (dataGridView1.Rows.Count > 1)
          {
              listBox1.Visible = true;
              MessageBox.Show(txtSearch.Text + " : " + "Kayıt Bulundu", "Kitaplar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtSearch.Clear();
              txtSearch.Focus();
              listBox1.Items.Add(dataGridView1.CurrentRow.Cells[1].Value.ToString());
              
          }
          else if (dataGridView1.Rows.Count > 0)
          {
              MessageBox.Show(txtSearch.Text + " : " + "Kayıt Bulunamadı", "Kitaplar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              txtSearch.Clear();
              txtSearch.Focus();
          }
      }

      private void listBox1_SelectedValueChanged(object sender, EventArgs e)
      {
      }

      private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
      {
          DialogResult ac = MessageBox.Show("Kitabı görüntülemek ister misiniz ?","Kitabı Bulundu",MessageBoxButtons.YesNo);
          if (ac==DialogResult.Yes)
          {
              bookname = dataGridView1.CurrentRow.Cells[1].Value.ToString();
              author = dataGridView1.CurrentRow.Cells[2].Value.ToString();
              type = dataGridView1.CurrentRow.Cells[3].Value.ToString();
              pagenumber = dataGridView1.CurrentRow.Cells[7].Value.ToString();
              summary = dataGridView1.CurrentRow.Cells[6].Value.ToString();
              image = dataGridView1.CurrentRow.Cells[8].Value.ToString();
              BookView view = new BookView();
              view.Show();
          }
      }

      private void txtSearch_KeyDown(object sender, KeyEventArgs e)
      {
          if (e.KeyCode == Keys.Enter)
          {
              btnAra_Click(sender, new EventArgs());
          }
      }

      private void UserBooks_FormClosed(object sender, FormClosedEventArgs e)
      {
          User back = new User();
          back.Show();
      }


    }
}
