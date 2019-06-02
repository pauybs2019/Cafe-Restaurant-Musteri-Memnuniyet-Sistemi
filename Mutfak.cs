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
    public partial class Mutfak : Form
    {
        public Mutfak()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");

        private void verilerigöster()
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from urunler",baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["urunID"].ToString();
                ekle.SubItems.Add(oku["urunad"].ToString());
                ekle.SubItems.Add(oku["urunfiyat"].ToString());
                ekle.SubItems.Add(oku["kategoriID"].ToString());
                ekle.SubItems.Add(oku["kategoriad"].ToString());

                listUrun.Items.Add(ekle);
            }

            baglanti.Close();
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            SqlCommand komut =new SqlCommand("delete from urunler where urunID=" + txt_urunID.Text + "",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Silindi");
          
        }

        private void btnUrunGoster_Click(object sender, EventArgs e)
        {
            grpBoxUrunler.Visible = true;
            verilerigöster();
            
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
           
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into urunler (kategoriID,kategoriad,urunad,urunfiyat) values ('"+cmbKategoriID.Text+"','" + cmbKategori.Text+"','"+txtUrunAdi.Text+"', '"+txtFiyat.Text+"') ",baglanti);

            komut.ExecuteNonQuery();

            MessageBox.Show("Ürün Eklendi");
            
            baglanti.Close();
            verilerigöster();


        }
        
        private void Mutfak_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet.kategori' table. You can move, or remove it, as needed.
            this.kategoriTableAdapter.Fill(this.cafeDataSet.kategori);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();
        }

        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
                      
            SqlCommand komut=new SqlCommand ("update urunler set kategoriID='"+cmbKategoriID.Text+"',kategoriad='" + cmbKategori.Text + "',urunad='" + txtUrunAdi.Text + "',urunfiyat='" + txtFiyat.Text + "' where urunID=" + txt_urunID.Text + "",baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Ürün Güncellendi");
            baglanti.Close();
            
        }

        private void listUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listUrun.SelectedItems.Count > 0)

            {

                ListViewItem item = listUrun.SelectedItems[0];

                //int urunID = int.Parse(item.Text);

                txt_urunID.Text = item.SubItems[0].Text;

                cmbKategoriID.Text = item.SubItems[3].Text;

                cmbKategori.Text = item.SubItems[4].Text;

                txtUrunAdi.Text = item.SubItems[1].Text;

                txtFiyat.Text = item.SubItems[2].Text;

            }
        }
    }
}
