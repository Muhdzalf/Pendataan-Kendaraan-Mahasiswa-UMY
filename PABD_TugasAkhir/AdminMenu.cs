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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adm_AkunMhs akunMhs = new adm_AkunMhs();
            this.Hide();
            akunMhs.Show();
        }

        private void btn_kendaraan_Click(object sender, EventArgs e)
        {
            Adm_kendaraan adm_Kendaraan = new Adm_kendaraan();
            this.Hide();
            adm_Kendaraan.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            PageAwal page = new PageAwal();
            this.Hide();
            page.Show();
        }
    }
}
