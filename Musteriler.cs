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

namespace cafeotomasyon
{
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\;Initial Catalog=cafe;Integrated Security=True");
        private void Musteriler_Load(object sender, EventArgs e)
        {

            verilerigöster();
        }
        public void verilerigöster()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from musteriler", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["musteriID"].ToString();
                ekle.SubItems.Add(oku["musteriad"].ToString());
                ekle.SubItems.Add(oku["musterisoyad"].ToString());
                ekle.SubItems.Add(oku["telefon"].ToString());
                ekle.SubItems.Add(oku["adres"].ToString());

                listMüsteri.Items.Add(ekle);
            }

            baglanti.Close();
        }

        
        private void btnYeniMusteriEkleme_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into musteriler(musteriad,musterisoyad,telefon) values ('"+textAD.Text+"','"+textSoyad.Text+"','"+textTelefon.Text+"')",baglanti);
            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Eklendi");
            listMüsteri.Refresh();

            baglanti.Close();

   
               
            
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update musteriler set musteriad='"+textAD.Text+"',musterisoyad='"+textSoyad.Text+"',telefon='"+textTelefon.Text+"' where musteriID='"+textMusteriID.Text+"'",baglanti);
            komut.ExecuteNonQuery();

            MessageBox.Show("GÜncelleme Yapıldı.");

            

            baglanti.Close();


            verilerigöster();


        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("delete from musteriler where musteriID='"+textMusteriID.Text+"'", baglanti);
            komut.ExecuteNonQuery();

            MessageBox.Show("Kayıt Silindi");

            baglanti.Close();
            
        }

        private void listMüsteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            

                ListViewItem item = listMüsteri.SelectedItems[0];

                textMusteriID.Text = item.SubItems[0].Text;

                textAD.Text = item.SubItems[1].Text;

                textSoyad.Text = item.SubItems[2].Text;

                textTelefon.Text = item.SubItems[3].Text;

            
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }
    }
}
