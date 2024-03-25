using ontapProjects;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        #region Method
        void openForm(Type typeForm)
        {
            foreach (var frm in MdiChildren)
            {
                if (frm.GetType() == typeForm)
                {
                    frm.Activate();
                    return;
                }
            }
            Form f = (Form)Activator.CreateInstance(typeForm);
            f.MdiParent = this;
            f.Show();
        }
        #endregion

        #region Events
        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn đóng cửa sổ chứ?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void menuDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                frmLogin f = new frmLogin();
                this.Hide();
            }
        }
        private void menuNhanSu_Click(object sender, EventArgs e)
        {
            frmNhanSu f = new frmNhanSu();
            openForm(f.GetType());
        }
        private void menuPhongBan_Click_1(object sender, EventArgs e)
        {
            frmPhongBan f = new frmPhongBan();
            openForm(f.GetType());
        }
        #endregion

        private void menuBaoHiem_Click(object sender, EventArgs e)
        {
             frmBaoHiem f= new frmBaoHiem();
            openForm(f.GetType());
        }

        private void menuHopDong_Click(object sender, EventArgs e)
        {
            frmHopDong f = new frmHopDong();
            openForm(f.GetType());
        }
        private void menuKTvaKL_Click(object sender, EventArgs e)
        {
            frmKTvaKL f = new frmKTvaKL();
            openForm(f.GetType());
        }     
        private void frmMenu_Load(object sender, EventArgs e)
        {
            menuChamCong.Visible = false;
        }

        private void menuInBaoCao_Click(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInDS f = new frmInDS();
            openForm(f.GetType());
        }

        private void traCứuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraCuu f = new frmTraCuu();
            openForm(f.GetType());
        }
    }
}
