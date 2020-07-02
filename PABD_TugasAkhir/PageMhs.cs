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
    public partial class PageMhs : Form
    {
        public static string setvalueMhsid = "";
        public PageMhs()
        {
            InitializeComponent();
        }

        private static string getConnectionString()
        {
            return "Data Source=DZALFIQ;Initial Catalog=KendaraanDB;User ID=SA;Password=jasmerah";
        }

        private void PageMhs_Load(object sender, EventArgs e)
        {

            txtid.Enabled = false;
            txtNIM.Enabled = false;
            txtNama.Enabled = false;
            txtFakultas.Enabled = false;
            txtJurusan.Enabled = false;
            txtPass.Enabled = false;
            txtAngkatan.Enabled = false;

            btnSave.Enabled = false;

            txtNIM.Text = Login_Mhs.setvalueNIM;

            try
            {
                Login_Mhs mhs = new Login_Mhs();
                string connectString = getConnectionString();
                string sql = "SELECT Mahasiswa_id, Nama_Mahasiswa, Jurusan, Fakultas, Angkatan, Password FROM Akun_Mahasiswa Where NIM=" + txtNIM.Text;

                SqlConnection connect = new SqlConnection(connectString);
                SqlCommand cmd = new SqlCommand(sql, connect);
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtid.Text = (reader["Mahasiswa_id"].ToString());
                    txtNama.Text = (reader["Nama_Mahasiswa"].ToString());
                    txtJurusan.Text = (reader["Jurusan"].ToString());
                    txtFakultas.Text = (reader["Fakultas"].ToString());
                    txtAngkatan.Text = (reader["Angkatan"].ToString());
                    txtPass.Text = (reader["Password"].ToString());
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTambahKendaraan_Click(object sender, EventArgs e)
        {
            setvalueMhsid = txtid.Text;
            KendMahasiswa kendaraan = new KendMahasiswa();
            this.Hide();
            kendaraan.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtNIM.Enabled = false;
            txtNama.Enabled = true;
            txtFakultas.Enabled = true;
            txtJurusan.Enabled = true;
            txtPass.Enabled = true;
            txtAngkatan.Enabled = true;

            btnEdit.Enabled = false;
            btnSave.Enabled = true;
        }

        private void txtNIM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);

            try
            {    
                connect.ConnectionString = connectString;
                connect.Open();

                string query = "UPDATE Akun_Mahasiswa SET Nama_Mahasiswa='" + txtNama.Text + "', Fakultas='" + txtFakultas.Text + "', Jurusan='" + txtJurusan.Text + "', Angkatan='" + txtAngkatan.Text + "', Password='" + txtPass.Text + "' WHERE Mahasiswa_id=" + txtid.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = query;

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Perubahan Data Berhasil");
                }
                else
                {
                    MessageBox.Show("Perubahan Data Berhasil");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            PageAwal page = new PageAwal();
            page.Show();
        }


        private void txtid_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Kendaraan Where Pemilik ='" + txtid.Text + "'";

            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);
            connect.ConnectionString = connectString;
            connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            connect.Close();
        }
    }
    
}
