using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
    public partial class Frm_AsnadList : Form

    {
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

		private IContainer components;


        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.TextBox txt_BahaFltr;
        private System.Windows.Forms.TextBox txt_AmaliatFltr;
        private System.Windows.Forms.Panel pnl_Asnad;
        public System.Windows.Forms.TextBox txt_Comment;
        private System.Windows.Forms.Label Label33;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label22;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_AsnadSum;
        private System.Windows.Forms.Label lbl_AsnadNum;
        private System.Windows.Forms.Label Label26;
        private System.Windows.Forms.Label Label28;
        internal System.Windows.Forms.DataGridView dtg_AsnadList;
        public System.Windows.Forms.TextBox txt_JobNo;
        private System.Windows.Forms.TextBox txt_SanadNoFltr;
        private System.Windows.Forms.TextBox txt_JobNoFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaFltr;
        private System.Windows.Forms.TextBox txt_ProjectFltr;
        private System.Windows.Forms.TextBox txt_SanadDateFltr;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox txt_CommentFltr;
        private System.Windows.Forms.Label Label32;
        public System.Windows.Forms.ComboBox cmbo_SanadNoa;
        private System.Windows.Forms.Label Label34;
        public System.Windows.Forms.ComboBox cmbo_NoaSanadFltr;
        private System.Windows.Forms.TextBox txt_Roonevesht;
        public System.Windows.Forms.ComboBox cmbo_FehrestName;
        private System.Windows.Forms.Panel Panel8;
        private System.Windows.Forms.Label lbl_SanadZaribComment2;
        private System.Windows.Forms.Label lbl_SanadZaribComment1;
        private System.Windows.Forms.Label lbl_SanadZarib2;
        private System.Windows.Forms.Label lbl_SanadZarib1;
        public System.Windows.Forms.Label lbl_SanadBakhsh;
        public System.Windows.Forms.Label lbl_SanadShahr;
        public System.Windows.Forms.Label lbl_SanadOstan;
        private System.Windows.Forms.Label Label39;
        private System.Windows.Forms.Label Label40;
        private System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Label Label42;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.ComboBox cmbo_FehrestFltr;
        private System.Windows.Forms.Label lbl_SanadBakhshCode;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Label lbl_Baha;
        private System.Windows.Forms.Label Label5;
        public System.Windows.Forms.ComboBox cmbo_SalMali;
        public System.Windows.Forms.ComboBox cmbo_OnvanCode;
        public System.Windows.Forms.ComboBox cmbo_Amaliat;
        private System.Windows.Forms.Button Btn_Open;
        private System.Windows.Forms.Button btn_OnvanCode;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DateTimePicker DateTimePicker1;
        public System.Windows.Forms.TextBox txt_SanadYear;
        public System.Windows.Forms.TextBox txt_SanadMonth;
        public System.Windows.Forms.TextBox txt_SanadDay;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.ComboBox cmbo_SalMaliFltr;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Button btn_projectSearch;
        private System.Windows.Forms.Button btn_KarfarmaSearch;
        public System.Windows.Forms.TextBox txt_Project;
        public System.Windows.Forms.TextBox txt_Karfarma;
        private System.Windows.Forms.Button btn_Filter;
        public System.Windows.Forms.TextBox txt_SanadNo;
        private System.Windows.Forms.Label lbl_User;
        internal System.Windows.Forms.CheckBox chk_SabtNashode;
        private System.Windows.Forms.Label Label6;


        public Frm_AsnadList()
		{
			base.KeyDown += Frm_AsnadList_KeyDown;
			base.Load += Frm_AsnadList_Load;
			SalMaliSearch = "";
			ProjectSearch = "";
			StrFehrestCode = "";
			KarfarmaSearch = "";
			StrKarfarmaCode = "";
			AmaliatSearch = "";
			OnvanCodeSearch = "";
			OnvanMabna = "";
			SystemRefresh = 0;
			InitializeComponent();
		}

		private void Frm_AsnadList_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_AsnadList_Load(object sender, EventArgs e)
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

		~Frm_AsnadList()
		{
			base.Dispose();
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

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[System.Diagnostics.DebuggerStepThrough]
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_AsnadList));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_SalMaliFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_FehrestFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_NoaSanadFltr = new System.Windows.Forms.ComboBox();
			this.txt_CommentFltr = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaFltr = new System.Windows.Forms.TextBox();
			this.txt_ProjectFltr = new System.Windows.Forms.TextBox();
			this.txt_SanadDateFltr = new System.Windows.Forms.TextBox();
			this.txt_JobNoFltr = new System.Windows.Forms.TextBox();
			this.txt_SanadNoFltr = new System.Windows.Forms.TextBox();
			this.txt_BahaFltr = new System.Windows.Forms.TextBox();
			this.txt_AmaliatFltr = new System.Windows.Forms.TextBox();
			this.pnl_Asnad = new System.Windows.Forms.Panel();
			this.txt_SanadNo = new System.Windows.Forms.TextBox();
			this.txt_Karfarma = new System.Windows.Forms.TextBox();
			this.txt_Project = new System.Windows.Forms.TextBox();
			this.btn_KarfarmaSearch = new System.Windows.Forms.Button();
			this.btn_projectSearch = new System.Windows.Forms.Button();
			this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.txt_SanadYear = new System.Windows.Forms.TextBox();
			this.txt_SanadMonth = new System.Windows.Forms.TextBox();
			this.txt_SanadDay = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_OnvanCode = new System.Windows.Forms.Button();
			this.Btn_Open = new System.Windows.Forms.Button();
			this.cmbo_Amaliat = new System.Windows.Forms.ComboBox();
			this.cmbo_OnvanCode = new System.Windows.Forms.ComboBox();
			this.cmbo_SalMali = new System.Windows.Forms.ComboBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.lbl_Baha = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Panel8 = new System.Windows.Forms.Panel();
			this.lbl_SanadBakhshCode = new System.Windows.Forms.Label();
			this.lbl_SanadZaribComment2 = new System.Windows.Forms.Label();
			this.lbl_SanadZaribComment1 = new System.Windows.Forms.Label();
			this.lbl_SanadZarib2 = new System.Windows.Forms.Label();
			this.lbl_SanadZarib1 = new System.Windows.Forms.Label();
			this.lbl_SanadBakhsh = new System.Windows.Forms.Label();
			this.lbl_SanadShahr = new System.Windows.Forms.Label();
			this.lbl_SanadOstan = new System.Windows.Forms.Label();
			this.Label39 = new System.Windows.Forms.Label();
			this.Label40 = new System.Windows.Forms.Label();
			this.Label41 = new System.Windows.Forms.Label();
			this.Label42 = new System.Windows.Forms.Label();
			this.cmbo_FehrestName = new System.Windows.Forms.ComboBox();
			this.Label34 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.cmbo_SanadNoa = new System.Windows.Forms.ComboBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.txt_JobNo = new System.Windows.Forms.TextBox();
			this.txt_Comment = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label22 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.lbl_AsnadSum = new System.Windows.Forms.Label();
			this.lbl_AsnadNum = new System.Windows.Forms.Label();
			this.Label26 = new System.Windows.Forms.Label();
			this.Label28 = new System.Windows.Forms.Label();
			this.dtg_AsnadList = new System.Windows.Forms.DataGridView();
			this.txt_Roonevesht = new System.Windows.Forms.TextBox();
			this.lbl_User = new System.Windows.Forms.Label();
			this.chk_SabtNashode = new System.Windows.Forms.CheckBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.pnl_Asnad.SuspendLayout();
			this.Panel8.SuspendLayout();
			this.Panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadList).BeginInit();
			base.SuspendLayout();
			this.pnl_Filter.BackColor = System.Drawing.Color.White;
			this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.cmbo_SalMaliFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_FehrestFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_NoaSanadFltr);
			this.pnl_Filter.Controls.Add(this.txt_CommentFltr);
			this.pnl_Filter.Controls.Add(this.txt_KarfarmaFltr);
			this.pnl_Filter.Controls.Add(this.txt_ProjectFltr);
			this.pnl_Filter.Controls.Add(this.txt_SanadDateFltr);
			this.pnl_Filter.Controls.Add(this.txt_JobNoFltr);
			this.pnl_Filter.Controls.Add(this.txt_SanadNoFltr);
			this.pnl_Filter.Controls.Add(this.txt_BahaFltr);
			this.pnl_Filter.Controls.Add(this.txt_AmaliatFltr);
			this.pnl_Filter.Location = new System.Drawing.Point(1, 4);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1157, 60);
			this.pnl_Filter.TabIndex = 71;
			this.btn_Filter.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(1116, 0);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(40, 59);
			this.btn_Filter.TabIndex = 148;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1082, 1);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(35, 58);
			this.Label10.TabIndex = 154;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(1, 1);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1159, 32);
			this.PictureBox1.TabIndex = 156;
			this.PictureBox1.TabStop = false;
			this.cmbo_SalMaliFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_SalMaliFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_SalMaliFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_SalMaliFltr.FormattingEnabled = true;
			this.cmbo_SalMaliFltr.Location = new System.Drawing.Point(976, 37);
			this.cmbo_SalMaliFltr.Name = "cmbo_SalMaliFltr";
			this.cmbo_SalMaliFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_SalMaliFltr.Size = new System.Drawing.Size(45, 26);
			this.cmbo_SalMaliFltr.TabIndex = 155;
			this.cmbo_FehrestFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_FehrestFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_FehrestFltr.FormattingEnabled = true;
			this.cmbo_FehrestFltr.Location = new System.Drawing.Point(1, 37);
			this.cmbo_FehrestFltr.Name = "cmbo_FehrestFltr";
			this.cmbo_FehrestFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestFltr.Size = new System.Drawing.Size(119, 26);
			this.cmbo_FehrestFltr.TabIndex = 86;
			this.cmbo_NoaSanadFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_NoaSanadFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_NoaSanadFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_NoaSanadFltr.FormattingEnabled = true;
			this.cmbo_NoaSanadFltr.Location = new System.Drawing.Point(1022, 37);
			this.cmbo_NoaSanadFltr.Name = "cmbo_NoaSanadFltr";
			this.cmbo_NoaSanadFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_NoaSanadFltr.Size = new System.Drawing.Size(60, 26);
			this.cmbo_NoaSanadFltr.TabIndex = 73;
			this.txt_CommentFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_CommentFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_CommentFltr.Location = new System.Drawing.Point(121, 37);
			this.txt_CommentFltr.Name = "txt_CommentFltr";
			this.txt_CommentFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_CommentFltr.Size = new System.Drawing.Size(149, 26);
			this.txt_CommentFltr.TabIndex = 57;
			this.txt_KarfarmaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaFltr.Location = new System.Drawing.Point(511, 37);
			this.txt_KarfarmaFltr.Name = "txt_KarfarmaFltr";
			this.txt_KarfarmaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaFltr.Size = new System.Drawing.Size(149, 26);
			this.txt_KarfarmaFltr.TabIndex = 55;
			this.txt_ProjectFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ProjectFltr.Location = new System.Drawing.Point(661, 37);
			this.txt_ProjectFltr.Name = "txt_ProjectFltr";
			this.txt_ProjectFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectFltr.Size = new System.Drawing.Size(149, 26);
			this.txt_ProjectFltr.TabIndex = 54;
			this.txt_SanadDateFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadDateFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_SanadDateFltr.Location = new System.Drawing.Point(811, 37);
			this.txt_SanadDateFltr.Name = "txt_SanadDateFltr";
			this.txt_SanadDateFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SanadDateFltr.Size = new System.Drawing.Size(54, 26);
			this.txt_SanadDateFltr.TabIndex = 53;
			this.txt_JobNoFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_JobNoFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_JobNoFltr.Location = new System.Drawing.Point(866, 37);
			this.txt_JobNoFltr.Name = "txt_JobNoFltr";
			this.txt_JobNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_JobNoFltr.Size = new System.Drawing.Size(54, 26);
			this.txt_JobNoFltr.TabIndex = 50;
			this.txt_SanadNoFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadNoFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_SanadNoFltr.Location = new System.Drawing.Point(921, 37);
			this.txt_SanadNoFltr.Name = "txt_SanadNoFltr";
			this.txt_SanadNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SanadNoFltr.Size = new System.Drawing.Size(54, 26);
			this.txt_SanadNoFltr.TabIndex = 54;
			this.txt_BahaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_BahaFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_BahaFltr.Location = new System.Drawing.Point(421, 37);
			this.txt_BahaFltr.Name = "txt_BahaFltr";
			this.txt_BahaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_BahaFltr.Size = new System.Drawing.Size(89, 26);
			this.txt_BahaFltr.TabIndex = 47;
			this.txt_AmaliatFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_AmaliatFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_AmaliatFltr.Location = new System.Drawing.Point(271, 37);
			this.txt_AmaliatFltr.Name = "txt_AmaliatFltr";
			this.txt_AmaliatFltr.Size = new System.Drawing.Size(149, 26);
			this.txt_AmaliatFltr.TabIndex = 48;
			this.pnl_Asnad.BackColor = System.Drawing.Color.LightSteelBlue;
			this.pnl_Asnad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Asnad.Controls.Add(this.txt_SanadNo);
			this.pnl_Asnad.Controls.Add(this.txt_Karfarma);
			this.pnl_Asnad.Controls.Add(this.txt_Project);
			this.pnl_Asnad.Controls.Add(this.btn_KarfarmaSearch);
			this.pnl_Asnad.Controls.Add(this.btn_projectSearch);
			this.pnl_Asnad.Controls.Add(this.DateTimePicker1);
			this.pnl_Asnad.Controls.Add(this.txt_SanadYear);
			this.pnl_Asnad.Controls.Add(this.txt_SanadMonth);
			this.pnl_Asnad.Controls.Add(this.txt_SanadDay);
			this.pnl_Asnad.Controls.Add(this.Label16);
			this.pnl_Asnad.Controls.Add(this.Label17);
			this.pnl_Asnad.Controls.Add(this.Label18);
			this.pnl_Asnad.Controls.Add(this.btn_Delete);
			this.pnl_Asnad.Controls.Add(this.btn_OnvanCode);
			this.pnl_Asnad.Controls.Add(this.Btn_Open);
			this.pnl_Asnad.Controls.Add(this.cmbo_Amaliat);
			this.pnl_Asnad.Controls.Add(this.cmbo_OnvanCode);
			this.pnl_Asnad.Controls.Add(this.cmbo_SalMali);
			this.pnl_Asnad.Controls.Add(this.Label5);
			this.pnl_Asnad.Controls.Add(this.lbl_Baha);
			this.pnl_Asnad.Controls.Add(this.btn_Exit);
			this.pnl_Asnad.Controls.Add(this.btn_Copy);
			this.pnl_Asnad.Controls.Add(this.btn_Insert);
			this.pnl_Asnad.Controls.Add(this.Btn_Save);
			this.pnl_Asnad.Controls.Add(this.Panel8);
			this.pnl_Asnad.Controls.Add(this.cmbo_FehrestName);
			this.pnl_Asnad.Controls.Add(this.Label34);
			this.pnl_Asnad.Controls.Add(this.Label32);
			this.pnl_Asnad.Controls.Add(this.cmbo_SanadNoa);
			this.pnl_Asnad.Controls.Add(this.Label9);
			this.pnl_Asnad.Controls.Add(this.txt_JobNo);
			this.pnl_Asnad.Controls.Add(this.txt_Comment);
			this.pnl_Asnad.Controls.Add(this.Label33);
			this.pnl_Asnad.Controls.Add(this.Label8);
			this.pnl_Asnad.Controls.Add(this.Label22);
			this.pnl_Asnad.Controls.Add(this.Label1);
			this.pnl_Asnad.Controls.Add(this.Label2);
			this.pnl_Asnad.Controls.Add(this.Label4);
			this.pnl_Asnad.Controls.Add(this.Label3);
			this.pnl_Asnad.Location = new System.Drawing.Point(1, 498);
			this.pnl_Asnad.Name = "pnl_Asnad";
			this.pnl_Asnad.Size = new System.Drawing.Size(1180, 207);
			this.pnl_Asnad.TabIndex = 66;
			this.txt_SanadNo.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadNo.Location = new System.Drawing.Point(991, 34);
			this.txt_SanadNo.Name = "txt_SanadNo";
			this.txt_SanadNo.Size = new System.Drawing.Size(100, 26);
			this.txt_SanadNo.TabIndex = 5;
			this.txt_Karfarma.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Karfarma.Location = new System.Drawing.Point(674, 112);
			this.txt_Karfarma.Name = "txt_Karfarma";
			this.txt_Karfarma.Size = new System.Drawing.Size(417, 26);
			this.txt_Karfarma.TabIndex = 9;
			this.txt_Project.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Project.Location = new System.Drawing.Point(674, 86);
			this.txt_Project.Name = "txt_Project";
			this.txt_Project.Size = new System.Drawing.Size(417, 26);
			this.txt_Project.TabIndex = 8;
			this.btn_KarfarmaSearch.Image = (System.Drawing.Image)resources.GetObject("btn_KarfarmaSearch.Image");
			this.btn_KarfarmaSearch.Location = new System.Drawing.Point(648, 112);
			this.btn_KarfarmaSearch.Name = "btn_KarfarmaSearch";
			this.btn_KarfarmaSearch.Size = new System.Drawing.Size(26, 25);
			this.btn_KarfarmaSearch.TabIndex = 160;
			this.btn_KarfarmaSearch.UseVisualStyleBackColor = true;
			this.btn_projectSearch.Image = (System.Drawing.Image)resources.GetObject("btn_projectSearch.Image");
			this.btn_projectSearch.Location = new System.Drawing.Point(648, 86);
			this.btn_projectSearch.Name = "btn_projectSearch";
			this.btn_projectSearch.Size = new System.Drawing.Size(26, 25);
			this.btn_projectSearch.TabIndex = 159;
			this.btn_projectSearch.UseVisualStyleBackColor = true;
			this.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
			this.DateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.DateTimePicker1.CustomFormat = "dd/MM/yyyy";
			this.DateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateTimePicker1.Location = new System.Drawing.Point(757, 9);
			this.DateTimePicker1.Name = "DateTimePicker1";
			this.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.DateTimePicker1.RightToLeftLayout = true;
			this.DateTimePicker1.Size = new System.Drawing.Size(0, 20);
			this.DateTimePicker1.TabIndex = 158;
			this.txt_SanadYear.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadYear.Location = new System.Drawing.Point(710, 9);
			this.txt_SanadYear.Name = "txt_SanadYear";
			this.txt_SanadYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SanadYear.Size = new System.Drawing.Size(40, 26);
			this.txt_SanadYear.TabIndex = 4;
			this.txt_SanadMonth.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadMonth.Location = new System.Drawing.Point(759, 9);
			this.txt_SanadMonth.Name = "txt_SanadMonth";
			this.txt_SanadMonth.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SanadMonth.Size = new System.Drawing.Size(40, 26);
			this.txt_SanadMonth.TabIndex = 3;
			this.txt_SanadDay.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadDay.Location = new System.Drawing.Point(809, 8);
			this.txt_SanadDay.Name = "txt_SanadDay";
			this.txt_SanadDay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SanadDay.Size = new System.Drawing.Size(40, 26);
			this.txt_SanadDay.TabIndex = 2;
			this.Label16.AutoSize = true;
			this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label16.Location = new System.Drawing.Point(799, 10);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(13, 16);
			this.Label16.TabIndex = 154;
			this.Label16.Text = "/";
			this.Label17.AutoSize = true;
			this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label17.Location = new System.Drawing.Point(749, 10);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(13, 16);
			this.Label17.TabIndex = 153;
			this.Label17.Text = "/";
			this.Label18.AutoSize = true;
			this.Label18.Location = new System.Drawing.Point(848, 12);
			this.Label18.Name = "Label18";
			this.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label18.Size = new System.Drawing.Size(38, 13);
			this.Label18.TabIndex = 152;
			this.Label18.Text = ": تاریخ";
			this.btn_Delete.Location = new System.Drawing.Point(220, 171);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(90, 30);
			this.btn_Delete.TabIndex = 19;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_OnvanCode.Image = (System.Drawing.Image)resources.GetObject("btn_OnvanCode.Image");
			this.btn_OnvanCode.Location = new System.Drawing.Point(21, 5);
			this.btn_OnvanCode.Name = "btn_OnvanCode";
			this.btn_OnvanCode.Size = new System.Drawing.Size(28, 26);
			this.btn_OnvanCode.TabIndex = 150;
			this.btn_OnvanCode.UseVisualStyleBackColor = true;
			this.Btn_Open.Location = new System.Drawing.Point(864, 171);
			this.Btn_Open.Name = "Btn_Open";
			this.Btn_Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Open.Size = new System.Drawing.Size(90, 30);
			this.Btn_Open.TabIndex = 16;
			this.Btn_Open.Text = "(DblClk) نمایش";
			this.Btn_Open.UseVisualStyleBackColor = true;
			this.cmbo_Amaliat.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_Amaliat.FormattingEnabled = true;
			this.cmbo_Amaliat.Location = new System.Drawing.Point(674, 138);
			this.cmbo_Amaliat.Name = "cmbo_Amaliat";
			this.cmbo_Amaliat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Amaliat.Size = new System.Drawing.Size(417, 26);
			this.cmbo_Amaliat.TabIndex = 10;
			this.cmbo_OnvanCode.Enabled = false;
			this.cmbo_OnvanCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_OnvanCode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_OnvanCode.FormattingEnabled = true;
			this.cmbo_OnvanCode.Location = new System.Drawing.Point(48, 6);
			this.cmbo_OnvanCode.Name = "cmbo_OnvanCode";
			this.cmbo_OnvanCode.Size = new System.Drawing.Size(82, 26);
			this.cmbo_OnvanCode.TabIndex = 12;
			this.cmbo_SalMali.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_SalMali.FormattingEnabled = true;
			this.cmbo_SalMali.Location = new System.Drawing.Point(991, 8);
			this.cmbo_SalMali.Name = "cmbo_SalMali";
			this.cmbo_SalMali.Size = new System.Drawing.Size(100, 26);
			this.cmbo_SalMali.TabIndex = 1;
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(130, 12);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(73, 13);
			this.Label5.TabIndex = 123;
			this.Label5.Text = " کد مشخصات :";
			this.lbl_Baha.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_Baha.Location = new System.Drawing.Point(681, 57);
			this.lbl_Baha.Name = "lbl_Baha";
			this.lbl_Baha.Size = new System.Drawing.Size(172, 20);
			this.lbl_Baha.TabIndex = 121;
			this.lbl_Baha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_Exit.Location = new System.Drawing.Point(15, 171);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(100, 30);
			this.btn_Exit.TabIndex = 15;
			this.btn_Exit.Text = "(Esc) بازگشت ";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Copy.Location = new System.Drawing.Point(431, 171);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Copy.Size = new System.Drawing.Size(90, 30);
			this.btn_Copy.TabIndex = 18;
			this.btn_Copy.Text = "(Ctrl + C) کپی ";
			this.btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Insert.Location = new System.Drawing.Point(656, 171);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Insert.Size = new System.Drawing.Size(90, 30);
			this.btn_Insert.TabIndex = 17;
			this.btn_Insert.Text = "(Insert) جدید  ";
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.Btn_Save.Location = new System.Drawing.Point(1059, 171);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Save.Size = new System.Drawing.Size(90, 30);
			this.Btn_Save.TabIndex = 14;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Panel8.Controls.Add(this.lbl_SanadBakhshCode);
			this.Panel8.Controls.Add(this.lbl_SanadZaribComment2);
			this.Panel8.Controls.Add(this.lbl_SanadZaribComment1);
			this.Panel8.Controls.Add(this.lbl_SanadZarib2);
			this.Panel8.Controls.Add(this.lbl_SanadZarib1);
			this.Panel8.Controls.Add(this.lbl_SanadBakhsh);
			this.Panel8.Controls.Add(this.lbl_SanadShahr);
			this.Panel8.Controls.Add(this.lbl_SanadOstan);
			this.Panel8.Controls.Add(this.Label39);
			this.Panel8.Controls.Add(this.Label40);
			this.Panel8.Controls.Add(this.Label41);
			this.Panel8.Controls.Add(this.Label42);
			this.Panel8.Location = new System.Drawing.Point(4, 36);
			this.Panel8.Name = "Panel8";
			this.Panel8.Size = new System.Drawing.Size(618, 77);
			this.Panel8.TabIndex = 85;
			this.lbl_SanadBakhshCode.AutoSize = true;
			this.lbl_SanadBakhshCode.Location = new System.Drawing.Point(310, 21);
			this.lbl_SanadBakhshCode.Name = "lbl_SanadBakhshCode";
			this.lbl_SanadBakhshCode.Size = new System.Drawing.Size(0, 13);
			this.lbl_SanadBakhshCode.TabIndex = 108;
			this.lbl_SanadBakhshCode.Visible = false;
			this.lbl_SanadZaribComment2.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZaribComment2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZaribComment2.Location = new System.Drawing.Point(12, 41);
			this.lbl_SanadZaribComment2.Name = "lbl_SanadZaribComment2";
			this.lbl_SanadZaribComment2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZaribComment2.Size = new System.Drawing.Size(274, 20);
			this.lbl_SanadZaribComment2.TabIndex = 107;
			this.lbl_SanadZaribComment2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadZaribComment1.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZaribComment1.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZaribComment1.Location = new System.Drawing.Point(12, 18);
			this.lbl_SanadZaribComment1.Name = "lbl_SanadZaribComment1";
			this.lbl_SanadZaribComment1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZaribComment1.Size = new System.Drawing.Size(274, 20);
			this.lbl_SanadZaribComment1.TabIndex = 106;
			this.lbl_SanadZaribComment1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadZarib2.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZarib2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZarib2.Location = new System.Drawing.Point(290, 41);
			this.lbl_SanadZarib2.Name = "lbl_SanadZarib2";
			this.lbl_SanadZarib2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZarib2.Size = new System.Drawing.Size(43, 20);
			this.lbl_SanadZarib2.TabIndex = 105;
			this.lbl_SanadZarib2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_SanadZarib1.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZarib1.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZarib1.Location = new System.Drawing.Point(290, 18);
			this.lbl_SanadZarib1.Name = "lbl_SanadZarib1";
			this.lbl_SanadZarib1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZarib1.Size = new System.Drawing.Size(43, 20);
			this.lbl_SanadZarib1.TabIndex = 104;
			this.lbl_SanadZarib1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_SanadBakhsh.BackColor = System.Drawing.Color.White;
			this.lbl_SanadBakhsh.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadBakhsh.Location = new System.Drawing.Point(446, 52);
			this.lbl_SanadBakhsh.Name = "lbl_SanadBakhsh";
			this.lbl_SanadBakhsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadBakhsh.Size = new System.Drawing.Size(112, 21);
			this.lbl_SanadBakhsh.TabIndex = 103;
			this.lbl_SanadBakhsh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadShahr.BackColor = System.Drawing.Color.White;
			this.lbl_SanadShahr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadShahr.Location = new System.Drawing.Point(446, 28);
			this.lbl_SanadShahr.Name = "lbl_SanadShahr";
			this.lbl_SanadShahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadShahr.Size = new System.Drawing.Size(112, 21);
			this.lbl_SanadShahr.TabIndex = 102;
			this.lbl_SanadShahr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadOstan.BackColor = System.Drawing.Color.White;
			this.lbl_SanadOstan.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadOstan.Location = new System.Drawing.Point(446, 4);
			this.lbl_SanadOstan.Name = "lbl_SanadOstan";
			this.lbl_SanadOstan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadOstan.Size = new System.Drawing.Size(112, 21);
			this.lbl_SanadOstan.TabIndex = 14;
			this.lbl_SanadOstan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label39.Location = new System.Drawing.Point(329, 34);
			this.Label39.Name = "Label39";
			this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label39.Size = new System.Drawing.Size(91, 27);
			this.Label39.TabIndex = 93;
			this.Label39.Text = " :ضریب منطقه ای";
			this.Label40.AutoSize = true;
			this.Label40.Location = new System.Drawing.Point(557, 10);
			this.Label40.Name = "Label40";
			this.Label40.Size = new System.Drawing.Size(40, 13);
			this.Label40.TabIndex = 92;
			this.Label40.Text = "استان :";
			this.Label41.AutoSize = true;
			this.Label41.Location = new System.Drawing.Point(557, 33);
			this.Label41.Name = "Label41";
			this.Label41.Size = new System.Drawing.Size(60, 13);
			this.Label41.TabIndex = 91;
			this.Label41.Text = " شهرستان :";
			this.Label42.AutoSize = true;
			this.Label42.Location = new System.Drawing.Point(558, 54);
			this.Label42.Name = "Label42";
			this.Label42.Size = new System.Drawing.Size(36, 13);
			this.Label42.TabIndex = 90;
			this.Label42.Text = " بخش :";
			this.cmbo_FehrestName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_FehrestName.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestName.FormattingEnabled = true;
			this.cmbo_FehrestName.Location = new System.Drawing.Point(263, 6);
			this.cmbo_FehrestName.Name = "cmbo_FehrestName";
			this.cmbo_FehrestName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestName.Size = new System.Drawing.Size(300, 26);
			this.cmbo_FehrestName.TabIndex = 11;
			this.Label34.AutoSize = true;
			this.Label34.Location = new System.Drawing.Point(1090, 12);
			this.Label34.Name = "Label34";
			this.Label34.Size = new System.Drawing.Size(61, 13);
			this.Label34.TabIndex = 78;
			this.Label34.Text = " سال مالی :";
			this.Label32.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.Label32.AutoSize = true;
			this.Label32.Location = new System.Drawing.Point(847, 38);
			this.Label32.Name = "Label32";
			this.Label32.Size = new System.Drawing.Size(54, 13);
			this.Label32.TabIndex = 77;
			this.Label32.Text = " نوع سند :";
			this.cmbo_SanadNoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_SanadNoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_SanadNoa.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_SanadNoa.FormattingEnabled = true;
			this.cmbo_SanadNoa.Location = new System.Drawing.Point(711, 36);
			this.cmbo_SanadNoa.Name = "cmbo_SanadNoa";
			this.cmbo_SanadNoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_SanadNoa.Size = new System.Drawing.Size(136, 26);
			this.cmbo_SanadNoa.TabIndex = 6;
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(855, 61);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(35, 13);
			this.Label9.TabIndex = 60;
			this.Label9.Text = " مبلغ :";
			this.txt_JobNo.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_JobNo.Location = new System.Drawing.Point(991, 60);
			this.txt_JobNo.Name = "txt_JobNo";
			this.txt_JobNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_JobNo.Size = new System.Drawing.Size(100, 26);
			this.txt_JobNo.TabIndex = 7;
			this.txt_Comment.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Comment.Location = new System.Drawing.Point(14, 125);
			this.txt_Comment.Name = "txt_Comment";
			this.txt_Comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_Comment.Size = new System.Drawing.Size(548, 26);
			this.txt_Comment.TabIndex = 13;
			this.Label33.AutoSize = true;
			this.Label33.Location = new System.Drawing.Point(560, 131);
			this.Label33.Name = "Label33";
			this.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label33.Size = new System.Drawing.Size(55, 13);
			this.Label33.TabIndex = 50;
			this.Label33.Text = ": توضیحات";
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(562, 13);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(67, 13);
			this.Label8.TabIndex = 47;
			this.Label8.Text = " فهرست بها :";
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(1091, 38);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(66, 13);
			this.Label22.TabIndex = 36;
			this.Label22.Text = " شماره سند :";
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(1092, 64);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "شماره کار :";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(1091, 93);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(58, 13);
			this.Label2.TabIndex = 100;
			this.Label2.Text = " نام پروژه :";
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(1090, 141);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(73, 13);
			this.Label4.TabIndex = 102;
			this.Label4.Text = "  موضوع سند :";
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(1089, 120);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(68, 13);
			this.Label3.TabIndex = 101;
			this.Label3.Text = " نام کارفرما :";
			this.Panel1.BackColor = System.Drawing.SystemColors.Control;
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.lbl_AsnadSum);
			this.Panel1.Controls.Add(this.lbl_AsnadNum);
			this.Panel1.Controls.Add(this.Label26);
			this.Panel1.Controls.Add(this.Label28);
			this.Panel1.Location = new System.Drawing.Point(1, 466);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(1180, 28);
			this.Panel1.TabIndex = 65;
			this.lbl_AsnadSum.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_AsnadSum.ForeColor = System.Drawing.Color.Black;
			this.lbl_AsnadSum.Location = new System.Drawing.Point(417, 4);
			this.lbl_AsnadSum.Name = "lbl_AsnadSum";
			this.lbl_AsnadSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_AsnadSum.Size = new System.Drawing.Size(149, 20);
			this.lbl_AsnadSum.TabIndex = 46;
			this.lbl_AsnadSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_AsnadNum.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_AsnadNum.ForeColor = System.Drawing.Color.Black;
			this.lbl_AsnadNum.Location = new System.Drawing.Point(833, 3);
			this.lbl_AsnadNum.Name = "lbl_AsnadNum";
			this.lbl_AsnadNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_AsnadNum.Size = new System.Drawing.Size(118, 20);
			this.lbl_AsnadNum.TabIndex = 44;
			this.lbl_AsnadNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label26.AutoSize = true;
			this.Label26.ForeColor = System.Drawing.Color.Black;
			this.Label26.Location = new System.Drawing.Point(570, 6);
			this.Label26.Name = "Label26";
			this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label26.Size = new System.Drawing.Size(82, 13);
			this.Label26.TabIndex = 42;
			this.Label26.Text = ": جمع مبلغ اسناد";
			this.Label28.AutoSize = true;
			this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f);
			this.Label28.ForeColor = System.Drawing.Color.Black;
			this.Label28.Location = new System.Drawing.Point(956, 5);
			this.Label28.Name = "Label28";
			this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label28.Size = new System.Drawing.Size(64, 13);
			this.Label28.TabIndex = 40;
			this.Label28.Text = ": تعداد اسناد";
			this.dtg_AsnadList.AllowUserToAddRows = false;
			this.dtg_AsnadList.AllowUserToDeleteRows = false;
			this.dtg_AsnadList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtg_AsnadList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
			this.dtg_AsnadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_AsnadList.DefaultCellStyle = dataGridViewCellStyle2;
			this.dtg_AsnadList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_AsnadList.Location = new System.Drawing.Point(1, 46);
			this.dtg_AsnadList.MultiSelect = false;
			this.dtg_AsnadList.Name = "dtg_AsnadList";
			this.dtg_AsnadList.ReadOnly = true;
			this.dtg_AsnadList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_AsnadList.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dtg_AsnadList.RowTemplate.Height = 44;
			this.dtg_AsnadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_AsnadList.Size = new System.Drawing.Size(1180, 419);
			this.dtg_AsnadList.TabIndex = 12;
			this.txt_Roonevesht.Location = new System.Drawing.Point(882, 130);
			this.txt_Roonevesht.Name = "txt_Roonevesht";
			this.txt_Roonevesht.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_Roonevesht.Size = new System.Drawing.Size(560, 20);
			this.txt_Roonevesht.TabIndex = 79;
			this.lbl_User.AutoSize = true;
			this.lbl_User.BackColor = System.Drawing.Color.White;
			this.lbl_User.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.lbl_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_User.Location = new System.Drawing.Point(197, 217);
			this.lbl_User.Name = "lbl_User";
			this.lbl_User.Size = new System.Drawing.Size(74, 26);
			this.lbl_User.TabIndex = 161;
			this.lbl_User.Text = "Label6";
			this.lbl_User.Visible = false;
			this.chk_SabtNashode.AutoSize = true;
			this.chk_SabtNashode.Location = new System.Drawing.Point(1163, 47);
			this.chk_SabtNashode.Name = "chk_SabtNashode";
			this.chk_SabtNashode.Size = new System.Drawing.Size(15, 14);
			this.chk_SabtNashode.TabIndex = 162;
			this.chk_SabtNashode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.chk_SabtNashode.UseVisualStyleBackColor = true;
			this.Label6.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label6.Font = new System.Drawing.Font("B Titr", 6.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label6.Location = new System.Drawing.Point(1156, 4);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(26, 60);
			this.Label6.TabIndex = 163;
			this.Label6.Text = "ثبت نشده";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new System.Drawing.Size(1184, 711);
			base.ControlBox = false;
			base.Controls.Add(this.chk_SabtNashode);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.lbl_User);
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.pnl_Asnad);
			base.Controls.Add(this.dtg_AsnadList);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "Frm_AsnadList";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "لیست اسناد";
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.pnl_Asnad.ResumeLayout(false);
			this.pnl_Asnad.PerformLayout();
			this.Panel8.ResumeLayout(false);
			this.Panel8.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadList).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();

            this.txt_BahaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BahaFltr_KeyDown);
            this.txt_AmaliatFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AmaliatFltr_KeyDown);
            this.txt_Comment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Comment_KeyDown);
            this.txt_Comment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Comment_KeyUp);
            this.txt_Comment.TextChanged += new System.EventHandler(this.txt_Comment_TextChanged);
            this.dtg_AsnadList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Asnad_CellClick);
            this.dtg_AsnadList.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadList_CellContentDoubleClick);
            this.dtg_AsnadList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadList_CellDoubleClick);
            this.dtg_AsnadList.Click += new System.EventHandler(this.dtg_AsnadList_Click);
            this.dtg_AsnadList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_AsnadList_KeyDown);
            this.dtg_AsnadList.SelectionChanged += new System.EventHandler(this.dtg_Asnad_SelectionChanged);
            this.dtg_AsnadList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dtg_AsnadList_MouseDown);
            this.dtg_AsnadList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtg_AsnadList_CellMouseDown);
            this.dtg_AsnadList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadList_CellContentClick);
            this.dtg_AsnadList.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.dtg_AsnadList_MouseWheel);
            this.txt_JobNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_JobNo_KeyDown);
            this.txt_JobNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_JobNo_KeyUp);
            this.txt_JobNo.TextChanged += new System.EventHandler(this.txt_JobNo_TextChanged);
            this.txt_SanadNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SanadNoFltr_KeyDown);
            this.txt_JobNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_JobNoFltr_KeyDown);
            this.txt_KarfarmaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaFltr_KeyDown);
            this.txt_ProjectFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectFltr_KeyDown);
            this.txt_ProjectFltr.TextChanged += new System.EventHandler(this.txt_ProjectFltr_TextChanged);
            this.txt_SanadDateFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SanadDateFltr_KeyDown);
            this.txt_CommentFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CommentFltr_KeyDown);
            this.cmbo_SanadNoa.GotFocus += new System.EventHandler(this.cmbo_SanadNoa_GotFocus);
            this.cmbo_SanadNoa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_NoaSanad_KeyUp);
            this.cmbo_SanadNoa.Leave += new System.EventHandler(this.cmbo_SanadNoa_Leave);
            this.cmbo_SanadNoa.SelectedIndexChanged += new System.EventHandler(this.cmbo_NoaSanad_SelectedIndexChanged);
            this.cmbo_SanadNoa.TextChanged += new System.EventHandler(this.cmbo_NoaSanad_TextChanged);
            this.cmbo_NoaSanadFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_NoaSanadFltr_SelectedIndexChanged);
            this.cmbo_FehrestName.GotFocus += new System.EventHandler(this.cmbo_FehrestName_GotFocus);
            this.cmbo_FehrestName.TextChanged += new System.EventHandler(this.cmbo_FehrestName_TextChanged);
            this.cmbo_FehrestName.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestName_SelectedIndexChanged);
            this.cmbo_FehrestName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_FehrestName_KeyDown);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.Btn_Save.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Btn_Save_KeyDown);
            this.cmbo_FehrestFltr.GotFocus += new System.EventHandler(this.cmbo_FehrestFltr_GotFocus);
            this.cmbo_FehrestFltr.Leave += new System.EventHandler(this.cmbo_FehrestFltr_Leave);
            this.cmbo_FehrestFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestFltr_SelectedIndexChanged);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Copy.Click += new System.EventHandler(this.btn_copy_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.lbl_Baha.TextChanged += new System.EventHandler(this.lbl_Baha_TextChanged);
            this.cmbo_SalMali.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_SalMali_KeyDown);
            this.cmbo_SalMali.TextChanged += new System.EventHandler(this.cmbo_SalMali_TextChanged);
            this.cmbo_SalMali.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_SalMali_KeyUp);
            this.cmbo_SalMali.Leave += new System.EventHandler(this.cmbo_SalMali_Leave);
            this.cmbo_SalMali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbo_SalMali_KeyPress);
            this.cmbo_SalMali.SelectedIndexChanged += new System.EventHandler(this.cmbo_SalMali_SelectedIndexChanged);
            this.cmbo_OnvanCode.GotFocus += new System.EventHandler(this.cmbo_OnvanCode_GotFocus);
            this.cmbo_OnvanCode.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.cmbo_OnvanCode_HelpRequested);
            this.cmbo_OnvanCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_OnvanCode_KeyUp);
            this.cmbo_OnvanCode.Leave += new System.EventHandler(this.cmbo_OnvanCode_Leave);
            this.cmbo_OnvanCode.TextChanged += new System.EventHandler(this.cmbo_OnvanCode_TextChanged);
            this.cmbo_OnvanCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbo_OnvanCode_KeyPress);
            this.cmbo_OnvanCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_OnvanCode_SelectedIndexChanged);
            this.cmbo_OnvanCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_OnvanCode_KeyDown);
            this.cmbo_Amaliat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_Amaliat_KeyDown);
            this.cmbo_Amaliat.Leave += new System.EventHandler(this.cmbo_Amaliat_Leave);
            this.cmbo_Amaliat.TextChanged += new System.EventHandler(this.cmbo_Amaliat_TextChanged);
            this.cmbo_Amaliat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_Amaliat_KeyUp);
            this.cmbo_Amaliat.SelectedIndexChanged += new System.EventHandler(this.cmbo_Amaliat_SelectedIndexChanged);
            this.Btn_Open.Click += new System.EventHandler(this.Btn_Open_Click);
            this.btn_OnvanCode.Click += new System.EventHandler(this.btn_Anavin_Click);
            this.cmbo_SalMaliFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_SalMaliFltr_SelectedIndexChanged);
            this.cmbo_SalMaliFltr.TextChanged += new System.EventHandler(this.cmbo_SalMaliFltr_TextChanged);
            this.btn_projectSearch.Click += new System.EventHandler(this.btn_projectSearch_Click);
            this.btn_KarfarmaSearch.Click += new System.EventHandler(this.btn_KarfarmaSearch_Click);
            this.txt_Project.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Project_KeyDown);
            this.txt_Project.Leave += new System.EventHandler(this.txt_Project_Leave);
            this.txt_Project.TextChanged += new System.EventHandler(this.txt_Project_TextChanged);
            this.txt_Project.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Project_KeyUp);
            this.txt_Karfarma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Karfarma_KeyDown);
            this.txt_Karfarma.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Karfarma_KeyUp);
            this.txt_Karfarma.Leave += new System.EventHandler(this.txt_Karfarma_Leave);
            this.txt_Karfarma.TextChanged += new System.EventHandler(this.txt_Karfarma_TextChanged);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.txt_SanadNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SanadNo_KeyDown);
            this.txt_SanadNo.TextChanged += new System.EventHandler(this.txt_SanadNo_TextChanged_1);
            this.chk_SabtNashode.CheckedChanged += new System.EventHandler(this.chk_SabtNashode_CheckedChanged);
        }
	}
}
