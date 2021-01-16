using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Project_QLPT.DataBase;

namespace Project_QLPT
{
    public partial class frmStatis : UserControl
    {
        public frmStatis()
        {
            InitializeComponent();
            init();
        }
        private QLPT_DB context = new QLPT_DB();
        private void init()
        {
            cboSelect.Items.Add("Phiếu thuê");
            cboSelect.Items.Add("Người thuê");
            cboSelect.Items.Add("Phòng");
            cboSelect.SelectedIndex = 0;
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource;
            if (cboSelect.Text.Equals("Người thuê"))
            {
                List<NGUOITHUE> lst = context.NGUOITHUEs.ToList();
                reportViewer1.LocalReport.ReportPath = "rptCustomer.rdlc";
                reportDataSource = new ReportDataSource("DataSet1",lst);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            if (cboSelect.Text.Equals("Phòng"))
            {
                List<PHONG> lst = context.PHONGs.ToList();
                reportViewer1.LocalReport.ReportPath = "rptRoom.rdlc";
                reportDataSource = new ReportDataSource("DataSet1", lst);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            if (cboSelect.Text.Equals("Phiếu thuê"))
            {
                var lst = context.PHONGs.Join
                    (
                        context.PHIEUTHUEs,
                        P => P.IDPHONG,
                        PT => PT.IDPHONG,
                        (P, PT) => new { P, PT }
                    ).Join
                    (
                        context.NGUOITHUEs,
                        PPT => PPT.PT.IDNGUOITHUE,
                        NT => NT.IDNGUOITHUE,
                        (PPT, NT) => new { PPT, NT }
                    ).Select
                    (
                        p => new
                        {
                            IDPHIEU = p.PPT.PT.IDPHIEU,
                            TENNGUOITHUE = p.NT.TENNGUOITHUE,
                            TENPHONG = p.PPT.P.TENPHONG,
                            NGAYTHUE = p.PPT.PT.NGAYTHUE,
                            NGAYTRA = p.PPT.PT.NGAYTRA,
                            GHICHU = p.PPT.PT.GHICHU,
                        }
                    ).ToList();


                reportViewer1.LocalReport.ReportPath = "rptBills.rdlc";
                reportDataSource = new ReportDataSource("DataSet1", lst);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            }
            reportViewer1.RefreshReport();
        }
    }
}
