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
    public partial class Siparis : Form
    {
        public int masaId;
        public Siparis()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        public void verilerigöster(int kategoriID)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from urunler where kategoriID='"+kategoriID+"'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["urunID"].ToString();
                ekle.SubItems.Add(oku["urunad"].ToString());
                ekle.SubItems.Add(oku["urunfiyat"].ToString());
                ekle.SubItems.Add(oku["kategoriID"].ToString());
                ekle.SubItems.Add(oku["kategoriad"].ToString());

                listMenü.Items.Add(ekle);
            }

            baglanti.Close();
        }

        public void verilerigöster_iki(int kategoriID)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("select * from urunler where kategoriID='" + kategoriID + "'", baglanti);

            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["urunID"].ToString();
                ekle.SubItems.Add(oku["urunad"].ToString());
                ekle.SubItems.Add(oku["urunfiyat"].ToString());
                ekle.SubItems.Add(oku["kategoriID"].ToString());
                ekle.SubItems.Add(oku["kategoriad"].ToString());

                listSiparis.Items.Add(ekle);
            }

            baglanti.Close();
        }
        private void btnSıcakIcecekler_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(2);

        }

        private void btnAnaYemek_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(1);

            
        }

        private void Siparis_Load(object sender, EventArgs e)
        {

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            Odeme odeme = new Odeme();
            
            odeme.hesaplama(1);
            odeme.Show();
         
         
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Masalar masalar = new Masalar();
            masalar.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            YetkiliGiris giris = new YetkiliGiris();
            giris.Show();
            this.Hide();
        }

        private void btnPizza_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(8);
        }

        private void btnSogukİcecekler_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(3);

        }

        private void btnTatli_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(4);

        }

        private void btnSalata_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(5);

        }

        private void btnFastFood_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(6);

        }

        private void btnMakarna_Click(object sender, EventArgs e)
        {
            listMenü.Items.Clear();
            verilerigöster(7);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void listMenü_Click(object sender, EventArgs e)
        {
            //ListViewItem list = new ListViewItem();
            //list.Text= listMenü.SelectedItems[0].SubItems[0].Text;
            //list.SubItems.Add(listMenü.SelectedItems[0].SubItems[1].Text);
            //list.SubItems.Add(listMenü.SelectedItems[0].SubItems[2].Text);
            //list.SubItems.Add(listMenü.SelectedItems[0].SubItems[3].Text);
            //list.SubItems.Add(listMenü.SelectedItems[0].SubItems[4].Text);

            //this.listSiparis.Items.Add(list);
            
            
        }

        private void listSiparis_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

         }

        private void listMenü_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void listMenü_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
            
           

        }

        private void listMenü_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void buttonSiparis_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            baglanti.Open();
            string xx = "";
            int masaID = masaId;
            for (int i = 0; i < listMenü.Items.Count; i++)
            {

                xx = listMenü.Items[i].SubItems[0].Text;
                 komut = new SqlCommand("insert into siparis (masaID,urunID) values ("+masaID+","+int.Parse(xx)+")", baglanti);
                komut.ExecuteNonQuery();

            }
            baglanti.Close();


            Masalar masalar = new Masalar();


            masalar.Show();
            this.Hide();
          

        }
        public void datalariGoster(int masaID)
        {
            listSiparis.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select urunID,urunad,urunfiyat,kategoriad from siparisDetay",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();

                ekle.Text = oku["urunID"].ToString();
                ekle.SubItems.Add(oku["urunad"].ToString());
                ekle.SubItems.Add(oku["urunfiyat"].ToString());
                ekle.SubItems.Add(oku["kategoriad"].ToString());

                listSiparis.Items.Add(ekle);
            }
            oku.Close();

            baglanti.Close();

        }

        private void listMenü_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
          

        }

        private void listMenü_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      

        private void listSiparis_ItemCheck(object sender, ItemCheckEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            //string xx = "";
            int masaID = masaId;
            var isaretli = this.listSiparis.CheckedIndices;

            foreach (var item in isaretli)
            {
                ListViewItem l = this.listSiparis.Items[(int)item];
                int itemId = Convert.ToInt32(l.SubItems[0].Text);
                SqlCommand komut = new SqlCommand("delete from siparis where masaID=" + masaID + " and urunID=" + itemId + "", baglanti);
                komut.ExecuteNonQuery();

            }

            baglanti.Close();
            MessageBox.Show("Silme işlemi gerçekleşmiştir.");

            datalariGoster(masaID);



        }
    }
   

}
