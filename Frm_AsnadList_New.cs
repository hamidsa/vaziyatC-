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
    public partial class Frm_AsnadList_New : Form
    {
        // Private fields
        private byte Nsit;
        private string Btn_AsnadListSit;
        private string SalMaliSearch;
        private string ProjectSearch;
        private string StrFehrestCode;
        private string KarfarmaSearch;
        private string StrKarfarmaCode;
        private string AmaliatSearch;
        private string OnvanCodeSearch;
        private string OnvanMabna;
        private byte DtgAsnadListRefresh;
        private byte SystemRefresh;
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

        public Frm_AsnadList_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_AsnadList_New_KeyDown;
            this.Load += Frm_AsnadList_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void Frm_AsnadList_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_AsnadList_New_Load(object sender, EventArgs e)
		{
			base.KeyPreview = true;
			DtgAsnadListRefresh = 0;
			Module1.SanadRecordRefresh = 0;
			SetPnl_AsnadBlue();
			Module1.Load_Cmbo(cmbo_SalMaliFltr, "asnad1", "Salmali", "");
			cmbo_SalMaliFltr.Items.Add(" ");
			Module1.Load_Cmbo(cmbo_SalMali, "asnad1", "SalMali", "");
			Module1.Load_Cmbo(cmbo_OnvanCode, "Moshakhasat", "EsmRamz", "");
			Module1.Load_Cmbo(cmbo_FehrestName, "fehrest", "fehrest", "");
			Module1.Load_Cmbo(cmbo_FehrestFltr, "fehrest", "fehrest", "");
			Module1.Load_Cmbo(cmbo_Amaliat, "asnad1", "noeSanad", "");
			cmbo_FehrestFltr.Items.Add(" ");
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn.Close();
			Module1.BtnCommand = "";
			Module1.BtnProjectList = false;
			Module1.BtnKarfarmaList = false;
			Btn_AsnadListSit = "";
			cmbo_SanadNoa.Items.Clear();
			cmbo_SanadNoa.Items.Add("فاکتور");
			cmbo_SanadNoa.Items.Add("پیش فاکتور");
			cmbo_SanadNoa.Items.Add("صوری");
			cmbo_SanadNoa.Items.Add("قالب");
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
			checked
			{
				if (Module1.Ghaleb == 1)
				{
					cmbo_SalMaliFltr.SelectedIndex = cmbo_SalMaliFltr.Items.Count - 1;
				}
				else
				{
					cmbo_SalMaliFltr.SelectedIndex = cmbo_SalMaliFltr.Items.Count - 2;
				}
				Module1.ComboProjectOstanLoad();
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [fehrest], REPLACE(REPLACE([jari],'ي',N'ی'),'ك',N'ک') FROM [dbo].[fehrest] ";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[1])) && Operators.CompareString(Module1.ArbToPer(Conversions.ToString(sqlDataReader[1])), "(پایه)", TextCompare: false) == 0)
					{
						Module1.FehrestMabna = Conversions.ToString(sqlDataReader[0]);
					}
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [EsmRamz], REPLACE(REPLACE([OnvanMabna],'ي',N'ی'),'ك',N'ک') FROM [dbo].[Moshakhasat] ";
				sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[1])) && Operators.CompareString(Module1.ArbToPer(Conversions.ToString(sqlDataReader[1])), "بلی", TextCompare: false) == 0)
					{
						OnvanMabna = Conversions.ToString(sqlDataReader[0]);
					}
				}
				cmbo_FehrestName.Enabled = false;
				cmbo_FehrestFltr.Text = "";
				sqlDataReader.Close();
				DtgAsnadListRefresh = 1;
				Load_dtg_AsnadList();
			}
			foreach (Control control in pnl_Asnad.Controls)
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
			foreach (Control control in pnl_Asnad.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

private void ShowSanadRecord()
		{
			int index = 0;
			Module1.DatePikerSit = false;
			cmbo_FehrestName.Enabled = false;
			int lErl = default(int);
			if (dtg_AsnadList.RowCount != 0)
			{
				try
				{
					index = dtg_AsnadList.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Module1.SanadRec.recnum = Conversions.ToInteger(dtg_AsnadList.Rows[index].Cells[0].Value);
				Module1.SanadRec.NoaSanad = dtg_AsnadList.Rows[index].Cells[2].Value.ToString();
				Module1.SanadRec.SalMali = dtg_AsnadList.Rows[index].Cells[3].Value.ToString();
				Module1.SanadRec.sanadnum = Conversions.ToString(dtg_AsnadList.Rows[index].Cells[4].Value);
				Module1.SanadRec.karnum = dtg_AsnadList.Rows[index].Cells[5].Value.ToString();
				string[] array = Strings.Split(dtg_AsnadList.Rows[index].Cells[6].Value.ToString(), "/");
				Module1.SanadRec.sanaddatey = array[0];
				Module1.SanadRec.sanaddatem = array[1];
				Module1.SanadRec.sanaddated = array[2];
				Module1.SanadRec.pkod = Conversions.ToInteger(dtg_AsnadList.Rows[index].Cells[7].Value);
				Module1.SanadRec.forpf = Conversions.ToBoolean(dtg_AsnadList.Rows[index].Cells[8].Value);
				Module1.SanadRec.pname1 = dtg_AsnadList.Rows[index].Cells[9].Value.ToString();
				Module1.SanadRec.karkod1 = Conversions.ToInteger(dtg_AsnadList.Rows[index].Cells[10].Value);
				Module1.SanadRec.karname1 = dtg_AsnadList.Rows[index].Cells[11].Value.ToString();
				if (Operators.CompareString(dtg_AsnadList.Rows[index].Cells[12].Value.ToString(), "", TextCompare: false) != 0)
				{
					Module1.SanadRec.mablaghk = Conversions.ToSingle(dtg_AsnadList.Rows[index].Cells[12].Value);
				}
				else
				{
					Module1.SanadRec.mablaghk = 0f;
				}
				Module1.SanadRec.BakhshCode = dtg_AsnadList.Rows[index].Cells[13].Value.ToString();
				Module1.SanadRec.noeSanad = dtg_AsnadList.Rows[index].Cells[14].Value.ToString();
				Module1.SanadRec.Pname2 = dtg_AsnadList.Rows[index].Cells[15].Value.ToString();
				Module1.SanadRec.fehrestfile = dtg_AsnadList.Rows[index].Cells[16].Value.ToString();
				Module1.SanadRec.OnvanCode = OnvanMabna;
				Module1.SanadRec.Fehrest = dtg_AsnadList.Rows[index].Cells[18].Value.ToString();
				Module1.SanadRec.Nameh = dtg_AsnadList.Rows[index].Cells[19].Value.ToString();
				Module1.SanadRec.Printed = Conversions.ToByte(dtg_AsnadList.Rows[index].Cells[20].Value);
				Module1.SanadRec.IjadSystem = dtg_AsnadList.Rows[index].Cells[21].Value.ToString();
				Module1.SanadRec.TimeIjad = dtg_AsnadList.Rows[index].Cells[22].Value.ToString();
				Module1.SanadRec.EslahSystem = dtg_AsnadList.Rows[index].Cells[23].Value.ToString();
				Module1.SanadRec.TimeEslah = dtg_AsnadList.Rows[index].Cells[24].Value.ToString();
				Module1.SanadRec.karname2 = dtg_AsnadList.Rows[index].Cells[27].Value.ToString();
				Module1.SanadRec.Ronevwsht = dtg_AsnadList.Rows[index].Cells[28].Value.ToString();
				switch (cmbo_SanadNoa.Text)
				{
				case "فاکتور":
					Module1.SanadRec.forpf = true;
					Module1.SanadRec.Soori = 0;
					Module1.SanadRec.Ghaleb = 0;
					break;
				case "پیش فاکتور":
					Module1.forpf = false;
					Module1.SanadRec.Soori = 0;
					Module1.SanadRec.Ghaleb = 0;
					break;
				case "صوری":
					Module1.SanadRec.Soori = 1;
					Module1.SanadRec.Ghaleb = 0;
					break;
				case "قالب":
					Module1.SanadRec.Ghaleb = 1;
					Module1.SanadRec.Soori = 0;
					Module1.GhalebNo = Module1.SanadRec.sanadnum;
					Module1.Ghalebforpf = Module1.SanadRec.forpf;
					Module1.GhalebSalMali = Module1.SanadRec.SalMali;
					break;
				}
				txt_SanadNo.Text = Module1.SanadRec.sanadnum;
				cmbo_SanadNoa.Text = Module1.SanadRec.NoaSanad;
				txt_JobNo.Text = Module1.SanadRec.karnum;
				txt_Karfarma.Text = Module1.SanadRec.karname1;
				cmbo_SalMali.Text = Module1.SanadRec.SalMali;
				txt_Project.Text = Module1.SanadRec.pname1;
				lbl_Baha.Text = Conversions.ToString(Convert.ToInt64(Module1.SanadRec.mablaghk));
				cmbo_Amaliat.Text = Module1.SanadRec.noeSanad;
				txt_Comment.Text = Module1.SanadRec.Pname2;
				txt_SanadYear.Text = Module1.SanadRec.sanaddatey;
				txt_SanadMonth.Text = Module1.SanadRec.sanaddatem;
				txt_SanadDay.Text = Module1.SanadRec.sanaddated;
				DateTimePicker1.Text = "";
				cmbo_FehrestName.Text = Module1.SanadRec.Fehrest;
				cmbo_OnvanCode.Text = Module1.SanadRec.OnvanCode;
				Module1.FindOstanShahrBakhsh(Module1.SanadRec.BakhshCode);
				lbl_SanadOstan.Text = Module1.StrOstan;
				lbl_SanadShahr.Text = Module1.StrShahr;
				lbl_SanadBakhsh.Text = Module1.StrBakhsh;
				lbl_SanadBakhshCode.Text = Module1.SanadRec.BakhshCode;
				FindZaribMantaghe(Module1.SanadRec.BakhshCode, Module1.SanadRec.fehrestfile);
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text = Module1.SanadRec.sanadnum;
				MyProject.Forms.Frm_AsnadDetail.lbl_NoaSanad.Text = Module1.SanadRec.NoaSanad;
				MyProject.Forms.Frm_AsnadDetail.lbl_JobNo.Text = Module1.SanadRec.karnum;
				MyProject.Forms.Frm_AsnadDetail.lbl_Project.Text = Module1.SanadRec.pname1;
				MyProject.Forms.Frm_AsnadDetail.lbl_Karfarma.Text = Module1.SanadRec.karname1;
				MyProject.Forms.Frm_AsnadDetail.lbl_SalMali.Text = Module1.SanadRec.SalMali;
				MyProject.Forms.Frm_AsnadDetail.lbl_Amaliat.Text = Module1.SanadRec.noeSanad;
				MyProject.Forms.Frm_AsnadDetail.lbl_Comment.Text = Module1.SanadRec.Pname2;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadYear.Text = Module1.SanadRec.sanaddatey;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadMonth.Text = Module1.SanadRec.sanaddatem;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadDay.Text = Module1.SanadRec.sanaddated;
				MyProject.Forms.Frm_AsnadDetail.lbl_Fehrest.Text = Module1.SanadRec.Fehrest;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadOstan.Text = Module1.StrOstan;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadShahr.Text = Module1.StrShahr;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadBakhsh.Text = Module1.StrBakhsh;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadBakhshCode.Text = Module1.SanadRec.BakhshCode;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text = lbl_SanadZarib1.Text;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib2.Text = lbl_SanadZarib2.Text;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadZaribComment1.Text = lbl_SanadZaribComment1.Text;
				MyProject.Forms.Frm_AsnadDetail.lbl_SanadZaribComment2.Text = lbl_SanadZaribComment2.Text;
			}
			lErl = 70;
		}

private void Cmbo_Day_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void dtg_Asnad_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			SystemRefresh = 1;
			Module1.BtnCommand = "";
			ShowSanadRecord();
			SystemRefresh = 0;
		}

private void dtg_AsnadList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Module1.SanadNoSelected = Conversions.ToString(dtg_AsnadList.Rows[dtg_AsnadList.CurrentRow.Index].Cells[4].Value);
			MyProject.Forms.Frm_AsnadDetail.ShowDialog();
		}

private void dtg_AsnadList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Module1.SanadNoSelected = Conversions.ToString(dtg_AsnadList.Rows[dtg_AsnadList.CurrentRow.Index].Cells[4].Value);
			MyProject.Forms.Frm_AsnadDetail.ShowDialog();
		}

private void dtg_AsnadList_Click(object sender, EventArgs e)
		{
			ShowSanadRecord();
		}

private void dtg_AsnadList_KeyDown(object sender, KeyEventArgs e)
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
				txt_SanadNo.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_Asnad_SelectionChanged(object sender, EventArgs e)
		{
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			SystemRefresh = 1;
			if ((pnl_Asnad.BackColor == Color.LightPink) & (DtgAsnadListRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات سند ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_AsnadBlue();
					break;
				case DialogResult.No:
					SetPnl_AsnadBlue();
					break;
				}
			}
			ShowSanadRecord();
			SystemRefresh = 0;
		}

private void txt_SanadNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_SanadNoFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void txt_SanadDateFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return || DtgAsnadListRefresh == 0)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_SanadDateFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void cmbo_NoaSanadFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgAsnadListRefresh == 0)
			{
				return;
			}
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

private void Rec_Color()
		{
			switch (cmbo_SanadNoa.Text)
			{
			case "فاکتور":
				txt_SanadNo.BackColor = Color.White;
				cmbo_SanadNoa.BackColor = Color.White;
				txt_JobNo.BackColor = Color.White;
				txt_SanadDay.BackColor = Color.White;
				txt_SanadMonth.BackColor = Color.White;
				txt_SanadYear.BackColor = Color.White;
				txt_Karfarma.BackColor = Color.White;
				cmbo_SalMali.BackColor = Color.White;
				txt_Project.BackColor = Color.White;
				lbl_Baha.BackColor = Color.White;
				cmbo_Amaliat.BackColor = Color.White;
				cmbo_OnvanCode.BackColor = Color.White;
				lbl_SanadOstan.BackColor = Color.White;
				lbl_SanadShahr.BackColor = Color.White;
				lbl_SanadBakhsh.BackColor = Color.White;
				lbl_SanadZarib1.BackColor = Color.White;
				lbl_SanadZarib2.BackColor = Color.White;
				lbl_SanadZaribComment1.BackColor = Color.White;
				lbl_SanadZaribComment2.BackColor = Color.White;
				cmbo_FehrestName.BackColor = Color.White;
				txt_Comment.BackColor = Color.White;
				break;
			case "پیش فاکتور":
				txt_SanadNo.BackColor = Color.LightBlue;
				cmbo_SanadNoa.BackColor = Color.LightBlue;
				txt_JobNo.BackColor = Color.LightBlue;
				txt_SanadDay.BackColor = Color.LightBlue;
				txt_SanadMonth.BackColor = Color.LightBlue;
				txt_SanadYear.BackColor = Color.LightBlue;
				txt_Karfarma.BackColor = Color.LightBlue;
				cmbo_SalMali.BackColor = Color.LightBlue;
				txt_Project.BackColor = Color.LightBlue;
				lbl_Baha.BackColor = Color.LightBlue;
				cmbo_Amaliat.BackColor = Color.LightBlue;
				cmbo_OnvanCode.BackColor = Color.LightBlue;
				lbl_SanadOstan.BackColor = Color.LightBlue;
				lbl_SanadShahr.BackColor = Color.LightBlue;
				lbl_SanadBakhsh.BackColor = Color.LightBlue;
				lbl_SanadZarib1.BackColor = Color.LightBlue;
				lbl_SanadZarib2.BackColor = Color.LightBlue;
				lbl_SanadZaribComment1.BackColor = Color.LightBlue;
				lbl_SanadZaribComment2.BackColor = Color.LightBlue;
				cmbo_FehrestName.BackColor = Color.LightBlue;
				txt_Comment.BackColor = Color.LightBlue;
				break;
			case "صوری":
				txt_SanadNo.BackColor = Color.LightGray;
				cmbo_SanadNoa.BackColor = Color.LightGray;
				txt_JobNo.BackColor = Color.LightGray;
				txt_SanadDay.BackColor = Color.LightGray;
				txt_SanadMonth.BackColor = Color.LightGray;
				txt_SanadYear.BackColor = Color.LightGray;
				txt_Karfarma.BackColor = Color.LightGray;
				cmbo_SalMali.BackColor = Color.LightGray;
				txt_Project.BackColor = Color.LightGray;
				lbl_Baha.BackColor = Color.LightGray;
				cmbo_Amaliat.BackColor = Color.LightGray;
				cmbo_OnvanCode.BackColor = Color.LightGray;
				lbl_SanadOstan.BackColor = Color.LightGray;
				lbl_SanadShahr.BackColor = Color.LightGray;
				lbl_SanadBakhsh.BackColor = Color.LightGray;
				lbl_SanadZarib1.BackColor = Color.LightGray;
				lbl_SanadZarib2.BackColor = Color.LightGray;
				lbl_SanadZaribComment1.BackColor = Color.LightGray;
				lbl_SanadZaribComment2.BackColor = Color.LightGray;
				cmbo_FehrestName.BackColor = Color.LightGray;
				txt_Comment.BackColor = Color.LightGray;
				break;
			case "قالب":
				txt_SanadNo.BackColor = Color.LightGreen;
				cmbo_SanadNoa.BackColor = Color.LightGreen;
				txt_JobNo.BackColor = Color.LightGreen;
				txt_SanadDay.BackColor = Color.LightGreen;
				txt_SanadMonth.BackColor = Color.LightGreen;
				txt_SanadYear.BackColor = Color.LightGreen;
				txt_Karfarma.BackColor = Color.LightGreen;
				cmbo_SalMali.BackColor = Color.LightGreen;
				txt_Project.BackColor = Color.LightGreen;
				lbl_Baha.BackColor = Color.LightGreen;
				cmbo_Amaliat.BackColor = Color.LightGreen;
				cmbo_OnvanCode.BackColor = Color.LightGreen;
				lbl_SanadOstan.BackColor = Color.LightGreen;
				lbl_SanadShahr.BackColor = Color.LightGreen;
				lbl_SanadBakhsh.BackColor = Color.LightGreen;
				lbl_SanadZarib1.BackColor = Color.LightGreen;
				lbl_SanadZarib2.BackColor = Color.LightGreen;
				lbl_SanadZaribComment1.BackColor = Color.LightGreen;
				lbl_SanadZaribComment2.BackColor = Color.LightGreen;
				cmbo_FehrestName.BackColor = Color.LightGreen;
				txt_Comment.BackColor = Color.LightGreen;
				break;
			}
		}

private void txt_ProjectList_TextChanged(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_Project.Load_dtg_Project();
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
				Module1.cmd.CommandText = "SELECT Top 1 CAST([zarib] as Float) As 'Zarib_i' FROM [dbo].[etbakhsh] where ([bkod]='" + BakhshCode + "' and [fehrest] ='" + Module1.SanadRec.fehrestfile + "') ";
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
						switch (Module1.SanadRec.fehrestfile.Trim())
						{
						case "FEHBAHA1384":
						case "FEHBAHA1387":
						case "FEHBAHA1391":
						case "FEHBAHA1393":
						case "FEHBAHA1397":
						case "FEHBAHA1399":
							lbl_SanadZaribComment1.Text = "(فصول 1 و 2 و6 طبق بخش نامه 3730 سازمان مديريت)";
							lbl_SanadZaribComment2.Text = "(فصل 5 طبق بخش نامه 3730 سازمان مديريت)";
							break;
						default:
							lbl_SanadZaribComment1.Text = "ضریب منطقه ای برای فصل 1 و 2 و6 طبق بخش نامه 1403/169890  سازمان مدیریت ";
							lbl_SanadZaribComment2.Text = "ضریب منطقه ای برای فصل 5 طبق بخش نامه 1403/16980 سازمان مدیریت";
							break;
						}
						goto IL_032e;
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
				goto IL_032e;
			}
			IL_032e:
			Module1.Zarib_1 = (float)Math.Round(((double)Module1.Zarib_I + 1.7) / 2.7, 3);
			lbl_SanadZarib1.Text = Strings.FormatCurrency(Module1.Zarib_1, 3, TriState.True, TriState.False);
			Module1.Zarib_2 = (float)Math.Round(((double)Module1.Zarib_I + 1.4) / 2.4, 3);
			lbl_SanadZarib2.Text = Strings.FormatCurrency(Module1.Zarib_2, 3, TriState.True, TriState.False);
		}

private void Btn_Save_Click_1(object sender, EventArgs e)
		{
		}

private void cmbo_FehrestFltr_GotFocus(object sender, EventArgs e)
		{
		}

private void cmbo_FehrestFltr_Leave(object sender, EventArgs e)
		{
		}

private void cmbo_FehrestFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgAsnadListRefresh != 0)
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
		}

public void Load_dtg_AsnadList()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[11];
			Module1.SanadRecordRefresh = 0;
			int lErl = default(int);
			checked
			{
				if (DtgAsnadListRefresh != 0)
				{
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
					string text = SalMali_filter + array[1] + SanadNo_filter + array[2] + NoaSanad_filter + array[3] + JobNo_filter + array[4] + SanadDate_filter + array[5] + Project_filter + array[6] + Karfarma_filter + array[7] + Baha_filter + array[8] + Amaliat_filter + array[9] + Comment_filter + array[10] + Fehrest_filter;
					string text2 = " [sanadnum] Not in (SELECT [ShomaresanadSoratvazeyat] FROM [Dabirkhane].[dbo].[SanadSoratVazeyat])";
					if (Operators.CompareString(text, "", TextCompare: false) == 0)
					{
						Module1.strWhere = " ";
					}
					else
					{
						Module1.strWhere = " WHERE " + text;
					}
					if (chk_SabtNashode.Checked)
					{
						if (Operators.CompareString(Module1.strWhere, "", TextCompare: false) == 0)
						{
							Module1.strWhere = " WHERE " + text2;
						}
						else
						{
							Module1.strWhere = Module1.strWhere + " And " + text2;
						}
					}
					string text3 = ((Operators.CompareString(Module1.NoaSanad, "قالب", TextCompare: false) != 0) ? "  order by [sanadnum] desc" : "  order by [sanadnum]");
					Module1.MyConn.Close();
					lErl = 10;
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT DISTINCT [recnum] As 'recnum',[recnum] As 'ردیف', Cast([forpf] As Nvarchar(20)) As 'نوع سند', [Salmali] As 'سال مالی', [sanadnum] As 'شماره سند',[karnum] As 'شماره کار',[sanaddatey] + '/' + [sanaddatem] + '/' + [sanaddated]  As 'تاریخ', [asnad1].[pkod] As 'کد پروژه', [asnad1].[forpf],REPLACE(REPLACE([pname1],'ي',N'ی'),'ك',N'ک') As 'پروژه', [karkod1] As 'کد کارفرما', REPLACE(REPLACE([karname1],'ي',N'ی'),'ك',N'ک') As 'کارفرما',Cast([mablaghk] As Decimal(18,0)) As 'مبلغ',[etproj].[bakhshkod] As 'کد بخش',REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') As 'موضوع سند', REPLACE(REPLACE([Pname2],'ي',N'ی'),'ك',N'ک') As 'توضیحات', [fehrestfile] As 'فایل فهرست بها', OnvanCode As 'کد عنوان',REPLACE(REPLACE([asnad1].[fehrest],'ي',N'ی'),'ك',N'ک') As 'فهرست بها',REPLACE(REPLACE([Nameh],'ي',N'ی'),'ك',N'ک') As 'نامه', [Printed] As 'پرینت', [IjadSystem] As 'ایجاد کننده', [TimeIjad] As 'تاریخ ایجاد', [EslahSystem] As 'اصلاح کننده', [TimeEslah] As 'تاریخ اصلاح', Cast([Soori] As Nvarchar(20)) As 'صوری', Cast([Ghaleb] As Nvarchar(20)) As 'قالب' , [Karname2], [Ronevwsht] FROM [dbo].[asnad1] INNER JOIN [etproj] ON [asnad1].[pkod]=[etproj].[pkod] And [asnad1].[fehrestfile]=[etproj].[fehrest]" + Module1.strWhere + text3;
					lErl = 1;
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					dataTable.Load(sqlDataReader);
					sqlDataReader.Close();
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
					dtg_AsnadList.Columns[12].DefaultCellStyle.Format = "N0";
					dtg_AsnadList.Columns[0].Visible = false;
					dtg_AsnadList.Columns[1].Width = 35;
					dtg_AsnadList.Columns[2].Width = 60;
					dtg_AsnadList.Columns[3].Width = 45;
					dtg_AsnadList.Columns[4].Width = 55;
					dtg_AsnadList.Columns[5].Width = 55;
					dtg_AsnadList.Columns[6].Width = 55;
					dtg_AsnadList.Columns[7].Visible = false;
					dtg_AsnadList.Columns[8].Visible = false;
					dtg_AsnadList.Columns[9].Width = 150;
					dtg_AsnadList.Columns[10].Visible = false;
					dtg_AsnadList.Columns[11].Width = 150;
					dtg_AsnadList.Columns[12].Width = 90;
					dtg_AsnadList.Columns[13].Visible = false;
					dtg_AsnadList.Columns[14].Width = 150;
					dtg_AsnadList.Columns[15].Width = 150;
					dtg_AsnadList.Columns[16].Visible = false;
					dtg_AsnadList.Columns[17].Visible = false;
					dtg_AsnadList.Columns[18].Width = 120;
					dtg_AsnadList.Columns[19].Visible = false;
					dtg_AsnadList.Columns[20].Visible = false;
					dtg_AsnadList.Columns[21].Visible = false;
					dtg_AsnadList.Columns[21].Width = 100;
					dtg_AsnadList.Columns[22].Visible = false;
					dtg_AsnadList.Columns[23].Visible = false;
					dtg_AsnadList.Columns[24].Visible = false;
					dtg_AsnadList.Columns[25].Visible = false;
					dtg_AsnadList.Columns[26].Visible = false;
					dtg_AsnadList.Columns[27].Visible = false;
					dtg_AsnadList.Columns[28].Visible = false;
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
						ShowSanadRecord();
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, lErl);
						Module1.CurrRow = 0;
						ProjectData.ClearProjectError();
						goto IL_1120;
					}
				}
				goto IL_1166;
			}
			IL_1166:
			lErl = 20;
			return;
			IL_1120:
			try
			{
				dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
				ShowSanadRecord();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
			goto IL_1166;
		}

public void EraseProjectRecordShow()
		{
			MyProject.Forms.Frm_Project.txt_ProjectCode.Text = "";
			MyProject.Forms.Frm_Project.txt_ProjectName.Text = "";
			MyProject.Forms.Frm_Project.txt_ProjectAddress.Text = "";
			MyProject.Forms.Frm_Project.txt_ProjectTel.Text = "";
			MyProject.Forms.Frm_Project.cmbo_ProjectOstan.Text = "";
			MyProject.Forms.Frm_Project.cmbo_ProjectShahr.Text = "";
			MyProject.Forms.Frm_Project.cmbo_ProjectBakhsh.Text = "";
		}

private void btn_Insert_Click(object sender, EventArgs e)
		{
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Module1.BtnCommand = "Insert";
			txt_SanadNo.ForeColor = Color.Red;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [sanadnum] FROM [dbo].[asnad1] Where [Salmali]= '" + cmbo_SalMali.Text + "' And " + NoaSanad_filter + " Order By [sanadnum] Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				txt_SanadNo.Text = Conversions.ToString(checked(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1));
			}
			sqlDataReader.Close();
			txt_JobNo.Text = "";
			DateTimePicker1.Value = DateTime.Now;
			txt_Project.Text = "";
			txt_Karfarma.Text = "";
			lbl_Baha.Text = "";
			cmbo_Amaliat.Text = "";
			cmbo_OnvanCode.Text = "jahdazma";
			cmbo_FehrestName.Text = "";
			cmbo_FehrestName.Enabled = true;
			lbl_SanadOstan.Text = "";
			lbl_SanadShahr.Text = "";
			lbl_SanadBakhsh.Text = "";
			lbl_SanadZarib1.Text = "";
			lbl_SanadZarib2.Text = "";
			lbl_SanadZaribComment1.Text = "";
			lbl_SanadZaribComment2.Text = "";
			txt_Comment.Text = "";
			Module1.SanadRec.recnum = 0;
			MyProject.Forms.Frm_AsnadGhaleb.ShowDialog();
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			chk_SabtNashode.Checked = false;
			Close();
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = "";
			Module1.BtnCommand = "Copy";
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			MyProject.Forms.frm_CopySanad.ShowDialog();
			Load_dtg_AsnadList();
			checked
			{
				int lErl = default(int);
				try
				{
					int num = dtg_AsnadList.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(dtg_AsnadList.Rows[i].Cells[4].Value.ToString(), MyProject.Forms.frm_CopySanad.txt_SanadNo.Text, TextCompare: false) == 0)
						{
							dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[i].Cells[1];
							ShowSanadRecord();
							break;
						}
					}
				}
				catch (ArgumentOutOfRangeException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ArgumentOutOfRangeException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
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
			if (Operators.CompareString(Btn_AsnadListSit, "Modify", TextCompare: false) == 0)
			{
				MessageBox.Show(" ابتدا شماره سند انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				Btn_AsnadListSit = "Delete";
				if (dtg_AsnadList.RowCount != 0)
				{
					int index = dtg_AsnadList.CurrentRow.Index;
					if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("سند شماره ", dtg_AsnadList[4, index].Value), " حذف شود؟")), "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "DELETE FROM [dbo].[asnad1] WHERE [recnum] ='" + Conversions.ToString(Module1.SanadRec.recnum) + "'";
						sqlCommand.ExecuteNonQuery();
						sqlCommand.CommandText = "DELETE FROM [dbo].[asnad2] WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						sqlCommand.ExecuteNonQuery();
						sqlCommand.CommandText = "DELETE FROM [dbo].[asnad4] WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						sqlCommand.ExecuteNonQuery();
					}
				}
			}
			lErl = 20;
			Load_dtg_AsnadList();
			try
			{
				if (Module1.CurrRow != 0)
				{
					dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[checked(Module1.CurrRow - 1)].Cells[1];
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, lErl);
				ProjectData.ClearProjectError();
			}
			ShowSanadRecord();
		}

private void txt_SanadNo_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_SanadNo_Leave(object sender, EventArgs e)
		{
		}

private void txt_SanadNo_TextChanged(object sender, EventArgs e)
		{
		}

private void txt_JobNo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void txt_JobNo_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_JobNo_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (SystemRefresh == 1))
			{
				return;
			}
			try
			{
				if (Operators.CompareString(txt_JobNo.Text.Trim(), Module1.SanadRec.karnum.Trim(), TextCompare: false) != 0)
				{
					txt_JobNo.ForeColor = Color.Red;
				}
				else
				{
					txt_JobNo.ForeColor = Color.Black;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			CheckSanadRecChange();
		}

private void cmbo_SanadNoa_GotFocus(object sender, EventArgs e)
		{
		}

private void cmbo_NoaSanad_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void cmbo_SanadNoa_Leave(object sender, EventArgs e)
		{
		}

private void cmbo_NoaSanad_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbo_SanadNoa.Text)
			{
			case "فاکتور":
				Module1.forpf = true;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "پیش فاکتور":
				Module1.forpf = false;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "صوری":
				Module1.soori = 1;
				Module1.Ghaleb = 0;
				break;
			case "قالب":
				Module1.Ghaleb = 1;
				Module1.soori = 0;
				break;
			}
			Module1.NoaSanad = cmbo_SanadNoa.Text;
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			try
			{
				if (Operators.CompareString(cmbo_SanadNoa.Text.Trim(), Module1.SanadRec.NoaSanad.Trim(), TextCompare: false) != 0)
				{
					cmbo_SanadNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SanadNoa.ForeColor = Color.Black;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			CheckSanadRecChange();
		}

private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			if (0 - (Module1.DatePikerSit ? 1 : 0) == 1)
			{
				string[] array = Strings.Split(DateTimePicker1.Text.ToString(), "/");
				txt_SanadYear.Text = array[2];
				txt_SanadMonth.Text = array[1];
				txt_SanadDay.Text = array[0];
			}
			else
			{
				Module1.DatePikerSit = true;
			}
			if (DtgAsnadListRefresh != 0)
			{
				if ((Operators.CompareString(txt_SanadYear.Text.Trim(), Module1.SanadRec.sanaddatey.Trim(), TextCompare: false) != 0) | (Operators.CompareString(txt_SanadMonth.Text.Trim(), Module1.SanadRec.sanaddatem.Trim(), TextCompare: false) != 0) | (Operators.CompareString(txt_SanadDay.Text.Trim(), Module1.SanadRec.sanaddated.Trim(), TextCompare: false) != 0))
				{
					txt_SanadYear.ForeColor = Color.Red;
					txt_SanadMonth.ForeColor = Color.Red;
					txt_SanadDay.ForeColor = Color.Red;
				}
				else
				{
					pnl_Asnad.BackColor = Color.LightPink;
					txt_SanadYear.ForeColor = Color.Black;
					txt_SanadMonth.ForeColor = Color.Black;
					txt_SanadDay.ForeColor = Color.Black;
				}
				CheckSanadRecChange();
			}
		}

public byte CheckProjectExist()
		{
			byte result = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [pkod],[bakhshkod] FROM [dbo].[etproj] Where REPLACE(REPLACE([pname],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(txt_Project.Text) + "' And [fehrest]='" + Module1.CurrentFehrestFile + "' Group By [pkod],[bakhshkod]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					Module1.StrProjectCode = Conversions.ToString(sqlDataReader[0]);
				}
				result = 1;
			}
			else
			{
				switch (MessageBox.Show(".لطفااطلاعات پروژه را کامل کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					Module1.FromAsnadList = 1;
					MyProject.Forms.Frm_Project.txt_ProjectName.Text = txt_Project.Text;
					MyProject.Forms.Frm_Project.txt_ProjectNameFltr.Text = txt_Project.Text;
					Module1.ProjectName_filter = " (REPLACE(REPLACE([pname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(txt_Project.Text) + "%')";
					MyProject.Forms.Frm_Project.ShowDialog();
					MyProject.Forms.Frm_Project.frm_Project_btn_insert();
					MyProject.Forms.Frm_Project.pnl_Project.BackColor = Color.LightPink;
					result = 1;
					break;
				}
			}
			sqlDataReader.Close();
			return result;
		}

public byte CheckKarfarmaExist()
		{
			byte result = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(txt_Karfarma.Text) + "' Group By [kknum]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					StrKarfarmaCode = Conversions.ToString(sqlDataReader[0]);
				}
				result = 1;
			}
			else
			{
				switch (MessageBox.Show(". لطفااطلاعات کارفرما را کامل کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					Module1.FromAsnadList = 1;
					MyProject.Forms.Frm_Karfarma.txt_KarfarmaName.Text = txt_Karfarma.Text;
					MyProject.Forms.Frm_Karfarma.txt_KarfarmaNameFltr.Text = txt_Karfarma.Text;
					MyProject.Forms.Frm_Karfarma.KarfarmaName_filter = " (REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(txt_Karfarma.Text) + "%')";
					MyProject.Forms.Frm_Karfarma.ShowDialog();
					MyProject.Forms.Frm_Karfarma.frm_Karfarma_btn_insert();
					MyProject.Forms.Frm_Karfarma.pnl_Karfarma.BackColor = Color.LightPink;
					result = 1;
					break;
				}
			}
			sqlDataReader.Close();
			KarfarmaSearch = "";
			return result;
		}

public string SystemNameToUsername(string SystemName)
		{
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [UserName] FROM [dbo].[Systems1] Where [SystemName] = '" + SystemName + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			string result = "";
			while (sqlDataReader.Read())
			{
				result = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			return result;
		}

private void txt_Project_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void txt_Project_Leave(object sender, EventArgs e)
		{
			if (CheckProjectExist() != 0)
			{
			}
		}

private void txt_Project_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (SystemRefresh == 1))
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_Project.Text.Trim(), Module1.SanadRec.pname1.Trim(), TextCompare: false) != 0)
				{
					txt_Project.ForeColor = Color.Red;
				}
				else
				{
					txt_Project.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				txt_Project.ForeColor = Color.Red;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void txt_Comment_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void txt_Comment_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_Comment_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (SystemRefresh == 1))
			{
				return;
			}
			try
			{
				if (Operators.CompareString(txt_Comment.Text.Trim(), Module1.SanadRec.Pname2.Trim(), TextCompare: false) != 0)
				{
					txt_Comment.ForeColor = Color.Red;
				}
				else
				{
					txt_Comment.ForeColor = Color.Black;
				}
				CheckSanadRecChange();
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_SanadNo.Text, "", TextCompare: false) == 0)
			{
				DialogResult dialogResult = MessageBox.Show(".شماره سند را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_SanadNo.Focus();
				}
			}
			int lErl = default(int);
			if (!(pnl_Asnad.BackColor == Color.LightSteelBlue))
			{
				try
				{
					Module1.CurrRow = dtg_AsnadList.CurrentRow.Index;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ProjectData.ClearProjectError();
				}
				if (CheckProjectExist() == 0)
				{
					txt_Project.Focus();
					return;
				}
				if (CheckKarfarmaExist() == 0)
				{
					txt_Karfarma.Focus();
					return;
				}
				if (cmbo_SalMali.Text.Trim().Length != 4)
				{
					DialogResult dialogResult2 = MessageBox.Show(".سال مالی باید بصورت عدد چهاررقمی باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					if (dialogResult2 == DialogResult.OK)
					{
						cmbo_SalMali.Focus();
					}
				}
				if (Operators.CompareString(cmbo_FehrestName.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show(". لطفااطلاعات فهرست بها را کامل کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					switch (cmbo_SanadNoa.Text)
					{
					case "فاکتور":
						Module1.forpf = true;
						Module1.soori = 0;
						Module1.Ghaleb = 0;
						break;
					case "پیش فاکتور":
						Module1.forpf = false;
						Module1.soori = 0;
						Module1.Ghaleb = 0;
						break;
					case "صوری":
						Module1.soori = 1;
						Module1.Ghaleb = 0;
						break;
					case "قالب":
						Module1.Ghaleb = 1;
						Module1.soori = 0;
						break;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					lErl = 20;
					if (Module1.SanadRec.recnum == 0)
					{
						Module1.BtnCommand = "Insert";
						Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad1] ([radif],[sanadnum],[karnum],[pkod],[sanaddatey],[sanaddatem],[sanaddated],[fehkod],[forpf],[mablaghk],[pname1],[karkod1],[karname1],[fehrest],[noeSanad],[Salmali],[zarib],[fehrestfile],[Pname2],[Ronevwsht],[Printed],[IjadSystem],[TimeIjad],[Soori],[OnvanCode],[Ghaleb]) VALUES ('0','" + txt_SanadNo.Text + "','" + txt_JobNo.Text + "','" + Module1.StrProjectCode + "','" + txt_SanadYear.Text + "','" + txt_SanadMonth.Text + "','" + txt_SanadDay.Text + "','0','" + Conversions.ToString(Module1.forpf) + "','0','" + txt_Project.Text + "','" + StrKarfarmaCode + "','" + txt_Karfarma.Text + "','" + cmbo_FehrestName.Text + "','" + cmbo_Amaliat.Text + "','" + cmbo_SalMali.Text + "','" + Conversions.ToSingle(lbl_SanadZarib1.Text) + "','" + Module1.CurrentFehrestFile + "','" + txt_Comment.Text + "',' ','0','" + Environment.MachineName + "','','" + Conversions.ToString(Module1.soori) + "','" + cmbo_OnvanCode.Text + "','" + Conversions.ToString(Module1.Ghaleb) + "')";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
						if (Module1.FromAsnadGhaleb == 1)
						{
							if (Module1.MyConn.State == ConnectionState.Closed)
							{
								Module1.MyConn.Open();
							}
							Module1.cmd.Connection = Module1.MyConn;
							Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad2]([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb])(SELECT [radif],'" + txt_SanadNo.Text + "'[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],'" + Conversions.ToString(Module1.forpf) + "'[fopf],'" + cmbo_SalMali.Text + "'[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],'" + Conversions.ToString(Module1.soori) + "'[Soori],'" + Conversions.ToString(Module1.Ghaleb) + "'[Ghaleb] FROM [dbo].[asnad2]  WHERE [sanadnum] ='" + Module1.GhalebNo + "' And [Salmali]='" + Module1.GhalebSalMali + "' And [fopf]='" + Conversions.ToString(Module1.Ghalebforpf) + "' And [Soori]='" + Conversions.ToString(Module1.GhalebSoori) + "' And [Ghaleb]='1')";
							Module1.cmd.ExecuteNonQuery();
							Module1.MyConn.Close();
							if (Module1.MyConn.State == ConnectionState.Closed)
							{
								Module1.MyConn.Open();
							}
							Module1.cmd.Connection = Module1.MyConn;
							Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad4] ([sanadnum],[fopf],[Sharh],[darsad],[maghtoo],[mablagh],[mablaghk],[Salmali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[Soori],[Ghaleb])(SELECT '" + txt_SanadNo.Text + "'[sanadnum],[fopf],[Sharh],[darsad],[maghtoo],[mablagh],[mablaghk],[Salmali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[Soori],[Ghaleb] FROM [dbo].[asnad4]  WHERE [sanadnum] ='" + Module1.GhalebNo + "' And [Salmali]='" + Module1.GhalebSalMali + "' And [fopf]='" + Conversions.ToString(Module1.Ghalebforpf) + "' And [Soori]='" + Conversions.ToString(Module1.GhalebSoori) + "' And [Ghaleb]='1')";
							Module1.cmd.ExecuteNonQuery();
							Module1.MyConn.Close();
							Module1.FromAsnadGhaleb = 0;
						}
					}
					else
					{
						Module1.BtnCommand = "Modify";
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [radif] ='0',[sanadnum] = '" + txt_SanadNo.Text + "',[karnum] = '" + txt_JobNo.Text + "',[pkod] = '" + Module1.StrProjectCode + "',[sanaddatey] = '" + txt_SanadYear.Text + "',[sanaddatem] = '" + txt_SanadMonth.Text + "',[sanaddated] = '" + txt_SanadDay.Text + "',[fehkod] = '0',[forpf] = '" + Conversions.ToString(Module1.forpf) + "',[pname1] = '" + txt_Project.Text + "',[karkod1] = '" + StrKarfarmaCode + "',[karname1] = '" + txt_Karfarma.Text + "',[Karname2] = '',[fehrest] = '" + cmbo_FehrestName.Text + "',[noeSanad] = '" + cmbo_Amaliat.Text + "',[Salmali] = '" + cmbo_SalMali.Text + "',[zarib] = '" + Conversions.ToSingle(lbl_SanadZarib1.Text) + "',[Nameh] = '',[fehrestfile] = '" + Module1.CurrentFehrestFile + "',[Pname2] = '" + txt_Comment.Text + "',[Ronevwsht] = '',[Printed] = '',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = '',[Soori] = '" + Conversions.ToString(Module1.soori) + "',[OnvanCode] = '" + cmbo_OnvanCode.Text + "',[Ghaleb] = '" + Conversions.ToString(Module1.Ghaleb) + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Asnad2] SET [sanadnum] ='" + txt_SanadNo.Text + "',[Salmali]='" + cmbo_SalMali.Text + "',[fopf]='" + Conversions.ToString(Module1.forpf) + "',[Soori]='" + Conversions.ToString(Module1.soori) + "',[Ghaleb]='" + Conversions.ToString(Module1.Ghaleb) + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Asnad4] SET [sanadnum] ='" + txt_SanadNo.Text + "',[Salmali]='" + cmbo_SalMali.Text + "',[fopf]='" + Conversions.ToString(Module1.forpf) + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						Module1.cmd.ExecuteNonQuery();
					}
					Module1.MyConn.Close();
					SetPnl_AsnadBlue();
					Load_dtg_AsnadList();
					Module1.dtg_Color(dtg_AsnadList);
					try
					{
						if (Module1.CurrRow != 0)
						{
							dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
							ShowSanadRecord();
						}
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, lErl);
						ProjectData.ClearProjectError();
					}
				}
			}
			lErl = 10;
			if (Operators.CompareString(Module1.BtnCommand, "New", TextCompare: false) == 0)
			{
				btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
				txt_SanadNo.Focus();
				return;
			}
			try
			{
				if (Module1.CurrRow != 0)
				{
					dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[checked(Module1.CurrRow + 1)].Cells[1];
					ShowSanadRecord();
				}
				dtg_AsnadList.Focus();
				Btn_Save.BackColor = Color.White;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
		}

private void lbl_Baha_TextChanged(object sender, EventArgs e)
		{
		}

private void btn_Anavin_Click(object sender, EventArgs e)
		{
			Module1.FromAsnadList = 1;
			MyProject.Forms.frm_AsnadOnvan.ShowDialog();
			MyProject.Forms.frm_AsnadOnvan.txt_EsmRamzFltr.Text = cmbo_OnvanCode.Text;
		}

private void cmbo_OnvanCode_GotFocus(object sender, EventArgs e)
		{
		}

private void cmbo_OnvanCode_HelpRequested(object sender, HelpEventArgs hlpevent)
		{
		}

private void cmbo_OnvanCode_KeyUp(object sender, KeyEventArgs e)
		{
			OnvanCodeSearch = cmbo_OnvanCode.Text;
			if (Operators.CompareString(AmaliatSearch.Trim(), "", TextCompare: false) == 0)
			{
				Module1.Load_Cmbo(cmbo_Amaliat, "asnad1", "noeSanad", "");
			}
			else
			{
				Module1.Load_Cmbo(cmbo_Amaliat, "asnad1", "noeSanad", "Where noeSanad Like '%" + AmaliatSearch + "%'");
			}
			cmbo_OnvanCode.Text = OnvanCodeSearch;
			cmbo_OnvanCode.SelectionStart = checked(cmbo_OnvanCode.Text.Length + 1);
		}

private void cmbo_OnvanCode_Leave(object sender, EventArgs e)
		{
			OnvanCodeSearch = "";
		}

private void cmbo_OnvanCode_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (Operators.CompareString(cmbo_OnvanCode.Text.Trim(), "", TextCompare: false) == 0))
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_OnvanCode.Text.Trim(), Module1.SanadRec.OnvanCode.Trim(), TextCompare: false) != 0)
				{
					cmbo_OnvanCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_OnvanCode.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void cmbo_SalMali_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void cmbo_SalMali_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_SalMali.Text.Trim(), Module1.SanadRec.SalMali.Trim(), TextCompare: false) != 0)
				{
					cmbo_SalMali.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SalMali.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void cmbo_Amaliat_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void cmbo_Amaliat_Leave(object sender, EventArgs e)
		{
			AmaliatSearch = "";
		}

private void cmbo_Amaliat_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (SystemRefresh == 1))
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_Amaliat.Text.Trim(), Module1.SanadRec.noeSanad.Trim(), TextCompare: false) != 0)
				{
					cmbo_Amaliat.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Amaliat.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void cmbo_SalMali_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void cmbo_Amaliat_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void cmbo_FehrestName_GotFocus(object sender, EventArgs e)
		{
		}

private void cmbo_SalMali_Leave(object sender, EventArgs e)
		{
			if (cmbo_SalMali.Text.Trim().Length != 4)
			{
				DialogResult dialogResult = MessageBox.Show(".سال مالی باید بصورت عدد چهاررقمی باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

private void txt_Project_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_Karfarma_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void txt_Karfarma_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_Karfarma_Leave(object sender, EventArgs e)
		{
			if (CheckKarfarmaExist() != 0)
			{
			}
		}

private void txt_Karfarma_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (SystemRefresh == 1))
			{
				return;
			}
			int lErl = default(int);
			if (Operators.CompareString(txt_Karfarma.Text, "", TextCompare: false) != 0)
			{
				try
				{
					if (Operators.CompareString(txt_Karfarma.Text.Trim(), Module1.SanadRec.karname1.Trim(), TextCompare: false) != 0)
					{
						txt_Karfarma.ForeColor = Color.Red;
					}
					else
					{
						txt_Karfarma.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void cmbo_NoaSanad_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (Operators.CompareString(cmbo_SanadNoa.Text.Trim(), "", TextCompare: false) == 0))
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_SanadNoa.Text.Trim(), Module1.SanadRec.NoaSanad.Trim(), TextCompare: false) != 0)
				{
					cmbo_SanadNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SanadNoa.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void txt_SanadYear_TextChanged(object sender, EventArgs e)
		{
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_SanadYear.Text.Trim(), Module1.SanadRec.sanaddatey.Trim(), TextCompare: false) != 0)
				{
					txt_SanadYear.ForeColor = Color.Red;
				}
				else
				{
					txt_SanadYear.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void txt_SanadMonth_TextChanged(object sender, EventArgs e)
		{
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_SanadMonth.Text.Trim(), Module1.SanadRec.sanaddatem.Trim(), TextCompare: false) != 0)
				{
					txt_SanadMonth.ForeColor = Color.Red;
				}
				else
				{
					txt_SanadMonth.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void txt_SanadDay_TextChanged(object sender, EventArgs e)
		{
			if (Module1.SanadRecordRefresh == 0)
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_SanadDay.Text.Trim(), Module1.SanadRec.sanaddated.Trim(), TextCompare: false) != 0)
				{
					txt_SanadDay.ForeColor = Color.Red;
				}
				else
				{
					txt_SanadDay.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckSanadRecChange();
		}

private void cmbo_FehrestName_TextChanged(object sender, EventArgs e)
		{
			if ((Module1.SanadRecordRefresh == 0) | (Operators.CompareString(cmbo_FehrestName.Text.Trim(), "", TextCompare: false) == 0))
			{
				return;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_FehrestName.Text.Trim(), Module1.SanadRec.Fehrest.Trim(), TextCompare: false) != 0)
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
			CheckSanadRecChange();
			if (Operators.CompareString(cmbo_FehrestName.Text, "", TextCompare: false) != 0)
			{
				Module1.CurrentFehrestName = cmbo_FehrestName.Text;
				Module1.CurrentFehrestFile = Module1.FindCodeOrName(Module1.CurrentFehrestName, "[fehrest]", "[filename]", "[fehrest]");
			}
		}

private void Btn_Open_Click(object sender, EventArgs e)
		{
			Module1.BtnCommand = "";
			ShowSanadRecord();
			Module1.SanadNoSelected = txt_SanadNo.Text;
			MyProject.Forms.Frm_AsnadDetail.ShowDialog();
		}

private void CheckSanadRecChange()
		{
			if (DtgAsnadListRefresh == 0)
			{
				return;
			}
			foreach (object control in pnl_Asnad.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Asnad.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Asnad.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Asnad.BackColor = Color.LightPink;
					return;
				}
			}
			SetPnl_AsnadBlue();
		}

private void cmbo_SalMali_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.KeyChar = '\0';
				MessageBox.Show(".سال مالی باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

public void SetPnl_AsnadBlue()
		{
			pnl_Asnad.BackColor = Color.LightSteelBlue;
			foreach (object control in pnl_Asnad.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Asnad.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

private void Btn_Save_KeyDown(object sender, KeyEventArgs e)
		{
			txt_SanadNo.Focus();
		}

private void cmbo_SalMaliFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
				dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				return;
			}
			if (Operators.CompareString(cmbo_SalMaliFltr.Text, "", TextCompare: false) != 0)
			{
				SalMali_filter = " ([SalMali] Like N'%" + cmbo_SalMaliFltr.Text.Trim() + "%')";
			}
			else
			{
				SalMali_filter = "";
			}
			if (DtgAsnadListRefresh != 0)
			{
				Load_dtg_AsnadList();
			}
		}

private void cmbo_FehrestName_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_FehrestName.Text, "", TextCompare: false) != 0)
			{
				Module1.CurrentFehrestName = cmbo_FehrestName.Text;
				Module1.CurrentFehrestFile = Module1.FindCodeOrName(Module1.CurrentFehrestName, "[fehrest]", "[filename]", "[fehrest]");
			}
		}

private void btn_projectSearch_Click(object sender, EventArgs e)
		{
			Module1.FromAsnadList = 1;
			MyProject.Forms.Frm_Project.ShowDialog();
			MyProject.Forms.Frm_Project.Load_dtg_Project();
		}

private void btn_KarfarmaSearch_Click(object sender, EventArgs e)
		{
			Module1.FromAsnadList = 1;
			MyProject.Forms.Frm_Karfarma.ShowDialog();
			MyProject.Forms.Frm_Karfarma.Load_dtg_Karfarma();
		}

private void btn_AmaliatSearch_Click(object sender, EventArgs e)
		{
			AmaliatSearch = cmbo_Amaliat.Text;
			cmbo_Amaliat.DroppedDown = false;
			if (Operators.CompareString(AmaliatSearch.Trim(), "", TextCompare: false) == 0)
			{
				Module1.Load_Cmbo(cmbo_Amaliat, "asnad1", "noeSanad", "");
			}
			else
			{
				Module1.Load_Cmbo(cmbo_Amaliat, "asnad1", "noeSanad", "Where noeSanad Like '%" + AmaliatSearch + "%'");
			}
			if (cmbo_Amaliat.Items.Count > 0)
			{
				cmbo_Amaliat.DroppedDown = true;
			}
			cmbo_Amaliat.Text = AmaliatSearch;
			cmbo_Amaliat.SelectionStart = checked(cmbo_Amaliat.Text.Length + 1);
		}

private void txt_JobNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_JobNoFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void txt_ProjectFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_ProjectFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void txt_KarfarmaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_KarfarmaFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void txt_BahaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_BahaFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
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

private void txt_AmaliatFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_AmaliatFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				if (Operators.CompareString(txt_CommentFltr.Text, "", TextCompare: false) != 0)
				{
					btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
					dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				}
				return;
			}
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

private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			SalMali_filter = "";
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
			pnl_Filter.Visible = false;
			Load_dtg_AsnadList();
			txt_SanadNoFltr.Text = "";
			cmbo_NoaSanadFltr.Text = Module1.NoaSanad;
			txt_JobNoFltr.Text = "";
			txt_SanadDateFltr.Text = "";
			txt_ProjectFltr.Text = "";
			txt_KarfarmaFltr.Text = "";
			cmbo_SalMaliFltr.Text = "";
			txt_BahaFltr.Text = "";
			txt_AmaliatFltr.Text = "";
			txt_CommentFltr.Text = "";
			cmbo_FehrestFltr.Text = "";
		}

private void cmbo_SalMaliFltr_TextChanged(object sender, EventArgs e)
		{
			if (pnl_Asnad.BackColor == Color.LightPink)
			{
				btn_Filter_Click(RuntimeHelpers.GetObjectValue(sender), e);
				dtg_Asnad_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				return;
			}
			if (Operators.CompareString(cmbo_SalMaliFltr.Text, "", TextCompare: false) != 0)
			{
				SalMali_filter = " ([SalMali] Like N'%" + cmbo_SalMaliFltr.Text.Trim() + "%')";
			}
			else
			{
				SalMali_filter = "";
			}
			if (DtgAsnadListRefresh != 0)
			{
				Load_dtg_AsnadList();
			}
		}

private void cmbo_OnvanCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

private void cmbo_OnvanCode_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void cmbo_SalMali_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void txt_SanadNo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void txt_SanadNo_TextChanged_1(object sender, EventArgs e)
		{
		}

private void cmbo_Amaliat_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void cmbo_FehrestName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void cmbo_OnvanCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadList.Focus();
			}
		}

private void dtg_AsnadList_MouseDown(object sender, MouseEventArgs e)
		{
		}

private void dtg_AsnadList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			try
			{
				if (e.Button == MouseButtons.Right)
				{
					dtg_AsnadList.CurrentCell = dtg_AsnadList[e.ColumnIndex, e.RowIndex];
					dtg_AsnadList.Columns[21].Visible = true;
					dtg_AsnadList.Columns[22].Visible = true;
					string text = SystemNameToUsername(Conversions.ToString(dtg_AsnadList.Rows[dtg_AsnadList.CurrentRow.Index].Cells[21].Value));
					DateTime dateTime = Conversions.ToDate(dtg_AsnadList.Rows[dtg_AsnadList.CurrentRow.Index].Cells[22].Value);
					lbl_User.Visible = true;
					lbl_User.Location = PointToClient(Control.MousePosition);
					lbl_User.Text = text;
					lbl_User.BringToFront();
				}
				else
				{
					lbl_User.Visible = false;
					dtg_AsnadList.Columns[21].Visible = false;
					dtg_AsnadList.Columns[22].Visible = false;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				lbl_User.Visible = false;
				ProjectData.ClearProjectError();
			}
		}

private void dtg_AsnadList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
		}

private void dtg_AsnadList_MouseWheel(object sender, MouseEventArgs e)
		{
			lbl_User.Visible = false;
		}

private void txt_ProjectFltr_TextChanged(object sender, EventArgs e)
		{
		}

private void chk_SabtNashode_CheckedChanged(object sender, EventArgs e)
		{
			Load_dtg_AsnadList();
		}

    }
}
