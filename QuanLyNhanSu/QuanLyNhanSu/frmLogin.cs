using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanSu
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        #region Events
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection();
             try
             {
                 conn.Open();
                 string tKhoan = txtTKhoan.Text;
                 string mKhau = txtMKhau.Text;
                 if (tKhoan != null && tKhoan.Trim() != "") { }
                 else
                 {
                     lblLoi.Text = "Ban can nhap tai khoan!!!";
                     txtTKhoan.Focus();
                     return;
                 }
                 if (mKhau != null && mKhau.Trim() != "") { }
                 else
                 {
                     lblLoi.Text = "Ban can nhap mat khau!!!";
                     txtMKhau.Focus();
                     return;
                 }

                 string query = "select * from tb_TaiKhoan where TenTK='" + tKhoan + "' and MatKhau='" + mKhau + "'";
                 SqlCommand cmd = new SqlCommand(query, conn);
                 SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                 DataSet ds = new DataSet();
                 adapter.Fill(ds);
                 SqlDataReader daRD = cmd.ExecuteReader();

                 if (daRD.Read() == true)
                 {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMenu f = new frmMenu();
                    f.Show();
                    this.Hide();
                 }
                 else
                 {
                     lblLoi.Text = "Thong tin tai khoan hoac mat khau chua dung!!!";
                     txtTKhoan.Clear();
                     txtMKhau.Clear();
                     txtTKhoan.Focus();
                 }
             }
             catch (Exception ex)
             {
                 lblLoi.Text = "Error"+ex.Message;
             }
             finally
             {
                 conn.Close();
             }
        }
        #endregion
    }
}