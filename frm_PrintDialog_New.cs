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
    public partial class frm_PrintDialog_New : Form
    {
        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public frm_PrintDialog_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_PrintDialog_New_KeyDown;
            this.Load += frm_PrintDialog_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void frm_PrintDialog_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void OK_Button_Click(object sender, EventArgs e)
		{
			if (rdo_Sanad.Checked)
			{
				MyProject.Forms.Frm_AsnadDetail.PrintSanad();
			}
			if (rdo_Nameh.Checked)
			{
				MyProject.Forms.Frm_AsnadDetail.PrintNameh();
				if (Panel1.BackColor == Color.LightPink)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Karname2] = '" + txt_Karnam2.Text + "',[Ronevwsht] = '" + txt_Ronevwsht.Text + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					Module1.cmd.ExecuteNonQuery();
					SetPanelBlue();
					Module1.SanadRec.karname2 = txt_Karnam2.Text;
					Module1.SanadRec.Ronevwsht = txt_Ronevwsht.Text;
				}
			}
			if (!rdo_ArzeshAfzoode.Checked)
			{
				return;
			}
			try
			{
				if ((Operators.CompareString(txt_Takhfif.Text, "", TextCompare: false) == 0) | rdo_NoTakhfif.Checked)
				{
					Module1.Takhfif = 0;
				}
				else
				{
					Module1.Takhfif = Conversions.ToInteger(txt_Takhfif.Text);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".مبلغ تخفیف درست وارد نشده است", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_Takhfif.Focus();
				ProjectData.ClearProjectError();
				return;
			}
			MyProject.Forms.Frm_AsnadDetail.PrintArzeshAfzoode();
		}

private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			MyProject.Forms.Frm_AsnadDetail.txt_ItemNo.Focus();
			Close();
		}

private void frm_Dialog1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Cancel_Button_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void frm_PrintDialog_New_Load(object sender, EventArgs e)
		{
			SetPanelBlue();
			cmbo_Pardakht.Items.Clear();
			cmbo_Pardakht.Items.Add("نقدی");
			cmbo_Pardakht.Items.Add("غیر نقدی");
			cmbo_Pardakht.Items.Add(" ");
			cmbo_Pardakht.Text = " ";
			rdo_NoTakhfif.Checked = true;
			txt_Takhfif.Text = "";
			rdo_Sanad.Checked = true;
			OK_Button.Focus();
		}

private void rdo_Sanad_CheckedChanged(object sender, EventArgs e)
		{
			SetPanelBlue();
			if (rdo_Sanad.Checked)
			{
				lbl_Karnam2.Visible = false;
				lbl_Ronevwsht.Visible = false;
				txt_Karnam2.Visible = false;
				txt_Ronevwsht.Visible = false;
				Panel2.Visible = false;
				txt_Karnam2.Text = Module1.SanadRec.karname2;
				txt_Ronevwsht.Text = Module1.SanadRec.Ronevwsht;
			}
		}

private void rdo_Sanad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				rdo_Nameh.Checked = true;
			}
		}

private void rdo_Nameh_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Nameh.Checked)
			{
				lbl_Karnam2.Visible = true;
				lbl_Ronevwsht.Visible = true;
				txt_Karnam2.Visible = true;
				txt_Ronevwsht.Visible = true;
				Panel2.Visible = false;
				txt_Karnam2.Text = Module1.SanadRec.karname2;
				txt_Ronevwsht.Text = Module1.SanadRec.Ronevwsht;
			}
		}

private void rdo_Nameh_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				rdo_Sanad.Checked = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				rdo_ArzeshAfzoode.Checked = true;
			}
		}

private void rdo_ArzeshAfzoode_CheckedChanged(object sender, EventArgs e)
		{
			SetPanelBlue();
			if (rdo_ArzeshAfzoode.Checked)
			{
				lbl_Karnam2.Visible = false;
				lbl_Ronevwsht.Visible = false;
				txt_Karnam2.Visible = false;
				txt_Ronevwsht.Visible = false;
				Panel2.Visible = true;
			}
			foreach (DataGridViewRow item in (IEnumerable)MyProject.Forms.Frm_AsnadDetail.dtg_SanadSum.Rows)
			{
				if (item.Cells[3].Value.ToString().Contains("تخفيف"))
				{
					Type typeFromHandle = typeof(Math);
					DataGridViewCell dataGridViewCell;
					object[] obj = new object[1] { (dataGridViewCell = item.Cells[6]).Value };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					object value = NewLateBinding.LateGet(null, typeFromHandle, "Abs", obj, null, null, obj2);
					if (array2[0])
					{
						dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
					}
					Module1.Takhfif = Conversions.ToInteger(value);
				}
				if (item.Cells[3].Value.ToString().Contains("ماليات"))
				{
					Module1.Maliat = Conversions.ToInteger(item.Cells[6].Value);
				}
			}
		}

private void rdo_WithTakhfif_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_WithTakhfif.Checked)
			{
				txt_Takhfif.Visible = true;
				Label1.Visible = true;
				txt_Takhfif.Text = Conversions.ToString(Module1.Takhfif);
			}
		}

private void rdo_NoTakhfif_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_NoTakhfif.Checked)
			{
				txt_Takhfif.Text = "";
				txt_Takhfif.Visible = false;
				Label1.Visible = false;
			}
		}

private void rdo_ArzeshAfzoode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				rdo_Nameh.Checked = true;
			}
		}

private void txt_Karnam2_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_Karnam2.Text.Trim(), Module1.SanadRec.karname2.Trim(), TextCompare: false) != 0)
				{
					txt_Karnam2.ForeColor = Color.Red;
				}
				else
				{
					txt_Karnam2.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckNameChange();
		}

private void txt_Ronevwsht_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_Ronevwsht.Text.Trim(), Module1.SanadRec.Ronevwsht.Trim(), TextCompare: false) != 0)
				{
					txt_Ronevwsht.ForeColor = Color.Red;
				}
				else
				{
					txt_Ronevwsht.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckNameChange();
		}

private void CheckNameChange()
		{
			foreach (object control in Panel1.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					Panel1.BackColor = Color.LightPink;
					return;
				}
			}
			SetPanelBlue();
		}

public void SetPanelBlue()
		{
			Panel1.BackColor = Color.WhiteSmoke;
			foreach (object control in Panel1.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void cmbo_Pardakht_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

    }
}
