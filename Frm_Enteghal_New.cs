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
    public partial class Frm_Enteghal_New : Form
    {
        // Private fields
        private string OnvanMabna;
        private string SalMali_filter;
        private string SanadNo_filter;
        private string NoaSanad_filter;
        private string JobNo_filter;
        private string SanadDate_filter;
        private string Project_filter;
        private string Karfarma_filter;
        private string Baha_filter;
        private string Amaliat_filter;
        private string Comment_filter;
        private string Fehrest_filter;
        private string FehrestCode_filter;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_Enteghal_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Enteghal_New_KeyDown;
            this.Load += Frm_Enteghal_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void Frm_Enteghal_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void Frm_Enteghal_New_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			Module1.SanadRecordRefresh = 0;
			Load_Cmbo1(cmbo_SalMaliFltr, "asnad1", "Salmali", "");
			cmbo_SalMaliFltr.Items.Add(" ");
			Load_Cmbo1(cmbo_FehrestFltr, "fehrest", "fehrest", "");
			cmbo_FehrestFltr.Items.Add(" ");
			Module1.MyConn1.Close();
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn1.Close();
			Module1.BtnCommand = "";
			Module1.BtnProjectList = false;
			Module1.BtnKarfarmaList = false;
			cmbo_NoaSanadFltr.Items.Clear();
			cmbo_NoaSanadFltr.Items.Add("فاکتور");
			cmbo_NoaSanadFltr.Items.Add("پیش فاکتور");
			cmbo_NoaSanadFltr.Items.Add("صوری");
			cmbo_NoaSanadFltr.Items.Add("قالب");
			cmbo_NoaSanadFltr.Items.Add(" ");
			cmbo_NoaSanadFltr.Text = Module1.NoaSanad;
			switch (Module1.NoaSanad)
			{
			case "فاکتور":
				NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
				Module1.forpf = true;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "پیش فاکتور":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
				Module1.forpf = false;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "صوری":
				NoaSanad_filter = " ([Soori] = '1' And [Ghaleb] = '0')";
				Module1.soori = 1;
				Module1.Ghaleb = 0;
				break;
			case "قالب":
				NoaSanad_filter = " ([Soori] = '0' And [Ghaleb] = '1')";
				Module1.Ghaleb = 1;
				Module1.soori = 0;
				break;
			}
			cmbo_SalMaliFltr.SelectedIndex = checked(cmbo_SalMaliFltr.Items.Count - 2);
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "SELECT [EsmRamz], REPLACE(REPLACE([OnvanMabna],'ي',N'ی'),'ك',N'ک') FROM [dbo].[Moshakhasat] ";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[1])) && Operators.CompareString(Module1.ArbToPer(Conversions.ToString(sqlDataReader[1])), "بلی", TextCompare: false) == 0)
				{
					OnvanMabna = Conversions.ToString(sqlDataReader[0]);
				}
			}
			cmbo_FehrestFltr.Text = "";
			sqlDataReader.Close();
			Load_dtg_AsnadList();
		}

public void Load_dtg_AsnadList()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[11];
			Module1.SanadRecordRefresh = 0;
			int lErl = default(int);
			try
			{
				Module1.CurrRow = dtg_AsnadList.CurrentRow.Index;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				ProjectData.ClearProjectError();
			}
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 10);
				if (Operators.CompareString(SalMali_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SanadNo_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(SanadNo_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0 && Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
				{
					array[10] = " And ";
				}
				Module1.strWhere = " WHERE " + SalMali_filter + array[1] + SanadNo_filter + array[2] + NoaSanad_filter + array[3] + JobNo_filter + array[4] + SanadDate_filter + array[5] + Project_filter + array[6] + Karfarma_filter + array[7] + Baha_filter + array[8] + Amaliat_filter + array[9] + Comment_filter + array[10] + Fehrest_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				string text = ((Operators.CompareString(Module1.NoaSanad, "قالب", TextCompare: false) != 0) ? "  order by [sanadnum] desc" : "  order by [sanadnum]");
				Module1.MyConn1.Close();
				lErl = 10;
				if (Module1.MyConn1.State == ConnectionState.Closed)
				{
					Module1.MyConn1.Open();
				}
				Module1.cmd.Connection = Module1.MyConn1;
				Module1.cmd.CommandText = "SELECT DISTINCT [recnum] As 'recnum',[recnum] As 'ردیف', Cast([forpf] As Nvarchar(20)) As 'نوع سند', [Salmali] As 'سال مالی', [sanadnum] As 'شماره سند',[karnum] As 'شماره کار',[sanaddatey] + '/' + [sanaddatem] + '/' + [sanaddated]  As 'تاریخ', [asnad1].[pkod] As 'کد پروژه', [asnad1].[forpf],REPLACE(REPLACE([pname1],'ي',N'ی'),'ك',N'ک') As 'پروژه', [karkod1] As 'کد کارفرما', REPLACE(REPLACE([karname1],'ي',N'ی'),'ك',N'ک') As 'کارفرما',Cast([mablaghk] As Decimal(18,0)) As 'مبلغ',[etproj].[bakhshkod] As 'کد بخش',REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') As 'موضوع سند', REPLACE(REPLACE([Pname2],'ي',N'ی'),'ك',N'ک') As 'توضیحات', [fehrestfile] As 'فایل فهرست بها', OnvanCode As 'کد عنوان',REPLACE(REPLACE([asnad1].[fehrest],'ي',N'ی'),'ك',N'ک') As 'فهرست بها',REPLACE(REPLACE([Nameh],'ي',N'ی'),'ك',N'ک') As 'نامه', [Printed] As 'پرینت', [IjadSystem] As 'ایجاد کننده', [TimeIjad] As 'تاریخ ایجاد', [EslahSystem] As 'اصلاح کننده', [TimeEslah] As 'تاریخ اصلاح', Cast([Soori] As Nvarchar(20)) As 'صوری', Cast([Ghaleb] As Nvarchar(20)) As 'قالب' FROM [dbo].[asnad1] INNER JOIN [etproj] ON [asnad1].[pkod]=[etproj].[pkod] And [asnad1].[fehrestfile]=[etproj].[fehrest]" + Module1.strWhere + text;
				lErl = 1;
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				dataTable.Load(sqlDataReader);
				sqlDataReader.Close();
				Module1.MyConn1.Close();
				foreach (DataColumn column in dataTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["نوع سند"], "1", TextCompare: false))
					{
						dataTable.Rows[i]["نوع سند"] = "فاکتور";
						Module1.NoaSanad = "فاکتور";
					}
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["نوع سند"], "0", TextCompare: false))
					{
						dataTable.Rows[i]["نوع سند"] = "پیش فاکتور";
						Module1.NoaSanad = "پیش فاکتور";
					}
					if (Operators.CompareString(dataTable.Rows[i]["صوری"].ToString(), "1", TextCompare: false) == 0)
					{
						dataTable.Rows[i]["نوع سند"] = "صوری";
						Module1.NoaSanad = "صوری";
					}
					if (Operators.CompareString(dataTable.Rows[i]["قالب"].ToString(), "1", TextCompare: false) == 0)
					{
						dataTable.Rows[i]["نوع سند"] = "قالب";
						Module1.NoaSanad = "قالب";
					}
				}
				dtg_AsnadList.DataSource = null;
				dtg_AsnadList.DataSource = dataTable;
				dtg_AsnadList.Columns[1].DefaultCellStyle.Format = "##,0";
				dtg_AsnadList.Columns[11].DefaultCellStyle.Format = "##,0";
				dtg_AsnadList.Columns[0].Visible = false;
				dtg_AsnadList.Columns[1].Width = 40;
				dtg_AsnadList.Columns[2].Width = 50;
				dtg_AsnadList.Columns[3].Width = 40;
				dtg_AsnadList.Columns[4].Width = 60;
				dtg_AsnadList.Columns[5].Width = 50;
				dtg_AsnadList.Columns[6].Width = 50;
				dtg_AsnadList.Columns[7].Visible = false;
				dtg_AsnadList.Columns[8].Visible = false;
				dtg_AsnadList.Columns[9].Width = 165;
				dtg_AsnadList.Columns[10].Visible = false;
				dtg_AsnadList.Columns[11].Width = 165;
				dtg_AsnadList.Columns[12].Width = 100;
				dtg_AsnadList.Columns[13].Visible = false;
				dtg_AsnadList.Columns[14].Width = 150;
				dtg_AsnadList.Columns[15].Width = 150;
				dtg_AsnadList.Columns[16].Visible = false;
				dtg_AsnadList.Columns[17].Visible = false;
				dtg_AsnadList.Columns[18].Width = 100;
				dtg_AsnadList.Columns[19].Visible = false;
				dtg_AsnadList.Columns[20].Visible = false;
				dtg_AsnadList.Columns[21].Visible = false;
				dtg_AsnadList.Columns[22].Visible = false;
				dtg_AsnadList.Columns[23].Visible = false;
				dtg_AsnadList.Columns[24].Visible = false;
				dtg_AsnadList.Columns[25].Visible = false;
				dtg_AsnadList.Columns[26].Visible = false;
				Module1.dtg_Color(dtg_AsnadList);
				lbl_AsnadNum.Text = Strings.Format(dtg_AsnadList.RowCount, "##,0");
				decimal num3 = default(decimal);
				foreach (DataGridViewRow item in (IEnumerable)dtg_AsnadList.Rows)
				{
					num3 = new decimal(Convert.ToDouble(num3) + Conversion.Val(RuntimeHelpers.GetObjectValue(item.Cells[12].Value)));
				}
				lbl_AsnadSum.Text = Strings.Format(num3, "##,0");
				Module1.SanadRecordRefresh = 1;
				try
				{
					dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, lErl);
					Module1.CurrRow = 0;
					ProjectData.ClearProjectError();
					goto IL_107e;
				}
				goto IL_10bd;
			}
			IL_107e:
			try
			{
				dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
			goto IL_10bd;
			IL_10bd:
			lErl = 20;
		}

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			txt_SanadNoFltr.Text = "";
			cmbo_NoaSanadFltr.Text = Module1.NoaSanad;
			txt_JobNoFltr.Text = "";
			txt_SanadDateFltr.Text = "";
			txt_ProjectFltr.Text = "";
			txt_KarfarmaFltr.Text = "";
			txt_BahaFltr.Text = "";
			txt_AmaliatFltr.Text = "";
			txt_CommentFltr.Text = "";
			cmbo_FehrestFltr.Text = "";
			SanadNo_filter = "";
			NoaSanad_filter = "";
			JobNo_filter = "";
			SanadDate_filter = "";
			Project_filter = "";
			Karfarma_filter = "";
			Baha_filter = "";
			Amaliat_filter = "";
			Comment_filter = "";
			Fehrest_filter = "";
			Frm_Enteghal_New_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

private void cmbo_NoaSanadFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_NoaSanadFltr.Text.Trim(), "", TextCompare: false) != 0)
			{
				switch (cmbo_NoaSanadFltr.Text)
				{
				case "فاکتور":
					NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
					Module1.forpf = true;
					Module1.soori = 0;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "فاکتور";
					break;
				case "پیش فاکتور":
					NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
					Module1.forpf = false;
					Module1.soori = 0;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "پیش فاکتور";
					break;
				case "صوری":
					NoaSanad_filter = " ([Soori] = '1' And [Ghaleb] = '0')";
					Module1.soori = 1;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "صوری";
					break;
				case "قالب":
					NoaSanad_filter = " ([Soori] = '0' And [Ghaleb] = '1')";
					Module1.Ghaleb = 1;
					Module1.soori = 0;
					Module1.NoaSanad = "قالب";
					break;
				}
			}
			else
			{
				NoaSanad_filter = "";
				Module1.NoaSanad = "";
			}
			Load_dtg_AsnadList();
		}

private void cmbo_SalMaliFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_SalMaliFltr.Text, "", TextCompare: false) != 0)
			{
				SalMali_filter = " ([SalMali] Like N'%" + cmbo_SalMaliFltr.Text.Trim() + "%')";
			}
			else
			{
				SalMali_filter = "";
			}
			Load_dtg_AsnadList();
		}

private void txt_SanadNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SanadNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_SanadNoFltr.Text;
					SanadNo_filter = " ([sanadnum] Like N'%" + text + "%')";
				}
				else
				{
					SanadNo_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void txt_JobNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_JobNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_JobNoFltr.Text;
					JobNo_filter = " ([karnum] Like N'%" + text + "%')";
				}
				else
				{
					JobNo_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void txt_SanadDateFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SanadDateFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_SanadDateFltr.Text;
					SanadDate_filter = " (([sanaddatey] + '/' + [sanaddatem] + '/' + [sanaddated]) Like N'%" + text + "%')";
				}
				else
				{
					SanadDate_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void txt_SanadDateFltr_TextChanged(object sender, EventArgs e)
		{
		}

private void txt_ProjectFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectFltr.Text;
					Project_filter = "  (REPLACE(REPLACE([pname1],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Project_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void txt_KarfarmaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_KarfarmaFltr.Text;
					Karfarma_filter = " (REPLACE(REPLACE([karname1],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Karfarma_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void txt_BahaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_BahaFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				array = txt_BahaFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					Baha_filter = " (cast([mablaghk] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					Baha_filter = "([mablaghk] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					Baha_filter = "";
				}
			}
			else
			{
				Baha_filter = "";
			}
			Load_dtg_AsnadList();
		}

private void txt_AmaliatFltr_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_AmaliatFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = txt_AmaliatFltr.Text;
				Amaliat_filter = " (REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
			}
			else
			{
				Amaliat_filter = "";
			}
			Load_dtg_AsnadList();
		}

private void txt_CommentFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_CommentFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_CommentFltr.Text;
					Comment_filter = " (REPLACE(REPLACE([Pname2],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Comment_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

private void cmbo_FehrestFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_FehrestFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_FehrestFltr.Text;
				Fehrest_filter = " (REPLACE(REPLACE([asnad1].[fehrest],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
			}
			else
			{
				Fehrest_filter = "";
			}
			Load_dtg_AsnadList();
		}

private void Load_Cmbo1(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			strCmbo.DataSource = null;
			Module1.MyConn1.Close();
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
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

private void btn_Cansel_Click(object sender, EventArgs e)
        {

        }

private void btn_ImportSelect_Click(object sender, EventArgs e)
        {

        }

    }
}
