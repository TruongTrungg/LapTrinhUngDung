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
using QuanLyNhanSu;

namespace ontapProjects

{
    public partial class frmBaoHiem : Form
    {
        public SqlCommand cmd;
        public SqlDataAdapter adt;
        public DataTable dt;
        public frmBaoHiem()
        {
            InitializeComponent();
        }
        void loadDB()
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbBaoHiem_Goi", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                adt = new SqlDataAdapter(cmd);
                dt = new DataTable();
                adt.Fill(dt);
                dtgBaoHiem.DataSource = dt;
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
        private void frmBaoHiem_Load(object sender, EventArgs e)
        {
            loadDB();
            CBOMNS_Show();
        }

        private void dtgBaoHiem_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dtgBaoHiem.CurrentCell.RowIndex;
                txtMbh.Text = dtgBaoHiem.Rows[dong].Cells[0].Value.ToString();
                txtSbh.Text = dtgBaoHiem.Rows[dong].Cells[1].Value.ToString();
                dtpNgayCap.Value = DateTime.Parse(dtgBaoHiem.Rows[dong].Cells[2].Value.ToString());
                txtNoiCap.Text = dtgBaoHiem.Rows[dong].Cells[3].Value.ToString();
                cboMaNV.Text = dtgBaoHiem.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception)
            {
            }
        }

        private void btnXoaBH_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbBaoHiem_Xoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaBH", txtMbh.Text);

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
            txtMbh.Text = "";
            txtSbh.Text = "";
            dtpNgayCap.Text = "";
            txtNoiCap.Text = "";
            cboMaNV.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_tbBaoHiem_Sua", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaBH", txtMbh.Text);                
                cmd.Parameters.AddWithValue("@SoBH", txtSbh.Text);
                cmd.Parameters.AddWithValue("@NgayCap", DateTime.Parse(dtpNgayCap.Text));
                cmd.Parameters.AddWithValue("@NoiCap", txtNoiCap.Text);
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.Text.ToString());

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

        private void btnThembh_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            try
            {
                conn.Open();
                cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "sp_tbBaoHiem_Them";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaBH", txtMbh.Text);
                cmd.Parameters.AddWithValue("@SoBH", txtSbh.Text);
                cmd.Parameters.AddWithValue("@NgayCap", DateTime.Parse(dtpNgayCap.Text));
                cmd.Parameters.AddWithValue("@NoiCap", txtNoiCap.Text);
                cmd.Parameters.AddWithValue("@MaNV", cboMaNV.SelectedValue.ToString());

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

