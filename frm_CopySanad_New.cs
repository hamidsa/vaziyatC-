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
    public partial class frm_CopySanad_New : Form
    {
        // Private fields
        private SqlDataReader myReader;
        private string NoaSanad_filter;
        private byte Typ_Factor;
        private byte Typ_Soori;
        private byte Typ_Ghaleb;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public frm_CopySanad_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += frm_CopySanad_New_KeyDown;
            this.Load += frm_CopySanad_New_Load;
            
            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }
        private void frm_CopySanad_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void frm_CopySanad_New_Load(object sender, EventArgs e)
		{
			cmbo_NoaSanad.Items.Clear();
			cmbo_NoaSanad.Items.Add("فاکتور");
			cmbo_NoaSanad.Items.Add("پیش فاکتور");
			cmbo_NoaSanad.Items.Add("صوری");
			cmbo_NoaSanad.Items.Add("قالب");
			cmbo_NoaSanad.Text = Module1.NoaSanad;
			Module1.Load_Cmbo(cmbo_SalMali, "asnad1", "SalMali", "");
			cmbo_SalMali.Text = MyProject.Forms.Frm_AsnadList.cmbo_SalMali.Text;
		}

private void OK_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.OK;
			switch (cmbo_NoaSanad.Text)
			{
			case "فاکتور":
				NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
				Typ_Factor = 1;
				break;
			case "پیش فاکتور":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
				Typ_Factor = 0;
				break;
			case "صوری":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '1' And [Ghaleb] = '0')";
				Typ_Soori = 1;
				break;
			case "قالب":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '1')";
				Typ_Ghaleb = 1;
				break;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE [sanadnum] ='" + txt_SanadNo.Text + "' And [Salmali]='" + cmbo_SalMali.Text + "' And " + NoaSanad_filter;
			myReader = Module1.cmd.ExecuteReader();
			if (myReader.HasRows)
			{
				MessageBox.Show("سند شماره " + txt_SanadNo.Text + " موجود است شماره سند جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			myReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad1]([radif],[sanadnum],[karnum],[pkod],[sanaddatey],[sanaddatem],[sanaddated],[fehkod],[forpf],[mablaghk],[pname1],[karkod1],[karname1],[Karname2],[fehrest],[noeSanad],[Salmali],[zarib],[Nameh],[fehrestfile],[Pname2],[Ronevwsht],[Printed],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[Soori],[OnvanCode],[Ghaleb])(SELECT [radif],'" + txt_SanadNo.Text + "'[sanadnum],[karnum],[pkod],[sanaddatey],[sanaddatem],[sanaddated],[fehkod],'" + Conversions.ToString(Typ_Factor) + "'[forpf],[mablaghk],[pname1],[karkod1],[karname1],[Karname2],[fehrest],[noeSanad],'" + cmbo_SalMali.Text + "'[Salmali],[zarib],[Nameh],[fehrestfile],[Pname2],[Ronevwsht],[Printed],'" + Environment.MachineName + "'[IjadSystem],[EslahSystem],''[TimeIjad],[TimeEslah],'" + Conversions.ToString(Typ_Soori) + "'[Soori],[OnvanCode],'" + Conversions.ToString(Typ_Ghaleb) + "'[Ghaleb] FROM [dbo].[asnad1]  WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad2]([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb])(SELECT [radif],'" + txt_SanadNo.Text + "'[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],'" + Conversions.ToString(Typ_Factor) + "'[fopf],'" + cmbo_SalMali.Text + "'[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],'" + Conversions.ToString(Typ_Soori) + "'[Soori],'" + Conversions.ToString(Typ_Ghaleb) + "'[Ghaleb] FROM [dbo].[asnad2]  WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad4]([sanadnum],[fopf],[Sharh],[darsad],[maghtoo],[mablagh],[mablaghk],[Salmali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[Soori],[Ghaleb])SELECT '" + txt_SanadNo.Text + "'[sanadnum],'" + Conversions.ToString(Typ_Factor) + "'[fopf],[Sharh],[darsad],[maghtoo],[mablagh],[mablaghk],'" + cmbo_SalMali.Text + "'[Salmali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],'" + Conversions.ToString(Typ_Soori) + "'[Soori],'" + Conversions.ToString(Typ_Ghaleb) + "'[Ghaleb] FROM [dbo].[asnad4] WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' order by recnum";
			Module1.cmd.ExecuteNonQuery();
			Close();
		}

private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			Close();
		}

private void cmbo_NoaSanad_SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_SanadNo.Text = "";
			switch (cmbo_NoaSanad.Text)
			{
			case "فاکتور":
				NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
				break;
			case "پیش فاکتور":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
				break;
			case "صوری":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '1' And [Ghaleb] = '0')";
				break;
			case "قالب":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '1')";
				break;
			}
			Module1.MyConn.Close();
			Module1.cmd.Connection = Module1.MyConn;
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [sanadnum] FROM [dbo].[asnad1] Where [Salmali]= '" + cmbo_SalMali.Text + "' And " + NoaSanad_filter + " Order By [sanadnum] Desc";
			myReader = Module1.cmd.ExecuteReader();
			while (myReader.Read())
			{
				txt_SanadNo.Text = Conversions.ToString(checked(Conversions.ToInteger(myReader[0].ToString()) + 1));
			}
			if (Operators.CompareString(txt_SanadNo.Text, "", TextCompare: false) == 0)
			{
				txt_SanadNo.Text = "1";
			}
			myReader.Close();
		}

private void cmbo_SalMali_SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_SanadNo.Text = "";
			switch (cmbo_NoaSanad.Text)
			{
			case "فاکتور":
				NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
				break;
			case "پیش فاکتور":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
				break;
			case "صوری":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '1' And [Ghaleb] = '0')";
				break;
			case "قالب":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '1')";
				break;
			}
			Module1.MyConn.Close();
			Module1.cmd.Connection = Module1.MyConn;
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [sanadnum] FROM [dbo].[asnad1] Where [Salmali]= '" + cmbo_SalMali.Text + "' And " + NoaSanad_filter + " Order By [sanadnum] Desc";
			myReader = Module1.cmd.ExecuteReader();
			while (myReader.Read())
			{
				txt_SanadNo.Text = Conversions.ToString(checked(Conversions.ToInteger(myReader[0].ToString()) + 1));
			}
			if (Operators.CompareString(txt_SanadNo.Text, "", TextCompare: false) == 0)
			{
				txt_SanadNo.Text = "1";
			}
			myReader.Close();
		}

    }
}
