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
    public partial class Form4 : Form
    {

        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;
        public Form4()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        public void refreshform()
        {
            nmp.Text = "";
            idp.Text = "";
            tdp.Text = "";
            bdp.Text = "";
            pdp.Text = "";
            nmp.Enabled = false;
            idp.Enabled = false;
            tdp.Enabled = false;
            bdp.Enabled = false;
            pdp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id, nama, tipe,  brand, purchase_date from dbo.alat";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id = nmp.Text;
            string nama = idp.Text;
            string type = tdp.Text;
            string brand = bdp.Text;
            string purchase_Date = pdp.Text;

            if (id == "")
            {
                MessageBox.Show("Masukkan Id ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (type == "")
            {
                MessageBox.Show("Masukkan Type", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (brand == "")
            {
                MessageBox.Show("Masukkan Brand", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (purchase_Date == "")
            {
                MessageBox.Show("Masukkan Purchase Date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                koneksi.Open();
                string str = "Insert Into alat (id, nama, tipe,  brand, purchase_date) values (@nmp, @idp, @tdp, @bdp, @pdp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@idp", nama));
                cmd.Parameters.Add(new SqlParameter("@nmp", id));
                cmd.Parameters.Add(new SqlParameter("@tdp", type));
                cmd.Parameters.Add(new SqlParameter("@bdp", brand));
                cmd.Parameters.Add(new SqlParameter("@pdp", purchase_Date));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            idp.Enabled = true;
            tdp.Enabled = true;
            bdp.Enabled = true;
            pdp.Enabled = true;
            btnsave.Enabled = true;
            btndelete.Enabled = true;
        }

        private void pdp_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
