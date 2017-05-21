using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Member_List : Form
    {

        public Member_List()
        {
            InitializeComponent();
        }
        
        private void Member_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bookDbKeremMember.UserTb' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = tools.list("Select * from UserTb").DataSet.Tables[0];
            // TODO: This line of code loads data into the 'bookDbDataSet9.UserTb' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'bookDbDataSet.UserTb' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'kutuphaneDataSet.Books' table. You can move, or remove it, as needed.


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Member_Registration Mregister = new Member_Registration();
            Mregister.Show();
        }

        private void btn_MemberUpd_Click(object sender, EventArgs e)
        {
            Member_Registration Mregister = new Member_Registration();
            Mregister.Show();
        }

        private void btn_MemberDel_Click(object sender, EventArgs e)
        {
            Member_Registration Mregister = new Member_Registration();
            Mregister.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Profile profil = new Profile();

            profil.Show();
        }

        private void Member_List_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }
    }
}
