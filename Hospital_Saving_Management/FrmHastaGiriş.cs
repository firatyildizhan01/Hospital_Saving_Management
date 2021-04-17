using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Saving_Management
{
    public partial class FrmHastaGiriş : Form
    {
        public FrmHastaGiriş()
        {
            InitializeComponent();
        }

        private void FrmHastaGiriş_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lnkÜye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 jhg = new Form2();
            jhg.Show();
            this.Hide();
        }
    }
}
