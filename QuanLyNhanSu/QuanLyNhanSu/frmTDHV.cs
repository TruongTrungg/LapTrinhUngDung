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

namespace QuanLyNhanSu
{
    public partial class frmTDHV : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        bool kt = true;
        public frmTDHV()
        {
            InitializeComponent();
        }
        void loadDB() {
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbTrinhDoHocVan_Goi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                dgvTDHV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void frmTDHV_Load(object sender, EventArgs e)
        {
            loadDB();

            dgvTDHV.Columns["MaTDHV"].HeaderText = "Mã học vấn";
            dgvTDHV.Columns["TenTDHV"].HeaderText = "Tên học vấn";
            dgvTDHV.Columns["ChuyenNganh"].HeaderText = "Chuyên ngành";

            dgvTDHV.Columns["TenTDHV"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvTDHV.Columns["ChuyenNganh"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtCN.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
        }

        private void btoThem_Click(object sender, EventArgs e)
        {
            txtCN.Enabled = true;
            txtTen.Enabled = true;
            txtMa.Enabled = true;
            txtTen.Clear();
            txtMa.Clear();
            txtCN.Clear();
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            dgvTDHV.Enabled = false;
            txtMa.Focus();
            kt = true;
        }

        private void btoXoa_Click(object sender, EventArgs e)
        {
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbTrinhDoHocVan_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaTDHV", txtMa.Text);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Đã xóa!","", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã để xóa", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erroe: " + ex.Message);
            }
            finally { conn.Close();
                loadDB();
            }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            txtCN.Enabled = true;
            txtTen.Enabled = true;
            txtMa.Enabled = true;
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            txtTen.Focus();
            dgvTDHV.Enabled = false;
            kt = false;
        }

        private void btoHuy_Click(object sender, EventArgs e)
        {
            txtCN.Enabled = false;
            txtTen.Enabled = false;
            txtMa.Enabled = false;
            txtMa.Clear();
            txtTen.Clear();
            txtCN.Clear();
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
            btoThem.Enabled = true;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            dgvTDHV.Enabled = true;
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string cn = txtCN.Text;
            conn = DBUtils.GetDBConnection();
            if (kt == true)
            {
                if (!string.IsNullOrWhiteSpace(ma))
                {
                }
                else
                {
                    MessageBox.Show("Không được để trống mã!", "", MessageBoxButtons.OK);
                    txtMa.Focus();
                    return;
                }
                if (!string.IsNullOrWhiteSpace(ten))
                {
                }
                else
                {
                    MessageBox.Show("Không được để trống tên!", "", MessageBoxButtons.OK);
                    txtTen.Focus();
                    return;
                }
                if (!string.IsNullOrWhiteSpace(cn))
                {
                }
                else
                {
                    MessageBox.Show("Không được để trống chức năng!", "", MessageBoxButtons.OK);
                    txtCN.Focus();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbTrinhDoHocVan_Them",conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaTDHV",txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenTDHV", txtTen.Text);
                    cmd.Parameters.AddWithValue("@ChuyenNganh", txtCN.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    loadDB();
                };
            }
            else {
                if (txtTen.Text == null)
                {
                    MessageBox.Show("Bạn cần nhập tên", "", MessageBoxButtons.OK);
                    txtTen.Focus();
                    return;
                }
                else if (txtCN.Text == null)
                {
                    MessageBox.Show("Bạn cần nhập chức năng", "", MessageBoxButtons.OK);
                    txtCN.Focus();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbTrinhDoHocVan_Sua", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaTDHV", txtMa.Text);
                    cmd.Parameters.AddWithValue("@TenTDHV", txtTen.Text);
                    cmd.Parameters.AddWithValue("@ChuyenNganh", txtCN.Text);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    loadDB();
                };
            }
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtCN.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
            btoThem.Enabled = true;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            dgvTDHV.Enabled = true;
            txtMa.Focus();
        }

        private void dgvTDHV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvTDHV.Rows[e.RowIndex];

            txtMa.Text = row.Cells[0].Value.ToString();
            txtTen.Text = row.Cells[1].Value.ToString();
            txtCN.Text = row.Cells[2].Value.ToString();
        }
    }
}
