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

namespace PABD_TugasAkhir
{
    public partial class Login_Adm : Form
    {
        
        public Login_Adm()
        {
            InitializeComponent();
        }

        private static string getConnectionString()
        {
            return "Data Source=DZALFIQ;Initial Catalog=KendaraanDB;User ID=SA;Password=jasmerah";
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            PageAwal PA = new PageAwal();
            this.Hide();
            PA.Show();
        }

        private void btn_LoginAdm_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT (*) from UserAdmin WHERE Username= '" + txtuserAdm.Text + "' and Password='" + txtpassAdm.Text + "'", connect);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                AdminMenu adm = new AdminMenu();
                adm.Show();
            }
            else
            {
                MessageBox.Show("Password atau Username Salah", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connect.Close();
        }
    }
}
