using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class frm_PrintSanad_New
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Component declarations

        // Controls

        // Button
        private System.Windows.Forms.Button btn_Exit;

        // CrystalReportViewer
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CrystalReportViewer1;

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
    }
}
