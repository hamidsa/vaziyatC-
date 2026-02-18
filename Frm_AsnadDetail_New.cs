using GeoBaha.My;
using JntNum2Text;
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
    public partial class Frm_AsnadDetail_New : Form
    {
        public struct SanadSumDetailes
		{
			public int recnum;

			public string sanadnum;

			public int Radif;

			public string Sharh;

			public string Noa;

			public string Darsad;

			public string Mablagh;
		}

        // Private fields
        private byte Nsit;
        private byte SetItemNomFocus;
        private byte SetDarsadMablaghFocus;
        private byte DtgAsnadDetailRefresh;
        private string Btn_AsnadDetailSit;
        private string ItemNo_Filter;
        private string ItemFasl_Filter;
        private string ItemNoa_Filter;
        private string ItemSharh_Filter;
        private string ItemVahed_Filter;
        private string ItemBahavahed_Filter;
        private string ItemTedad_Filter;
        private string ItemBahaKol_Filter;
        private string DarsadMeghdar_Filter;
        private string DarsadItem_Filter;
        private string DarsadMablagh_Filter;
        private string DarsadItemBaha;
        private string Tozihat_Filter;
        private string ItemSearch;
        private double SumFosoolWithZarib;
        private double SumFosoolNoZarib;
        private string GhabelPardakht;
        private int IdNo;
        private string BtnCommand1;
        private byte LoadDtgAsnadDetail;
        private byte LoadDtgAsnadSanadSum;
        private byte ExitFrmAsnadDetail;
        private bool fopf;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_AsnadDetail_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_AsnadDetail_New_KeyDown;
            this.Load += Frm_AsnadDetail_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

private void Frm_AsnadDetail_New_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void Frm_AsnadDetail_New_Load(object sender, EventArgs e)
		{
			DtgAsnadDetailRefresh = 0;
			TableSanadSum.Columns.AddRange(new DataColumn[8]
			{
				new DataColumn("recnum", typeof(int)),
				new DataColumn("SanadNo", typeof(string)),
				new DataColumn("ردیف", typeof(string)),
				new DataColumn("شرح", typeof(string)),
				new DataColumn("نوع", typeof(string)),
				new DataColumn("درصد", typeof(decimal)),
				new DataColumn("مبلغ", typeof(decimal)),
				new DataColumn("مانده", typeof(decimal))
			});
			TableFosoolSum.Columns.AddRange(new DataColumn[7]
			{
				new DataColumn("sanadnum", typeof(string)),
				new DataColumn("ردیف", typeof(string)),
				new DataColumn("فصل", typeof(string)),
				new DataColumn("شرح", typeof(string)),
				new DataColumn("جمع_بدون_ضریب", typeof(decimal)),
				new DataColumn("ضریب", typeof(decimal)),
				new DataColumn("جمع_با_ضریب", typeof(decimal))
			});
			lbl_SanadNo.Text = Module1.SanadNoSelected;
			base.KeyPreview = true;
			pnl_SanadSum.Visible = false;
			dtg_SanadSum.Height = 160;
			pnl_MablaghKol.Visible = true;
			Btn_AsnadDetailSit = "";
			cmbo_ItemNoaFltr.Items.Clear();
			cmbo_ItemNoaFltr.Items.Add("بها دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی");
			cmbo_ItemNoaFltr.Items.Add("ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی - ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("توافقی");
			cmbo_ItemNoaFltr.Items.Add("");
			cmbo_SumSharh.Items.Clear();
			if (Operators.CompareString(Module1.SanadRec.fehrestfile, "FEHBAHA1401", TextCompare: false) == 0)
			{
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/47 فصول اول تا سوم بخشنامه 1403/129444");
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/50 فصل چهارم بخشنامه 1403/129444");
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/55 فصول پنجم و ششم بخشنامه 1403/129444");
			}
			cmbo_SumSharh.Items.Add("مالیات و عوارض");
			cmbo_SumSharh.Items.Add("تخفیف");
			cmbo_SumSharh.Items.Add("کسر می شود پیش پرداخت");
			cmbo_SumSharh.Items.Add(" کسر می شود صورت وضعیت موقت شماره");
			cmbo_SumSharh.Items.Add("سایر موارد");
			cmbo_SumNoa.Items.Clear();
			cmbo_SumNoa.Items.Add("درصد");
			cmbo_SumNoa.Items.Add("مقطوع");
			switch (Module1.SanadRec.NoaSanad.Trim())
			{
			case "فاکتور":
				fopf = true;
				Module1.NoaSanad = "فاکتور";
				Text = "فاکتور شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "پیش فاکتور":
				fopf = false;
				Module1.NoaSanad = "پیش فاکتور";
				Text = "پیش فاکتور شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "صوری":
				Module1.soori = 1;
				Module1.Ghaleb = 0;
				fopf = Module1.SanadRec.forpf;
				Module1.NoaSanad = "صوری";
				Text = "فاکتور صوری شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "قالب":
				Module1.Ghaleb = 1;
				Module1.soori = 0;
				fopf = Module1.SanadRec.forpf;
				Module1.NoaSanad = "قالب";
				Text = "قالب شماره : " + Module1.SanadRec.sanadnum;
				break;
			}
			Load_dtg_AsnadDetail(Module1.SanadNoSelected);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			foreach (Control control7 in pnl_Item.Controls)
			{
				if (control7 is TextBox || control7 is ComboBox || control7 is Button)
				{
					control7.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control7.KeyDown += GeneralKeyDownHandler1;
				}
				if (control7 is TextBox || control7 is Button)
				{
					control7.KeyDown += GeneralKeyDownHandler2;
				}
			}
			foreach (Control control8 in pnl_SanadSum.Controls)
			{
				if (control8 is TextBox || control8 is ComboBox || control8 is Button)
				{
					control8.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control8.KeyDown += GeneralKeyDownHandler1;
				}
				if (control8 is TextBox || control8 is Button)
				{
					control8.KeyDown += GeneralKeyDownHandler2;
				}
			}
			DtgAsnadDetailRefresh = 1;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ShomareSanad] FROM [Dabirkhane].[dbo].[SoratVazeyatGharardadha] Where [ShomareSanad] = '" + Module1.SanadNoSelected + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(" .سند توسط امور قراردادها ثبت شده است تغییرات ممکن نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Module1.SanadSabtGharardadha = true;
				foreach (Control control9 in pnl_Item.Controls)
				{
					if (!(control9 is Button))
					{
						control9.Enabled = false;
					}
				}
				foreach (Control control10 in pnl_SanadSum.Controls)
				{
					if (!(control10 is Button))
					{
						control10.Enabled = false;
					}
				}
				btn_Modify1.Visible = false;
			}
			else
			{
				Module1.SanadSabtGharardadha = false;
				foreach (Control control11 in pnl_Item.Controls)
				{
					if (!(control11 is Button))
					{
						control11.Enabled = true;
					}
				}
				foreach (Control control12 in pnl_SanadSum.Controls)
				{
					if (!(control12 is Button))
					{
						control12.Enabled = true;
					}
				}
				btn_Modify1.Visible = true;
			}
			sqlDataReader.Close();
		}

private void GeneralKeyDownHandler1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
			}
			if (SetItemNomFocus == 1)
			{
				txt_ItemNo.Text = "";
				txt_ItemNo.Focus();
				SetItemNomFocus = 0;
			}
			else if (SetItemNomFocus == 2)
			{
				Btn_Return.Focus();
				SetDarsadMablaghFocus = 0;
			}
			if (SetDarsadMablaghFocus == 1)
			{
				txt_DarsadMablagh.Text = "";
				txt_DarsadMablagh.Focus();
				SetDarsadMablaghFocus = 0;
			}
			else if (SetDarsadMablaghFocus == 2)
			{
				cmbo_DarsadItem.Focus();
				SetDarsadMablaghFocus = 0;
			}
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadDetail.Focus();
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
			foreach (Control control4 in pnl_SanadSum.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

private void ShowItemRecord()
		{
			int index = 0;
			int lErl = default(int);
			if (dtg_AsnadDetail.RowCount != 0)
			{
				try
				{
					index = dtg_AsnadDetail.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Module1.DatePikerSit = false;
				if (dtg_AsnadDetail.RowCount != 0)
				{
					Module1.ItemRec.recnum = Conversions.ToInteger(dtg_AsnadDetail.Rows[index].Cells[0].Value);
					Module1.ItemRec.Radif = dtg_AsnadDetail.Rows[index].Cells[2].Value.ToString();
					Module1.ItemRec.sanadnum = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[3].Value);
					Module1.ItemRec.itemnum = dtg_AsnadDetail.Rows[index].Cells[4].Value.ToString();
					Module1.ItemRec.fasl = dtg_AsnadDetail.Rows[index].Cells[5].Value.ToString();
					Module1.ItemRec.ItemNoa = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[6].Value);
					switch (Module1.ItemRec.ItemNoa.Trim())
					{
					case "بها دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("0");
						Module1.ItemRec.setarehdar = Conversions.ToByte("0");
						break;
					case "درصدی":
						Module1.ItemRec.darsadi = Conversions.ToByte("1");
						Module1.ItemRec.setarehdar = Conversions.ToByte("0");
						break;
					case "ستاره دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("0");
						Module1.ItemRec.setarehdar = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("1");
						Module1.ItemRec.setarehdar = Conversions.ToByte("1");
						break;
					}
					Module1.ItemRec.sharhitem = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[7].Value);
					Module1.ItemRec.shvahed = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[8].Value);
					Module1.ItemRec.ghvahed = dtg_AsnadDetail.Rows[index].Cells[9].Value.ToString();
					Module1.ItemRec.total = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[10].Value);
					Module1.ItemRec.mablagh = dtg_AsnadDetail.Rows[index].Cells[11].Value.ToString();
					Module1.ItemRec.DarsadMeghdar = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[12].Value);
					Module1.ItemRec.DarsadItem = dtg_AsnadDetail.Rows[index].Cells[13].Value.ToString();
					Module1.ItemRec.DarsadMablagh = dtg_AsnadDetail.Rows[index].Cells[14].Value.ToString();
					switch (Module1.ItemRec.DarsadMablagh.Trim())
					{
					case "0":
						Module1.ItemRec.Mablaghi = Conversions.ToByte("0");
						break;
					case null:
					case "":
						Module1.ItemRec.Mablaghi = Conversions.ToByte("0");
						break;
					default:
						Module1.ItemRec.Mablaghi = Conversions.ToByte("1");
						break;
					}
					Module1.ItemRec.molahezat = dtg_AsnadDetail.Rows[index].Cells[15].Value.ToString();
					txt_ItemNo.Text = Module1.ItemRec.itemnum;
					cmbo_ItemFasl.Text = Module1.ItemRec.fasl;
					lbl_ItemNoa.Text = Module1.ItemRec.ItemNoa;
					txt_ItemSharh.Text = Module1.ItemRec.sharhitem;
					cmbo_ItemVahed.Text = Module1.ItemRec.shvahed;
					txt_ItemBahavahed.Text = Module1.ItemRec.ghvahed;
					txt_ItemTedad.Text = Module1.ItemRec.total;
					if (Operators.CompareString(Module1.ItemRec.mablagh, "", TextCompare: false) != 0)
					{
						txt_ItemBahaKol.Text = Conversions.ToString(Convert.ToInt64(Conversions.ToDouble(Module1.ItemRec.mablagh)));
					}
					txt_DarsadMeghdar.Text = Module1.ItemRec.DarsadMeghdar;
					if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
					{
						LoadCmboDarsadItems();
						if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0))
						{
							cmbo_DarsadItem.Text = ": مبلغ";
							txt_DarsadMablagh.Text = Module1.ItemRec.DarsadMablagh;
						}
						else
						{
							cmbo_DarsadItem.Text = ": ایتم";
							txt_DarsadMablagh.Text = Module1.ItemRec.DarsadItem;
						}
					}
					else
					{
						cmbo_DarsadItem.DataSource = null;
					}
					txt_Tozihat.Text = Module1.ItemRec.molahezat;
				}
			}
			lErl = 60;
		}

private void ShowSanadSumRecord()
		{
			if (ExitFrmAsnadDetail == 1)
			{
				ExitFrmAsnadDetail = 0;
				return;
			}
			ref SanadSumDetailes sanadSumRec = ref SanadSumRec;
			int num;
			int lErl = default(int);
			try
			{
				num = dtg_SanadSum.CurrentRow.Index;
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				num = 0;
				ProjectData.ClearProjectError();
			}
			if (dtg_SanadSum.RowCount == 1 || num == 0)
			{
				BtnCommand1 = "New";
				sanadSumRec.recnum = Conversions.ToInteger("0");
				sanadSumRec.sanadnum = lbl_SanadNo.Text;
				sanadSumRec.Radif = Conversions.ToInteger("0");
				sanadSumRec.Sharh = "جمع سند با ضریب";
				sanadSumRec.Noa = "";
				sanadSumRec.Darsad = "0";
				sanadSumRec.Mablagh = Conversions.ToString(SumFosoolWithZarib);
				txt_SumRadif.Text = "0";
				cmbo_SumSharh.Text = "جمع سند با ضریب";
				cmbo_SumNoa.Text = "";
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				lbl_SumMande.Text = Conversions.ToString(SumFosoolWithZarib);
				txt_SumRadif.Enabled = false;
				cmbo_SumSharh.Enabled = false;
				cmbo_SumNoa.Enabled = false;
				txt_SumDarsad.Enabled = false;
				txt_SumMablagh.Enabled = false;
				foreach (Control control in pnl_SanadSum.Controls)
				{
					if (((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox)))
					{
						control.ForeColor = Color.Black;
					}
				}
				pnl_SanadSum.BackColor = Color.LightSteelBlue;
			}
			else
			{
				txt_SumRadif.Enabled = true;
				cmbo_SumSharh.Enabled = true;
				cmbo_SumNoa.Enabled = true;
				txt_SumDarsad.Enabled = true;
				txt_SumMablagh.Enabled = true;
				BtnCommand1 = "";
				checked
				{
					if (dtg_SanadSum.RowCount != 0)
					{
						int index = dtg_SanadSum.CurrentRow.Index;
						sanadSumRec.recnum = Conversions.ToInteger(dtg_SanadSum.Rows[index].Cells[0].Value);
						sanadSumRec.sanadnum = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[1].Value.ToString();
						sanadSumRec.Radif = Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[2].Value.ToString());
						sanadSumRec.Sharh = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[3].Value.ToString();
						sanadSumRec.Noa = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[4].Value.ToString();
						sanadSumRec.Darsad = Conversions.ToString(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[5].Value);
						txt_SumRadif.Text = Conversions.ToString(sanadSumRec.Radif);
						cmbo_SumSharh.Text = sanadSumRec.Sharh;
						cmbo_SumNoa.Text = sanadSumRec.Noa;
						txt_SumDarsad.Text = sanadSumRec.Darsad;
						if (dtg_SanadSum.CurrentRow.Index != 0)
						{
							string left = sanadSumRec.Noa.Trim();
							if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
							{
								if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
								{
									sanadSumRec.Mablagh = Conversions.ToString(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[6].Value);
									txt_SumMablagh.Enabled = true;
									txt_SumDarsad.Text = "";
									txt_SumDarsad.Enabled = false;
								}
							}
							else
							{
								sanadSumRec.Mablagh = Math.Truncate(Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(sanadSumRec.Darsad, dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index - 1].Cells[7].Value), 100))).ToString();
								txt_SumMablagh.Enabled = false;
							}
							txt_SumMablagh.Text = Strings.FormatNumber(Conversions.ToLong(sanadSumRec.Mablagh), 0, TriState.True);
							lbl_SumMande.Text = Strings.FormatNumber(Operators.AddObject(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index - 1].Cells[7].Value, Conversions.ToDouble(sanadSumRec.Mablagh)), 0, TriState.True);
						}
					}
				}
			}
			lErl = 10;
		}

private void dtg_AsnadDetail_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

private void dtg_AsnadDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

private void dtg_AsnadDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.P)
			{
				btn_Print_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_ItemNo.Focus();
				e.SuppressKeyPress = true;
			}
		}

private void dtg_AsnadDetail_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
		}

private void dtg_AsnadDetail_SelectionChanged(object sender, EventArgs e)
		{
			SetItemNomFocus = 0;
			if ((LoadDtgAsnadDetail == 1) | (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0))
			{
				ShowItemRecord();
				SetPnl_ItemBlue();
				return;
			}
			if (pnl_Item.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				switch (dialogResult)
				{
				case DialogResult.No:
					SetPnl_ItemBlue();
					break;
				case DialogResult.Cancel:
					txt_ItemNo.Focus();
					return;
				}
			}
			ShowItemRecord();
		}

private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemNoaFltr.Text;
				switch (text.Trim())
				{
				case "بها دار":
					ItemNoa_Filter = " ([darsad] Like '0'And [setarehdar] Like '0')";
					break;
				case "درصدی":
					ItemNoa_Filter = " ([darsad] Like '1'And [setarehdar] Like '0')";
					break;
				case "ستاره دار":
					ItemNoa_Filter = " ([darsad] Like '0'And [setarehdar] Like '1')";
					break;
				case "درصدی - ستاره دار":
					ItemNoa_Filter = " ([darsad] Like '1'And [setarehdar] Like '1')";
					break;
				case null:
				case "":
					ItemNoa_Filter = "";
					break;
				}
			}
			else
			{
				ItemNoa_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

public void Load_dtg_FosoolSum()
		{
			TableFosoolSum.Clear();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = " SELECT sanadnum,fasl As 'ردیف', fasl As 'فصل' ,(SELECT [FaslComment] FROM [dbo].[Fosool] where FehrestFile ='" + Module1.CurrentFehrestFile + "' and FaslCode =fasl) As 'شرح' ,Sum([mablagh]) As 'جمع_بدون_ضریب' ,(SELECT Cast([ZaribCode] As float) FROM [dbo].[Fosool] where FehrestFile ='" + Module1.CurrentFehrestFile + "' and FaslCode =fasl) As 'ضریب' ,(SELECT CAST([mablaghk] AS FLOAT) FROM [dbo].[Asnad1] where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fehrestfile]='" + Module1.CurrentFehrestFile + "' And [forpf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "') As 'جمع_با_ضریب'  FROM [dbo].[Asnad2] Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' Group by [sanadnum],[fasl] Order by [sanadnum],[fasl]";
			int lErl = 1;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			TableFosoolSum.Load(sqlDataReader);
			sqlDataReader.Close();
			foreach (DataColumn column in TableFosoolSum.Columns)
			{
				column.ReadOnly = false;
			}
			SumFosoolWithZarib = 0.0;
			SumFosoolNoZarib = 0.0;
			checked
			{
				int num = TableFosoolSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					TableFosoolSum.Rows[i]["ردیف"] = i + 1;
					try
					{
						object left = TableFosoolSum.Rows[i]["ضریب"];
						if (Operators.ConditionalCompareObjectEqual(left, 0, TextCompare: false))
						{
							TableFosoolSum.Rows[i]["ضریب"] = "1";
						}
						else if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, 1, TextCompare: false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 3, TextCompare: false))))
						{
							TableFosoolSum.Rows[i]["ضریب"] = Module1.Zarib_1;
						}
						else if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, 2, TextCompare: false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 4, TextCompare: false))))
						{
							TableFosoolSum.Rows[i]["ضریب"] = Module1.Zarib_2;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, lErl);
						Exception ex2 = ex;
						TableFosoolSum.Rows[i]["ضریب"] = "1";
						ProjectData.ClearProjectError();
					}
					TableFosoolSum.Rows[i]["جمع_با_ضریب"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[1] { Operators.MultiplyObject(TableFosoolSum.Rows[i]["جمع_بدون_ضریب"], TableFosoolSum.Rows[i]["ضریب"]) }, null, null, null));
					SumFosoolNoZarib = Conversions.ToDouble(Operators.AddObject(SumFosoolNoZarib, TableFosoolSum.Rows[i]["جمع_بدون_ضریب"]));
					SumFosoolWithZarib = Conversions.ToDouble(Operators.AddObject(SumFosoolWithZarib, TableFosoolSum.Rows[i]["جمع_با_ضریب"]));
				}
				DataRow dataRow = TableFosoolSum.NewRow();
				dataRow["sanadnum"] = "0";
				dataRow["ردیف"] = "";
				dataRow["فصل"] = "";
				dataRow["شرح"] = "جمع فصول";
				dataRow["جمع_بدون_ضریب"] = SumFosoolNoZarib;
				dataRow["جمع_با_ضریب"] = SumFosoolWithZarib;
				TableFosoolSum.Rows.Add(dataRow);
				dtg_FosoolSum.DataSource = TableFosoolSum;
				dtg_FosoolSum.Columns[4].DefaultCellStyle.Format = "N0";
				dtg_FosoolSum.Columns[5].DefaultCellStyle.Format = "C3";
				dtg_FosoolSum.Columns[6].DefaultCellStyle.Format = "N0";
				dtg_FosoolSum.Columns[0].Width = 0;
				dtg_FosoolSum.Columns[0].Visible = false;
				dtg_FosoolSum.Columns[1].Width = 35;
				dtg_FosoolSum.Columns[2].Width = 35;
				dtg_FosoolSum.Columns[3].Width = 222;
				dtg_FosoolSum.Columns[4].Width = 100;
				dtg_FosoolSum.Columns[5].Width = 50;
				dtg_FosoolSum.Columns[6].Width = 100;
				dtg_FosoolSum.Refresh();
				Module1.dtg_Color(dtg_FosoolSum);
				foreach (object column2 in dtg_FosoolSum.Columns)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(column2);
					NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
				}
			}
		}

public void Load_dtg_SanadSum()
		{
			double num = Conversions.ToDouble(lbl_SanadZarib1.Text);
			double num2 = Conversions.ToDouble(lbl_SanadZarib2.Text);
			TableSanadSum.Clear();
			LoadDtgAsnadSanadSum = 1;
			foreach (DataColumn column in TableSanadSum.Columns)
			{
				column.ReadOnly = false;
			}
			DataRow dataRow = TableSanadSum.NewRow();
			dataRow["recnum"] = 0;
			dataRow["SanadNo"] = lbl_SanadNo.Text;
			dataRow["ردیف"] = 0;
			dataRow["شرح"] = "جمع سند با ضریب";
			dataRow["نوع"] = "";
			dataRow["درصد"] = 0;
			dataRow["مبلغ"] = SumFosoolWithZarib;
			dataRow["مانده"] = SumFosoolWithZarib;
			TableSanadSum.Rows.Add(dataRow);
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "Select [recnum],[sanadnum],[recnum] As 'ردیف',[Sharh] As 'شرح',[darsad] As 'نوع',[Darsad] As 'درصد',Cast([mablagh] As decimal(18,2)) As 'مبلغ', Cast([mablaghk] As numeric(18,2)) As 'مانده' FROM [dbo].[asnad4] Where sanadnum ='" + lbl_SanadNo.Text + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' And ([darsad] <> '0' or [maghtoo] <> '0') Order by [recnum]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				if (sqlDataReader.HasRows)
				{
					while (sqlDataReader.Read())
					{
						DataRow dataRow2 = TableSanadSum.NewRow();
						dataRow2["recnum"] = sqlDataReader[0].ToString();
						dataRow2["SanadNo"] = sqlDataReader[1].ToString();
						dataRow2["ردیف"] = sqlDataReader[2].ToString();
						dataRow2["شرح"] = sqlDataReader[3].ToString();
						if (Operators.CompareString(sqlDataReader[5].ToString().Trim(), "0", TextCompare: false) != 0)
						{
							dataRow2["نوع"] = "درصد";
						}
						else
						{
							dataRow2["نوع"] = "مقطوع";
						}
						dataRow2["درصد"] = RuntimeHelpers.GetObjectValue(sqlDataReader[5]);
						dataRow2["مبلغ"] = RuntimeHelpers.GetObjectValue(sqlDataReader[6]);
						dataRow2["مانده"] = RuntimeHelpers.GetObjectValue(sqlDataReader[7]);
						TableSanadSum.Rows.Add(dataRow2);
					}
					sqlDataReader.Close();
					TableSanadSum.Rows[0]["مانده"] = SumFosoolWithZarib;
					int num3 = TableSanadSum.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						TableSanadSum.Rows[i]["ردیف"] = i;
						if (i != 0)
						{
							if (Operators.CompareString(TableSanadSum.Rows[i]["درصد"].ToString(), "0", TextCompare: false) != 0)
							{
								TableSanadSum.Rows[i]["مبلغ"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Truncate", new object[1] { Operators.DivideObject(Operators.MultiplyObject(TableSanadSum.Rows[i]["درصد"], TableSanadSum.Rows[i - 1]["مانده"]), 100) }, null, null, null));
							}
							switch (TableSanadSum.Rows[i]["شرح"].ToString())
							{
							case "تعديل بابت ضريب 1/47 فصول اول تا سوم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.47 * (num * (SumFasl("1") + SumFasl("2")) + SumFasl("3"));
								break;
							case "تعديل بابت ضريب 1/50 فصل چهارم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.5 * SumFasl("4");
								break;
							case "تعديل بابت ضريب 1/55 فصول پنجم و ششم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.55 * (num2 * SumFasl("5") + num * SumFasl("6"));
								break;
							}
							TableSanadSum.Rows[i]["مانده"] = Operators.AddObject(TableSanadSum.Rows[i - 1]["مانده"], TableSanadSum.Rows[i]["مبلغ"]);
						}
					}
				}
				dtg_SanadSum.DataSource = TableSanadSum;
				dtg_SanadSum.Columns[6].DefaultCellStyle.Format = "N0";
				dtg_SanadSum.Columns[7].DefaultCellStyle.Format = "N0";
				dtg_SanadSum.Columns[0].Visible = false;
				dtg_SanadSum.Columns[1].Visible = false;
				dtg_SanadSum.Columns[2].Width = 40;
				dtg_SanadSum.Columns[3].Width = 190;
				dtg_SanadSum.Columns[4].Width = 40;
				dtg_SanadSum.Columns[5].Width = 70;
				dtg_SanadSum.Columns[6].Width = 100;
				dtg_SanadSum.Columns[7].Width = 100;
				GhabelPardakht = Conversions.ToString(TableSanadSum.Rows[TableSanadSum.Rows.Count - 1]["مانده"]);
				lbl_MablaghKol1.Text = Strings.FormatNumber(GhabelPardakht, 0, TriState.True);
				lbl_MablaghKol2.Text = "( " + Num2Text.ToFarsi(Conversions.ToLong(lbl_MablaghKol1.Text)) + "  ریال )";
				lbl_GhabelPardakht.Text = "       " + lbl_MablaghKol2.Text + "       " + lbl_MablaghKol1.Text;
				foreach (object column2 in dtg_SanadSum.Columns)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(column2);
					NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
				}
				dtg_SanadSum.Rows[0].ReadOnly = true;
				Module1.dtg_Color(dtg_SanadSum);
				int num4 = dtg_SanadSum.Columns.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					dtg_SanadSum.Rows[0].Cells[j].Style.BackColor = Color.SteelBlue;
					dtg_SanadSum.Rows[0].Cells[j].Style.ForeColor = Color.White;
				}
				LoadDtgAsnadSanadSum = 0;
			}
		}

private void dtg_SanadSum_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_SanadSum.CurrentCell.RowIndex == 0)
			{
				dtg_SanadSum.CurrentCell.Selected = false;
				BtnCommand1 = "New";
			}
			else
			{
				BtnCommand1 = "";
			}
			if (pnl_SanadSum.Visible)
			{
				ShowSanadSumRecord();
			}
		}

private void dtg_SanadSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_SanadSum.CurrentCell.RowIndex == 0)
			{
				dtg_SanadSum.CurrentCell.Selected = false;
				BtnCommand1 = "New";
			}
			else
			{
				BtnCommand1 = "";
			}
			if (pnl_SanadSum.Visible)
			{
				ShowSanadSumRecord();
			}
		}

public void Load_dtg_AsnadDetail(string SanadNo)
		{
			LoadDtgAsnadDetail = 1;
			AsnadDetailTable.Clear();
			string[] array = new string[12];
			int lErl = default(int);
			try
			{
				Module1.CurrRow = dtg_AsnadDetail.CurrentRow.Index;
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
				if (Operators.CompareString(ItemNo_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0 && Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
				{
					array[11] = " And ";
				}
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemFasl_Filter + array[2] + ItemNoa_Filter + array[3] + ItemSharh_Filter + array[4] + ItemVahed_Filter + array[5] + ItemBahavahed_Filter + array[6] + ItemTedad_Filter + array[7] + ItemBahaKol_Filter + array[8] + DarsadMeghdar_Filter + array[9] + DarsadItem_Filter + array[10] + DarsadMablagh_Filter + array[11] + Tozihat_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " Where sanadnum ='" + SanadNo + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				}
				else
				{
					Module1.strWhere = Module1.strWhere + " And sanadnum ='" + SanadNo + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					txt_ItemRadifFltr.Text = "";
				}
				lErl = 10;
				Module1.MyConn.Close();
				Module1.MyConn.Open();
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [recnum] As 'recnum',[radif] As 'ردیف',[radif] As 'ردیف ایتم',[sanadnum] As 'شماره سند', [itemnum] As 'شماره ایتم',[fasl] As 'فصل',Cast([darsad] As varchar(25))+Cast([setarehdar]  As varchar(25)) As 'نوع ایتم', [sharhitem] As 'شرح ایتم', [shvahed] As 'واحد', Cast([ghvahed]  As Float) As 'بهای واحد',Cast([total]  As Float) As 'تعداد', Cast([mablagh] As Float) As 'بهای_کل',[itemdarsad] As 'درصد',[itemname] As 'نسبت به ایتم',[NesbatbeMablagh] As 'نسبت به مبلغ', [molahezat] As 'توضیحات' FROM [dbo].[asnad2]  " + Module1.strWhere + " order by [itemnum],[itemname]";
				lErl = 1;
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				AsnadDetailTable.Load(sqlDataReader);
				sqlDataReader.Close();
				foreach (DataColumn column in AsnadDetailTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = AsnadDetailTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					AsnadDetailTable.Rows[i]["ردیف"] = i + 1;
					object left = AsnadDetailTable.Rows[i]["نوع ایتم"];
					if (Operators.ConditionalCompareObjectEqual(left, "00", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "بها دار";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "10", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "درصدی";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "01", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "ستاره دار";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "11", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "درصدی - ستاره دار";
					}
					AsnadDetailTable.Rows[i]["بهای_کل"] = Strings.Format(Conversions.ToDouble(AsnadDetailTable.Rows[i]["تعداد"].ToString()) * Conversions.ToDouble(AsnadDetailTable.Rows[i]["بهای واحد"].ToString()), "###0");
				}
				dtg_AsnadDetail.DataSource = AsnadDetailTable;
				dtg_AsnadDetail.Columns[9].DefaultCellStyle.Format = "N0";
				dtg_AsnadDetail.Columns[10].DefaultCellStyle.Format = "C2";
				dtg_AsnadDetail.Columns[11].DefaultCellStyle.Format = "N0";
				dtg_AsnadDetail.Columns[0].Visible = false;
				dtg_AsnadDetail.Columns[1].Width = 40;
				dtg_AsnadDetail.Columns[2].Visible = false;
				dtg_AsnadDetail.Columns[3].Visible = false;
				dtg_AsnadDetail.Columns[4].Width = 50;
				dtg_AsnadDetail.Columns[5].Width = 40;
				dtg_AsnadDetail.Columns[6].Width = 60;
				dtg_AsnadDetail.Columns[7].Width = 290;
				dtg_AsnadDetail.Columns[8].Width = 70;
				dtg_AsnadDetail.Columns[9].Width = 80;
				dtg_AsnadDetail.Columns[10].Width = 60;
				dtg_AsnadDetail.Columns[11].Width = 100;
				dtg_AsnadDetail.Columns[12].Width = 50;
				dtg_AsnadDetail.Columns[13].Width = 70;
				dtg_AsnadDetail.Columns[14].Width = 70;
				dtg_AsnadDetail.Columns[15].Width = 200;
				dtg_AsnadDetail.Refresh();
				LoadDtgAsnadDetail = 0;
				Module1.dtg_Color(dtg_AsnadDetail);
				if (DtgAsnadDetailRefresh == 0)
				{
					try
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow].Cells[1];
						ShowItemRecord();
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, lErl);
						Module1.CurrRow = 0;
						ProjectData.ClearProjectError();
						goto IL_11db;
					}
				}
				goto IL_1222;
			}
			IL_11db:
			try
			{
				dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow].Cells[1];
				ShowItemRecord();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
			goto IL_1222;
			IL_1222:
			lErl = 20;
		}

private void txt_ItemNo_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemBahavahed_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemBahavahed_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				if ((Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) != 0))
				{
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
				}
				else
				{
					txt_ItemBahaKol.Text = "";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".بهای واحد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_ItemBahavahed.Text = "";
				}
				else
				{
					txt_ItemTedad.Focus();
				}
				ProjectData.ClearProjectError();
			}
		}

private void txt_ItemTedad_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemTedad_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

private void txt_ItemTedad_KeyUp(object sender, KeyEventArgs e)
		{
			if ((Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) == 0))
			{
				txt_ItemBahaKol.Text = "";
				return;
			}
			try
			{
				txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(txt_ItemTedad.Text) * Conversions.ToDouble(txt_ItemBahavahed.Text), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_ItemTedad.Text = "";
				}
				else
				{
					txt_ItemNo.Focus();
				}
				ProjectData.ClearProjectError();
			}
		}

private void pnl_Item_Leave(object sender, EventArgs e)
		{
		}

private void BlankItemRec()
		{
			txt_ItemTedad.Text = "";
			txt_ItemBahavahed.Text = "";
			txt_ItemBahaKol.Text = "";
			cmbo_ItemVahed.Text = "";
			txt_ItemSharh.Text = "";
			txt_DarsadMeghdar.Text = "";
			cmbo_DarsadItem.Text = "";
			txt_DarsadMablagh.Text = "";
			txt_Tozihat.Text = "";
			ItemSearch = "";
			txt_ItemNo.Text = "";
			Module1.ItemRec.recnum = 0;
			Module1.ItemRec.Radif = "";
			Module1.ItemRec.sanadnum = "";
			Module1.ItemRec.itemnum = "";
			Module1.ItemRec.fasl = "";
			Module1.ItemRec.ItemNoa = "";
			Module1.ItemRec.sharhitem = "";
			Module1.ItemRec.shvahed = "";
			Module1.ItemRec.ghvahed = "";
			Module1.ItemRec.total = "";
			Module1.ItemRec.mablagh = "";
			Module1.ItemRec.DarsadMeghdar = "";
			Module1.ItemRec.DarsadItem = "";
			Module1.ItemRec.DarsadMablagh = "";
			Module1.ItemRec.molahezat = "";
		}

private void btn_Exit_Click(object sender, EventArgs e)
		{
			Module1.BtnKarfarmaList = false;
			Close();
		}

private void Btn_New_Click(object sender, EventArgs e)
		{
		}

private void txt_ItemTedad_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemTedad.Text.Trim(), Module1.ItemRec.total.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_ItemTedad.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemTedad.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void lbl_ItemNoa_TextChanged(object sender, EventArgs e)
		{
			switch (lbl_ItemNoa.Text.Trim())
			{
			case "بها دار":
				cmbo_DarsadItem.Text = "";
				txt_DarsadMeghdar.Text = "";
				txt_ItemBahavahed.Enabled = false;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemTedad.TabIndex = 101;
				Btn_Save.TabIndex = 102;
				break;
			case "درصدی":
			case "درصدي":
				txt_ItemBahavahed.Enabled = false;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = true;
				txt_DarsadMeghdar.Visible = true;
				txt_DarsadMeghdar.Enabled = false;
				cmbo_DarsadItem.Enabled = true;
				cmbo_DarsadItem.Visible = true;
				txt_DarsadMablagh.Visible = true;
				txt_DarsadMeghdar.Text = txt_ItemBahavahed.Text;
				txt_DarsadMablagh.Enabled = true;
				cmbo_DarsadItem.TabIndex = 101;
				txt_ItemTedad.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				break;
			case "ستاره دار":
				txt_ItemTedad.TabIndex = 101;
				txt_ItemBahavahed.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				cmbo_DarsadItem.Text = "";
				txt_DarsadMeghdar.Text = "";
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemTedad.TabIndex = 101;
				txt_ItemBahavahed.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				break;
			case "درصدی - ستاره دار":
			case "درصدي - ستاره دار":
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = true;
				txt_DarsadMeghdar.Visible = true;
				cmbo_DarsadItem.Visible = true;
				txt_DarsadMablagh.Visible = true;
				txt_DarsadMeghdar.Enabled = true;
				cmbo_DarsadItem.Enabled = true;
				txt_DarsadMablagh.Enabled = true;
				txt_DarsadMeghdar.TabIndex = 101;
				cmbo_DarsadItem.TabIndex = 102;
				txt_ItemTedad.TabIndex = 103;
				Btn_Save.TabIndex = 104;
				break;
			case "توافقی":
			case "توافقي":
				txt_ItemNo.Enabled = true;
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = true;
				cmbo_ItemFasl.Enabled = true;
				Module1.Load_Cmbo(cmbo_ItemFasl, "Fosool", "FaslCode", "where [FehrestFile] = '" + Module1.CurrentFehrestFile + "' and [FaslComment] like N'%توافقی%'");
				cmbo_ItemFasl.SelectedIndex = 0;
				txt_ItemSharh.Enabled = true;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Enabled = false;
				cmbo_DarsadItem.Enabled = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemSharh.TabIndex = 101;
				cmbo_ItemVahed.TabIndex = 102;
				txt_ItemTedad.TabIndex = 103;
				txt_ItemBahavahed.TabIndex = 104;
				Btn_Save.TabIndex = 104;
				break;
			}
		}

private void txt_ItemBahavahed_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemBahavahed.Text.Trim(), Module1.ItemRec.ghvahed.Trim(), TextCompare: false) != 0)
				{
					txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemBahavahed.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_Tozihat_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

private void txt_Tozihat_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_Tozihat_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_Tozihat.Text.Trim(), Module1.ItemRec.molahezat.Trim(), TextCompare: false) != 0)
				{
					txt_Tozihat.ForeColor = Color.Red;
				}
				else
				{
					txt_Tozihat.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_Tozihat_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_Tozihat.Text.Trim(), Module1.ItemRec.molahezat.Trim(), TextCompare: false) != 0)
				{
					txt_Tozihat.ForeColor = Color.Red;
				}
				else
				{
					txt_Tozihat.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void cmbo_ItemVahed_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void cmbo_ItemVahed_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void cmbo_ItemVahed_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(cmbo_ItemVahed.Text.Trim(), Module1.ItemRec.shvahed.Trim(), TextCompare: false) != 0)
				{
					cmbo_ItemVahed.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ItemVahed.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void cmbo_ItemVahed_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void txt_ItemSharh_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemSharh_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemSharh_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemSharh.Text.Trim(), Module1.ItemRec.sharhitem.Trim(), TextCompare: false) != 0)
			{
				txt_ItemSharh.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemSharh.ForeColor = Color.Black;
			}
			CheckItemRecChange();
		}

private void txt_DarsadMeghdar_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

private void txt_DarsadMeghdar_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".بهای واحد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_DarsadMeghdar.Text = "";
			}
			try
			{
				txt_ItemBahavahed.Text = (Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha)).ToString();
				txt_ItemBahaKol.Text = (Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text)).ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_DarsadMeghdar_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_DarsadMeghdar.Text.Trim(), Module1.ItemRec.DarsadMeghdar.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_DarsadMeghdar.ForeColor = Color.Red;
				}
				else
				{
					txt_DarsadMeghdar.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_DarsadMeghdar_TextChanged(object sender, EventArgs e)
		{
		}

public void CheckItemRecChange()
		{
			foreach (Control control in pnl_Item.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && control.ForeColor == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					return;
				}
			}
			SetPnl_ItemBlue();
		}

private void Btn_Return1_Click(object sender, EventArgs e)
		{
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					btn_Save1_Click(RuntimeHelpers.GetObjectValue(sender), e);
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
				}
				if (dialogResult == DialogResult.No)
				{
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
				}
				if (dialogResult == DialogResult.Cancel)
				{
					txt_SumRadif.Focus();
					return;
				}
			}
			pnl_SanadSum.Visible = false;
			pnl_MablaghKol.Visible = true;
			dtg_SanadSum.Height = 160;
			btn_Modify1.Visible = true;
		}

private void btn_Save1_Click(object sender, EventArgs e)
		{
			Save_dtgSanadSum();
			if (Operators.CompareString(Module1.BtnCommand, "New", TextCompare: false) == 0)
			{
				Btn_New_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

private void dtg_FosoolSum_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dtg_FosoolSum.ClearSelection();
		}

private void dtg_FosoolSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dtg_FosoolSum.ClearSelection();
		}

private void dtg_SanadSum_SelectionChanged(object sender, EventArgs e)
		{
			BtnCommand1 = "";
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
					foreach (Control control2 in pnl_SanadSum.Controls)
					{
						if (((object)control2.GetType() == typeof(ComboBox)) | ((object)control2.GetType() == typeof(TextBox)))
						{
							control2.ForeColor = Color.Black;
						}
					}
					Save_dtgSanadSum();
					break;
				case DialogResult.No:
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
					foreach (Control control3 in pnl_SanadSum.Controls)
					{
						if (((object)control3.GetType() == typeof(ComboBox)) | ((object)control3.GetType() == typeof(TextBox)))
						{
							control3.ForeColor = Color.Black;
						}
					}
					break;
				}
			}
			ShowSanadSumRecord();
			int lErl = default(int);
			try
			{
				if (dtg_SanadSum.CurrentCell.RowIndex == 0)
				{
					dtg_SanadSum.CurrentCell.Selected = false;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 20;
		}

private void btn_New1_Click(object sender, EventArgs e)
		{
			txt_SumRadif.Enabled = true;
			cmbo_SumSharh.Enabled = true;
			cmbo_SumNoa.Enabled = true;
			txt_SumDarsad.Enabled = true;
			txt_SumMablagh.Enabled = true;
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				dtg_SanadSum_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				return;
			}
			BtnCommand1 = "New";
			txt_SumRadif.Text = Conversions.ToString(dtg_SanadSum.RowCount);
			cmbo_SumSharh.Text = "";
			cmbo_SumSharh.Focus();
			cmbo_SumNoa.Text = "درصد";
			txt_SumDarsad.Text = "";
			txt_SumMablagh.Text = "";
			txt_SumMablagh.Enabled = false;
			lbl_SumMande.Text = "";
			foreach (Control control in pnl_SanadSum.Controls)
			{
				if (((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox)))
				{
					control.ForeColor = Color.Black;
				}
			}
		}

private void btn_Delete1_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			int index = dtg_SanadSum.CurrentRow.Index;
			int num = Conversions.ToInteger(dtg_SanadSum.Rows[index].Cells[0].Value);
			checked
			{
				if (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)
				{
					MessageBox.Show(" ابتدا ردیف مورد نظر را انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					BtnCommand1 = "Delete";
					if (dtg_SanadSum.RowCount - 1 != 0)
					{
						int index2 = dtg_SanadSum.CurrentRow.Index;
						if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ردیف ", dtg_SanadSum[2, index2].Value), " حذف شود؟")), "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
						{
							Module1.MyConn.Close();
							if (Module1.MyConn.State == ConnectionState.Closed)
							{
								Module1.MyConn.Open();
							}
							sqlCommand.Connection = Module1.MyConn;
							sqlCommand.CommandText = "DELETE FROM [dbo].[Asnad4] WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [recnum]='" + Conversions.ToString(SanadSumRec.recnum) + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
							sqlCommand.ExecuteNonQuery();
						}
					}
				}
				Load_dtg_SanadSum();
				dtg_SanadSum.CurrentCell = dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[4];
				ShowSanadSumRecord();
			}
		}

private void btn_Modify1_Click(object sender, EventArgs e)
		{
			pnl_SanadSum.Visible = true;
			btn_Modify1.Visible = false;
			pnl_MablaghKol.Visible = false;
			dtg_SanadSum.CurrentCell = dtg_SanadSum.Rows[0].Cells[4];
			dtg_SanadSum.Height = 150;
			ShowSanadSumRecord();
		}

private void cmbo_SumSharh_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && !((dtg_SanadSum.CurrentRow.Index == 0) | (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)))
			{
				if (Operators.CompareString(cmbo_SumSharh.Text.Trim(), SanadSumRec.Sharh.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumSharh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumSharh.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

private void cmbo_SumSharh_TextChanged(object sender, EventArgs e)
		{
			double num = Conversions.ToDouble(lbl_SanadZarib1.Text);
			double num2 = Conversions.ToDouble(lbl_SanadZarib2.Text);
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			switch (cmbo_SumSharh.Text.Trim())
			{
			case "مالیات و عوارض":
				cmbo_SumNoa.Text = "درصد";
				txt_SumDarsad.Text = "10";
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/47 فصول اول تا سوم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.47 * (num * (SumFasl("1") + SumFasl("2")) + SumFasl("3")), "###0");
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/50 فصل چهارم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.5 * SumFasl("4"), "###0");
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/55 فصول پنجم و ششم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.55 * (num2 * SumFasl("5") + num * SumFasl("6")), "###0");
				Calculate_SanadSumMande();
				break;
			default:
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				lbl_SumMande.Text = "";
				break;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_SumSharh.Text.Trim(), SanadSumRec.Sharh.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumSharh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumSharh.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
				goto IL_02ac;
			}
			CheckSumRecChange();
			goto IL_02ac;
			IL_02ac:
			lErl = 10;
		}

private void CheckSumRecChange()
		{
			foreach (Control control in pnl_SanadSum.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && control.ForeColor == Color.Red)
				{
					pnl_SanadSum.BackColor = Color.LightPink;
					return;
				}
			}
			pnl_SanadSum.BackColor = Color.LightSteelBlue;
		}

private void cmbo_SumNoa_Leave(object sender, EventArgs e)
		{
			CheckSumRecChange();
		}

private void cmbo_SumNoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			string left = cmbo_SumNoa.Text.Trim();
			if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
				{
					txt_SumMablagh.Enabled = true;
					txt_SumDarsad.Text = "";
					txt_SumMablagh.Text = "";
					txt_SumDarsad.Enabled = false;
				}
			}
			else
			{
				txt_SumDarsad.Enabled = true;
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				txt_SumMablagh.Enabled = false;
			}
			try
			{
				if (Operators.CompareString(cmbo_SumNoa.Text.Trim(), SanadSumRec.Noa.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumNoa.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_SumDarsad_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_SumDarsad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Versioned.IsNumeric(e.KeyChar) && Convert.ToByte(e.KeyChar) != 8 && Convert.ToByte(e.KeyChar) != 45 && Convert.ToByte(e.KeyChar) != 46)
			{
				e.Handled = true;
			}
			string @string = "-0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) != 0)
			{
			}
		}

private void txt_SumMablagh_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Versioned.IsNumeric(e.KeyChar) && Convert.ToByte(e.KeyChar) != 8 && Convert.ToByte(e.KeyChar) != 45)
			{
				e.Handled = true;
			}
			string @string = "-0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) != 0)
			{
			}
		}

private void txt_SumMablagh_KeyUp(object sender, KeyEventArgs e)
		{
			if ((Operators.CompareString(txt_SumMablagh.Text, "-", TextCompare: false) == 0) | (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".درصد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumMablagh.Text = "";
			}
			Calculate_SanadSumMande();
		}

private void txt_SumDarsad_KeyUp(object sender, KeyEventArgs e)
		{
			if (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0 || ((Operators.CompareString(txt_SumDarsad.Text, "-", TextCompare: false) == 0) | (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0)))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".درصد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
			Calculate_SanadSumMande();
		}

private void txt_SumMablagh_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumMablagh.Text, "-", TextCompare: false) != 0)
			{
				string value = ((Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) != 0) ? txt_SumMablagh.Text : "0");
				string value2 = ((Operators.CompareString(SanadSumRec.Mablagh, "", TextCompare: false) != 0) ? SanadSumRec.Mablagh : "0");
				if (checked(Conversions.ToLong(value) - Conversions.ToLong(value2)) != 0)
				{
					txt_SumMablagh.ForeColor = Color.Red;
				}
				else
				{
					txt_SumMablagh.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

private void txt_SumMablagh_MouseEnter(object sender, EventArgs e)
		{
		}

private void txt_SumMablagh_TextChanged(object sender, EventArgs e)
		{
		}

private void Save_dtgSanadSum()
		{
			if (Module1.SanadSabtGharardadha)
			{
				MessageBox.Show(" سند توسط امور قراردادها ثبت شده است تغییر ممکن نیست.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (!(pnl_SanadSum.BackColor == Color.LightSteelBlue))
			{
				if ((Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_SumMablagh.Text, "0", TextCompare: false) == 0))
				{
					MessageBox.Show(".اطلاعات ورودی را کامل کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					goto IL_04d8;
				}
				if (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0)
				{
					txt_SumDarsad.Text = "0";
				}
				if (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0)
				{
					txt_SumMablagh.Text = "0";
				}
				if (Operators.CompareString(lbl_SumMande.Text, "", TextCompare: false) == 0)
				{
					lbl_SumMande.Text = "0";
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				if (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)
				{
					Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad4] ([sanadnum], [fopf], [Sharh], [darsad], [maghtoo], [mablagh], [mablaghk], [Salmali], [IjadSystem], [TimeIjad],[Soori],[Ghaleb])VALUES ('" + lbl_SanadNo.Text + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + cmbo_SumSharh.Text + "','" + txt_SumDarsad.Text + "','" + txt_SumMablagh.Text + "','" + txt_SumMablagh.Text + "','" + lbl_SumMande.Text + "','" + Module1.SanadRec.SalMali + "','" + Environment.MachineName + "','','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
					Module1.cmd.ExecuteNonQuery();
				}
				else
				{
					int index = dtg_SanadSum.CurrentRow.Index;
					if (dtg_SanadSum.CurrentRow.Index != 0)
					{
						Module1.cmd.CommandText = "Update [dbo].[asnad4] SET [sanadnum] = '" + Conversions.ToString(Conversions.ToDouble(lbl_SanadNo.Text)) + "',[fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "',[Sharh] = '" + cmbo_SumSharh.Text + "',[darsad] = '" + Conversions.ToString(Conversions.ToDouble(txt_SumDarsad.Text)) + "',[maghtoo] = '" + txt_SumMablagh.Text + "',[mablagh] = '" + txt_SumMablagh.Text + "',[mablaghk] = '" + Conversions.ToString(Conversions.ToDouble(lbl_SumMande.Text)) + "',[Salmali] = '" + Module1.SanadRec.SalMali + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = '',[Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "',[Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' WHERE [recnum]='" + Conversions.ToString(SanadSumRec.recnum) + "' And [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						Module1.cmd.ExecuteNonQuery();
					}
				}
			}
			pnl_SanadSum.BackColor = Color.LightSteelBlue;
			Load_dtg_SanadSum();
			ShowSanadSumRecord();
			goto IL_04d8;
			IL_04d8:
			BtnCommand1 = "";
		}

private void txt_SumRadif_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_SumRadif.Text = "";
			}
		}

private void txt_SumRadif_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".ردیف باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
		}

private void txt_SumRadif_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			checked
			{
				int num = dtg_SanadSum.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToInteger(txt_SumRadif.Text) == Conversions.ToInteger(dtg_SanadSum.Rows[i].Cells[2].Value))
					{
						MessageBox.Show(". ردیف تکراری است مجددا وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_SumRadif.Focus();
						return;
					}
				}
				if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) != 0)
				{
					if (Conversions.ToDouble(txt_SumRadif.Text) != (double)SanadSumRec.Radif)
					{
						txt_SumRadif.ForeColor = Color.Red;
					}
					else
					{
						txt_SumRadif.ForeColor = Color.Black;
					}
					CheckSumRecChange();
				}
			}
		}

private void txt_SumRadif_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_SumRadif.Text.Trim(), SanadSumRec.Radif.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_SumRadif.ForeColor = Color.Red;
				}
				else
				{
					txt_SumRadif.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (!string.IsNullOrWhiteSpace(txt_SumRadif.Text) && !Versioned.IsNumeric(txt_SumRadif.Text))
			{
				txt_SumRadif.Text = "";
				MessageBox.Show(".ورودی باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
			}
			Calculate_SanadSumMande();
		}

private void Calculate_SanadSumMande()
		{
			if (dtg_SanadSum.RowCount == 0)
			{
				return;
			}
			float num = 1f;
			if ((Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0) & (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			checked
			{
				long num2 = default(long);
				if (Conversions.ToInteger(txt_SumRadif.Text) > Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[2].Value))
				{
					num2 = Conversions.ToLong(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[7].Value);
				}
				else if (Conversions.ToInteger(txt_SumRadif.Text) == Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[2].Value))
				{
					num2 = Conversions.ToLong(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 2].Cells[7].Value);
				}
				else
				{
					int num3 = dtg_SanadSum.RowCount - 2;
					for (int i = 0; i <= num3; i++)
					{
						if ((Conversions.ToInteger(txt_SumRadif.Text) > Conversions.ToInteger(dtg_SanadSum.Rows[i].Cells[2].Value)) & (Conversions.ToInteger(txt_SumRadif.Text) <= Conversions.ToInteger(dtg_SanadSum.Rows[i + 1].Cells[2].Value)))
						{
							num2 = Conversions.ToLong(dtg_SanadSum.Rows[i].Cells[7].Value);
						}
					}
				}
				long num4 = default(long);
				if (Operators.CompareString(cmbo_SumNoa.Text, "درصد", TextCompare: false) == 0)
				{
					num4 = (long)(Conversions.ToDouble(txt_SumDarsad.Text) * (double)num2 / 100.0);
					txt_SumMablagh.Text = Conversions.ToString(num4);
				}
				if (Operators.CompareString(cmbo_SumNoa.Text, "مقطوع", TextCompare: false) == 0)
				{
					num4 = (long)Math.Round(Conversions.ToDouble(txt_SumMablagh.Text));
				}
				num2 += num4;
				lbl_SumMande.Text = Conversions.ToString(num2);
			}
		}

private void btn_Filter_Click_1(object sender, EventArgs e)
		{
			if (pnl_Filter.Visible)
			{
				dtg_AsnadDetail.Location = new Point(15, 351);
				dtg_AsnadDetail.Height = 354;
				txt_ItemRadifFltr.Text = "";
				txt_ItemNoFltr.Text = "";
				txt_ItemFaslFltr.Text = "";
				cmbo_ItemNoaFltr.Text = "";
				txt_ItemSharhFltr.Text = "";
				txt_ItemVahedFltr.Text = "";
				txt_ItemBahavahedFltr.Text = "";
				txt_ItemTedadFltr.Text = "";
				txt_ItemBahaKolFltr.Text = "";
				txt_DarsadMeghdarFltr.Text = "";
				txt_DarsadItemFltr.Text = "";
				txt_DarsadMablaghFltr.Text = "";
				txt_TozihatFltr.Text = "";
				ItemNo_Filter = "";
				ItemFasl_Filter = "";
				ItemNoa_Filter = "";
				ItemSharh_Filter = "";
				ItemVahed_Filter = "";
				ItemBahavahed_Filter = "";
				ItemTedad_Filter = "";
				ItemBahaKol_Filter = "";
				DarsadMeghdar_Filter = "";
				DarsadItem_Filter = "";
				DarsadMablagh_Filter = "";
				Tozihat_Filter = "";
				pnl_Filter.Visible = false;
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
			else
			{
				pnl_Filter.Visible = true;
				dtg_AsnadDetail.Location = new Point(15, 372);
				dtg_AsnadDetail.Height = 331;
			}
		}

private void txt_ItemRadifFltr_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789-";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_SumRadif.Text = "";
			}
		}

private void btn_Print_Click1(object sender, EventArgs e)
		{
			if (pnl_Item.BackColor == Color.LightPink)
			{
				MessageBox.Show(" اطلاعات ایتم ذخیره شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT [SanadNo],[ItemFasl],[ItemNo],[ItemSharh],[ItemVahed],ItemTedad,ItemBahavahed,ItemBahaKol ,[Tozihat] FROM [dbo].[AsnadDetail] Where [SanadNo]= '" + lbl_SanadNo.Text.Trim() + "'", Module1.MyConn);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet, "Sanad1");
			CrystalReport1 crystalReport = new CrystalReport1();
			crystalReport.SetDataSource(dataSet.Tables[0]);
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_JobNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_Project.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + lbl_Karfarma.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + lbl_Fehrest.Text + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

private void SetPnl_ItemBlue()
		{
			pnl_Item.BackColor = Color.LightSteelBlue;
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

private void txt_SumDarsad_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumDarsad.Text, "-", TextCompare: false) != 0)
			{
				string value = ((Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) != 0) ? txt_SumDarsad.Text : "0");
				string value2 = ((Operators.CompareString(SanadSumRec.Darsad, "", TextCompare: false) != 0) ? SanadSumRec.Darsad : "0");
				if (Conversions.ToDouble(value) != Conversions.ToDouble(value2))
				{
					txt_SumDarsad.ForeColor = Color.Red;
				}
				else
				{
					txt_SumDarsad.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

private void cmbo_DarsadItem_GotFocus(object sender, EventArgs e)
		{
			if ((Operators.CompareString(Module1.ItemRec.DarsadItem, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadItem, "", TextCompare: false) != 0))
			{
				cmbo_DarsadItem.Text = ": ایتم";
			}
			else if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0))
			{
				cmbo_DarsadItem.Text = ": مبلغ";
			}
			else
			{
				cmbo_DarsadItem.Text = "";
			}
		}

private void cmbo_DarsadItem_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

private void cmbo_DarsadItem_Leave(object sender, EventArgs e)
		{
			try
			{
				switch (lbl_ItemNoa.Text.Trim())
				{
				case "درصدی":
				case "درصدي":
				case "درصدی - ستاره دار":
				case "درصدي - ستاره دار":
					txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
					break;
				}
				if ((Operators.CompareString(Module1.ItemRec.DarsadItem, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadItem, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_DarsadItem.Text, ": ایتم", TextCompare: false) != 0))
				{
					cmbo_DarsadItem.ForeColor = Color.Red;
				}
				else if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_DarsadItem.Text, ": مبلغ", TextCompare: false) != 0))
				{
					cmbo_DarsadItem.ForeColor = Color.Red;
				}
				else
				{
					cmbo_DarsadItem.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void cmbo_DarsadItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			DarsadItemBaha = "0";
			string left = cmbo_DarsadItem.Text.Trim();
			int lErl = default(int);
			if (Operators.CompareString(left, ": مبلغ", TextCompare: false) == 0 || Operators.CompareString(left, ": ایتم", TextCompare: false) == 0)
			{
				txt_DarsadMablagh.Visible = true;
			}
			else
			{
				txt_DarsadMablagh.Visible = false;
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT TOP 1 [ghvahed] FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [itemnum] ='" + cmbo_DarsadItem.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					DarsadItemBaha = sqlDataReader[0].ToString();
				}
				sqlDataReader.Close();
				try
				{
					txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
					if (string.IsNullOrEmpty(txt_ItemTedad.Text))
					{
						txt_ItemTedad.Text = "0";
					}
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					MessageBox.Show(" اطلاعات ورودی بررسی شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ProjectData.ClearProjectError();
				}
			}
			lErl = 10;
		}

private void Btn_Save_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemNo_TextChanged(object sender, EventArgs e)
		{
			switch (txt_ItemNo.Text.Trim())
			{
			case "40101":
			case "40201":
			case "40301":
			case "40401":
				btn_Calculate.Visible = true;
				break;
			default:
				btn_Calculate.Visible = false;
				break;
			}
		}

private void btn_Calculate_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_Calculate.chk_40201.Checked = false;
			MyProject.Forms.Frm_Calculate.chk_40301.Checked = false;
			MyProject.Forms.Frm_Calculate.chk_40401.Checked = false;
			MyProject.Forms.Frm_Calculate.CalculateItemFasl4();
			MyProject.Forms.Frm_Calculate.ShowDialog();
		}

private void Btn_Save_KeyUp(object sender, KeyEventArgs e)
		{
		}

private void lbl_ItemNoa_Click(object sender, EventArgs e)
		{
		}

private void txt_DarsadMablagh_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

private void txt_DarsadMablagh_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

private void txt_DarsadMablagh_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".ورودی باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
		}

private void txt_DarsadMablagh_Leave(object sender, EventArgs e)
		{
			if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_DarsadMablagh.Text, "0", TextCompare: false) == 0))
			{
				switch (MessageBox.Show(".ایتم یا مبلغ را جهت محاسبه وارد کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					SetDarsadMablaghFocus = 1;
					return;
				case DialogResult.Cancel:
					SetDarsadMablaghFocus = 2;
					return;
				}
			}
			string left = cmbo_DarsadItem.Text.Trim();
			if (Operators.CompareString(left, ": مبلغ", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, ": ایتم", TextCompare: false) == 0)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT TOP 1 [ghvahed] FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [itemnum] ='" + txt_DarsadMablagh.Text.Trim() + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						MessageBox.Show(" . ایتم  وارد شده در سند موجود نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						SetDarsadMablaghFocus = 2;
						sqlDataReader.Close();
						return;
					}
					while (sqlDataReader.Read())
					{
						DarsadItemBaha = sqlDataReader[0].ToString();
					}
					sqlDataReader.Close();
				}
			}
			else if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) != 0))
			{
				DarsadItemBaha = txt_DarsadMablagh.Text;
			}
			else
			{
				if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0))
				{
					txt_DarsadMeghdar.Focus();
				}
				if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) == 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0))
				{
					txt_DarsadMablagh.Focus();
				}
			}
			try
			{
				if ((Operators.CompareString(txt_DarsadMablagh.Text.Trim(), Module1.ItemRec.DarsadMablagh.ToString().Trim(), TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMablagh.Text.Trim(), Module1.ItemRec.DarsadItem.ToString().Trim(), TextCompare: false) != 0))
				{
					txt_DarsadMablagh.ForeColor = Color.Red;
				}
				else
				{
					txt_DarsadMablagh.ForeColor = Color.Black;
				}
				CheckItemRecChange();
				txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
				txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_DarsadMablagh_TextChanged(object sender, EventArgs e)
		{
		}

private void LoadCmboDarsadItems()
		{
			cmbo_DarsadItem.Items.Clear();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [ItemDarsad] FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] where [shomar] ='" + txt_ItemNo.Text.Trim() + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			string[] array = null;
			while (sqlDataReader.Read())
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
				{
					array = sqlDataReader[0].ToString().Split(',');
					continue;
				}
				sqlDataReader.Close();
				return;
			}
			sqlDataReader.Close();
			string text = "";
			string text2 = "";
			int num = Information.UBound(array);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string[] array2 = null;
				array2 = array[i].Split('-');
				if (Information.UBound(array2) == 0)
				{
					text = " ([itemnum] Like N'%" + array2[0] + "%') Order By [itemnum]";
				}
				if (Information.UBound(array2) == 1)
				{
					text = " ([itemnum] Between '" + Conversions.ToString(Conversion.Val(array2[0])) + "' And '" + Conversions.ToString(Conversion.Val(array2[1])) + "') Order By [itemnum]";
				}
				text2 = ((Operators.CompareString(text, "", TextCompare: false) != 0) ? "And " : "");
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [itemnum] FROM [dbo].[Asnad2] where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' " + text2 + text;
				sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					cmbo_DarsadItem.Items.Add(RuntimeHelpers.GetObjectValue(sqlDataReader[0]));
				}
				sqlDataReader.Close();
			}
			cmbo_DarsadItem.Items.Add(": ایتم");
			cmbo_DarsadItem.Items.Add(": مبلغ");
		}

private void Btn_Save_Leave(object sender, EventArgs e)
		{
			txt_ItemNo.Focus();
		}

private void txt_ItemTedad_TextChanged(object sender, EventArgs e)
		{
		}

private void cmbo_SumNoa_TextChanged(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			string left = cmbo_SumNoa.Text.Trim();
			if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
				{
					txt_SumMablagh.Enabled = true;
					txt_SumDarsad.Text = "";
					txt_SumDarsad.Enabled = false;
				}
			}
			else
			{
				txt_SumDarsad.Enabled = true;
				txt_SumMablagh.Text = "";
				txt_SumMablagh.Enabled = false;
			}
			try
			{
				if (Operators.CompareString(cmbo_SumNoa.Text.Trim(), SanadSumRec.Noa.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumNoa.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void btn_Import_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_ItemSelect.ShowDialog();
			MyProject.Forms.Frm_ItemSelect.Load_dtg_Item();
		}

private void txt_ItemNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemNoFltr.Text;
					ItemNo_Filter = " ([itemnum] Like '%" + text + "%')";
				}
				else
				{
					ItemNo_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

private void txt_ItemRadifFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			if ((Operators.CompareString(txt_ItemRadifFltr.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_ItemRadifFltr.Text, "-", TextCompare: false) == 0))
			{
				return;
			}
			string[] array = null;
			string[] array2 = new string[3];
			array = txt_ItemRadifFltr.Text.Split('-');
			array2 = null;
			dtg_AsnadDetail.CurrentCell = null;
			checked
			{
				if (Information.UBound(array) == 0)
				{
					int num = dtg_AsnadDetail.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(dtg_AsnadDetail.Rows[i].Cells[1].Value.ToString(), array[0], TextCompare: false) != 0)
						{
							dtg_AsnadDetail.Rows[i].Visible = false;
						}
					}
				}
				if (Information.UBound(array) == 1)
				{
					if (Operators.CompareString(array[1], "", TextCompare: false) == 0)
					{
						return;
					}
					int num2 = dtg_AsnadDetail.RowCount - 1;
					for (int j = 0; j <= num2; j++)
					{
						if ((Conversions.ToInteger(dtg_AsnadDetail.Rows[j].Cells[1].Value.ToString()) < Conversions.ToInteger(array[0])) | (Conversions.ToInteger(dtg_AsnadDetail.Rows[j].Cells[1].Value.ToString()) > Conversions.ToInteger(array[1])))
						{
							dtg_AsnadDetail.Rows[j].Visible = false;
						}
					}
				}
				int num3 = dtg_AsnadDetail.RowCount - 1;
				for (int k = 0; k <= num3; k++)
				{
					if (dtg_AsnadDetail.Rows[k].Visible)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[k].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

private void txt_ItemFaslFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemFaslFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemFaslFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemFasl_Filter = " ([fasl] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemFasl_Filter = "([fasl] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemFasl_Filter = "";
				}
			}
			else
			{
				ItemFasl_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_ItemSharhFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemSharhFltr.Text;
					ItemSharh_Filter = " (REPLACE(REPLACE([sharhitem],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ItemSharh_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

private void txt_ItemVahedFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemVahedFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemVahedFltr.Text;
					ItemVahed_Filter = " (REPLACE(REPLACE([shvahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ItemVahed_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
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
					ItemBahavahed_Filter = " (cast([ghvahed] as decimal(18,0)) Like '%" + Conversions.ToString(Conversion.Val(array[0])) + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahavahed_Filter = "([ghvahed] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahavahed_Filter = "";
				}
			}
			else
			{
				ItemBahavahed_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_ItemTedadFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemTedadFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemTedadFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemTedad_Filter = " (cast([total] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemTedad_Filter = "([total] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemTedad_Filter = "";
				}
			}
			else
			{
				ItemTedad_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_ItemBahaKolFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemBahaKolFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemBahaKolFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemBahaKol_Filter = " (cast([mablagh] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahaKol_Filter = "([mablagh] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahaKol_Filter = "";
				}
			}
			else
			{
				ItemBahaKol_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_DarsadMeghdarFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadMeghdarFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadMeghdarFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadMeghdar_Filter = " ([itemdarsad] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadMeghdar_Filter = "([itemdarsad] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadMeghdar_Filter = "";
				}
			}
			else
			{
				DarsadMeghdar_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_DarsadItemFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadItemFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadItemFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadItem_Filter = " ([itemname] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadItem_Filter = "([itemname] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadItem_Filter = "";
				}
			}
			else
			{
				DarsadItem_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_DarsadMablaghFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadMablaghFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadMablaghFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadMeghdar_Filter = " ([NesbatbeMablagh] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadMeghdar_Filter = "([NesbatbeMablagh] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadMeghdar_Filter = "";
				}
			}
			else
			{
				DarsadMeghdar_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

private void txt_TozihatFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_TozihatFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_TozihatFltr.Text;
					Tozihat_Filter = " (REPLACE(REPLACE([Tozihat],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Tozihat_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

private void btn_View_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_View.Text, "نمایش بیشتر", TextCompare: false) == 0)
			{
				pnl_Filter.Location = new Point(17, 93);
				dtg_AsnadDetail.Location = new Point(15, 115);
				dtg_AsnadDetail.Height = 445;
				btn_View.Text = "نمایش کمتر";
				pnl_Fosool.Visible = false;
			}
			else
			{
				pnl_Filter.Location = new Point(17, 307);
				dtg_AsnadDetail.Location = new Point(15, 329);
				dtg_AsnadDetail.Height = 235;
				btn_View.Text = "نمایش بیشتر";
				pnl_Fosool.Visible = true;
			}
		}

private void txt_ItemNo_KeyDown1(object sender, KeyEventArgs e)
		{
		}

private void txt_ItemNo_KeyUp(object sender, KeyEventArgs e)
		{
			ItemSearch = txt_ItemNo.Text;
			txt_ItemNo.SelectionStart = checked(txt_ItemNo.Text.Length + 1);
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [recnum],[itemnum] FROM [dbo].[asnad2] Where [recnum] = '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					if (Operators.CompareString(txt_ItemNo.Text, sqlDataReader[1].ToString(), TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [radif],[shomar],[Sharh],[Fasl],[Vahed],[baha],Cast([darsad] As varchar(25))+Cast([setareh] As varchar(25)) FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] Where [shomar] = '" + txt_ItemNo.Text + "'";
			sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					txt_ItemNo.Text = sqlDataReader[1].ToString();
					try
					{
						if (Operators.CompareString(txt_ItemNo.Text.Trim(), Module1.ItemRec.itemnum.Trim(), TextCompare: false) != 0)
						{
							txt_ItemTedad.Text = "";
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					txt_ItemSharh.Text = sqlDataReader[2].ToString();
					cmbo_ItemFasl.Text = sqlDataReader[3].ToString();
					cmbo_ItemVahed.Text = sqlDataReader[4].ToString();
					txt_ItemBahavahed.Text = sqlDataReader[5].ToString();
					txt_ItemBahaKol.Text = "";
					txt_Tozihat.Text = "";
					switch (sqlDataReader[6].ToString().Trim())
					{
					case "00":
						lbl_ItemNoa.Text = "بها دار";
						break;
					case "10":
						lbl_ItemNoa.Text = "درصدی";
						txt_DarsadMeghdar.Text = sqlDataReader[5].ToString();
						txt_ItemBahavahed.Text = "";
						break;
					case "01":
						lbl_ItemNoa.Text = "ستاره دار";
						break;
					case "11":
						lbl_ItemNoa.Text = "درصدی - ستاره دار";
						break;
					}
				}
			}
			sqlDataReader.Close();
		}

private void txt_ItemNo_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0)
			{
				switch (MessageBox.Show(".شماره ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					SetItemNomFocus = 1;
					return;
				case DialogResult.Cancel:
					SetItemNomFocus = 2;
					return;
				}
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_ItemNo.Text.Trim(), Module1.ItemRec.itemnum.Trim(), TextCompare: false) != 0)
				{
					txt_ItemNo.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemNo.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [radif],[shomar],[Sharh],[Fasl],[Vahed],[baha],Cast([darsad] As varchar(25))+Cast([setareh] As varchar(25)) FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] Where [shomar] = '" + txt_ItemNo.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (!sqlDataReader.HasRows)
			{
				DialogResult dialogResult = MessageBox.Show(".ایتم در فهرست بها نیست بصورت توافقی در نظر گرقته می شود", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				pnl_Item.BackColor = Color.LightPink;
				if (dialogResult != DialogResult.OK)
				{
					if (dialogResult == DialogResult.Cancel)
					{
						sqlDataReader.Close();
						SetItemNomFocus = 1;
						goto IL_03cb;
					}
				}
				else
				{
					lbl_ItemNoa.Text = "توافقی";
				}
				sqlDataReader.Close();
			}
			else if (sqlDataReader.Read())
			{
				txt_ItemNo.Text = sqlDataReader[1].ToString();
				txt_ItemSharh.Text = sqlDataReader[2].ToString();
				cmbo_ItemFasl.Text = sqlDataReader[3].ToString();
				cmbo_ItemVahed.Text = sqlDataReader[4].ToString();
				txt_ItemBahavahed.Text = sqlDataReader[5].ToString();
				switch (sqlDataReader[6].ToString().Trim())
				{
				case "00":
					lbl_ItemNoa.Text = "بها دار";
					break;
				case "10":
					lbl_ItemNoa.Text = "درصدی";
					break;
				case "01":
					lbl_ItemNoa.Text = "ستاره دار";
					break;
				case "11":
					lbl_ItemNoa.Text = "درصدی - ستاره دار";
					break;
				}
				if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
				{
					LoadCmboDarsadItems();
				}
				else
				{
					cmbo_DarsadItem.DataSource = null;
				}
				sqlDataReader.Close();
			}
			else
			{
				sqlDataReader.Close();
				ItemSearch = "";
				lbl_ItemNoa_TextChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			goto IL_03cb;
			IL_03cb:
			lErl = 10;
		}

private void cmbo_ItemFasl_KeyDown(object sender, KeyEventArgs e)
		{
		}

private void cmbo_ItemFasl_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

private void txt_ItemBahaKol_KeyDown(object sender, KeyEventArgs e)
		{
		}

public void PrintSanad()
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT TOP 1 [ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna] From [Moshakhasat] Where [EsmRamz] ='" + MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.Onvan.ShName = sqlDataReader[0].ToString();
				Module1.Onvan.CodeEghtesadi = sqlDataReader[1].ToString();
				Module1.Onvan.OnvanSanad = sqlDataReader[2].ToString();
				Module1.Onvan.NameAmel = sqlDataReader[3].ToString();
				Module1.Onvan.EsmRamz = sqlDataReader[4].ToString();
				Module1.Onvan.MatnNameh = sqlDataReader[5].ToString();
				Module1.Onvan.AvarezShahrdari = sqlDataReader[6].ToString();
				Module1.Onvan.AvarezArzeshAfzoode = sqlDataReader[7].ToString();
				Module1.Onvan.Semat = sqlDataReader[8].ToString();
				Module1.Onvan.OnvanMabna = sqlDataReader[9].ToString();
			}
			sqlDataReader.Close();
			if (Operators.CompareString(lbl_NoaSanad.Text.Trim(), "فاکتور", TextCompare: false) == 0)
			{
				text = Module1.Onvan.OnvanSanad;
			}
			CrystalReport1 crystalReport = new CrystalReport1();
			crystalReport.Subreports[0].Database.Tables["DataTable1"].SetDataSource(TableFosoolSum);
			checked
			{
				int num = TableSanadSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (i != 0)
					{
						if (Operators.ConditionalCompareObjectNotEqual(TableSanadSum.Rows[i]["درصد"], 0, TextCompare: false))
						{
							TableSanadSum.Rows[i]["شرح"] = TableSanadSum.Rows[i]["شرح"].ToString() + " (" + TableSanadSum.Rows[i]["درصد"].ToString() + TableSanadSum.Rows[i]["نوع"].ToString() + ")";
							TableSanadSum.Rows[i]["درصد"] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
						}
						else
						{
							TableSanadSum.Rows[i]["شرح"] = TableSanadSum.Rows[i]["شرح"].ToString();
						}
						TableSanadSum.Rows[i]["نوع"] = "";
					}
				}
				crystalReport.Subreports[1].Database.Tables["DataTable2"].SetDataSource(TableSanadSum);
				int num2 = AsnadDetailTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if ((Operators.CompareString(AsnadDetailTable.Rows[j]["نسبت به ایتم"].ToString(), "0", TextCompare: false) != 0) & (Operators.CompareString(AsnadDetailTable.Rows[j]["نسبت به ایتم"].ToString(), "", TextCompare: false) != 0))
					{
						AsnadDetailTable.Rows[j]["توضیحات"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(AsnadDetailTable.Rows[j]["توضیحات"], " ( نسبت به ایتم "), AsnadDetailTable.Rows[j]["نسبت به ایتم"]), ")");
						AsnadDetailTable.Rows[j]["واحد"] = Operators.ConcatenateObject(Operators.ConcatenateObject(AsnadDetailTable.Rows[j]["درصد"], " "), AsnadDetailTable.Rows[j]["واحد"]);
					}
				}
				crystalReport.Database.Tables["DataTable3"].SetDataSource(AsnadDetailTable);
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
				crystalReport.DataDefinition.FormulaFields["UnboundString22"].Text = "'" + lbl_SanadNo.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString23"].Text = "'" + lbl_JobNo.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_Project.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + lbl_Fehrest.Text + "'";
				string text4 = "";
				switch (lbl_NoaSanad.Text.Trim())
				{
				case "فاکتور":
					text4 = " صورت هزینه ";
					break;
				case "پیش فاکتور":
					text4 = " برآورد هزینه ";
					break;
				case "صوری":
					text4 = " صورت هزینه ";
					break;
				case "قالب":
					text4 = " نمونه صورت هزینه ";
					break;
				}
				crystalReport.DataDefinition.FormulaFields["UnboundString25"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + text4 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString12"].Text = "'" + lbl_Project.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString13"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString17"].Text = "'" + lbl_Fehrest.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString10"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString14"].Text = "'" + lbl_Comment.Text + "'";
				string text5 = lbl_SanadOstan.Text + "-" + lbl_SanadShahr.Text + "-" + lbl_SanadBakhsh.Text;
				crystalReport.DataDefinition.FormulaFields["UnboundString11"].Text = "'" + text5 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString15"].Text = "'" + lbl_SanadZarib1.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString20"].Text = "'" + lbl_SanadZarib2.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString19"].Text = "'" + lbl_SanadZaribComment1.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString21"].Text = "'" + lbl_SanadZaribComment2.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString30"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString32"].Text = "'" + text4 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString33"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_MablaghKol1.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString2"].Text = "'" + lbl_MablaghKol2.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString3"].Text = "'" + Module1.Onvan.Semat + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString4"].Text = "'" + Module1.Onvan.NameAmel + "'";
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(70);
				MyProject.Forms.frm_PrintSanad.ShowDialog();
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
				Load_dtg_SanadSum();
			}
		}

public void PrintNameh()
		{
			string text = " موضوع: صورت هزینه " + lbl_Project.Text;
			string text2 = ((Operators.CompareString(MyProject.Forms.frm_PrintDialog.txt_Ronevwsht.Text.Trim(), "", TextCompare: false) == 0) ? "" : (" رونوشت : " + MyProject.Forms.frm_PrintDialog.txt_Ronevwsht.Text));
			CrystalReport3 crystalReport = new CrystalReport3();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_Karfarma.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString8"].Text = "'" + MyProject.Forms.frm_PrintDialog.txt_Karnam2.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString2"].Text = "'" + text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + lbl_Comment.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_MablaghKol1.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString9"].Text = "'" + text2 + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(90);
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

public void PrintArzeshAfzoode()
		{
			CrystalReport4 crystalReport = new CrystalReport4();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_Project.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString2"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_Karfarma.Text + "'";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[Oname],[ShahrName],[KodPosti] FROM [Jahdazma1].[dbo].[etkarfar]Where REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(lbl_Karfarma.Text) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + sqlDataReader[4].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + sqlDataReader[5].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + sqlDataReader[0].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + sqlDataReader[6].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString8"].Text = "'" + sqlDataReader[2].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString9"].Text = "'" + sqlDataReader[3].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString10"].Text = "'" + sqlDataReader[1].ToString() + "'";
				}
			}
			crystalReport.DataDefinition.FormulaFields["UnboundString11"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString12"].Text = "'" + lbl_Comment.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundNumber2"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat + (double)Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber3"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat + (double)Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber4"].Text = Conversions.ToString(Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber5"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber6"].Text = Conversions.ToString(Module1.Maliat);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber7"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text));
			crystalReport.DataDefinition.FormulaFields["UnboundString20"].Text = "'" + MyProject.Forms.frm_PrintDialog.txt_Tozihat.Text + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(85);
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

public double SumFasl(string Fasl)
		{
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT sum(cast([mablagh] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fasl] = '" + Fasl + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			double result = default(double);
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					result = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])) ? 0.0 : Conversions.ToDouble(sqlDataReader[0].ToString()));
				}
			}
			else
			{
				result = 0.0;
			}
			sqlDataReader.Close();
			return result;
		}

private void lbl_MablaghKol1_TextChanged(object sender, EventArgs e)
		{
			if (Module1.FromEdari == 1)
			{
				return;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "UPDATE [dbo].[Asnad1] SET [mablaghk] ='" + GhabelPardakht + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			checked
			{
				int num = TableSanadSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectNotEqual(TableSanadSum.Rows[i]["recnum"], 0, TextCompare: false))
					{
						Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo].[Asnad4] SET [mablagh] = '", TableSanadSum.Rows[i]["مبلغ"]), "'"), ",[mablaghk] = '"), TableSanadSum.Rows[i]["مانده"]), "'"), " WHERE [sanadnum] ='"), Module1.SanadRec.sanadnum), "' AND [recnum] ='"), TableSanadSum.Rows[i]["recnum"]), "'"));
						Module1.cmd.ExecuteNonQuery();
					}
				}
			}
		}

private void txt_ItemBahavahed_TextChanged(object sender, EventArgs e)
		{
		}

private void Btn_Return_Click(object sender, EventArgs e)
		{
			Btn_Return1_Click(RuntimeHelpers.GetObjectValue(sender), e);
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				Btn_Return1_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (pnl_Item.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (dialogResult == DialogResult.No)
				{
					SetPnl_ItemBlue();
				}
			}
			dtg_AsnadDetail.Focus();
			ExitFrmAsnadDetail = 1;
			TableSanadSum.Columns.Clear();
			TableFosoolSum.Columns.Clear();
			Close();
			Module1.SanadRecordRefresh = 1;
			MyProject.Forms.Frm_AsnadList.Load_dtg_AsnadList();
			MyProject.Forms.Frm_AsnadList.SetPnl_AsnadBlue();
		}

private void btn_Print_Click(object sender, EventArgs e)
		{
			if (pnl_Item.BackColor == Color.LightPink)
			{
				MessageBox.Show(" اطلاعات سند ذخیره شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MyProject.Forms.frm_PrintDialog.ShowDialog();
			}
		}

private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			int index = default(int);
			int lErl = default(int);
			try
			{
				index = dtg_AsnadDetail.CurrentRow.Index;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				ProjectData.ClearProjectError();
			}
			if (dtg_AsnadDetail.RowCount != 0)
			{
				int index2 = dtg_AsnadDetail.CurrentRow.Index;
				if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ایتم ردیف ", dtg_AsnadDetail[1, index2].Value), " با شماره ایتم "), dtg_AsnadDetail[4, index2].Value), " حذف شود؟ ")), "حذف ایتم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "DELETE FROM [dbo].[Asnad2]  WHERE [recnum]= '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
					sqlCommand.ExecuteNonQuery();
				}
			}
			lErl = 20;
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			Module1.BtnCommand = "Delete";
			try
			{
				if (index != 0)
				{
					dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[index].Cells[1];
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, lErl);
				dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[checked(index - 1)].Cells[1];
				ProjectData.ClearProjectError();
			}
			ShowItemRecord();
		}

private void btn_copy_Click(object sender, EventArgs e)
		{
			string itemnum = Module1.ItemRec.itemnum;
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_AsnadDetail_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_AsnadDetail.CurrentRow.Index;
			DialogResult dialogResult = MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ایتم ردیف ", dtg_AsnadDetail[1, index].Value), " با شماره ایتم "), dtg_AsnadDetail[4, index].Value), " کپی شود؟ ")), "کپی ایتم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad2]([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[TimeIjad] ,[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) (SELECT [radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],'" + Environment.MachineName + "','',[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb] FROM [dbo].[asnad2]  WHERE [sanadnum] = '" + Module1.ItemRec.sanadnum + "' And [itemnum] = '" + Module1.ItemRec.itemnum + "' And [fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] = '" + Module1.SanadRec.SalMali + "' And [Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			Module1.BtnCommand = "Copy";
			checked
			{
				int num = dtg_AsnadDetail.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_AsnadDetail.Rows[i].Cells[4].Value.ToString(), itemnum, TextCompare: false) == 0)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[i].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

private void btn_Insert_Click(object sender, EventArgs e)
		{
			BlankItemRec();
			Module1.BtnCommand = "New";
			txt_ItemNo.Focus();
		}

private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = cmbo_DarsadItem.Text;
			string text2 = txt_DarsadMablagh.Text;
			string text3 = "";
			float num = 0f;
			string text4 = "";
			checked
			{
				int lErl = default(int);
				if (Module1.SanadSabtGharardadha)
				{
					MessageBox.Show(" .سند توسط امور قراردادها ثبت شده است تغییر ممکن نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Load_dtg_AsnadDetail(lbl_SanadNo.Text);
					Load_dtg_FosoolSum();
					Load_dtg_SanadSum();
					SetPnl_ItemBlue();
				}
				else
				{
					try
					{
						Module1.CurrRow = dtg_AsnadDetail.CurrentRow.Index;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, lErl);
						ProjectData.ClearProjectError();
					}
					if (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult = MessageBox.Show(".تعداد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_ItemTedad.Focus();
						return;
					}
					if (Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult2 = MessageBox.Show(".بهای واحد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_ItemBahavahed.Focus();
						return;
					}
					if (Operators.CompareString(cmbo_ItemVahed.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult3 = MessageBox.Show(". واحد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						cmbo_ItemVahed.Focus();
					}
					if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
					{
						if (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0)
						{
							DialogResult dialogResult4 = MessageBox.Show(". مقدار درصد را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_DarsadMeghdar.Focus();
							return;
						}
					}
					else
					{
						txt_DarsadMeghdar.Text = "0";
						text = "";
					}
					byte b = default(byte);
					byte b2 = default(byte);
					switch (lbl_ItemNoa.Text.Trim())
					{
					case "بها دار":
						b = Conversions.ToByte("0");
						b2 = Conversions.ToByte("0");
						break;
					case "درصدی":
						b = Conversions.ToByte("1");
						b2 = Conversions.ToByte("0");
						break;
					case "ستاره دار":
					case "توافقی":
						b = Conversions.ToByte("0");
						b2 = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						b = Conversions.ToByte("1");
						b2 = Conversions.ToByte("1");
						break;
					}
					string left = cmbo_DarsadItem.Text.Trim();
					byte b3;
					if (Operators.CompareString(left, ": ایتم", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, ": مبلغ", TextCompare: false) == 0)
						{
							text2 = txt_DarsadMablagh.Text;
							b3 = Conversions.ToByte("1");
							text = "0";
						}
						else
						{
							text = cmbo_DarsadItem.Text;
							text2 = "0";
							b3 = Conversions.ToByte("1");
						}
					}
					else
					{
						text = txt_DarsadMablagh.Text;
						text2 = "0";
						b3 = Conversions.ToByte("1");
					}
					lErl = 20;
					if (Module1.ItemRec.recnum == 0)
					{
						Module1.BtnCommand = "New";
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Asnad2] ([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) VALUES('0','" + lbl_SanadNo.Text + "','" + txt_ItemNo.Text + "','" + txt_ItemSharh.Text + "','" + Conversions.ToString(Math.Round(Conversions.ToSingle(txt_ItemBahaKol.Text))) + "','','','" + cmbo_ItemFasl.Text + "','0','" + Conversions.ToString(Math.Round(Conversions.ToSingle(txt_ItemBahavahed.Text))) + "','" + cmbo_ItemVahed.Text + "','" + txt_ItemTedad.Text + "','" + Conversions.ToString(b) + "','" + Conversions.ToString(b2) + "','" + Conversions.ToString(Conversions.ToSingle(txt_DarsadMeghdar.Text)) + "','" + text + "','" + txt_Tozihat.Text + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + Module1.SanadRec.SalMali + "','" + Environment.MachineName + "','','','','','','','','" + Conversions.ToString(b3) + "','" + text2 + "','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
						Module1.cmd.ExecuteNonQuery();
					}
					else
					{
						Module1.BtnCommand = "Modify";
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Asnad2] SET [radif] = '0',[sanadnum] = '" + lbl_SanadNo.Text + "',[itemnum] = '" + txt_ItemNo.Text + "',[sharhitem] = '" + txt_ItemSharh.Text + "',[mablagh] = '" + Conversions.ToString(Math.Round(Conversions.ToDouble(txt_ItemBahaKol.Text))) + "',[fasl] = '" + cmbo_ItemFasl.Text + "',[vahed] = '0',[ghvahed] = '" + Conversions.ToString(Math.Round(Conversions.ToDouble(txt_ItemBahavahed.Text))) + "',[shvahed] = '" + cmbo_ItemVahed.Text + "',[total] = '" + txt_ItemTedad.Text + "',[darsad] = '" + Conversions.ToString(b) + "',[setarehdar] = '" + Conversions.ToString(b2) + "',[itemdarsad] = '" + txt_DarsadMeghdar.Text + "',[itemname] = '" + text + "',[molahezat] = '" + txt_Tozihat.Text + "',[fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "',[SalMali] = '" + Module1.SanadRec.SalMali + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = '',[Mablaghi] = '" + Conversions.ToString(b3) + "',[NesbatbeMablagh] = '" + text2 + "',[Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "',[Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' WHERE [recnum] = '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
						Module1.cmd.ExecuteNonQuery();
					}
					text3 = txt_ItemNo.Text;
					num = Conversions.ToSingle(txt_ItemTedad.Text);
					text4 = txt_Tozihat.Text;
					lErl = 30;
					Load_dtg_AsnadDetail(lbl_SanadNo.Text);
					Load_dtg_FosoolSum();
					Load_dtg_SanadSum();
					SetPnl_ItemBlue();
					int num2 = -1;
					foreach (DataGridViewRow item in (IEnumerable)dtg_AsnadDetail.Rows)
					{
						num2++;
						if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(item.Cells[4].Value, text3, TextCompare: false), Operators.CompareObjectEqual(item.Cells[10].Value, num, TextCompare: false)), Operators.CompareObjectEqual(item.Cells[15].Value, text4, TextCompare: false))))
						{
							dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[num2].Cells[1];
							ShowItemRecord();
						}
					}
					dtg_AsnadDetail.Focus();
					if (Operators.CompareString(Module1.BtnCommand, "New", TextCompare: false) == 0)
					{
						BlankItemRec();
						txt_ItemNo.Focus();
					}
					else
					{
						try
						{
							dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow + 1].Cells[1];
							ShowItemRecord();
							dtg_AsnadDetail.Focus();
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, lErl);
							ProjectData.ClearProjectError();
						}
					}
				}
				lErl = 10;
			}
		}

private void cmbo_SumSharh_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void txt_SumDarsad_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_SumDarsad.Text, SanadSumRec.Darsad, TextCompare: false) != 0)
			{
				txt_SumDarsad.ForeColor = Color.Red;
			}
			else
			{
				txt_SumDarsad.ForeColor = Color.Black;
			}
		}

private void lbl_GhabelPardakht_Click(object sender, EventArgs e)
		{
		}

private void lbl_SumMande_TextChanged(object sender, EventArgs e)
		{
		}

private void cmbo_ItemFasl_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

private void pnl_Filter_Paint(object sender, PaintEventArgs e)
        {

        }

private void txt_ItemRadifFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_DarsadMablaghFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemNoFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemTedadFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemBahavahedFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemVahedFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_DarsadMeghdarFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemSharhFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemFaslFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemBahaKolFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_DarsadItemFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_TozihatFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

private void lbl_Comment_Click(object sender, EventArgs e)
        {

        }

private void lbl_Amaliat_Click(object sender, EventArgs e)
        {

        }

private void lbl_Karfarma_Click(object sender, EventArgs e)
        {

        }

private void lbl_Fehrest_Click(object sender, EventArgs e)
        {

        }

private void lbl_Project_Click(object sender, EventArgs e)
        {

        }

private void lbl_JobNo_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadNo_Click(object sender, EventArgs e)
        {

        }

private void lbl_NoaSanad_Click(object sender, EventArgs e)
        {

        }

private void lbl_SalMali_Click(object sender, EventArgs e)
        {

        }

private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

private void lbl_SanadZaribComment2_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadZaribComment1_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadZarib2_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadZarib1_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadBakhsh_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadShahr_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadOstan_Click(object sender, EventArgs e)
        {

        }

private void Label39_Click(object sender, EventArgs e)
        {

        }

private void Label40_Click(object sender, EventArgs e)
        {

        }

private void Label41_Click(object sender, EventArgs e)
        {

        }

private void Label42_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadBakhshCode_Click(object sender, EventArgs e)
        {

        }

private void Label4_Click(object sender, EventArgs e)
        {

        }

private void Label32_Click(object sender, EventArgs e)
        {

        }

private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

private void lbl_SanadYear_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadMonth_Click(object sender, EventArgs e)
        {

        }

private void lbl_SanadDay_Click(object sender, EventArgs e)
        {

        }

private void Label16_Click(object sender, EventArgs e)
        {

        }

private void Label17_Click(object sender, EventArgs e)
        {

        }

private void Label18_Click(object sender, EventArgs e)
        {

        }

private void Label11_Click(object sender, EventArgs e)
        {

        }

private void Label13_Click(object sender, EventArgs e)
        {

        }

private void Label22_Click(object sender, EventArgs e)
        {

        }

private void Label14_Click(object sender, EventArgs e)
        {

        }

private void Label15_Click(object sender, EventArgs e)
        {

        }

private void Label19_Click(object sender, EventArgs e)
        {

        }

private void Label20_Click(object sender, EventArgs e)
        {

        }

private void pnl_Fosool_Paint(object sender, PaintEventArgs e)
        {

        }

private void pnl_SanadSum_Paint(object sender, PaintEventArgs e)
        {

        }

private void Label3_Click(object sender, EventArgs e)
        {

        }

private void lbl_SumMande_Click(object sender, EventArgs e)
        {

        }

private void Label8_Click(object sender, EventArgs e)
        {

        }

private void Label1_Click(object sender, EventArgs e)
        {

        }

private void Label7_Click(object sender, EventArgs e)
        {

        }

private void Label6_Click(object sender, EventArgs e)
        {

        }

private void Label5_Click(object sender, EventArgs e)
        {

        }

private void pnl_MablaghKol_Paint(object sender, PaintEventArgs e)
        {

        }

private void Label12_Click(object sender, EventArgs e)
        {

        }

private void lbl_MablaghKol1_Click(object sender, EventArgs e)
        {

        }

private void lbl_MablaghKol2_Click(object sender, EventArgs e)
        {

        }

private void txt_FaslNoFltr_TextChanged(object sender, EventArgs e)
        {

        }

private void Label38_Click(object sender, EventArgs e)
        {

        }

private void Label37_Click(object sender, EventArgs e)
        {

        }

private void Label35_Click(object sender, EventArgs e)
        {

        }

private void Label30_Click(object sender, EventArgs e)
        {

        }

private void Label29_Click(object sender, EventArgs e)
        {

        }

private void Label24_Click(object sender, EventArgs e)
        {

        }

private void txt_ItemBahaKol_TextChanged(object sender, EventArgs e)
        {

        }

private void Label21_Click(object sender, EventArgs e)
        {

        }

private void cmbo_ItemVahed_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

private void Label9_Click(object sender, EventArgs e)
        {

        }

private void lbl_ItemNoa_Click_1(object sender, EventArgs e)
        {

        }

private void lbl_DarsadItem_Click(object sender, EventArgs e)
        {

        }

private void cmbo_DarsadItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

private void txt_Tozihat_TextChanged_1(object sender, EventArgs e)
        {

        }

private void txt_ItemSharh_TextChanged(object sender, EventArgs e)
        {

        }

private void txt_ItemNo_TextChanged_1(object sender, EventArgs e)
        {

        }

private void pnl_Item_Paint(object sender, PaintEventArgs e)
        {

        }

private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
