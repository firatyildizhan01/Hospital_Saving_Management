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

namespace Hospital_Saving_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlBaglanti bgl = new SqlBaglanti();
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("İnsert into hasta_tablo (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskAd.Text);
            komut.Parameters.AddWithValue("@p2", mskSoyad.Text);
            komut.Parameters.AddWithValue("@p3",mskTc.Text );
            komut.Parameters.AddWithValue("@p4",mskTel.Text );
            komut.Parameters.AddWithValue("@p5",mskŞifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("kaydınız gerçekleşmiştir Şifreniz:" + mskŞifre.Text, "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
