using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechGenics
{
    public partial class frmGoogle : Form
    {
        public frmGoogle()
        {
            InitializeComponent();
        }

        private void frmGoogle_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("www.google.com");
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            this.Text = e.Url.ToString() + "Is Loading ...";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
