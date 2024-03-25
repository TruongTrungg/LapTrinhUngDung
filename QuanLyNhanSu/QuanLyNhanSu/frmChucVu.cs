using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

namespace QuanLyNhanSu
{
    public partial class frmChucVu : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        Boolean kt = true;
        public frmChucVu()
        {
            InitializeComponent();
        }
        #region Method
        void loadDB() {
            SqlConnection conn  = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbChucVu_Goi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);

                dgvChucVu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        #endregion

        #region Events
        private void frmChucVu_Load(object sender, EventArgs e)
        {
            loadDB();

            dgvChucVu.Columns["MaChucVu"].HeaderText = "Mã chức vụ";
            dgvChucVu.Columns["TenChucVu"].HeaderText = "Tên chức vụ";

            txtMaCV.Enabled = false;
            txtTenCV.Enabled = false;
            btoLuu.Enabled = false;
            btoHuy.Enabled = false;
        }
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvChucVu.Rows[e.RowIndex];

            txtMaCV.Text = row.Cells[0].Value.ToString();
            txtTenCV.Text = row.Cells[1].Value.ToString();
        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            txtMaCV.Enabled = true;
            txtTenCV.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            btoLuu.Enabled = true;
            btoHuy.Enabled = true;
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMaCV.Focus();
            kt = true;
        }
        private void btoXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbChucVu_Xoa",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaChucVu", txtMaCV.Text);

                cmd.ExecuteNonQuery();
                loadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMaCV.Focus();
        }
        private void btoSua_Click(object sender, EventArgs e)
        {
            txtMaCV.Enabled = true;
            txtTenCV.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            btoLuu.Enabled = true;
            btoHuy.Enabled = true;
            dgvChucVu.Enabled = false;
            txtTenCV.Clear();
            txtTenCV.Focus();
            kt = false;
        }
        private void btoLuu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            if (kt == true)
            {
                if (txtMaCV.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập mã chức vụ", "", MessageBoxButtons.OK);
                    txtMaCV.Focus();
                    return;
                }
                else if (txtTenCV.Text == "") {
                    MessageBox.Show("Bạn chưa nhập tên chức vụ", "", MessageBoxButtons.OK);
                    txtTenCV.Focus();
                    return;
                }
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbChucVu_Them", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaChucVu", txtMaCV.Text);
                    cmd.Parameters.AddWithValue("@TenChucVu", txtTenCV.Text);

                    cmd.ExecuteNonQuery();
                    loadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally { conn.Close(); }
            }
            else {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbChucVu_Sua", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaChucVu", txtMaCV.Text);
                    cmd.Parameters.AddWithValue("@TenChucVu", txtTenCV.Text);

                    cmd.ExecuteNonQuery();
                    loadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            txtMaCV.Enabled = false;
            txtTenCV.Enabled = false;
            btoLuu.Enabled = false;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            btoThem.Enabled = true;
            dgvChucVu.Enabled = true;
            txtMaCV.Clear();
            txtTenCV.Clear();
            txtMaCV.Focus();
        }
        private void btoHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn đang hủy dữ liệu? Bạn có muốn tiếp tục?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                txtMaCV.Enabled = false;
                txtTenCV.Enabled = false;
                btoThem.Enabled = true;
                btoXoa.Enabled = true;
                btoSua.Enabled = true;
                btoLuu.Enabled = false;
                btoHuy.Enabled = false;
                txtMaCV.Clear();
                txtTenCV.Clear();
                txtMaCV.Focus();
            }
        }
        private void frmChucVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đóng cửa sổ chứ?","Thông báo",MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion

        private void btoThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
