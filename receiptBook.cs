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
    public partial class receiptBook : Form
    {
        public receiptBook()
        {
            InitializeComponent();
        }
        public SqlConnection Con;

        private void receiptBook_Load(object sender, EventArgs e)
        {
            if (tools.Con.State == ConnectionState.Closed)
            {
                tools.Con.Open();
            }
                
                dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];
                dataGridView2.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMember.Text)||string.IsNullOrWhiteSpace(txtBook.Text)||string.IsNullOrWhiteSpace(txtBarcode.Text)||string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez !","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE  BooksTb SET BookUsed= @BookUsed, [Hasar Durumu]= @damage, Kutuphane_Gelis= @libralycomedate where BookId=@id", tools.Con);
                cmd2.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);
                cmd2.Parameters.AddWithValue("@BookUsed", 0);
                cmd2.Parameters.AddWithValue("@damage", comboBox1.SelectedItem.ToString());
                cmd2.Parameters.AddWithValue("@libralycomedate", DateTime.Now);
                if (tools.Con.State == ConnectionState.Closed)
                {
                    tools.Con.Open();
                }

                if (comboBox1.SelectedItem.ToString() == "Kayıp")
                {
                    MessageBox.Show("Kitap Adı :" + " " + txtBook.Text + " " + "Kitabı Temin Etmeniz Gerekmektedir..!");
                    cmd2.ExecuteNonQuery();
                    dataGridView1.DataSource = tools.list("Select * From BooksTb");
                }
                else if (comboBox1.SelectedItem.ToString() == "Hasarlı" || comboBox1.SelectedItem.ToString() == "Hasarsız")
                {
                    cmd2.ExecuteNonQuery();

                    SqlCommand cmd4 = new SqlCommand("DELETE FROM Borrowed WHERE BookId= @bookid", tools.Con);
                    cmd4.Parameters.AddWithValue("@bookid", txtBarcode.Text);
                    // Bağlantı kapatılır:  
                    MessageBox.Show("Kitap Kütüphaneye teslim edilmiştir.");
                    cmd4.ExecuteNonQuery();
                    dataGridView1.DataSource = tools.list("Select * From BooksTb").DataSet.Tables[0];
                    tools.Con.Close();
                }
            }
            

        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtBook.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtBook.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMember.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString() + " " + dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString(); ;

        }

        private void receiptBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();

        }

        private void txtMember_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar);
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void comboBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsLetterOrDigit(e.KeyChar) || Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsNumber(e.KeyChar);
        }
    }
}
