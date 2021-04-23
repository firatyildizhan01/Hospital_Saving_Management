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
    public partial class hastadetay : Form
    {
        public hastadetay()
        {
            InitializeComponent();
        }
        public string tc;

        SqlBaglanti mjk = new SqlBaglanti();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTc1.Text = tc;

            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From hasta_tablo where HastaTc = @p1", mjk.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTc1.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            mjk.baglanti().Close();


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From TBL_randevular where HastaTc=" + tc, mjk.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            SqlCommand komut2 = new SqlCommand("Select BransAd From branss", mjk.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while(dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);   
            }
            mjk.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Doctor where DoktorBrans=@p1", mjk.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            mjk.baglanti().Close();
        }
    }
}
