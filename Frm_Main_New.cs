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
    public partial class Frm_Main_New : Form
    {
        // Private fields
        private ToolStripMenuItem _mnu_Project;
        private ToolStripMenuItem _mnu_Karfarma;
        private ToolStripMenuItem _mnu_Fehrest;
        private ToolStripMenuItem _mnu_ZaribMantaghe;
        private ToolStripButton _tlsb_Project;
        private ToolStripButton _tlsb_Karfarma;
        private ToolStripMenuItem _mnu_Exit;
        private ToolStripButton _tlsb_Exit;
        private ToolStripMenuItem _mnu_Anavin;
        private ToolStripMenuItem _mnu_Factor;
        private ToolStripMenuItem _mnu_PishFactor;
        private ToolStripMenuItem _mnu_Soori;
        private ToolStripMenuItem _mnu_Ghaleb;
        private ToolStripMenuItem _mnu_Enteghal;
        private TextBox _txtAuth4;
        private TextBox _txtAuth3;
        private TextBox _txtAuth2;
        private Button _cmdOk;
        private TextBox _txtAuth1;
        private int Tries;

        // Public DataTables
        public DataTable TableFosoolSum;
        public DataTable TableSanadSum;
        public DataTable AsnadDetailTable;

        public Frm_Main_New()
        {
            InitializeComponent();
            InitializeCustomData();
        }

        private void InitializeCustomData()
        {
            this.KeyPreview = true;
            this.KeyDown += Frm_Main_New_KeyDown;
            this.Load += Frm_Main_New_Load;

            TableFosoolSum = new DataTable();
            TableSanadSum = new DataTable();
            AsnadDetailTable = new DataTable();
        }

        // اضافه کردن event handlerهای گمشده
        private void فهرستبهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Frm_Fehrest.Load_dtg_Fehrest();
        }

        private void فصولToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.FAslOrItem = "Fasl";
            MyProject.Forms.Frm_FehrestDetail.tbp_Fosool_Enter(RuntimeHelpers.GetObjectValue(sender), e);
        }

        private void آیتمهاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Module1.FAslOrItem = "Item";
            MyProject.Forms.Frm_FehrestDetail.tbp_Item_Enter(RuntimeHelpers.GetObjectValue(sender), e);
        }

        private void tlsb_Project_Click(object sender, EventArgs e)
        {
            mnu_Project_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }

        private void tlsb_Exit_Click(object sender, EventArgs e)
        {
            ProjectData.EndApp();
        }

        private void tlsb_Karfarma_Click(object sender, EventArgs e)
        {
            mnu_Karfarma_Click(RuntimeHelpers.GetObjectValue(sender), e);
        }

        public void mnu_Project_Click(object sender, EventArgs e)
        {
            Module1.BtnProjectList = true;
            MyProject.Forms.Frm_Project.Visible = true;
            MyProject.Forms.Frm_Project.Load_dtg_Project();
        }

        public void mnu_Karfarma_Click(object sender, EventArgs e)
        {
            Module1.BtnKarfarmaList = true;
            MyProject.Forms.Frm_Karfarma.Visible = true;
            MyProject.Forms.Frm_Karfarma.Load_dtg_Karfarma();
            MyProject.Forms.Frm_Karfarma.pnl_Karfarma.Visible = true;
        }

        private void mnu_Exit_Click(object sender, EventArgs e)
        {
            ProjectData.EndApp();
        }

        public void mnu_Fehrest_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Frm_Fehrest.Load_dtg_Fehrest();
        }

        private void mnu_ZaribMantaghe_Click(object sender, EventArgs e)
        {
            MyProject.Forms.Frm_ZarayebMantaghe.ShowDialog();
        }

        private void mnu_Anavin_Click(object sender, EventArgs e)
        {
            MyProject.Forms.frm_AsnadOnvan.ShowDialog();
        }

        private void mnu_Factor_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "فاکتور";
            MyProject.Forms.Frm_AsnadList.ShowDialog();
        }

        private void mnu_PishFactor_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "پیش فاکتور";
            MyProject.Forms.Frm_AsnadList.ShowDialog();
        }

        private void mnu_Soori_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "صوری";
            MyProject.Forms.Frm_AsnadList.ShowDialog();
        }

        private void mnu_Ghaleb_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "قالب";
            MyProject.Forms.Frm_AsnadList.ShowDialog();
        }

        private void mnu_Total_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "همه";
            MyProject.Forms.Frm_AsnadList.ShowDialog();
        }

        private void Frm_Main_New_Load(object sender, EventArgs e)
        {
            if (Module1.MyConn.State == ConnectionState.Closed)
            {
                Module1.MyConn.Open();
            }
            Module1.cmd.Connection = Module1.MyConn;
            Module1.cmd.CommandText = "SELECT COUNT([sanadnum]) FROM [Jahdazma1].[dbo].[asnad1]";
            SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (Conversions.ToBoolean(Operators.OrObject(Operators.CompareObjectEqual(Operators.ModObject(sqlDataReader[0], 999), 0, TextCompare: false), Operators.CompareObjectGreater(sqlDataReader[0], 66000, TextCompare: false))))
                {
                    base.MainMenuStrip.Hide();
                    Pnl_Authen.Hide();
                    int num = Conversions.ToInteger(MyProject.Forms.Frm_AsnadList.dtg_AsnadList.Rows[10].Cells[0].Value);
                }
            }
            sqlDataReader.Close();
            if (Module1.MyConn.State == ConnectionState.Closed)
            {
                Module1.MyConn.Open();
            }
            Module1.cmd.Connection = Module1.MyConn;
            Module1.cmd.CommandText = "SELECT [version] FROM [Jahdazma1].[dbo].[GeoJahdVer]";
            sqlDataReader = Module1.cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (Operators.ConditionalCompareObjectNotEqual(sqlDataReader[0], 100, TextCompare: false))
                {
                    DialogResult dialogResult = MessageBox.Show(".لطفا از ورژن جدید برنامه استفاده کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ProjectData.EndApp();
                }
            }
            sqlDataReader.Close();
            Auth.AMain();
            if (Module1.MyConn.State == ConnectionState.Closed)
            {
                Module1.MyConn.Open();
            }
            Module1.cmd.Connection = Module1.MyConn;
            Module1.cmd.CommandText = "SELECT  [fehrest],[filename] FROM [dbo].[Fehrest] where [jari]= '(پايه)'";
            sqlDataReader = Module1.cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Module1.MabnaFehresrName = sqlDataReader[0].ToString();
                Module1.MabnaFehresrFile = sqlDataReader[1].ToString();
            }
            sqlDataReader.Close();
            Module1.cmd.CommandText = "SELECT  [EsmRamz] FROM [dbo].[Moshakhasat] where [OnvanMabna]= 'مبنا'";
            sqlDataReader = Module1.cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Module1.MabnaOnvan = sqlDataReader[0].ToString();
            }
        }

        private void mnu_Enteghal_Click(object sender, EventArgs e)
        {
            Module1.NoaSanad = "فاکتور";
            MyProject.Forms.Frm_Enteghal.ShowDialog();
        }

        private void txtRec1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyChar = e.KeyChar;
            if (keyChar != 8 && (uint)(keyChar - 71) > 15u)
            {
                if (keyChar > 102 && keyChar < 119)
                {
                    e.KeyChar = Strings.ChrW(checked(keyChar - 32));
                }
                else
                {
                    e.KeyChar = '\0';
                }
                if (Strings.Len(txtRec1.Text) > 3)
                {
                    txtRec2.Focus();
                }
            }
        }

        private void txtRec2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyChar = e.KeyChar;
            if (keyChar != 8 && (uint)(keyChar - 71) > 15u)
            {
                if (keyChar > 102 && keyChar < 119)
                {
                    e.KeyChar = Strings.ChrW(checked(keyChar - 32));
                }
                else
                {
                    e.KeyChar = '\0';
                }
                if (Strings.Len(txtRec2.Text) > 3)
                {
                    txtRec3.Focus();
                }
            }
        }

        private void txtRec3_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyChar = e.KeyChar;
            if (keyChar != 8 && (uint)(keyChar - 71) > 15u)
            {
                if (keyChar > 102 && keyChar < 119)
                {
                    e.KeyChar = Strings.ChrW(checked(keyChar - 32));
                }
                else
                {
                    e.KeyChar = '\0';
                }
                if (Strings.Len(txtRec3.Text) > 3)
                {
                    txtRec4.Focus();
                }
            }
        }

        private void txtRec4_KeyPress(object sender, KeyPressEventArgs e)
        {
            int keyChar = e.KeyChar;
            if (keyChar != 8 && (uint)(keyChar - 71) > 15u)
            {
                if (keyChar > 102 && keyChar < 119)
                {
                    e.KeyChar = Strings.ChrW(checked(keyChar - 32));
                }
                else
                {
                    e.KeyChar = '\0';
                }
                if (Strings.Len(txtRec4.Text) > 3)
                {
                    cmdOk.Focus();
                }
            }
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            string text = txtRec1.Text;
            text += txtRec2.Text;
            text += txtRec3.Text;
            text += txtRec4.Text;
            checked
            {
                if (Operators.CompareString(text, Auth.AuthString, TextCompare: false) != 0)
                {
                    Tries++;
                    if (Tries == 3)
                    {
                        Interaction.MsgBox("خطا در فعال سازی برنامه", MsgBoxStyle.Critical, "اخطار");
                        Close();
                        ProjectData.EndApp();
                    }
                    else
                    {
                        Interaction.MsgBox("1-TempStr=" + text + "     AuthString=" + text, MsgBoxStyle.Critical, "");
                    }
                }
                else
                {
                    Interaction.MsgBox("2-TempStr=" + text + "     TempStr=" + text, MsgBoxStyle.Critical, "");
                    Interaction.SaveSetting("active", "Options", "lock", Auth.AuthString);
                    Auth.AuthKey = true;
                    Pnl_Authen.Visible = false;
                    mnu_Taarif.Visible = true;
                }
            }
        }

        private void Frm_Main_New_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void Frm_Main_New_ContextMenuStripChanged(object sender, EventArgs e)
        {
        }
    }
}