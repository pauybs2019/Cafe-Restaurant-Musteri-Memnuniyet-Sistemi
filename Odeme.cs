using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeotomasyon
{
    public partial class Odeme : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        public Odeme()
        {
            InitializeComponent();
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Masalar masalar = new Masalar();


            masalar.Show();
            this.Hide();

        }
        public void hesaplama(int masaId)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select sum(urunfiyat) as urnFiyat from siparis as spr inner join urunler as ur on spr.urunID = ur.urunID where spr.masaID = "+masaId+"", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                lbltoplamFiyat.Text = oku["urnFiyat"].ToString();

            }

            baglanti.Close();

        }
    }
}
