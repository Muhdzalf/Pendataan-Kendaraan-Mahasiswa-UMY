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
    public partial class Adm_kendaraan : Form
    {
        public Adm_kendaraan()
        {
            InitializeComponent();
        }

        private static string getConnectionString()
        {
            return "Data Source=DZALFIQ;Initial Catalog=KendaraanDB;User ID=SA;Password=jasmerah";
        }

        private void Adm_kendaraan_Load(object sender, EventArgs e)
        {
            
            string query = "SELECT * FROM Kendaraan Mahasiswa";

            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);
            connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gvAdminKendaraan.DataSource = dt;
            connect.Close();


            btnRefresh_Click(sender, e);

        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);

            try
            {
                /*connect.ConnectionString = connectString;
                connect.Open();
                {
                    string query = "SELECT Kendaraan.Kendaraan_id, Kendaraan.Jenis, Kendaraan.No_Polisi, Kendaraan.Merk, Kendaraan.Warna, Akun_Mahasiswa.Nama_Mahasiswa" +
                        "FROM dbo.Kendaraan" +
                        "INNER JOIN dbo.Akun_Mahasiswa ON Kendaraan.Pemilik = Akun_Mahasiswa.Mahasiswa_id";

                    SqlCommand cmd = new SqlCommand(query, connect);
                    
                    //Set the SqlDataAdapter object
                    SqlDataAdapter dAdapter = new SqlDataAdapter(cmd);

                    //define dataset
                    DataSet ds = new DataSet();

                    //fill dataset with query results
                    dAdapter.Fill(ds);

                    //set DataGridView control to read-only
                    gvAdminKendaraan.ReadOnly = true;

                    //set the DataGridView control's data source/data table
                    gvAdminKendaraan.DataSource = ds.Tables[0];


                    //close connection
                    connect.Close();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
