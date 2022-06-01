namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private char islem;
        private bool _ekrantemizle;
        private int _ilksayi;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if(label1.Text == "0")
            {
                label1.Text = "";
            }
            label1.Text += "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle) 
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "3";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
           
            label1.Text += "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "5";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "6";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "7";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "8";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizle)
            {
                label1.Text = "";
                _ekrantemizle = false;
            }
            if (label1.Text == "0")
            {
                label1.Text = "";
            }
            
            label1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            islem = '+';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            islem = '-';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            islem = 'x';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = '/';
            _ekrantemizle = true;
            _ilksayi = Convert.ToInt32(label1.Text);
        }
        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(label1.Text);
            int sonuc;
            switch (islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case 'x':
                    sonuc = _ilksayi * ikincisayi;
                    break ;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
                default:
                    sonuc = 0;
                    break;

            }
            label1.Text = Convert.ToString(sonuc);
        }

        
    }
}