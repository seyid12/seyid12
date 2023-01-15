using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fldlg = new OpenFileDialog();
            if (fldlg.ShowDialog()==DialogResult.OK)
            {
                label1.Text = fldlg.FileName;
                textBox1.Text = fldlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text== "Please select file")
            {
                MessageBox.Show("Please select file");
            }
            else
            {
                Byte[] thsfile = File.ReadAllBytes(label1.Text);
                for (int i = 0; i < thsfile.Length; i++)
                {
                    thsfile[i] = (Byte)((int)thsfile[i] + 1);
                    if (thsfile[i] > 255)
                    {
                        thsfile[i] = 0;
                    }
                }
                File.WriteAllBytes(textBox1.Text, thsfile);
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Please select file")
            {
                MessageBox.Show("Please select file");
            }
            else
            {
                Byte[] thsfile = File.ReadAllBytes(label1.Text);
                for (int i = 0; i < thsfile.Length; i++)
                {
                    if ((Byte)((int)thsfile[i] - 1) < 0)
                    {
                        thsfile[i] = 255;
                    }
                    else
                    {
                        thsfile[i] = (Byte)((int)thsfile[i] - 1);
                    }
                }
                File.WriteAllBytes(textBox1.Text, thsfile);
            }
        }
    }
}
