using GeoBaha.My;
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
    public partial class Frm_AsnadGhaleb_New : Form
    {
        // Private fields
        private byte frmGhalebRefresh;
        private string GhalebNO_filter;
        private string GhalebName_filter;
        private string GhalebFehrestName_filter;
        private string GhalebFehrestName;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_AsnadGhaleb_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_AsnadGhaleb_New_KeyDown;
            this.Load += Frm_AsnadGhaleb_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

        private void Frm_AsnadGhaleb_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        private void Frm_AsnadGhaleb_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			Module1.GhalebNo = Conversions.ToString(0);
			Module1.Load_Cmbo(cmbo_FehrestNameFltr, "fehrest", "fehrest", "");
			frmGhalebRefresh = 0;
			Load_dtg_AsnadGhaleb();
			frmGhalebRefresh = 1;
		}

private void btn_Select_Click(object sender, EventArgs e)
		{
			string text = "";
			string fehrestFile = "";
			SqlCommand sqlCommand = new SqlCommand();
			string text2 = "";
			base.DialogResult = DialogResult.OK;
			Module1.GhalebNo = Conversions.ToString(dtg_AsnadGhaleb.Rows[dtg_AsnadGhaleb.CurrentRow.Index].Cells[1].Value);
			Module1.GhalebSalMali = Conversions.ToString(dtg_AsnadGhaleb.Rows[dtg_AsnadGhaleb.CurrentRow.Index].Cells[5].Value);
			Module1.Ghalebforpf = Conversions.ToBoolean(dtg_AsnadGhaleb.Rows[dtg_AsnadGhaleb.CurrentRow.Index].Cells[6].Value);
			Module1.GhalebSoori = Conversions.ToBoolean(dtg_AsnadGhaleb.Rows[dtg_AsnadGhaleb.CurrentRow.Index].Cells[7].Value);
			if (Operators.CompareString(MyProject.Forms.Frm_AsnadList.cmbo_NoaSanadFltr.Text, "فاکتور", TextCompare: false) == 0)
			{
				Module1.forpf = true;
			}
			if (Operators.CompareString(MyProject.Forms.Frm_AsnadList.cmbo_NoaSanadFltr.Text, "پیش فاکتور", TextCompare: false) == 0)
			{
				Module1.forpf = false;
			}
			if (Operators.CompareString(MyProject.Forms.Frm_AsnadList.cmbo_NoaSanadFltr.Text, "قالب", TextCompare: false) == 0)
			{
				Module1.Ghaleb = 1;
			}
			else
			{
				Module1.Ghaleb = 0;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			sqlCommand.Connection = Module1.MyConn;
			sqlCommand.CommandText = "SELECT top 1 [radif],'" + MyProject.Forms.Frm_AsnadList.txt_SanadNo.Text + "'[sanadnum],[karnum],[pkod],[sanaddatey],[sanaddatem],[sanaddated],[fehkod],'" + Conversions.ToString(Module1.forpf) + "'[forpf],[mablaghk],[pname1],[karkod1],[karname1],[Karname2],[fehrest],[noeSanad],[Salmali],[zarib],[Nameh],[fehrestfile],[Pname2],[Ronevwsht],[Printed],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[Soori],[OnvanCode],'" + Conversions.ToString(Module1.Ghaleb) + "'[Ghaleb],(Select Top 1 [bakhshkod] From [dbo].[etproj] Where [pkod]=[asnad1].pkod) As bakhshkod  FROM [dbo].[asnad1] WHERE [sanadnum]='" + Module1.GhalebNo + "' And [Ghaleb]='1'";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			Frm_AsnadList frm_AsnadList = MyProject.Forms.Frm_AsnadList;
			while (sqlDataReader.Read())
			{
				frm_AsnadList.cmbo_SalMali.Text = frm_AsnadList.cmbo_SalMali.Text;
				frm_AsnadList.cmbo_SanadNoa.Text = frm_AsnadList.cmbo_NoaSanadFltr.Text;
				frm_AsnadList.txt_SanadDay.Text = Conversions.ToString(sqlDataReader[4]);
				frm_AsnadList.txt_SanadMonth.Text = Conversions.ToString(sqlDataReader[5]);
				frm_AsnadList.txt_SanadYear.Text = Conversions.ToString(sqlDataReader[6]);
				frm_AsnadList.txt_JobNo.Text = Conversions.ToString(sqlDataReader[2]);
				frm_AsnadList.txt_Project.Text = Conversions.ToString(sqlDataReader[10]);
				frm_AsnadList.txt_Karfarma.Text = Conversions.ToString(sqlDataReader[12]);
				frm_AsnadList.cmbo_Amaliat.Text = Conversions.ToString(sqlDataReader[15]);
				text2 = Conversions.ToString(sqlDataReader[14]);
				frm_AsnadList.cmbo_OnvanCode.Text = Conversions.ToString(sqlDataReader[28]);
				frm_AsnadList.txt_Comment.Text = Conversions.ToString(sqlDataReader[20]);
				fehrestFile = Conversions.ToString(sqlDataReader[19]);
				text = Conversions.ToString(sqlDataReader[30]);
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			frm_AsnadList.cmbo_FehrestName.Text = text2;
			Close();
			Module1.FindOstanShahrBakhsh(text);
			frm_AsnadList.lbl_SanadOstan.Text = Module1.StrOstan;
			frm_AsnadList.lbl_SanadShahr.Text = Module1.StrShahr;
			frm_AsnadList.lbl_SanadBakhsh.Text = Module1.StrBakhsh;
			frm_AsnadList.FindZaribMantaghe(text, fehrestFile);
			frm_AsnadList = null;
			Module1.FromAsnadGhaleb = 1;
		}

private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			Module1.GhalebNo = Conversions.ToString(0);
			Close();
			Module1.FromAsnadGhaleb = 0;
		}

public void Load_dtg_AsnadGhaleb()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[5];
			base.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 2);
				if (Operators.CompareString(GhalebNO_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(GhalebName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(GhalebFehrestName_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
				}
				if (Operators.CompareString(GhalebName_filter, "", TextCompare: false) != 0 && Operators.CompareString(GhalebFehrestName_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				Module1.strWhere = " WHERE [Ghaleb] = '1' And " + GhalebNO_filter + array[1] + GhalebName_filter + array[2] + GhalebFehrestName_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE [Ghaleb] = '1' And ", TextCompare: false) == 0)
				{
					Module1.strWhere = " WHERE [Ghaleb] = '1'";
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [recnum] As 'ردیف',[sanadnum] As 'شماره قالب',[pname1]  As 'نوع قالب',[fehrest] As 'فهرست بها',[fehrestfile],[Salmali] ,[forpf],[soori] FROM [dbo].[asnad1] " + Module1.strWhere + " Order by [fehrestfile],[sanadnum] ";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				dataTable.Load(sqlDataReader);
				sqlDataReader.Close();
				Module1.MyConn.Close();
				foreach (DataColumn column in dataTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
				}
				dtg_AsnadGhaleb.DataSource = dataTable;
				dtg_AsnadGhaleb.Columns[0].Width = 50;
				dtg_AsnadGhaleb.Columns[1].Width = 50;
				dtg_AsnadGhaleb.Columns[2].Width = 500;
				dtg_AsnadGhaleb.Columns[3].Width = 150;
				dtg_AsnadGhaleb.Columns[4].Visible = false;
				dtg_AsnadGhaleb.Columns[5].Visible = false;
				dtg_AsnadGhaleb.Columns[6].Visible = false;
				dtg_AsnadGhaleb.Columns[7].Visible = false;
			}
		}

private void cmbo_FehrestNameFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmGhalebRefresh != 0)
			{
				if (Operators.CompareString(cmbo_FehrestNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = cmbo_FehrestNameFltr.Text;
					GhalebFehrestName_filter = " ([fehrest] Like '%" + text + "%' Or [fehrest] ='' )";
				}
				else
				{
					GhalebFehrestName_filter = "";
				}
				Load_dtg_AsnadGhaleb();
			}
		}

private void dtg_AsnadGhaleb_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Select_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void txt_GhalebNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_GhalebNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					GhalebNO_filter = " ([sanadnum] Like '%" + Module1.ArbToPer(txt_GhalebNoFltr.Text) + "%')";
				}
				else
				{
					GhalebNO_filter = "";
				}
				Load_dtg_AsnadGhaleb();
			}
		}

private void txt_GhalebNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_GhalebNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					GhalebName_filter = " (REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(txt_GhalebNameFltr.Text) + "%')";
				}
				else
				{
					GhalebName_filter = "";
				}
				Load_dtg_AsnadGhaleb();
			}
		}

private void dtg_AsnadGhaleb_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Select_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void dtg_AsnadGhaleb_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

    }
}
