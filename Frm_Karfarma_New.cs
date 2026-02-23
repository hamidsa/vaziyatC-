using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;
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
    public partial class Frm_Karfarma_New : Form
    {
        public struct KarfarmaDetailes
		{
			public int Id;

			public int KarfarmaCode;

			public string KarfarmaName;

			public string Ostan;

			public string Shahr;

			public string KarfarmaEghtesadiCode;

			public string KarfarmaMelliCode;

			public string KarfarmaPostCode;

			public string KarfarmaAddress;

			public string KarfarmaTel;
		}

        // Private fields
        private ComboBox _cmbo_KarfarmaShahr;
        private ComboBox _cmbo_KarfarmaOstan;
        private TextBox _txt_KarfarmaTel;
        private TextBox _txt_KarfarmaAddress;
        private TextBox _txt_KarfarmaCode;
        private TextBox _txt_KarfarmaName;
        private DataGridView _dtg_Karfarma;
        private ComboBox _cmbo_KarfarmaShahrFltr;
        private TextBox _txt_KarfarmaNameFltr;
        private ComboBox _cmbo_KarfarmaOstanFltr;
        private TextBox _txt_KarfarmaMelliCodelFltr;
        private TextBox _txt_KarfarmaEghtesadiCodeFltr;
        private TextBox _txt_KarfarmaPostCode;
        private TextBox _txt_KarfarmaMelliCode;
        private TextBox _txt_KarfarmaCodeEghtesadi;
        private TextBox _txt_KarfarmaCodeFltr;
        private TextBox _txt_KarfarmaTelFltr;
        private TextBox _txt_KarfarmaAddressFltr;
        private TextBox _txt_KarfarmaPostiCodeFltr;
        private Button _btn_Insert;
        private Button _btn_copy;
        private Button _btn_Save;
        private Button _btn_Delete;
        private Button _btn_Exit;
        private Button _btn_Filter;
        private string ChangeDtgOrPnl;
        private string BtnCommand;
        private byte DtgKarfarmaRefresh;
        private byte frmKarfarmaRefresh;

        public string KarfarmaCode_filter;

        public string KarfarmaName_filter;

        public string KarfarmaOstan_filter;

        public string KarfarmaShahr_filter;

        public string KarfarmaEghtesadiCode_filter;

        public string KarfarmaMelliCode_filter;

        public string KarfarmaPostiCode_filter;

        public string KarfarmaAddress_filter;

        public string KarfarmaTel_filter;



        public KarfarmaDetailes Karfarma;


        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_Karfarma_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Karfarma_New_KeyDown;
            this.Load += Frm_Karfarma_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void cmbo_KarfarmaOstan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void btn_Return_Click(object sender, EventArgs e)
		{
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			Module1.BtnKarfarmaList = false;
			Close();
		}

public void ShowKarfarmaRecord()
		{
			int num = 0;
			ref KarfarmaDetailes karfarma = ref Karfarma;
			int lErl = default(int);
			if (dtg_Karfarma.RowCount != 0)
			{
				try
				{
					num = dtg_Karfarma.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				karfarma.Id = Conversions.ToInteger(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[0].Value);
				karfarma.KarfarmaCode = Conversions.ToInteger(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[2].Value);
				karfarma.KarfarmaName = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[3].Value.ToString();
				karfarma.Ostan = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[4].Value.ToString();
				karfarma.Shahr = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[5].Value.ToString();
				karfarma.KarfarmaEghtesadiCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[6].Value.ToString();
				karfarma.KarfarmaMelliCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[7].Value.ToString();
				karfarma.KarfarmaPostCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[8].Value.ToString();
				karfarma.KarfarmaAddress = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[9].Value.ToString();
				karfarma.KarfarmaTel = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[10].Value.ToString();
				txt_KarfarmaCode.Text = Conversions.ToString(karfarma.KarfarmaCode);
				txt_KarfarmaName.Text = karfarma.KarfarmaName;
				cmbo_KarfarmaOstan.Text = karfarma.Ostan;
				cmbo_KarfarmaShahr.Text = karfarma.Shahr;
				txt_KarfarmaCodeEghtesadi.Text = karfarma.KarfarmaEghtesadiCode;
				txt_KarfarmaMelliCode.Text = karfarma.KarfarmaMelliCode;
				txt_KarfarmaPostCode.Text = karfarma.KarfarmaPostCode;
				txt_KarfarmaAddress.Text = karfarma.KarfarmaAddress;
				txt_KarfarmaTel.Text = karfarma.KarfarmaTel;
			}
			lErl = 60;
		}

private void dtg_Karfarma_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowKarfarmaRecord();
		}

private void dtg_Karfarma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowKarfarmaRecord();
		}

private void dtg_Karfarma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (0 - (Module1.BtnKarfarmaList ? 1 : 0) == 1)
			{
				Frm_AsnadList frm_AsnadList = MyProject.Forms.Frm_AsnadList;
				frm_AsnadList.txt_Karfarma.Text = Conversions.ToString(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[2].Value);
				frm_AsnadList = null;
			}
		}

private void dtg_Karfarma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click_1(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void dtg_Karfarma_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				txt_KarfarmaCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Karfarma_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Karfarma.BackColor == Color.LightPink) & (frmKarfarmaRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات کارفرما ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_KarfarmaBlue();
					break;
				case DialogResult.No:
					SetPnl_KarfarmaBlue();
					break;
				case DialogResult.Cancel:
					txt_KarfarmaCode.Focus();
					return;
				}
			}
			if (DtgKarfarmaRefresh == 1)
			{
				ShowKarfarmaRecord();
			}
		}

public void Load_dtg_Karfarma()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[9];
			DtgKarfarmaRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 8);
				if (Operators.CompareString(KarfarmaCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0 && Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
				{
					array[8] = " And ";
				}
				Module1.strWhere = " WHERE " + KarfarmaCode_filter + array[1] + KarfarmaName_filter + array[2] + KarfarmaOstan_filter + array[3] + KarfarmaShahr_filter + array[4] + KarfarmaEghtesadiCode_filter + array[5] + KarfarmaMelliCode_filter + array[6] + KarfarmaPostiCode_filter + array[4] + KarfarmaAddress_filter + array[5] + KarfarmaTel_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = "";
				}
				if (base.Visible)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [indentradif] As 'Id',[radif] As 'ردیف',[kknum] As 'کد ', [kname] As 'نام کارفرما', [Oname] As 'استان', [ShahrName] As 'شهر' , [ShomareEghtesadi] As 'کد اقتصادی', [ShomareSabtYaMelli] As 'کد ملی', [KodPosti] As 'کد پستی',[adres] As 'آدرس کارفرما', [tel] As 'تلفن ' FROM [dbo].[etkarfar] " + Module1.strWhere + " Order By [kknum] Asc";
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
					}
					dtg_Karfarma.DataSource = dataTable;
					dtg_Karfarma.Columns[0].Width = 75;
					dtg_Karfarma.Columns[0].Visible = false;
					dtg_Karfarma.Columns[1].Width = 50;
					dtg_Karfarma.Columns[2].Width = 50;
					dtg_Karfarma.Columns[3].Width = 210;
					dtg_Karfarma.Columns[4].Width = 100;
					dtg_Karfarma.Columns[5].Width = 100;
					dtg_Karfarma.Columns[6].Width = 100;
					dtg_Karfarma.Columns[7].Width = 100;
					dtg_Karfarma.Columns[8].Width = 100;
					dtg_Karfarma.Columns[9].Width = 210;
					dtg_Karfarma.Columns[10].Width = 100;
					base.Visible = true;
				}
				DtgKarfarmaRefresh = 1;
			}
		}

private void Frm_Karfarma_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_Karfarma_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmKarfarmaRefresh = 0;
			Load_Cmbo_FrmKarfarma(cmbo_KarfarmaOstanFltr, "etkarfar", "Oname", "");
			Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
			Module1.Load_Cmbo(cmbo_KarfarmaOstan, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_KarfarmaShahr, "ZarayebMantaghe", "Shahr", "");
			Load_dtg_Karfarma();
			dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[0].Cells[1];
			ShowKarfarmaRecord();
			frmKarfarmaRefresh = 1;
			foreach (Control control in pnl_Karfarma.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control.KeyDown += GeneralKeyDownHandler1;
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
			foreach (Control control in pnl_Karfarma.Controls)
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
			if (!(pnl_Karfarma.BackColor == Color.Tan))
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
				{
					Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + txt_KarfarmaCode.Text + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[etkarfar] ([radif],[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah]) VALUES('0','" + txt_KarfarmaCode.Text + "','" + txt_KarfarmaName.Text + "','" + txt_KarfarmaAddress.Text + "','" + txt_KarfarmaTel.Text + "','" + txt_KarfarmaCodeEghtesadi.Text + "','" + txt_KarfarmaMelliCode.Text + "','" + Module1.FindCodeOrName(cmbo_KarfarmaOstan.Text, "[Ostan]", "[OstanCode]", "[ZarayebMantaghe]") + "','" + cmbo_KarfarmaOstan.Text + "','" + Module1.FindCodeOrName(cmbo_KarfarmaShahr.Text, "[Shahr]", "[ShahrCode]", "[ZarayebMantaghe]") + "','" + cmbo_KarfarmaShahr.Text + "','" + txt_KarfarmaPostCode.Text + "','" + Environment.MachineName + "','','','')";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_KarfarmaBlue();
						goto IL_04af;
					}
					MessageBox.Show("کد کارفرما " + txt_KarfarmaCode.Text + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_KarfarmaCode.Text = "";
					txt_KarfarmaName.Focus();
					sqlDataReader.Close();
				}
				else
				{
					Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + txt_KarfarmaCode.Text + "' And [indentradif] <> '" + Conversions.ToString(Karfarma.Id) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo].[etkarfar] SET [radif] ='0',[kknum] = '" + txt_KarfarmaCode.Text + "',[kname] = '" + txt_KarfarmaName.Text + "',[adres] = '" + txt_KarfarmaAddress.Text + "',[tel] = '" + txt_KarfarmaTel.Text + "',[ShomareEghtesadi] = '" + txt_KarfarmaCodeEghtesadi.Text + "',[ShomareSabtYaMelli] = '" + txt_KarfarmaMelliCode.Text + "',[okod] = '" + Module1.FindCodeOrName(cmbo_KarfarmaOstan.Text, "[Ostan]", "[OstanCode]", "[ZarayebMantaghe]") + "',[Oname] = '" + cmbo_KarfarmaOstan.Text + "',[ShahrKod] = '" + Module1.FindCodeOrName(cmbo_KarfarmaShahr.Text, "[Shahr]", "[ShahrCode]", "[ZarayebMantaghe]") + "',[ShahrName] = '" + cmbo_KarfarmaShahr.Text + "',[KodPosti] = '" + txt_KarfarmaPostCode.Text + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = ''WHERE [indentradif] = '" + Conversions.ToString(Karfarma.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						goto IL_04af;
					}
					MessageBox.Show("کد کارفرما " + txt_KarfarmaCode.Text + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_KarfarmaCode.Text = "";
					txt_KarfarmaCode.Focus();
				}
			}
			goto IL_0551;
			IL_04af:
			SetPnl_KarfarmaBlue();
			text = txt_KarfarmaCode.Text;
			Frm_Karfarma_New_Load(RuntimeHelpers.GetObjectValue(sender), e);
			checked
			{
				int num = dtg_Karfarma.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dtg_Karfarma.Rows[i].Cells[2].Value, text, TextCompare: false))
					{
						dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[i].Cells[1];
						ShowKarfarmaRecord();
					}
				}
				goto IL_0551;
			}
			IL_0551:
			BtnCommand = "";
		}

private void SetPnl_KarfarmaBlue()
		{
			pnl_Karfarma.BackColor = Color.Tan;
			foreach (object control in pnl_Karfarma.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Karfarma.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

public void btn_Insert_Click(object sender, EventArgs e)
		{
			frm_Karfarma_btn_insert();
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_KarfarmaCode.Text;
			string defaultResponse = "";
			BtnCommand = "Copy";
			if (pnl_Karfarma.BackColor == Color.LightPink)
			{
				dtg_Karfarma_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [kknum] FROM [dbo].[etkarfar] Order By [kknum] Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				while (sqlDataReader.Read())
				{
					defaultResponse = Conversions.ToString(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1);
				}
				sqlDataReader.Close();
				string text2 = Interaction.InputBox(" کپی کارفرما " + Conversions.ToString(Karfarma.KarfarmaCode) + " تحت عنوان کد کارفرمای ذیل انجام شود؟ ", " ", defaultResponse);
				if (Operators.CompareString(text2, "", TextCompare: false) == 0)
				{
					return;
				}
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + text2 + "'";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show("کارفرما با کد " + text2 + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				sqlDataReader.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[etkarfar] ([radif],[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah])(SELECT [radif],'" + text2 + "'[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],'" + Environment.MachineName + "',[EslahSystem],'',[TimeEslah] FROM [dbo].[etkarfar] Where [kknum]='" + text + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Karfarma();
				int num = dtg_Karfarma.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Karfarma.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[i].Cells[1];
						ShowKarfarmaRecord();
						break;
					}
				}
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			string text = txt_KarfarmaCode.Text;
			int index = dtg_Karfarma.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Karfarma.RowCount - 1 != 0)
				{
					int index2 = dtg_Karfarma.CurrentRow.Index;
					if (MessageBox.Show("کارفرما با کد   " + txt_KarfarmaCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE karkod1 = '" + text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مربط به کد کارفرمای   " + txt_KarfarmaCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE [karkod1] = '" + text + "'";
						sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مربوط به کد کارفرمای   " + txt_KarfarmaCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo].[etkarfar] WHERE kknum = '" + text + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_Karfarma();
				if (index != 0)
				{
					dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[index].Cells[1];
				}
				ShowKarfarmaRecord();
			}
		}

private void btn_Exit_Click_1(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Karfarma_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.txt_Karfarma.Focus();
				MyProject.Forms.Frm_AsnadList.txt_Karfarma.Text = txt_KarfarmaName.Text;
				Module1.FromAsnadList = 0;
			}
			Close();
		}

private void txt_KarfarmaCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_Karfarma_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_KarfarmaShahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_KarfarmaCodeEghtesadi_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_KarfarmaMelliCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_KarfarmaPostCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_KarfarmaAddress_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_KarfarmaTel_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_Karfarma_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaName.Text.Trim(), Karfarma.KarfarmaName.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaName.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaName.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void CheckKarfarmaChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Karfarma.BackColor = Color.Tan;
			foreach (object control in pnl_Karfarma.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Karfarma.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Karfarma.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Karfarma.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void txt_KarfarmaCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaCode.Text, Conversions.ToString(Karfarma.KarfarmaCode), TextCompare: false) != 0)
				{
					txt_KarfarmaCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void cmbo_KarfarmaOstan_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmKarfarmaRefresh != 0)
			{
				string left = cmbo_KarfarmaOstan.Text.Trim();
				try
				{
					if (Operators.CompareString(left, "", TextCompare: false) != 0)
					{
						Module1.Load_Cmbo(cmbo_KarfarmaShahr, "ZarayebMantaghe", "Shahr", "Where REPLACE(REPLACE(Ostan,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(cmbo_KarfarmaOstan.Text.Trim()) + "%'");
					}
					if ((Operators.CompareString(left, Karfarma.Ostan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_KarfarmaShahr.Text.Trim(), Karfarma.Shahr.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_KarfarmaOstan.ForeColor = Color.Red;
						cmbo_KarfarmaShahr.ForeColor = Color.Red;
					}
					else
					{
						cmbo_KarfarmaOstan.ForeColor = Color.Black;
						cmbo_KarfarmaShahr.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckKarfarmaChange();
			}
			lErl = 20;
			cmbo_KarfarmaShahr.Text = "";
		}

private void cmbo_KarfarmaShahr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmKarfarmaRefresh != 0)
			{
				try
				{
					if ((Operators.CompareString(cmbo_KarfarmaOstan.Text.Trim(), Karfarma.Ostan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_KarfarmaShahr.Text.Trim(), Karfarma.Shahr.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_KarfarmaShahr.ForeColor = Color.Red;
					}
					else
					{
						cmbo_KarfarmaOstan.ForeColor = Color.Black;
						cmbo_KarfarmaShahr.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckKarfarmaChange();
			}
			lErl = 20;
		}

private void txt_KarfarmaAddress_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaAddress.Text.Trim(), Karfarma.KarfarmaAddress.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaAddress.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaAddress.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void txt_KarfarmaCodeEghtesadi_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaCodeEghtesadi.Text.Trim(), Karfarma.KarfarmaEghtesadiCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaCodeEghtesadi.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaCodeEghtesadi.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void txt_KarfarmaMelliCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaMelliCode.Text.Trim(), Karfarma.KarfarmaMelliCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaMelliCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaMelliCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void txt_KarfarmaPostCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaPostCode.Text.Trim(), Karfarma.KarfarmaPostCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaPostCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaPostCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void txt_KarfarmaTel_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaTel.Text.Trim(), Karfarma.KarfarmaTel.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaTel.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaTel.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

private void cmbo_KarfarmaShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_filter.Visible)
			{
				pnl_filter.Visible = true;
				return;
			}
			pnl_filter.Visible = false;
			txt_KarfarmaCodeFltr.Text = "";
			txt_KarfarmaNameFltr.Text = "";
			cmbo_KarfarmaOstanFltr.Text = "";
			cmbo_KarfarmaOstanFltr.Text = "";
			cmbo_KarfarmaShahrFltr.Text = "";
			txt_KarfarmaEghtesadiCodeFltr.Text = "";
			txt_KarfarmaMelliCodelFltr.Text = "";
			txt_KarfarmaPostiCodeFltr.Text = "";
			txt_KarfarmaAddressFltr.Text = "";
			txt_KarfarmaTelFltr.Text = "";
			Frm_Karfarma_New_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void txt_KarfarmaCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaCodeFltr.Text;
					KarfarmaCode_filter = " ([kknum] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaNameFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_KarfarmaNameFltr.Text;
					KarfarmaName_filter = " (REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					KarfarmaName_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaAddressFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaAddressFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_KarfarmaAddressFltr.Text;
					KarfarmaAddress_filter = " (REPLACE(REPLACE([adres],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					KarfarmaAddress_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void cmbo_KarfarmaOstanFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				string text = cmbo_KarfarmaOstanFltr.Text;
				switch (text)
				{
				case "Null":
					KarfarmaOstan_filter = " ([Oname] is Null)";
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
					break;
				case null:
				case "":
					KarfarmaOstan_filter = "";
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
					break;
				default:
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "Where REPLACE(REPLACE(Oname,'ي',N'ی'),'ك',N'ک') Like N'" + Module1.ArbToPer(text) + "'");
					KarfarmaOstan_filter = " (REPLACE(REPLACE(Oname,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void cmbo_KarfarmashahrFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				string text = cmbo_KarfarmaShahrFltr.Text;
				switch (text)
				{
				case "Null":
					KarfarmaShahr_filter = " ([ShahrName] is Null)";
					break;
				case null:
				case "":
					KarfarmaShahr_filter = "";
					break;
				default:
					KarfarmaShahr_filter = " (REPLACE(REPLACE(ShahrName,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaEghtesadiCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaEghtesadiCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaEghtesadiCodeFltr.Text;
					KarfarmaEghtesadiCode_filter = " ([ShomareEghtesadi] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaEghtesadiCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaMelliCodelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaMelliCodelFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaMelliCodelFltr.Text;
					KarfarmaMelliCode_filter = " ([ShomareSabtYaMelli] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaMelliCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaPostiCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaPostiCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaPostiCodeFltr.Text;
					KarfarmaPostiCode_filter = " ([KodPosti] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaPostiCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void txt_KarfarmaTelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaTelFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaTelFltr.Text;
					KarfarmaTel_filter = " ([tel] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaTel_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

private void Load_Cmbo_FrmKarfarma(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT REPLACE(REPLACE(" + strField + ",'ي',N'ی'),'ك',N'ک') As " + Module1.ArbToPer(strField) + " FROM [dbo]." + strTable + " " + strWhere + " Group By " + strField + " Order By " + strField;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			sqlDataReader.Close();
			strCmbo.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(row[strField])))
				{
					strCmbo.Items.Add("Null");
				}
				else
				{
					strCmbo.Items.Add(RuntimeHelpers.GetObjectValue(row[strField]));
				}
			}
		}

public void frm_Karfarma_btn_insert()
		{
			BtnCommand = "Insert";
			if (pnl_Karfarma.BackColor == Color.LightPink)
			{
				frm_Karfarma_btn_insert();
			}
			pnl_Karfarma.BackColor = Color.LightPink;
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [kknum] FROM [dbo].[etkarfar] order by Cast([kknum] As bigint) Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				txt_KarfarmaCode.Text = Conversions.ToString(checked(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1));
			}
			sqlDataReader.Close();
			txt_KarfarmaName.Text = "";
			cmbo_KarfarmaOstan.Text = "";
			cmbo_KarfarmaShahr.Text = "";
			txt_KarfarmaCodeEghtesadi.Text = "";
			txt_KarfarmaMelliCode.Text = "";
			txt_KarfarmaPostCode.Text = "";
			txt_KarfarmaAddress.Text = "";
			txt_KarfarmaTel.Text = "";
		}

private void cmbo_KarfarmaOstan_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

    }
}
