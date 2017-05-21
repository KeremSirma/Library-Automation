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
    public partial class MainLogin : Form
    {
        public MainLogin()
        {
            InitializeComponent();
        }
        Login adminlog = new Login();
        User userlog = new User();
        private void btnMemberLog_Click(object sender, EventArgs e)
        {
            userlog.Show();

        }

        private void btnAdminLog_Click(object sender, EventArgs e)
        {
            adminlog.Show();
        }
    }
}
