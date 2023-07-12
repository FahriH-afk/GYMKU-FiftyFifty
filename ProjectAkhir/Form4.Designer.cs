namespace ProjectAkhir
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pdp = new System.Windows.Forms.DateTimePicker();
            this.idp = new System.Windows.Forms.TextBox();
            this.nmp = new System.Windows.Forms.TextBox();
            this.bdp = new System.Windows.Forms.TextBox();
            this.NamaMahasiswa = new System.Windows.Forms.Label();
            this.TanggalLahir = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tdp = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnopen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdp
            // 
            this.pdp.Location = new System.Drawing.Point(555, 250);
            this.pdp.Name = "pdp";
            this.pdp.Size = new System.Drawing.Size(152, 22);
            this.pdp.TabIndex = 23;
            this.pdp.ValueChanged += new System.EventHandler(this.pdp_ValueChanged);
            // 
            // idp
            // 
            this.idp.Location = new System.Drawing.Point(555, 143);
            this.idp.Name = "idp";
            this.idp.Size = new System.Drawing.Size(212, 22);
            this.idp.TabIndex = 20;
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(555, 109);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(212, 22);
            this.nmp.TabIndex = 19;
            // 
            // bdp
            // 
            this.bdp.Location = new System.Drawing.Point(555, 216);
            this.bdp.Name = "bdp";
            this.bdp.Size = new System.Drawing.Size(212, 22);
            this.bdp.TabIndex = 18;
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.AutoSize = true;
            this.NamaMahasiswa.Location = new System.Drawing.Point(427, 143);
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.Size = new System.Drawing.Size(44, 16);
            this.NamaMahasiswa.TabIndex = 17;
            this.NamaMahasiswa.Text = "Nama";
            // 
            // TanggalLahir
            // 
            this.TanggalLahir.AutoSize = true;
            this.TanggalLahir.Location = new System.Drawing.Point(427, 255);
            this.TanggalLahir.Name = "TanggalLahir";
            this.TanggalLahir.Size = new System.Drawing.Size(96, 16);
            this.TanggalLahir.TabIndex = 16;
            this.TanggalLahir.Text = "Purchase Date";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(427, 176);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(39, 16);
            this.JenisKelamin.TabIndex = 15;
            this.JenisKelamin.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Brand";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // tdp
            // 
            this.tdp.Location = new System.Drawing.Point(555, 176);
            this.tdp.Name = "tdp";
            this.tdp.Size = new System.Drawing.Size(212, 22);
            this.tdp.TabIndex = 24;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(430, 311);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 25;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(430, 357);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 26;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(692, 311);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(23, 415);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 28;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "GYMKU";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(351, 324);
            this.dataGridView1.TabIndex = 30;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(692, 357);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 31;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.tdp);
            this.Controls.Add(this.pdp);
            this.Controls.Add(this.idp);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.bdp);
            this.Controls.Add(this.NamaMahasiswa);
            this.Controls.Add(this.TanggalLahir);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Data Alat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker pdp;
        private System.Windows.Forms.TextBox idp;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.TextBox bdp;
        private System.Windows.Forms.Label NamaMahasiswa;
        private System.Windows.Forms.Label TanggalLahir;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tdp;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnopen;
    }
}