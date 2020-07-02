namespace PABD_TugasAkhir
{
    partial class Adm_kendaraan
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
            this.gvAdminKendaraan = new System.Windows.Forms.DataGridView();
            this.kendaraanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kendaraanDBDataSet = new PABD_TugasAkhir.KendaraanDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.kendaraanTableAdapter = new PABD_TugasAkhir.KendaraanDBDataSetTableAdapters.KendaraanTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminKendaraan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // gvAdminKendaraan
            // 
            this.gvAdminKendaraan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAdminKendaraan.Location = new System.Drawing.Point(32, 102);
            this.gvAdminKendaraan.Name = "gvAdminKendaraan";
            this.gvAdminKendaraan.RowTemplate.Height = 24;
            this.gvAdminKendaraan.Size = new System.Drawing.Size(746, 288);
            this.gvAdminKendaraan.TabIndex = 19;
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
            this.label1.Location = new System.Drawing.Point(234, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kendaraan Mahasiswa";
            // 
            // kendaraanTableAdapter
            // 
            this.kendaraanTableAdapter.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(703, 403);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 44;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(622, 403);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 35);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Adm_kendaraan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gvAdminKendaraan);
            this.Controls.Add(this.label1);
            this.Name = "Adm_kendaraan";
            this.Text = "Admin Kendaraan";
            this.Load += new System.EventHandler(this.Adm_kendaraan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvAdminKendaraan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kendaraanDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gvAdminKendaraan;
        private System.Windows.Forms.Label label1;
        private KendaraanDBDataSet kendaraanDBDataSet;
        private System.Windows.Forms.BindingSource kendaraanBindingSource;
        private KendaraanDBDataSetTableAdapters.KendaraanTableAdapter kendaraanTableAdapter;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
    }
}