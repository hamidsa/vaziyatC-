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
    public partial class Frm_FehrestDetail_New : Form
    {
        public struct FehrestFaslDetailes
		{
			public int Id;

			public string FehrestFile;

			public string FaslCode;

			public string FaslComment;

			public string ZaribCode;
		}

        public struct FehrestItemDetailes
		{
			public int Id;

			public string ItemNo;

			public string ItemSharh;

			public string ItemFasl;

			public int ItemVahedCode;

			public string ItemVahedSharh;

			public float ItemBahaVahed;

			public string ItemNoa;

			public string ItemDarsad;

			public string GroupName;
		}

        // Private fields
        private TabPage _tbp_Item;
        private ComboBox _cmbo_FehrestItem;
        private TextBox _txt_ItemNoFltr;
        private ComboBox _cmbo_ItemNoaFltr;
        private TextBox _txt_ItemBahavahedFltr;
        private TextBox _txt_ItemSharhFltr;
        private Button _btn_Filter;
        private DataGridView _dtg_Item;
        private TabPage _tbp_Fosool;
        private ComboBox _cmbo_Fehrest;
        private DataGridView _dtg_Fosool;
        private ComboBox _cmbo_ZaribCode;
        private Button _Btn_Save;
        private TextBox _txt_FaslCode;
        private TextBox _txt_FaslComment;
        private ComboBox _cmbo_ItemNoa;
        private TextBox _txt_ItemBahavahed;
        private Button _btn_SaveItem;
        private Button _btn_VahedSearch;
        private TextBox _txt_ItemNo;
        private TextBox _txt_ItemSharh;
        private ComboBox _cmbo_ItemFaslFltr;
        private ComboBox _cmbo_ItemVahedSharhFltr;
        private TextBox _txt_ZaribComment;
        private Button _Btn_Insert;
        private Button _Btn_Copy;
        private Button _btn_Delete;
        private Button _Btn_Exit;
        private Button _btn_ExitItem;
        private Button _btn_CopyItem;
        private Button _btn_DeleteItem;
        private Button _btn_InsertItem;
        private TextBox _txt_ItemDarsad;
        private ComboBox _cmbo_GroupFltr;
        private ComboBox _cmbo_ItemVahedSharh;
        private ComboBox _cmbo_ItemFasl;
        private Button _btn_GroupSearch;
        private string BtnCommand;
        private string ChangeFossolDtgOrPnl;
        private string ChangeItemDtgOrPnl;
        private byte DtgFosoolRefresh;
        private byte DtgItemRefresh;
        private byte Darsadi;
        private byte setarehdar;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;
        public FehrestFaslDetailes Fasl;

        public FehrestItemDetailes Item;

        public string FaslCode_Filter;

        public string FaslComment_Filter;

        public string ZaribCode_Filter;

        public string ItemNo_Filter;

        public string ItemSharh_Filter;

        public string ItemVahedSharh_Filter;

        public string ItemBahaVahed_Filter;

        public string ItemFasl_Filter;

        public string GroupName_Filter;

        public string ItemNoa_Filter;

 
        public Frm_FehrestDetail_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_FehrestDetail_New_KeyDown;
            this.Load += Frm_FehrestDetail_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void Frm_FehrestDetail_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Escape)
			{
				Btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_FehrestDetail_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			DtgFosoolRefresh = 0;
			DtgItemRefresh = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [fehrest] FROM [dbo].[Fehrest] Group By [fehrest] order by [Fehrest] desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_Fehrest.DataSource = dataTable;
			cmbo_Fehrest.DisplayMember = "Fehrest";
			cmbo_FehrestItem.DataSource = dataTable;
			cmbo_FehrestItem.DisplayMember = "Fehrest";
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0)
			{
				Module1.CurrentFehrestFile = Module1.FindCodeOrName(cmbo_Fehrest.Text, "[fehrest]", "[filename]", "[fehrest]");
			}
			Module1.Load_Cmbo(cmbo_ZaribCode, "ZarayebMantaghe", "ZaribCode", "");
			Module1.Load_Cmbo(cmbo_ItemFasl, "Fosool", "FaslCode", "");
			Module1.Load_Cmbo(cmbo_Group, Module1.CurrentFehrestFile, "GroupName", "");
			Module1.Load_Cmbo(cmbo_ItemNoa, Module1.CurrentFehrestFile, "ItemNoa", "");
			Module1.Load_Cmbo(cmbo_ItemVahedSharh, Module1.CurrentFehrestFile, "Vahed", "");
			if (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) == 0)
			{
				tab_Fosool.SelectedIndex = 1;
				tab_Fosool.TabPages[1].Show();
				Module1.FAslOrItem = "";
			}
			if (Operators.CompareString(MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text, "", TextCompare: false) != 0)
			{
				cmbo_Fehrest.Text = MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text;
				cmbo_FehrestItem.Text = MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text;
			}
			DtgFosoolRefresh = 1;
			DtgItemRefresh = 1;
			foreach (Control control3 in pnl_Fasl.Controls)
			{
				if (control3 is TextBox || control3 is ComboBox || control3 is Button)
				{
					control3.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control3.KeyDown += GeneralKeyDownHandler1;
				}
				if (control3 is TextBox || control3 is Button)
				{
					control3.KeyDown += GeneralKeyDownHandler2;
				}
			}
			foreach (Control control4 in pnl_Item.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control4.KeyDown += GeneralKeyDownHandler1;
				}
				if (control4 is TextBox || control4 is Button)
				{
					control4.KeyDown += GeneralKeyDownHandler2;
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
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
			}
			if ((e.KeyCode == Keys.F2) & (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) == 0))
			{
				btn_SaveItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if ((e.KeyCode == Keys.F2) & (Operators.CompareString(Module1.FAslOrItem, "Fasl", TextCompare: false) == 0))
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
			foreach (Control control3 in pnl_Item.Controls)
			{
				if (control3 is TextBox || control3 is ComboBox || control3 is Button)
				{
					control3.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
			foreach (Control control4 in pnl_Fasl.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

private void cmbo_Fehrest_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) != 0)
			{
				tbp_Fosool_Enter(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

public void Load_dtg_Fosool()
		{
			DataTable dataTable = new DataTable();
			string arab = cmbo_Fehrest.Text;
			string[] array = new string[5];
			base.Visible = true;
			int num = 0;
			do
			{
				array[num] = "";
				num = checked(num + 1);
			}
			while (num <= 4);
			if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
				{
					array[1] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[3] = " And ";
				}
			}
			if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[3] = " And ";
				}
			}
			if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0 && Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
			{
				array[3] = " And ";
			}
			Module1.strWhere = " WHERE " + Module1.FehrestFile_filter + array[1] + Module1.FehrestName_filter + array[2] + Module1.FehrestFile_filter + array[3] + Module1.FehrestMabna_filter + array[4];
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
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(arab) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Id As 'Id',[FaslCode] As 'فصل',[FaslComment] As 'شرح',[ZaribCode] As 'کد ضریب',(SELECT Top 1 [Comment]  FROM [dbo].[ZarayebMantaghe]  Where [ZaribCode] =[Fosool].ZaribCode)  As 'شرح کد ضریب' FROM [dbo].[Fosool] where [FehrestFile]= '" + Module1.CurrentFehrestFile + "' Order By [FaslCode]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			dtg_Fosool.DataSource = dataTable;
			sqlDataReader.Close();
			dtg_Fosool.Columns[0].Visible = false;
			dtg_Fosool.Columns[1].Width = 50;
			dtg_Fosool.Columns[2].Width = 600;
			dtg_Fosool.Columns[3].Width = 50;
			dtg_Fosool.Columns[4].Width = 500;
			Module1.FAslOrItem = "Fasl";
		}

public void Load_dtg_Item()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[7];
			base.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 5);
				if (Operators.CompareString(ItemNo_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0 && Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
				{
					array[6] = " And ";
				}
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemSharh_Filter + array[2] + ItemVahedSharh_Filter + array[3] + ItemBahaVahed_Filter + array[4] + ItemFasl_Filter + array[5] + ItemNoa_Filter + array[5] + GroupName_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(cmbo_Fehrest.Text) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					while (sqlDataReader.Read())
					{
						Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
					}
					sqlDataReader.Close();
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) != 0)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [radif] As 'Id',[darsad] As 'Chk',[radif] As 'ردیف',[shomar] As 'ایتم',[Sharh] As 'شرح ایتم',[Fasl] As 'فصل',[Vahed] As 'واحد',[baha] As 'بها',[ItemNoa] As 'نوع ایتم',[ItemDarsad] As 'درصد نسبت به',[GroupName] As 'گروه' FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Order By [shomar]";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					dataTable.Load(sqlDataReader);
					foreach (DataColumn column in dataTable.Columns)
					{
						column.ReadOnly = false;
					}
					int num2 = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num2; i++)
					{
						dataTable.Rows[i]["ردیف"] = i + 1;
						dataTable.Rows[i]["Chk"] = 0;
					}
					dtg_Item.DataSource = dataTable;
					dtg_Item.Columns[0].Visible = false;
					dtg_Item.Columns[1].Visible = false;
					dtg_Item.Columns[2].ReadOnly = true;
					dtg_Item.Columns[2].Width = 60;
					dtg_Item.Columns[3].ReadOnly = true;
					dtg_Item.Columns[3].Width = 60;
					dtg_Item.Columns[4].ReadOnly = true;
					dtg_Item.Columns[4].Width = 500;
					dtg_Item.Columns[5].ReadOnly = true;
					dtg_Item.Columns[5].Width = 40;
					dtg_Item.Columns[6].ReadOnly = true;
					dtg_Item.Columns[6].Width = 80;
					dtg_Item.Columns[7].ReadOnly = true;
					dtg_Item.Columns[7].Width = 70;
					dtg_Item.Columns[8].ReadOnly = true;
					dtg_Item.Columns[8].Width = 80;
					dtg_Item.Columns[9].ReadOnly = true;
					dtg_Item.Columns[9].Visible = false;
					dtg_Item.Columns[10].ReadOnly = true;
					dtg_Item.Columns[10].Width = 226;
					Module1.FAslOrItem = "Item";
					dtg_Item.Refresh();
					sqlDataReader.Close();
				}
				Module1.MyConn.Close();
			}
		}

public void tbp_Item_Enter(object sender, EventArgs e)
		{
			cmbo_FehrestItem.Text = cmbo_Fehrest.Text;
			Load_dtg_Item();
		}

public void tbp_Fosool_Enter(object sender, EventArgs e)
		{
			Load_dtg_Fosool();
		}

private void cmbo_FehrestItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			DataTable dataTable4 = new DataTable();
			if (Operators.CompareString(cmbo_FehrestItem.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where [Fehrest] =N'" + cmbo_FehrestItem.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			if ((Module1.CurrentFehrestFile == null) | (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0))
			{
				return;
			}
			cmbo_ItemFaslFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Fasl] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [Fasl] Order By [Fasl]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_ItemFaslFltr.Items.Add("");
			foreach (DataRow row in dataTable.Rows)
			{
				cmbo_ItemFaslFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Fasl"]));
			}
			cmbo_ItemFaslFltr.Text = "";
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemVahedSharhFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Vahed] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [Vahed] Order By [Vahed]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable2.Load(sqlDataReader);
			cmbo_ItemVahedSharhFltr.Items.Add("");
			foreach (DataRow row2 in dataTable2.Rows)
			{
				cmbo_ItemVahedSharhFltr.Items.Add(RuntimeHelpers.GetObjectValue(row2["Vahed"]));
			}
			cmbo_ItemVahedSharhFltr.Text = "";
			sqlDataReader.Close();
			dataTable2.Clear();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_GroupFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [GroupName] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [GroupName] Order By [GroupName]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable3.Load(sqlDataReader);
			cmbo_GroupFltr.Items.Add("");
			foreach (DataRow row3 in dataTable3.Rows)
			{
				cmbo_GroupFltr.Items.Add(RuntimeHelpers.GetObjectValue(row3["GroupName"]));
			}
			cmbo_GroupFltr.Text = "";
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemNoaFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [ItemNoa] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [ItemNoa] Order By [ItemNoa]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable4.Load(sqlDataReader);
			cmbo_ItemNoaFltr.Items.Add("");
			foreach (DataRow row4 in dataTable4.Rows)
			{
				cmbo_ItemNoaFltr.Items.Add(RuntimeHelpers.GetObjectValue(row4["ItemNoa"]));
			}
			cmbo_ItemNoaFltr.Text = "";
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if ((Operators.CompareString(Module1.FAslOrItem, "Fasl", TextCompare: false) != 0) & (DtgItemRefresh == 1))
			{
				Load_dtg_Item();
			}
		}

private void ShowItemRecord()
		{
			int index = 0;
			ref FehrestItemDetailes item = ref Item;
			int lErl = default(int);
			if (dtg_Item.RowCount != 0)
			{
				try
				{
					index = dtg_Item.CurrentRow.Index;
					item.Id = Conversions.ToInteger(dtg_Item.Rows[index].Cells[0].Value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				item.ItemNo = dtg_Item.Rows[index].Cells[3].Value.ToString();
				item.ItemSharh = Conversions.ToString(dtg_Item.Rows[index].Cells[4].Value);
				item.ItemFasl = dtg_Item.Rows[index].Cells[5].Value.ToString();
				item.ItemVahedSharh = Conversions.ToString(dtg_Item.Rows[index].Cells[6].Value);
				item.ItemBahaVahed = Conversions.ToSingle(dtg_Item.Rows[index].Cells[7].Value);
				item.ItemNoa = dtg_Item.Rows[index].Cells[8].Value.ToString();
				item.ItemDarsad = dtg_Item.Rows[index].Cells[9].Value.ToString();
				item.GroupName = dtg_Item.Rows[index].Cells[10].Value.ToString();
				txt_ItemNo.Text = item.ItemNo;
				txt_ItemSharh.Text = item.ItemSharh;
				cmbo_ItemVahedSharh.Text = item.ItemVahedSharh;
				txt_ItemBahavahed.Text = Conversions.ToString(Convert.ToInt64(item.ItemBahaVahed));
				cmbo_ItemFasl.Text = item.ItemFasl;
				cmbo_ItemNoa.Text = item.ItemNoa;
				txt_ItemDarsad.Text = item.ItemDarsad;
				cmbo_Group.Text = item.GroupName;
			}
			lErl = 60;
		}

private void ShowFaslRecord()
		{
			int index = 0;
			ref FehrestFaslDetailes fasl = ref Fasl;
			int lErl = default(int);
			if (dtg_Fosool.RowCount != 0)
			{
				try
				{
					index = dtg_Fosool.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				fasl.Id = Conversions.ToInteger(dtg_Fosool.Rows[index].Cells[0].Value.ToString());
				fasl.FaslCode = dtg_Fosool.Rows[index].Cells[1].Value.ToString();
				fasl.FaslComment = Conversions.ToString(dtg_Fosool.Rows[index].Cells[2].Value);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Fosool.Rows[index].Cells[3].Value)))
				{
					fasl.ZaribCode = "";
				}
				else
				{
					fasl.ZaribCode = Conversions.ToString(dtg_Fosool.Rows[index].Cells[3].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Fosool.Rows[index].Cells[4].Value)))
				{
					txt_ZaribComment.Text = "";
				}
				else
				{
					txt_ZaribComment.Text = Conversions.ToString(dtg_Fosool.Rows[index].Cells[4].Value);
				}
				txt_FaslCode.Text = fasl.FaslCode;
				txt_FaslComment.Text = fasl.FaslComment;
				cmbo_ZaribCode.Text = fasl.ZaribCode;
			}
			lErl = 60;
		}

private void dtg_Item_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 1)
			{
				DataGridViewRow dataGridViewRow = dtg_Item.Rows[e.RowIndex];
				dataGridViewRow.Cells["Chk"].Value = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Chk"].EditedFormattedValue));
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(dataGridViewRow.Cells["Chk"].Value, false, TextCompare: false))))
				{
					dtg_Item.CurrentRow.Selected = true;
					dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.RoyalBlue;
					dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				}
				else
				{
					dtg_Item.CurrentRow.Cells[1].Value = false;
					dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.White;
					dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
				}
			}
			ShowItemRecord();
		}

private void dtg_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

private void dtg_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

private void dtg_Item_KeyDown(object sender, KeyEventArgs e)
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
				txt_ItemNo.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Item_SelectionChanged(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "dtg";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_SaveItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Setpnl_ItemBlue();
					break;
				case DialogResult.No:
					Setpnl_ItemBlue();
					break;
				case DialogResult.Cancel:
					txt_ItemNo.Focus();
					return;
				}
			}
			if (DtgItemRefresh == 1)
			{
				ShowItemRecord();
			}
		}

private void txt_ItemNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemNoFltr.Text;
					ItemNo_Filter = " ([shomar] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ItemNo_Filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				if (DtgItemRefresh == 1)
				{
					Load_dtg_Item();
				}
				ShowItemRecord();
			}
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_Filter.Text, "حذف فیلتر", TextCompare: false) == 0)
			{
				FaslCode_Filter = "";
				FaslComment_Filter = "";
				ZaribCode_Filter = "";
				ItemNo_Filter = "";
				ItemSharh_Filter = "";
				ItemVahedSharh_Filter = "";
				ItemBahaVahed_Filter = "";
				ItemFasl_Filter = "";
				GroupName_Filter = "";
				ItemNoa_Filter = "";
				txt_ItemNoFltr.Text = "";
				txt_ItemSharhFltr.Text = "";
				cmbo_ItemFaslFltr.Text = "";
				cmbo_ItemVahedSharhFltr.Text = "";
				txt_ItemBahavahedFltr.Text = "";
				cmbo_ItemNoaFltr.Text = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
				Load_dtg_Item();
			}
		}

private void cmbo_FehrestItem_TextChanged(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			if (Operators.CompareString(cmbo_FehrestItem.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(cmbo_FehrestItem.Text) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if ((Module1.CurrentFehrestFile == null) | (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemFaslFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Fasl] FROM [dbo]." + Module1.CurrentFehrestFile + " " + Module1.strWhere + " Group by [Fasl] Order By [Fasl]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			dataTable.Load(sqlDataReader);
			cmbo_ItemFaslFltr.Items.Add("");
			foreach (DataRow row in dataTable.Rows)
			{
				cmbo_ItemFaslFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Fasl"]));
			}
			cmbo_ItemFaslFltr.Text = "";
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemVahedSharhFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Vahed] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [Vahed] Order By [Vahed]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable2.Load(sqlDataReader);
			cmbo_ItemVahedSharhFltr.Items.Add("");
			foreach (DataRow row2 in dataTable2.Rows)
			{
				cmbo_ItemVahedSharhFltr.Items.Add(RuntimeHelpers.GetObjectValue(row2["Vahed"]));
			}
			cmbo_ItemVahedSharhFltr.Text = "";
			sqlDataReader.Close();
			cmbo_ItemNoaFltr.Items.Add("بها دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی");
			cmbo_ItemNoaFltr.Items.Add("ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی - ستاره دار");
			cmbo_ItemNoaFltr.Text = "";
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
		}

private void dtg_Fosool_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFaslRecord();
		}

private void dtg_Fosool_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFaslRecord();
		}

private void dtg_Fosool_KeyDown(object sender, KeyEventArgs e)
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
				txt_FaslCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Fosool_SelectionChanged(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "dtg";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات فصل ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Setpnl_FosoolBlue();
					break;
				case DialogResult.No:
					Setpnl_FosoolBlue();
					break;
				case DialogResult.Cancel:
					txt_FaslCode.Focus();
					return;
				}
			}
			if (DtgFosoolRefresh == 1)
			{
				ShowFaslRecord();
			}
		}

private void cmbo_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

private void cmbo_ZaribCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!((Operators.CompareString(cmbo_ZaribCode.Text, "", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ZaribCode.Text, "System.Data.DataRowView", TextCompare: false) == 0)))
			{
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top(1) [Comment] FROM [dbo].[ZarayebMantaghe] Where [ZaribCode] ='" + cmbo_ZaribCode.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					txt_ZaribComment.Text = Conversions.ToString(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(cmbo_ItemFasl.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("شماره فصل را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_FaslCode.Focus();
				}
				else if (!(pnl_Fasl.BackColor == Color.Thistle))
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [FaslCode] FROM [dbo].[Fosool] Where [FaslCode]='" + txt_FaslCode.Text + "' And [FehrestFile]='" + Module1.CurrentFehrestFile + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره فصل " + txt_FaslCode.Text + " موجود است شماره فصل جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FaslCode.Text = "";
							txt_FaslCode.Focus();
							sqlDataReader.Close();
							goto IL_032d;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([FehrestFile],[FaslCode],[FaslComment],[ZaribCode]) VALUES('" + Module1.CurrentFehrestFile + "','" + txt_FaslCode.Text + "','" + txt_FaslComment.Text + "','" + cmbo_ZaribCode.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_FosoolBlue();
					}
					else
					{
						Module1.cmd.CommandText = "UPDATE [dbo].[Fosool] SET [FehrestFile] ='" + Module1.CurrentFehrestFile + "',[FaslCode] = '" + txt_FaslCode.Text + "',[FaslComment] = '" + txt_FaslComment.Text + "',[ZaribCode] = '" + cmbo_ZaribCode.Text + "'WHERE Id = '" + Conversions.ToString(Fasl.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_FosoolBlue();
					}
					text = txt_FaslCode.Text;
					Load_dtg_Fosool();
					int num = dtg_Fosool.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(dtg_Fosool.Rows[i].Cells[1].Value.ToString(), text, TextCompare: false) == 0)
						{
							dtg_Fosool.CurrentCell = dtg_Fosool.Rows[i].Cells[1];
							ShowFaslRecord();
						}
					}
				}
				goto IL_032d;
			}
			IL_032d:
			BtnCommand = "";
		}

private void Setpnl_FosoolBlue()
		{
			pnl_Fasl.BackColor = Color.Thistle;
			foreach (object control in pnl_Fasl.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Fasl.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void Btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Close();
		}

private void txt_FaslCode_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

private void txt_FaslComment_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

private void txt_ZaribComment_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

private void CheckFosoolChange()
		{
			if (Operators.CompareString(ChangeFossolDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Fasl.BackColor = Color.Thistle;
			foreach (object control in pnl_Fasl.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Fasl.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Fasl.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Fasl.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void Btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Fasl.BackColor = Color.LightPink;
			txt_FaslCode.Text = "";
			txt_FaslComment.Text = "";
			cmbo_ZaribCode.Text = "";
			txt_ZaribComment.Text = "";
		}

private void Btn_Copy_Click(object sender, EventArgs e)
		{
			string text = txt_FaslCode.Text;
			string text2 = "";
			BtnCommand = "Copy";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text3 = Interaction.InputBox("  کپی فصل " + Fasl.FaslCode + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text3, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [FaslCode] FROM [dbo].[Fosool] Where [FaslCode]='" + text3 + "' And [FehrestFile] = ' " + Module1.CurrentFehrestFile + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show("شماره فصل  " + text3 + " موجود است شماره فصل جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([FehrestFile],[FaslCode],[FaslComment],[ZaribCode])(SELECT [FehrestFile],'" + text3 + "'[FaslCode],[FaslComment],[ZaribCode] FROM [dbo].[Fosool] Where [FaslCode]='" + txt_FaslCode.Text + "' And [FehrestFile] = '" + Module1.CurrentFehrestFile + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Fosool();
			checked
			{
				int num = dtg_Fosool.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Fosool.Rows[i].Cells[2].Value.ToString(), text3, TextCompare: false) == 0)
					{
						dtg_Fosool.CurrentCell = dtg_Fosool.Rows[i].Cells[1];
						ShowFaslRecord();
						break;
					}
				}
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			string text = txt_FaslCode.Text;
			int index = dtg_Fosool.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Fosool.RowCount - 1 != 0)
				{
					int index2 = dtg_Fosool.CurrentRow.Index;
					if (MessageBox.Show(" فصل شماره " + txt_FaslCode.Text + " حذف شود؟  ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo].[Fosool] Where [FaslCode]='" + text + "' And [FehrestFile] = '" + Module1.CurrentFehrestFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_Fosool();
				if (index != 0)
				{
					dtg_Fosool.CurrentCell = dtg_Fosool.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Fosool.CurrentCell = dtg_Fosool.Rows[index].Cells[1];
				}
				ShowFaslRecord();
			}
		}

private void btn_SaveItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			checked
			{
				if (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("شماره ایتم را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_ItemNo.Focus();
				}
				else
				{
					if (pnl_Item.BackColor == Color.DarkKhaki)
					{
						return;
					}
					switch (cmbo_ItemNoa.Text.Trim())
					{
					case "بها دار":
						Darsadi = Conversions.ToByte("0");
						setarehdar = Conversions.ToByte("0");
						break;
					case "درصدی":
						Darsadi = Conversions.ToByte("1");
						setarehdar = Conversions.ToByte("0");
						break;
					case "ستاره دار":
						Darsadi = Conversions.ToByte("0");
						setarehdar = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						Darsadi = Conversions.ToByte("1");
						setarehdar = Conversions.ToByte("1");
						break;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + "  Where [shomar]='" + txt_ItemNo.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره ایتم " + txt_ItemNo.Text + " موجود است شماره ایتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_ItemNo.Text = "";
							txt_ItemNo.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo]." + Module1.CurrentFehrestFile + " ([shomar],[Sharh],[Fasl],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName]) VALUES('" + txt_ItemNo.Text + "','" + txt_ItemSharh.Text + "','" + cmbo_ItemFasl.Text + "','" + cmbo_ItemVahedSharh.Text + "','" + txt_ItemBahavahed.Text + "','" + Conversions.ToString(Darsadi) + "','" + Conversions.ToString(setarehdar) + "','" + cmbo_ItemNoa.Text + "','" + txt_ItemDarsad.Text + "','" + txt_ItemNo.Text.Substring(1, 3) + "','" + cmbo_Group.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_ItemBlue();
					}
					else
					{
						Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "' And [radif] <> '" + Conversions.ToString(Item.Id) + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره ایتم " + txt_ItemNo.Text + " موجود است شماره ایتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_ItemNo.Text = "";
							txt_ItemNo.Focus();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [shomar] ='" + txt_ItemNo.Text + "',[Sharh] = '" + txt_ItemSharh.Text + "',[Fasl] = '" + cmbo_ItemFasl.Text + "',[Vahed] = '" + cmbo_ItemVahedSharh.Text + "',[baha] = '" + txt_ItemBahavahed.Text + "',[darsad] = '" + Conversions.ToString(Darsadi) + "',[setareh] = '" + Conversions.ToString(setarehdar) + "',[ItemNoa] = '" + cmbo_ItemNoa.Text + "',[ItemDarsad] = '" + txt_ItemDarsad.Text + "',[GroupNo] = '" + txt_ItemNo.Text.Substring(1, 3) + "',[GroupName] = '" + cmbo_Group.Text + "' WHERE [radif] = '" + Conversions.ToString(Item.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_ItemBlue();
					}
					text = txt_ItemNo.Text;
					Load_dtg_Item();
					int num = dtg_Item.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Item.Rows[i].Cells[3].Value, text, TextCompare: false))
						{
							dtg_Item.CurrentCell = dtg_Item.Rows[i].Cells[2];
							ShowItemRecord();
						}
					}
				}
			}
		}

private void Setpnl_ItemBlue()
		{
			pnl_Item.BackColor = Color.DarkKhaki;
			foreach (object control in pnl_Item.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Item.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void cmbo_ItemNoa_TextChanged(object sender, EventArgs e)
		{
			if ((Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
			{
				Label5.Visible = true;
				txt_ItemDarsad.Visible = true;
			}
			else
			{
				Label5.Visible = false;
				txt_ItemDarsad.Visible = false;
			}
		}

private void btn_ExitItem_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

private void CheckItemChange()
		{
			if (Operators.CompareString(ChangeItemDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Item.BackColor = Color.DarkKhaki;
			foreach (object control in pnl_Item.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Item.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void txt_ItemNo_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void txt_ItemSharh_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
			txt_ItemSharh.SelectionStart = checked(txt_ItemSharh.Text.Length + 1);
		}

private void txt_ItemDarsad_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void cmbo_ItemVahedSharh_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void cmbo_ItemFasl_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void txt_ItemBahavahed_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void cmbo_ItemNoa_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

private void btn_CopyItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			string text2 = "";
			BtnCommand = "Copy";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text3 = Interaction.InputBox("  کپی آیتم " + Item.ItemNo + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text3, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "' And radif <> '" + Conversions.ToString(Item.Id) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(" آیتم" + text3 + " موجود است شماره آیتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo]." + Module1.CurrentFehrestFile + " ([shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection])(SELECT '" + text3 + "'[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Item();
			checked
			{
				int num = dtg_Item.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Item.Rows[i].Cells[2].Value.ToString(), text3, TextCompare: false) == 0)
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[i].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

private void txt_FaslComment_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FaslComment.Text.Trim(), Fasl.FaslComment.Trim(), TextCompare: false) != 0)
			{
				txt_FaslComment.ForeColor = Color.Red;
			}
			else
			{
				txt_FaslComment.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

private void txt_FaslCode_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FaslCode.Text.Trim(), Fasl.FaslCode.Trim(), TextCompare: false) != 0)
			{
				txt_FaslCode.ForeColor = Color.Red;
			}
			else
			{
				txt_FaslCode.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

private void cmbo_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ZaribCode.Text.Trim(), Fasl.ZaribCode.Trim(), TextCompare: false) != 0)
			{
				cmbo_ZaribCode.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ZaribCode.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

private void txt_ItemNo_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemNo.Text.Trim(), Item.ItemNo.Trim(), TextCompare: false) != 0)
			{
				txt_ItemNo.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemNo.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

private void txt_ItemSharh_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemSharh.Text.Trim(), Item.ItemSharh.Trim(), TextCompare: false) != 0)
			{
				txt_ItemSharh.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemSharh.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

private void cmbo_ItemVahedSharh_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemVahedSharh.Text.Trim(), Item.ItemVahedSharh.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemVahedSharh.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemVahedSharh.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

private void cmbo_ItemFasl_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemFasl.Text.Trim(), Item.ItemFasl.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemFasl.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemFasl.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

private void txt_ItemBahavahed_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Conversions.ToDouble(txt_ItemBahavahed.Text.Trim()) != (double)Item.ItemBahaVahed)
				{
					txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemBahavahed.ForeColor = Color.Black;
				}
				CheckItemChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void cmbo_ItemNoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbo_ItemNoa.Text.Trim())
			{
			case "بها دار":
				Darsadi = Conversions.ToByte("0");
				setarehdar = Conversions.ToByte("0");
				break;
			case "درصدی":
				Darsadi = Conversions.ToByte("1");
				setarehdar = Conversions.ToByte("0");
				break;
			case "ستاره دار":
				Darsadi = Conversions.ToByte("0");
				setarehdar = Conversions.ToByte("1");
				break;
			case "درصدی - ستاره دار":
				Darsadi = Conversions.ToByte("1");
				setarehdar = Conversions.ToByte("1");
				break;
			}
			if (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), Item.ItemNoa.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemNoa.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemNoa.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

private void txt_ItemDarsad_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemDarsad.Text.Trim(), Item.ItemDarsad.Trim(), TextCompare: false) != 0)
				{
					txt_ItemDarsad.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemDarsad.ForeColor = Color.Black;
				}
				CheckItemChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void btn_InsertItem_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Item.BackColor = Color.LightPink;
			txt_ItemNo.Text = "";
			txt_ItemSharh.Text = "";
			cmbo_ItemVahedSharh.Text = "";
			cmbo_ItemFasl.Text = "1";
			txt_ItemBahavahed.Text = "";
			cmbo_ItemNoa.Text = "بهادار";
			txt_ItemDarsad.Text = "";
		}

private void btn_DeleteItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			int index = dtg_Item.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Item.RowCount - 1 != 0)
				{
					int index2 = dtg_Item.CurrentRow.Index;
					if (MessageBox.Show("آیتم شماره " + txt_ItemNo.Text + " حذف شود؟ ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + text + "' And [radif] = '" + Conversions.ToString(Item.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				int lErl = 20;
				Load_dtg_Item();
				try
				{
					if (index != 0)
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[index - 1].Cells[1];
					}
					else
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[index].Cells[1];
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				ShowItemRecord();
			}
		}

private void tbp_Fosool_Click(object sender, EventArgs e)
		{
		}

private void cmbo_ItemFaslFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemFaslFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemFaslFltr.Text;
				ItemFasl_Filter = " ([Fasl] Like N'%" + text + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

private void cmbo_ItemVahedSharhFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemVahedSharhFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemVahedSharhFltr.Text;
				ItemFasl_Filter = " (REPLACE(REPLACE([Vahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

private void cmbo_GroupFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_GroupFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_GroupFltr.Text;
				GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				GroupName_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemNoaFltr.Text;
				ItemFasl_Filter = " ([ItemNoa] Like N'%" + text + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

private void btn_Search_Click(object sender, EventArgs e)
		{
			string text = cmbo_ItemVahedSharh.Text;
			cmbo_ItemVahedSharh.DroppedDown = false;
			Module1.Load_Cmbo(cmbo_ItemVahedSharh, Module1.CurrentFehrestFile, "Vahed", "");
			if (cmbo_ItemVahedSharh.Items.Count > 0)
			{
				cmbo_ItemVahedSharh.DroppedDown = true;
			}
			cmbo_ItemVahedSharh.Text = text;
			cmbo_ItemVahedSharh.SelectionStart = checked(cmbo_ItemVahedSharh.Text.Length + 1);
		}

private void btn_GroupSearch_Click(object sender, EventArgs e)
		{
			string text = cmbo_Group.Text;
			cmbo_Group.DroppedDown = false;
			Module1.Load_Cmbo(cmbo_Group, Module1.CurrentFehrestFile, "GroupName", "");
			if (cmbo_Group.Items.Count > 0)
			{
				cmbo_Group.DroppedDown = true;
			}
			cmbo_Group.Text = text;
			cmbo_Group.SelectionStart = checked(cmbo_Group.Text.Length + 1);
		}

private void txt_ItemSharhFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemSharhFltr.Text;
					ItemSharh_Filter = " ([Sharh] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ItemSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				if (DtgItemRefresh == 1)
				{
					Load_dtg_Item();
				}
				ShowItemRecord();
			}
		}

private void txt_ItemBahavahedFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemBahavahedFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemBahavahedFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemBahaVahed_Filter = " (cast([baha] as decimal(18,0)) Like '%" + Conversions.ToString(Conversion.Val(array[0])) + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahaVahed_Filter = "([baha] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahaVahed_Filter = "";
					btn_Filter.Text = "فیلتر";
					return;
				}
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemBahaVahed_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

    }
}
