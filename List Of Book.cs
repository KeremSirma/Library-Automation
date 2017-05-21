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
    public partial class List_Of_Book : Form
    {
        //SqlConnection Con;
        //SqlDataAdapter Da;
        //DataSet Ds;
        //SqlCommand Cmd;
        public List_Of_Book()
        {
            InitializeComponent();
        }

        private void List_Of_Book_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = tools.list("Select * from BooksTb").DataSet.Tables[0];



        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            Book_Records BookRec = new Book_Records();
            BookRec.Show();
        }
        
        void whereBook()
        {
            if (tools.Con.State == ConnectionState.Closed)
                tools.Con.Open();

            SqlCommand Command1 = new SqlCommand("Select b.BookId, b.BookName, s.ShelfSequence, s.ShelfType  from BooksTb as b inner join Shelfs as s on b.BookId = s.BookId and b.BookId=@x", tools.Con);
            Command1.Parameters.AddWithValue("@x", dataGridView1.CurrentRow.Cells[0].Value);
            SqlDataReader Output1 = Command1.ExecuteReader();
            if (Output1.Read())
            {
                MessageBox.Show("Kitap Şurada" + Environment.NewLine + "Kitap İd : " + Output1["BookId"].ToString().Trim() + Environment.NewLine + "Kitap Adı : " + Output1["BookName"].ToString().Trim() + Environment.NewLine + "Rafı : " + Output1["ShelfType"].ToString().Trim() + Environment.NewLine + "Sırası : " + Output1["ShelfSequence"].ToString().Trim());
            }
            tools.Con.Close();

        }
        private void btnDelBook_Click(object sender, EventArgs e)
        {
            Book_Records BookRec = new Book_Records();
            BookRec.Show();
        }

        private void btnUpdBook_Click(object sender, EventArgs e)
        {
            Book_Records BookRec = new Book_Records();
            BookRec.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            whereBook();
            
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dt2 = new DateTime();

                // dateTimePicker1.Value = );// takvimde seçilen tarihler nesnelere aktarılıyor.

                dt2 = DateTime.Now;
                //TimeSpan GunFarki = dateTimePicker1.Value.Subtract(Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()));

                TimeSpan GunFarki = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[10].Value.ToString()).Subtract(DateTime.Now);
                if (GunFarki.Days < 0)
                {
                    MessageBox.Show("Teslim Günü Geçmiştir", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(GunFarki.Days.ToString() + " gün"); //textbox'a da çağrılan metod yardımıyla 
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kitap Zaten Kütüphanede","Tekrar Kontrol Ediniz");
            }
            
            
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void List_Of_Book_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }
    }
}
