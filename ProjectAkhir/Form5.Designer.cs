namespace ProjectAkhir
{
    partial class Form5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pdp = new System.Windows.Forms.TextBox();
            this.ddp = new System.Windows.Forms.TextBox();
            this.nmp = new System.Windows.Forms.TextBox();
            this.adp = new System.Windows.Forms.TextBox();
            this.NamaMahasiswa = new System.Windows.Forms.Label();
            this.JenisKelamin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(390, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(398, 376);
            this.dataGridView1.TabIndex = 12;
            // 
            // pdp
            // 
            this.pdp.Location = new System.Drawing.Point(148, 223);
            this.pdp.Name = "pdp";
            this.pdp.Size = new System.Drawing.Size(212, 22);
            this.pdp.TabIndex = 32;
            // 
            // ddp
            // 
            this.ddp.Location = new System.Drawing.Point(148, 190);
            this.ddp.Name = "ddp";
            this.ddp.Size = new System.Drawing.Size(212, 22);
            this.ddp.TabIndex = 31;
            // 
            // nmp
            // 
            this.nmp.Location = new System.Drawing.Point(148, 156);
            this.nmp.Name = "nmp";
            this.nmp.Size = new System.Drawing.Size(212, 22);
            this.nmp.TabIndex = 30;
            // 
            // adp
            // 
            this.adp.Location = new System.Drawing.Point(148, 263);
            this.adp.Name = "adp";
            this.adp.Size = new System.Drawing.Size(212, 22);
            this.adp.TabIndex = 29;
            // 
            // NamaMahasiswa
            // 
            this.NamaMahasiswa.AutoSize = true;
            this.NamaMahasiswa.Location = new System.Drawing.Point(20, 190);
            this.NamaMahasiswa.Name = "NamaMahasiswa";
            this.NamaMahasiswa.Size = new System.Drawing.Size(46, 16);
            this.NamaMahasiswa.TabIndex = 28;
            this.NamaMahasiswa.Text = "Durasi";
            // 
            // JenisKelamin
            // 
            this.JenisKelamin.AutoSize = true;
            this.JenisKelamin.Location = new System.Drawing.Point(20, 223);
            this.JenisKelamin.Name = "JenisKelamin";
            this.JenisKelamin.Size = new System.Drawing.Size(38, 16);
            this.JenisKelamin.TabIndex = 27;
            this.JenisKelamin.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Active";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Id";
            // 
            // btnsave
            // 
            this.btnsave.ForeColor = System.Drawing.Color.Black;
            this.btnsave.Location = new System.Drawing.Point(23, 314);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 33;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(23, 374);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 34;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Location = new System.Drawing.Point(276, 313);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 23);
            this.btnadd.TabIndex = 35;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnopen
            // 
            this.btnopen.ForeColor = System.Drawing.Color.Black;
            this.btnopen.Location = new System.Drawing.Point(276, 374);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 36;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // btnclose
            // 
            this.btnclose.ForeColor = System.Drawing.Color.Black;
            this.btnclose.Location = new System.Drawing.Point(713, 415);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 37;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.pdp);
            this.Controls.Add(this.ddp);
            this.Controls.Add(this.nmp);
            this.Controls.Add(this.adp);
            this.Controls.Add(this.NamaMahasiswa);
            this.Controls.Add(this.JenisKelamin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Form5";
            this.Text = "Data Program Latihan";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox pdp;
        private System.Windows.Forms.TextBox ddp;
        private System.Windows.Forms.TextBox nmp;
        private System.Windows.Forms.TextBox adp;
        private System.Windows.Forms.Label NamaMahasiswa;
        private System.Windows.Forms.Label JenisKelamin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclose;
    }
}