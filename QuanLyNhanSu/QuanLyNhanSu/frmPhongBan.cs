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
    public partial class frmPhongBan : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        bool kt = true;
        public frmPhongBan()
        {
            InitializeComponent();
        }
        #region Method
        void loadDB()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                string query = "select * from tb_PhongBan";
                cmd = new SqlCommand(query, conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dgvPhongBan.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        #endregion
        #region Events
        private void frmPhongBan_Load(object sender, EventArgs e)
        {
            loadDB();

            txtMaPB.Enabled = false;
            txtSDTPB.Enabled = false;
            txtSoPhong.Enabled = false;
            txtTenPB.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
        }
        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvPhongBan.Rows[e.RowIndex];

            txtMaPB.Text = row.Cells[0].Value.ToString();
            txtTenPB.Text = row.Cells[1].Value.ToString();
            txtSoPhong.Text = row.Cells[2].Value.ToString();
            txtSDTPB.Text = row.Cells[3].Value.ToString();
        }
        #endregion

        private void btoThem_Click(object sender, EventArgs e)
        {
            txtMaPB.Enabled = true;
            txtSDTPB.Enabled = true;
            txtSoPhong.Enabled = true;
            txtTenPB.Enabled = true;
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            txtMaPB.Clear();
            txtTenPB.Clear();
            txtSoPhong.Clear();
            txtSDTPB.Clear();
            txtMaPB.Focus();
            dgvPhongBan.Enabled = false;
            kt = true;
        }
        private void btoXoa_Click(object sender, EventArgs e)
        {
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbPhongBan_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPB.Text);

                cmd.ExecuteNonQuery();
                loadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void btoSua_Click(object sender, EventArgs e)
        {
            txtMaPB.Enabled = true;
            txtSDTPB.Enabled = true;
            txtSoPhong.Enabled = true;
            txtTenPB.Enabled = true;
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            dgvPhongBan.Enabled = false;
            kt = false;
        }

        private void btoHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn đang hủy dữ liệu? Bạn có muốn tiếp tục?", "Thông báo!", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                txtMaPB.Enabled = false;
                txtSDTPB.Enabled = false;
                txtSoPhong.Enabled = false;
                txtTenPB.Enabled = false;
                btoHuy.Enabled = false;
                btoLuu.Enabled = false;
                btoThem.Enabled = true;
                btoXoa.Enabled = true;
                btoSua.Enabled = true;
                dgvPhongBan.Enabled = true;
            }
        }

        private void btoLuu_Click(object sender, EventArgs e)
        {
            if (kt == true)
            {
                if (txtMaPB == null)
                {
                    MessageBox.Show("Mã phòng ban không được để trống!", "", MessageBoxButtons.OK);
                    txtMaPB.Focus();
                    return;
                }
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "sp_tbPhongBan_Them";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPB.Text);
                    cmd.Parameters.AddWithValue("@TenPhongBan", txtTenPB.Text);
                    cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text);
                    cmd.Parameters.AddWithValue("@SDTPB", txtSDTPB.Text);

                    cmd.ExecuteNonQuery();
                    loadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally { conn.Close(); }
            }
            else
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                try
                {
                    conn.Open();
                    cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandText = "sp_tbPhongBan_Sua";
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPhongBan", txtMaPB.Text);
                    cmd.Parameters.AddWithValue("@TenPhongBan", txtTenPB.Text);
                    cmd.Parameters.AddWithValue("@SoPhong", txtSoPhong.Text);
                    cmd.Parameters.AddWithValue("@SDTPB", txtSDTPB.Text);

                    cmd.ExecuteNonQuery();
                    loadDB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
                finally { conn.Close(); }
            }
            txtMaPB.Enabled = false;
            txtSDTPB.Enabled = false;
            txtSoPhong.Enabled = false;
            txtTenPB.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
            btoThem.Enabled = true;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            dgvPhongBan.Enabled = true;

        }

        private void frmPhongBan_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Tắt úng dụng? Bạn tiếp tục chứ?", "", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
