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
	public class Frm_ZarayebMantaghe : Form
	{
		public struct ZarayebMantagheDetailes
		{
			public int Id;

			public string OstanCode;

			public string Ostan;

			public string ShahrCode;

			public string Shahr;

			public string BakhshCode;

			public string Bakhsh;

			public int ZaribCode;

			public float zarib_F;

			public string Comment;
		}

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ZaribMantagheFltr")]
		private TextBox _txt_ZaribMantagheFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_OstanCodeFltr")]
		private ComboBox _cmbo_OstanCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_OstanFltr")]
		private ComboBox _cmbo_OstanFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ShahrCodeFltr")]
		private ComboBox _cmbo_ShahrCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_ZarayebMantaghe")]
		private DataGridView _dtg_ZarayebMantaghe;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Exit")]
		private Button _btn_Exit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Save")]
		private Button _Btn_Save;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_Zarib_F")]
		private TextBox _txt_Zarib_F;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_BakhshCodeFltr")]
		private ComboBox _cmbo_BakhshCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ShahrFltr")]
		private ComboBox _cmbo_ShahrFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_BakhshFltr")]
		private ComboBox _cmbo_BakhshFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ZaribCodeFltr")]
		private ComboBox _cmbo_ZaribCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_CommentFltr")]
		private ComboBox _cmbo_CommentFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_ZaribCode")]
		private Button _btn_ZaribCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Delete")]
		private Button _btn_Delete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_copy")]
		private Button _btn_copy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Insert")]
		private Button _btn_Insert;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_BakhshCode")]
		private ComboBox _cmbo_BakhshCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_Shahr")]
		private ComboBox _cmbo_Shahr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_Bakhsh")]
		private ComboBox _cmbo_Bakhsh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_OstanCode")]
		private ComboBox _cmbo_OstanCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_Ostan")]
		private ComboBox _cmbo_Ostan;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ShahrCode")]
		private ComboBox _cmbo_ShahrCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ZaribCode")]
		private ComboBox _cmbo_ZaribCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_Comment")]
		private ComboBox _cmbo_Comment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Filter")]
		private Button _btn_Filter;

		public string Ostan_filter;

		public string OstanCode_filter;

		public string Shahr_filter;

		public string ShahrCode_filter;

		public string Bakhsh_filter;

		public string BakhshCode_filter;

		public string ZaribMantaghe_filter;

		public string ZaribCode_filter;

		public string Comment_filter;

		private byte frmZaribMantagheRefresh;

		private byte DtgZaribMantaghetRefresh;

		private string BtnCommand;

		private string ChangeDtgOrPnl;

		public ZarayebMantagheDetailes ZarayebMantaghe;

        private System.Windows.Forms.ComboBox cmbo_ZaribBakhshname;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.TextBox txt_ZaribMantagheFltr;
        private System.Windows.Forms.ComboBox cmbo_OstanCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_OstanFltr;
        private System.Windows.Forms.ComboBox cmbo_ShahrCodeFltr;
        private System.Windows.Forms.Button Button17;
        private System.Windows.Forms.DataGridView dtg_ZarayebMantaghe;
        private System.Windows.Forms.Panel Pnl_Zarib;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.TextBox txt_Zarib_F;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ComboBox cmbo_BakhshCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_ShahrFltr;
        private System.Windows.Forms.ComboBox cmbo_BakhshFltr;
        private System.Windows.Forms.ComboBox cmbo_ZaribCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_CommentFltr;
        private System.Windows.Forms.Button btn_ZaribCode;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.ComboBox cmbo_BakhshCode;
        private System.Windows.Forms.ComboBox cmbo_Shahr;
        private System.Windows.Forms.ComboBox cmbo_Bakhsh;
        private System.Windows.Forms.ComboBox cmbo_OstanCode;
        private System.Windows.Forms.ComboBox cmbo_Ostan;
        private System.Windows.Forms.ComboBox cmbo_ShahrCode;
        private System.Windows.Forms.ComboBox cmbo_ZaribCode;
        private System.Windows.Forms.ComboBox cmbo_Comment;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Label lbl_RecNo;
        public Frm_ZarayebMantaghe()
		{
			base.KeyDown += Frm_ZarayebMantaghe_KeyDown;
			base.Load += Frm_ZarayebMantaghe_Load;
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_ZarayebMantaghe));
			this.cmbo_ZaribBakhshname = new System.Windows.Forms.ComboBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.cmbo_ZaribCodeFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_CommentFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_BakhshCodeFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ShahrFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_BakhshFltr = new System.Windows.Forms.ComboBox();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_ZaribMantagheFltr = new System.Windows.Forms.TextBox();
			this.cmbo_OstanCodeFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_OstanFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ShahrCodeFltr = new System.Windows.Forms.ComboBox();
			this.Button17 = new System.Windows.Forms.Button();
			this.dtg_ZarayebMantaghe = new System.Windows.Forms.DataGridView();
			this.Pnl_Zarib = new System.Windows.Forms.Panel();
			this.lbl_RecNo = new System.Windows.Forms.Label();
			this.cmbo_ZaribCode = new System.Windows.Forms.ComboBox();
			this.cmbo_Comment = new System.Windows.Forms.ComboBox();
			this.cmbo_BakhshCode = new System.Windows.Forms.ComboBox();
			this.cmbo_Shahr = new System.Windows.Forms.ComboBox();
			this.cmbo_Bakhsh = new System.Windows.Forms.ComboBox();
			this.cmbo_OstanCode = new System.Windows.Forms.ComboBox();
			this.cmbo_Ostan = new System.Windows.Forms.ComboBox();
			this.cmbo_ShahrCode = new System.Windows.Forms.ComboBox();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_copy = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.btn_ZaribCode = new System.Windows.Forms.Button();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Label9 = new System.Windows.Forms.Label();
			this.txt_Zarib_F = new System.Windows.Forms.TextBox();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_ZarayebMantaghe).BeginInit();
			this.Pnl_Zarib.SuspendLayout();
			base.SuspendLayout();
			this.cmbo_ZaribBakhshname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ZaribBakhshname.FormattingEnabled = true;
			this.cmbo_ZaribBakhshname.Location = new System.Drawing.Point(44, 12);
			this.cmbo_ZaribBakhshname.Name = "cmbo_ZaribBakhshname";
			this.cmbo_ZaribBakhshname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ZaribBakhshname.Size = new System.Drawing.Size(719, 28);
			this.cmbo_ZaribBakhshname.TabIndex = 139;
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(1009, 16);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label11.Size = new System.Drawing.Size(54, 13);
			this.Label11.TabIndex = 141;
			this.Label11.Text = "کد ضریب :";
			this.Label11.Visible = false;
			this.pnl_Filter.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.cmbo_ZaribCodeFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_CommentFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_BakhshCodeFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ShahrFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_BakhshFltr);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.txt_ZaribMantagheFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_OstanCodeFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_OstanFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ShahrCodeFltr);
			this.pnl_Filter.Controls.Add(this.Button17);
			this.pnl_Filter.Location = new System.Drawing.Point(10, 10);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1227, 64);
			this.pnl_Filter.TabIndex = 144;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1173, 4);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(49, 56);
			this.Label10.TabIndex = 153;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmbo_ZaribCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ZaribCodeFltr.FormattingEnabled = true;
			this.cmbo_ZaribCodeFltr.Location = new System.Drawing.Point(458, 40);
			this.cmbo_ZaribCodeFltr.Name = "cmbo_ZaribCodeFltr";
			this.cmbo_ZaribCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ZaribCodeFltr.Size = new System.Drawing.Size(70, 21);
			this.cmbo_ZaribCodeFltr.TabIndex = 89;
			this.cmbo_CommentFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_CommentFltr.FormattingEnabled = true;
			this.cmbo_CommentFltr.Location = new System.Drawing.Point(16, 40);
			this.cmbo_CommentFltr.Name = "cmbo_CommentFltr";
			this.cmbo_CommentFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_CommentFltr.Size = new System.Drawing.Size(441, 21);
			this.cmbo_CommentFltr.TabIndex = 90;
			this.cmbo_BakhshCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_BakhshCodeFltr.FormattingEnabled = true;
			this.cmbo_BakhshCodeFltr.Location = new System.Drawing.Point(724, 40);
			this.cmbo_BakhshCodeFltr.Name = "cmbo_BakhshCodeFltr";
			this.cmbo_BakhshCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_BakhshCodeFltr.Size = new System.Drawing.Size(67, 21);
			this.cmbo_BakhshCodeFltr.TabIndex = 86;
			this.cmbo_ShahrFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ShahrFltr.FormattingEnabled = true;
			this.cmbo_ShahrFltr.Location = new System.Drawing.Point(792, 40);
			this.cmbo_ShahrFltr.Name = "cmbo_ShahrFltr";
			this.cmbo_ShahrFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ShahrFltr.Size = new System.Drawing.Size(120, 21);
			this.cmbo_ShahrFltr.TabIndex = 85;
			this.cmbo_BakhshFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_BakhshFltr.FormattingEnabled = true;
			this.cmbo_BakhshFltr.Location = new System.Drawing.Point(604, 40);
			this.cmbo_BakhshFltr.Name = "cmbo_BakhshFltr";
			this.cmbo_BakhshFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_BakhshFltr.Size = new System.Drawing.Size(119, 21);
			this.cmbo_BakhshFltr.TabIndex = 87;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(17, 2);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1206, 36);
			this.PictureBox1.TabIndex = 147;
			this.PictureBox1.TabStop = false;
			this.txt_ZaribMantagheFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ZaribMantagheFltr.Location = new System.Drawing.Point(529, 40);
			this.txt_ZaribMantagheFltr.Name = "txt_ZaribMantagheFltr";
			this.txt_ZaribMantagheFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ZaribMantagheFltr.Size = new System.Drawing.Size(74, 20);
			this.txt_ZaribMantagheFltr.TabIndex = 88;
			this.cmbo_OstanCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_OstanCodeFltr.FormattingEnabled = true;
			this.cmbo_OstanCodeFltr.Location = new System.Drawing.Point(1102, 40);
			this.cmbo_OstanCodeFltr.Name = "cmbo_OstanCodeFltr";
			this.cmbo_OstanCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_OstanCodeFltr.Size = new System.Drawing.Size(69, 21);
			this.cmbo_OstanCodeFltr.TabIndex = 82;
			this.cmbo_OstanFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_OstanFltr.FormattingEnabled = true;
			this.cmbo_OstanFltr.Location = new System.Drawing.Point(983, 40);
			this.cmbo_OstanFltr.Name = "cmbo_OstanFltr";
			this.cmbo_OstanFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_OstanFltr.Size = new System.Drawing.Size(118, 21);
			this.cmbo_OstanFltr.TabIndex = 83;
			this.cmbo_ShahrCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ShahrCodeFltr.FormattingEnabled = true;
			this.cmbo_ShahrCodeFltr.Location = new System.Drawing.Point(913, 40);
			this.cmbo_ShahrCodeFltr.Name = "cmbo_ShahrCodeFltr";
			this.cmbo_ShahrCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ShahrCodeFltr.Size = new System.Drawing.Size(69, 21);
			this.cmbo_ShahrCodeFltr.TabIndex = 84;
			this.Button17.BackColor = System.Drawing.Color.LightGray;
			this.Button17.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button17.ForeColor = System.Drawing.Color.Black;
			this.Button17.Location = new System.Drawing.Point(1506, 7);
			this.Button17.Name = "Button17";
			this.Button17.Size = new System.Drawing.Size(89, 21);
			this.Button17.TabIndex = 44;
			this.Button17.Text = "حذف فیلتر";
			this.Button17.UseVisualStyleBackColor = false;
			this.dtg_ZarayebMantaghe.AllowUserToAddRows = false;
			this.dtg_ZarayebMantaghe.AllowUserToDeleteRows = false;
			this.dtg_ZarayebMantaghe.AllowUserToOrderColumns = true;
			this.dtg_ZarayebMantaghe.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_ZarayebMantaghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_ZarayebMantaghe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_ZarayebMantaghe.Location = new System.Drawing.Point(10, 41);
			this.dtg_ZarayebMantaghe.Name = "dtg_ZarayebMantaghe";
			this.dtg_ZarayebMantaghe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_ZarayebMantaghe.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_ZarayebMantaghe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_ZarayebMantaghe.Size = new System.Drawing.Size(1265, 501);
			this.dtg_ZarayebMantaghe.TabIndex = 143;
			this.Pnl_Zarib.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.Pnl_Zarib.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Pnl_Zarib.Controls.Add(this.lbl_RecNo);
			this.Pnl_Zarib.Controls.Add(this.cmbo_ZaribCode);
			this.Pnl_Zarib.Controls.Add(this.cmbo_Comment);
			this.Pnl_Zarib.Controls.Add(this.cmbo_BakhshCode);
			this.Pnl_Zarib.Controls.Add(this.cmbo_Shahr);
			this.Pnl_Zarib.Controls.Add(this.cmbo_Bakhsh);
			this.Pnl_Zarib.Controls.Add(this.cmbo_OstanCode);
			this.Pnl_Zarib.Controls.Add(this.cmbo_Ostan);
			this.Pnl_Zarib.Controls.Add(this.cmbo_ShahrCode);
			this.Pnl_Zarib.Controls.Add(this.btn_Delete);
			this.Pnl_Zarib.Controls.Add(this.btn_copy);
			this.Pnl_Zarib.Controls.Add(this.btn_Insert);
			this.Pnl_Zarib.Controls.Add(this.btn_ZaribCode);
			this.Pnl_Zarib.Controls.Add(this.Label5);
			this.Pnl_Zarib.Controls.Add(this.Label4);
			this.Pnl_Zarib.Controls.Add(this.Label3);
			this.Pnl_Zarib.Controls.Add(this.Label2);
			this.Pnl_Zarib.Controls.Add(this.Label1);
			this.Pnl_Zarib.Controls.Add(this.Label6);
			this.Pnl_Zarib.Controls.Add(this.Label7);
			this.Pnl_Zarib.Controls.Add(this.Label8);
			this.Pnl_Zarib.Controls.Add(this.btn_Exit);
			this.Pnl_Zarib.Controls.Add(this.Btn_Save);
			this.Pnl_Zarib.Controls.Add(this.Label9);
			this.Pnl_Zarib.Controls.Add(this.txt_Zarib_F);
			this.Pnl_Zarib.Location = new System.Drawing.Point(10, 548);
			this.Pnl_Zarib.Name = "Pnl_Zarib";
			this.Pnl_Zarib.Size = new System.Drawing.Size(1265, 150);
			this.Pnl_Zarib.TabIndex = 142;
			this.lbl_RecNo.AutoSize = true;
			this.lbl_RecNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_RecNo.Location = new System.Drawing.Point(1172, 8);
			this.lbl_RecNo.Name = "lbl_RecNo";
			this.lbl_RecNo.Size = new System.Drawing.Size(61, 13);
			this.lbl_RecNo.TabIndex = 150;
			this.lbl_RecNo.Text = "تعداد رکورد";
			this.cmbo_ZaribCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_ZaribCode.FormattingEnabled = true;
			this.cmbo_ZaribCode.Location = new System.Drawing.Point(988, 27);
			this.cmbo_ZaribCode.Name = "cmbo_ZaribCode";
			this.cmbo_ZaribCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ZaribCode.Size = new System.Drawing.Size(85, 21);
			this.cmbo_ZaribCode.TabIndex = 91;
			this.cmbo_Comment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_Comment.FormattingEnabled = true;
			this.cmbo_Comment.Location = new System.Drawing.Point(207, 27);
			this.cmbo_Comment.Name = "cmbo_Comment";
			this.cmbo_Comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Comment.Size = new System.Drawing.Size(781, 21);
			this.cmbo_Comment.TabIndex = 92;
			this.cmbo_BakhshCode.FormattingEnabled = true;
			this.cmbo_BakhshCode.Location = new System.Drawing.Point(459, 80);
			this.cmbo_BakhshCode.Name = "cmbo_BakhshCode";
			this.cmbo_BakhshCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_BakhshCode.Size = new System.Drawing.Size(78, 21);
			this.cmbo_BakhshCode.TabIndex = 97;
			this.cmbo_Shahr.FormattingEnabled = true;
			this.cmbo_Shahr.Location = new System.Drawing.Point(574, 80);
			this.cmbo_Shahr.Name = "cmbo_Shahr";
			this.cmbo_Shahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Shahr.Size = new System.Drawing.Size(151, 21);
			this.cmbo_Shahr.TabIndex = 96;
			this.cmbo_Bakhsh.FormattingEnabled = true;
			this.cmbo_Bakhsh.Location = new System.Drawing.Point(313, 80);
			this.cmbo_Bakhsh.Name = "cmbo_Bakhsh";
			this.cmbo_Bakhsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Bakhsh.Size = new System.Drawing.Size(146, 21);
			this.cmbo_Bakhsh.TabIndex = 98;
			this.cmbo_OstanCode.FormattingEnabled = true;
			this.cmbo_OstanCode.Location = new System.Drawing.Point(988, 80);
			this.cmbo_OstanCode.Name = "cmbo_OstanCode";
			this.cmbo_OstanCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_OstanCode.Size = new System.Drawing.Size(85, 21);
			this.cmbo_OstanCode.TabIndex = 93;
			this.cmbo_Ostan.FormattingEnabled = true;
			this.cmbo_Ostan.Location = new System.Drawing.Point(838, 80);
			this.cmbo_Ostan.Name = "cmbo_Ostan";
			this.cmbo_Ostan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_Ostan.Size = new System.Drawing.Size(150, 21);
			this.cmbo_Ostan.TabIndex = 94;
			this.cmbo_ShahrCode.FormattingEnabled = true;
			this.cmbo_ShahrCode.Location = new System.Drawing.Point(725, 80);
			this.cmbo_ShahrCode.Name = "cmbo_ShahrCode";
			this.cmbo_ShahrCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ShahrCode.Size = new System.Drawing.Size(83, 21);
			this.cmbo_ShahrCode.TabIndex = 95;
			this.btn_Delete.Enabled = false;
			this.btn_Delete.Location = new System.Drawing.Point(335, 116);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(80, 25);
			this.btn_Delete.TabIndex = 103;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_copy.Location = new System.Drawing.Point(572, 116);
			this.btn_copy.Name = "btn_copy";
			this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_copy.Size = new System.Drawing.Size(80, 25);
			this.btn_copy.TabIndex = 102;
			this.btn_copy.Text = "(Clt+C) کپی";
			this.btn_copy.UseVisualStyleBackColor = true;
			this.btn_Insert.Location = new System.Drawing.Point(800, 116);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Insert.Size = new System.Drawing.Size(80, 25);
			this.btn_Insert.TabIndex = 101;
			this.btn_Insert.Text = "(Ins) ایجاد ";
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.btn_ZaribCode.Image = (System.Drawing.Image)resources.GetObject("btn_ZaribCode.Image");
			this.btn_ZaribCode.Location = new System.Drawing.Point(178, 24);
			this.btn_ZaribCode.Name = "btn_ZaribCode";
			this.btn_ZaribCode.Size = new System.Drawing.Size(28, 26);
			this.btn_ZaribCode.TabIndex = 149;
			this.ToolTip1.SetToolTip(this.btn_ZaribCode, "اصلاح");
			this.btn_ZaribCode.UseVisualStyleBackColor = true;
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(549, 11);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(88, 13);
			this.Label5.TabIndex = 139;
			this.Label5.Text = "شرح کد بخش نامه";
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(1008, 11);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(60, 13);
			this.Label4.TabIndex = 138;
			this.Label4.Text = "کد بخشنامه";
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(480, 65);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(42, 13);
			this.Label3.TabIndex = 134;
			this.Label3.Text = "کد بخش";
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(744, 65);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(42, 13);
			this.Label2.TabIndex = 132;
			this.Label2.Text = "کد شهر";
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(1007, 65);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(49, 13);
			this.Label1.TabIndex = 130;
			this.Label1.Text = "کد استان";
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(388, 65);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(27, 13);
			this.Label6.TabIndex = 122;
			this.Label6.Text = "بخش";
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(641, 65);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(27, 13);
			this.Label7.TabIndex = 120;
			this.Label7.Text = "شهر";
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(904, 65);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(34, 13);
			this.Label8.TabIndex = 117;
			this.Label8.Text = "استان";
			this.btn_Exit.Location = new System.Drawing.Point(132, 116);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(80, 25);
			this.btn_Exit.TabIndex = 104;
			this.btn_Exit.Text = " خروج ";
			this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.Btn_Save.Location = new System.Drawing.Point(1050, 116);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(80, 25);
			this.Btn_Save.TabIndex = 100;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Label9.AutoSize = true;
			this.Label9.Location = new System.Drawing.Point(214, 65);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(33, 13);
			this.Label9.TabIndex = 95;
			this.Label9.Text = "ضریب";
			this.txt_Zarib_F.Location = new System.Drawing.Point(176, 80);
			this.txt_Zarib_F.Name = "txt_Zarib_F";
			this.txt_Zarib_F.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_Zarib_F.Size = new System.Drawing.Size(100, 20);
			this.txt_Zarib_F.TabIndex = 99;
			this.btn_Filter.BackColor = System.Drawing.Color.LightGray;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(1236, 43);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(38, 32);
			this.btn_Filter.TabIndex = 145;
			this.ToolTip1.SetToolTip(this.btn_Filter, "فیلتر");
			this.btn_Filter.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new System.Drawing.Size(1284, 702);
			base.Controls.Add(this.btn_Filter);
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.dtg_ZarayebMantaghe);
			base.Controls.Add(this.Pnl_Zarib);
			base.Controls.Add(this.Label11);
			base.Name = "Frm_ZarayebMantaghe";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "لیست ضرایب منطقه ای";
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_ZarayebMantaghe).EndInit();
			this.Pnl_Zarib.ResumeLayout(false);
			this.Pnl_Zarib.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
            this.txt_ZaribMantagheFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ZaribMantagheFltr_KeyDown);
            this.cmbo_OstanCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanCodeCodeFltr_SelectedIndexChanged);
            this.cmbo_OstanCodeFltr.TextChanged += new System.EventHandler(this.cmbo_OstanCodeFltr_TextChanged);
            this.cmbo_OstanFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanFltr_SelectedIndexChanged);
            this.cmbo_OstanFltr.TextChanged += new System.EventHandler(this.cmbo_OstanFltr_TextChanged);
            this.cmbo_ShahrCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrCodeFltr_SelectedIndexChanged);
            this.cmbo_ShahrCodeFltr.TextChanged += new System.EventHandler(this.cmbo_ShahrCodeFltr_TextChanged);
            this.dtg_ZarayebMantaghe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ZarayebMantaghe_CellClick);
            this.dtg_ZarayebMantaghe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ZarayebMantaghe_CellContentClick);
            this.dtg_ZarayebMantaghe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_ZarayebMantaghe_KeyDown);
            this.dtg_ZarayebMantaghe.SelectionChanged += new System.EventHandler(this.dtg_ZarayebMantaghe_SelectionChanged);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.GotFocus += new System.EventHandler(this.btn_Exit_GotFocus);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.Btn_Save.GotFocus += new System.EventHandler(this.Btn_Save_GotFocus);
            this.txt_Zarib_F.GotFocus += new System.EventHandler(this.txt_Zarib_F_GotFocus);
            this.txt_Zarib_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Zarib_F_KeyPress);
            this.txt_Zarib_F.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Zarib_F_KeyUp);
            this.txt_Zarib_F.TextChanged += new System.EventHandler(this.txt_Zarib_F_TextChanged);
            this.cmbo_BakhshCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshCodeFltr_SelectedIndexChanged);
            this.cmbo_BakhshCodeFltr.TextChanged += new System.EventHandler(this.cmbo_BakhshCodeFltr_TextChanged);
            this.cmbo_ShahrFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrFltr_SelectedIndexChanged);
            this.cmbo_ShahrFltr.TextChanged += new System.EventHandler(this.cmbo_ShahrFltr_TextChanged);
            this.cmbo_BakhshFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshFltr_SelectedIndexChanged);
            this.cmbo_BakhshFltr.TextChanged += new System.EventHandler(this.cmbo_BakhshFltr_TextChanged);
            this.cmbo_ZaribCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ZaribCodeFltr_SelectedIndexChanged);
            this.cmbo_ZaribCodeFltr.TextChanged += new System.EventHandler(this.cmbo_ZaribCodeFltr_TextChanged);
            this.cmbo_CommentFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_CommentFltr_SelectedIndexChanged);
            this.cmbo_CommentFltr.TextChanged += new System.EventHandler(this.cmbo_CommentFltr_TextChanged);
            this.btn_ZaribCode.Click += new System.EventHandler(this.btn_ZaribCode_Click);
            this.btn_ZaribCode.GotFocus += new System.EventHandler(this.btn_ZaribCode_GotFocus);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.GotFocus += new System.EventHandler(this.btn_Delete_GotFocus);
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            this.btn_copy.GotFocus += new System.EventHandler(this.btn_copy_GotFocus);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.GotFocus += new System.EventHandler(this.btn_Insert_GotFocus);
            this.cmbo_BakhshCode.GotFocus += new System.EventHandler(this.cmbo_BakhshCode_GotFocus);
            this.cmbo_BakhshCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshCode_SelectedIndexChanged);
            this.cmbo_BakhshCode.TextChanged += new System.EventHandler(this.cmbo_BakhshCode_TextChanged);
            this.cmbo_Shahr.GotFocus += new System.EventHandler(this.cmbo_Shahr_GotFocus);
            this.cmbo_Shahr.SelectedIndexChanged += new System.EventHandler(this.cmbo_Shahr_SelectedIndexChanged);
            this.cmbo_Shahr.TextChanged += new System.EventHandler(this.cmbo_Shahr_TextChanged);
            this.cmbo_Bakhsh.GotFocus += new System.EventHandler(this.cmbo_Bakhsh_GotFocus);
            this.cmbo_Bakhsh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_Bakhsh_KeyUp);
            this.cmbo_Bakhsh.LostFocus += new System.EventHandler(this.cmbo_Bakhsh_LostFocus);
            this.cmbo_Bakhsh.SelectedIndexChanged += new System.EventHandler(this.cmbo_Bakhsh_SelectedIndexChanged);
            this.cmbo_Bakhsh.TextChanged += new System.EventHandler(this.cmbo_Bakhsh_TextChanged);
            this.cmbo_OstanCode.GotFocus += new System.EventHandler(this.cmbo_OstanCode_GotFocus);
            this.cmbo_OstanCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_OstanCode_KeyDown);
            this.cmbo_OstanCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_OstanCode_KeyUp);
            this.cmbo_OstanCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanCode_SelectedIndexChanged);
            this.cmbo_OstanCode.TextChanged += new System.EventHandler(this.cmbo_OstanCode_TextChanged);
            this.cmbo_Ostan.GotFocus += new System.EventHandler(this.cmbo_Ostan_GotFocus);
            this.cmbo_Ostan.SelectedIndexChanged += new System.EventHandler(this.cmbo_Ostan_SelectedIndexChanged);
            this.cmbo_Ostan.TextChanged += new System.EventHandler(this.cmbo_Ostan_TextChanged);
            this.cmbo_ShahrCode.FormatStringChanged += new System.EventHandler(this.cmbo_ShahrCode_FormatStringChanged);
            this.cmbo_ShahrCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrCode_SelectedIndexChanged);
            this.cmbo_ShahrCode.TextChanged += new System.EventHandler(this.cmbo_ShahrCode_TextChanged);
            this.cmbo_ZaribCode.GotFocus += new System.EventHandler(this.cmbo_ZaribCode_GotFocus);
            this.cmbo_ZaribCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_ZaribCode_SelectedIndexChanged);
            this.cmbo_ZaribCode.TextChanged += new System.EventHandler(this.cmbo_ZaribCode_TextChanged);
            this.cmbo_Comment.GotFocus += new System.EventHandler(this.cmbo_Comment_GotFocus);
            this.cmbo_Comment.SelectedIndexChanged += new System.EventHandler(this.cmbo_Comment_SelectedIndexChanged);
            this.cmbo_Comment.TextChanged += new System.EventHandler(this.cmbo_Comment_TextChanged);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
        }

		public void Load_dtg_ZarayebMantaghe()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[9];
			DtgZaribMantaghetRefresh = 0;
			base.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 8);
				if (Operators.CompareString(OstanCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Ostan_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Ostan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ShahrCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Shahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(BakhshCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(Bakhsh_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ZaribMantaghe_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(ZaribCode_filter, "", TextCompare: false) != 0 && Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
				{
					array[8] = " And ";
				}
				Module1.strWhere = " WHERE " + OstanCode_filter + array[1] + Ostan_filter + array[2] + ShahrCode_filter + array[3] + Shahr_filter + array[4] + BakhshCode_filter + array[5] + Bakhsh_filter + array[6] + ZaribMantaghe_filter + array[7] + ZaribCode_filter + array[8] + Comment_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [Id] As 'Id',[Id] As 'ردیف',[OstanCode] As 'کد استان',[Ostan] As 'استان',[ShahrCode] As 'کد شهر',[Shahr] As 'شهر',[BakhshCode] As 'کد بخش',[Bakhsh] As 'بخش',[zarib_F] As 'ضریب منطقه ای',[ZaribCode] As 'کد بخشنامه',[Comment] As 'شرح کد بخشنامه' FROM [dbo].[ZarayebMantaghe] " + Module1.strWhere + " Order By  OstanCode , ShahrCode , BakhshCode , ZaribCode ";
				SqlDataReader reader = Module1.cmd.ExecuteReader();
				dataTable.Load(reader);
				foreach (DataColumn column in dataTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
				}
				dtg_ZarayebMantaghe.DataSource = dataTable;
				dtg_ZarayebMantaghe.Columns[0].Visible = false;
				dtg_ZarayebMantaghe.Columns[1].Width = 50;
				dtg_ZarayebMantaghe.Columns[2].Width = 70;
				dtg_ZarayebMantaghe.Columns[3].Width = 120;
				dtg_ZarayebMantaghe.Columns[4].Width = 70;
				dtg_ZarayebMantaghe.Columns[5].Width = 120;
				dtg_ZarayebMantaghe.Columns[6].Width = 70;
				dtg_ZarayebMantaghe.Columns[7].Width = 120;
				dtg_ZarayebMantaghe.Columns[8].Width = 75;
				dtg_ZarayebMantaghe.Columns[9].Width = 70;
				dtg_ZarayebMantaghe.Columns[10].Width = 440;
				DtgZaribMantaghetRefresh = 1;
				lbl_RecNo.Text = Conversions.ToString(dataTable.Rows.Count) + " :تعداد رکورد";
			}
		}

		private void Frm_ZarayebMantaghe_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_ZarayebMantaghe_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			DataTable dataTable = new DataTable();
			base.KeyPreview = true;
			Pnl_Zarib.Visible = false;
			dtg_ZarayebMantaghe.Height = 650;
			frmZaribMantagheRefresh = 0;
			string strWhere = " ";
			Load_Cmbo_FrmZarayeb(cmbo_OstanCodeFltr, "ZarayebMantaghe", "OstanCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_OstanFltr, "ZarayebMantaghe", "Ostan", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ZaribCodeFltr, "ZarayebMantaghe", "ZaribCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_CommentFltr, "ZarayebMantaghe", "Comment", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_OstanCode, "ZarayebMantaghe", "OstanCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Ostan, "ZarayebMantaghe", "Ostan", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_ZaribCode, "ZarayebBakhshname", "ZaribCode", strWhere);
			Load_Cmbo_FrmZarayeb(cmbo_Comment, "ZarayebMantaghe", "Comment", strWhere);
			FilterClear();
			Load_dtg_ZarayebMantaghe();
			dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[0].Cells[1];
			ShowZarayebMantagheRecord();
			frmZaribMantagheRefresh = 1;
			foreach (Control control in Pnl_Zarib.Controls)
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
			foreach (Control control in Pnl_Zarib.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		public void ShowZarayebMantagheRecord()
		{
			int index = 0;
			ref ZarayebMantagheDetailes zarayebMantaghe = ref ZarayebMantaghe;
			int lErl = default(int);
			if (dtg_ZarayebMantaghe.RowCount != 0)
			{
				try
				{
					index = dtg_ZarayebMantaghe.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				zarayebMantaghe.Id = Conversions.ToInteger(dtg_ZarayebMantaghe.Rows[index].Cells[0].Value);
				zarayebMantaghe.OstanCode = Conversions.ToString(dtg_ZarayebMantaghe.Rows[index].Cells[2].Value);
				zarayebMantaghe.Ostan = Conversions.ToString(dtg_ZarayebMantaghe.Rows[index].Cells[3].Value);
				zarayebMantaghe.ShahrCode = dtg_ZarayebMantaghe.Rows[index].Cells[4].Value.ToString();
				zarayebMantaghe.Shahr = dtg_ZarayebMantaghe.Rows[index].Cells[5].Value.ToString();
				zarayebMantaghe.BakhshCode = dtg_ZarayebMantaghe.Rows[index].Cells[6].Value.ToString();
				zarayebMantaghe.Bakhsh = dtg_ZarayebMantaghe.Rows[index].Cells[7].Value.ToString();
				zarayebMantaghe.zarib_F = Conversions.ToSingle(dtg_ZarayebMantaghe.Rows[index].Cells[8].Value.ToString());
				zarayebMantaghe.ZaribCode = Conversions.ToInteger(dtg_ZarayebMantaghe.Rows[index].Cells[9].Value.ToString());
				zarayebMantaghe.Comment = dtg_ZarayebMantaghe.Rows[index].Cells[10].Value.ToString();
				cmbo_OstanCode.Text = zarayebMantaghe.OstanCode;
				cmbo_Ostan.Text = zarayebMantaghe.Ostan;
				cmbo_ShahrCode.Text = zarayebMantaghe.ShahrCode;
				cmbo_Shahr.Text = zarayebMantaghe.Shahr;
				cmbo_BakhshCode.Text = zarayebMantaghe.BakhshCode;
				cmbo_Bakhsh.Text = zarayebMantaghe.Bakhsh;
				txt_Zarib_F.Text = Conversions.ToString(zarayebMantaghe.zarib_F);
				cmbo_ZaribCode.Text = Conversions.ToString(zarayebMantaghe.ZaribCode);
				int zaribCode = zarayebMantaghe.ZaribCode;
				if (zaribCode == Conversions.ToInteger("0"))
				{
					cmbo_Comment.SelectedIndex = 2;
				}
				else if (zaribCode == Conversions.ToInteger("1"))
				{
					cmbo_Comment.SelectedIndex = 1;
				}
				else if (zaribCode == Conversions.ToInteger("2"))
				{
					cmbo_Comment.SelectedIndex = 0;
				}
			}
			lErl = 60;
		}

		private void dtg_ZarayebMantaghe_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowZarayebMantagheRecord();
		}

		private void dtg_ZarayebMantaghe_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowZarayebMantagheRecord();
		}

		private void dtg_ZarayebMantaghe_KeyDown(object sender, KeyEventArgs e)
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
				cmbo_OstanCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_ZarayebMantaghe_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((Pnl_Zarib.BackColor == Color.LightPink) & (frmZaribMantagheRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					Pnl_Zarib.BackColor = Color.DarkSeaGreen;
					break;
				case DialogResult.No:
					Pnl_Zarib.BackColor = Color.DarkSeaGreen;
					break;
				case DialogResult.Cancel:
					cmbo_OstanCode.Focus();
					return;
				}
			}
			if (DtgZaribMantaghetRefresh == 1)
			{
				ShowZarayebMantagheRecord();
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			foreach (Control control in Pnl_Zarib.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && Operators.CompareString(control.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("اطلاعات را کامل کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					control.Focus();
					return;
				}
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
			{
				Module1.cmd.CommandText = "SELECT [Ostan],[Shahr],[Bakhsh] FROM [dbo].[ZarayebMantaghe] Where [Ostan]='" + cmbo_Ostan.Text + "' And [Shahr]='" + cmbo_Shahr.Text + "' And [Bakhsh]='" + cmbo_Bakhsh.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show(". منطقه مذکور موجود است منطقه جدید انتخاب کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbo_Ostan.Focus();
					sqlDataReader.Close();
					return;
				}
				sqlDataReader.Close();
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe] ([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) VALUES('" + cmbo_OstanCode.Text + "','" + cmbo_Ostan.Text + "','" + cmbo_ShahrCode.Text + "','" + cmbo_Shahr.Text + "','" + cmbo_BakhshCode.Text + " ','" + cmbo_Bakhsh.Text + "','" + cmbo_ZaribCode.Text + "','" + txt_Zarib_F.Text + "','" + cmbo_Comment.Text + "')";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_ZaribGreen();
			}
			else
			{
				Module1.cmd.CommandText = "UPDATE [dbo].[ZarayebMantaghe] SET [OstanCode] ='" + cmbo_OstanCode.Text + "',[Ostan] = '" + cmbo_Ostan.Text + "',[ShahrCode] = '" + cmbo_ShahrCode.Text + "',[Shahr] = '" + cmbo_Shahr.Text + "',[BakhshCode] = '" + cmbo_BakhshCode.Text + "',[Bakhsh] = '" + cmbo_Bakhsh.Text + "',[ZaribCode] = '" + cmbo_ZaribCode.Text + "',[zarib_F] = '" + txt_Zarib_F.Text + "',[Comment] = '" + cmbo_Comment.Text + "'WHERE Id = '" + Conversions.ToString(ZarayebMantaghe.Id) + "'";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_ZaribGreen();
			}
			Load_dtg_ZarayebMantaghe();
			DataGridView dataGridView = dtg_ZarayebMantaghe;
			checked
			{
				int num = dataGridView.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[2].Value, cmbo_OstanCode.Text, TextCompare: false), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[4].Value, cmbo_ShahrCode.Text, TextCompare: false)), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[6].Value, cmbo_BakhshCode.Text, TextCompare: false)), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[9].Value, cmbo_ZaribCode.Text, TextCompare: false))))
					{
						dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
						ShowZarayebMantagheRecord();
					}
				}
				dataGridView = null;
			}
		}

		private void Setpnl_ZaribGreen()
		{
			Pnl_Zarib.BackColor = Color.DarkSeaGreen;
			foreach (object control in Pnl_Zarib.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in Pnl_Zarib.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void cmbo_OstanCodeCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_OstanCodeFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_OstanFltr.Text = "";
					strWhere = " Where [OstanCode] = '" + text + "'";
					OstanCode_filter = " ([Ostancode] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					OstanCode_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_OstanFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_OstanFltr.Text;
				OstanCode_filter = "";
				Shahr_filter = "";
				ShahrCode_filter = "";
				Bakhsh_filter = "";
				BakhshCode_filter = "";
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_OstanCodeFltr.Text = "";
					strWhere = " Where [Ostan] = N'" + text + "'";
					Ostan_filter = " ([Ostan] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					Ostan_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCodeFltr, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_ShahrFltr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_ShahrCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ShahrCodeFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_ShahrFltr.Text = "";
					strWhere = " Where [ShahrCode] = '" + text + "'";
					ShahrCode_filter = " ([ShahrCode] Like N'%" + text + "%')";
				}
				else
				{
					strWhere = " ";
					ShahrCode_filter = "";
				}
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_ShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ShahrFltr.Text;
				string strWhere;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_ShahrCodeFltr.Text = "";
					strWhere = " Where [Shahr] = N'" + text + "'";
					Shahr_filter = " ([Shahr] Like N'%" + text + "%')";
				}
				else
				{
					Shahr_filter = "";
					strWhere = " ";
				}
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCodeFltr, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshFltr, "ZarayebMantaghe", "Bakhsh", strWhere);
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_BakhshCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_BakhshCodeFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_BakhshFltr.Text = "";
					BakhshCode_filter = " ([BakhshCode] Like N'%" + text + "%')";
				}
				else
				{
					BakhshCode_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_BakhshFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_BakhshFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					cmbo_BakhshCodeFltr.Text = "";
					Bakhsh_filter = " ([Bakhsh] Like N'%" + text + "%')";
				}
				else
				{
					Bakhsh_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void txt_ZaribMantagheFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ZaribMantagheFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				array = txt_ZaribMantagheFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ZaribMantaghe_filter = " ([zarib_F] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ZaribMantaghe_filter = "([zarib_F] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ZaribMantaghe_filter = "";
				}
			}
			else
			{
				ZaribMantaghe_filter = "";
			}
			Load_dtg_ZarayebMantaghe();
			ShowZarayebMantagheRecord();
		}

		private void cmbo_ZaribCodeFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_ZaribCodeFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					ZaribCode_filter = " ([ZaribCode] Like N'%" + text + "%')";
					Comment_filter = "";
				}
				else
				{
					ZaribCode_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void cmbo_CommentFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				string text = cmbo_CommentFltr.Text;
				if (Operators.CompareString(text, "", TextCompare: false) != 0)
				{
					Comment_filter = " ([Comment] Like N'%" + text + "%')";
					ZaribCode_filter = "";
				}
				else
				{
					Comment_filter = "";
				}
				Load_dtg_ZarayebMantaghe();
				ShowZarayebMantagheRecord();
			}
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (Pnl_Zarib.BackColor == Color.LightPink)
			{
				dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			cmbo_OstanCode.Text = "";
			cmbo_Ostan.Text = "";
			cmbo_ShahrCode.Text = "";
			cmbo_Shahr.Text = "";
			cmbo_BakhshCode.Text = "";
			cmbo_Bakhsh.Text = "";
			txt_Zarib_F.Text = "";
			cmbo_ZaribCode.Text = "";
			cmbo_Comment.Text = "";
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			FilterClear();
			Load_dtg_ZarayebMantaghe();
		}

		private void cmbo_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_ZaribCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [Comment] FROM [dbo].[ZarayebMantaghe]  Where [ZaribCode] = '" + cmbo_ZaribCode.Text + "' Group By [Comment]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			cmbo_Comment.Text = text;
			UpdateZaribCode();
		}

		private void cmbo_Comment_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Comment_SelectedIndexChanged(object sender, EventArgs e)
		{
			string text = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ZaribCode] FROM [dbo].[ZarayebMantaghe]  Where REPLACE(REPLACE([Comment],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(cmbo_Comment.Text) + "' Group By [ZaribCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			cmbo_ZaribCode.Text = text;
			UpdateZaribCode();
		}

		private void btn_ZaribCode_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_ZarayebBakhshname.ShowDialog();
		}

		private void cmbo_ShahrCode_FormatStringChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Shahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_BakhshCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Bakhsh_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Bakhsh_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void txt_Zarib_F_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_Zarib_F_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_Zarib_F.Text = "";
			}
		}

		private void txt_Zarib_F_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".ضریب باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_Zarib_F.Text = "";
			}
		}

		private void btn_copy_Click(object sender, EventArgs e)
		{
			ShowZarayebMantagheRecord();
			int rowIndex = dtg_ZarayebMantaghe.CurrentCell.RowIndex;
			int columnIndex = dtg_ZarayebMantaghe.CurrentCell.ColumnIndex;
			BtnCommand = "Copy";
			if (Pnl_Zarib.BackColor == Color.LightPink)
			{
				dtg_ZarayebMantaghe_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_ZarayebMantaghe.CurrentRow.Index;
			if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(checked(rowIndex + 1)) + " کپی شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe]([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) (SELECT [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment] FROM [dbo].[ZarayebMantaghe] Where [Id]='" + Conversions.ToString(ZarayebMantaghe.Id) + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_ZarayebMantaghe();
				dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[rowIndex].Cells[columnIndex];
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			int rowIndex = dtg_ZarayebMantaghe.CurrentCell.RowIndex;
			int columnIndex = dtg_ZarayebMantaghe.CurrentCell.ColumnIndex;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_ZarayebMantaghe.RowCount - 1 != 0)
				{
					int index = dtg_ZarayebMantaghe.CurrentRow.Index;
					if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(rowIndex + 1) + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
					{
						return;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebMantaghe] WHERE Id = '" + Conversions.ToString(ZarayebMantaghe.Id) + "'";
					Module1.cmd.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				Load_dtg_ZarayebMantaghe();
				if (rowIndex == 0)
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[0].Cells[columnIndex];
				}
				if (rowIndex > dtg_ZarayebMantaghe.RowCount)
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[dtg_ZarayebMantaghe.RowCount].Cells[columnIndex];
				}
				if ((rowIndex > 0) & (dtg_ZarayebMantaghe.RowCount <= dtg_ZarayebMantaghe.RowCount))
				{
					dtg_ZarayebMantaghe.CurrentCell = dtg_ZarayebMantaghe.Rows[rowIndex - 1].Cells[columnIndex];
				}
			}
		}

		private void cmbo_OstanCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_OstanCode_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void cmbo_OstanCode_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void cmbo_OstanCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [OstanCode] = '" + cmbo_OstanCode.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT Ostan FROM [dbo].[ZarayebMantaghe] Where OstanCode ='" + cmbo_OstanCode.Text + "'Group By Ostan";
			SyncCmboZarib(cmbo_Ostan, strCommand);
			UpdateZaribCode();
		}

		private void cmbo_Ostan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Ostan_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_Ostan.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [Ostan] = N'" + cmbo_Ostan.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_ShahrCode, "ZarayebMantaghe", "ShahrCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Shahr, "ZarayebMantaghe", "Shahr", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT OstanCode FROM [dbo].[ZarayebMantaghe] Where Ostan =N'" + cmbo_Ostan.Text + "'Group By OstanCode";
			SyncCmboZarib(cmbo_OstanCode, strCommand);
			UpdateZaribCode();
		}

		private void cmbo_ShahrCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [ShahrCode] = '" + cmbo_ShahrCode.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			string strCommand = "SELECT Shahr FROM [dbo].[ZarayebMantaghe] Where ShahrCode ='" + cmbo_ShahrCode.Text + "'Group By Shahr";
			SyncCmboZarib(cmbo_Shahr, strCommand);
			UpdateZaribCode();
		}

		private void cmbo_Shahr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_Shahr.Text, "", TextCompare: false) != 0)
			{
				string strWhere = " Where [Shahr] = N'" + cmbo_Shahr.Text + "'";
				Load_Cmbo_FrmZarayeb(cmbo_BakhshCode, "ZarayebMantaghe", "BakhshCode", strWhere);
				Load_Cmbo_FrmZarayeb(cmbo_Bakhsh, "ZarayebMantaghe", "Bakhsh", strWhere);
			}
			SyncCmboZarib(strCommand: (Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) ? ("SELECT ShahrCode FROM [dbo].[ZarayebMantaghe] Where Shahr =N'" + cmbo_Shahr.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' Group By ShahrCode") : ("SELECT ShahrCode FROM [dbo].[ZarayebMantaghe] Where Shahr =N'" + cmbo_Shahr.Text + "'Group By ShahrCode"), strCmbo: cmbo_ShahrCode);
			UpdateZaribCode();
		}

		private void cmbo_BakhshCode_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strCommand = "SELECT Bakhsh FROM [dbo].[ZarayebMantaghe] Where BakhshCode ='" + cmbo_BakhshCode.Text + "'Group By Bakhsh";
			SyncCmboZarib(cmbo_Bakhsh, strCommand);
			UpdateZaribCode();
		}

		private void cmbo_Bakhsh_LostFocus(object sender, EventArgs e)
		{
		}

		private void cmbo_Bakhsh_SelectedIndexChanged(object sender, EventArgs e)
		{
			string strCommand = "";
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) == 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) == 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "'Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) == 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And ShahrCode ='" + cmbo_ShahrCode.Text + "' Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) == 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' Group By BakhshCode";
			}
			if ((Operators.CompareString(cmbo_OstanCode.Text, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_ShahrCode.Text, "", TextCompare: false) != 0))
			{
				strCommand = "SELECT BakhshCode FROM [dbo].[ZarayebMantaghe] Where Bakhsh =N'" + cmbo_Bakhsh.Text + "' And OstanCode ='" + cmbo_OstanCode.Text + "' And ShahrCode ='" + cmbo_ShahrCode.Text + "' Group By BakhshCode";
			}
			SyncCmboZarib(cmbo_BakhshCode, strCommand);
			UpdateZaribCode();
		}

		private void SyncCmboZarib(ComboBox strCmbo, string strCommand)
		{
			string right = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = strCommand;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				right = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
			if (Operators.CompareString(strCmbo.Text, right, TextCompare: false) != 0)
			{
				strCmbo.Text = right;
			}
		}

		private void Load_Cmbo_FrmZarayeb(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT " + strField + " FROM [dbo]." + strTable + " " + strWhere + " Group By " + strField + " Order By " + strField;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			dataTable.Load(sqlDataReader);
			sqlDataReader.Close();
			strCmbo.Items.Clear();
			foreach (DataRow row in dataTable.Rows)
			{
				strCmbo.Items.Add(RuntimeHelpers.GetObjectValue(row[strField]));
			}
			strCmbo.Text = "";
		}

		private void cmbo_OstanCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_OstanCode.Text, ZarayebMantaghe.OstanCode, TextCompare: false) != 0)
				{
					cmbo_OstanCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_OstanCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_Ostan_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Ostan.Text, ZarayebMantaghe.Ostan, TextCompare: false) != 0)
				{
					cmbo_Ostan.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Ostan.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_ShahrCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_ShahrCode.Text, ZarayebMantaghe.ShahrCode, TextCompare: false) != 0)
				{
					cmbo_ShahrCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ShahrCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_Shahr_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Shahr.Text, ZarayebMantaghe.Shahr, TextCompare: false) != 0)
				{
					cmbo_Shahr.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Shahr.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_BakhshCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_BakhshCode.Text, ZarayebMantaghe.BakhshCode, TextCompare: false) != 0)
				{
					cmbo_BakhshCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_BakhshCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_Bakhsh_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Bakhsh.Text, ZarayebMantaghe.Bakhsh, TextCompare: false) != 0)
				{
					cmbo_Bakhsh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Bakhsh.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void txt_Zarib_F_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(txt_Zarib_F.Text, ZarayebMantaghe.zarib_F.ToString(), TextCompare: false) != 0)
				{
					txt_Zarib_F.ForeColor = Color.Red;
				}
				else
				{
					txt_Zarib_F.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void CheckZaribMantageChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			Pnl_Zarib.BackColor = Color.DarkSeaGreen;
			foreach (object control in Pnl_Zarib.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					Pnl_Zarib.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in Pnl_Zarib.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					Pnl_Zarib.BackColor = Color.LightPink;
					break;
				}
			}
		}

		public void UpdateZaribCode()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "Select [zarib_F] FROM [dbo].[ZarayebMantaghe] WHERE [OstanCode]='" + cmbo_OstanCode.Text + "' And [ShahrCode]= '" + cmbo_ShahrCode.Text + "' And [BakhshCode]= '" + cmbo_BakhshCode.Text + "' And [ZaribCode]= '" + cmbo_ZaribCode.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			txt_Zarib_F.Text = "";
			while (sqlDataReader.Read())
			{
				txt_Zarib_F.Text = Conversions.ToString(sqlDataReader[0]);
			}
			sqlDataReader.Close();
		}

		public void FindZarib_F()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebMantaghe] WHERE [ZaribCode]='0'";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebMantaghe] ([OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],[ZaribCode],[zarib_F],[Comment]) (SELECT [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh],'0'[ZaribCode],'1'[zarib_F], 'ضريب 1 براي فصل هاي بدون ضريب'[Comment] FROM [dbo].[ZarayebMantaghe] Group by [OstanCode],[Ostan],[ShahrCode],[Shahr],[BakhshCode],[Bakhsh])";
			Module1.cmd.ExecuteNonQuery();
		}

		private void btn_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_Comment_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Operators.CompareString(cmbo_Comment.Text, ZarayebMantaghe.Comment, TextCompare: false) != 0)
				{
					cmbo_Comment.ForeColor = Color.Red;
				}
				else
				{
					cmbo_Comment.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (frmZaribMantagheRefresh != 0)
			{
				if (Conversions.ToDouble(cmbo_ZaribCode.Text) != (double)ZarayebMantaghe.ZaribCode)
				{
					cmbo_ZaribCode.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ZaribCode.ForeColor = Color.Black;
				}
			}
			CheckZaribMantageChange();
		}

		private void cmbo_OstanFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_OstanFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_OstanCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_OstanCodeCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_ShahrCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_ShahrCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_ShahrFltr_TextChanged(object sender, EventArgs e)
		{
		}

		private void cmbo_BakhshCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_BakhshCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_BakhshFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_BakhshFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_ZaribCodeFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_ZaribCodeFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_CommentFltr_TextChanged(object sender, EventArgs e)
		{
			cmbo_CommentFltr_SelectedIndexChanged(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void Btn_Save_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void btn_Insert_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void btn_copy_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void btn_Delete_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void btn_Exit_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void FilterClear()
		{
			btn_Filter.BackColor = Color.LightGray;
			Ostan_filter = "";
			OstanCode_filter = "";
			Shahr_filter = "";
			ShahrCode_filter = "";
			Bakhsh_filter = "";
			BakhshCode_filter = "";
			ZaribMantaghe_filter = "";
			ZaribCode_filter = "";
			Comment_filter = "";
			cmbo_OstanCodeFltr.Text = "";
			cmbo_OstanFltr.Text = "";
			cmbo_ShahrCodeFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_ShahrFltr.Text = "";
			cmbo_BakhshCodeFltr.Text = "";
			cmbo_BakhshFltr.Text = "";
			txt_ZaribMantagheFltr.Text = "";
			cmbo_ZaribCodeFltr.Text = "";
			cmbo_CommentFltr.Text = "";
		}
	}
}
