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
    public partial class MainForm : Form
    {

        SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=master;Integrated Security=True");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_BookRec_Click(object sender, EventArgs e)
        {
            Book_Records BookRec = new Book_Records();
            BookRec.Show();
            this.Hide();
        }

        private void btn_MemRec_Click(object sender, EventArgs e)
        {
            Member_Registration MemRec = new Member_Registration();
            MemRec.Show();
            this.Hide();
        }

        private void btn_MemList_Click(object sender, EventArgs e)
        {
            Member_List MemList = new Member_List();
            MemList.Show();
            this.Hide();
        }

        private void btn_BookList_Click(object sender, EventArgs e)
        {
            List_Of_Book ListBook = new List_Of_Book();
            ListBook.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Login Log = new Login();
            Log.Show();
            Con.Close();
            this.Hide();;
        }

        private void btnGive_Click(object sender, EventArgs e)
        {
            GiveBookList give = new GiveBookList();
            give.Show();
            this.Hide();
        }

        private void btnReceiptBook_Click(object sender, EventArgs e)
        {
            receiptBook receiptbook = new receiptBook();
            receiptbook.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gaziosmanpasa.bel.tr");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/gaziosmanpasabelediyesi");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/GOPBelediyesi");
        }

        private void btnBackupRestore_Click(object sender, EventArgs e)
        {
            BackupRestore backrest = new BackupRestore();
            backrest.Show();
            this.Hide();
        }
    }
}
