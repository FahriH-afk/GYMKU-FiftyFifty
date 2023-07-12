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
    public partial class Form2 : Form
    {
        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;

        public void refreshform()
        {
            nmp.Text = "";
            idp.Text = "";
            idp.Enabled = false;
            nmp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;

        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id, nama from dbo.pelanggan";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        public Form2()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clsbtn_Click(object sender, EventArgs e)
        {
            GYMKITA fm = new GYMKITA();
            fm.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = nmp.Text;
            string nama = idp.Text;

            if (id == "")
            {
                MessageBox.Show("Masukkan Id ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (nama == "")
            {
                MessageBox.Show("Masukkan Nama ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "Insert Into pelanggan (id, nama) values (@nmp, @idp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@idp", id));
                cmd.Parameters.Add(new SqlParameter("@nmp", nama));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            idp.Enabled = true;
            nmp.Enabled = true;
            btndelete.Enabled = true;
            btnsave.Enabled = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnopen.Enabled = false;
        }
    }
}
