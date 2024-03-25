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
    public partial class frmHopDong : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter adt;
        public DataTable dt;
        public frmHopDong()
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
                cmd = new SqlCommand("sp_tbHopDongLaoDong_Goi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dtgHopDong.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex.Message);
            }
            finally
            { conn.Close(); }
        }
        void CBOMNS_Show()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("select * from tb_NhanVien", conn);
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                cboTenNS.DataSource = dt;
                cboTenNS.DisplayMember = "MaNV";
                cboTenNS.ValueMember = "MaNV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally { conn.Close(); }
        }

        #endregion

        #region Events
        private void dtgHopDong_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dtgHopDong.CurrentCell.RowIndex;
                txtMHD.Text = dtgHopDong.Rows[dong].Cells[0].Value.ToString();
                cboLHD.Text = dtgHopDong.Rows[dong].Cells[1].Value.ToString();
                dtpNBD.Value = DateTime.Parse(dtgHopDong.Rows[dong].Cells[2].Value.ToString());
                dtpNKT.Value = DateTime.Parse(dtgHopDong.Rows[dong].Cells[3].Value.ToString());
                dtpNK.Value = DateTime.Parse(dtgHopDong.Rows[dong].Cells[4].Value.ToString());
                txtKy.Text = dtgHopDong.Rows[dong].Cells[5].Value.ToString();
                txtNoiDung.Text = dtgHopDong.Rows[dong].Cells[6].Value.ToString();
                cboThoiHan.Text = dtgHopDong.Rows[dong].Cells[7].Value.ToString();
                txtHSL.Text = dtgHopDong.Rows[dong].Cells[8].Value.ToString();
                cboTenNS.Text = dtgHopDong.Rows[dong].Cells[9].Value.ToString();
            }
            catch (Exception)
            {
            }

        }
        //private void dtgHopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex == -1) return;

        //    DataGridViewRow row = dtgHopDong.Rows[e.RowIndex];

        //    txtMHD.Text = row.Cells[0].Value.ToString();
        //    dtpNBD.Text = row.Cells[1].Value.ToString();
        //    dtpNKT.Text = row.Cells[2].Value.ToString();
        //    dtpNK.Text = row.Cells[3].Value.ToString();
        //    cboLHD.Text = row.Cells[4].Value.ToString();
        //    txtNoiDung.Text = row.Cells[5].Value.ToString();
        //    txtKy.Text = row.Cells[6].Value.ToString();
        //    txtHSL.Text = row.Cells[7].Value.ToString();
        //    cboThoiHan.Text = row.Cells[8].Value.ToString();
        //    cboTenNS.Text = row.Cells[9].Value.ToString();
        //}
        private void btoThem_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_tbHopDongLaoDong_Them";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHD", txtMHD.Text);
                cmd.Parameters.AddWithValue("@LoaiHD", cboLHD.Text.ToString());
                cmd.Parameters.AddWithValue("@NgayBatDau", DateTime.Parse(dtpNBD.Text));
                cmd.Parameters.AddWithValue("@NgayKetThuc", DateTime.Parse(dtpNKT.Text));
                cmd.Parameters.AddWithValue("@NgayKy", DateTime.Parse(dtpNK.Text));
                cmd.Parameters.AddWithValue("@SoLanKy", txtKy.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@ThoiHan", cboThoiHan.Text.ToString());
                cmd.Parameters.AddWithValue("@HeSoLuong", txtHSL.Text);
                cmd.Parameters.AddWithValue("@MaNV", cboTenNS.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conn.Close();
                loadDB();
            }
        }
        private void frmHopDong_Load(object sender, EventArgs e)
        {
            loadDB();
            dtgHopDong.DefaultCellStyle.ForeColor = Color.Black;
            CBOMNS_Show();
        }
        private void btoXoa_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbHopDongLaoDong_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaHD", txtMHD.Text);

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conn.Close();
                loadDB();
            }
            txtMHD.Text = "";
            txtKy.Text = "";
            txtHSL.Text = "";
            txtNoiDung.Text = "";
            dtpNBD.Text = "";
            dtpNKT.Text = "";
            dtpNK.Text = "";
            cboLHD.Text = "";
            cboTenNS.Text = "";
            cboThoiHan.Text = "";
        }


        #endregion

        private void btoSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbHopDongLaoDong_Sua", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHD", txtMHD.Text);
                cmd.Parameters.AddWithValue("@LoaiHD", cboLHD.Text.ToString());
                cmd.Parameters.AddWithValue("@NgayBatDau", DateTime.Parse(dtpNBD.Text));
                cmd.Parameters.AddWithValue("@NgayKetThuc", DateTime.Parse(dtpNKT.Text));
                cmd.Parameters.AddWithValue("@NgayKy", DateTime.Parse(dtpNK.Text));
                cmd.Parameters.AddWithValue("@SoLanKy", txtKy.Text);
                cmd.Parameters.AddWithValue("@NoiDung", txtNoiDung.Text);
                cmd.Parameters.AddWithValue("@ThoiHan", cboThoiHan.Text.ToString());
                cmd.Parameters.AddWithValue("@HeSoLuong", txtHSL.Text);
                cmd.Parameters.AddWithValue("@MaNV", cboTenNS.SelectedValue.ToString());

                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
            finally
            {
                conn.Close();
                loadDB();
            }
        }
    }
}

