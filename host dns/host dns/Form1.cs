using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace host_dns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tr = textBox1.Text;
            if(textBox1.Text!="")
            { 
                Uri webadress = new Uri(tr);
                listBox1.Items.Add(webadress.Host);
                listBox1.Items.Add(webadress.Authority);
                listBox1.Items.Add(webadress.Scheme);
                listBox1.Items.Add(webadress.Port);
                listBox1.Items.Add(webadress.Query);
                listBox1.Items.Add(webadress.IsDefaultPort);
                listBox1.Items.Add(webadress.HostNameType);
            }
            else
            {
                listBox1.Items.Clear();
            }
        }
    }
}
