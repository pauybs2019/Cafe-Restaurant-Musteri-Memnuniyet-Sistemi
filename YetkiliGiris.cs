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
    public partial class YetkiliGiris : Form
    {
        public YetkiliGiris()
        {
            InitializeComponent();
        }

        private void YetkiliGiris_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (txtKullanici.Text=="Gökhan" && txtSifre.Text=="123")
            {
                Menü menü = new Menü();
                menü.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız");
            }
        }
    }
}
