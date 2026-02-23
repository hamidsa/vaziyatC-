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
    public partial class Frm_Project_New : Form
    {
        // Private fields
        private DataGridView _dtg_Project;
        private ComboBox _cmbo_ProjectShahrFltr;
        private ComboBox _cmbo_ProjectBakhshFltr;
        private TextBox _txt_ProjectNameFltr;
        private ComboBox _cmbo_ProjectOstanFltr;
        private TextBox _txt_ProjectTelFltr;
        private TextBox _txt_ProjectAddressFltr;
        private TextBox _txt_ProjectCodeFltr;
        private Button _btn_Exit;
        private Button _btn_Delete;
        private Button _btn_copy;
        private Button _btn_Insert;
        private ComboBox _cmbo_ProjectBakhsh;
        private ComboBox _cmbo_ProjectShahr;
        private ComboBox _cmbo_ProjectOstan;
        private Button _Btn_Save;
        private TextBox _txt_ProjectTel;
        private TextBox _txt_ProjectAddress;
        private TextBox _txt_ProjectCode;
        private TextBox _txt_ProjectName;
        private Button _btn_Filter;
        private ComboBox _cmbo_FehrestNameFltr;
        private ComboBox _cmbo_FehrestName;
        private string BtnCommand;
        private byte DtgProjectRefresh;
        private byte frmProjectRefresh;
        private string ChangeDtgOrPnl;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;
        public string ProjectCode_filter;

        public string ProjectAddress_filter;

        public string ProjectTel_filter;

        public string ProjectOstan_filter;

        public string ProjectShahr_filter;

        public string ProjectBakhsh_filter;

        public string ProjectFehrestFile_filter;



        public ProjectDetailes Project;


        public Frm_Project_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Project_New_KeyDown;
            this.Load += Frm_Project_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void dtg_projectsList_SelectionChanged(object sender, EventArgs e)
		{
			if (DtgProjectRefresh == 1)
			{
				ShowProjectRecord();
			}
		}

private void dtg_projectList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowProjectRecord();
		}

private void dtg_projectList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void dtg_projectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void dtg_projectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowProjectRecord();
		}

private void dtg_project_SelectionChanged(object sender, EventArgs e)
		{
            dtg_project_SelectionChanged(sender, e);
        }

private void txt_ProjectNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectNameFltr.Text;
					Module1.ProjectName_filter = " (REPLACE(REPLACE([pname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					Module1.ProjectName_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

private void txt_ProjectCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectCodeFltr.Text;
					ProjectCode_filter = " ([pkod] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectCode_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

private void txt_ProjectAddressFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectAddressFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					ProjectAddress_filter = " (REPLACE(REPLACE([padres],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(txt_ProjectAddressFltr.Text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectAddress_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

private void txt_ProjectTelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectTelFltr.Text, "", TextCompare: false) != 0)
				{
					ProjectTel_filter = " ([ptel] Like N'%" + txt_ProjectTelFltr.Text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectTel_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

private void cmbo_ProjectShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void Frm_Project_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_Project_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			frmProjectRefresh = 0;
			Module1.Load_Cmbo(cmbo_ProjectOstanFltr, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_ProjectOstan, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_ProjectShahrFltr, "ZarayebMantaghe", "Shahr", "");
			Module1.Load_Cmbo(cmbo_ProjectShahr, "ZarayebMantaghe", "Shahr", "");
			Module1.Load_Cmbo(cmbo_ProjectBakhshFltr, "ZarayebMantaghe", "Bakhsh", "");
			Module1.Load_Cmbo(cmbo_ProjectBakhsh, "ZarayebMantaghe", "Bakhsh", "");
			Module1.Load_Cmbo(cmbo_FehrestNameFltr, "fehrest", "fehrest", "");
			Module1.Load_Cmbo(cmbo_FehrestName, "fehrest", "fehrest", "");
			cmbo_FehrestNameFltr.Text = Module1.MabnaFehresrFile;
			frmProjectRefresh = 1;
			if (Module1.FromAsnadList == 1)
			{
				cmbo_FehrestNameFltr.Text = Module1.CurrentFehrestName;
			}
			else
			{
				cmbo_FehrestNameFltr.Text = Module1.MabnaFehresrName;
			}
			foreach (Control control in pnl_Project.Controls)
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
			foreach (Control control in pnl_Project.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
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

public void Load_dtg_Project()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[8];
			DtgProjectRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 7);
				if (Operators.CompareString(ProjectCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Module1.ProjectName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(Module1.ProjectName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0 && Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[7] = " And ";
				}
				Module1.strWhere = " WHERE " + ProjectCode_filter + array[1] + Module1.ProjectName_filter + array[2] + ProjectAddress_filter + array[3] + ProjectTel_filter + array[4] + ProjectOstan_filter + array[5] + ProjectShahr_filter + array[6] + ProjectBakhsh_filter + array[7] + ProjectFehrestFile_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = "";
				}
				if (base.Visible)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [identradif] As 'Id',[identradif] As 'ردیف',[pkod] As 'کد پروژه', [pname] As 'نام پروژه',(SELECT Top 1 [Ostan] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Ostan]) As 'استان',(SELECT Top 1 [Shahr] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Shahr]) As 'شهر',(SELECT Top 1 [Bakhsh] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Bakhsh]) As 'بخش',[bakhshkod] As 'کد بخش',[padres] As 'آدرس پروژه',[ptel] As 'تلفن پروژه',[fehrest] ,(SELECT top 1 [fehrest] FROM [dbo].[fehrest] where filename = [etproj].[fehrest]) As 'فهرست بها'FROM [dbo].[etproj] " + Module1.strWhere + " Order By [pkod],[fehrest] Asc";
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
					dtg_Project.DataSource = dataTable;
					dtg_Project.Columns[0].Width = 75;
					dtg_Project.Columns[0].Visible = false;
					dtg_Project.Columns[1].Width = 60;
					dtg_Project.Columns[2].Width = 60;
					dtg_Project.Columns[3].Width = 260;
					dtg_Project.Columns[4].Width = 100;
					dtg_Project.Columns[5].Width = 100;
					dtg_Project.Columns[6].Width = 100;
					dtg_Project.Columns[7].Visible = false;
					dtg_Project.Columns[8].Width = 200;
					dtg_Project.Columns[9].Width = 100;
					dtg_Project.Columns[10].Visible = false;
					dtg_Project.Columns[11].Width = 140;
					base.Visible = true;
				}
				DtgProjectRefresh = 1;
			}
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_project_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.txt_Project.Focus();
				MyProject.Forms.Frm_AsnadList.txt_Project.Text = txt_ProjectName.Text;
				Module1.StrProjectCode = txt_ProjectCode.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadOstan.Text = cmbo_ProjectOstan.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadShahr.Text = cmbo_ProjectShahr.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadBakhsh.Text = cmbo_ProjectBakhsh.Text;
				MyProject.Forms.Frm_AsnadList.cmbo_FehrestName.Text = cmbo_FehrestName.Text;
				MyProject.Forms.Frm_AsnadList.FindZaribMantaghe(Project.BakhshCode, Project.ProjectFehrestFile);
				Module1.FromAsnadList = 0;
			}
			Close();
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			Btn_Save_Click(sender, e);
		}

public void btn_Insert_Click(object sender, EventArgs e)
		{
			frm_Project_btn_insert();
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_ProjectCode.Text;
			string defaultResponse = "";
			BtnCommand = "Copy";
			if (pnl_Project.BackColor == Color.LightPink)
			{
				dtg_project_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [pkod] FROM [dbo].[etproj] Where [fehrest] ='" + Project.ProjectFehrestFile + "' Order By [pkod] Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				while (sqlDataReader.Read())
				{
					defaultResponse = Conversions.ToString(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1);
				}
				sqlDataReader.Close();
				string text2 = Interaction.InputBox(" کپی پروژه " + Conversions.ToString(Project.ProjectCode) + " تحت عنوان کد پروژه ذیل انجام شود؟ ", " ", defaultResponse);
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
				Module1.cmd.CommandText = "SELECT [pkod] FROM [dbo].[etproj] Where [pkod]='" + text2 + "' And [fehrest] ='" + Project.ProjectFehrestFile + "'";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show("پروژه با کد " + text2 + " موجود است کد پروژه جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				sqlDataReader.Close();
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[etproj]([radif],[pkod],[pname],[padres],[ptel],[bakhshkod],[fehrest],[fehname],[bakhshkod_old])(SELECT [radif],'" + text2 + "' [pkod],[pname],[padres],[ptel],[bakhshkod],[fehrest],[fehname],[bakhshkod_old] FROM [dbo].[etproj] Where [pkod]='" + text + "' And [fehrest] ='" + Project.ProjectFehrestFile + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Project();
				int num = dtg_Project.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Project.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Project.CurrentCell = dtg_Project.Rows[i].Cells[1];
						ShowProjectRecord();
						break;
					}
				}
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_ProjectCode.Text;
			int index = dtg_Project.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Project.RowCount - 1 != 0)
				{
					int index2 = dtg_Project.CurrentRow.Index;
					if (MessageBox.Show("پروژه با کد   " + txt_ProjectCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE pkod = '" + text + "'";
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مرتبط به کد پروژه   " + txt_ProjectCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "DELETE FROM [dbo].[etproj] WHERE pkod = '" + text + "'";
						sqlCommand.ExecuteNonQuery();
					}
				}
				Load_dtg_Project();
				if (index != 0)
				{
					dtg_Project.CurrentCell = dtg_Project.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Project.CurrentCell = dtg_Project.Rows[index].Cells[1];
				}
				ShowProjectRecord();
			}
		}

private void cmbo_ProjectShahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_ProjectShahr_SelectedValueChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
		}

private void cmbo_ProjectOstan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_ProjectOstan_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectOstan.Text.Trim();
				try
				{
					if ((Operators.CompareString(text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectShahr.Text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectBakhsh.Text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						Module1.Load_Cmbo(cmbo_ProjectShahr, "ZarayebMantaghe", "Shahr", "Where Ostan = N'" + text + "'");
						try
						{
							cmbo_ProjectShahr.Text = "";
						}
						catch (ArgumentException ex)
						{
							ProjectData.SetProjectError(ex, lErl);
							ArgumentException ex2 = ex;
							ProjectData.ClearProjectError();
						}
						cmbo_ProjectOstan.ForeColor = Color.Red;
						cmbo_ProjectShahr.ForeColor = Color.Red;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex3)
				{
					ProjectData.SetProjectError(ex3, lErl);
					NullReferenceException ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

private void cmbo_ProjectShahr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectShahr.Text.Trim();
				try
				{
					if ((Operators.CompareString(cmbo_ProjectOstan.Text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectBakhsh.Text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						Module1.Load_Cmbo(cmbo_ProjectBakhsh, "ZarayebMantaghe", "Bakhsh", "Where Ostan = N'" + cmbo_ProjectOstan.Text.Trim() + "' And [Shahr]= N'" + text + "'");
						try
						{
							cmbo_ProjectBakhsh.Text = "";
						}
						catch (ArgumentException ex)
						{
							ProjectData.SetProjectError(ex, lErl);
							ArgumentException ex2 = ex;
							ProjectData.ClearProjectError();
						}
						cmbo_ProjectShahr.ForeColor = Color.Red;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex3)
				{
					ProjectData.SetProjectError(ex3, lErl);
					NullReferenceException ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

private void cmbo_ProjectBakhsh_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_ProjectBakhsh_MouseClick(object sender, MouseEventArgs e)
		{
		}

private void cmbo_ProjectBakhsh_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectBakhsh.Text.Trim();
				try
				{
					if ((Operators.CompareString(cmbo_ProjectOstan.Text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectShahr.Text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

private void CheckProjectChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Project.BackColor = Color.LightSteelBlue;
			foreach (object control in pnl_Project.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Project.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Project.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Project.BackColor = Color.LightPink;
					break;
				}
			}
		}

private void SetPnl_ProjectBlue()
		{
			pnl_Project.BackColor = Color.LightSteelBlue;
			foreach (object control in pnl_Project.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Project.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void txt_ProjectCodeList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ProjectCodeList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectCode.Text, Conversions.ToString(Project.ProjectCode), TextCompare: false) != 0)
				{
					txt_ProjectCode.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectCode.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

private void txt_ProjectList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ProjectList_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				try
				{
					if (Operators.CompareString(txt_ProjectName.Text.Trim(), Project.ProjectName.Trim(), TextCompare: false) != 0)
					{
						txt_ProjectName.ForeColor = Color.Red;
					}
					else
					{
						txt_ProjectName.ForeColor = Color.Black;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ProjectData.ClearProjectError();
				}
				CheckProjectChange();
			}
			lErl = 20;
		}

private void txt_ProjectAddressList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ProjectAddressList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectAddress.Text.Trim(), Project.ProjectAddress.Trim(), TextCompare: false) != 0)
				{
					txt_ProjectAddress.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectAddress.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

private void txt_ProjectTelList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void txt_ProjectTelList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectTel.Text.Trim(), Project.ProjectTel.Trim(), TextCompare: false) != 0)
				{
					txt_ProjectTel.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectTel.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

public object FindBakhshCode(string Ostan, string Shahr, string Bakhsh)
		{
			string result = "";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [BakhshCode] FROM [dbo].[ZarayebMantaghe] Where [Ostan] = N'" + Ostan + "' And [Shahr]= N'" + Shahr + "' And [Bakhsh]= N'" + Bakhsh + "' group by [BakhshCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				result = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			return result;
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_Filter.Text, "حذف فیلتر", TextCompare: false) == 0)
			{
				txt_ProjectCodeFltr.Text = "";
				txt_ProjectNameFltr.Text = "";
				txt_ProjectAddressFltr.Text = "";
				txt_ProjectTelFltr.Text = "";
				cmbo_ProjectOstanFltr.Text = "";
				cmbo_ProjectShahrFltr.Text = "";
				cmbo_ProjectBakhshFltr.Text = "";
				Frm_Project_New_Load(RuntimeHelpers.GetObjectValue(sender), e);
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
		}

private void cmbo_ProjectOstanFltr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectOstanFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [OstanCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Ostan],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectOstan_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectOstan_filter = "";
					break;
				default:
					ProjectOstan_filter = " (SUBSTRING(Cast([bakhshkod] As varchar(10)), 1, 2) Like N'%" + text2 + "%')";
					break;
				}
				Module1.Load_Cmbo(cmbo_ProjectShahrFltr, "[ZarayebMantaghe]", "Shahr", "Where [Ostan] = N'" + text + "'");
				try
				{
					cmbo_ProjectShahrFltr.Text = "";
				}
				catch (ArgumentException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ArgumentException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
			lErl = 20;
		}

private void cmbo_ProjectShahrFltr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectShahrFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [ShahrCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Shahr],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "' And REPLACE(REPLACE([Ostan],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(cmbo_ProjectOstanFltr.Text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectShahr_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectShahr_filter = "";
					break;
				default:
					ProjectShahr_filter = " (SUBSTRING(Cast([bakhshkod] As varchar(10)), 1, 4) Like N'%" + text2 + "%')";
					break;
				}
				Module1.Load_Cmbo(cmbo_ProjectBakhshFltr, "[ZarayebMantaghe]", "Bakhsh", "Where [Shahr] = N'" + text + "' And [Ostan]= N'" + cmbo_ProjectOstanFltr.Text + "'");
				try
				{
					cmbo_ProjectBakhshFltr.Text = "";
				}
				catch (ArgumentException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ArgumentException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
			lErl = 20;
		}

private void cmbo_ProjectBakhshFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectBakhshFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [BakhshCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Bakhsh],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectBakhsh_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectBakhsh_filter = "";
					break;
				default:
					ProjectBakhsh_filter = " ([bakhshkod] Like N'%" + text2 + "%')";
					break;
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
		}

private void dtg_Project_KeyDown(object sender, KeyEventArgs e)
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
				txt_ProjectCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void cmbo_FehrestFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(cmbo_FehrestNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = Module1.FindCodeOrName(cmbo_FehrestNameFltr.Text, "[fehrest]", "[filename]", "[fehrest]");
					ProjectFehrestFile_filter = " ([fehrest] Like '%" + text + "%')";
				}
				else
				{
					ProjectFehrestFile_filter = "";
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

private void cmbo_FehrestName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

private void cmbo_FehrestName_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string inputData = cmbo_FehrestName.Text.Trim();
				try
				{
					if (Operators.CompareString(Module1.FindCodeOrName(inputData, "[fehrest]", "[filename]", "[fehrest]"), Project.ProjectFehrestFile.Trim(), TextCompare: false) != 0)
					{
						cmbo_FehrestName.ForeColor = Color.Red;
					}
					else
					{
						cmbo_FehrestName.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

private object CheckProjectExist()
		{
			object obj = 0;
			if (Operators.CompareString(txt_ProjectName.Text, "", TextCompare: false) == 0)
			{
				DialogResult dialogResult = MessageBox.Show(".نام پروژه را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [pkod] FROM [dbo].[etproj] Where [pkod]='" + txt_ProjectCode.Text + "' And [fehrest]='" + Module1.FindCodeOrName(cmbo_FehrestName.Text, "[fehrest]", "[filename]", "[fehrest]") + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			obj = ((!sqlDataReader.HasRows) ? ((object)0) : ((object)1));
			sqlDataReader.Close();
			return obj;
		}

public void frm_Project_btn_insert()
		{
			BtnCommand = "Insert";
			if (pnl_Project.BackColor == Color.LightPink)
			{
				dtg_project_SelectionChanged(null, EventArgs.Empty);
			}
			pnl_Project.BackColor = Color.LightPink;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [pkod] FROM [dbo].[etproj] order by Cast([pkod] As bigint) Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				txt_ProjectCode.Text = Conversions.ToString(checked(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1));
			}
			sqlDataReader.Close();
			txt_ProjectName.Text = "";
			cmbo_FehrestName.Enabled = true;
			cmbo_ProjectOstan.Text = "";
			cmbo_ProjectShahr.Text = "";
			cmbo_ProjectBakhsh.Text = "";
			txt_ProjectAddress.Text = "";
			txt_ProjectTel.Text = "";
			cmbo_FehrestName.Text = Module1.MabnaFehresrName;
		}

public void FindZaribMantaghe(string BakhshCode, string FehrestFile)
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[3];
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ZaribCode] FROM [dbo].[Fosool] where [FehrestFile] =N'" + FehrestFile + "' Group by zaribcode Order by [ZaribCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			int num = 0;
			checked
			{
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(sqlDataReader[0], 0, TextCompare: false), num < 5)))
					{
						num++;
						array[num] = Conversions.ToString(sqlDataReader[0]);
					}
				}
				sqlDataReader.Close();
				dataTable.Columns.Clear();
				dataTable.Rows.Clear();
				Module1.cmd.CommandText = "SELECT Top 1 [zarib]  As 'Zarib_i' FROM [dbo].[etbakhsh] where ([bkod]='" + BakhshCode + "' and [fehrest] ='" + FehrestFile + "') ";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					while (sqlDataReader.Read())
					{
						Module1.Zarib_I = Conversions.ToSingle(sqlDataReader[0]);
					}
					sqlDataReader.Close();
					if (Module1.Zarib_I != 0f)
					{
						if ((Operators.CompareString(FehrestFile.Trim(), "FEHBAHA1400", TextCompare: false) == 0) | (Operators.CompareString(FehrestFile.Trim(), "FEHBAHA1401", TextCompare: false) == 0))
						{
							lbl_SanadZaribComment1.Text = "ضریب منطقه ای برای فصل 1 و 2 و6 طبق بخش نامه 1403/169890  سازمان مدیریت ";
							lbl_SanadZaribComment2.Text = "ضریب منطقه ای برای فصل 5 طبق بخش نامه 1403/169890 سازمان مدیریت";
						}
						else
						{
							lbl_SanadZaribComment1.Text = "(فصول 1 و 2 و6 طبق بخش نامه 3730 سازمان مديريت)";
							lbl_SanadZaribComment2.Text = "(فصل 5 طبق بخش نامه 3730 سازمان مديريت)";
						}
						goto IL_02e4;
					}
				}
				else
				{
					sqlDataReader.Close();
				}
				Module1.cmd.CommandText = "SELECT zarib_i , comment FROM [dbo].[ZarayebMantaghe] where BakhshCode='" + BakhshCode + "' And (ZaribCode='" + array[1] + "' Or ZaribCode ='" + array[2] + "') Order By ZaribCode";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					num = 0;
					while (sqlDataReader.Read())
					{
						num++;
						if (num == 1)
						{
							Module1.Zarib_I = Conversions.ToSingle(sqlDataReader[0]);
							lbl_SanadZaribComment1.Text = sqlDataReader[1].ToString();
						}
						else
						{
							lbl_SanadZaribComment2.Text = sqlDataReader[1].ToString();
						}
					}
				}
				sqlDataReader.Close();
				Module1.MyConn.Close();
				goto IL_02e4;
			}
			IL_02e4:
			if ((Module1.Zarib_I != 0f) & (Operators.CompareString(BakhshCode, "", TextCompare: false) != 0))
			{
				Module1.Zarib_1 = (float)Math.Round(((double)Module1.Zarib_I + 1.7) / 2.7, 3);
				lbl_SanadZarib1.Text = Strings.FormatCurrency(Module1.Zarib_1, 3, TriState.True, TriState.False);
				Module1.Zarib_2 = (float)Math.Round(((double)Module1.Zarib_I + 1.4) / 2.4, 3);
				lbl_SanadZarib2.Text = Strings.FormatCurrency(Module1.Zarib_2, 3, TriState.True, TriState.False);
			}
			else
			{
				lbl_SanadZarib1.Text = "";
				lbl_SanadZarib2.Text = "";
			}
		}

public void FindOstanShahrBakhsh(string Bakhshcode)
		{
			SqlCommand sqlCommand = new SqlCommand();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			sqlCommand.Connection = Module1.MyConn;
			sqlCommand.CommandText = "Select REPLACE((REPLACE([Ostan],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Shahr],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Bakhsh],'ي',N'ی')),'ك',N'ک') FROM [dbo].[ZarayebMantaghe] where BakhshCode ='" + Bakhshcode + "'";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					Module1.StrOstan = sqlDataReader[0].ToString();
					Module1.StrShahr = sqlDataReader[1].ToString();
					Module1.StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			else
			{
				sqlDataReader.Close();
				sqlCommand.CommandText = "Select REPLACE((REPLACE([etostan].[oname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etshahr].[shname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etbakhsh].[bname],'ي',N'ی')),'ك',N'ک') FROM [dbo].[etbakhsh] INNER JOIN [etostan] ON [etbakhsh].okod =[etostan].okod  INNER JOIN [etshahr] ON [etbakhsh].shkod =[etshahr].shkod  where bkod ='" + Bakhshcode + "' group by [etbakhsh].[okod],[etostan].[oname],[etbakhsh].[shkod],[etshahr].[shname],[etbakhsh].[bkod],[etbakhsh].[bname],[etbakhsh].[zarib]";
				sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					Module1.StrOstan = sqlDataReader[0].ToString();
					Module1.StrShahr = sqlDataReader[1].ToString();
					Module1.StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			sqlDataReader.Close();
		}

private void cmbo_ProjectOstan_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

private void cmbo_ProjectShahr_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

private void cmbo_ProjectBakhsh_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

public void ShowProjectRecord()
		{
			cmbo_FehrestName.Enabled = false;
			int index = 0;
			ref ProjectDetailes project = ref Project;
			int lErl = default(int);
			if (dtg_Project.RowCount != 0)
			{
				try
				{
					index = dtg_Project.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				project.Id = Conversions.ToInteger(dtg_Project.Rows[index].Cells[0].Value);
				project.ProjectCode = Conversions.ToInteger(dtg_Project.Rows[index].Cells[2].Value);
				project.ProjectName = dtg_Project.Rows[index].Cells[3].Value.ToString();
				project.BakhshCode = dtg_Project.Rows[index].Cells[7].Value.ToString();
				if ((Operators.CompareString(dtg_Project.Rows[index].Cells[4].Value.ToString(), "", TextCompare: false) == 0) | (Operators.CompareString(dtg_Project.Rows[index].Cells[5].Value.ToString(), "", TextCompare: false) == 0) | (Operators.CompareString(dtg_Project.Rows[index].Cells[6].Value.ToString(), "", TextCompare: false) == 0))
				{
					FindOstanShahrBakhsh(project.BakhshCode);
					project.ProjectOstan = Module1.StrOstan;
					project.ProjectShahr = Module1.StrShahr;
					project.ProjectBakhsh = Module1.StrBakhsh;
				}
				else
				{
					project.ProjectOstan = dtg_Project.Rows[index].Cells[4].Value.ToString();
					project.ProjectShahr = dtg_Project.Rows[index].Cells[5].Value.ToString();
					project.ProjectBakhsh = dtg_Project.Rows[index].Cells[6].Value.ToString();
				}
				project.ProjectAddress = dtg_Project.Rows[index].Cells[8].Value.ToString();
				project.ProjectTel = dtg_Project.Rows[index].Cells[9].Value.ToString();
				project.ProjectFehrestFile = dtg_Project.Rows[index].Cells[10].Value.ToString();
				txt_ProjectCode.Text = Conversions.ToString(project.ProjectCode);
				txt_ProjectName.Text = project.ProjectName;
				txt_ProjectAddress.Text = project.ProjectAddress;
				txt_ProjectTel.Text = project.ProjectTel;
				cmbo_ProjectOstan.Text = project.ProjectOstan;
				cmbo_ProjectShahr.Text = project.ProjectShahr;
				cmbo_ProjectBakhsh.Text = project.ProjectBakhsh;
				cmbo_FehrestName.Text = Module1.FindCodeOrName(project.ProjectFehrestFile, "[filename]", "[fehrest]", "[fehrest]");
				string bakhshCode = Conversions.ToString(FindBakhshCode(project.ProjectOstan, project.ProjectShahr, project.ProjectBakhsh));
				FindZaribMantaghe(bakhshCode, project.ProjectFehrestFile);
			}
			lErl = 60;
		}

    }
}
