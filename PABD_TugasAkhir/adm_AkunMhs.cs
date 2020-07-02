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
    public partial class adm_AkunMhs : Form
    {
        DataTable dt;
        DataRow dr;
        string connectString = "Data Source=DZALFIQ;Initial Catalog=KendaraanDB;User ID=SA;Password=jasmerah";
        SqlConnection connect = new SqlConnection();

        public adm_AkunMhs()
        {
            InitializeComponent();
        }

        private void adm_AkunMhs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kendaraanDBDataSet.Akun_Mahasiswa' table. You can move, or remove it, as needed.
            this.akun_MahasiswaTableAdapter.Fill(this.kendaraanDBDataSet.Akun_Mahasiswa);

            txtid.Text = "";
            txtNama.Text = "";
            txtNIM.Text = "";
            txtPassword.Text = "";

            txtid.Enabled = false;
            txtNama.Enabled = false;
            txtNIM.Enabled = false;
            txtPassword.Enabled = false;

            bindingNavigator1.Enabled = true;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btncreate.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //txt kosoong
            txtid.Clear();
            txtNama.Clear();
            txtNIM.Clear();
            txtPassword.Clear();

            txtid.Enabled = false;
            txtNama.Enabled = true;
            txtNIM.Enabled = true;
            txtPassword.Enabled = true;

            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btncreate.Enabled = true;
        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            try {

                 connect.ConnectionString = connectString;
                 connect.Open();

                if (txtNama.Text !="" && txtNIM.Text !="" && txtPassword.Text != "")

                {
                    string query = "Select*From Akun_Mahasiswa";
                    SqlDataAdapter da = new SqlDataAdapter(query, connect);
                    SqlCommandBuilder builder = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet("Akun_Mahasiswa");

                    da.Fill(ds, "Akun_Mahasiswa");
                    dt = kendaraanDBDataSet.Tables["Akun_Mahasiswa"];
                    dr = dt.NewRow();
                    dr["NIM"] = txtNIM.Text;
                    dr["Nama_Mahasiswa"] = txtNama.Text;
                    dr["Password"] = txtPassword.Text;
                    dt.Rows.Add(dr);
                    da.Update(ds, "Akun_Mahasiswa");

                    akun_MahasiswaTableAdapter.Update(kendaraanDBDataSet);
                    txtNIM.Text = System.Convert.ToString(dr[0]);

                    MessageBox.Show("Akun Telah ditambahkan", "Selamat", MessageBoxButtons.OK, MessageBoxIcon.None);

                }
                else
                {
                    MessageBox.Show("Data Tidak Boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                connect.ConnectionString = connectString;
                connect.Open();

                string query = "DELETE FROM Akun_Mahasiswa WHERE Mahasiswa_id=" + GV_AkunMhs.CurrentRow.Cells[0].FormattedValue;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        private void GV_AkunMhs_Click(object sender, EventArgs e)
        {
            txtid.Text = GV_AkunMhs.CurrentRow.Cells[0].FormattedValue.ToString();
            txtNIM.Text = GV_AkunMhs.CurrentRow.Cells[1].FormattedValue.ToString();
            txtNama.Text = GV_AkunMhs.CurrentRow.Cells[2].FormattedValue.ToString();
            txtPassword.Text = GV_AkunMhs.CurrentRow.Cells[6].FormattedValue.ToString();

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            txtNIM.Enabled = true;
            txtNama.Enabled = true;
            txtPassword.Enabled = true;

            btnUpdate.Enabled = true;
            btnEdit.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                connect.ConnectionString = connectString;
                connect.Open();

                string query = "UPDATE Akun_Mahasiswa SET NIM='"+ txtNIM.Text + "', Nama_Mahasiswa='" + txtNama.Text + "', Password='" + txtPassword.Text + "' WHERE Mahasiswa_id="+ txtid.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = query;

                int result = cmd.ExecuteNonQuery();
                if (result == 1){
                    MessageBox.Show("Data Telah dirubah");
                    btn_refresh_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Perubahan Data Gagal");
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
            try
            {
                string query = "SELECT * FROM Akun_Mahasiswa";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connect;
                cmd.CommandText = query;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                GV_AkunMhs.DataSource = dt;
                adm_AkunMhs_Load(sender, e);
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.Dispose();
            }

        }

        private void cl(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminMenu admin = new AdminMenu();
            admin.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Akun_Mahasiswa Where NIM ='" + textBox1.Text + "'";

            connect.ConnectionString = connectString;
            connect.Open();

            SqlDataAdapter adapter = new SqlDataAdapter(query, connect);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GV_AkunMhs.DataSource = dt;
            connect.Close();
        }
    }
}
