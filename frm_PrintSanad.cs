using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using CrystalDecisions.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class frm_PrintSanad : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Exit")]
		private Button _btn_Exit;

        internal CrystalReportViewer CrystalReportViewer1;
        private System.Windows.Forms.Button btn_Exit;

        public frm_PrintSanad()
		{
			base.Load += frm_PrintSanad_Load;
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.CrystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
			this.btn_Exit = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.CrystalReportViewer1.ActiveViewIndex = -1;
			this.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
			this.CrystalReportViewer1.Location = new System.Drawing.Point(0, 0);
			this.CrystalReportViewer1.Name = "CrystalReportViewer1";
			this.CrystalReportViewer1.Size = new System.Drawing.Size(1190, 759);
			this.CrystalReportViewer1.TabIndex = 0;
			this.btn_Exit.Location = new System.Drawing.Point(545, 745);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 1;
			this.btn_Exit.Text = "خروج";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Exit.Visible = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new System.Drawing.Size(1184, 771);
			base.Controls.Add(this.CrystalReportViewer1);
			base.Controls.Add(this.btn_Exit);
			base.Name = "frm_PrintSanad";
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "پرینت";
			base.ResumeLayout(false);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
        }

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			CrystalReportViewer1.ReportSource = null;
			CrystalReportViewer1.Refresh();
			MyProject.Forms.Frm_AsnadDetail.Load_dtg_AsnadDetail(Module1.SanadRec.sanadnum);
			Close();
		}

		private void frm_PrintSanad_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
		}
	}
}
