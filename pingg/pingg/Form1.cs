using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace pingg
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
            Ping p = new Ping();
            PingReply cevap = p.Send(tr);
            if(cevap.Status == IPStatus.Success)
            {
                listBox1.Items.Add("Server ayakta");
                listBox1.Items.Add("IP Adresi:"+cevap.Address);
                listBox1.Items.Add("Time:"+cevap.RoundtripTime+"ms");
                listBox1.Items.Add("Tarih/Saat:"+DateTime.Now);
                listBox1.Items.Add("Paket boyutu:"+cevap.Buffer.Length+"byte");
                listBox1.Items.Add("TTL:"+cevap.Options.Ttl);
            }
            else
            {
                listBox1.Items.Add("Server düştü");
            }

        }
    }
}
