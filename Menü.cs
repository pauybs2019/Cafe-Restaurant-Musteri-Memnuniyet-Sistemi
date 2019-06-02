using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cafeotomasyon
{
    public partial class Menü : Form
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            Masalar masalar = new Masalar();
            masalar.Show();
            this.Hide();
                
            
        }

        private void btnMusteriler_Click(object sender, EventArgs e)
        {
            Musteriler musteriler = new Musteriler();
            musteriler.Show();
            this.Hide();
                
        }

        private void btnMutfak_Click(object sender, EventArgs e)
        {
            Mutfak mutfak = new Mutfak();
            mutfak.Show();
            this.Hide();
        }

        private void btnRezarvasyon_Click(object sender, EventArgs e)
        {
            Rezarvasyon rezarvasyon = new Rezarvasyon();
            rezarvasyon.Show();
            this.Hide();
        }

        private void btnYonetici_Click(object sender, EventArgs e)
        {
            Yonetici yonetici = new Yonetici();
            yonetici.Show();
            this.Hide();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa kasa = new Kasa();

            kasa.Show();
            this.Hide();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            Degerlendirme degerlendirme = new Degerlendirme();
            degerlendirme.Show();
            this.Hide();
        }

        private void btnKilit_Click(object sender, EventArgs e)
        {
            YetkiliGiris yetkiliGiris = new YetkiliGiris();
            yetkiliGiris.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
