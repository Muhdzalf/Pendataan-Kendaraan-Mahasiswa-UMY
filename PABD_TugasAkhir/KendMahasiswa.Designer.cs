namespace PABD_TugasAkhir
{
    partial class KendMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KendMahasiswa));
            this.btn_refresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmerk = new System.Windows.Forms.TextBox();
            this.txtNopol = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gvKendaraanMhs = new System.Windows.Forms.DataGridView();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kendaraanDBDataSet = new PABD_TugasAkhir.KendaraanDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.kendaraanTableAdapter = new PABD_TugasAkhir.KendaraanDBDataSetTableAdapters.KendaraanTableAdapter();
            this.cbJenis = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWarna = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_mhsid = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvKendaraanMhs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(145, 386);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(150, 35);
            this.btn_refresh.TabIndex = 36;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 35);
            this.btnUpdate.TabIndex = 35;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 35);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 35);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Create";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(135, 328);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 32;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Merk";
            // 
            // txtmerk
            // 
            this.txtmerk.Location = new System.Drawing.Point(152, 252);
            this.txtmerk.Name = "txtmerk";
            this.txtmerk.Size = new System.Drawing.Size(162, 22);
            this.txtmerk.TabIndex = 30;
            // 
            // txtNopol
            // 
            this.txtNopol.Location = new System.Drawing.Point(152, 215);
            this.txtNopol.Name = "txtNopol";
            this.txtNopol.Size = new System.Drawing.Size(252, 22);
            this.txtNopol.TabIndex = 29;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(152, 96);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(93, 22);
            this.txtid.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nomor Polisi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Jenis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Kendaraan id";
            // 
            // gvKendaraanMhs
            // 
            this.gvKendaraanMhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvKendaraanMhs.Location = new System.Drawing.Point(446, 96);
            this.gvKendaraanMhs.Name = "gvKendaraanMhs";
            this.gvKendaraanMhs.RowTemplate.Height = 24;
            this.gvKendaraanMhs.Size = new System.Drawing.Size(342, 253);
            this.gvKendaraanMhs.TabIndex = 22;
            this.gvKendaraanMhs.Click += new System.EventHandler(this.gvKendaraanMhs_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(218, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 36);
            this.label1.TabIndex = 21;
            this.label1.Text = "Kendaraan Mahasiswa";
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // cbJenis
            // 
            this.cbJenis.FormattingEnabled = true;
            this.cbJenis.Location = new System.Drawing.Point(152, 172);
            this.cbJenis.Name = "cbJenis";
            this.cbJenis.Size = new System.Drawing.Size(143, 24);
            this.cbJenis.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Warna";
            // 
            // txtWarna
            // 
            this.txtWarna.Location = new System.Drawing.Point(152, 291);
            this.txtWarna.Name = "txtWarna";
            this.txtWarna.Size = new System.Drawing.Size(162, 22);
            this.txtWarna.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Mahasiswa_id";
            // 
            // txt_mhsid
            // 
            this.txt_mhsid.Location = new System.Drawing.Point(152, 134);
            this.txt_mhsid.Name = "txt_mhsid";
            this.txt_mhsid.Size = new System.Drawing.Size(162, 22);
            this.txt_mhsid.TabIndex = 40;
            this.txt_mhsid.TextChanged += new System.EventHandler(this.txt_mhsid_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // KendMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_mhsid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWarna);
            this.Controls.Add(this.cbJenis);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtmerk);
            this.Controls.Add(this.txtNopol);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvKendaraanMhs);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "KendMahasiswa";
            this.Text = "Kendaraan Mahasiswa";
            this.Load += new System.EventHandler(this.KendMahasiswa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKendaraanMhs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmerk;
        private System.Windows.Forms.TextBox txtNopol;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gvKendaraanMhs;
        private System.Windows.Forms.Label label1;
        private KendaraanDBDataSet kendaraanDBDataSet;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private KendaraanDBDataSetTableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.ComboBox cbJenis;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWarna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_mhsid;
        private System.Windows.Forms.Button btnBack;
    }
}