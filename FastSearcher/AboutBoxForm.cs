using System;
using System.Windows.Forms;

namespace MIF
{
    partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void linkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.github.com/VladPVS/The-MIF");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void richTextBoxDescription_Enter(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://en.wikipedia.org/wiki/Vasyl_Slipak"); 
        }


        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
