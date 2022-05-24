using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WebPreglednik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnGo_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(txtBrowser.Text);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            TabPage tabpage = new TabPage();
            tabpage.Text = "New Tab";
            tabControl1.Controls.Add(tabpage);
            WebBrowser webbrowser = new WebBrowser();
            webbrowser.Parent = tabpage;
            webbrowser.Dock = DockStyle.Fill;
            webbrowser.Navigate("www.google.com");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
