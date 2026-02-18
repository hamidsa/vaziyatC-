using System;
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
	internal class Frm_ItemSelect : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Cansel")]
		private Button _btn_Cansel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_ImportSelect")]
		private Button _btn_ImportSelect;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_DelSelect")]
		private Button _btn_DelSelect;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_GroupFltr")]
		private ComboBox _cmbo_GroupFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemVahedSharhFltr")]
		private ComboBox _cmbo_ItemVahedSharhFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemFaslFltr")]
		private ComboBox _cmbo_ItemFaslFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemNoFltr")]
		private TextBox _txt_ItemNoFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemNoaFltr")]
		private ComboBox _cmbo_ItemNoaFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemBahavahedFltr")]
		private TextBox _txt_ItemBahavahedFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemSharhFltr")]
		private TextBox _txt_ItemSharhFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Filter")]
		private Button _btn_Filter;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_FehrestItem")]
		private ComboBox _cmbo_FehrestItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_Item")]
		private DataGridView _dtg_Item;

		public string FaslCode_Filter;

		public string FaslComment_Filter;

		public string ZaribCode_Filter;

		public string ItemNo_Filter;

		public string ItemSharh_Filter;

		public string ItemVahedSharh_Filter;

		public string ItemBahaVahed_Filter;

		public string ItemFasl_Filter;

		public string GroupName_Filter;

		public string ItemNoa_Filter;

		private byte DtgItemRefresh;

		private byte ImportItemsDone;
        private System.Windows.Forms.Button btn_Cansel;
        private System.Windows.Forms.Button btn_ImportSelect;
        private System.Windows.Forms.Button btn_DelSelect;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbo_GroupFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemVahedSharhFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemFaslFltr;
        private System.Windows.Forms.TextBox txt_ItemNoFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemNoaFltr;
        private System.Windows.Forms.TextBox txt_ItemBahavahedFltr;
        private System.Windows.Forms.TextBox txt_ItemSharhFltr;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbo_FehrestItem;
        private System.Windows.Forms.DataGridView dtg_Item;

        public Frm_ItemSelect()
		{
			base.Load += Frm_ItemSelect_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_ItemSelect));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_Cansel = new System.Windows.Forms.Button();
			this.btn_ImportSelect = new System.Windows.Forms.Button();
			this.btn_DelSelect = new System.Windows.Forms.Button();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.cmbo_GroupFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ItemVahedSharhFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ItemFaslFltr = new System.Windows.Forms.ComboBox();
			this.txt_ItemNoFltr = new System.Windows.Forms.TextBox();
			this.cmbo_ItemNoaFltr = new System.Windows.Forms.ComboBox();
			this.txt_ItemBahavahedFltr = new System.Windows.Forms.TextBox();
			this.txt_ItemSharhFltr = new System.Windows.Forms.TextBox();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_FehrestItem = new System.Windows.Forms.ComboBox();
			this.dtg_Item = new System.Windows.Forms.DataGridView();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).BeginInit();
			base.SuspendLayout();
			this.btn_Cansel.Location = new System.Drawing.Point(934, 479);
			this.btn_Cansel.Name = "btn_Cansel";
			this.btn_Cansel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Cansel.Size = new System.Drawing.Size(125, 30);
			this.btn_Cansel.TabIndex = 143;
			this.btn_Cansel.Text = "انصراف";
			this.btn_Cansel.UseVisualStyleBackColor = true;
			this.btn_ImportSelect.Location = new System.Drawing.Point(156, 479);
			this.btn_ImportSelect.Name = "btn_ImportSelect";
			this.btn_ImportSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_ImportSelect.Size = new System.Drawing.Size(125, 30);
			this.btn_ImportSelect.TabIndex = 141;
			this.btn_ImportSelect.Text = "انتقال انتخاب ها به سند";
			this.btn_ImportSelect.UseVisualStyleBackColor = true;
			this.btn_DelSelect.Location = new System.Drawing.Point(555, 479);
			this.btn_DelSelect.Name = "btn_DelSelect";
			this.btn_DelSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_DelSelect.Size = new System.Drawing.Size(125, 30);
			this.btn_DelSelect.TabIndex = 142;
			this.btn_DelSelect.Text = "حذف انتخاب ها";
			this.btn_DelSelect.UseVisualStyleBackColor = true;
			this.pnl_Filter.BackColor = System.Drawing.Color.White;
			this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.cmbo_GroupFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemVahedSharhFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemFaslFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemNoFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemNoaFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemBahavahedFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemSharhFltr);
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Location = new System.Drawing.Point(12, 46);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1180, 49);
			this.pnl_Filter.TabIndex = 139;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1078, 4);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(54, 43);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmbo_GroupFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_GroupFltr.FormattingEnabled = true;
			this.cmbo_GroupFltr.Location = new System.Drawing.Point(0, 26);
			this.cmbo_GroupFltr.Name = "cmbo_GroupFltr";
			this.cmbo_GroupFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_GroupFltr.Size = new System.Drawing.Size(205, 25);
			this.cmbo_GroupFltr.TabIndex = 135;
			this.cmbo_ItemVahedSharhFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemVahedSharhFltr.FormattingEnabled = true;
			this.cmbo_ItemVahedSharhFltr.Location = new System.Drawing.Point(378, 26);
			this.cmbo_ItemVahedSharhFltr.Name = "cmbo_ItemVahedSharhFltr";
			this.cmbo_ItemVahedSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemVahedSharhFltr.Size = new System.Drawing.Size(97, 25);
			this.cmbo_ItemVahedSharhFltr.TabIndex = 77;
			this.cmbo_ItemFaslFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemFaslFltr.FormattingEnabled = true;
			this.cmbo_ItemFaslFltr.Location = new System.Drawing.Point(476, 26);
			this.cmbo_ItemFaslFltr.Name = "cmbo_ItemFaslFltr";
			this.cmbo_ItemFaslFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemFaslFltr.Size = new System.Drawing.Size(41, 25);
			this.cmbo_ItemFaslFltr.TabIndex = 76;
			this.txt_ItemNoFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemNoFltr.Location = new System.Drawing.Point(1017, 26);
			this.txt_ItemNoFltr.Name = "txt_ItemNoFltr";
			this.txt_ItemNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemNoFltr.Size = new System.Drawing.Size(60, 24);
			this.txt_ItemNoFltr.TabIndex = 74;
			this.cmbo_ItemNoaFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemNoaFltr.FormattingEnabled = true;
			this.cmbo_ItemNoaFltr.Location = new System.Drawing.Point(206, 26);
			this.cmbo_ItemNoaFltr.Name = "cmbo_ItemNoaFltr";
			this.cmbo_ItemNoaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemNoaFltr.Size = new System.Drawing.Size(99, 25);
			this.cmbo_ItemNoaFltr.TabIndex = 73;
			this.txt_ItemBahavahedFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemBahavahedFltr.Location = new System.Drawing.Point(306, 26);
			this.txt_ItemBahavahedFltr.Name = "txt_ItemBahavahedFltr";
			this.txt_ItemBahavahedFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemBahavahedFltr.Size = new System.Drawing.Size(71, 24);
			this.txt_ItemBahavahedFltr.TabIndex = 54;
			this.txt_ItemSharhFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemSharhFltr.Location = new System.Drawing.Point(518, 26);
			this.txt_ItemSharhFltr.Name = "txt_ItemSharhFltr";
			this.txt_ItemSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemSharhFltr.Size = new System.Drawing.Size(498, 24);
			this.txt_ItemSharhFltr.TabIndex = 50;
			this.btn_Filter.BackColor = System.Drawing.Color.LightGray;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Location = new System.Drawing.Point(1132, 3);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(43, 44);
			this.btn_Filter.TabIndex = 44;
			this.btn_Filter.Text = "حذف فیلتر";
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(16, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1159, 25);
			this.PictureBox1.TabIndex = 75;
			this.PictureBox1.TabStop = false;
			this.cmbo_FehrestItem.BackColor = System.Drawing.SystemColors.Window;
			this.cmbo_FehrestItem.Font = new System.Drawing.Font("B Titr", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestItem.ForeColor = System.Drawing.Color.Black;
			this.cmbo_FehrestItem.FormattingEnabled = true;
			this.cmbo_FehrestItem.Location = new System.Drawing.Point(204, 6);
			this.cmbo_FehrestItem.Name = "cmbo_FehrestItem";
			this.cmbo_FehrestItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestItem.Size = new System.Drawing.Size(800, 37);
			this.cmbo_FehrestItem.TabIndex = 140;
			this.dtg_Item.AllowUserToAddRows = false;
			this.dtg_Item.AllowUserToDeleteRows = false;
			this.dtg_Item.AllowUserToOrderColumns = true;
			this.dtg_Item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dtg_Item.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dtg_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Item.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Item.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Item.GridColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Item.Location = new System.Drawing.Point(12, 73);
			this.dtg_Item.Name = "dtg_Item";
			this.dtg_Item.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Item.Size = new System.Drawing.Size(1180, 400);
			this.dtg_Item.TabIndex = 138;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Info;
			base.ClientSize = new System.Drawing.Size(1204, 512);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.btn_Cansel);
			base.Controls.Add(this.btn_ImportSelect);
			base.Controls.Add(this.btn_DelSelect);
			base.Controls.Add(this.cmbo_FehrestItem);
			base.Controls.Add(this.dtg_Item);
			base.Name = "Frm_ItemSelect";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتقال ایتم به سند";
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).EndInit();
			base.ResumeLayout(false);
            this.btn_Cansel.Click += new System.EventHandler(this.btn_Cansel_Click);
            this.btn_ImportSelect.Click += new System.EventHandler(this.btn_ImportSelect_Click);
            this.btn_DelSelect.Click += new System.EventHandler(this.btn_DelSelect_Click);
            this.cmbo_GroupFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_GroupFltr_SelectedIndexChanged);
            this.cmbo_GroupFltr.TextChanged += new System.EventHandler(this.cmbo_GroupFltr_TextChanged);
            this.cmbo_GroupFltr.LostFocus += new System.EventHandler(this.cmbo_GroupFltr_LostFocus);
            this.cmbo_GroupFltr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbo_GroupFltr_MouseClick);
            this.cmbo_ItemVahedSharhFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemVahedSharhFltr_SelectedIndexChanged);
            this.cmbo_ItemFaslFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemFaslFltr_SelectedIndexChanged);
            this.txt_ItemNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNoFltr_KeyDown);
            this.cmbo_ItemNoaFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_SelectedIndexChanged);
            this.cmbo_ItemNoaFltr.TextChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_TextChanged);
            this.txt_ItemBahavahedFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahedFltr_KeyDown);
            this.txt_ItemSharhFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemSharhFltr_KeyDown);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.cmbo_FehrestItem.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestItem_SelectedIndexChanged);
            this.dtg_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellClick);
            this.dtg_Item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellDoubleClick);
            this.dtg_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Item_KeyDown);
        }

		private void Frm_ItemSelect_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			Module1.strWhere = " ";
			DtgItemRefresh = 0;
			ImportItemsDone = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [fehrest] FROM [dbo].[Fehrest] Group By [fehrest] Order by [fehrest]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_FehrestItem.DataSource = dataTable;
			cmbo_FehrestItem.DisplayMember = "Fehrest";
			DtgItemRefresh = 1;
			cmbo_FehrestItem.Text = Module1.CurrentFehrestName;
			Module1.CurrentFehrestFile = Module1.FindCodeOrName(Module1.CurrentFehrestName, "[fehrest]", "[filename]", "[fehrest]");
			Module1.Load_Cmbo(cmbo_ItemFaslFltr, Module1.CurrentFehrestFile, "Fasl", "");
			Module1.Load_Cmbo(cmbo_ItemVahedSharhFltr, Module1.CurrentFehrestFile, "Vahed", "");
			Module1.Load_Cmbo(cmbo_ItemNoaFltr, Module1.CurrentFehrestFile, "ItemNoa", "");
			Module1.Load_Cmbo(cmbo_GroupFltr, Module1.CurrentFehrestFile, "GroupName", "");
			Load_dtg_Item();
			sqlDataReader.Close();
		}

		private void cmbo_FehrestItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh == 0)
			{
				return;
			}
			DtgItemRefresh = 0;
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			DataTable dataTable4 = new DataTable();
			if (Operators.CompareString(cmbo_FehrestItem.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where [Fehrest] =N'" + cmbo_FehrestItem.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			if (Module1.CurrentFehrestFile == null)
			{
				return;
			}
			cmbo_ItemFaslFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Fasl] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [Fasl] Order By [Fasl]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_ItemFaslFltr.Items.Add("");
			foreach (DataRow row in dataTable.Rows)
			{
				cmbo_ItemFaslFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Fasl"]));
			}
			cmbo_ItemFaslFltr.Text = "";
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemVahedSharhFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Vahed] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [Vahed] Order By [Vahed]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable2.Load(sqlDataReader);
			cmbo_ItemVahedSharhFltr.Items.Add("");
			foreach (DataRow row2 in dataTable2.Rows)
			{
				cmbo_ItemVahedSharhFltr.Items.Add(RuntimeHelpers.GetObjectValue(row2["Vahed"]));
			}
			cmbo_ItemVahedSharhFltr.Text = "";
			sqlDataReader.Close();
			dataTable2.Clear();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_GroupFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [GroupNo],[GroupName] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [GroupNo],[GroupName] Order By [GroupNo]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable3.Load(sqlDataReader);
			cmbo_GroupFltr.Items.Add("");
			foreach (DataRow row3 in dataTable3.Rows)
			{
				cmbo_GroupFltr.Items.Add(RuntimeHelpers.GetObjectValue(row3["GroupName"]));
			}
			cmbo_GroupFltr.Text = "";
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemNoaFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [ItemNoa] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [ItemNoa] Order By [ItemNoa]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable4.Load(sqlDataReader);
			cmbo_ItemNoaFltr.Items.Add("");
			foreach (DataRow row4 in dataTable4.Rows)
			{
				cmbo_ItemNoaFltr.Items.Add(RuntimeHelpers.GetObjectValue(row4["ItemNoa"]));
			}
			cmbo_ItemNoaFltr.Text = "";
			sqlDataReader.Close();
			Module1.MyConn.Close();
			Load_dtg_Item();
		}

		public void Load_dtg_Item()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[7];
			cmbo_GroupFltr.Width = 205;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 5);
				if (Operators.CompareString(ItemNo_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemVahedSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahaVahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
				}
				if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0 && Operators.CompareString(GroupName_Filter, "", TextCompare: false) != 0)
				{
					array[6] = " And ";
				}
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemSharh_Filter + array[2] + ItemVahedSharh_Filter + array[3] + ItemBahaVahed_Filter + array[4] + ItemFasl_Filter + array[5] + ItemNoa_Filter + array[6] + GroupName_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) != 0)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [radif] As 'Id',[Selection] As '*',[radif] As 'ردیف',[shomar] As 'ایتم',[Sharh] As 'شرح ایتم',[Fasl] As 'فصل',[Vahed] As 'واحد',[baha] As 'بها',[ItemNoa] As 'نوع ایتم',[ItemDarsad] As 'درصد نسبت به',[GroupName] As 'گروه' FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Order By [shomar]";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					dataTable.Load(sqlDataReader);
					foreach (DataColumn column in dataTable.Columns)
					{
						column.ReadOnly = false;
					}
					int num2 = dataTable.Rows.Count - 1;
					for (int i = 0; i <= num2; i++)
					{
						dataTable.Rows[i]["ردیف"] = i + 1;
						dataTable.Rows[i]["*"] = 0;
					}
					dtg_Item.DataSource = dataTable;
					dtg_Item.Columns[0].Visible = false;
					dtg_Item.Columns[1].Visible = true;
					dtg_Item.Columns[1].Width = 20;
					dtg_Item.Columns[2].ReadOnly = true;
					dtg_Item.Columns[2].Width = 40;
					dtg_Item.Columns[3].ReadOnly = true;
					dtg_Item.Columns[3].Width = 60;
					dtg_Item.Columns[4].ReadOnly = true;
					dtg_Item.Columns[4].Width = 500;
					dtg_Item.Columns[5].ReadOnly = true;
					dtg_Item.Columns[5].Width = 40;
					dtg_Item.Columns[6].ReadOnly = true;
					dtg_Item.Columns[6].Width = 100;
					dtg_Item.Columns[7].ReadOnly = true;
					dtg_Item.Columns[7].Width = 70;
					dtg_Item.Columns[8].ReadOnly = true;
					dtg_Item.Columns[8].Width = 100;
					dtg_Item.Columns[9].ReadOnly = true;
					dtg_Item.Columns[9].Visible = false;
					dtg_Item.Columns[10].ReadOnly = true;
					dtg_Item.Columns[10].Width = 190;
					dtg_Item.Refresh();
					sqlDataReader.Close();
				}
				Module1.MyConn.Close();
			}
		}

		private void dtg_Item_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 1)
			{
				ItemSelection();
			}
		}

		private void dtg_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			ItemSelection();
		}

		private void dtg_Item_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				ItemSelection();
			}
		}

		private void ItemSelection()
		{
			if (dtg_Item.RowCount == 0)
			{
				return;
			}
			if (Operators.ConditionalCompareObjectEqual(dtg_Item.CurrentRow.Cells[1].Value, true, TextCompare: false))
			{
				dtg_Item.CurrentRow.Cells[1].Value = false;
				dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.White;
				dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0' WHERE [shomar]='", dtg_Item.CurrentRow.Cells[3].Value), "'"));
				Module1.cmd.ExecuteNonQuery();
			}
			else
			{
				dtg_Item.CurrentRow.Cells[1].Value = true;
				dtg_Item.CurrentRow.Selected = true;
				dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.Cyan;
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '1' WHERE [shomar]='", dtg_Item.CurrentRow.Cells[3].Value), "'"));
				Module1.cmd.ExecuteNonQuery();
			}
		}

		private void btn_Cansel_Click(object sender, EventArgs e)
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [Selection] = '0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn.Close();
			Close();
			MyProject.Forms.Frm_AsnadDetail.Load_dtg_AsnadDetail(MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text);
		}

		private void btn_DelSelect_Click(object sender, EventArgs e)
		{
			Load_dtg_Item();
		}

		private void btn_ImportSelect_Click(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT [shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa] FROM [Jahdazma1].[dbo]." + Module1.CurrentFehrestFile + " where [Selection]='1'";
			SqlDataReader reader = Module1.cmd.ExecuteReader();
			dataTable.Load(reader);
			foreach (DataRow row in dataTable.Rows)
			{
				Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("INSERT INTO [dbo].[Asnad2] ([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) VALUES('0','" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "','", row["shomar"]), "','"), row["Sharh"]), "','0','','','"), row["Fasl"]), "','0','"), row["baha"]), "','"), row["Vahed"]), "','0','"), row["darsad"]), "','"), row["setareh"]), "',(Case When '"), row["darsad"]), "' ='True' THEN '"), row["baha"]), "' Else '0' End),'0','','"), Module1.SanadRec.forpf), "','"), Module1.SanadRec.SalMali), "','"), Environment.MachineName), "','','','','','','','','0','0','"), Module1.SanadRec.Soori), "','"), Module1.SanadRec.Ghaleb), "')"));
				Module1.cmd.ExecuteNonQuery();
			}
			Module1.MyConn.Close();
			btn_Cansel_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void txt_ItemNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemNoFltr.Text;
					ItemNo_Filter = " ([shomar] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemNo_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void txt_ItemSharhFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemSharhFltr.Text;
					ItemSharh_Filter = " ([Sharh] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void cmbo_ItemFaslFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemFaslFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemFaslFltr.Text;
					ItemFasl_Filter = " ([Fasl] Like '%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemFasl_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void cmbo_ItemVahedSharhFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemVahedSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemVahedSharhFltr.Text;
					ItemVahedSharh_Filter = " (REPLACE(REPLACE([Vahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemVahedSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
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
					ItemBahaVahed_Filter = " (cast([baha] as decimal(18,0)) Like '%" + Conversions.ToString(Conversion.Val(array[0])) + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahaVahed_Filter = "([baha] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahaVahed_Filter = "";
				}
			}
			else
			{
				ItemBahaVahed_Filter = "";
			}
			Load_dtg_Item();
		}

		private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_ItemNoaFltr.Text;
					ItemNoa_Filter = " ([ItemNoa] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					ItemNoa_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void cmbo_ItemNoaFltr_TextChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				string text = cmbo_ItemNoaFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					ItemNoa_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				else
				{
					ItemNoa_Filter = " (REPLACE(REPLACE([ItemNoa],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void cmbo_GroupFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				if (Operators.CompareString(cmbo_GroupFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = cmbo_GroupFltr.Text;
					GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				else
				{
					GroupName_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void cmbo_GroupFltr_TextChanged(object sender, EventArgs e)
		{
			if (DtgItemRefresh != 0)
			{
				string text = cmbo_GroupFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) == 0)
				{
					GroupName_Filter = "";
					btn_Filter.Text = "فیلتر";
				}
				else
				{
					GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
				}
				Load_dtg_Item();
			}
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			FaslCode_Filter = "";
			FaslComment_Filter = "";
			ZaribCode_Filter = "";
			ItemNo_Filter = "";
			ItemSharh_Filter = "";
			ItemVahedSharh_Filter = "";
			ItemBahaVahed_Filter = "";
			ItemFasl_Filter = "";
			GroupName_Filter = "";
			ItemNoa_Filter = "";
			Load_dtg_Item();
			txt_ItemNoFltr.Text = "";
			txt_ItemSharhFltr.Text = "";
			cmbo_ItemFaslFltr.Text = "";
			cmbo_ItemVahedSharhFltr.Text = "";
			txt_ItemBahavahedFltr.Text = "";
			cmbo_ItemNoaFltr.Text = "";
			cmbo_GroupFltr.Text = "";
		}

		private void cmbo_GroupFltr_LostFocus(object sender, EventArgs e)
		{
			cmbo_GroupFltr.Width = 205;
		}

		private void cmbo_GroupFltr_MouseClick(object sender, MouseEventArgs e)
		{
			cmbo_GroupFltr.Width = 310;
		}
	}
}
