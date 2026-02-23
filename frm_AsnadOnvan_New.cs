using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;
using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System;

namespace GeoBaha
{
    public partial class frm_AsnadOnvan_New : Form
    {
        // Private fields
        private string BtnCommand;
        private byte frmOnvanRefresh;
        private byte DtgOnvanRefresh;
        private string ChangeDtgOrPnl;
        private string MabnaEsmRamz;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public string EsmRamz_filter;

        public string ShName_filter;

        public string EghtesadiCode_filter;

        public string AvarezShahrdari_filter;

        public string ArzeshAfzoode_filter;

        public string OnvanMabna_filter;

        public string OnvanFactor_filter;

        public string MatnName_filter;

        public string SahebEmza_filter;

        public string Semat_filter;



        public frm_AsnadOnvan_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_AsnadOnvan_New_KeyDown;
            this.Load += frm_AsnadOnvan_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void frm_AsnadOnvan_New_Load(object sender, EventArgs e)
        {
            // کدهای مربوط به بارگذاری فرم frm_AsnadOnvan_New
            // مثلاً:
            // Module1.Load_Cmbo(cmbo_Example, "table", "field", "");
            // LoadData();
        }
        public void Load_dtg_AsnadOnvan()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[10];
			DtgOnvanRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 9);
				if (Operators.CompareString(EsmRamz_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ShName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(ShName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0 && Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
				{
					array[9] = " And ";
				}
				Module1.strWhere = " WHERE " + EsmRamz_filter + array[1] + ShName_filter + array[2] + EghtesadiCode_filter + array[3] + AvarezShahrdari_filter + array[4] + ArzeshAfzoode_filter + array[5] + OnvanFactor_filter + array[6] + MatnName_filter + array[7] + SahebEmza_filter + array[8] + Semat_filter + array[9] + OnvanMabna_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (base.Visible)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [EsmRamz] As 'ردیف',[EsmRamz] As 'کد عنوان',[ShName] As 'نام شرکت',[CodeEghtesadi] As 'کد اقتصادی',[AvarezShahrdari] As 'عوارض شهرداری',[AvarezArzeshAfzoode] As 'ارزش افزوده',[OnvanSanad] As 'عنوان فاکتور',[NameAmel] As 'صاحب امضاء',[Semat] As 'سمت',[OnvanMabna] As 'مبنا'  FROM [dbo].[Moshakhasat] " + Module1.strWhere + " Order by [EsmRamz] ";
					SqlDataReader reader = Module1.cmd.ExecuteReader();
					dataTable.Load(reader);
					foreach (DataColumn column in dataTable.Columns)
					{
						column.ReadOnly = false;
					}
					int num2 = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num2; i++)
					{
						dataTable.Rows[i]["ردیف"] = i + 1;
						if (Operators.CompareString(dataTable.Rows[i]["مبنا"].ToString(), "بلی", TextCompare: false) == 0)
						{
							MabnaEsmRamz = Conversions.ToString(dataTable.Rows[i]["کد عنوان"]);
						}
					}
					dtg_Onvan.DataSource = dataTable;
					dtg_Onvan.Columns[0].Width = 50;
					dtg_Onvan.Columns[1].Width = 60;
					dtg_Onvan.Columns[2].Width = 230;
					dtg_Onvan.Columns[3].Width = 120;
					dtg_Onvan.Columns[4].Width = 50;
					dtg_Onvan.Columns[5].Width = 50;
					dtg_Onvan.Columns[6].Width = 230;
					dtg_Onvan.Columns[7].Width = 150;
					dtg_Onvan.Columns[8].Width = 150;
					dtg_Onvan.Columns[9].Width = 44;
				}
				DtgOnvanRefresh = 1;
			}
		}

private void frm_AsnadOnvan_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void frm_AsnadAnavin_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmOnvanRefresh = 0;
			cmbo_OnvanMabna.Items.Clear();
			cmbo_OnvanMabna.Items.Add("بلی");
			cmbo_OnvanMabna.Items.Add("خیر");
			cmbo_OnvanMabnaFltr.Items.Clear();
			cmbo_OnvanMabnaFltr.Items.Add("بلی");
			cmbo_OnvanMabnaFltr.Items.Add("خیر");
			frmOnvanRefresh = 1;
			Load_dtg_AsnadOnvan();
			dtg_Onvan.CurrentCell = dtg_Onvan.Rows[0].Cells[1];
			ShowOnvanRecord();
			foreach (Control control in pnl_Onvan.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.KeyDown += GeneralKeyDownHandler1;
					control.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
				}
				if (control is TextBox || control is Button)
				{
					control.KeyDown += GeneralKeyDownHandler2;
				}
			}
		}

private void GeneralKeyDownHandler1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
			}
		}

private void GeneralKeyDownHandler2(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
			}
			if (e.KeyCode == Keys.Up)
			{
				SelectNextControl((Control)sender, forward: false, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
			}
		}

private void GeneralGotFocusHandler()
		{
			foreach (Control control in pnl_Onvan.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

private void btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(txt_EsmRamzCode.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("کد عنوان را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_EsmRamzCode.Focus();
				}
				else
				{
					if (pnl_Onvan.BackColor == Color.Beige)
					{
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + txt_EsmRamzCode.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است کد جدید انتخاب کنید " + txt_EsmRamzCode.Text + " کد  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_EsmRamzCode.Text = "";
							txt_EsmRamzCode.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Moshakhasat] ([ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]) VALUES('" + txt_ShName.Text + "','" + txt_CodeEghtesadi.Text + "','" + txt_OnvanSanad.Text + "','" + txt_SahebEmza.Text + "','" + txt_EsmRamzCode.Text + "','','" + txt_AvarezShahrdari.Text + "','" + txt_ArzeshAfzoode.Text + "','" + txt_Semat.Text + "','" + cmbo_OnvanMabna.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'بلی'  WHERE [EsmRamz] = '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'خیر'  WHERE [EsmRamz] <> '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_OnvanBlue();
					}
					else
					{
						if (Operators.CompareString(txt_EsmRamzCode.Text, Module1.Onvan.EsmRamz, TextCompare: false) != 0)
						{
							Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + txt_EsmRamzCode.Text + "'";
							SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
							if (sqlDataReader.HasRows)
							{
								MessageBox.Show(".موجود است کد عنوان جدید انتخاب کنید " + txt_EsmRamzCode.Text + " کد عنوان  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								txt_EsmRamzCode.Text = "";
								txt_EsmRamzCode.Focus();
								sqlDataReader.Close();
								return;
							}
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat] SET [EsmRamz] ='" + txt_EsmRamzCode.Text + "',[ShName] = '" + txt_ShName.Text + "',[CodeEghtesadi] ='" + txt_CodeEghtesadi.Text + "',[AvarezShahrdari] ='" + txt_AvarezShahrdari.Text + "',[AvarezArzeshAfzoode] ='" + txt_ArzeshAfzoode.Text + "',[OnvanSanad] ='" + txt_OnvanSanad.Text + "',[NameAmel] ='" + txt_SahebEmza.Text + "',[Semat] = '" + txt_Semat.Text + "',[OnvanMabna] = '" + cmbo_OnvanMabna.Text + "'WHERE EsmRamz = '" + txt_EsmRamzCode.Text + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'بلی'  WHERE [EsmRamz] = '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'خیر'  WHERE [EsmRamz] <> '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_OnvanBlue();
					}
					text = txt_EsmRamzCode.Text;
					Load_dtg_AsnadOnvan();
					int num = dtg_Onvan.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Onvan.Rows[i].Cells[1].Value, text, TextCompare: false))
						{
							dtg_Onvan.CurrentCell = dtg_Onvan.Rows[i].Cells[0];
							ShowOnvanRecord();
						}
					}
				}
			}
		}

private void SetPnl_OnvanBlue()
		{
			pnl_Onvan.BackColor = Color.Beige;
			foreach (object control in pnl_Onvan.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Onvan.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

public void ShowOnvanRecord()
		{
			int index = 0;
			Module1.DatePikerSit = false;
			int lErl = default(int);
			if (dtg_Onvan.RowCount != 0)
			{
				try
				{
					index = dtg_Onvan.CurrentRow.Index;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ProjectData.ClearProjectError();
				}
				Module1.Onvan.EsmRamz = Conversions.ToString(dtg_Onvan.Rows[index].Cells[1].Value);
				Module1.Onvan.ShName = Conversions.ToString(dtg_Onvan.Rows[index].Cells[2].Value);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[3].Value)))
				{
					Module1.Onvan.CodeEghtesadi = "";
				}
				else
				{
					Module1.Onvan.CodeEghtesadi = Conversions.ToString(dtg_Onvan.Rows[index].Cells[3].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[4].Value)))
				{
					Module1.Onvan.AvarezShahrdari = "";
				}
				else
				{
					Module1.Onvan.AvarezShahrdari = Conversions.ToString(dtg_Onvan.Rows[index].Cells[4].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[5].Value)))
				{
					Module1.Onvan.AvarezArzeshAfzoode = "";
				}
				else
				{
					Module1.Onvan.AvarezArzeshAfzoode = Conversions.ToString(dtg_Onvan.Rows[index].Cells[5].Value);
				}
				Module1.Onvan.OnvanSanad = Conversions.ToString(dtg_Onvan.Rows[index].Cells[6].Value);
				Module1.Onvan.NameAmel = Conversions.ToString(dtg_Onvan.Rows[index].Cells[7].Value);
				Module1.Onvan.Semat = Conversions.ToString(dtg_Onvan.Rows[index].Cells[8].Value);
				Module1.Onvan.OnvanMabna = Conversions.ToString(dtg_Onvan.Rows[index].Cells[9].Value);
				txt_EsmRamzCode.Text = Module1.Onvan.EsmRamz;
				txt_ShName.Text = Module1.Onvan.ShName;
				txt_CodeEghtesadi.Text = Module1.Onvan.CodeEghtesadi;
				txt_AvarezShahrdari.Text = Module1.Onvan.AvarezShahrdari;
				txt_ArzeshAfzoode.Text = Module1.Onvan.AvarezArzeshAfzoode;
				txt_OnvanSanad.Text = Module1.Onvan.OnvanSanad;
				txt_SahebEmza.Text = Module1.Onvan.NameAmel;
				txt_Semat.Text = Module1.Onvan.Semat;
				cmbo_OnvanMabna.Text = Module1.Onvan.OnvanMabna;
			}
			lErl = 60;
		}

private void dtg_Onvan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			ShowOnvanRecord();
		}

private void dtg_Onvan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowOnvanRecord();
		}

private void dtg_Onvan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_EsmRamzCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Onvan_SelectionChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh == 0)
			{
				return;
			}
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Onvan.BackColor == Color.LightPink) & (frmOnvanRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات عناوین ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_OnvanBlue();
					break;
				case DialogResult.No:
					SetPnl_OnvanBlue();
					break;
				case DialogResult.Cancel:
					txt_EsmRamzCode.Focus();
					return;
				}
			}
			if (DtgOnvanRefresh == 1)
			{
				ShowOnvanRecord();
			}
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Focus();
				MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Text = txt_EsmRamzCode.Text;
				Module1.FromAsnadList = 0;
			}
			Close();
		}

private void CheckOnvanChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Onvan.BackColor = Color.Tan;
			foreach (object control in pnl_Onvan.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Onvan.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Onvan.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Onvan.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void txt_EsmRamzCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_OnvanMabna_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_OnvanMabna_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OnvanMabna.Text.Trim(), Module1.Onvan.OnvanMabna.Trim(), TextCompare: false) != 0)
			{
				cmbo_OnvanMabna.ForeColor = Color.Red;
			}
			else
			{
				cmbo_OnvanMabna.ForeColor = Color.Black;
			}
			CheckOnvanChange();
		}

private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Onvan.BackColor == Color.LightPink)
			{
				dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Onvan.BackColor = Color.LightPink;
			txt_EsmRamzCode.Text = "";
			txt_ShName.Text = "";
			txt_CodeEghtesadi.Text = "";
			txt_AvarezShahrdari.Text = "";
			txt_ArzeshAfzoode.Text = "";
			txt_OnvanSanad.Text = "";
			txt_SahebEmza.Text = "";
			txt_Semat.Text = "";
			cmbo_OnvanMabna.Text = "خیر";
		}

private void btn_Copy_Click(object sender, EventArgs e)
		{
			string text = txt_EsmRamzCode.Text;
			BtnCommand = "Copy";
			if (pnl_Onvan.BackColor == Color.LightPink)
			{
				dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text2 = Interaction.InputBox("  کپی کد عنوان " + Module1.Onvan.EsmRamz + " با چه کدی انجام شود؟ ", " ");
			if (Operators.CompareString(text2, "", TextCompare: false) == 0)
			{
				return;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + text2 + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show("کد " + text2 + " موجود است کد جدید انتخاب کنید  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Moshakhasat]([ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]) (Select [ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],'" + text2 + "'[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_AsnadOnvan();
			checked
			{
				int num = dtg_Onvan.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Onvan.Rows[i].Cells[1].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Onvan.CurrentCell = dtg_Onvan.Rows[i].Cells[0];
						ShowOnvanRecord();
						break;
					}
				}
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_EsmRamzCode.Text;
			int index = dtg_Onvan.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Onvan.RowCount - 1 == 0)
				{
					MessageBox.Show(".امکان حذف نیست حداقل یک عنوان بایستی موجود باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					int index2 = dtg_Onvan.CurrentRow.Index;
					if (MessageBox.Show(" کد  " + txt_EsmRamzCode.Text + " حذف شود؟  ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE OnvanCode = '" + text + "'";
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("هستند بایستی حذف شوند. " + text + " ابتدا سند هایی که مرتبط به کد ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "DELETE FROM [dbo].[Moshakhasat] WHERE [EsmRamz] = '" + text + "'";
						sqlCommand.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_AsnadOnvan();
				if (index != 0)
				{
					dtg_Onvan.CurrentCell = dtg_Onvan.Rows[index - 1].Cells[0];
				}
				else
				{
					dtg_Onvan.CurrentCell = dtg_Onvan.Rows[index].Cells[0];
				}
				ShowOnvanRecord();
			}
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			txt_EsmRamzFltr.Text = "";
			txt_ShNameFltr.Text = Module1.NoaSanad;
			txt_CodeEghtesadiFltr.Text = "";
			txt_AvarezShahrdariFltr.Text = "";
			txt_ArzeshAfzoodeFltr.Text = "";
			txt_OnvanFactorFltr.Text = "";
			txt_SahebEmzaFltr.Text = "";
			txt_SematFltr.Text = "";
			cmbo_OnvanMabnaFltr.Text = "";
			frm_AsnadAnavin_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void txt_EsmRamz_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_EsmRamzCode.Text.Trim()), Module1.PerToArb(Module1.Onvan.EsmRamz.Trim()), TextCompare: false) != 0)
				{
					txt_EsmRamzCode.ForeColor = Color.Red;
				}
				else
				{
					txt_EsmRamzCode.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_ShName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ShName_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_ShName.Text.Trim()), Module1.PerToArb(Module1.Onvan.ShName.Trim()), TextCompare: false) != 0)
				{
					txt_ShName.ForeColor = Color.Red;
				}
				else
				{
					txt_ShName.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_CodeEghtesadi_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_EghtesadiCode_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_CodeEghtesadi.Text.Trim()), Module1.PerToArb(Module1.Onvan.CodeEghtesadi.Trim()), TextCompare: false) != 0)
				{
					txt_CodeEghtesadi.ForeColor = Color.Red;
				}
				else
				{
					txt_CodeEghtesadi.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_AvarezShahrdari_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_AvarezShahrdari.Text.Trim()), Module1.PerToArb(Module1.Onvan.AvarezShahrdari.Trim()), TextCompare: false) != 0)
				{
					txt_AvarezShahrdari.ForeColor = Color.Red;
				}
				else
				{
					txt_AvarezShahrdari.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_ArzeshAfzoode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ArzeshAfzoode_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_ArzeshAfzoode.Text.Trim()), Module1.PerToArb(Module1.Onvan.AvarezArzeshAfzoode.Trim()), TextCompare: false) != 0)
				{
					txt_ArzeshAfzoode.ForeColor = Color.Red;
				}
				else
				{
					txt_ArzeshAfzoode.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_OnvanSanad_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_OnvanFactor_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_OnvanSanad.Text).Trim(), Module1.PerToArb(Module1.Onvan.OnvanSanad).Trim(), TextCompare: false) != 0)
				{
					txt_OnvanSanad.ForeColor = Color.Red;
				}
				else
				{
					txt_OnvanSanad.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_SahebEmza_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_SahebEmza_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_SahebEmza.Text).Trim(), Module1.PerToArb(Module1.Onvan.NameAmel).Trim(), TextCompare: false) != 0)
				{
					txt_SahebEmza.ForeColor = Color.Red;
				}
				else
				{
					txt_SahebEmza.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_Semat_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_Semat_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_Semat.Text).Trim(), Module1.PerToArb(Module1.Onvan.Semat).Trim(), TextCompare: false) != 0)
				{
					txt_Semat.ForeColor = Color.Red;
				}
				else
				{
					txt_Semat.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void cmbo_OnvanMabna_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OnvanMabna.Text, "بلی", TextCompare: false) == 0)
			{
				MabnaEsmRamz = txt_EsmRamzCode.Text;
			}
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(cmbo_OnvanMabna.Text).Trim(), Module1.PerToArb(Module1.Onvan.Semat).Trim(), TextCompare: false) != 0)
				{
					cmbo_OnvanMabna.ForeColor = Color.Red;
				}
				else
				{
					cmbo_OnvanMabna.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

private void txt_EsmRamzFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_EsmRamzFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_EsmRamzFltr.Text);
					EsmRamz_filter = " ([EsmRamz] Like N'%" + text + "%')";
				}
				else
				{
					EsmRamz_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_ShNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ShNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_ShNameFltr.Text);
					ShName_filter = " (REPLACE(REPLACE([ShName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ShName_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_CodeEghtesadiFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_CodeEghtesadiFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_CodeEghtesadiFltr.Text);
					EghtesadiCode_filter = " ([CodeEghtesadi] Like N'%" + text + "%')";
				}
				else
				{
					EghtesadiCode_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_AvarezShahrdariFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_AvarezShahrdariFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_AvarezShahrdariFltr.Text);
					AvarezShahrdari_filter = " ([AvarezShahrdari] Like N'%" + text + "%')";
				}
				else
				{
					AvarezShahrdari_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_ArzeshAfzoodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ArzeshAfzoodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_ArzeshAfzoodeFltr.Text);
					ArzeshAfzoode_filter = " ([AvarezArzeshAfzoode] Like N'%" + text + "%')";
				}
				else
				{
					ArzeshAfzoode_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_OnvanFactorFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_OnvanFactorFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_OnvanFactorFltr.Text);
					OnvanFactor_filter = " (REPLACE(REPLACE([OnvanSanad],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					OnvanFactor_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_SahebEmzaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SahebEmzaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_SahebEmzaFltr.Text);
					SahebEmza_filter = " (REPLACE(REPLACE([NameAmel],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					SahebEmza_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void txt_SematFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SematFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_SematFltr.Text);
					Semat_filter = " (REPLACE(REPLACE([Semat],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Semat_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

private void cmbo_OnvanMabnaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				string text = Module1.PerToArb(cmbo_OnvanMabnaFltr.Text);
				switch (text)
				{
				case "Null":
					OnvanMabna_filter = " ([OnvanMabna] is Null)";
					break;
				case null:
				case "":
					OnvanMabna_filter = "";
					break;
				default:
					OnvanMabna_filter = " (REPLACE(REPLACE([OnvanMabna],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

    }
}
