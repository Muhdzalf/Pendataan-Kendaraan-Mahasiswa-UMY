namespace PABD_TugasAkhir
{
    partial class Login_Adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Adm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpassAdm = new System.Windows.Forms.TextBox();
            this.txtuserAdm = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_LoginAdm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 55);
            this.label3.TabIndex = 13;
            this.label3.Text = "Login Admin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Username";
            // 
            // txtpassAdm
            // 
            this.txtpassAdm.Location = new System.Drawing.Point(319, 199);
            this.txtpassAdm.Name = "txtpassAdm";
            this.txtpassAdm.Size = new System.Drawing.Size(242, 22);
            this.txtpassAdm.TabIndex = 10;
            // 
            // txtuserAdm
            // 
            this.txtuserAdm.Location = new System.Drawing.Point(319, 170);
            this.txtuserAdm.Name = "txtuserAdm";
            this.txtuserAdm.Size = new System.Drawing.Size(242, 22);
            this.txtuserAdm.TabIndex = 9;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(443, 236);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(118, 26);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_LoginAdm
            // 
            this.btn_LoginAdm.Location = new System.Drawing.Point(319, 236);
            this.btn_LoginAdm.Name = "btn_LoginAdm";
            this.btn_LoginAdm.Size = new System.Drawing.Size(118, 26);
            this.btn_LoginAdm.TabIndex = 7;
            this.btn_LoginAdm.Text = "Login";
            this.btn_LoginAdm.UseVisualStyleBackColor = true;
            this.btn_LoginAdm.Click += new System.EventHandler(this.btn_LoginAdm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Login_Adm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpassAdm);
            this.Controls.Add(this.txtuserAdm);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_LoginAdm);
            this.Name = "Login_Adm";
            this.Text = "Login_Adm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpassAdm;
        private System.Windows.Forms.TextBox txtuserAdm;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_LoginAdm;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}