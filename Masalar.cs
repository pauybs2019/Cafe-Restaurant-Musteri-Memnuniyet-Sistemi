using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace cafeotomasyon
{
    public partial class Masalar : Form
    {
        public Masalar()
        {
            InitializeComponent();
            msnCnt();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void Masalar_Load(object sender, EventArgs e)
        {

        }

        private void btnMasa1_Click(object sender, EventArgs e)
        {
            Siparis siparis = new Siparis();
            siparis.Show();
            siparis.textBox1.Text = btnMasa1.Text;
            siparis.masaId = 1;
            siparis.datalariGoster(siparis.masaId);
            this.Hide();


        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }

        public int masalarKontrol(int masaID)
        {
            int result = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select count (masaID)as mscnt from siparis where masaID="+masaID+"", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                result = int.Parse(oku["mscnt"].ToString());
            }

            baglanti.Close();
            return result;
        }
        public void msnCnt()
        {
            int result = masalarKontrol(1);
            if (result == 0)
            {
                btnMasa1.BackgroundImage = Image.FromFile("C:\\Users\\adem\\Desktop\\cafeotomasyon\\cafeotomasyon\\cafeotomasyon\\resimler\\bosmasa.png");
            }
            else
            {
                btnMasa1.BackgroundImage = Image.FromFile("C:\\Users\\adem\\Desktop\\cafeotomasyon\\cafeotomasyon\\cafeotomasyon\\resimler\\dolumasa.png");
            }
        }

    }
}
