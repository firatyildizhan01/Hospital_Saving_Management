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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmHastaGiriş grm = new FrmHastaGiriş();
            grm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGiriş ctk = new DoktorGiriş();
            ctk.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sekreterGİriş mjk = new sekreterGİriş();
            mjk.Show();
            this.Hide();
        }
    }
}
