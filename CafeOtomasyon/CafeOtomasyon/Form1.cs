using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CafeOtomasyon
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }
        void SiparisGetir()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-5DAU57K\\SEYID;Initial Catalog=CafeData1;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT *FROM siparis2",baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SiparisGetir();
            button2.Enabled = false;
        }

        private void cayartıbutton_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caySayisiLabel.Text);
            caysayisi++;
            caySayisiLabel.Text=Convert.ToString(caysayisi);
            lblcayucreti.Text = Convert.ToString(caysayisi * 3);
        }

        private void cayeksibutton_Click(object sender, EventArgs e)
        {
            int caysayisi = Convert.ToInt32(caySayisiLabel.Text);
            if (caysayisi > 0)
            {
                caysayisi--;
                caySayisiLabel.Text = Convert.ToString(caysayisi);
                lblcayucreti.Text = Convert.ToString(caysayisi * 3);
            }
        }

        private void kahveartıbutton_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            kahvesayisi++;
            kahveSayisiLabel.Text = Convert.ToString(kahvesayisi);
            lblkahveucreti.Text=Convert.ToString(kahvesayisi * 10);
        }

        private void kahveeksibutton_Click(object sender, EventArgs e)
        {
            int kahvesayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            if (kahvesayisi > 0)
            {
                kahvesayisi--;
                kahveSayisiLabel.Text = Convert.ToString(kahvesayisi);
                lblkahveucreti.Text = Convert.ToString(kahvesayisi * 10);
            }
        }

        private void kolaartıbutton_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolaSayisilabel.Text);
            kolasayisi++;
            kolaSayisilabel.Text=Convert.ToString(kolasayisi);
            lblkolaucreti.Text = Convert.ToString(kolasayisi * 8);
        }

        private void kolaeksinbutton_Click(object sender, EventArgs e)
        {
            int kolasayisi = Convert.ToInt32(kolaSayisilabel.Text);
            if (kolasayisi > 0)
            {
                kolasayisi--;
                kolaSayisilabel.Text = Convert.ToString(kolasayisi);
                lblkolaucreti.Text = Convert.ToString(kolasayisi * 8);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            caySayisiLabel.Text = "0";
            kahveSayisiLabel.Text="0";
            kolaSayisilabel.Text="0";
            lblcayucreti.Text="0";
            lblkahveucreti.Text = "0";
            lblkolaucreti.Text="0";
            lbltoplamucret.Text="0";
        }
        private void btnsiparisver_Click(object sender, EventArgs e)
        {
            lbltoplamucret.Text = Convert.ToString(Convert.ToInt32(lblcayucreti.Text) + Convert.ToInt32(lblkahveucreti.Text) + Convert.ToInt32(lblkolaucreti.Text));
            button2.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO siparis2(Caysayisi,Kahvesayisi,Kolasayisi,Cayucreti,Kahveucreti,Kolaucreti,toplamucret) VALUES (@Caysayisi,@Kahvesayisi,@Kolasayisi,@Cayucreti,@Kahveucreti,@Kolaucreti,@toplamucret)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@Caysayisi",caySayisiLabel.Text);
            komut.Parameters.AddWithValue("@Kahvesayisi", kahveSayisiLabel.Text);
            komut.Parameters.AddWithValue("@Kolasayisi", kolaSayisilabel.Text);
            komut.Parameters.AddWithValue("@Cayucreti", lblcayucreti.Text);
            komut.Parameters.AddWithValue("@Kahveucreti", lblkahveucreti.Text);
            komut.Parameters.AddWithValue("@Kolaucreti",lblkolaucreti.Text);
            komut.Parameters.AddWithValue("@toplamucret", lbltoplamucret.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            SiparisGetir();
        }

       
    }
}
