using Microsoft.VisualBasic.CompilerServices;
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
    public partial class Frm_ZarayebBakhshname_New : Form
    {
        public struct BakhshnameDetailes
		{
			public int Id;

			public string ZaribCode;

			public string ZaribCodeComment;
		}

        // Private fields
        private TextBox _txt_ZaribCode;
        private Button _Btn_Insert;
        private Button _Btn_Copy;
        private Button _btn_Delete;
        private Button _Btn_Exit;
        private TextBox _txt_ZaribCodeComment;
        private Button _Btn_Save;
        private DataGridView _dtg_Bakhshname;
        private string BtnCommand;
        private string ChangeDtgOrPnl;
        private byte frmBakhshnameRefresh;
        private byte DtgBakhshnameRefresh;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_ZarayebBakhshname_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_ZarayebBakhshname_New_KeyDown;
            this.Load += Frm_ZarayebBakhshname_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void Frm_ZarayebBakhshname_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_ZaribCode_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmBakhshnameRefresh = 0;
			Load_dtg_Bakhshname();
			dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[0].Cells[1];
			ShowBakhshnameRecord();
			frmBakhshnameRefresh = 1;
			foreach (Control control in pnl_Bakhshname.Controls)
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
			foreach (Control control in pnl_Bakhshname.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

public void Load_dtg_Bakhshname()
		{
			DataTable dataTable = new DataTable();
			base.Visible = true;
			base.KeyPreview = true;
			DtgBakhshnameRefresh = 0;
			base.KeyPreview = true;
			Module1.WhereZaribCode = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [Id] As 'Id',[Id] As 'ردیف',[ZaribCode] As 'کد بخشنامه',[Comment] As 'شرح کد بخشنامه' FROM [dbo].[ZarayebBakhshname] " + Module1.WhereZaribCode + " Order By ZaribCode ";
			SqlDataReader reader = Module1.cmd.ExecuteReader();
			dataTable.Load(reader);
			foreach (DataColumn column in dataTable.Columns)
			{
				column.ReadOnly = false;
			}
			checked
			{
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
				}
				dtg_Bakhshname.DataSource = dataTable;
				dtg_Bakhshname.Columns[0].Visible = false;
				dtg_Bakhshname.Columns[1].Width = 50;
				dtg_Bakhshname.Columns[2].Width = 50;
				dtg_Bakhshname.Columns[3].Width = 670;
			}
			foreach (Control control3 in pnl_Bakhshname.Controls)
			{
				if (control3 is TextBox || control3 is ComboBox || control3 is Button)
				{
					control3.KeyDown += GeneralKeyDownHandler;
				}
			}
			foreach (Control control4 in pnl_Bakhshname.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.KeyDown += GeneralKeyDownHandler;
				}
			}
			DtgBakhshnameRefresh = 1;
			lbl_RecNo.Text = Conversions.ToString(dataTable.Rows.Count) + " :تعداد رکورد";
		}

private void GeneralKeyDownHandler(object sender, KeyEventArgs e)
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

public void ShowBakhshnameRecord()
		{
			int index = 0;
			ref BakhshnameDetailes bakhshname = ref Bakhshname;
			int lErl = default(int);
			if (dtg_Bakhshname.RowCount != 0)
			{
				try
				{
					index = dtg_Bakhshname.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				if (dtg_Bakhshname.RowCount != 0)
				{
					try
					{
						bakhshname.Id = Conversions.ToInteger(dtg_Bakhshname.Rows[index].Cells[0].Value);
					}
					catch (NullReferenceException ex3)
					{
						ProjectData.SetProjectError(ex3, lErl);
						NullReferenceException ex4 = ex3;
						ProjectData.ClearProjectError();
						goto IL_0151;
					}
					bakhshname.Id = Conversions.ToInteger(dtg_Bakhshname.Rows[index].Cells[0].Value);
					bakhshname.ZaribCode = Conversions.ToString(dtg_Bakhshname.Rows[index].Cells[2].Value);
					bakhshname.ZaribCodeComment = dtg_Bakhshname.Rows[index].Cells[3].Value.ToString();
					txt_ZaribCode.Text = bakhshname.ZaribCode;
					txt_ZaribCodeComment.Text = bakhshname.ZaribCodeComment;
				}
			}
			goto IL_0151;
			IL_0151:
			lErl = 60;
		}

private void Btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

private void dtg_Bakhshname_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowBakhshnameRecord();
		}

private void dtg_Bakhshname_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowBakhshnameRecord();
		}

private void dtg_Bakhshname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				Btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				Btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_ZaribCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Bakhshname_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Bakhshname.BackColor == Color.LightPink) & (frmBakhshnameRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					pnl_Bakhshname.BackColor = Color.LightCyan;
					break;
				case DialogResult.No:
					pnl_Bakhshname.BackColor = Color.LightCyan;
					break;
				case DialogResult.Cancel:
					txt_ZaribCode.Focus();
					return;
				}
			}
			if (DtgBakhshnameRefresh == 1)
			{
				ShowBakhshnameRecord();
			}
			ShowBakhshnameRecord();
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			foreach (Control control in pnl_Bakhshname.Controls)
			{
				if ((object)control.GetType() == typeof(TextBox) && Operators.CompareString(control.Text, "", TextCompare: false) == 0)
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
				Module1.cmd.CommandText = "SELECT [ZaribCode],[Comment] FROM [dbo].[ZarayebBakhshname] Where [ZaribCode]='" + txt_ZaribCode.Text + "' And [Comment]='" + txt_ZaribCodeComment.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show(". اطلاعات مذکور موجود است اطلاعات جدید وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_ZaribCode.Focus();
					sqlDataReader.Close();
					return;
				}
				sqlDataReader.Close();
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebBakhshname] ([ZaribCode],[Comment]) VALUES('" + txt_ZaribCode.Text + "','" + txt_ZaribCodeComment.Text + "')";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_BakhshnameGreen();
			}
			else
			{
				Module1.cmd.CommandText = "UPDATE [dbo].[ZarayebBakhshname] SET [ZaribCode] ='" + txt_ZaribCode.Text + "',[Comment] = '" + txt_ZaribCodeComment.Text + "' WHERE Id = '" + Conversions.ToString(Bakhshname.Id) + "'";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_BakhshnameGreen();
			}
			Load_dtg_Bakhshname();
			DataGridView dataGridView = dtg_Bakhshname;
			checked
			{
				int num = dataGridView.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[2].Value, txt_ZaribCode.Text, TextCompare: false), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[3].Value, txt_ZaribCodeComment.Text, TextCompare: false))))
					{
						dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
						ShowBakhshnameRecord();
					}
				}
				dataGridView = null;
			}
		}

private void Setpnl_BakhshnameGreen()
		{
			pnl_Bakhshname.BackColor = Color.LightCyan;
			foreach (object control in pnl_Bakhshname.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Bakhshname.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void Btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Bakhshname.BackColor == Color.LightPink)
			{
				dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			txt_ZaribCode.Text = "";
			txt_ZaribCodeComment.Text = "";
		}

private void Btn_Copy_Click(object sender, EventArgs e)
		{
			ShowBakhshnameRecord();
			int rowIndex = dtg_Bakhshname.CurrentCell.RowIndex;
			int columnIndex = dtg_Bakhshname.CurrentCell.ColumnIndex;
			BtnCommand = "Copy";
			if (pnl_Bakhshname.BackColor == Color.LightPink)
			{
				dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_Bakhshname.CurrentRow.Index;
			if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(checked(rowIndex + 1)) + " کپی شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebBakhshname]([ZaribCode],[Comment]) (SELECT [ZaribCode],[Comment] FROM [dbo].[ZarayebBakhshname] Where [Id]='" + Conversions.ToString(Bakhshname.Id) + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Bakhshname();
				dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[rowIndex].Cells[columnIndex];
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			int rowIndex = dtg_Bakhshname.CurrentCell.RowIndex;
			int columnIndex = dtg_Bakhshname.CurrentCell.ColumnIndex;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Bakhshname.RowCount - 1 != 0)
				{
					int index = dtg_Bakhshname.CurrentRow.Index;
					if (MessageBox.Show("کد بخشنامه با شماره   " + txt_ZaribCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
					{
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [FehrestFile] FROM [dbo].[Fosool] WHERE [ZaribCode] = '" + txt_ZaribCode.Text + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						MessageBox.Show("ابتدا فهرست بهاهایی که مرتبط با کد بخشنامه   " + txt_ZaribCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebBakhshname] WHERE [ZaribCode] = '" + txt_ZaribCode.Text + "'";
					Module1.cmd.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				Load_dtg_Bakhshname();
				if (rowIndex == 0)
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[0].Cells[columnIndex];
				}
				if (rowIndex > dtg_Bakhshname.RowCount)
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[dtg_Bakhshname.RowCount].Cells[columnIndex];
				}
				if ((rowIndex > 0) & (dtg_Bakhshname.RowCount <= dtg_Bakhshname.RowCount))
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[rowIndex - 1].Cells[columnIndex];
				}
			}
		}

private void txt_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (frmBakhshnameRefresh != 0)
			{
				if (Operators.CompareString(txt_ZaribCode.Text, Bakhshname.ZaribCode.ToString(), TextCompare: false) != 0)
				{
					txt_ZaribCode.ForeColor = Color.Red;
				}
				else
				{
					txt_ZaribCode.ForeColor = Color.Black;
				}
			}
			CheckBakhshnameChange();
		}

private void txt_ZaribCodeComment_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ZaribCodeComment_TextChanged(object sender, EventArgs e)
		{
			if (frmBakhshnameRefresh != 0)
			{
				if (Operators.CompareString(txt_ZaribCodeComment.Text, Bakhshname.ZaribCodeComment.ToString(), TextCompare: false) != 0)
				{
					txt_ZaribCodeComment.ForeColor = Color.Red;
				}
				else
				{
					txt_ZaribCodeComment.ForeColor = Color.Black;
				}
			}
			CheckBakhshnameChange();
		}

private void CheckBakhshnameChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Bakhshname.BackColor = Color.LightCyan;
			foreach (object control in pnl_Bakhshname.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Bakhshname.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Bakhshname.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Bakhshname.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void Btn_Save_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void Btn_Insert_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void Btn_Copy_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void Btn_Delet_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void Btn_Exit_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

    }
}
