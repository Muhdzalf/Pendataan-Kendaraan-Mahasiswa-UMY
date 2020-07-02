namespace PABD_TugasAkhir
{
    partial class PageMhs
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageMhs));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtFakultas = new System.Windows.Forms.TextBox();
            this.txtJurusan = new System.Windows.Forms.TextBox();
            this.txtAngkatan = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kendaraanDBDataSet = new PABD_TugasAkhir.KendaraanDBDataSet();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTambahKendaraan = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.kendaraanTableAdapter = new PABD_TugasAkhir.KendaraanDBDataSetTableAdapters.KendaraanTableAdapter();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.kendaraanDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btn_logout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Biodata";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NIM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fakultas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Jurusan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Angkatan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 36);
            this.label7.TabIndex = 6;
            this.label7.Text = "Selamat Datang, Mahasiswa";
            // 
            // txtNIM
            // 
            this.txtNIM.Location = new System.Drawing.Point(125, 119);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(134, 22);
            this.txtNIM.TabIndex = 7;
            this.txtNIM.TextChanged += new System.EventHandler(this.txtNIM_TextChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(125, 145);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(215, 22);
            this.txtNama.TabIndex = 8;
            // 
            // txtFakultas
            // 
            this.txtFakultas.Location = new System.Drawing.Point(125, 172);
            this.txtFakultas.Name = "txtFakultas";
            this.txtFakultas.Size = new System.Drawing.Size(170, 22);
            this.txtFakultas.TabIndex = 9;
            // 
            // txtJurusan
            // 
            this.txtJurusan.Location = new System.Drawing.Point(125, 200);
            this.txtJurusan.Name = "txtJurusan";
            this.txtJurusan.Size = new System.Drawing.Size(170, 22);
            this.txtJurusan.TabIndex = 10;
            // 
            // txtAngkatan
            // 
            this.txtAngkatan.Location = new System.Drawing.Point(125, 230);
            this.txtAngkatan.Name = "txtAngkatan";
            this.txtAngkatan.Size = new System.Drawing.Size(95, 22);
            this.txtAngkatan.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 103);
            this.dataGridView1.TabIndex = 12;
            // 
            // kendaraanBindingSource
            // 
            this.kendaraanBindingSource.DataMember = "Kendaraan";
            this.kendaraanBindingSource.DataSource = this.kendaraanDBDataSet;
            // 
            // kendaraanDBDataSet
            // 
            this.kendaraanDBDataSet.DataSetName = "KendaraanDBDataSet";
            this.kendaraanDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Data Kendaraan";
            // 
            // btnTambahKendaraan
            // 
            this.btnTambahKendaraan.Location = new System.Drawing.Point(522, 426);
            this.btnTambahKendaraan.Name = "btnTambahKendaraan";
            this.btnTambahKendaraan.Size = new System.Drawing.Size(150, 35);
            this.btnTambahKendaraan.TabIndex = 15;
            this.btnTambahKendaraan.Text = "Tambah";
            this.btnTambahKendaraan.UseVisualStyleBackColor = true;
            this.btnTambahKendaraan.Click += new System.EventHandler(this.btnTambahKendaraan_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(356, 139);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(356, 194);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(125, 258);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(170, 22);
            this.txtPass.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 261);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Password";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(125, 91);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(74, 22);
            this.txtid.TabIndex = 21;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 94);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mahasiswa id";
            // 
            // kendaraanDBDataSetBindingSource
            // 
            this.kendaraanDBDataSetBindingSource.DataSource = this.kendaraanDBDataSet;
            this.kendaraanDBDataSetBindingSource.Position = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.Location = new System.Drawing.Point(522, 12);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(150, 35);
            this.btn_logout.TabIndex = 14;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // PageMhs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 473);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnTambahKendaraan);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAngkatan);
            this.Controls.Add(this.txtJurusan);
            this.Controls.Add(this.txtFakultas);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "PageMhs";
            this.Text = "Akun Mahasiswa";
            this.Load += new System.EventHandler(this.PageMhs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTambahKendaraan;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSave;
        private KendaraanDBDataSet kendaraanDBDataSet;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private KendaraanDBDataSetTableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtNIM;
        public System.Windows.Forms.TextBox txtNama;
        public System.Windows.Forms.TextBox txtFakultas;
        public System.Windows.Forms.TextBox txtJurusan;
        public System.Windows.Forms.TextBox txtAngkatan;
        public System.Windows.Forms.TextBox txtPass;
        public System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource kendaraanDBDataSetBindingSource;
        private System.Windows.Forms.Button btn_logout;
    }
}