using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[StandardModule]
	public sealed class Module1
	{
		public struct SanadDetailes
		{
			public int recnum;

			public string sanadnum;

			public string karnum;

			public int pkod;

			public string sanaddatey;

			public string sanaddatem;

			public string sanaddated;

			public string fehrestfile;

			public bool forpf;

			public float mablaghk;

			public string pname1;

			public int karkod1;

			public string karname1;

			public string karname2;

			public string Fehrest;

			public string NoaSanad;

			public string SalMali;

			public string Nameh;

			public string Pname2;

			public string Ronevwsht;

			public string BakhshCode;

			public string noeSanad;

			public string OnvanCode;

			public byte Printed;

			public string IjadSystem;

			public string TimeIjad;

			public string EslahSystem;

			public string TimeEslah;

			public byte Soori;

			public byte Ghaleb;
		}

		public struct OnvanDetailes
		{
			public string ShName;

			public string CodeEghtesadi;

			public string OnvanSanad;

			public string NameAmel;

			public string EsmRamz;

			public string MatnNameh;

			public string AvarezShahrdari;

			public string AvarezArzeshAfzoode;

			public string Semat;

			public string OnvanMabna;
		}

		public struct ItemDetailes
		{
			public int recnum;

			public string Radif;

			public string itemnum;

			public string sanadnum;

			public string fasl;

			public string ItemNoa;

			public byte darsadi;

			public byte setarehdar;

			public string sharhitem;

			public string shvahed;

			public string ghvahed;

			public string total;

			public string mablagh;

			public string DarsadMeghdar;

			public string DarsadItem;

			public string DarsadMablagh;

			public string molahezat;

			public string IjadSystem;

			public string TimeIjad;

			public string EslahSystem;

			public string TimeEslah;

			public string GroupCode;

			public string GroupName;

			public string SubGroupCode;

			public string SubGroupName;

			public string GroupMablagh;

			public string GroupDarsad;

			public byte Mablaghi;
		}

		public static SqlConnection MyConn = new SqlConnection("server=192.168.1.102;database=Jahdazma1;user id=jahd;password=74121");

		public static SqlConnection MyConn1 = new SqlConnection("server=192.168.1.102;database=Jahdazma1;user id=jahd;password=74121");

		public static SqlConnection MyConn2 = new SqlConnection("server=192.168.1.102;database=Dabirkhane;user id=jahd;password=74121");

		public static PersianCalendar PerCal = new PersianCalendar();

		public static SqlDataAdapter MyDataAdapter = new SqlDataAdapter();

		public static DataSet MyDataSet = new DataSet();

		public static SqlCommand cmd = new SqlCommand();

		public static SqlCommand cmd1 = new SqlCommand();

		public static int RowsAffected;

		public static string strWhere = "";

		public static bool bytWhereFrom;

		public static string strAccountIdt = "";

		public static string strSearchDate = "";

		public static string strSearchDate1 = "";

		public static string user = "";

		public static string pass = "";

		public static bool DatePikerSit;

		public static string StrOstan;

		public static string StrShahr;

		public static string StrBakhsh;

		public static bool BtnProjectList;

		public static bool BtnKarfarmaList;

		public static bool FromFilter = false;

		public static string SanadNoSelected;

		public static string FAslOrItem;

		public static string FehrestMabna;

		public static byte FromAsnadList = 0;

		public static byte FromAsnadGhaleb = 0;

		public static bool SanadSabtGharardadha;

		public static string NoaSanad;

		public static string WhereZaribCode;

		public static string BtnCommand;

		public static string a1_Factor;

		public static string a2_Factor;

		public static string a3_Factor;

		public static string a4_Factor;

		public static string a5_Factor;

		public static string a6_Factor;

		public static string a7_Factor;

		public static string a8_Factor;

		public static string a_Factor;

		public static string b_Factor;

		public static byte FactorHasRow;

		public static bool forpf;

		public static byte soori;

		public static byte Ghaleb;

		public static string MabnaFehresrFile;

		public static string MabnaFehresrName;

		public static string MabnaOnvan;

		public static string CurrentFehrestFile = "";

		public static string CurrentFehrestName;

		public static string FehrestName_filter;

		public static string FehrestFile_filter;

		public static string FehrestMabna_filter;

		public static string GhalebNo;

		public static string GhalebSalMali;

		public static bool Ghalebforpf;

		public static bool GhalebSoori;

		public static string StrProjectCode = "";

		public static int CurrRow;

		public static byte SanadRecordRefresh;

		public static string ProjectName_filter;

		public static int Takhfif;

		public static int Maliat;

		public static float Zarib_I;

		public static float Zarib_1;

		public static float Zarib_2;

		public static string SalMali = "";

		public static byte DtgAsnadRefresh;

		public static byte FromEdari = 0;

		public static string strFilter = "";

		public static PersianCalendar pc = new PersianCalendar();

		public static SanadDetailes SanadRec;

		public static OnvanDetailes Onvan;

		public static ItemDetailes ItemRec;

		public static void ComboDateLoad(ComboBox ComboDay, ComboBox ComboMonth, ComboBox ComboYear, byte Sit)
		{
		}

		public static void ComboProjectOstanLoad()
		{
			DataTable dataTable = new DataTable();
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT REPLACE(REPLACE([Ostan],'ي',N'ی'),'ك',N'ک') As Ostan FROM [ZarayebMantaghe] group by [Ostan]";
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			MyProject.Forms.Frm_Project.cmbo_ProjectOstan.DataSource = dataTable;
			MyProject.Forms.Frm_Project.cmbo_ProjectOstan.DisplayMember = "Ostan";
			MyProject.Forms.Frm_Project.cmbo_ProjectOstanFltr.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				MyProject.Forms.Frm_Project.cmbo_ProjectOstanFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Ostan"]));
			}
			MyProject.Forms.Frm_Project.cmbo_ProjectOstanFltr.Text = "";
			sqlDataReader.Close();
		}

		public static void ComboProjectShahrLoad(string Ostan)
		{
			DataTable dataTable = new DataTable();
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT [Shahr] FROM [dbo].[ZarayebMantaghe] Where [Ostan] = N'" + Ostan + "' group by Shahr";
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			if (0 - (FromFilter ? 1 : 0) == 0)
			{
				MyProject.Forms.Frm_Project.cmbo_ProjectShahr.DataSource = dataTable;
				MyProject.Forms.Frm_Project.cmbo_ProjectShahr.DisplayMember = "Shahr";
				sqlDataReader.Close();
				return;
			}
			MyProject.Forms.Frm_Project.cmbo_ProjectShahrFltr.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				MyProject.Forms.Frm_Project.cmbo_ProjectShahrFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Shahr"]));
			}
			MyProject.Forms.Frm_Project.cmbo_ProjectShahrFltr.Text = "";
			sqlDataReader.Close();
		}

		public static void ComboProjectBakhshLoad(string Ostan, string Shahr)
		{
			DataTable dataTable = new DataTable();
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT [Bakhsh] FROM [dbo].[ZarayebMantaghe] Where [Ostan] = N'" + Ostan + "' And [Shahr]= N'" + Shahr + "' group by Bakhsh";
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			if (0 - (FromFilter ? 1 : 0) == 0)
			{
				MyProject.Forms.Frm_Project.cmbo_ProjectBakhsh.DataSource = dataTable;
				MyProject.Forms.Frm_Project.cmbo_ProjectBakhsh.DisplayMember = "bakhsh";
				return;
			}
			MyProject.Forms.Frm_Project.cmbo_ProjectBakhshFltr.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				MyProject.Forms.Frm_Project.cmbo_ProjectBakhshFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Bakhsh"]));
			}
			sqlDataReader.Close();
		}

		public static void FindBakhshCode(string BakhshCode, string Ostan, string Shahr, string Bakhsh)
		{
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT [BakhshCode] FROM [dbo].[ZarayebMantaghe] Where [Ostan] = N'" + Ostan + "' And [Shahr]= N'" + Shahr + "' And [Bakhsh]= N'" + Bakhsh + "' group by [BakhshCode]";
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			BakhshCode = "";
			while (sqlDataReader.Read())
			{
				BakhshCode = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
		}

		public static string FindCodeOrName(string InputData, string InputField, string OutputField, string strTable)
		{
			string result = "";
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT Top 1 " + OutputField + " FROM [dbo]." + strTable + " Where REPLACE(REPLACE(" + InputField + ",'ي',N'ی'),'ك',N'ک') = N'" + ArbToPer(InputData) + "'";
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				result = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			return result;
		}

		public static void Load_Cmbo(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			strCmbo.DataSource = null;
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			cmd.Connection = MyConn;
			cmd.CommandText = "SELECT REPLACE(REPLACE(" + strField + ",'ي',N'ی'),'ك',N'ک') As " + ArbToPer(strField) + " FROM [dbo]." + strTable + " " + strWhere + " Group By " + strField + " Order By " + strField;
			SqlDataReader sqlDataReader = cmd.ExecuteReader();
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

		public static void dtg_Color(DataGridView dtgrd)
		{
			string[] array = new string[3];
			checked
			{
				try
				{
					if (dtgrd.Rows.Count <= 0)
					{
						return;
					}
					int num = dtgrd.Rows.Count - 1;
					for (int i = 0; i <= num; i++)
					{
						DataGridView dataGridView = dtgrd;
						int num2 = dataGridView.Columns.Count - 1;
						for (int j = 0; j <= num2; j++)
						{
							if (Operators.CompareString(dataGridView.Rows[i].Cells[2].Value.ToString(), "فاکتور", TextCompare: false) == 0)
							{
								dataGridView.Rows[i].Cells[j].Style.BackColor = Color.White;
							}
							if (Operators.CompareString(dataGridView.Rows[i].Cells[2].Value.ToString(), "پیش فاکتور", TextCompare: false) == 0)
							{
								dataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightBlue;
							}
							if (Operators.CompareString(dataGridView.Rows[i].Cells[2].Value.ToString(), "صوری", TextCompare: false) == 0)
							{
								dataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightGray;
							}
							if (Operators.CompareString(dataGridView.Rows[i].Cells[2].Value.ToString(), "قالب", TextCompare: false) == 0)
							{
								dataGridView.Rows[i].Cells[j].Style.BackColor = Color.LightGreen;
							}
							if (MyProject.Forms.Frm_AsnadList.chk_SabtNashode.Checked)
							{
								dataGridView.Rows[i].Cells[j].Style.ForeColor = Color.Red;
							}
							else
							{
								dataGridView.Rows[i].Cells[j].Style.ForeColor = Color.Black;
							}
						}
						dataGridView = null;
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

		public static void FindOstanShahrBakhsh(string Bakhshcode)
		{
			SqlCommand sqlCommand = new SqlCommand();
			MyConn.Close();
			if (MyConn.State == ConnectionState.Closed)
			{
				MyConn.Open();
			}
			sqlCommand.Connection = MyConn;
			sqlCommand.CommandText = "Select REPLACE((REPLACE([Ostan],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Shahr],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Bakhsh],'ي',N'ی')),'ك',N'ک') FROM [dbo].[ZarayebMantaghe] where BakhshCode ='" + Bakhshcode + "'";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					StrOstan = sqlDataReader[0].ToString();
					StrShahr = sqlDataReader[1].ToString();
					StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			else
			{
				sqlDataReader.Close();
				sqlCommand.CommandText = "Select REPLACE((REPLACE([etostan].[oname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etshahr].[shname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etbakhsh].[bname],'ي',N'ی')),'ك',N'ک') FROM [dbo].[etbakhsh] INNER JOIN [etostan] ON [etbakhsh].okod =[etostan].okod  INNER JOIN [etshahr] ON [etbakhsh].shkod =[etshahr].shkod  where bkod ='" + Bakhshcode + "' group by [etbakhsh].[okod],[etostan].[oname],[etbakhsh].[shkod],[etshahr].[shname],[etbakhsh].[bkod],[etbakhsh].[bname],[etbakhsh].[zarib]";
				sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					StrOstan = sqlDataReader[0].ToString();
					StrShahr = sqlDataReader[1].ToString();
					StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			sqlDataReader.Close();
		}

		public static string PerToArb(string Persian)
		{
			return Persian.Replace("ی", "ي").Replace("ک", "ك");
		}

		public static string ArbToPer(string Arab)
		{
			return Arab.Replace("ي", "ی").Replace("ك", "ک");
		}

		public static string MiladiToShamsi(int Year, int Month, int Day)
		{
			string result;
			try
			{
				DateTime time = Conversions.ToDate(Conversions.ToString(Year) + "/" + Conversions.ToString(Month) + "/" + Conversions.ToString(Day));
				PersianCalendar persianCalendar = new PersianCalendar();
				result = Conversions.ToString(persianCalendar.GetYear(time)) + "/" + Strings.Format(persianCalendar.GetMonth(time), "00") + "/" + Strings.Format(persianCalendar.GetDayOfMonth(time), "00");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				result = Conversions.ToString(0);
				ProjectData.ClearProjectError();
			}
			return result;
		}
	}
}
