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
    public partial class Rezarvasyon : Form
    {
        public Rezarvasyon()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-25U6SKM\\SQLEXPRESS;Initial Catalog=cafe;Integrated Security=True");
        private void Rezarvasyon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeDataSet11.masalar' table. You can move, or remove it, as needed.
            this.masalarTableAdapter.Fill(this.cafeDataSet11.masalar);
            // TODO: This line of code loads data into the 'cafeDataSet10.masa' table. You can move, or remove it, as needed.
            this.masaTableAdapter2.Fill(this.cafeDataSet10.masa);
            // TODO: This line of code loads data into the 'cafeDataSet9.masa' table. You can move, or remove it, as needed.
            this.masaTableAdapter1.Fill(this.cafeDataSet9.masa);
            // TODO: This line of code loads data into the 'cafeDataSet8.masa' table. You can move, or remove it, as needed.
            this.masaTableAdapter.Fill(this.cafeDataSet8.masa);

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Menü menü = new Menü();
            menü.Show();
            this.Hide();

        }

        private void btnRezarvasyon_Click(object sender, EventArgs e)
        {


            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into rezarvasyon(ad,soyad,tarih,saat,masaID) values ('"+txtAdRezarvasyon.Text+"','"+txtSoyadRezarvasyon.Text+"','"+txtTarihRezarvasyon.Text+"','"+txtSaatRezarvasyon.Text+"','"+cmbMasaRezarvasyon.Text+"')",baglanti);

            komut.ExecuteNonQuery();
                   
                      
            Masalar masalar = new Masalar();
            

            if (cmbMasaRezarvasyon.Text=="Masa 1")
            {
                masalar.btnMasa1.BackgroundImage = Image.FromFile("C:\\Users\\adem\\Desktop\\cafeotomasyon\\cafeotomasyon\\cafeotomasyon\\resimler\\masarezarvasyon.png");

                //masalar.btnMasa1.Text = "("+txtSaatRezarvasyon.Text+")"+" "+txtAdRezarvasyon.Text+" "+txtSoyadRezarvasyon.Text;

                masalar.Show();
                this.Hide();
               
            }

            baglanti.Close();

        }

        private void cmbMasaRezarvasyon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
