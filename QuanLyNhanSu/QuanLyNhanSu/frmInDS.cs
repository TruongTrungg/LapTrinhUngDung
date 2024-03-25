using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class frmInDS : Form
    {
        public frmInDS()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CachedrptHopDongLaoDong rpt = new CachedrptHopDongLaoDong();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CachedrptDSKhenThuongVaKyLuat rpt = new CachedrptDSKhenThuongVaKyLuat();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CachedrptBaoHiem rpt = new CachedrptBaoHiem();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                CachedrptNhanSu rpt = new CachedrptNhanSu();
                crystalReportViewer1.ReportSource = rpt;
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                CachedrptPhongBan rpt = new CachedrptPhongBan();
                crystalReportViewer1.ReportSource = rpt;
            }
            

        }

        private void frmInDS_Load(object sender, EventArgs e)
        {

        }
    }
}
