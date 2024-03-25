using CrystalDecisions.Shared;
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
    public partial class frmTraCuu : Form
    {
        public frmTraCuu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                CachedrptHopDong1NV rpt = new CachedrptHopDong1NV();
                crystalReportViewer1.ReportSource = rpt;

                rptHopDong1NV bd1 = new rptHopDong1NV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue para2 = new ParameterDiscreteValue();
                para2.Value = textBox1.Text;
                para.Add(para2);
                //DDUA VAO REPORT
                bd1.DataDefinition.ParameterFields["@mahd"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = bd1;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                CachedrptKhenThuongVaKyLuat_1NV rpt = new CachedrptKhenThuongVaKyLuat_1NV();
                crystalReportViewer1.ReportSource = rpt;

                rptKhenThuongVaKyLuat_1NV bd1 = new rptKhenThuongVaKyLuat_1NV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue para2 = new ParameterDiscreteValue();
                para2.Value = textBox1.Text;
                para.Add(para2);
                //DDUA VAO REPORT
                bd1.DataDefinition.ParameterFields["@maktkl"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = bd1;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                CachedrptBaoHiem_1NV rpt = new CachedrptBaoHiem_1NV();
                crystalReportViewer1.ReportSource = rpt;

                rptBaoHiem_1NV bd1 = new rptBaoHiem_1NV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue para2 = new ParameterDiscreteValue();
                para2.Value = textBox1.Text;
                para.Add(para2);
                //DDUA VAO REPORT
                bd1.DataDefinition.ParameterFields["@mabh"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = bd1;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                Cachedrpt_1NV rpt = new Cachedrpt_1NV();
                crystalReportViewer1.ReportSource = rpt;

                rpt_1NV bd1 = new rpt_1NV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue para2 = new ParameterDiscreteValue();
                para2.Value = textBox1.Text;
                para.Add(para2);
                //DDUA VAO REPORT
                bd1.DataDefinition.ParameterFields["@manv"].ApplyCurrentValues(para);
                crystalReportViewer1.ReportSource = bd1;
            }
        }

        private void frmTraCuu_Load(object sender, EventArgs e)
        {        
        }
    }
}
