namespace PABD_TugasAkhir
{
    partial class PageAwal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAwal));
            this.btn_LoginPage = new System.Windows.Forms.Button();
            this.btn_Cek = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Admin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_LoginPage
            // 
            this.btn_LoginPage.Location = new System.Drawing.Point(219, 244);
            this.btn_LoginPage.Name = "btn_LoginPage";
            this.btn_LoginPage.Size = new System.Drawing.Size(150, 35);
            this.btn_LoginPage.TabIndex = 0;
            this.btn_LoginPage.Text = "Login Mahasiswa";
            this.btn_LoginPage.UseVisualStyleBackColor = true;
            this.btn_LoginPage.Click += new System.EventHandler(this.btn_LoginPage_Click);
            // 
            // btn_Cek
            // 
            this.btn_Cek.Location = new System.Drawing.Point(312, 406);
            this.btn_Cek.Name = "btn_Cek";
            this.btn_Cek.Size = new System.Drawing.Size(150, 35);
            this.btn_Cek.TabIndex = 1;
            this.btn_Cek.Text = "Cek";
            this.btn_Cek.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selamat Datang";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Admin
            // 
            this.btn_Admin.Location = new System.Drawing.Point(413, 244);
            this.btn_Admin.Name = "btn_Admin";
            this.btn_Admin.Size = new System.Drawing.Size(150, 35);
            this.btn_Admin.TabIndex = 4;
            this.btn_Admin.Text = "Login Admin";
            this.btn_Admin.UseVisualStyleBackColor = true;
            this.btn_Admin.Click += new System.EventHandler(this.btn_Admin_Click);
            // 
            // PageAwal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.btn_Admin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Cek);
            this.Controls.Add(this.btn_LoginPage);
            this.Name = "PageAwal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Selamat Datang";
            this.Load += new System.EventHandler(this.PageAwal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LoginPage;
        private System.Windows.Forms.Button btn_Cek;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Admin;
    }
}

