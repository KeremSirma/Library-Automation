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
using Office = Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;


namespace Library
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }
        void GridList()
        {
           
            SqlCommand cmd = new SqlCommand("Select * from Profile where Tc=@tc", tools.Con);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[0].Value);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();


            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:
            adp.Fill(dtable);


            // dataGridView'ımız verileri dtable'dan alır ve gösterir:
            dataGridView2.DataSource = dtable;
            //MessageBox.Show(dtable.ToString());

            // Bağlantı kapatılır:
            tools.Con.Close();

        }

        void Gridlist2()
        {
           
            dataGridView2.Visible = false;
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Tc) as [Alınan Toplam Kitap] FROM Profile where Tc=@tc", tools.Con);
            cmd.Parameters.AddWithValue("@tc", dataGridView1.CurrentRow.Cells[0].Value);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dtable = new DataTable();

            
            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:
            adp.Fill(dtable);
           

            // dataGridView'ımız verileri dtable'dan alır ve gösterir:
            dataGridView2.DataSource = dtable;
            MessageBox.Show(dataGridView1.CurrentRow.Cells[2].Value.ToString()+" adlı üyeye ait toplam kitap sayısı="+dataGridView2.CurrentRow.Cells[0].Value.ToString());
            // Bağlantı kapatılır:
            tools.Con.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
            dataGridView2.DataSource = tools.list("Select * from Profile").DataSet.Tables[0];
       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dataGridView2.Visible = true;
            btnYazdir.Visible = true;
            button2.Visible = true;
            GridList();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            

            Excel.Application uygulama = new Excel.Application();
            uygulama.Visible = true;
            object Missing = Type.Missing;
            Microsoft.Office.Interop.Excel.Workbook profile = uygulama.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet Sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)profile.Sheets[1];
            int sutun = 1;
            int satir = 1;
            for (int j = 0; j < dataGridView2.ColumnCount; j++)
            {
                Microsoft.Office.Interop.Excel.Range myrange = (Excel.Range)Sheet1.Cells[satir, sutun + j];
                myrange.Value2 = dataGridView2.Columns[j].HeaderText;

            }
            satir++;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        Excel.Range range = (Excel.Range)Sheet1.Cells[satir + i, sutun + j];
                        range.Value2 = dataGridView2[j, i].Value == null ? "" : dataGridView2[j, i].Value.ToString();
                        range.Select();
                    }
                }
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Gridlist2();
        }
    }
}
