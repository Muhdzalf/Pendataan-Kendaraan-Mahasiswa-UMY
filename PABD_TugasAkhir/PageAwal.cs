using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PABD_TugasAkhir
{
    public partial class PageAwal : Form
    {
        public PageAwal()
        {
            InitializeComponent();
        }

        private void btn_LoginPage_Click(object sender, EventArgs e)
        {
            Login_Mhs login = new Login_Mhs();
            this.Hide();
            login.Show();

        }

        private void btn_Admin_Click(object sender, EventArgs e)
        {
            Login_Adm LA = new Login_Adm();
            this.Hide();
            LA.Show();
        }

        private void PageAwal_Load(object sender, EventArgs e)
        {

        }
    }
}
