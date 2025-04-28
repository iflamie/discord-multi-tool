using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWID
{
    public partial class Form1 : Form
    {
        private string HWIDG;
        public Form1()
        {
            InitializeComponent();
            this.HWIDG = WindowsIdentity.GetCurrent().User.Value;
            WebClient webClient = new WebClient();
            string text = webClient.DownloadString("https://pastebin.com/raw/JNnpYSrG");
            bool flag = text.Contains(this.HWIDG);
            bool flag2 = !flag;
            if (flag2)
            {
                
            }

            bool flag3 = text == this.HWIDG;
            if (flag3)
            {

            }
            HWIDH.AppendText($"\n HWID: {this.HWIDG}\n");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HWIDH_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
