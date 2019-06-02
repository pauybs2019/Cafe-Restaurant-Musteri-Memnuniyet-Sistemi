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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        private void Yonetici_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from yonetici", baglanti);
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                ListViewItem item = new ListViewItem(dr["yoneticiID"].ToString());
                item.SubItems.Add(dr["ad"].ToString());
                item.SubItems.Add(dr["soyad"].ToString());
                item.SubItems.Add(dr["parola"].ToString());
                listYonetici.Items.Add(item);

            }
            baglanti.Close();
            listYonetici.Refresh();
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into yonetici (ad,soyad,parola) values ('" + textAD.Text + "','" + textSoyad.Text + "','" + textParola.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Kayıt Yapıldı.");
            baglanti.Close();
        }

        private void btnYoneticiGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("update yonetici set ad='" + textAD.Text + "',soyad='" + textSoyad.Text + "',parola='" + textParola.Text + "' where yoneticiID=" + textID.Text + "", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Güncelleme Yapıldı.");
            baglanti.Close();

        }

        private void listYonetici_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listYonetici.SelectedItems.Count > 0)
            {
                textID.Text = listYonetici.SelectedItems[0].SubItems[0].Text;
                textAD.Text = listYonetici.SelectedItems[0].SubItems[1].Text;
                textSoyad.Text = listYonetici.SelectedItems[0].SubItems[2].Text;
                textParola.Text = listYonetici.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from yonetici where yoneticiID=" + textID.Text + "", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Silindi");
            
            baglanti.Close();
           
        }
    }
}
