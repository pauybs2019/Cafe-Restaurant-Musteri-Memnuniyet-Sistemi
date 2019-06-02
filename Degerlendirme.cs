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
    public partial class Degerlendirme : Form
    {
        public Degerlendirme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void verilerigöster()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select servis, calisan, urun, aciklama from sonuc", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["servis"].ToString();
                ekle.SubItems.Add(oku["calisan"].ToString());
                ekle.SubItems.Add(oku["urun"].ToString());
                ekle.SubItems.Add(oku["aciklama"].ToString());
                //ekle.SubItems.Add(oku["kategoriad"].ToString());

                listSonuc.Items.Add(ekle);
            }

            baglanti.Close();
        }
        private void btnSonucGoster_Click(object sender, EventArgs e)
        {
            verilerigöster();
        }

        private void Degerlendirme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'cafeDataSet14.masalar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.masalarTableAdapter.Fill(this.cafeDataSet14.masalar);

        }
    }
}
