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
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyNhanSu
{
    public partial class frmKTvaKL : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        bool kt = true;
        public frmKTvaKL()
        {
            InitializeComponent();
        }
        void loadDB() {
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbKhenThuongVaKyLuat_Goi",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();

                adt.Fill(dt);
                dgvKTvaKL.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }
        void CBOMaNV_Show() {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tb_NhanVien", conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                cboMaNV.DataSource = dt;
                cboMaNV.DisplayMember = "MaNV";
                cboMaNV.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        private void frmKTvaKL_Load(object sender, EventArgs e)
        {
            loadDB();
            CBOMaNV_Show();

            dgvKTvaKL.Columns["MaKTVKL"].HeaderText = "Mã";
            dgvKTvaKL.Columns["NoiDung"].HeaderText = "Nôi dung";
            dgvKTvaKL.Columns["Ngay"].HeaderText = "Ngày";
            dgvKTvaKL.Columns["Loai"].HeaderText = "Loại";
            dgvKTvaKL.Columns["MaNV"].HeaderText = "Mã nhân sự";

            txtID.Enabled = false;
            txtMaKTKL.Enabled = false;
            txtNoiDung.Enabled = false;
            dtpNgay.Enabled = false;
            cboLoai.Enabled = false;
            cboMaNV.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
        }
        private void dgvKTvaKL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            DataGridViewRow row = dgvKTvaKL.Rows[e.RowIndex];

            txtID.Text = row.Cells[0].Value.ToString();
            txtMaKTKL.Text = row.Cells[1].Value.ToString();
            txtNoiDung.Text = row.Cells[2].Value.ToString();
            dtpNgay.Text = row.Cells[3].Value.ToString();
            cboLoai.Text = row.Cells[4].Value.ToString();
            cboMaNV.Text = row.Cells[5].Value.ToString();

        }
        private void btoThem_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtMaKTKL.Clear();
            txtNoiDung.Clear();
            cboLoai.Text = "";
            cboMaNV.Text = "";

            txtID.Enabled = true;
            txtMaKTKL.Enabled = true;
            txtNoiDung.Enabled = true;
            dtpNgay.Enabled = true;
            cboLoai.Enabled = true;
            cboMaNV.Enabled = true;
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            dgvKTvaKL.Enabled = false;
            txtID.Focus();
            kt = true;
        }
        private void btoXoa_Click(object sender, EventArgs e)
        {
            conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbKhenThuongVaKyLuat_Xoa",conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@ID",txtID.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { 
                conn.Close();
                loadDB();
            }
        }
        private void btoSua_Click(object sender, EventArgs e)
        {
            txtID.Enabled = true;
            txtMaKTKL.Enabled = true;
            txtNoiDung.Enabled = true;
            dtpNgay.Enabled = true;
            cboLoai.Enabled = true;
            cboMaNV.Enabled = true;
            btoHuy.Enabled = true;
            btoLuu.Enabled = true;
            btoThem.Enabled = false;
            btoXoa.Enabled = false;
            btoSua.Enabled = false;
            dgvKTvaKL.Enabled = false;
            txtMaKTKL.Focus();
            kt = false;
        }
        private void btoLuu_Click(object sender, EventArgs e)
        {
            conn = DBUtils.GetDBConnection();
            if (kt == true)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbKhenThuongVaKyLuat_Them", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@MaKTVKL", txtMaKTKL.Text);
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                    cmd.Parameters.AddWithValue("@Ngay", DateTime.Parse(dtpNgay.Text));
                    cmd.Parameters.AddWithValue("@Loai", cboLoai.Text);
                    cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue.ToString());

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
                }
            }
            else {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("sp_tbKhenThuongVaKyLuat_Sua", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID", txtID.Text);
                    cmd.Parameters.AddWithValue("@MaKTVKL", txtMaKTKL.Text);
                    cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                    cmd.Parameters.AddWithValue("@Ngay", DateTime.Parse(dtpNgay.Text));
                    cmd.Parameters.AddWithValue("@Loai", cboLoai.Text);
                    cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue.ToString());

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
                }
            }
            txtID.Enabled = false;
            txtMaKTKL.Enabled = false;
            txtNoiDung.Enabled = false;
            dtpNgay.Enabled = false;
            cboLoai.Enabled = false;
            cboMaNV.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
            btoThem.Enabled = true;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            dgvKTvaKL.Enabled = true;
        }

        private void btoHuy_Click(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtMaKTKL.Enabled = false;
            txtNoiDung.Enabled = false;
            dtpNgay.Enabled = false;
            cboLoai.Enabled = false;
            cboMaNV.Enabled = false;
            btoHuy.Enabled = false;
            btoLuu.Enabled = false;
            btoThem.Enabled = true;
            btoXoa.Enabled = true;
            btoSua.Enabled = true;
            dgvKTvaKL.Enabled=true;
        }

        private void frmKTvaKL_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Ban muốn đóng cửa số?","",MessageBoxButtons.YesNo);
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
