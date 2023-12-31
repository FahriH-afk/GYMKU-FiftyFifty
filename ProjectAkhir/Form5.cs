﻿using System;
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
    public partial class Form5 : Form
    {
        private string stringConnection = "data source = LAPTOP-SAQOFK2U\\ACERNITRO;database=fitnes;User Id = sa; Password = 123";
        private SqlConnection koneksi;
        public Form5()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        public void refreshform()
        {
            nmp.Text = "";
            ddp.Text = "";
            pdp.Text = "";
            adp.Text = "";
            nmp.Enabled = false;
            ddp.Enabled = false;
            pdp.Enabled = false;
            adp.Enabled = false;
            btnsave.Enabled = false;
            btndelete.Enabled = false;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id, durasi, price, active from dbo.pr_latihan";
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            string id = nmp.Text;
            string durasi = ddp.Text;
            string price = pdp.Text;
            string active = adp.Text;

            if (id == "")
            {
                MessageBox.Show("Masukkan Id", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (durasi == "")
            {
                MessageBox.Show("Masukkan Durasi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (price == "")
            {
                MessageBox.Show("Masukkan Price", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (active == "")
            {
                MessageBox.Show("Masukkan Active", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            else
            {
                koneksi.Open();
                string str = "Insert Into pr_latihan (id, durasi, price, active) values (@nmp, @ddp, @pdp, @adp)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.Parameters.Add(new SqlParameter("@nmp", id));
                cmd.Parameters.Add(new SqlParameter("@ddp", durasi));
                cmd.Parameters.Add(new SqlParameter("@pdp", price));
                cmd.Parameters.Add(new SqlParameter("@adp", active));
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
            ddp.Enabled = true;
            pdp.Enabled = true;
            adp.Enabled = true;
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
