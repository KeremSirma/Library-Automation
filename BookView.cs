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
    public partial class BookView : Form
    {
        public BookView()
        {
            InitializeComponent();
        }
        public static string image, bookname, author, pagenumber, type, summary;

        private void BookView_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("http://responsivevoice.org/text-to-speech-languages/konusma-turkce-metin/");
            webBrowser1.ScriptErrorsSuppressed = true;
            pictureBox1.ImageLocation = UserBooks.image;
            lblBookName.Text = UserBooks.bookname;
            lblAuthor.Text = UserBooks.author;
            lblPageNumber.Text = UserBooks.pagenumber;
            lblType.Text = UserBooks.type;
            txtSummary.Text = UserBooks.summary;
            
            
        }

        private void txtOku_Click(object sender, EventArgs e)
        {
            try
            {
                webBrowser1.Document.GetElementById("text").InvokeMember("select");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            } 
            webBrowser1.Document.GetElementById("text").InnerText = txtSummary.Text;

            webBrowser1.Document.GetElementById("playbutton").InvokeMember("click");
        }

        private void txtSummary_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
