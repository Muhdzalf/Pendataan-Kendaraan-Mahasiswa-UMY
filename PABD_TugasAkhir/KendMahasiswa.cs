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
    public partial class KendMahasiswa : Form
    {

        public KendMahasiswa()
        {
            InitializeComponent();
        }

        private static string getConnectionString()
        {
            return "Data Source=DZALFIQ;Initial Catalog=KendaraanDB;User ID=SA;Password=jasmerah";
        }

        private void KendMahasiswa_Load(object sender, EventArgs e)
        {

            txtid.Enabled = false;
            txt_mhsid.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

            cbJenis.Items.Add("Motor");
            cbJenis.Items.Add("Mobil");
            cbJenis.Items.Add("Sepeda");

            txt_mhsid.Text = PageMhs.setvalueMhsid;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);
            DataTable dt;
            DataRow dr;

            try
            {
                connect.ConnectionString = connectString;
                connect.Open();

                if (cbJenis.Text != "" && txtmerk.Text != "" && txtWarna.Text != "")

                {
                    string query = "Select*From Kendaraan";
                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet("Kendaraan");

                    da.Fill(ds, "Kendaraan");
                    dt = kendaraanDBDataSet.Tables["Kendaraan"];
                    dr = dt.NewRow();
                    dr["Jenis"] = cbJenis.Text;
                    dr["No_Polisi"] = txtNopol.Text;
                    dr["Merk"] = txtmerk.Text;
                    dr["Warna"] = txtWarna.Text;
                    dr["Pemilik"] = txt_mhsid.Text;
                    dt.Rows.Add(dr);
                    da.Update(ds, "Kendaraan");

                    kendaraanTableAdapter.Update(kendaraanDBDataSet);
                    txtid.Text = System.Convert.ToString(dr[0]);

                    MessageBox.Show("Data Kendaraan Berhasil ditambahkan", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("Data Jenis, Merk, dan Warna tidak boleh kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void gvKendaraanMhs_Click(object sender, EventArgs e)
        {
            txtid.Text = gvKendaraanMhs.CurrentRow.Cells[0].FormattedValue.ToString();
            txt_mhsid.Text = gvKendaraanMhs.CurrentRow.Cells[5].FormattedValue.ToString();
            cbJenis.Text = gvKendaraanMhs.CurrentRow.Cells[4].FormattedValue.ToString();
            txtNopol.Text = gvKendaraanMhs.CurrentRow.Cells[1].FormattedValue.ToString();
            txtmerk.Text = gvKendaraanMhs.CurrentRow.Cells[2].FormattedValue.ToString();
            txtWarna.Text = gvKendaraanMhs.CurrentRow.Cells[3].FormattedValue.ToString();

            cbJenis.Enabled = false;
            txtmerk.Enabled = false;
            txtNopol.Enabled = false;
            txtWarna.Enabled = false;

            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            cbJenis.Enabled = true;
            txtmerk.Enabled = true;
            txtNopol.Enabled = true;
            txtWarna.Enabled = true;

            btnSave.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);

            try
            {
                connect.ConnectionString = connectString;
                connect.Open();

                string query = "UPDATE Kendaraan SET Jenis='" + cbJenis.Text + "', No_Polisi='" + txtNopol.Text + "', Merk='" + txtmerk.Text + "', Warna='" + txtWarna.Text + "' WHERE Kendaraan_id=" + txtid.Text;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);

            try
            {
                connect.ConnectionString = connectString;
                connect.Open();

                string query = "DELETE FROM Kendaraan WHERE Kendaraan_id=" + gvKendaraanMhs.CurrentRow.Cells[0].FormattedValue;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = query;

                int result = cmd.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Akun Telah Dihapus");
                    btn_refresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Akun Gagal dihapus");
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

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);

            try
            {
                string query = "SELECT * FROM Kendaraan";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                gvKendaraanMhs.DataSource = dt;
                KendMahasiswa_Load(sender, e);
                txt_mhsid_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.Dispose();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageMhs pageMhs = new PageMhs();
            pageMhs.Show();
        }

        private void txt_mhsid_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Kendaraan Where Pemilik ='" + txt_mhsid.Text + "'";

            string connectString = getConnectionString();
            SqlConnection connect = new SqlConnection(connectString);
            connect.ConnectionString = connectString;
            connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            gvKendaraanMhs.DataSource = dt;
            connect.Close();
        }
    }
    
}
