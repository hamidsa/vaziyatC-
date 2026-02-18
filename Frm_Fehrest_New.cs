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
    public partial class Frm_Fehrest_New : Form
    {
        public struct FehrestDetailes
		{
			public int Id;

			public string FehrestFile;

			public string FehrestName;

			public string FehrestMabna;
		}

        // Private fields
        private byte frmFehrestRefresh;
        private string BtnCommand;
        private string ChangeDtgOrPnl;
        private byte DtgFehrestRefresh;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_Fehrest_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Fehrest_New_KeyDown;
            this.Load += Frm_Fehrest_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void btn_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

public void ShowFehrestRecord()
		{
			int index = 0;
			Module1.DatePikerSit = false;
			ref FehrestDetailes fehrest = ref Fehrest;
			int lErl = default(int);
			if (dtg_Fehrest.RowCount != 0)
			{
				try
				{
					index = dtg_Fehrest.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				fehrest.Id = Conversions.ToInteger(dtg_Fehrest.Rows[index].Cells[0].Value);
				fehrest.FehrestFile = Conversions.ToString(dtg_Fehrest.Rows[index].Cells[2].Value);
				fehrest.FehrestName = dtg_Fehrest.Rows[index].Cells[3].Value.ToString();
				fehrest.FehrestMabna = dtg_Fehrest.Rows[index].Cells[4].Value.ToString();
				txt_FehrestName.Text = fehrest.FehrestName;
				txt_FehrestFile.Text = fehrest.FehrestFile;
				cmbo_FehrestMabna.Text = fehrest.FehrestMabna;
			}
			lErl = 60;
		}

private void dtg_Fehrest_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			ShowFehrestRecord();
		}

private void dtg_Fehrest_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFehrestRecord();
		}

private void dtg_Fehrest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Open_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void dtg_Fehrest_KeyDown(object sender, KeyEventArgs e)
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
				txt_FehrestFile.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Fehrest_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات فهرست بها ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_FehrestBlue();
					break;
				case DialogResult.No:
					SetPnl_FehrestBlue();
					break;
				case DialogResult.Cancel:
					txt_FehrestFile.Focus();
					return;
				}
			}
			if (DtgFehrestRefresh == 1)
			{
				ShowFehrestRecord();
			}
		}

private void Frm_Fehrest_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_Fehrest_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmFehrestRefresh = 0;
			DtgFehrestRefresh = 0;
			cmbo_FehrestMabna.Items.Clear();
			cmbo_FehrestMabna.Items.Add("(پايه)");
			cmbo_FehrestMabna.Items.Add("-");
			DtgFehrestRefresh = 1;
			frmFehrestRefresh = 1;
			foreach (Control control in pnl_Fehrest.Controls)
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
			foreach (Control control in pnl_Fehrest.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

public void Load_dtg_Fehrest()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[5];
			base.Visible = true;
			pnl_Fehrest.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 2);
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
				}
				if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0 && Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				Module1.strWhere = " WHERE " + Module1.FehrestFile_filter + array[1] + Module1.FehrestName_filter + array[2] + Module1.FehrestMabna_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [kod] As 'Id',[kod] As 'ردیف', [filename] As 'فایل فهرست', [fehrest] As 'نام فهرست',[jari] As 'پایه' FROM [dbo].[Fehrest] " + Module1.strWhere + " Order by [filename] desc";
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
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["پایه"], "(پايه)", TextCompare: false))
					{
						Module1.MabnaFehresrFile = Conversions.ToString(dataTable.Rows[i]["فایل فهرست"]);
					}
				}
				dtg_Fehrest.DataSource = dataTable;
				dtg_Fehrest.Columns[0].Visible = false;
				dtg_Fehrest.Columns[1].Width = 50;
				dtg_Fehrest.Columns[2].Width = 150;
				dtg_Fehrest.Columns[3].Width = 350;
				dtg_Fehrest.Columns[4].Width = 70;
			}
		}

private void btn_Open_Click(object sender, EventArgs e)
		{
			Module1.FAslOrItem = "Fasl";
			MyProject.Forms.Frm_FehrestDetail.ShowDialog();
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(txt_FehrestFile.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("فایل فهرست بها را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_FehrestFile.Focus();
				}
				else
				{
					if (pnl_Fehrest.BackColor == Color.DarkSeaGreen)
					{
						return;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + txt_FehrestFile.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + txt_FehrestFile.Text + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FehrestFile.Text = "";
							txt_FehrestFile.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Fehrest] ([filename],[Fehrest],[jari]) VALUES('" + txt_FehrestFile.Text + "','" + txt_FehrestName.Text + "','-')";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '(پايه)'  WHERE [filename] = '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '-'  WHERE [filename] <> '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_FehrestBlue();
					}
					else
					{
						Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + txt_FehrestFile.Text + "' And kod <> '" + Conversions.ToString(Fehrest.Id) + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + txt_FehrestFile.Text + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FehrestFile.Text = "";
							txt_FehrestFile.Focus();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest] SET [filename] ='" + txt_FehrestFile.Text + "',[fehrest] = '" + txt_FehrestName.Text + "',[jari] = '" + cmbo_FehrestMabna.Text + "'WHERE kod = '" + Conversions.ToString(Fehrest.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '(پايه)'  WHERE [filename] = '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '-'  WHERE [filename] <> '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_FehrestBlue();
					}
					text = txt_FehrestFile.Text;
					Load_dtg_Fehrest();
					int num = dtg_Fehrest.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Fehrest.Rows[i].Cells[2].Value, text, TextCompare: false))
						{
							dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[i].Cells[1];
							ShowFehrestRecord();
						}
					}
				}
			}
		}

private void SetPnl_FehrestBlue()
		{
			pnl_Fehrest.BackColor = Color.DarkSeaGreen;
			foreach (object control in pnl_Fehrest.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Fehrest.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Fehrest.BackColor = Color.LightPink;
			txt_FehrestFile.Text = "";
			txt_FehrestName.Text = "";
			cmbo_FehrestMabna.Text = "-";
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_FehrestFile.Text;
			BtnCommand = "Copy";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text2 = Interaction.InputBox("  کپی فایل فهرست بهای " + Fehrest.FehrestFile + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text2, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + text2 + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + text2 + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fehrest]([filename],[fehrest],[jari]) (Select '" + text2 + "'[filename],[fehrest],''[jari] FROM [dbo].[Fehrest] Where [filename]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "CREATE TABLE [dbo].[" + text2 + "]([radif] [nvarchar](10) NULL,[shomar] [nvarchar](10) NOT NULL,[Sharh] [nvarchar](1000) NOT NULL,[Fasl] [nvarchar](5) NOT NULL,[vkod] [decimal](18, 1) NULL,[Vahed] [nvarchar](100) NOT NULL,[baha] [nvarchar](100) NOT NULL,[darsad] [bit] NULL,[setareh] [bit] NULL,[ItemNoa] [nvarchar](20) NOT NULL,[ItemDarsad] [nvarchar](200) NULL,[GroupNo] [nchar](10) NULL,[GroupName] [nvarchar](200) NULL,[Selection] [bit] NULL) ON [PRIMARY]";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[" + text2 + "] ([radif],[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection]) (SELECT [radif],[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection] FROM [Jahdazma1].[dbo].[" + text + "])";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([Id],[FehrestFile],[FaslCode],[FaslComment],[ZaribCode])(SELECT [Id],'" + text2 + "'[FehrestFile],[FaslCode],[FaslComment],[ZaribCode] FROM [dbo].[Fosool] where [FehrestFile]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Fehrest();
			checked
			{
				int num = dtg_Fehrest.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Fehrest.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[i].Cells[1];
						ShowFehrestRecord();
						break;
					}
				}
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_FehrestFile.Text;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Fehrest.RowCount - 1 != 0 && MessageBox.Show(" حذف شود؟ " + txt_FehrestFile.Text + " فهرست با نام فایل ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE fehrestfile = '" + text + "'";
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						MessageBox.Show(".ابتدا سند های مرتبط به این فهرست بها بایستی حذف شوند ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					sqlDataReader.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = ("DELETE FROM [dbo].[Fehrest]  WHERE [filename] = '" + text) ?? "";
					sqlCommand.ExecuteNonQuery();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = ("DELETE FROM [dbo].[Fosool] where [FehrestFile] = '" + text) ?? "";
					sqlCommand.ExecuteNonQuery();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "DROP TABLE [dbo].[" + text + "]";
					sqlCommand.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				int lErl = 20;
				Load_dtg_Fehrest();
				try
				{
					int index = dtg_Fehrest.CurrentRow.Index;
					if (index != 0)
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[index - 1].Cells[1];
					}
					else
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[index].Cells[1];
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				ShowFehrestRecord();
			}
		}

private void btn_Exit_Click_1(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

private void txt_FehrestName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_FehrestName_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FehrestName.Text.Trim(), Fehrest.FehrestName.Trim(), TextCompare: false) != 0)
			{
				txt_FehrestName.ForeColor = Color.Red;
			}
			else
			{
				txt_FehrestName.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

private void txt_FehrestFile_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_FehrestFile_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FehrestFile.Text.Trim(), Fehrest.FehrestFile.Trim(), TextCompare: false) != 0)
			{
				txt_FehrestFile.ForeColor = Color.Red;
			}
			else
			{
				txt_FehrestFile.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

private void cmbo_FehrestMabna_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_FehrestMabna_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_FehrestMabna.Text.Trim(), Fehrest.FehrestMabna.Trim(), TextCompare: false) != 0)
			{
				if (Operators.CompareString(cmbo_FehrestMabna.Text, "(پايه)", TextCompare: false) == 0)
				{
					Module1.MabnaFehresrName = txt_FehrestName.Text;
					Module1.MabnaFehresrFile = txt_FehrestFile.Text;
				}
				cmbo_FehrestMabna.ForeColor = Color.Red;
			}
			else
			{
				cmbo_FehrestMabna.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

private void CheckFehrestChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Fehrest.BackColor = Color.Tan;
			foreach (object control in pnl_Fehrest.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Fehrest.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Fehrest.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Fehrest.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void txt_FehrestFileFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_FehrestFileFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_FehrestFileFltr.Text;
					Module1.FehrestFile_filter = " ([filename] Like N'%" + text + "%')";
				}
				else
				{
					Module1.FehrestFile_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}

private void txt_FehrestNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_FehrestNameFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_FehrestNameFltr.Text;
					Module1.FehrestName_filter = " (REPLACE(REPLACE([fehrest],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					Module1.FehrestName_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}

private void cmbo_FehrestMabnaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(cmbo_FehrestMabnaFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = cmbo_FehrestMabnaFltr.Text;
					Module1.FehrestMabna_filter = " (REPLACE(REPLACE([jari],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					Module1.FehrestMabna_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}

    }
}
