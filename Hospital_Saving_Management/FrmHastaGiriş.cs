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
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }
        SqlBaglanti atd = new SqlBaglanti();
        private void FrmHastaGiriş_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From hasta_tablo Where HastaTc=@p1 and HastaSifre=@p2", atd.baglanti());
            komut.Parameters.Add("@p1", mskTc.Text);
            komut.Parameters.Add("@p2", txtŞifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hastadetay crm = new hastadetay();
                crm.tc = mskTc.Text;
                crm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı tc & şifre");
            }
            atd.baglanti().Close();
        }

        private void lnkÜye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 jhg = new Form2();
            jhg.Show();
            this.Hide();
        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
