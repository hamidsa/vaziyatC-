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
    public partial class Frm_Calculate_New : Form
    {
        // Private fields
        private TextBox _txt_40101B;
        private TextBox _Txt_D;
        private TextBox _txt_rs;
        private TextBox _txt_b;
        private TextBox _txt_S;
        private TextBox _txt_a;
        private TextBox _txt_k1;
        private Button _btn_Find_a;
        private Button _btn_Ok;
        private Button _btn_Cancel;
        private CheckBox _chk_40201;
        private CheckBox _chk_40301;
        private CheckBox _chk_40401;
        private Button _btn_Find_b;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;


        public double k1;
        public Frm_Calculate_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Calculate_New_KeyDown;
            this.Load += Frm_Calculate_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

        private void Frm_Calculate_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Frm_Calculate_New_Load(object sender, EventArgs e)
        {
            // کدهای مربوط به بارگذاری فرم frm_AsnadOnvan_New
            // مثلاً:
            // Module1.Load_Cmbo(cmbo_Example, "table", "field", "");
            // LoadData();
        }

        private void Txt_D_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					Txt_D.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			else if ((Conversions.ToSingle(txt_rs.Text) != 0f) & (Operators.CompareString(txt_rs.Text, "", TextCompare: false) != 0) & ((Conversions.ToSingle(Txt_D.Text) != 0f) & (Operators.CompareString(Txt_D.Text, "", TextCompare: false) != 0)))
			{
				txt_40101B.Text = Strings.Format(Conversions.ToSingle(txt_40101C1.Text) + Conversions.ToSingle(txt_40101C2.Text) * (1f + Conversions.ToSingle(txt_rs.Text)) / 2f * Conversions.ToSingle(Txt_D.Text), "###0");
			}
			else
			{
				txt_40101B.Text = "";
			}
			if (e.KeyCode == Keys.Return)
			{
				btn_Ok.Select();
			}
		}

private void txt_rs_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_rs.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			else if ((Conversions.ToSingle(txt_rs.Text) != 0f) & (Operators.CompareString(txt_rs.Text, "", TextCompare: false) != 0) & ((Conversions.ToSingle(Txt_D.Text) != 0f) & (Operators.CompareString(Txt_D.Text, "", TextCompare: false) != 0)))
			{
				txt_40101B.Text = Strings.Format(Conversions.ToSingle(txt_40101C1.Text) + Conversions.ToSingle(txt_40101C2.Text) * (1f + Conversions.ToSingle(txt_rs.Text)) / 2f * Conversions.ToSingle(Txt_D.Text), "###0");
			}
			else
			{
				txt_40101B.Text = "";
			}
			if (e.KeyCode == Keys.Return)
			{
				Txt_D.Focus();
			}
		}

private void txt_40101B_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_40101B.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_rs.Focus();
			}
		}

private void btn_Ok_Click(object sender, EventArgs e)
		{
			try
			{
				Frm_AsnadDetail frm_AsnadDetail = MyProject.Forms.Frm_AsnadDetail;
				if (pnl_40101.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40101B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40201.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40201B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40301.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40301B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40401.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40401B.Text;
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
					MyProject.Forms.Frm_AsnadDetail.txt_Tozihat.Text = "k1=" + txt_k1.Text + " , a1=" + Module1.a1_Factor + " , a2=" + Module1.a2_Factor + " , a3=" + Module1.a3_Factor + " , a4=" + Module1.a4_Factor + " , a5=" + Module1.a5_Factor + " , a6=" + Module1.a6_Factor + " , a7=" + Module1.a7_Factor + " , a8=" + Module1.a8_Factor + " , b=" + txt_b.Text + " , S=" + txt_S.Text;
				}
				frm_AsnadDetail.txt_ItemBahavahed.Focus();
				frm_AsnadDetail = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.Text.Trim(), Module1.ItemRec.ghvahed.Trim(), TextCompare: false) != 0)
				{
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.ForeColor = Color.Black;
				}
				MyProject.Forms.Frm_AsnadDetail.CheckItemRecChange();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			Close();
		}

private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

private void chk_40201_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

private void chk_40301_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

public void CalculateItemFasl4()
		{
			string value = "0";
			string value2 = "0";
			string value3 = "0";
			string value4 = "0";
			string value5 = "0";
			string value6 = "0";
			string value7 = "0";
			string value8 = "0";
			double SumFasl = Conversions.ToDouble(value);
			CalculateSumFasl("1", ref SumFasl);
			value = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value2);
			CalculateSumFasl("1*", ref SumFasl);
			value2 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value3);
			CalculateSumFasl("2", ref SumFasl);
			value3 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value4);
			CalculateSumFasl("2*", ref SumFasl);
			value4 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value5);
			CalculateSumFasl("3", ref SumFasl);
			value5 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value6);
			CalculateSumFasl("3*", ref SumFasl);
			value6 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value7);
			CalculateSumFasl("6", ref SumFasl);
			value7 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value8);
			CalculateSumFasl("6*", ref SumFasl);
			value8 = Conversions.ToString(SumFasl);
			checked
			{
				switch (MyProject.Forms.Frm_AsnadDetail.txt_ItemNo.Text.Trim())
				{
				case "40101":
				{
					pnl_40101.Visible = true;
					pnl_40201.Visible = false;
					pnl_40301.Visible = false;
					pnl_40401.Visible = false;
					pnl_40101.Location = new Point(35, 23);
					base.Height = pnl_40101.Location.Y + pnl_40101.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_rs.Text = MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text;
					Txt_D.Text = "0";
					txt_40101B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40101C1.Text = "40000000";
						txt_40101C2.Text = "400000";
						break;
					case "FEHBAHA1401":
						txt_40101C1.Text = "24000000";
						txt_40101C2.Text = "300000";
						break;
					case "FEHBAHA1400":
						txt_40101C1.Text = "18197000";
						txt_40101C2.Text = "190000";
						break;
					case "FEHBAHA1399":
						txt_40101C1.Text = "11740000";
						txt_40101C2.Text = "123000";
						break;
					case "FEHBAHA1397":
						txt_40101C1.Text = "6180000";
						txt_40101C2.Text = "123000";
						break;
					case "FEHBAHA1393":
						txt_40101C1.Text = "3640000";
						txt_40101C2.Text = "72700";
						break;
					case "FEHBAHA1391":
						txt_40101C1.Text = "1966500";
						txt_40101C2.Text = "39330";
						break;
					case "FEHBAHA1387":
						txt_40101C1.Text = "1150000";
						txt_40101C2.Text = "23000";
						break;
					case "FEHBAHA1384":
						txt_40101C1.Text = "800000";
						txt_40101C2.Text = "16000";
						break;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT sum(cast([total] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And ([itemnum]  between '10401' And '10407' Or [itemnum]  between '10501' And '10507' Or [itemnum]  between '10701' And '10713' Or  [itemnum]  between '11001' And '11004') And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						while (sqlDataReader.Read())
						{
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
							{
								Txt_D.Text = Strings.Format(Conversions.ToDouble(sqlDataReader[0].ToString()), "###0.00");
							}
						}
					}
					sqlDataReader.Close();
					if (Conversions.ToDouble(Txt_D.Text) != 0.0)
					{
						txt_40101B.Text = Strings.Format(Conversions.ToDouble(txt_40101C1.Text) + Conversions.ToDouble(txt_40101C2.Text) * (1.0 + Conversions.ToDouble(txt_rs.Text)) / 2.0 * Conversions.ToDouble(Txt_D.Text), "###0");
					}
					else
					{
						txt_40101B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40201":
				{
					pnl_40101.Visible = false;
					pnl_40201.Visible = true;
					pnl_40301.Visible = false;
					pnl_40401.Visible = false;
					pnl_40201.Location = new Point(35, 23);
					base.Height = pnl_40201.Location.Y + pnl_40201.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_F.Text = "0";
					txt_40201B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40201C1.Text = "16000000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1401":
						txt_40201C1.Text = "9000000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1400":
						txt_40201C1.Text = "6770000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1399":
						txt_40201C1.Text = "4370000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1397":
						txt_40201C1.Text = "2300000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1393":
						txt_40201C1.Text = "1360000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1391":
						txt_40201C1.Text = "735300";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1387":
						txt_40201C1.Text = "430000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1384":
						txt_40201C1.Text = "300000";
						txt_40201C2.Text = "0.05";
						break;
					}
					double num = ((!chk_40201.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_F.Text = Strings.Format(Conversions.ToDouble(value3) * num + Conversions.ToDouble(value4), "###0");
					if (Conversions.ToDouble(txt_F.Text) != 0.0)
					{
						txt_40201B.Text = Strings.Format(Conversions.ToDouble(txt_40201C1.Text) + Conversions.ToDouble(txt_40201C2.Text) * Conversions.ToDouble(txt_F.Text), "###0");
					}
					else
					{
						txt_40201B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40301":
				{
					pnl_40101.Visible = false;
					pnl_40201.Visible = false;
					pnl_40301.Visible = true;
					pnl_40401.Visible = false;
					pnl_40301.Location = new Point(35, 23);
					base.Height = pnl_40301.Location.Y + pnl_40301.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_L.Text = "0";
					txt_40301B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40301C1.Text = "4000000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1401":
						txt_40301C1.Text = "3000000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1400":
						txt_40301C1.Text = "2370000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1399":
						txt_40301C1.Text = "1531000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1397":
						txt_40301C1.Text = "806000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1393":
						txt_40301C1.Text = "475000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1391":
						txt_40301C1.Text = "256500";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1387":
						txt_40301C1.Text = "150000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1384":
						txt_40301C1.Text = "100000";
						txt_40301C2.Text = "0.07";
						break;
					}
					double num = ((!chk_40301.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_Fasl_3.Text = Strings.Format(Conversions.ToDouble(value5) + Conversions.ToDouble(value6), "###0");
					txt_Fasl_6.Text = Strings.Format(Conversions.ToDouble(value7) * num + Conversions.ToDouble(value8), "###0");
					txt_L.Text = Strings.Format(Conversions.ToDouble(txt_Fasl_3.Text) + Conversions.ToDouble(txt_Fasl_6.Text), "###0");
					if (Conversions.ToDouble(txt_L.Text) != 0.0)
					{
						txt_40301B.Text = Strings.Format(Conversions.ToDouble(txt_40301C1.Text) + Conversions.ToDouble(txt_40301C2.Text) * Conversions.ToDouble(txt_L.Text), "###0");
					}
					else
					{
						txt_40301B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40401":
				{
					LoadFactor_a_b();
					k1 = 0.0;
					pnl_40101.Visible = false;
					pnl_40201.Visible = false;
					pnl_40301.Visible = false;
					pnl_40401.Visible = true;
					pnl_40401.Location = new Point(35, 23);
					base.Height = pnl_40401.Location.Y + pnl_40401.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					double num = ((!chk_40401.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_S.Text = Strings.Format(Conversions.ToDouble(value) * num + Conversions.ToDouble(value2) + Conversions.ToDouble(value3) * num + Conversions.ToDouble(value4) + Conversions.ToDouble(value5) + Conversions.ToDouble(value6), "###0");
					Calculate_k1((float)(Conversions.ToDouble(txt_S.Text) / 1000000.0), ref k1);
					txt_k1.Text = Strings.Format(k1 / 100.0, "###0.0000");
					LoadFactor_a_b();
					Module1.a_Factor = Conversions.ToString(Math.Round(Conversions.ToDouble(Module1.a1_Factor) * Conversions.ToDouble(Module1.a2_Factor) * Conversions.ToDouble(Module1.a3_Factor) * Conversions.ToDouble(Module1.a4_Factor) * Conversions.ToDouble(Module1.a5_Factor) * Conversions.ToDouble(Module1.a6_Factor) * Conversions.ToDouble(Module1.a7_Factor) * Conversions.ToDouble(Module1.a8_Factor), 4));
					txt_a.Text = Module1.a_Factor;
					txt_b.Text = Module1.b_Factor;
					break;
				}
				}
				btn_Ok.Select();
			}
		}

private void CalculateSumFasl(string Fasl, ref double SumFasl)
		{
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT sum(cast([mablagh] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fasl] = '" + Fasl + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
					{
						SumFasl = Conversions.ToDouble(sqlDataReader[0].ToString());
					}
				}
			}
			sqlDataReader.Close();
		}

private void Calculate_k1(float S, ref double k1)
		{
			switch (Module1.SanadRec.fehrestfile)
			{
			case "FEHBAHA1403":
				if (S <= 1350f)
				{
					k1 = 6.57;
				}
				if (S > 1350f && S <= 2900f)
				{
					k1 = 6.57 - (double)((S - 1350f) / 1550f) * 0.4400000000000004;
				}
				if (S > 2900f && S <= 4200f)
				{
					k1 = 6.13 - (double)((S - 2900f) / 1300f) * 0.28000000000000025;
				}
				if (S > 4200f && S <= 7000f)
				{
					k1 = 5.85 - (double)((S - 4200f) / 2800f) * 0.22999999999999954;
				}
				if (S > 7000f && S <= 18000f)
				{
					k1 = 5.62 - (double)((S - 7000f) / 11000f) * 0.5;
				}
				if (S > 18000f && S <= 35000f)
				{
					k1 = 5.12 - (double)((S - 18000f) / 17000f) * 0.25;
				}
				if (S > 35000f && S <= 70000f)
				{
					k1 = 4.87 - (double)((S - 35000f) / 35000f) * 0.41000000000000014;
				}
				if (S > 70000f && S <= 175000f)
				{
					k1 = 4.46 - (double)((S - 70000f) / 105000f) * 0.3899999999999997;
				}
				if (S > 175000f && S <= 290000f)
				{
					k1 = 4.07 - (double)((S - 175000f) / 115000f) * 0.20000000000000018;
				}
				if (S > 290000f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1401":
				if (S <= 700f)
				{
					k1 = 6.57;
				}
				if (S > 700f && S <= 1500f)
				{
					k1 = 6.57 - (double)((S - 700f) / 800f) * 0.4400000000000004;
				}
				if (S > 1500f && S <= 2400f)
				{
					k1 = 6.13 - (double)((S - 1500f) / 900f) * 0.28000000000000025;
				}
				if (S > 2400f && S <= 3600f)
				{
					k1 = 5.85 - (double)((S - 2400f) / 1200f) * 0.22999999999999954;
				}
				if (S > 3600f && S <= 9000f)
				{
					k1 = 5.62 - (double)((S - 3600f) / 5400f) * 0.5;
				}
				if (S > 9000f && S <= 18000f)
				{
					k1 = 5.12 - (double)((S - 9000f) / 9000f) * 0.25;
				}
				if (S > 18000f && S <= 36000f)
				{
					k1 = 4.87 - (double)((S - 18000f) / 18000f) * 0.41000000000000014;
				}
				if (S > 36000f && S <= 90000f)
				{
					k1 = 4.46 - (double)((S - 36000f) / 54000f) * 0.3899999999999997;
				}
				if (S > 90000f && S <= 150000f)
				{
					k1 = 4.07 - (double)((S - 90000f) / 60000f) * 0.20000000000000018;
				}
				if (S > 150000f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1400":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1399":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			case "FEHBAHA1397":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			case "FEHBAHA1393":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			}
		}

private void chk_40401_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

private void txt_S_TextChanged(object sender, EventArgs e)
		{
			Calculate_k1((float)(Conversions.ToDouble(txt_S.Text) / 1000000.0), ref k1);
			txt_k1.Text = Strings.Format(k1 / 100.0, "###0.00000");
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void btn_Find_a_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_Factor_a.ShowDialog();
		}

private void btn_Find_b_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_Factor_b.ShowDialog();
		}

private void LoadFactor_a_b()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [SanadNo],[a1],[a2],[a3],[a4],[a5],[a6],[a7],[a8],[b] FROM [dbo].[Factors40401] Where [SanadNo] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				Module1.FactorHasRow = 1;
				while (sqlDataReader.Read())
				{
					Module1.a1_Factor = sqlDataReader[1].ToString().Trim();
					Module1.a2_Factor = sqlDataReader[2].ToString().Trim();
					Module1.a3_Factor = sqlDataReader[3].ToString().Trim();
					Module1.a4_Factor = sqlDataReader[4].ToString().Trim();
					Module1.a5_Factor = sqlDataReader[5].ToString().Trim();
					Module1.a6_Factor = sqlDataReader[6].ToString().Trim();
					Module1.a7_Factor = sqlDataReader[7].ToString().Trim();
					Module1.a8_Factor = sqlDataReader[8].ToString().Trim();
					Module1.b_Factor = sqlDataReader[9].ToString().Trim();
				}
			}
			else
			{
				Module1.FactorHasRow = 0;
				foreach (Control control in MyProject.Forms.frm_Factor_a.Controls)
				{
					if (!(control is Panel))
					{
						continue;
					}
					foreach (RadioButton control2 in control.Controls)
					{
						if (Operators.CompareString(control2.Text.Substring(3, 4), "1.00", TextCompare: false) == 0)
						{
							control2.Checked = true;
						}
					}
				}
				Module1.a7_Factor = "1.00";
				Module1.a8_Factor = "1.00";
				Module1.b_Factor = "1.00";
			}
			sqlDataReader.Close();
		}

private void txt_k1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_a_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

private void txt_b_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

    }
}
