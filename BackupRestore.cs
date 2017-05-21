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
    public partial class BackupRestore : Form
    {
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void BackupRestore_Load(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
            btnRestore.Enabled = false;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dlg.SelectedPath;
                btnBackup.Enabled = true;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        private void btnBackup_Click(object sender, EventArgs e)
        {
            string database = tools.Con.Database.ToString();
            try
            {
                if (textBox1.Text == string.Empty)
                {
                    MessageBox.Show("please enter backup file location");
                }
                else
                {
                    string cmd = "BACKUP DATABASE [" + database + "] TO DISK='" + textBox1.Text + "\\" + "database" + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    using (SqlCommand command = new SqlCommand(cmd, tools.Con))
                    {
                        if (tools.Con.State != ConnectionState.Open)
                        {
                            tools.Con.Open();
                        }
                        command.ExecuteNonQuery();
                        tools.Con.Close();
                        MessageBox.Show("Veritabanı yedeklemesi başarıyla tamamlandı.");
                        btnBackup.Enabled = false;
                    }
                }

            }
            catch
            {

            }
        }

        private void btnRestoreBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQL SERVER database backup files|*.bak";
            dlg.Title = "Database restore";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                textBox4.Text = dlg.FileName;
                btnRestore.Enabled = true;
            }
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2100:Review SQL queries for security vulnerabilities")]
        private void btnRestore_Click(object sender, EventArgs e)
        {
            string database = tools.Con.Database.ToString();
            if (tools.Con.State != ConnectionState.Open)
            {
                tools.Con.Open();
            }
            try
            {
                string sqlStmt2 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                SqlCommand bu2 = new SqlCommand(sqlStmt2, tools.Con);
                bu2.ExecuteNonQuery();

                string sqlStmt3 = "USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + textBox4.Text + "'WITH REPLACE;";
                SqlCommand bu3 = new SqlCommand(sqlStmt3, tools.Con);
                bu3.ExecuteNonQuery();

                string sqlStmt4 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                SqlCommand bu4 = new SqlCommand(sqlStmt4, tools.Con);
                bu4.ExecuteNonQuery();

                MessageBox.Show("Veritabanı geriyüklemesi başarılı!");
                tools.Con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BackupRestore_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm back = new MainForm();
            back.Show();
        }

       
    }
}
