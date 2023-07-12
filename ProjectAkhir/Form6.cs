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

namespace ProjectAkhir
{
    public partial class Form6 : Form
    {
        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;
        public Form6()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        public void refreshform()
        {
            nmp.Text = "";
            sdp.Text = "";
            nmp.Enabled = false;
            sdp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pg, status_p from dbo.jenis_pelanggan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GYMKITA fm = new GYMKITA();
            fm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_pg = nmp.Text;
            string status_p = sdp.Text;

            if (id_pg == "")
            {
                MessageBox.Show("Masukkan Brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (status_p == "")
            {
                MessageBox.Show("Masukkan Purchase Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                koneksi.Open();
                string str = "Insert Into jenis_pelanggan (id_pg, status_p) values (@nmp, @sdp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@sdp", status_p));
                cmd.Parameters.Add(new SqlParameter("@nmp", id_pg));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            sdp.Enabled = true;
            btnsave.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnopen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }
    }
}
