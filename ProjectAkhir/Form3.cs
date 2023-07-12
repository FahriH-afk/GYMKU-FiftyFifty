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

    public partial class Form3 : Form
    {
        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;
        public Form3()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        public void refreshform()
        {
            nmp.Text = "";
            idp.Text = "";
            edp.Text = "";
            adp.Text = "";
            sdp.Text = "";
            nmp.Enabled = false;
            idp.Enabled = false;
            edp.Enabled = false;
            adp.Enabled = false;
            sdp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id, nama, alamat, spesialis, experience from dbo.trainer";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            nmp.Enabled = true;
            idp.Enabled = true;
            edp.Enabled = true;
            adp.Enabled = true;
            sdp.Enabled = true;
            btnsave.Enabled = true;
            btndelete.Enabled = true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id = nmp.Text;
            string nama = idp.Text;
            string alamat = adp.Text;
            string spesialis = sdp.Text;
            string experience = edp.Text;
            if (id == "")
            {
                MessageBox.Show("Masukkan Id ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (alamat == "")
            {
                MessageBox.Show("Masukkan Alamat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (spesialis == "")
            {
                MessageBox.Show("Masukkan Spesialis", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (spesialis == "")
            {
                MessageBox.Show("Masukkan Experience", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                koneksi.Open();
                string str = "Insert Into trainer (id, nama, alamat, spesialis, experience) values (@nmp, @idp, @adp, @sdp, @edp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@idp", nama));
                cmd.Parameters.Add(new SqlParameter("@nmp", id));
                cmd.Parameters.Add(new SqlParameter("@adp", alamat));
                cmd.Parameters.Add(new SqlParameter("@sdp", spesialis));
                cmd.Parameters.Add(new SqlParameter("@edp", experience));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
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
    }
}
