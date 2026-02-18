using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class Frm_AsnadGhaleb : Form
	{
		private IContainer components;



		private byte frmGhalebRefresh;

		private string GhalebNO_filter;

		private string GhalebName_filter;

		private string GhalebFehrestName_filter;

		private string GhalebFehrestName;


        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.DataGridView dtg_AsnadGhaleb;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbo_FehrestNameFltr;
        private System.Windows.Forms.TextBox txt_GhalebNoFltr;
        private System.Windows.Forms.TextBox txt_GhalebNameFltr;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button btn_Filter;

        

		public Frm_AsnadGhaleb()
		{
			base.Load += Frm_AsnadGhaleb_Load;
			InitializeComponent();
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_AsnadGhaleb));
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Select = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.dtg_AsnadGhaleb = new System.Windows.Forms.DataGridView();
			this.Label1 = new System.Windows.Forms.Label();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_FehrestNameFltr = new System.Windows.Forms.ComboBox();
			this.txt_GhalebNoFltr = new System.Windows.Forms.TextBox();
			this.txt_GhalebNameFltr = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadGhaleb).BeginInit();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.btn_Select, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(34, 419);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(809, 29);
			this.TableLayoutPanel1.TabIndex = 0;
			this.btn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Select.Location = new System.Drawing.Point(169, 3);
			this.btn_Select.Name = "btn_Select";
			this.btn_Select.Size = new System.Drawing.Size(67, 23);
			this.btn_Select.TabIndex = 0;
			this.btn_Select.Text = "انتخاب";
			this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(574, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "انصراف";
			this.dtg_AsnadGhaleb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_AsnadGhaleb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_AsnadGhaleb.Location = new System.Drawing.Point(34, 73);
			this.dtg_AsnadGhaleb.MultiSelect = false;
			this.dtg_AsnadGhaleb.Name = "dtg_AsnadGhaleb";
			this.dtg_AsnadGhaleb.ReadOnly = true;
			this.dtg_AsnadGhaleb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_AsnadGhaleb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_AsnadGhaleb.Size = new System.Drawing.Size(810, 316);
			this.dtg_AsnadGhaleb.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("B Homa", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.Location = new System.Drawing.Point(350, 14);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(194, 35);
			this.Label1.TabIndex = 2;
			this.Label1.Text = " قالب سند را انتخاب کنید :";
			this.pnl_Filter.BackColor = System.Drawing.Color.White;
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.cmbo_FehrestNameFltr);
			this.pnl_Filter.Controls.Add(this.txt_GhalebNoFltr);
			this.pnl_Filter.Controls.Add(this.txt_GhalebNameFltr);
			this.pnl_Filter.Controls.Add(this.Button7);
			this.pnl_Filter.Location = new System.Drawing.Point(34, 53);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(810, 56);
			this.pnl_Filter.TabIndex = 89;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(766, 1);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(43, 54);
			this.btn_Filter.TabIndex = 157;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(720, 1);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(46, 53);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(19, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(776, 31);
			this.PictureBox1.TabIndex = 156;
			this.PictureBox1.TabStop = false;
			this.cmbo_FehrestNameFltr.FormattingEnabled = true;
			this.cmbo_FehrestNameFltr.Location = new System.Drawing.Point(18, 33);
			this.cmbo_FehrestNameFltr.Name = "cmbo_FehrestNameFltr";
			this.cmbo_FehrestNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestNameFltr.Size = new System.Drawing.Size(150, 21);
			this.cmbo_FehrestNameFltr.TabIndex = 95;
			this.txt_GhalebNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_GhalebNoFltr.Location = new System.Drawing.Point(670, 33);
			this.txt_GhalebNoFltr.Name = "txt_GhalebNoFltr";
			this.txt_GhalebNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_GhalebNoFltr.Size = new System.Drawing.Size(49, 21);
			this.txt_GhalebNoFltr.TabIndex = 55;
			this.txt_GhalebNameFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_GhalebNameFltr.Location = new System.Drawing.Point(169, 33);
			this.txt_GhalebNameFltr.Name = "txt_GhalebNameFltr";
			this.txt_GhalebNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_GhalebNameFltr.Size = new System.Drawing.Size(500, 21);
			this.txt_GhalebNameFltr.TabIndex = 54;
			this.Button7.BackColor = System.Drawing.Color.LightGray;
			this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button7.ForeColor = System.Drawing.Color.Black;
			this.Button7.Location = new System.Drawing.Point(1506, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(89, 21);
			this.Button7.TabIndex = 44;
			this.Button7.Text = "حذف فیلتر";
			this.Button7.UseVisualStyleBackColor = false;
			base.AcceptButton = this.btn_Select;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btn_Cancel;
			base.ClientSize = new System.Drawing.Size(875, 457);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.TableLayoutPanel1);
			base.Controls.Add(this.dtg_AsnadGhaleb);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Frm_AsnadGhaleb";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتخاب قالب سند";
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadGhaleb).EndInit();
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel_Button_Click);
            this.dtg_AsnadGhaleb.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellContentDoubleClick);
            this.dtg_AsnadGhaleb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellDoubleClick);
            this.dtg_AsnadGhaleb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellContentClick);
            this.cmbo_FehrestNameFltr.TextChanged += new System.EventHandler(this.cmbo_FehrestNameFltr_TextChanged);
            this.txt_GhalebNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GhalebNoFltr_KeyDown);
            this.txt_GhalebNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GhalebNameFltr_KeyDown);
        }

		private void Frm_AsnadGhaleb_Load(object sender, EventArgs e)
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
