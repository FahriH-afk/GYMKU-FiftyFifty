using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjectAkhir
{
    public partial class Form7 : Form
    {
        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;
        public Form7()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        public  void refreshform()
        {
            nmp.Text = "";
            ddp.Text = "";
            nmp.Enabled = false;
            ddp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_tr, durasi from dbo.masa_kerja";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            GYMKITA fm = new GYMKITA();
            fm.Show();
            this.Hide();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            ddp.Enabled = true;
            btnsave.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id_tr = nmp.Text;
            string durasi = ddp.Text;

            if (id_tr == "")
            {
                MessageBox.Show("Masukkan Id Trainer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (durasi == "")
            {
                MessageBox.Show("Masukkan Durasi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "Insert Into masa_Kerja (id_tr, durasi) values (@nmp, @ddp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@ddp", durasi));
                cmd.Parameters.Add(new SqlParameter("@nmp", id_tr));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }
    }
}
