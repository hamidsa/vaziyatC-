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
    public partial class Frm_ZarayebMantaghe_New : Form
    {
        public struct ZarayebMantagheDetailes
		{
			public int Id;

			public string OstanCode;

			public string Ostan;

			public string ShahrCode;

			public string Shahr;

			public string BakhshCode;

			public string Bakhsh;

			public int ZaribCode;

			public float zarib_F;

			public string Comment;
		}

        // Private fields
        private TextBox _txt_ZaribMantagheFltr;
        private ComboBox _cmbo_OstanCodeFltr;
        private ComboBox _cmbo_OstanFltr;
        private ComboBox _cmbo_ShahrCodeFltr;
        private DataGridView _dtg_ZarayebMantaghe;
        private Button _btn_Exit;
        private Button _Btn_Save;
        private TextBox _txt_Zarib_F;
        private ComboBox _cmbo_BakhshCodeFltr;
        private ComboBox _cmbo_ShahrFltr;
        private ComboBox _cmbo_BakhshFltr;
        private ComboBox _cmbo_ZaribCodeFltr;
        private ComboBox _cmbo_CommentFltr;
        private Button _btn_ZaribCode;
        private Button _btn_Delete;
        private Button _btn_copy;
        private Button _btn_Insert;
        private ComboBox _cmbo_BakhshCode;
        private ComboBox _cmbo_Shahr;
        private ComboBox _cmbo_Bakhsh;
        private ComboBox _cmbo_OstanCode;
        private ComboBox _cmbo_Ostan;
        private ComboBox _cmbo_ShahrCode;
        private ComboBox _cmbo_ZaribCode;
        private ComboBox _cmbo_Comment;
        private Button _btn_Filter;
        private byte frmZaribMantagheRefresh;
        private byte DtgZaribMantaghetRefresh;
        private string BtnCommand;
        private string ChangeDtgOrPnl;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_ZarayebMantaghe_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_ZarayebMantaghe_New_KeyDown;
            this.Load += Frm_ZarayebMantaghe_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

public void Load_dtg_ZarayebMantaghe()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[9];
			DtgZaribMantaghetRefresh = 0;
			base.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 8);
				if (Operators.CompareString(OstanCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Ostan_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Ostan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0 && Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
				{
					array[8] = " And ";
				}
				Module1.strWhere = " WHERE " + OstanCode_filter + array[1] + Ostan_filter + array[2] + ShahrCode_filter + array[3] + Shahr_filter + array[4] + BakhshCode_filter + array[5] + Bakhsh_filter + array[6] + ZaribMantaghe_filter + array[7] + ZaribCode_filter + array[8] + Comment_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [Id] As 'Id',[Id] As 'ردیف',[OstanCode] As 'کد استان',[Ostan] As 'استان',[ShahrCode] As 'کد شهر',[Shahr] As 'شهر',[BakhshCode] As 'کد بخش',[Bakhsh] As 'بخش',[zarib_F] As 'ضریب منطقه ای',[ZaribCode] As 'کد بخشنامه',[Comment] As 'شرح کد بخشنامه' FROM [dbo].[ZarayebMantaghe] " + Module1.strWhere + " Order By  OstanCode , ShahrCode , BakhshCode , ZaribCode ";
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
				dtg_ZarayebMantaghe.DataSource = dataTable;
				dtg_ZarayebMantaghe.Columns[0].Visible = false;
				dtg_ZarayebMantaghe.Columns[1].Width = 50;
				dtg_ZarayebMantaghe.Columns[2].Width = 70;
				dtg_ZarayebMantaghe.Columns[3].Width = 120;
				dtg_ZarayebMantaghe.Columns[4].Width = 70;
				dtg_ZarayebMantaghe.Columns[5].Width = 120;
				dtg_ZarayebMantaghe.Columns[6].Width = 70;
				dtg_ZarayebMantaghe.Columns[7].Width = 120;
				dtg_ZarayebMantaghe.Columns[8].Width = 75;
				dtg_ZarayebMantaghe.Columns[9].Width = 70;
				dtg_ZarayebMantaghe.Columns[10].Width = 440;
				DtgZaribMantaghetRefresh = 1;
				lbl_RecNo.Text = Conversions.ToString(dataTable.Rows.Count) + " :تعداد رکورد";
			}
		}

private void Frm_ZarayebMantaghe_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_ZarayebMantaghe_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			base.KeyPreview = true;
			Pnl_Zarib.Visible = false;
			dtg_ZarayebMantaghe.Height = 650;
			frmZaribMantagheRefresh = 0;
			string strWhere = " ";
			Load_Cmbo_FrmZarayeb(cmbo_OstanCodeFltr, "ZarayebMantaghe", "OstanCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_OstanFltr, "ZarayebMantaghe", "Ostan", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ZaribCodeFltr, "ZarayebMantaghe", "ZaribCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_CommentFltr, "ZarayebMantaghe", "Comment", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_OstanCode, "ZarayebMantaghe", "OstanCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Ostan, "ZarayebMantaghe", "Ostan", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ZaribCode, "ZarayebBakhshname", "ZaribCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Comment, "ZarayebMantaghe", "Comment", strWhere);
			FilterClear();
			Load_dtg_ZarayebMantaghe();
			dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[0].Cells[1];
			ShowZarayebMantagheRecord();
			frmZaribMantagheRefresh = 1;
			foreach (Control control in Pnl_Zarib.Controls)
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
			foreach (Control control in Pnl_Zarib.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

public void ShowZarayebMantagheRecord()
		{
			int index = 0;
			ref ZarayebMantagheDetailes zarayebMantaghe = ref ZarayebMantaghe;
			int lErl = default(int);
			if (dtg_ZarayebMantaghe.RowCount != 0)
			{
				try
				{
					index = dtg_ZarayebMantaghe.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				zarayebMantaghe.Id = Conversions.ToInteger(dtg_ZarayebMantaghe.Rows[index].Cells[0].Value);
				zarayebMantaghe.OstanCode = Conversions.ToString(dtg_ZarayebMantaghe.Rows[index].Cells[2].Value);
				zarayebMantaghe.Ostan = Conversions.ToString(dtg_ZarayebMantaghe.Rows[index].Cells[3].Value);
				zarayebMantaghe.ShahrCode = dtg_ZarayebMantaghe.Rows[index].Cells[4].Value.ToString();
				zarayebMantaghe.Shahr = dtg_ZarayebMantaghe.Rows[index].Cells[5].Value.ToString();
				zarayebMantaghe.BakhshCode = dtg_ZarayebMantaghe.Rows[index].Cells[6].Value.ToString();
				zarayebMantaghe.Bakhsh = dtg_ZarayebMantaghe.Rows[index].Cells[7].Value.ToString();
				zarayebMantaghe.zarib_F = Conversions.ToSingle(dtg_ZarayebMantaghe.Rows[index].Cells[8].Value.ToString());
				zarayebMantaghe.ZaribCode = Conversions.ToInteger(dtg_ZarayebMantaghe.Rows[index].Cells[9].Value.ToString());
				zarayebMantaghe.Comment = dtg_ZarayebMantaghe.Rows[index].Cells[10].Value.ToString();
				cmbo_OstanCode.Text = zarayebMantaghe.OstanCode;
				cmbo_Ostan.Text = zarayebMantaghe.Ostan;
				cmbo_ShahrCode.Text = zarayebMantaghe.ShahrCode;
				cmbo_Shahr.Text = zarayebMantaghe.Shahr;
				cmbo_BakhshCode.Text = zarayebMantaghe.BakhshCode;
				cmbo_Bakhsh.Text = zarayebMantaghe.Bakhsh;
				txt_Zarib_F.Text = Conversions.ToString(zarayebMantaghe.zarib_F);
				cmbo_ZaribCode.Text = Conversions.ToString(zarayebMantaghe.ZaribCode);
				int zaribCode = zarayebMantaghe.ZaribCode;
				if (zaribCode == Conversions.ToInteger("0"))
				{
					cmbo_Comment.SelectedIndex = 2;
				}
				else if (zaribCode == Conversions.ToInteger("1"))
				{
					cmbo_Comment.SelectedIndex = 1;
				}
				else if (zaribCode == Conversions.ToInteger("2"))
				{
					cmbo_Comment.SelectedIndex = 0;
				}
			}
			lErl = 60;
		}

private void dtg_ZarayebMantaghe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowZarayebMantagheRecord();
		}

private void dtg_ZarayebMantaghe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowZarayebMantagheRecord();
		}

private void dtg_ZarayebMantaghe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				cmbo_OstanCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_ZarayebMantaghe_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((Pnl_Zarib.BackColor == Color.LightPink) & (frmZaribMantagheRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Pnl_Zarib.BackColor = Color.DarkSeaGreen;
					break;
				case DialogResult.No:
					Pnl_Zarib.BackColor = Color.DarkSeaGreen;
					break;
				case DialogResult.Cancel:
					cmbo_OstanCode.Focus();
					return;
				}
			}
			if (DtgZaribMantaghetRefresh == 1)
			{
				ShowZarayebMantagheRecord();
			}
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			foreach (Control control in Pnl_Zarib.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && Operators.CompareString(control.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("اطلاعات را کامل کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					control.Focus();
					return;
				}
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
			{
				Module1.cmd.CommandText = "SELECT [Ostan],[Shahr],[Bakhsh] FROM [dbo].[ZarayebMantaghe] Where [Ostan]='" + cmbo_Ostan.Text + "' And [Shahr]='" + cmbo_Shahr.Text + "' And [Bakhsh]='" + cmbo_Bakhsh.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show(". منطقه مذکور موجود است منطقه جدید انتخاب کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbo_Ostan.Focus();
					sqlDataReader.Close();
					return;
				}
				sqlDataReader.Close();
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe] ([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) VALUES('" + cmbo_OstanCode.Text + "','" + cmbo_Ostan.Text + "','" + cmbo_ShahrCode.Text + "','" + cmbo_Shahr.Text + "','" + cmbo_BakhshCode.Text + " ','" + cmbo_Bakhsh.Text + "','" + cmbo_ZaribCode.Text + "','" + txt_Zarib_F.Text + "','" + cmbo_Comment.Text + "')";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_ZaribGreen();
			}
			else
			{
				Module1.cmd.CommandText = "UPDATE [dbo].[ZarayebMantaghe] SET [OstanCode] ='" + cmbo_OstanCode.Text + "',[Ostan] = '" + cmbo_Ostan.Text + "',[ShahrCode] = '" + cmbo_ShahrCode.Text + "',[Shahr] = '" + cmbo_Shahr.Text + "',[BakhshCode] = '" + cmbo_BakhshCode.Text + "',[Bakhsh] = '" + cmbo_Bakhsh.Text + "',[ZaribCode] = '" + cmbo_ZaribCode.Text + "',[zarib_F] = '" + txt_Zarib_F.Text + "',[Comment] = '" + cmbo_Comment.Text + "'WHERE Id = '" + Conversions.ToString(ZarayebMantaghe.Id) + "'";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_ZaribGreen();
			}
			Load_dtg_ZarayebMantaghe();
			DataGridView dataGridView = dtg_ZarayebMantaghe;
			checked
			{
				int num = dataGridView.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[2].Value, cmbo_OstanCode.Text, TextCompare: false), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[4].Value, cmbo_ShahrCode.Text, TextCompare: false)), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[6].Value, cmbo_BakhshCode.Text, TextCompare: false)), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[9].Value, cmbo_ZaribCode.Text, TextCompare: false))))
					{
						dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
						ShowZarayebMantagheRecord();
					}
				}
				dataGridView = null;
			}
		}

private void Setpnl_ZaribGreen()
		{
			Pnl_Zarib.BackColor = Color.DarkSeaGreen;
			foreach (object control in Pnl_Zarib.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in Pnl_Zarib.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void cmbo_OstanCodeCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_OstanCodeFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_OstanFltr.Text = "";
					strWhere = " Where [OstanCode] = '" + text + "'";
					OstanCode_filter = " ([Ostancode] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					OstanCode_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_OstanFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_OstanFltr.Text;
				OstanCode_filter = "";
				Shahr_filter = "";
				ShahrCode_filter = "";
				Bakhsh_filter = "";
				BakhshCode_filter = "";
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_OstanCodeFltr.Text = "";
					strWhere = " Where [Ostan] = N'" + text + "'";
					Ostan_filter = " ([Ostan] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					Ostan_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_ShahrCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ShahrCodeFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_ShahrFltr.Text = "";
					strWhere = " Where [ShahrCode] = '" + text + "'";
					ShahrCode_filter = " ([ShahrCode] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					ShahrCode_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_ShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ShahrFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_ShahrCodeFltr.Text = "";
					strWhere = " Where [Shahr] = N'" + text + "'";
					Shahr_filter = " ([Shahr] Like N'%" + text + "%')";
				}
				else
				{
					Shahr_filter = "";
					strWhere = " ";
				}
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_BakhshCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_BakhshCodeFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_BakhshFltr.Text = "";
					BakhshCode_filter = " ([BakhshCode] Like N'%" + text + "%')";
				}
				else
				{
					BakhshCode_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_BakhshFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_BakhshFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_BakhshCodeFltr.Text = "";
					Bakhsh_filter = " ([Bakhsh] Like N'%" + text + "%')";
				}
				else
				{
					Bakhsh_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void txt_ZaribMantagheFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ZaribMantagheFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				array = txt_ZaribMantagheFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ZaribMantaghe_filter = " ([zarib_F] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ZaribMantaghe_filter = "([zarib_F] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ZaribMantaghe_filter = "";
				}
			}
			else
			{
				ZaribMantaghe_filter = "";
			}
			Load_dtg_ZarayebMantaghe();
			ShowZarayebMantagheRecord();
		}

private void cmbo_ZaribCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ZaribCodeFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					ZaribCode_filter = " ([ZaribCode] Like N'%" + text + "%')";
					Comment_filter = "";
				}
				else
				{
					ZaribCode_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void cmbo_CommentFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_CommentFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					Comment_filter = " ([Comment] Like N'%" + text + "%')";
					ZaribCode_filter = "";
				}
				else
				{
					Comment_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (Pnl_Zarib.BackColor == Color.LightPink)
			{
				dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			cmbo_OstanCode.Text = "";
			cmbo_Ostan.Text = "";
			cmbo_ShahrCode.Text = "";
			cmbo_Shahr.Text = "";
			cmbo_BakhshCode.Text = "";
			cmbo_Bakhsh.Text = "";
			txt_Zarib_F.Text = "";
			cmbo_ZaribCode.Text = "";
			cmbo_Comment.Text = "";
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			FilterClear();
			Load_dtg_ZarayebMantaghe();
		}

private void cmbo_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_ZaribCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [Comment] FROM [dbo].[ZarayebMantaghe]  Where [ZaribCode] = '" + cmbo_ZaribCode.Text + "' Group By [Comment]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			cmbo_Comment.Text = text;
			UpdateZaribCode();
		}

private void cmbo_Comment_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Comment_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ZaribCode] FROM [dbo].[ZarayebMantaghe]  Where REPLACE(REPLACE([Comment],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(cmbo_Comment.Text) + "' Group By [ZaribCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			cmbo_ZaribCode.Text = text;
			UpdateZaribCode();
		}

private void btn_ZaribCode_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_ZarayebBakhshname.ShowDialog();
		}

private void cmbo_ShahrCode_FormatStringChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Shahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_BakhshCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Bakhsh_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Bakhsh_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_Zarib_F_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_Zarib_F_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_Zarib_F.Text = "";
			}
		}

private void txt_Zarib_F_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".ضریب باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_Zarib_F.Text = "";
			}
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			ShowZarayebMantagheRecord();
			int rowIndex = dtg_ZarayebMantaghe.CurrentCell.RowIndex;
			int columnIndex = dtg_ZarayebMantaghe.CurrentCell.ColumnIndex;
			BtnCommand = "Copy";
			if (Pnl_Zarib.BackColor == Color.LightPink)
			{
				dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_ZarayebMantaghe.CurrentRow.Index;
			if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(checked(rowIndex + 1)) + " کپی شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe]([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) (SELECT [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment] FROM [dbo].[ZarayebMantaghe] Where [Id]='" + Conversions.ToString(ZarayebMantaghe.Id) + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_ZarayebMantaghe();
				dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[rowIndex].Cells[columnIndex];
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			int rowIndex = dtg_ZarayebMantaghe.CurrentCell.RowIndex;
			int columnIndex = dtg_ZarayebMantaghe.CurrentCell.ColumnIndex;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_ZarayebMantaghe.RowCount - 1 != 0)
				{
					int index = dtg_ZarayebMantaghe.CurrentRow.Index;
					if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(rowIndex + 1) + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
					{
						return;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebMantaghe] WHERE Id = '" + Conversions.ToString(ZarayebMantaghe.Id) + "'";
					Module1.cmd.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				Load_dtg_ZarayebMantaghe();
				if (rowIndex == 0)
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[0].Cells[columnIndex];
				}
				if (rowIndex > dtg_ZarayebMantaghe.RowCount)
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[dtg_ZarayebMantaghe.RowCount].Cells[columnIndex];
				}
				if ((rowIndex > 0) & (dtg_ZarayebMantaghe.RowCount <= dtg_ZarayebMantaghe.RowCount))
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[rowIndex - 1].Cells[columnIndex];
				}
			}
		}

private void cmbo_OstanCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_OstanCode_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void cmbo_OstanCode_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void cmbo_OstanCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [OstanCode] = '" + cmbo_OstanCode.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT Ostan FROM [dbo].[ZarayebMantaghe] Where OstanCode ='" + cmbo_OstanCode.Text + "'Group By Ostan";
			SyncCmboZarib(cmbo_Ostan, strCommand);
			UpdateZaribCode();
		}

private void cmbo_Ostan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Ostan_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_Ostan.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [Ostan] = N'" + cmbo_Ostan.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT OstanCode FROM [dbo].[ZarayebMantaghe] Where Ostan =N'" + cmbo_Ostan.Text + "'Group By OstanCode";
			SyncCmboZarib(cmbo_OstanCode, strCommand);
			UpdateZaribCode();
		}

private void cmbo_ShahrCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [ShahrCode] = '" + cmbo_ShahrCode.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT Shahr FROM [dbo].[ZarayebMantaghe] Where ShahrCode ='" + cmbo_ShahrCode.Text + "'Group By Shahr";
			SyncCmboZarib(cmbo_Shahr, strCommand);
			UpdateZaribCode();
		}

private void cmbo_Shahr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_Shahr.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [Shahr] = N'" + cmbo_Shahr.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			SyncCmboZarib(strCommand: (Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) ? ("SELECT ShahrCode FROM [dbo].[ZarayebMantaghe] Where Shahr =N'" + cmbo_Shahr.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' Group By ShahrCode") : ("SELECT ShahrCode FROM [dbo].[ZarayebMantaghe] Where Shahr =N'" + cmbo_Shahr.Text + "'Group By ShahrCode"), strCmbo: cmbo_ShahrCode);
			UpdateZaribCode();
		}

private void cmbo_BakhshCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strCommand = "SELECT Bakhsh FROM [dbo].[ZarayebMantaghe] Where BakhshCode ='" + cmbo_BakhshCode.Text + "'Group By Bakhsh";
			SyncCmboZarib(cmbo_Bakhsh, strCommand);
			UpdateZaribCode();
		}

private void cmbo_Bakhsh_LostFocus(object sender, EventArgs e)
		{
		}

private void cmbo_Bakhsh_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strCommand = "";
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) == 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) == 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "'Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) == 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And ShahrCode ='" + cmbo_ShahrCode.Text + "' Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) == 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' And ShahrCode ='" + cmbo_ShahrCode.Text + "' Group By BakhshCode";
			}
			SyncCmboZarib(cmbo_BakhshCode, strCommand);
			UpdateZaribCode();
		}

private void SyncCmboZarib(ComboBox strCmbo, string strCommand)
		{
			string right = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = strCommand;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				right = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			if (Operators.CompareString(strCmbo.Text, right, TextCompare: false) != 0)
			{
				strCmbo.Text = right;
			}
		}

private void Load_Cmbo_FrmZarayeb(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT " + strField + " FROM [dbo]." + strTable + " " + strWhere + " Group By " + strField + " Order By " + strField;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			sqlDataReader.Close();
			strCmbo.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				strCmbo.Items.Add(RuntimeHelpers.GetObjectValue(row[strField]));
			}
			strCmbo.Text = "";
		}

private void cmbo_OstanCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_OstanCode.Text, ZarayebMantaghe.OstanCode, TextCompare: false) != 0)
				{
					cmbo_OstanCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_OstanCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_Ostan_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Ostan.Text, ZarayebMantaghe.Ostan, TextCompare: false) != 0)
				{
					cmbo_Ostan.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Ostan.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_ShahrCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ShahrCode.Text, ZarayebMantaghe.ShahrCode, TextCompare: false) != 0)
				{
					cmbo_ShahrCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ShahrCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_Shahr_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Shahr.Text, ZarayebMantaghe.Shahr, TextCompare: false) != 0)
				{
					cmbo_Shahr.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Shahr.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_BakhshCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_BakhshCode.Text, ZarayebMantaghe.BakhshCode, TextCompare: false) != 0)
				{
					cmbo_BakhshCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_BakhshCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_Bakhsh_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Bakhsh.Text, ZarayebMantaghe.Bakhsh, TextCompare: false) != 0)
				{
					cmbo_Bakhsh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Bakhsh.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void txt_Zarib_F_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(txt_Zarib_F.Text, ZarayebMantaghe.zarib_F.ToString(), TextCompare: false) != 0)
				{
					txt_Zarib_F.ForeColor = Color.Red;
				}
				else
				{
					txt_Zarib_F.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void CheckZaribMantageChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			Pnl_Zarib.BackColor = Color.DarkSeaGreen;
			foreach (object control in Pnl_Zarib.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					Pnl_Zarib.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in Pnl_Zarib.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					Pnl_Zarib.BackColor = Color.LightPink;
					break;
				}
			}
		}

public void UpdateZaribCode()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "Select [zarib_F] FROM [dbo].[ZarayebMantaghe] WHERE [OstanCode]='" + cmbo_OstanCode.Text + "' And [ShahrCode]= '" + cmbo_ShahrCode.Text + "' And [BakhshCode]= '" + cmbo_BakhshCode.Text + "' And [ZaribCode]= '" + cmbo_ZaribCode.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			txt_Zarib_F.Text = "";
			while (sqlDataReader.Read())
			{
				txt_Zarib_F.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
		}

public void FindZarib_F()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebMantaghe] WHERE [ZaribCode]='0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe] ([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) (SELECT [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],'0'[ZaribCode],'1'[zarib_F], 'ضريب 1 براي فصل هاي بدون ضريب'[Comment] FROM [dbo].[ZarayebMantaghe] Group by [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh])";
			Module1.cmd.ExecuteNonQuery();
		}

private void btn_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_Comment_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Comment.Text, ZarayebMantaghe.Comment, TextCompare: false) != 0)
				{
					cmbo_Comment.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Comment.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Conversions.ToDouble(cmbo_ZaribCode.Text) != (double)ZarayebMantaghe.ZaribCode)
				{
					cmbo_ZaribCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ZaribCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

private void cmbo_OstanFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_OstanFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_OstanCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_OstanCodeCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_ShahrCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_ShahrCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_ShahrFltr_TextChanged(object sender, EventArgs e)
		{
		}

private void cmbo_BakhshCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_BakhshCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_BakhshFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_BakhshFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_ZaribCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_ZaribCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_CommentFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_CommentFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void Btn_Save_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void btn_Insert_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void btn_copy_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void btn_Delete_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void btn_Exit_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void FilterClear()
		{
			btn_Filter.BackColor = Color.LightGray;
			Ostan_filter = "";
			OstanCode_filter = "";
			Shahr_filter = "";
			ShahrCode_filter = "";
			Bakhsh_filter = "";
			BakhshCode_filter = "";
			ZaribMantaghe_filter = "";
			ZaribCode_filter = "";
			Comment_filter = "";
			cmbo_OstanCodeFltr.Text = "";
			cmbo_OstanFltr.Text = "";
			cmbo_ShahrCodeFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_BakhshCodeFltr.Text = "";
			cmbo_BakhshFltr.Text = "";
			txt_ZaribMantagheFltr.Text = "";
			cmbo_ZaribCodeFltr.Text = "";
			cmbo_CommentFltr.Text = "";
		}

    }
}
