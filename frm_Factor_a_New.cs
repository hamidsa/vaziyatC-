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
    public partial class frm_Factor_a_New : Form
    {
        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public frm_Factor_a_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_Factor_a_New_KeyDown;
            this.Load += frm_Factor_a_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void frm_Factor_a_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frm_Factor_a_New_Load(object sender, EventArgs e)
        {

            // Module1.Load_Cmbo(cmbo_Example, "table", "field", "");
            // LoadData();
        }

        private void frm_aFactor_Load(object sender, EventArgs e)
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
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a1", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a1_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a2", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a2_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a3", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a3_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a4", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a4_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a5", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a5_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
					if ((Operators.CompareString(control2.Text.Substring(0, 2), "a6", TextCompare: false) == 0) & (Operators.CompareString(control2.Text.Substring(3, 4).Trim(), Module1.a6_Factor, TextCompare: false) == 0))
					{
						control2.Checked = true;
					}
				}
			}
			txt_a7.Text = Module1.a7_Factor;
			txt_a8.Text = Module1.a8_Factor;
			Module1.b_Factor = Module1.b_Factor;
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
						switch (control.Name)
						{
						case "pnl_a1":
							Module1.a1_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						case "pnl_a2":
							Module1.a2_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						case "pnl_a3":
							Module1.a3_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						case "pnl_a4":
							Module1.a4_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						case "pnl_a5":
							Module1.a5_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						case "pnl_a6":
							Module1.a6_Factor = control2.Text.Substring(3, 4).Trim();
							break;
						}
					}
				}
			}
			Module1.a7_Factor = txt_a7.Text.Trim();
			Module1.a8_Factor = txt_a8.Text.Trim();
			if (Module1.FactorHasRow == 1)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "UPDATE [dbo].[Factors40401]SET [a1] = '" + Module1.a1_Factor + "',[a2] = '" + Module1.a2_Factor + "',[a3] = '" + Module1.a3_Factor + "',[a4] = '" + Module1.a4_Factor + "',[a5] = '" + Module1.a5_Factor + "',[a6] = '" + Module1.a6_Factor + "',[a7] = '" + Module1.a7_Factor + "',[a8] = '" + Module1.a8_Factor + "' Where [SanadNo]='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
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
			Module1.a_Factor = Conversions.ToString(Math.Round(Conversions.ToDouble(Module1.a1_Factor) * Conversions.ToDouble(Module1.a2_Factor) * Conversions.ToDouble(Module1.a3_Factor) * Conversions.ToDouble(Module1.a4_Factor) * Conversions.ToDouble(Module1.a5_Factor) * Conversions.ToDouble(Module1.a6_Factor) * Conversions.ToDouble(Module1.a7_Factor) * Conversions.ToDouble(Module1.a8_Factor), 2));
			MyProject.Forms.Frm_Calculate.txt_a.Text = Module1.a_Factor;
			Close();
		}

    }
}
