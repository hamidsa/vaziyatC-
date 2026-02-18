using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using Microsoft.VisualBasic;
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
    public partial class frm_Factor_b_New : Form
    {
        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public frm_Factor_b_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_Factor_b_New_KeyDown;
            this.Load += frm_Factor_b_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void frm_Factor_b_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			foreach (Control control in base.Controls)
			{
				if (!(control is Panel))
				{
					continue;
				}
				foreach (RadioButton control2 in control.Controls)
				{
					if (control is RadioButton && Operators.CompareString(control2.Text.Substring(2, 4).Trim(), Module1.b_Factor.Trim(), TextCompare: false) == 0)
					{
						control2.Checked = true;
					}
				}
			}
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			foreach (Control control in base.Controls)
			{
				if (!(control is Panel))
				{
					continue;
				}
				foreach (RadioButton control2 in control.Controls)
				{
					if (control2.Checked)
					{
						Module1.b_Factor = control2.Text.Substring(2, 4).Trim();
					}
				}
			}
			if (Module1.FactorHasRow == 1)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "UPDATE [dbo].[Factors40401]SET [b] = '" + Module1.b_Factor + "' Where [SanadNo]='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				Module1.cmd.ExecuteNonQuery();
			}
			else
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[Factors40401] ([SanadNo],[a1],[a2],[a3],[a4],[a5],[a6],[a7],[a8],[b],[fopf],[SalMali],[Soori],[Ghaleb],[Eslah],[EslahTime]) VALUES ('" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "','" + Module1.a1_Factor + "','" + Module1.a2_Factor + "','" + Module1.a3_Factor + "','" + Module1.a4_Factor + "','" + Module1.a5_Factor + "','" + Module1.a6_Factor + "','" + Module1.a7_Factor + "','" + Module1.a8_Factor + "','" + Module1.b_Factor + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + Module1.SanadRec.SalMali + "','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "','" + Environment.MachineName + "','')";
				Module1.cmd.ExecuteNonQuery();
				Module1.FactorHasRow = 1;
			}
			MyProject.Forms.Frm_Calculate.txt_b.Text = Module1.b_Factor;
			Close();
		}

private void rdb_b_1_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_1.Checked)
			{
				Module1.b_Factor = rdb_b_1.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_2_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_2.Checked)
			{
				Module1.b_Factor = rdb_b_2.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_3_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_3.Checked)
			{
				Module1.b_Factor = rdb_b_3.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_4_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_4.Checked)
			{
				Module1.b_Factor = rdb_b_4.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_5_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_5.Checked)
			{
				Module1.b_Factor = rdb_b_5.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_6_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_6.Checked)
			{
				Module1.b_Factor = rdb_b_6.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_7_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_7.Checked)
			{
				Module1.b_Factor = rdb_b_7.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_8_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_8.Checked)
			{
				Module1.b_Factor = rdb_b_8.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_9_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_9.Checked)
			{
				Module1.b_Factor = rdb_b_9.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_10_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_10.Checked)
			{
				Module1.b_Factor = rdb_b_10.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

private void rdb_b_11_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_11.Checked)
			{
				Module1.b_Factor = rdb_b_11.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

    }
}
