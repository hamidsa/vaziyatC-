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
    public partial class Frm_ItemSelect_New : Form
    {
        // Private fields
        private Button _btn_Cansel;
        private Button _btn_ImportSelect;
        private Button _btn_DelSelect;
        private ComboBox _cmbo_GroupFltr;
        private ComboBox _cmbo_ItemVahedSharhFltr;
        private ComboBox _cmbo_ItemFaslFltr;
        private TextBox _txt_ItemNoFltr;
        private ComboBox _cmbo_ItemNoaFltr;
        private TextBox _txt_ItemBahavahedFltr;
        private TextBox _txt_ItemSharhFltr;
        private Button _btn_Filter;
        private ComboBox _cmbo_FehrestItem;
        private DataGridView _dtg_Item;
        private byte DtgItemRefresh;
        private byte ImportItemsDone;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_ItemSelect_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_ItemSelect_New_KeyDown;
            this.Load += Frm_ItemSelect_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void Frm_ItemSelect_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			Module1.strWhere = " ";
			DtgItemRefresh = 0;
			ImportItemsDone = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [fehrest] FROM [dbo].[Fehrest] Group By [fehrest] Order by [fehrest]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_FehrestItem.DataSource = dataTable;
			cmbo_FehrestItem.DisplayMember = "Fehrest";
			DtgItemRefresh = 1;
			cmbo_FehrestItem.Text = Module1.CurrentFehrestName;
			Module1.CurrentFehrestFile = Module1.FindCodeOrName(Module1.CurrentFehrestName, "[fehrest]", "[filename]", "[fehrest]");
			Module1.Load_Cmbo(cmbo_ItemFaslFltr, Module1.CurrentFehrestFile, "Fasl", "");
			Module1.Load_Cmbo(cmbo_ItemVahedSharhFltr, Module1.CurrentFehrestFile, "Vahed", "");
			Module1.Load_Cmbo(cmbo_ItemNoaFltr, Module1.CurrentFehrestFile, "ItemNoa", "");
			Module1.Load_Cmbo(cmbo_GroupFltr, Module1.CurrentFehrestFile, "GroupName", "");
			Load_dtg_Item();
			sqlDataReader.Close();
		}

private void cmbo_FehrestItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh == 0)
			{
				return;
			}
			DtgItemRefresh = 0;
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
			if (Module1.CurrentFehrestFile == null)
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
			Module1.cmd.CommandText = "SELECT [GroupNo],[GroupName] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [GroupNo],[GroupName] Order By [GroupNo]";
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
			Load_dtg_Item();
		}

public void Load_dtg_Item()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[7];
			cmbo_GroupFltr.Width = 205;
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
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemSharh_Filter + array[2] + ItemVahedSharh_Filter + array[3] + ItemBahaVahed_Filter + array[4] + ItemFasl_Filter + array[5] + ItemNoa_Filter + array[6] + GroupName_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) != 0)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [radif] As 'Id',[Selection] As '*',[radif] As 'ردیف',[shomar] As 'ایتم',[Sharh] As 'شرح ایتم',[Fasl] As 'فصل',[Vahed] As 'واحد',[baha] As 'بها',[ItemNoa] As 'نوع ایتم',[ItemDarsad] As 'درصد نسبت به',[GroupName] As 'گروه' FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Order By [shomar]";
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
						dataTable.Rows[i]["*"] = 0;
					}
					dtg_Item.DataSource = dataTable;
					dtg_Item.Columns[0].Visible = false;
					dtg_Item.Columns[1].Visible = true;
					dtg_Item.Columns[1].Width = 20;
					dtg_Item.Columns[2].ReadOnly = true;
					dtg_Item.Columns[2].Width = 40;
					dtg_Item.Columns[3].ReadOnly = true;
					dtg_Item.Columns[3].Width = 60;
					dtg_Item.Columns[4].ReadOnly = true;
					dtg_Item.Columns[4].Width = 500;
					dtg_Item.Columns[5].ReadOnly = true;
					dtg_Item.Columns[5].Width = 40;
					dtg_Item.Columns[6].ReadOnly = true;
					dtg_Item.Columns[6].Width = 100;
					dtg_Item.Columns[7].ReadOnly = true;
					dtg_Item.Columns[7].Width = 70;
					dtg_Item.Columns[8].ReadOnly = true;
					dtg_Item.Columns[8].Width = 100;
					dtg_Item.Columns[9].ReadOnly = true;
					dtg_Item.Columns[9].Visible = false;
					dtg_Item.Columns[10].ReadOnly = true;
					dtg_Item.Columns[10].Width = 190;
					dtg_Item.Refresh();
					sqlDataReader.Close();
				}
				Module1.MyConn.Close();
			}
		}

private void dtg_Item_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 1)
			{
				ItemSelection();
			}
		}

private void dtg_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ItemSelection();
		}

private void dtg_Item_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				ItemSelection();
			}
		}

private void ItemSelection()
		{
			if (dtg_Item.RowCount == 0)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(dtg_Item.CurrentRow.Cells[1].Value, true, TextCompare: false))
			{
				dtg_Item.CurrentRow.Cells[1].Value = false;
				dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.White;
				dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0' WHERE [shomar]='", dtg_Item.CurrentRow.Cells[3].Value), "'"));
				Module1.cmd.ExecuteNonQuery();
			}
			else
			{
				dtg_Item.CurrentRow.Cells[1].Value = true;
				dtg_Item.CurrentRow.Selected = true;
				dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.Cyan;
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '1' WHERE [shomar]='", dtg_Item.CurrentRow.Cells[3].Value), "'"));
				Module1.cmd.ExecuteNonQuery();
			}
		}

private void btn_Cansel_Click(object sender, EventArgs e)
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn.Close();
			Close();
			MyProject.Forms.Frm_AsnadDetail.Load_dtg_AsnadDetail(MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text);
		}

private void btn_DelSelect_Click(object sender, EventArgs e)
		{
			Load_dtg_Item();
		}

private void btn_ImportSelect_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT [shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa] FROM [Jahdazma1].[dbo]." + Module1.CurrentFehrestFile + " where [Selection]='1'";
			SqlDataReader reader = Module1.cmd.ExecuteReader();
			dataTable.Load(reader);
			foreach (DataRow row in dataTable.Rows)
			{
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [dbo].[Asnad2] ([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) VALUES('0','" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "','", row["shomar"]), "','"), row["Sharh"]), "','0','','','"), row["Fasl"]), "','0','"), row["baha"]), "','"), row["Vahed"]), "','0','"), row["darsad"]), "','"), row["setareh"]), "',(Case When '"), row["darsad"]), "' ='True' THEN '"), row["baha"]), "' Else '0' End),'0','','"), Module1.SanadRec.forpf), "','"), Module1.SanadRec.SalMali), "','"), Environment.MachineName), "','','','','','','','','0','0','"), Module1.SanadRec.Soori), "','"), Module1.SanadRec.Ghaleb), "')"));
				Module1.cmd.ExecuteNonQuery();
			}
			Module1.MyConn.Close();
			btn_Cansel_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				}
				else
				{
					ItemNo_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
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
				}
				else
				{
					ItemSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void cmbo_ItemFaslFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemFaslFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemFaslFltr.Text;
					ItemFasl_Filter = " ([Fasl] Like '%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemFasl_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void cmbo_ItemVahedSharhFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemVahedSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemVahedSharhFltr.Text;
					ItemVahedSharh_Filter = " (REPLACE(REPLACE([Vahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemVahedSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
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
				}
			}
			else
			{
				ItemBahaVahed_Filter = "";
			}
			Load_dtg_Item();
		}

private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemNoaFltr.Text;
					ItemNoa_Filter = " ([ItemNoa] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemNoa_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void cmbo_ItemNoaFltr_TextChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				string text = cmbo_ItemNoaFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					ItemNoa_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				else
				{
					ItemNoa_Filter = " (REPLACE(REPLACE([ItemNoa],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void cmbo_GroupFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_GroupFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_GroupFltr.Text;
					GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					GroupName_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void cmbo_GroupFltr_TextChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				string text = cmbo_GroupFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					GroupName_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				else
				{
					GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				Load_dtg_Item();
			}
		}

private void btn_Filter_Click(object sender, EventArgs e)
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
			Load_dtg_Item();
			txt_ItemNoFltr.Text = "";
			txt_ItemSharhFltr.Text = "";
			cmbo_ItemFaslFltr.Text = "";
			cmbo_ItemVahedSharhFltr.Text = "";
			txt_ItemBahavahedFltr.Text = "";
			cmbo_ItemNoaFltr.Text = "";
			cmbo_GroupFltr.Text = "";
		}

private void cmbo_GroupFltr_LostFocus(object sender, EventArgs e)
		{
			cmbo_GroupFltr.Width = 205;
		}

private void cmbo_GroupFltr_MouseClick(object sender, MouseEventArgs e)
		{
			cmbo_GroupFltr.Width = 310;
		}

    }
}
