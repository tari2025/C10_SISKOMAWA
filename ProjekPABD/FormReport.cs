using System;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace ProjekPABD
{
    public partial class FormReport : Form
    {
        // Constructor menerima report dari luar
        public FormReport(ReportDocument report)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.RefreshReport();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}