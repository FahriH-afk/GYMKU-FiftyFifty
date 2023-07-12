using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAkhir
{
    public partial class GYMKITA : Form
    {
        public GYMKITA()
        {
            InitializeComponent();
        }

        private void GYMKITA_Load(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dataPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Hide();
        }

        private void dataTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fm = new Form3();
            fm.Show();
            this.Hide();
        }

        private void dataAlatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fm = new Form4();
            fm.Show();
            this.Hide();
        }

        private void dataProgramLatihanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fm = new Form5();
            fm.Show();
            this.Hide();
        }

        private void dataMasaKerjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 fm = new Form6();
            fm.Show();
            this.Hide();
        }

        private void dataJenisPelangganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 fm = new Form7();
            fm.Show();
            this.Hide();
        }
    }
}
