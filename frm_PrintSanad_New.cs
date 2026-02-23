using CrystalDecisions.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System;

namespace GeoBaha
{
    public partial class frm_PrintSanad_New : Form
    {
        // Private fields
        private Button _btn_Exit;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public frm_PrintSanad_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_PrintSanad_New_KeyDown;
            this.Load += frm_PrintSanad_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void frm_PrintSanad_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
		{
			CrystalReportViewer1.ReportSource = null;
			CrystalReportViewer1.Refresh();
			MyProject.Forms.Frm_AsnadDetail.Load_dtg_AsnadDetail(Module1.SanadRec.sanadnum);
			Close();
		}

private void frm_PrintSanad_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
		}

    }
}
