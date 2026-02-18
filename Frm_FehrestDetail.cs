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
	public class Frm_FehrestDetail : Form
	{
		public struct FehrestFaslDetailes
		{
			public int Id;

			public string FehrestFile;

			public string FaslCode;

			public string FaslComment;

			public string ZaribCode;
		}

		public struct FehrestItemDetailes
		{
			public int Id;

			public string ItemNo;

			public string ItemSharh;

			public string ItemFasl;

			public int ItemVahedCode;

			public string ItemVahedSharh;

			public float ItemBahaVahed;

			public string ItemNoa;

			public string ItemDarsad;

			public string GroupName;
		}

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tbp_Item")]
		private TabPage _tbp_Item;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_FehrestItem")]
		private ComboBox _cmbo_FehrestItem;

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
		[AccessedThroughProperty("dtg_Item")]
		private DataGridView _dtg_Item;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("tbp_Fosool")]
		private TabPage _tbp_Fosool;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_Fehrest")]
		private ComboBox _cmbo_Fehrest;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_Fosool")]
		private DataGridView _dtg_Fosool;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ZaribCode")]
		private ComboBox _cmbo_ZaribCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Save")]
		private Button _Btn_Save;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_FaslCode")]
		private TextBox _txt_FaslCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_FaslComment")]
		private TextBox _txt_FaslComment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemNoa")]
		private ComboBox _cmbo_ItemNoa;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemBahavahed")]
		private TextBox _txt_ItemBahavahed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_SaveItem")]
		private Button _btn_SaveItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_VahedSearch")]
		private Button _btn_VahedSearch;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemNo")]
		private TextBox _txt_ItemNo;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemSharh")]
		private TextBox _txt_ItemSharh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemFaslFltr")]
		private ComboBox _cmbo_ItemFaslFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemVahedSharhFltr")]
		private ComboBox _cmbo_ItemVahedSharhFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ZaribComment")]
		private TextBox _txt_ZaribComment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Insert")]
		private Button _Btn_Insert;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Copy")]
		private Button _Btn_Copy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Delete")]
		private Button _btn_Delete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Exit")]
		private Button _Btn_Exit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_ExitItem")]
		private Button _btn_ExitItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_CopyItem")]
		private Button _btn_CopyItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_DeleteItem")]
		private Button _btn_DeleteItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_InsertItem")]
		private Button _btn_InsertItem;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ItemDarsad")]
		private TextBox _txt_ItemDarsad;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_GroupFltr")]
		private ComboBox _cmbo_GroupFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemVahedSharh")]
		private ComboBox _cmbo_ItemVahedSharh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ItemFasl")]
		private ComboBox _cmbo_ItemFasl;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_GroupSearch")]
		private Button _btn_GroupSearch;

		public FehrestFaslDetailes Fasl;

		public FehrestItemDetailes Item;

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

		private string BtnCommand;

		private string ChangeFossolDtgOrPnl;

		private string ChangeItemDtgOrPnl;

		private byte DtgFosoolRefresh;

		private byte DtgItemRefresh;

		private byte Darsadi;

		private byte setarehdar;
        private System.Windows.Forms.TabPage tbp_Item;
        private System.Windows.Forms.ComboBox cmbo_FehrestItem;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.TextBox txt_ItemNoFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemNoaFltr;
        private System.Windows.Forms.TextBox txt_ItemBahavahedFltr;
        private System.Windows.Forms.TextBox txt_ItemSharhFltr;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.DataGridView dtg_Item;
        private System.Windows.Forms.TabPage tbp_Fosool;
        private System.Windows.Forms.ComboBox cmbo_Fehrest;
        private System.Windows.Forms.DataGridView dtg_Fosool;
        private System.Windows.Forms.Panel pnl_Fasl;
        private System.Windows.Forms.ComboBox cmbo_ZaribCode;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txt_FaslCode;
        private System.Windows.Forms.TextBox txt_FaslComment;
        private System.Windows.Forms.TabControl tab_Fosool;
        private System.Windows.Forms.Panel pnl_Item;
        private System.Windows.Forms.ComboBox cmbo_ItemNoa;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.TextBox txt_ItemBahavahed;
        private System.Windows.Forms.Label Label30;
        private System.Windows.Forms.Label Label31;
        private System.Windows.Forms.Button btn_SaveItem;
        private System.Windows.Forms.Button btn_VahedSearch;
        private System.Windows.Forms.TextBox txt_ItemNo;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Label Label43;
        private System.Windows.Forms.TextBox txt_ItemSharh;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbo_ItemFaslFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemVahedSharhFltr;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txt_ZaribComment;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button btn_ExitItem;
        private System.Windows.Forms.Button btn_CopyItem;
        private System.Windows.Forms.Button btn_DeleteItem;
        private System.Windows.Forms.Button btn_InsertItem;
        private System.Windows.Forms.TextBox txt_ItemDarsad;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox cmbo_Group;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.ComboBox cmbo_GroupFltr;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbo_ItemVahedSharh;
        private System.Windows.Forms.ComboBox cmbo_ItemFasl;
        private System.Windows.Forms.Button btn_GroupSearch;

        public Frm_FehrestDetail()
		{
			base.KeyDown += Frm_FehrestDetail_KeyDown;
			base.Load += Frm_FehrestDetail_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_FehrestDetail));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tbp_Item = new System.Windows.Forms.TabPage();
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
			this.pnl_Item = new System.Windows.Forms.Panel();
			this.btn_GroupSearch = new System.Windows.Forms.Button();
			this.cmbo_ItemFasl = new System.Windows.Forms.ComboBox();
			this.cmbo_ItemVahedSharh = new System.Windows.Forms.ComboBox();
			this.cmbo_Group = new System.Windows.Forms.ComboBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txt_ItemDarsad = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.btn_ExitItem = new System.Windows.Forms.Button();
			this.btn_CopyItem = new System.Windows.Forms.Button();
			this.btn_DeleteItem = new System.Windows.Forms.Button();
			this.btn_InsertItem = new System.Windows.Forms.Button();
			this.cmbo_ItemNoa = new System.Windows.Forms.ComboBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.txt_ItemBahavahed = new System.Windows.Forms.TextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.Label31 = new System.Windows.Forms.Label();
			this.btn_SaveItem = new System.Windows.Forms.Button();
			this.btn_VahedSearch = new System.Windows.Forms.Button();
			this.txt_ItemNo = new System.Windows.Forms.TextBox();
			this.Label35 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.Label43 = new System.Windows.Forms.Label();
			this.txt_ItemSharh = new System.Windows.Forms.TextBox();
			this.cmbo_FehrestItem = new System.Windows.Forms.ComboBox();
			this.dtg_Item = new System.Windows.Forms.DataGridView();
			this.tbp_Fosool = new System.Windows.Forms.TabPage();
			this.pnl_Fasl = new System.Windows.Forms.Panel();
			this.Btn_Insert = new System.Windows.Forms.Button();
			this.Btn_Copy = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.Btn_Exit = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.txt_ZaribComment = new System.Windows.Forms.TextBox();
			this.cmbo_ZaribCode = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.txt_FaslCode = new System.Windows.Forms.TextBox();
			this.txt_FaslComment = new System.Windows.Forms.TextBox();
			this.cmbo_Fehrest = new System.Windows.Forms.ComboBox();
			this.dtg_Fosool = new System.Windows.Forms.DataGridView();
			this.tab_Fosool = new System.Windows.Forms.TabControl();
			this.tbp_Item.SuspendLayout();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.pnl_Item.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).BeginInit();
			this.tbp_Fosool.SuspendLayout();
			this.pnl_Fasl.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Fosool).BeginInit();
			this.tab_Fosool.SuspendLayout();
			base.SuspendLayout();
			this.tbp_Item.BackColor = System.Drawing.Color.DarkKhaki;
			this.tbp_Item.Controls.Add(this.pnl_Filter);
			this.tbp_Item.Controls.Add(this.pnl_Item);
			this.tbp_Item.Controls.Add(this.cmbo_FehrestItem);
			this.tbp_Item.Controls.Add(this.dtg_Item);
			this.tbp_Item.Location = new System.Drawing.Point(4, 27);
			this.tbp_Item.Name = "tbp_Item";
			this.tbp_Item.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Item.Size = new System.Drawing.Size(1197, 699);
			this.tbp_Item.TabIndex = 2;
			this.tbp_Item.Text = "          ایتم ها          ";
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
			this.pnl_Filter.Location = new System.Drawing.Point(9, 49);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1181, 49);
			this.pnl_Filter.TabIndex = 103;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1076, 2);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(60, 44);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmbo_GroupFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_GroupFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_GroupFltr.FormattingEnabled = true;
			this.cmbo_GroupFltr.Location = new System.Drawing.Point(21, 25);
			this.cmbo_GroupFltr.Name = "cmbo_GroupFltr";
			this.cmbo_GroupFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_GroupFltr.Size = new System.Drawing.Size(224, 26);
			this.cmbo_GroupFltr.TabIndex = 80;
			this.cmbo_ItemVahedSharhFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemVahedSharhFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ItemVahedSharhFltr.FormattingEnabled = true;
			this.cmbo_ItemVahedSharhFltr.Location = new System.Drawing.Point(397, 26);
			this.cmbo_ItemVahedSharhFltr.Name = "cmbo_ItemVahedSharhFltr";
			this.cmbo_ItemVahedSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemVahedSharhFltr.Size = new System.Drawing.Size(79, 26);
			this.cmbo_ItemVahedSharhFltr.TabIndex = 77;
			this.cmbo_ItemFaslFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemFaslFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ItemFaslFltr.FormattingEnabled = true;
			this.cmbo_ItemFaslFltr.Location = new System.Drawing.Point(477, 26);
			this.cmbo_ItemFaslFltr.Name = "cmbo_ItemFaslFltr";
			this.cmbo_ItemFaslFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemFaslFltr.Size = new System.Drawing.Size(39, 26);
			this.cmbo_ItemFaslFltr.TabIndex = 76;
			this.txt_ItemNoFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemNoFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ItemNoFltr.Location = new System.Drawing.Point(1017, 26);
			this.txt_ItemNoFltr.Name = "txt_ItemNoFltr";
			this.txt_ItemNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemNoFltr.Size = new System.Drawing.Size(58, 26);
			this.txt_ItemNoFltr.TabIndex = 74;
			this.cmbo_ItemNoaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemNoaFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ItemNoaFltr.FormattingEnabled = true;
			this.cmbo_ItemNoaFltr.Location = new System.Drawing.Point(246, 25);
			this.cmbo_ItemNoaFltr.Name = "cmbo_ItemNoaFltr";
			this.cmbo_ItemNoaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemNoaFltr.Size = new System.Drawing.Size(80, 26);
			this.cmbo_ItemNoaFltr.TabIndex = 79;
			this.txt_ItemBahavahedFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemBahavahedFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ItemBahavahedFltr.Location = new System.Drawing.Point(327, 26);
			this.txt_ItemBahavahedFltr.Name = "txt_ItemBahavahedFltr";
			this.txt_ItemBahavahedFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemBahavahedFltr.Size = new System.Drawing.Size(69, 26);
			this.txt_ItemBahavahedFltr.TabIndex = 78;
			this.txt_ItemSharhFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemSharhFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ItemSharhFltr.Location = new System.Drawing.Point(517, 26);
			this.txt_ItemSharhFltr.Name = "txt_ItemSharhFltr";
			this.txt_ItemSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemSharhFltr.Size = new System.Drawing.Size(499, 26);
			this.txt_ItemSharhFltr.TabIndex = 75;
			this.btn_Filter.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Location = new System.Drawing.Point(1135, 1);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(45, 46);
			this.btn_Filter.TabIndex = 44;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(18, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1156, 25);
			this.PictureBox1.TabIndex = 75;
			this.PictureBox1.TabStop = false;
			this.pnl_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Item.Controls.Add(this.btn_GroupSearch);
			this.pnl_Item.Controls.Add(this.cmbo_ItemFasl);
			this.pnl_Item.Controls.Add(this.cmbo_ItemVahedSharh);
			this.pnl_Item.Controls.Add(this.cmbo_Group);
			this.pnl_Item.Controls.Add(this.Label7);
			this.pnl_Item.Controls.Add(this.txt_ItemDarsad);
			this.pnl_Item.Controls.Add(this.Label5);
			this.pnl_Item.Controls.Add(this.btn_ExitItem);
			this.pnl_Item.Controls.Add(this.btn_CopyItem);
			this.pnl_Item.Controls.Add(this.btn_DeleteItem);
			this.pnl_Item.Controls.Add(this.btn_InsertItem);
			this.pnl_Item.Controls.Add(this.cmbo_ItemNoa);
			this.pnl_Item.Controls.Add(this.Label21);
			this.pnl_Item.Controls.Add(this.txt_ItemBahavahed);
			this.pnl_Item.Controls.Add(this.Label30);
			this.pnl_Item.Controls.Add(this.Label31);
			this.pnl_Item.Controls.Add(this.btn_SaveItem);
			this.pnl_Item.Controls.Add(this.btn_VahedSearch);
			this.pnl_Item.Controls.Add(this.txt_ItemNo);
			this.pnl_Item.Controls.Add(this.Label35);
			this.pnl_Item.Controls.Add(this.Label38);
			this.pnl_Item.Controls.Add(this.Label43);
			this.pnl_Item.Controls.Add(this.txt_ItemSharh);
			this.pnl_Item.Location = new System.Drawing.Point(10, 539);
			this.pnl_Item.Name = "pnl_Item";
			this.pnl_Item.Size = new System.Drawing.Size(1178, 156);
			this.pnl_Item.TabIndex = 111;
			this.btn_GroupSearch.Image = (System.Drawing.Image)resources.GetObject("btn_GroupSearch.Image");
			this.btn_GroupSearch.Location = new System.Drawing.Point(13, 62);
			this.btn_GroupSearch.Name = "btn_GroupSearch";
			this.btn_GroupSearch.Size = new System.Drawing.Size(25, 21);
			this.btn_GroupSearch.TabIndex = 132;
			this.btn_GroupSearch.UseVisualStyleBackColor = true;
			this.btn_GroupSearch.Visible = false;
			this.cmbo_ItemFasl.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemFasl.FormattingEnabled = true;
			this.cmbo_ItemFasl.Location = new System.Drawing.Point(306, 33);
			this.cmbo_ItemFasl.Name = "cmbo_ItemFasl";
			this.cmbo_ItemFasl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemFasl.Size = new System.Drawing.Size(100, 26);
			this.cmbo_ItemFasl.TabIndex = 5;
			this.cmbo_ItemVahedSharh.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemVahedSharh.FormattingEnabled = true;
			this.cmbo_ItemVahedSharh.Location = new System.Drawing.Point(306, 5);
			this.cmbo_ItemVahedSharh.Name = "cmbo_ItemVahedSharh";
			this.cmbo_ItemVahedSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemVahedSharh.Size = new System.Drawing.Size(100, 26);
			this.cmbo_ItemVahedSharh.TabIndex = 3;
			this.cmbo_Group.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_Group.FormattingEnabled = true;
			this.cmbo_Group.Location = new System.Drawing.Point(38, 62);
			this.cmbo_Group.Name = "cmbo_Group";
			this.cmbo_Group.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Group.Size = new System.Drawing.Size(368, 26);
			this.cmbo_Group.TabIndex = 7;
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(405, 66);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(36, 15);
			this.Label7.TabIndex = 131;
			this.Label7.Text = ":  گروه";
			this.txt_ItemDarsad.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemDarsad.Location = new System.Drawing.Point(40, 91);
			this.txt_ItemDarsad.Name = "txt_ItemDarsad";
			this.txt_ItemDarsad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemDarsad.Size = new System.Drawing.Size(1036, 26);
			this.txt_ItemDarsad.TabIndex = 8;
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(1074, 98);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(73, 15);
			this.Label5.TabIndex = 129;
			this.Label5.Text = ": درصد نسبت به";
			this.btn_ExitItem.Location = new System.Drawing.Point(39, 122);
			this.btn_ExitItem.Name = "btn_ExitItem";
			this.btn_ExitItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_ExitItem.Size = new System.Drawing.Size(100, 27);
			this.btn_ExitItem.TabIndex = 13;
			this.btn_ExitItem.Text = "بازگشت";
			this.btn_ExitItem.UseVisualStyleBackColor = true;
			this.btn_CopyItem.Location = new System.Drawing.Point(529, 122);
			this.btn_CopyItem.Name = "btn_CopyItem";
			this.btn_CopyItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_CopyItem.Size = new System.Drawing.Size(100, 27);
			this.btn_CopyItem.TabIndex = 11;
			this.btn_CopyItem.Text = "(Clt+C) کپی";
			this.btn_CopyItem.UseVisualStyleBackColor = true;
			this.btn_DeleteItem.Location = new System.Drawing.Point(272, 122);
			this.btn_DeleteItem.Name = "btn_DeleteItem";
			this.btn_DeleteItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_DeleteItem.Size = new System.Drawing.Size(100, 27);
			this.btn_DeleteItem.TabIndex = 12;
			this.btn_DeleteItem.Text = "(Del) حذف";
			this.btn_DeleteItem.UseVisualStyleBackColor = true;
			this.btn_InsertItem.Location = new System.Drawing.Point(785, 122);
			this.btn_InsertItem.Name = "btn_InsertItem";
			this.btn_InsertItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_InsertItem.Size = new System.Drawing.Size(100, 27);
			this.btn_InsertItem.TabIndex = 10;
			this.btn_InsertItem.Text = "(Ins) ایجاد ";
			this.btn_InsertItem.UseVisualStyleBackColor = true;
			this.cmbo_ItemNoa.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ItemNoa.FormattingEnabled = true;
			this.cmbo_ItemNoa.Location = new System.Drawing.Point(40, 33);
			this.cmbo_ItemNoa.Name = "cmbo_ItemNoa";
			this.cmbo_ItemNoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemNoa.Size = new System.Drawing.Size(110, 26);
			this.cmbo_ItemNoa.TabIndex = 6;
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(407, 38);
			this.Label21.Name = "Label21";
			this.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label21.Size = new System.Drawing.Size(35, 15);
			this.Label21.TabIndex = 116;
			this.Label21.Text = ":  فصل";
			this.txt_ItemBahavahed.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemBahavahed.Location = new System.Drawing.Point(40, 5);
			this.txt_ItemBahavahed.Name = "txt_ItemBahavahed";
			this.txt_ItemBahavahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemBahavahed.Size = new System.Drawing.Size(110, 26);
			this.txt_ItemBahavahed.TabIndex = 4;
			this.Label30.AutoSize = true;
			this.Label30.Location = new System.Drawing.Point(148, 10);
			this.Label30.Name = "Label30";
			this.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label30.Size = new System.Drawing.Size(54, 15);
			this.Label30.TabIndex = 110;
			this.Label30.Text = ": بهای واحد";
			this.Label31.AutoSize = true;
			this.Label31.Location = new System.Drawing.Point(149, 38);
			this.Label31.Name = "Label31";
			this.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label31.Size = new System.Drawing.Size(47, 15);
			this.Label31.TabIndex = 108;
			this.Label31.Text = ":  نوع ایتم";
			this.btn_SaveItem.Location = new System.Drawing.Point(1038, 122);
			this.btn_SaveItem.Name = "btn_SaveItem";
			this.btn_SaveItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_SaveItem.Size = new System.Drawing.Size(100, 27);
			this.btn_SaveItem.TabIndex = 9;
			this.btn_SaveItem.Text = "(F2) ذخیره ";
			this.btn_SaveItem.UseVisualStyleBackColor = true;
			this.btn_VahedSearch.Image = (System.Drawing.Image)resources.GetObject("btn_VahedSearch.Image");
			this.btn_VahedSearch.Location = new System.Drawing.Point(280, 5);
			this.btn_VahedSearch.Name = "btn_VahedSearch";
			this.btn_VahedSearch.Size = new System.Drawing.Size(25, 21);
			this.btn_VahedSearch.TabIndex = 83;
			this.btn_VahedSearch.UseVisualStyleBackColor = true;
			this.btn_VahedSearch.Visible = false;
			this.txt_ItemNo.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ItemNo.Location = new System.Drawing.Point(1009, 9);
			this.txt_ItemNo.Name = "txt_ItemNo";
			this.txt_ItemNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemNo.Size = new System.Drawing.Size(100, 26);
			this.txt_ItemNo.TabIndex = 1;
			this.Label35.AutoSize = true;
			this.Label35.Location = new System.Drawing.Point(1108, 10);
			this.Label35.Name = "Label35";
			this.Label35.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label35.Size = new System.Drawing.Size(29, 15);
			this.Label35.TabIndex = 78;
			this.Label35.Text = ":  ایتم";
			this.Label38.AutoSize = true;
			this.Label38.Location = new System.Drawing.Point(405, 10);
			this.Label38.Name = "Label38";
			this.Label38.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label38.Size = new System.Drawing.Size(35, 15);
			this.Label38.TabIndex = 21;
			this.Label38.Text = ":  واحد";
			this.Label43.AutoSize = true;
			this.Label43.Location = new System.Drawing.Point(947, 10);
			this.Label43.Name = "Label43";
			this.Label43.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label43.Size = new System.Drawing.Size(36, 15);
			this.Label43.TabIndex = 20;
			this.Label43.Text = ":  شرح";
			this.txt_ItemSharh.Font = new System.Drawing.Font("B Yekan", 9f);
			this.txt_ItemSharh.Location = new System.Drawing.Point(490, 5);
			this.txt_ItemSharh.Multiline = true;
			this.txt_ItemSharh.Name = "txt_ItemSharh";
			this.txt_ItemSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemSharh.Size = new System.Drawing.Size(458, 80);
			this.txt_ItemSharh.TabIndex = 2;
			this.cmbo_FehrestItem.BackColor = System.Drawing.SystemColors.Window;
			this.cmbo_FehrestItem.Font = new System.Drawing.Font("B Titr", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestItem.FormattingEnabled = true;
			this.cmbo_FehrestItem.Location = new System.Drawing.Point(213, 6);
			this.cmbo_FehrestItem.Name = "cmbo_FehrestItem";
			this.cmbo_FehrestItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestItem.Size = new System.Drawing.Size(800, 37);
			this.cmbo_FehrestItem.TabIndex = 106;
			this.dtg_Item.AllowUserToAddRows = false;
			this.dtg_Item.AllowUserToDeleteRows = false;
			this.dtg_Item.AllowUserToOrderColumns = true;
			this.dtg_Item.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Item.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Item.GridColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Item.Location = new System.Drawing.Point(9, 76);
			this.dtg_Item.Name = "dtg_Item";
			this.dtg_Item.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.dtg_Item.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dtg_Item.RowTemplate.Height = 44;
			this.dtg_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Item.Size = new System.Drawing.Size(1180, 461);
			this.dtg_Item.TabIndex = 101;
			this.tbp_Fosool.BackColor = System.Drawing.Color.Thistle;
			this.tbp_Fosool.Controls.Add(this.pnl_Fasl);
			this.tbp_Fosool.Controls.Add(this.cmbo_Fehrest);
			this.tbp_Fosool.Controls.Add(this.dtg_Fosool);
			this.tbp_Fosool.ForeColor = System.Drawing.Color.Black;
			this.tbp_Fosool.Location = new System.Drawing.Point(4, 27);
			this.tbp_Fosool.Name = "tbp_Fosool";
			this.tbp_Fosool.Padding = new System.Windows.Forms.Padding(3);
			this.tbp_Fosool.Size = new System.Drawing.Size(1197, 699);
			this.tbp_Fosool.TabIndex = 1;
			this.tbp_Fosool.Text = "          فصول          ";
			this.pnl_Fasl.BackColor = System.Drawing.Color.Thistle;
			this.pnl_Fasl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Fasl.Controls.Add(this.Btn_Insert);
			this.pnl_Fasl.Controls.Add(this.Btn_Copy);
			this.pnl_Fasl.Controls.Add(this.btn_Delete);
			this.pnl_Fasl.Controls.Add(this.Btn_Exit);
			this.pnl_Fasl.Controls.Add(this.Label1);
			this.pnl_Fasl.Controls.Add(this.txt_ZaribComment);
			this.pnl_Fasl.Controls.Add(this.cmbo_ZaribCode);
			this.pnl_Fasl.Controls.Add(this.Label2);
			this.pnl_Fasl.Controls.Add(this.Btn_Save);
			this.pnl_Fasl.Controls.Add(this.Label3);
			this.pnl_Fasl.Controls.Add(this.Label4);
			this.pnl_Fasl.Controls.Add(this.txt_FaslCode);
			this.pnl_Fasl.Controls.Add(this.txt_FaslComment);
			this.pnl_Fasl.Location = new System.Drawing.Point(9, 548);
			this.pnl_Fasl.Name = "pnl_Fasl";
			this.pnl_Fasl.Size = new System.Drawing.Size(1180, 142);
			this.pnl_Fasl.TabIndex = 96;
			this.Btn_Insert.Location = new System.Drawing.Point(788, 96);
			this.Btn_Insert.Name = "Btn_Insert";
			this.Btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Insert.Size = new System.Drawing.Size(71, 28);
			this.Btn_Insert.TabIndex = 6;
			this.Btn_Insert.Text = "(Ins) ایجاد ";
			this.Btn_Insert.UseVisualStyleBackColor = true;
			this.Btn_Copy.Location = new System.Drawing.Point(570, 96);
			this.Btn_Copy.Name = "Btn_Copy";
			this.Btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Copy.Size = new System.Drawing.Size(71, 28);
			this.Btn_Copy.TabIndex = 7;
			this.Btn_Copy.Text = "(Clt+C) کپی";
			this.Btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Delete.Enabled = false;
			this.btn_Delete.Location = new System.Drawing.Point(344, 96);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(71, 28);
			this.btn_Delete.TabIndex = 8;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.Btn_Exit.Location = new System.Drawing.Point(129, 96);
			this.Btn_Exit.Name = "Btn_Exit";
			this.Btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Exit.Size = new System.Drawing.Size(71, 28);
			this.Btn_Exit.TabIndex = 9;
			this.Btn_Exit.Text = "بازگشت";
			this.Btn_Exit.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(227, 15);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(70, 15);
			this.Label1.TabIndex = 114;
			this.Label1.Text = "شرح کد ضریب";
			this.txt_ZaribComment.Enabled = false;
			this.txt_ZaribComment.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ZaribComment.Location = new System.Drawing.Point(26, 31);
			this.txt_ZaribComment.Name = "txt_ZaribComment";
			this.txt_ZaribComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ZaribComment.Size = new System.Drawing.Size(376, 26);
			this.txt_ZaribComment.TabIndex = 4;
			this.cmbo_ZaribCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_ZaribCode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ZaribCode.FormattingEnabled = true;
			this.cmbo_ZaribCode.Location = new System.Drawing.Point(410, 31);
			this.cmbo_ZaribCode.Name = "cmbo_ZaribCode";
			this.cmbo_ZaribCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ZaribCode.Size = new System.Drawing.Size(76, 26);
			this.cmbo_ZaribCode.TabIndex = 3;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(429, 15);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(47, 15);
			this.Label2.TabIndex = 90;
			this.Label2.Text = "کد ضریب";
			this.Btn_Save.Location = new System.Drawing.Point(994, 96);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Save.Size = new System.Drawing.Size(71, 28);
			this.Btn_Save.TabIndex = 5;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(793, 15);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(27, 15);
			this.Label3.TabIndex = 95;
			this.Label3.Text = "شرح";
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(1106, 15);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(26, 15);
			this.Label4.TabIndex = 94;
			this.Label4.Text = "فصل";
			this.txt_FaslCode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FaslCode.Location = new System.Drawing.Point(1099, 31);
			this.txt_FaslCode.Name = "txt_FaslCode";
			this.txt_FaslCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FaslCode.Size = new System.Drawing.Size(50, 26);
			this.txt_FaslCode.TabIndex = 1;
			this.txt_FaslComment.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FaslComment.Location = new System.Drawing.Point(493, 31);
			this.txt_FaslComment.Name = "txt_FaslComment";
			this.txt_FaslComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FaslComment.Size = new System.Drawing.Size(600, 26);
			this.txt_FaslComment.TabIndex = 2;
			this.cmbo_Fehrest.BackColor = System.Drawing.SystemColors.MenuHighlight;
			this.cmbo_Fehrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_Fehrest.FormattingEnabled = true;
			this.cmbo_Fehrest.Location = new System.Drawing.Point(255, 18);
			this.cmbo_Fehrest.Name = "cmbo_Fehrest";
			this.cmbo_Fehrest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Fehrest.Size = new System.Drawing.Size(700, 28);
			this.cmbo_Fehrest.TabIndex = 95;
			this.dtg_Fosool.AllowUserToAddRows = false;
			this.dtg_Fosool.AllowUserToDeleteRows = false;
			this.dtg_Fosool.AllowUserToOrderColumns = true;
			this.dtg_Fosool.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Fosool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Fosool.DefaultCellStyle = dataGridViewCellStyle3;
			this.dtg_Fosool.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Fosool.Location = new System.Drawing.Point(9, 52);
			this.dtg_Fosool.Name = "dtg_Fosool";
			dataGridViewCellStyle4.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.dtg_Fosool.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dtg_Fosool.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Fosool.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Fosool.Size = new System.Drawing.Size(1180, 489);
			this.dtg_Fosool.TabIndex = 97;
			this.tab_Fosool.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tab_Fosool.Controls.Add(this.tbp_Fosool);
			this.tab_Fosool.Controls.Add(this.tbp_Item);
			this.tab_Fosool.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
			this.tab_Fosool.Location = new System.Drawing.Point(0, 0);
			this.tab_Fosool.Name = "tab_Fosool";
			this.tab_Fosool.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.tab_Fosool.RightToLeftLayout = true;
			this.tab_Fosool.SelectedIndex = 0;
			this.tab_Fosool.Size = new System.Drawing.Size(1205, 730);
			this.tab_Fosool.TabIndex = 15;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new System.Drawing.Size(1204, 741);
			base.ControlBox = false;
			base.Controls.Add(this.tab_Fosool);
			base.Name = "Frm_FehrestDetail";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "اطلاعات فهارس بها";
			this.tbp_Item.ResumeLayout(false);
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.pnl_Item.ResumeLayout(false);
			this.pnl_Item.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).EndInit();
			this.tbp_Fosool.ResumeLayout(false);
			this.pnl_Fasl.ResumeLayout(false);
			this.pnl_Fasl.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Fosool).EndInit();
			this.tab_Fosool.ResumeLayout(false);
			base.ResumeLayout(false);

            this.tbp_Item.Enter += new System.EventHandler(this.tbp_Item_Enter);
            this.cmbo_FehrestItem.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestItem_SelectedIndexChanged);
            this.cmbo_FehrestItem.TextChanged += new System.EventHandler(this.cmbo_FehrestItem_TextChanged);
            this.txt_ItemNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNoFltr_KeyDown);
            this.cmbo_ItemNoaFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_SelectedIndexChanged);
            this.txt_ItemBahavahedFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahedFltr_KeyDown);
            this.txt_ItemSharhFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemSharhFltr_KeyDown);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.dtg_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellClick);
            this.dtg_Item.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellContentClick);
            this.dtg_Item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellDoubleClick);
            this.dtg_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Item_KeyDown);
            this.dtg_Item.SelectionChanged += new System.EventHandler(this.dtg_Item_SelectionChanged);
            this.tbp_Fosool.Enter += new System.EventHandler(this.tbp_Fosool_Enter);
            this.tbp_Fosool.Click += new System.EventHandler(this.tbp_Fosool_Click);
            this.cmbo_Fehrest.SelectedIndexChanged += new System.EventHandler(this.cmbo_Fehrest_SelectedIndexChanged);
            this.dtg_Fosool.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Fosool_CellClick);
            this.dtg_Fosool.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Fosool_CellContentClick);
            this.dtg_Fosool.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Fosool_KeyDown);
            this.dtg_Fosool.SelectionChanged += new System.EventHandler(this.dtg_Fosool_SelectionChanged);
            this.cmbo_ZaribCode.GotFocus += new System.EventHandler(this.cmbo_ZaribCode_GotFocus);
            this.cmbo_ZaribCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_ZaribCode_SelectedIndexChanged);
            this.cmbo_ZaribCode.TextChanged += new System.EventHandler(this.cmbo_ZaribCode_TextChanged);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.txt_FaslCode.GotFocus += new System.EventHandler(this.txt_FaslCode_GotFocus);
            this.txt_FaslCode.TextChanged += new System.EventHandler(this.txt_FaslCode_TextChanged);
            this.txt_FaslComment.GotFocus += new System.EventHandler(this.txt_FaslComment_GotFocus);
            this.txt_FaslComment.TextChanged += new System.EventHandler(this.txt_FaslComment_TextChanged);
            this.cmbo_ItemNoa.TextChanged += new System.EventHandler(this.cmbo_ItemNoa_TextChanged);
            this.cmbo_ItemNoa.GotFocus += new System.EventHandler(this.cmbo_ItemNoa_GotFocus);
            this.cmbo_ItemNoa.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemNoa_SelectedIndexChanged);
            this.txt_ItemBahavahed.GotFocus += new System.EventHandler(this.txt_ItemBahavahed_GotFocus);
            this.txt_ItemBahavahed.TextChanged += new System.EventHandler(this.txt_ItemBahavahed_TextChanged);
            this.btn_SaveItem.Click += new System.EventHandler(this.btn_SaveItem_Click);
            this.btn_VahedSearch.Click += new System.EventHandler(this.btn_Search_Click);
            this.txt_ItemNo.GotFocus += new System.EventHandler(this.txt_ItemNo_GotFocus);
            this.txt_ItemNo.TextChanged += new System.EventHandler(this.txt_ItemNo_TextChanged);
            this.txt_ItemSharh.GotFocus += new System.EventHandler(this.txt_ItemSharh_GotFocus);
            this.txt_ItemSharh.TextChanged += new System.EventHandler(this.txt_ItemSharh_TextChanged);
            this.cmbo_ItemFaslFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemFaslFltr_SelectedIndexChanged);
            this.cmbo_ItemVahedSharhFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemVahedSharhFltr_SelectedIndexChanged);
            this.txt_ZaribComment.GotFocus += new System.EventHandler(this.txt_ZaribComment_GotFocus);
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            this.btn_ExitItem.Click += new System.EventHandler(this.btn_ExitItem_Click);
            this.btn_CopyItem.Click += new System.EventHandler(this.btn_CopyItem_Click);
            this.btn_DeleteItem.Click += new System.EventHandler(this.btn_DeleteItem_Click);
            this.btn_InsertItem.Click += new System.EventHandler(this.btn_InsertItem_Click);
            this.txt_ItemDarsad.GotFocus += new System.EventHandler(this.txt_ItemDarsad_GotFocus);
            this.txt_ItemDarsad.TextChanged += new System.EventHandler(this.txt_ItemDarsad_TextChanged);
            this.cmbo_GroupFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_GroupFltr_SelectedIndexChanged);
            this.cmbo_ItemVahedSharh.GotFocus += new System.EventHandler(this.cmbo_ItemVahedSharh_GotFocus);
            this.cmbo_ItemVahedSharh.TextChanged += new System.EventHandler(this.cmbo_ItemVahedSharh_TextChanged);
            this.cmbo_ItemFasl.GotFocus += new System.EventHandler(this.cmbo_ItemFasl_GotFocus);
            this.cmbo_ItemFasl.TextChanged += new System.EventHandler(this.cmbo_ItemFasl_TextChanged);
            this.btn_GroupSearch.Click += new System.EventHandler(this.btn_GroupSearch_Click);
        }

		private void Frm_FehrestDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Escape)
			{
				Btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_FehrestDetail_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			DtgFosoolRefresh = 0;
			DtgItemRefresh = 0;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [fehrest] FROM [dbo].[Fehrest] Group By [fehrest] order by [Fehrest] desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			cmbo_Fehrest.DataSource = dataTable;
			cmbo_Fehrest.DisplayMember = "Fehrest";
			cmbo_FehrestItem.DataSource = dataTable;
			cmbo_FehrestItem.DisplayMember = "Fehrest";
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0)
			{
				Module1.CurrentFehrestFile = Module1.FindCodeOrName(cmbo_Fehrest.Text, "[fehrest]", "[filename]", "[fehrest]");
			}
			Module1.Load_Cmbo(cmbo_ZaribCode, "ZarayebMantaghe", "ZaribCode", "");
			Module1.Load_Cmbo(cmbo_ItemFasl, "Fosool", "FaslCode", "");
			Module1.Load_Cmbo(cmbo_Group, Module1.CurrentFehrestFile, "GroupName", "");
			Module1.Load_Cmbo(cmbo_ItemNoa, Module1.CurrentFehrestFile, "ItemNoa", "");
			Module1.Load_Cmbo(cmbo_ItemVahedSharh, Module1.CurrentFehrestFile, "Vahed", "");
			if (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) == 0)
			{
				tab_Fosool.SelectedIndex = 1;
				tab_Fosool.TabPages[1].Show();
				Module1.FAslOrItem = "";
			}
			if (Operators.CompareString(MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text, "", TextCompare: false) != 0)
			{
				cmbo_Fehrest.Text = MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text;
				cmbo_FehrestItem.Text = MyProject.Forms.Frm_Fehrest.txt_FehrestName.Text;
			}
			DtgFosoolRefresh = 1;
			DtgItemRefresh = 1;
			foreach (Control control3 in pnl_Fasl.Controls)
			{
				if (control3 is TextBox || control3 is ComboBox || control3 is Button)
				{
					control3.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control3.KeyDown += GeneralKeyDownHandler1;
				}
				if (control3 is TextBox || control3 is Button)
				{
					control3.KeyDown += GeneralKeyDownHandler2;
				}
			}
			foreach (Control control4 in pnl_Item.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control4.KeyDown += GeneralKeyDownHandler1;
				}
				if (control4 is TextBox || control4 is Button)
				{
					control4.KeyDown += GeneralKeyDownHandler2;
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
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
			}
			if ((e.KeyCode == Keys.F2) & (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) == 0))
			{
				btn_SaveItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if ((e.KeyCode == Keys.F2) & (Operators.CompareString(Module1.FAslOrItem, "Fasl", TextCompare: false) == 0))
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
			base.ActiveControl.BackColor = Color.Cyan;
			foreach (Control control4 in pnl_Fasl.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		private void cmbo_Fehrest_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(Module1.FAslOrItem, "Item", TextCompare: false) != 0)
			{
				tbp_Fosool_Enter(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		public void Load_dtg_Fosool()
		{
			DataTable dataTable = new DataTable();
			string arab = cmbo_Fehrest.Text;
			string[] array = new string[5];
			base.Visible = true;
			int num = 0;
			do
			{
				array[num] = "";
				num = checked(num + 1);
			}
			while (num <= 4);
			if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
				{
					array[1] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[3] = " And ";
				}
			}
			if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
			{
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[3] = " And ";
				}
			}
			if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0 && Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
			{
				array[3] = " And ";
			}
			Module1.strWhere = " WHERE " + Module1.FehrestFile_filter + array[1] + Module1.FehrestName_filter + array[2] + Module1.FehrestFile_filter + array[3] + Module1.FehrestMabna_filter + array[4];
			if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
			{
				Module1.strWhere = " ";
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(arab) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Id As 'Id',[FaslCode] As 'فصل',[FaslComment] As 'شرح',[ZaribCode] As 'کد ضریب',(SELECT Top 1 [Comment]  FROM [dbo].[ZarayebMantaghe]  Where [ZaribCode] =[Fosool].ZaribCode)  As 'شرح کد ضریب' FROM [dbo].[Fosool] where [FehrestFile]= '" + Module1.CurrentFehrestFile + "' Order By [FaslCode]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			dtg_Fosool.DataSource = dataTable;
			sqlDataReader.Close();
			dtg_Fosool.Columns[0].Visible = false;
			dtg_Fosool.Columns[1].Width = 50;
			dtg_Fosool.Columns[2].Width = 600;
			dtg_Fosool.Columns[3].Width = 50;
			dtg_Fosool.Columns[4].Width = 500;
			Module1.FAslOrItem = "Fasl";
		}

		public void Load_dtg_Item()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[7];
			base.Visible = true;
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
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemSharh_Filter + array[2] + ItemVahedSharh_Filter + array[3] + ItemBahaVahed_Filter + array[4] + ItemFasl_Filter + array[5] + ItemNoa_Filter + array[5] + GroupName_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(cmbo_Fehrest.Text) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					while (sqlDataReader.Read())
					{
						Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
					}
					sqlDataReader.Close();
				}
				if (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) != 0)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [radif] As 'Id',[darsad] As 'Chk',[radif] As 'ردیف',[shomar] As 'ایتم',[Sharh] As 'شرح ایتم',[Fasl] As 'فصل',[Vahed] As 'واحد',[baha] As 'بها',[ItemNoa] As 'نوع ایتم',[ItemDarsad] As 'درصد نسبت به',[GroupName] As 'گروه' FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Order By [shomar]";
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
						dataTable.Rows[i]["Chk"] = 0;
					}
					dtg_Item.DataSource = dataTable;
					dtg_Item.Columns[0].Visible = false;
					dtg_Item.Columns[1].Visible = false;
					dtg_Item.Columns[2].ReadOnly = true;
					dtg_Item.Columns[2].Width = 60;
					dtg_Item.Columns[3].ReadOnly = true;
					dtg_Item.Columns[3].Width = 60;
					dtg_Item.Columns[4].ReadOnly = true;
					dtg_Item.Columns[4].Width = 500;
					dtg_Item.Columns[5].ReadOnly = true;
					dtg_Item.Columns[5].Width = 40;
					dtg_Item.Columns[6].ReadOnly = true;
					dtg_Item.Columns[6].Width = 80;
					dtg_Item.Columns[7].ReadOnly = true;
					dtg_Item.Columns[7].Width = 70;
					dtg_Item.Columns[8].ReadOnly = true;
					dtg_Item.Columns[8].Width = 80;
					dtg_Item.Columns[9].ReadOnly = true;
					dtg_Item.Columns[9].Visible = false;
					dtg_Item.Columns[10].ReadOnly = true;
					dtg_Item.Columns[10].Width = 226;
					Module1.FAslOrItem = "Item";
					dtg_Item.Refresh();
					sqlDataReader.Close();
				}
				Module1.MyConn.Close();
			}
		}

		public void tbp_Item_Enter(object sender, EventArgs e)
		{
			cmbo_FehrestItem.Text = cmbo_Fehrest.Text;
			Load_dtg_Item();
		}

		public void tbp_Fosool_Enter(object sender, EventArgs e)
		{
			Load_dtg_Fosool();
		}

		private void cmbo_FehrestItem_SelectedIndexChanged(object sender, EventArgs e)
		{
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
			if ((Module1.CurrentFehrestFile == null) | (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0))
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
			Module1.cmd.CommandText = "SELECT [GroupName] FROM [dbo]." + Module1.CurrentFehrestFile + Module1.strWhere + " Group by [GroupName] Order By [GroupName]";
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
			if ((Operators.CompareString(Module1.FAslOrItem, "Fasl", TextCompare: false) != 0) & (DtgItemRefresh == 1))
			{
				Load_dtg_Item();
			}
		}

		private void ShowItemRecord()
		{
			int index = 0;
			ref FehrestItemDetailes item = ref Item;
			int lErl = default(int);
			if (dtg_Item.RowCount != 0)
			{
				try
				{
					index = dtg_Item.CurrentRow.Index;
					item.Id = Conversions.ToInteger(dtg_Item.Rows[index].Cells[0].Value);
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				item.ItemNo = dtg_Item.Rows[index].Cells[3].Value.ToString();
				item.ItemSharh = Conversions.ToString(dtg_Item.Rows[index].Cells[4].Value);
				item.ItemFasl = dtg_Item.Rows[index].Cells[5].Value.ToString();
				item.ItemVahedSharh = Conversions.ToString(dtg_Item.Rows[index].Cells[6].Value);
				item.ItemBahaVahed = Conversions.ToSingle(dtg_Item.Rows[index].Cells[7].Value);
				item.ItemNoa = dtg_Item.Rows[index].Cells[8].Value.ToString();
				item.ItemDarsad = dtg_Item.Rows[index].Cells[9].Value.ToString();
				item.GroupName = dtg_Item.Rows[index].Cells[10].Value.ToString();
				txt_ItemNo.Text = item.ItemNo;
				txt_ItemSharh.Text = item.ItemSharh;
				cmbo_ItemVahedSharh.Text = item.ItemVahedSharh;
				txt_ItemBahavahed.Text = Conversions.ToString(Convert.ToInt64(item.ItemBahaVahed));
				cmbo_ItemFasl.Text = item.ItemFasl;
				cmbo_ItemNoa.Text = item.ItemNoa;
				txt_ItemDarsad.Text = item.ItemDarsad;
				cmbo_Group.Text = item.GroupName;
			}
			lErl = 60;
		}

		private void ShowFaslRecord()
		{
			int index = 0;
			ref FehrestFaslDetailes fasl = ref Fasl;
			int lErl = default(int);
			if (dtg_Fosool.RowCount != 0)
			{
				try
				{
					index = dtg_Fosool.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				fasl.Id = Conversions.ToInteger(dtg_Fosool.Rows[index].Cells[0].Value.ToString());
				fasl.FaslCode = dtg_Fosool.Rows[index].Cells[1].Value.ToString();
				fasl.FaslComment = Conversions.ToString(dtg_Fosool.Rows[index].Cells[2].Value);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Fosool.Rows[index].Cells[3].Value)))
				{
					fasl.ZaribCode = "";
				}
				else
				{
					fasl.ZaribCode = Conversions.ToString(dtg_Fosool.Rows[index].Cells[3].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Fosool.Rows[index].Cells[4].Value)))
				{
					txt_ZaribComment.Text = "";
				}
				else
				{
					txt_ZaribComment.Text = Conversions.ToString(dtg_Fosool.Rows[index].Cells[4].Value);
				}
				txt_FaslCode.Text = fasl.FaslCode;
				txt_FaslComment.Text = fasl.FaslComment;
				cmbo_ZaribCode.Text = fasl.ZaribCode;
			}
			lErl = 60;
		}

		private void dtg_Item_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == 1)
			{
				DataGridViewRow dataGridViewRow = dtg_Item.Rows[e.RowIndex];
				dataGridViewRow.Cells["Chk"].Value = Convert.ToBoolean(RuntimeHelpers.GetObjectValue(dataGridViewRow.Cells["Chk"].EditedFormattedValue));
				if (Convert.ToBoolean(RuntimeHelpers.GetObjectValue(Operators.CompareObjectEqual(dataGridViewRow.Cells["Chk"].Value, false, TextCompare: false))))
				{
					dtg_Item.CurrentRow.Selected = true;
					dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.RoyalBlue;
					dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.White;
				}
				else
				{
					dtg_Item.CurrentRow.Cells[1].Value = false;
					dtg_Item.CurrentRow.DefaultCellStyle.BackColor = Color.White;
					dtg_Item.CurrentRow.DefaultCellStyle.ForeColor = Color.Black;
				}
			}
			ShowItemRecord();
		}

		private void dtg_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

		private void dtg_Item_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dtg_Item_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				Btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				Btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_ItemNo.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Item_SelectionChanged(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "dtg";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_SaveItem_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Setpnl_ItemBlue();
					break;
				case DialogResult.No:
					Setpnl_ItemBlue();
					break;
				case DialogResult.Cancel:
					txt_ItemNo.Focus();
					return;
				}
			}
			if (DtgItemRefresh == 1)
			{
				ShowItemRecord();
			}
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
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ItemNo_Filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				if (DtgItemRefresh == 1)
				{
					Load_dtg_Item();
				}
				ShowItemRecord();
			}
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_Filter.Text, "حذف فیلتر", TextCompare: false) == 0)
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
				txt_ItemNoFltr.Text = "";
				txt_ItemSharhFltr.Text = "";
				cmbo_ItemFaslFltr.Text = "";
				cmbo_ItemVahedSharhFltr.Text = "";
				txt_ItemBahavahedFltr.Text = "";
				cmbo_ItemNoaFltr.Text = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
				Load_dtg_Item();
			}
		}

		private void cmbo_FehrestItem_TextChanged(object sender, EventArgs e)
		{
			DataTable dataTable = new DataTable();
			DataTable dataTable2 = new DataTable();
			DataTable dataTable3 = new DataTable();
			if (Operators.CompareString(cmbo_FehrestItem.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top(1) [filename] FROM [dbo].[Fehrest]  Where REPLACE(REPLACE([Fehrest],'ي',N'ی'),'ك',N'ک') =N'" + Module1.ArbToPer(cmbo_FehrestItem.Text) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.CurrentFehrestFile = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if ((Module1.CurrentFehrestFile == null) | (Operators.CompareString(Module1.CurrentFehrestFile, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			cmbo_ItemFaslFltr.Items.Clear();
			Module1.cmd.CommandText = "SELECT [Fasl] FROM [dbo]." + Module1.CurrentFehrestFile + " " + Module1.strWhere + " Group by [Fasl] Order By [Fasl]";
			sqlDataReader = Module1.cmd.ExecuteReader();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			dataTable.Load(sqlDataReader);
			cmbo_ItemFaslFltr.Items.Add("");
			foreach (DataRow row in dataTable.Rows)
			{
				cmbo_ItemFaslFltr.Items.Add(RuntimeHelpers.GetObjectValue(row["Fasl"]));
			}
			cmbo_ItemFaslFltr.Text = "";
			sqlDataReader.Close();
			Module1.MyConn.Close();
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
			cmbo_ItemNoaFltr.Items.Add("بها دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی");
			cmbo_ItemNoaFltr.Items.Add("ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی - ستاره دار");
			cmbo_ItemNoaFltr.Text = "";
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
		}

		private void dtg_Fosool_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFaslRecord();
		}

		private void dtg_Fosool_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFaslRecord();
		}

		private void dtg_Fosool_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				Btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				Btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_FaslCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Fosool_SelectionChanged(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "dtg";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات فصل ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Setpnl_FosoolBlue();
					break;
				case DialogResult.No:
					Setpnl_FosoolBlue();
					break;
				case DialogResult.Cancel:
					txt_FaslCode.Focus();
					return;
				}
			}
			if (DtgFosoolRefresh == 1)
			{
				ShowFaslRecord();
			}
		}

		private void cmbo_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

		private void cmbo_ZaribCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!((Operators.CompareString(cmbo_ZaribCode.Text, "", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ZaribCode.Text, "System.Data.DataRowView", TextCompare: false) == 0)))
			{
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top(1) [Comment] FROM [dbo].[ZarayebMantaghe] Where [ZaribCode] ='" + cmbo_ZaribCode.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					txt_ZaribComment.Text = Conversions.ToString(sqlDataReader[0]);
				}
				sqlDataReader.Close();
			}
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(cmbo_ItemFasl.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("شماره فصل را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_FaslCode.Focus();
				}
				else if (!(pnl_Fasl.BackColor == Color.Thistle))
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [FaslCode] FROM [dbo].[Fosool] Where [FaslCode]='" + txt_FaslCode.Text + "' And [FehrestFile]='" + Module1.CurrentFehrestFile + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره فصل " + txt_FaslCode.Text + " موجود است شماره فصل جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FaslCode.Text = "";
							txt_FaslCode.Focus();
							sqlDataReader.Close();
							goto IL_032d;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([FehrestFile],[FaslCode],[FaslComment],[ZaribCode]) VALUES('" + Module1.CurrentFehrestFile + "','" + txt_FaslCode.Text + "','" + txt_FaslComment.Text + "','" + cmbo_ZaribCode.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_FosoolBlue();
					}
					else
					{
						Module1.cmd.CommandText = "UPDATE [dbo].[Fosool] SET [FehrestFile] ='" + Module1.CurrentFehrestFile + "',[FaslCode] = '" + txt_FaslCode.Text + "',[FaslComment] = '" + txt_FaslComment.Text + "',[ZaribCode] = '" + cmbo_ZaribCode.Text + "'WHERE Id = '" + Conversions.ToString(Fasl.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_FosoolBlue();
					}
					text = txt_FaslCode.Text;
					Load_dtg_Fosool();
					int num = dtg_Fosool.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(dtg_Fosool.Rows[i].Cells[1].Value.ToString(), text, TextCompare: false) == 0)
						{
							dtg_Fosool.CurrentCell = dtg_Fosool.Rows[i].Cells[1];
							ShowFaslRecord();
						}
					}
				}
				goto IL_032d;
			}
			IL_032d:
			BtnCommand = "";
		}

		private void Setpnl_FosoolBlue()
		{
			pnl_Fasl.BackColor = Color.Thistle;
			foreach (object control in pnl_Fasl.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Fasl.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void Btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Close();
		}

		private void txt_FaslCode_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

		private void txt_FaslComment_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

		private void txt_ZaribComment_GotFocus(object sender, EventArgs e)
		{
			ChangeFossolDtgOrPnl = "pnl";
		}

		private void CheckFosoolChange()
		{
			if (Operators.CompareString(ChangeFossolDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Fasl.BackColor = Color.Thistle;
			foreach (object control in pnl_Fasl.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Fasl.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Fasl.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Fasl.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void Btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Fasl.BackColor = Color.LightPink;
			txt_FaslCode.Text = "";
			txt_FaslComment.Text = "";
			cmbo_ZaribCode.Text = "";
			txt_ZaribComment.Text = "";
		}

		private void Btn_Copy_Click(object sender, EventArgs e)
		{
			string text = txt_FaslCode.Text;
			string text2 = "";
			BtnCommand = "Copy";
			if (pnl_Fasl.BackColor == Color.LightPink)
			{
				dtg_Fosool_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text3 = Interaction.InputBox("  کپی فصل " + Fasl.FaslCode + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text3, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [FaslCode] FROM [dbo].[Fosool] Where [FaslCode]='" + text3 + "' And [FehrestFile] = ' " + Module1.CurrentFehrestFile + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show("شماره فصل  " + text3 + " موجود است شماره فصل جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([FehrestFile],[FaslCode],[FaslComment],[ZaribCode])(SELECT [FehrestFile],'" + text3 + "'[FaslCode],[FaslComment],[ZaribCode] FROM [dbo].[Fosool] Where [FaslCode]='" + txt_FaslCode.Text + "' And [FehrestFile] = '" + Module1.CurrentFehrestFile + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Fosool();
			checked
			{
				int num = dtg_Fosool.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Fosool.Rows[i].Cells[2].Value.ToString(), text3, TextCompare: false) == 0)
					{
						dtg_Fosool.CurrentCell = dtg_Fosool.Rows[i].Cells[1];
						ShowFaslRecord();
						break;
					}
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			string text = txt_FaslCode.Text;
			int index = dtg_Fosool.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Fosool.RowCount - 1 != 0)
				{
					int index2 = dtg_Fosool.CurrentRow.Index;
					if (MessageBox.Show(" فصل شماره " + txt_FaslCode.Text + " حذف شود؟  ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo].[Fosool] Where [FaslCode]='" + text + "' And [FehrestFile] = '" + Module1.CurrentFehrestFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_Fosool();
				if (index != 0)
				{
					dtg_Fosool.CurrentCell = dtg_Fosool.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Fosool.CurrentCell = dtg_Fosool.Rows[index].Cells[1];
				}
				ShowFaslRecord();
			}
		}

		private void btn_SaveItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			checked
			{
				if (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("شماره ایتم را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_ItemNo.Focus();
				}
				else
				{
					if (pnl_Item.BackColor == Color.DarkKhaki)
					{
						return;
					}
					switch (cmbo_ItemNoa.Text.Trim())
					{
					case "بها دار":
						Darsadi = Conversions.ToByte("0");
						setarehdar = Conversions.ToByte("0");
						break;
					case "درصدی":
						Darsadi = Conversions.ToByte("1");
						setarehdar = Conversions.ToByte("0");
						break;
					case "ستاره دار":
						Darsadi = Conversions.ToByte("0");
						setarehdar = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						Darsadi = Conversions.ToByte("1");
						setarehdar = Conversions.ToByte("1");
						break;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + "  Where [shomar]='" + txt_ItemNo.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره ایتم " + txt_ItemNo.Text + " موجود است شماره ایتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_ItemNo.Text = "";
							txt_ItemNo.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo]." + Module1.CurrentFehrestFile + " ([shomar],[Sharh],[Fasl],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName]) VALUES('" + txt_ItemNo.Text + "','" + txt_ItemSharh.Text + "','" + cmbo_ItemFasl.Text + "','" + cmbo_ItemVahedSharh.Text + "','" + txt_ItemBahavahed.Text + "','" + Conversions.ToString(Darsadi) + "','" + Conversions.ToString(setarehdar) + "','" + cmbo_ItemNoa.Text + "','" + txt_ItemDarsad.Text + "','" + txt_ItemNo.Text.Substring(1, 3) + "','" + cmbo_Group.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_ItemBlue();
					}
					else
					{
						Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "' And [radif] <> '" + Conversions.ToString(Item.Id) + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("شماره ایتم " + txt_ItemNo.Text + " موجود است شماره ایتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_ItemNo.Text = "";
							txt_ItemNo.Focus();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo]." + Module1.CurrentFehrestFile + " SET [shomar] ='" + txt_ItemNo.Text + "',[Sharh] = '" + txt_ItemSharh.Text + "',[Fasl] = '" + cmbo_ItemFasl.Text + "',[Vahed] = '" + cmbo_ItemVahedSharh.Text + "',[baha] = '" + txt_ItemBahavahed.Text + "',[darsad] = '" + Conversions.ToString(Darsadi) + "',[setareh] = '" + Conversions.ToString(setarehdar) + "',[ItemNoa] = '" + cmbo_ItemNoa.Text + "',[ItemDarsad] = '" + txt_ItemDarsad.Text + "',[GroupNo] = '" + txt_ItemNo.Text.Substring(1, 3) + "',[GroupName] = '" + cmbo_Group.Text + "' WHERE [radif] = '" + Conversions.ToString(Item.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Setpnl_ItemBlue();
					}
					text = txt_ItemNo.Text;
					Load_dtg_Item();
					int num = dtg_Item.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Item.Rows[i].Cells[3].Value, text, TextCompare: false))
						{
							dtg_Item.CurrentCell = dtg_Item.Rows[i].Cells[2];
							ShowItemRecord();
						}
					}
				}
			}
		}

		private void Setpnl_ItemBlue()
		{
			pnl_Item.BackColor = Color.DarkKhaki;
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

		private void cmbo_ItemNoa_TextChanged(object sender, EventArgs e)
		{
			if ((Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
			{
				Label5.Visible = true;
				txt_ItemDarsad.Visible = true;
			}
			else
			{
				Label5.Visible = false;
				txt_ItemDarsad.Visible = false;
			}
		}

		private void btn_ExitItem_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

		private void CheckItemChange()
		{
			if (Operators.CompareString(ChangeItemDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Item.BackColor = Color.DarkKhaki;
			foreach (object control in pnl_Item.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Item.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void txt_ItemNo_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void txt_ItemSharh_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
			txt_ItemSharh.SelectionStart = checked(txt_ItemSharh.Text.Length + 1);
		}

		private void txt_ItemDarsad_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void cmbo_ItemVahedSharh_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void cmbo_ItemFasl_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void txt_ItemBahavahed_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void cmbo_ItemNoa_GotFocus(object sender, EventArgs e)
		{
			ChangeItemDtgOrPnl = "pnl";
		}

		private void btn_CopyItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			string text2 = "";
			BtnCommand = "Copy";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text3 = Interaction.InputBox("  کپی آیتم " + Item.ItemNo + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text3, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [shomar] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "' And radif <> '" + Conversions.ToString(Item.Id) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(" آیتم" + text3 + " موجود است شماره آیتم جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo]." + Module1.CurrentFehrestFile + " ([shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection])(SELECT '" + text3 + "'[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection] FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + txt_ItemNo.Text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Item();
			checked
			{
				int num = dtg_Item.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Item.Rows[i].Cells[2].Value.ToString(), text3, TextCompare: false) == 0)
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[i].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

		private void txt_FaslComment_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FaslComment.Text.Trim(), Fasl.FaslComment.Trim(), TextCompare: false) != 0)
			{
				txt_FaslComment.ForeColor = Color.Red;
			}
			else
			{
				txt_FaslComment.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

		private void txt_FaslCode_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FaslCode.Text.Trim(), Fasl.FaslCode.Trim(), TextCompare: false) != 0)
			{
				txt_FaslCode.ForeColor = Color.Red;
			}
			else
			{
				txt_FaslCode.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

		private void cmbo_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ZaribCode.Text.Trim(), Fasl.ZaribCode.Trim(), TextCompare: false) != 0)
			{
				cmbo_ZaribCode.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ZaribCode.ForeColor = Color.Black;
			}
			CheckFosoolChange();
		}

		private void txt_ItemNo_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemNo.Text.Trim(), Item.ItemNo.Trim(), TextCompare: false) != 0)
			{
				txt_ItemNo.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemNo.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

		private void txt_ItemSharh_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemSharh.Text.Trim(), Item.ItemSharh.Trim(), TextCompare: false) != 0)
			{
				txt_ItemSharh.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemSharh.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

		private void cmbo_ItemVahedSharh_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemVahedSharh.Text.Trim(), Item.ItemVahedSharh.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemVahedSharh.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemVahedSharh.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

		private void cmbo_ItemFasl_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemFasl.Text.Trim(), Item.ItemFasl.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemFasl.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemFasl.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

		private void txt_ItemBahavahed_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Conversions.ToDouble(txt_ItemBahavahed.Text.Trim()) != (double)Item.ItemBahaVahed)
				{
					txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemBahavahed.ForeColor = Color.Black;
				}
				CheckItemChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void cmbo_ItemNoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (cmbo_ItemNoa.Text.Trim())
			{
			case "بها دار":
				Darsadi = Conversions.ToByte("0");
				setarehdar = Conversions.ToByte("0");
				break;
			case "درصدی":
				Darsadi = Conversions.ToByte("1");
				setarehdar = Conversions.ToByte("0");
				break;
			case "ستاره دار":
				Darsadi = Conversions.ToByte("0");
				setarehdar = Conversions.ToByte("1");
				break;
			case "درصدی - ستاره دار":
				Darsadi = Conversions.ToByte("1");
				setarehdar = Conversions.ToByte("1");
				break;
			}
			if (Operators.CompareString(cmbo_ItemNoa.Text.Trim(), Item.ItemNoa.Trim(), TextCompare: false) != 0)
			{
				cmbo_ItemNoa.ForeColor = Color.Red;
			}
			else
			{
				cmbo_ItemNoa.ForeColor = Color.Black;
			}
			CheckItemChange();
		}

		private void txt_ItemDarsad_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemDarsad.Text.Trim(), Item.ItemDarsad.Trim(), TextCompare: false) != 0)
				{
					txt_ItemDarsad.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemDarsad.ForeColor = Color.Black;
				}
				CheckItemChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void btn_InsertItem_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_Item_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Item.BackColor = Color.LightPink;
			txt_ItemNo.Text = "";
			txt_ItemSharh.Text = "";
			cmbo_ItemVahedSharh.Text = "";
			cmbo_ItemFasl.Text = "1";
			txt_ItemBahavahed.Text = "";
			cmbo_ItemNoa.Text = "بهادار";
			txt_ItemDarsad.Text = "";
		}

		private void btn_DeleteItem_Click(object sender, EventArgs e)
		{
			string text = txt_ItemNo.Text;
			int index = dtg_Item.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Item.RowCount - 1 != 0)
				{
					int index2 = dtg_Item.CurrentRow.Index;
					if (MessageBox.Show("آیتم شماره " + txt_ItemNo.Text + " حذف شود؟ ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo]." + Module1.CurrentFehrestFile + " Where [shomar]='" + text + "' And [radif] = '" + Conversions.ToString(Item.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				int lErl = 20;
				Load_dtg_Item();
				try
				{
					if (index != 0)
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[index - 1].Cells[1];
					}
					else
					{
						dtg_Item.CurrentCell = dtg_Item.Rows[index].Cells[1];
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				ShowItemRecord();
			}
		}

		private void tbp_Fosool_Click(object sender, EventArgs e)
		{
		}

		private void cmbo_ItemFaslFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemFaslFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemFaslFltr.Text;
				ItemFasl_Filter = " ([Fasl] Like N'%" + text + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

		private void cmbo_ItemVahedSharhFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemVahedSharhFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemVahedSharhFltr.Text;
				ItemFasl_Filter = " (REPLACE(REPLACE([Vahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

		private void cmbo_GroupFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_GroupFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_GroupFltr.Text;
				GroupName_Filter = " (REPLACE(REPLACE([GroupName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				GroupName_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

		private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemNoaFltr.Text;
				ItemFasl_Filter = " ([ItemNoa] Like N'%" + text + "%')";
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemFasl_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}

		private void btn_Search_Click(object sender, EventArgs e)
		{
			string text = cmbo_ItemVahedSharh.Text;
			cmbo_ItemVahedSharh.DroppedDown = false;
			Module1.Load_Cmbo(cmbo_ItemVahedSharh, Module1.CurrentFehrestFile, "Vahed", "");
			if (cmbo_ItemVahedSharh.Items.Count > 0)
			{
				cmbo_ItemVahedSharh.DroppedDown = true;
			}
			cmbo_ItemVahedSharh.Text = text;
			cmbo_ItemVahedSharh.SelectionStart = checked(cmbo_ItemVahedSharh.Text.Length + 1);
		}

		private void btn_GroupSearch_Click(object sender, EventArgs e)
		{
			string text = cmbo_Group.Text;
			cmbo_Group.DroppedDown = false;
			Module1.Load_Cmbo(cmbo_Group, Module1.CurrentFehrestFile, "GroupName", "");
			if (cmbo_Group.Items.Count > 0)
			{
				cmbo_Group.DroppedDown = true;
			}
			cmbo_Group.Text = text;
			cmbo_Group.SelectionStart = checked(cmbo_Group.Text.Length + 1);
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
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ItemSharh_Filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				if (DtgItemRefresh == 1)
				{
					Load_dtg_Item();
				}
				ShowItemRecord();
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
					btn_Filter.Text = "فیلتر";
					return;
				}
				btn_Filter.Text = "حذف فیلتر";
				btn_Filter.BackColor = Color.Red;
			}
			else
			{
				ItemBahaVahed_Filter = "";
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
			if (DtgItemRefresh == 1)
			{
				Load_dtg_Item();
			}
			ShowItemRecord();
		}
	}
}
