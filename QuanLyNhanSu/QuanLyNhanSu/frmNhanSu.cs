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
    public partial class frmNhanSu : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter adt;
        public DataTable dt;
        public frmNhanSu()
        {
            InitializeComponent();
        }
        #region Method
        void loadDB()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try {                                         
                conn.Open();
                cmd = new SqlCommand("sp_tbNhanVien_Goi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dtgNhanSu.DataSource = dt;
            } 
            catch (Exception ex){
                Console.WriteLine("Error:"+ex.Message);
            }finally
            { conn.Close(); }
        }
        void CBOTDHV_Show()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tb_TrinhDoHocVan", conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                cboTDHV.DataSource = dt;
                cboTDHV.DisplayMember = "TenTDHV";
                cboTDHV.ValueMember = "MaTDHV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        void CBOChucVu_Show()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tb_ChucVu", conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                cboChucVu.DataSource = dt;
                cboChucVu.DisplayMember = "TenChucVu";
                cboChucVu.ValueMember = "MaChucVu";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        void CBOPB_Show()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tb_PhongBan",conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                cboPB.DataSource = dt;
                cboPB.DisplayMember = "TenPhongBan";
                cboPB.ValueMember = "MaPhongBan";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.Message);
            }
            finally { conn.Close(); }
        }
        #endregion
        #region Events
        private void dtgNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dtgNhanSu.Rows[e.RowIndex];

            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHoTen.Text = row.Cells[1].Value.ToString();
            cboGT.Text = row.Cells[2].Value.ToString();
            dtpNgaySinh.Text = row.Cells[3].Value.ToString();
            txtCCCD.Text = row.Cells[4].Value.ToString();
            txtDiaChi.Text = row.Cells[5].Value.ToString();
            txtSDT.Text = row.Cells[6].Value.ToString();
            txtEmail.Text = row.Cells[7].Value.ToString();
            cboPB.Text = row.Cells[8].Value.ToString();
            cboChucVu.Text = row.Cells[9].Value.ToString();
            cboTDHV.Text = row.Cells[10].Value.ToString();
        }
        private void frmNhanSu_Load(object sender, EventArgs e)
        {
            loadDB();
            CBOPB_Show();
            CBOChucVu_Show();
            CBOTDHV_Show();

            
            dtgNhanSu.Columns["HoTen"].HeaderText = "Họ tên";
            dtgNhanSu.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgNhanSu.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgNhanSu.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgNhanSu.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dtgNhanSu.Columns["MaPhongBan"].HeaderText = "Phòng ban";
            dtgNhanSu.Columns["MaChucVu"].HeaderText = "Chức vụ";
            dtgNhanSu.Columns["MaTDHV"].HeaderText = "Trình độ học vấn";
        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV == null)
            {
                MessageBox.Show("Mã nhân viên không được để trống!","",MessageBoxButtons.OK);
                txtMaNV.Focus();
                return;
            }
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_tbNhanVien_Them";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGT.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtpNgaySinh.Text));
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaPhongBan", cboPB.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaChucVu", cboChucVu.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaTDHV", cboTDHV.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally { 
                conn.Close();
                loadDB();
            }
        }
        private void btoXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbNhanVien_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);

                if (cmd.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Đã xóa!","",MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Không thấy nhân viên để xáo!", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally { 
                conn.Close();
                loadDB();
            }
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            txtSDT.Text = "";
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtEmail.Text = "";
            cboGT.Text = "";
            cboPB.Text = "";
            cboChucVu.Text = "";
            cboTDHV.Text = "";
            txtTimKiem.Focus();
        }
        private void btoSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbNhanVien_Sua", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@HoTen", txtHoTen.Text);
                cmd.Parameters.AddWithValue("@GioiTinh", cboGT.Text);
                cmd.Parameters.AddWithValue("@NgaySinh", DateTime.Parse(dtpNgaySinh.Text));
                cmd.Parameters.AddWithValue("@CCCD", txtCCCD.Text);
                cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@SoDienThoai", txtSDT.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@MaPhongBan", cboPB.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaChucVu", cboChucVu.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@MaTDHV", cboTDHV.SelectedValue.ToString());

                if (cmd.ExecuteNonQuery() > 0) {
                    MessageBox.Show("Đã sửa","",MessageBoxButtons.OK);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }finally { 
                conn.Close();
                loadDB();
            }
        }
        private void btoTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text == null)
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên","",MessageBoxButtons.OK);
                txtTimKiem.Focus();
                return;
            }
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                dt = new DataTable();
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_tbNhanVien_Tim", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter MaNV = new SqlParameter("@MaNV",txtTimKiem.Text);
                cmd.Parameters.Add(MaNV);
                //cmd.Parameters.AddWithValue("@MaNV", txtTimKiem.Text);
                cmd.ExecuteNonQuery();

                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
                dtgNhanSu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally { 
                conn.Close();
            }
            txtTimKiem.Focus();
        }
        private void frmNhanSu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r= MessageBox.Show("Bạn đang đóng cửa sổ?","Thông báo!",MessageBoxButtons.OKCancel);
            if (r== DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = false;
            }
        }
        private void botHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtCCCD.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            cboGT.Text = "";
            cboPB.Text = "";
            cboChucVu.Text = "";
            cboTDHV.Text = "";
            txtMaNV.Focus();
        }
        private void btothemCV_Click(object sender, EventArgs e)
        {
            frmChucVu f = new frmChucVu();
            f.ShowDialog();
        }
        private void btoUpdate_Click(object sender, EventArgs e)
        {
            CBOPB_Show();
            CBOChucVu_Show();
            CBOTDHV_Show();
            loadDB();
        }
        private void btoThemTDHV_Click(object sender, EventArgs e)
        {
            frmTDHV f = new frmTDHV();
            f.ShowDialog();
        }
        #endregion
    }
}
