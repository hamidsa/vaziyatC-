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
	public class Frm_Karfarma : Form
	{
		public struct KarfarmaDetailes
		{
			public int Id;

			public int KarfarmaCode;

			public string KarfarmaName;

			public string Ostan;

			public string Shahr;

			public string KarfarmaEghtesadiCode;

			public string KarfarmaMelliCode;

			public string KarfarmaPostCode;

			public string KarfarmaAddress;

			public string KarfarmaTel;
		}

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_KarfarmaShahr")]
		private ComboBox _cmbo_KarfarmaShahr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_KarfarmaOstan")]
		private ComboBox _cmbo_KarfarmaOstan;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaTel")]
		private TextBox _txt_KarfarmaTel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaAddress")]
		private TextBox _txt_KarfarmaAddress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaCode")]
		private TextBox _txt_KarfarmaCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaName")]
		private TextBox _txt_KarfarmaName;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_Karfarma")]
		private DataGridView _dtg_Karfarma;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_KarfarmaShahrFltr")]
		private ComboBox _cmbo_KarfarmaShahrFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaNameFltr")]
		private TextBox _txt_KarfarmaNameFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_KarfarmaOstanFltr")]
		private ComboBox _cmbo_KarfarmaOstanFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaMelliCodelFltr")]
		private TextBox _txt_KarfarmaMelliCodelFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaEghtesadiCodeFltr")]
		private TextBox _txt_KarfarmaEghtesadiCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaPostCode")]
		private TextBox _txt_KarfarmaPostCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaMelliCode")]
		private TextBox _txt_KarfarmaMelliCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaCodeEghtesadi")]
		private TextBox _txt_KarfarmaCodeEghtesadi;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaCodeFltr")]
		private TextBox _txt_KarfarmaCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaTelFltr")]
		private TextBox _txt_KarfarmaTelFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaAddressFltr")]
		private TextBox _txt_KarfarmaAddressFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_KarfarmaPostiCodeFltr")]
		private TextBox _txt_KarfarmaPostiCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Insert")]
		private Button _btn_Insert;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_copy")]
		private Button _btn_copy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Save")]
		private Button _btn_Save;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Delete")]
		private Button _btn_Delete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Exit")]
		private Button _btn_Exit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Filter")]
		private Button _btn_Filter;

		public string KarfarmaCode_filter;

		public string KarfarmaName_filter;

		public string KarfarmaOstan_filter;

		public string KarfarmaShahr_filter;

		public string KarfarmaEghtesadiCode_filter;

		public string KarfarmaMelliCode_filter;

		public string KarfarmaPostiCode_filter;

		public string KarfarmaAddress_filter;

		public string KarfarmaTel_filter;

		private string ChangeDtgOrPnl;

		public KarfarmaDetailes Karfarma;

		private string BtnCommand;

		private byte DtgKarfarmaRefresh;

		private byte frmKarfarmaRefresh;
        internal System.Windows.Forms.Panel pnl_Karfarma;
        private System.Windows.Forms.Label Label24;
        private System.Windows.Forms.Label Label29;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaShahr;
        private System.Windows.Forms.Label Label30;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaOstan;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Label Label37;
        private System.Windows.Forms.Label Label36;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.TextBox txt_KarfarmaTel;
        private System.Windows.Forms.TextBox txt_KarfarmaAddress;
        private System.Windows.Forms.TextBox txt_KarfarmaCode;
        internal System.Windows.Forms.TextBox txt_KarfarmaName;
        private System.Windows.Forms.DataGridView dtg_Karfarma;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaShahrFltr;
        internal System.Windows.Forms.TextBox txt_KarfarmaNameFltr;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaOstanFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaMelliCodelFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaEghtesadiCodeFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaPostCode;
        private System.Windows.Forms.TextBox txt_KarfarmaMelliCode;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txt_KarfarmaCodeEghtesadi;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txt_KarfarmaCodeFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaTelFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaAddressFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaPostiCodeFltr;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.ToolTip ToolTip1;

        public Frm_Karfarma()
		{
			base.KeyDown += Frm_Karfarma_KeyDown;
			base.Load += Frm_Karfarma_Load;
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_Karfarma));
			this.pnl_Karfarma = new System.Windows.Forms.Panel();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.btn_copy = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.txt_KarfarmaMelliCode = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.txt_KarfarmaCodeEghtesadi = new System.Windows.Forms.TextBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.txt_KarfarmaPostCode = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.Label29 = new System.Windows.Forms.Label();
			this.cmbo_KarfarmaShahr = new System.Windows.Forms.ComboBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.cmbo_KarfarmaOstan = new System.Windows.Forms.ComboBox();
			this.Label38 = new System.Windows.Forms.Label();
			this.Label37 = new System.Windows.Forms.Label();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label35 = new System.Windows.Forms.Label();
			this.txt_KarfarmaTel = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaAddress = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaCode = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaName = new System.Windows.Forms.TextBox();
			this.dtg_Karfarma = new System.Windows.Forms.DataGridView();
			this.pnl_filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.txt_KarfarmaTelFltr = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaAddressFltr = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaPostiCodeFltr = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaCodeFltr = new System.Windows.Forms.TextBox();
			this.cmbo_KarfarmaShahrFltr = new System.Windows.Forms.ComboBox();
			this.txt_KarfarmaNameFltr = new System.Windows.Forms.TextBox();
			this.cmbo_KarfarmaOstanFltr = new System.Windows.Forms.ComboBox();
			this.txt_KarfarmaMelliCodelFltr = new System.Windows.Forms.TextBox();
			this.txt_KarfarmaEghtesadiCodeFltr = new System.Windows.Forms.TextBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.pnl_Karfarma.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Karfarma).BeginInit();
			this.pnl_filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.pnl_Karfarma.BackColor = System.Drawing.Color.Tan;
			this.pnl_Karfarma.Controls.Add(this.btn_Insert);
			this.pnl_Karfarma.Controls.Add(this.btn_copy);
			this.pnl_Karfarma.Controls.Add(this.btn_Save);
			this.pnl_Karfarma.Controls.Add(this.btn_Delete);
			this.pnl_Karfarma.Controls.Add(this.btn_Exit);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaMelliCode);
			this.pnl_Karfarma.Controls.Add(this.Label2);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaCodeEghtesadi);
			this.pnl_Karfarma.Controls.Add(this.Label1);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaPostCode);
			this.pnl_Karfarma.Controls.Add(this.Label24);
			this.pnl_Karfarma.Controls.Add(this.Label29);
			this.pnl_Karfarma.Controls.Add(this.cmbo_KarfarmaShahr);
			this.pnl_Karfarma.Controls.Add(this.Label30);
			this.pnl_Karfarma.Controls.Add(this.cmbo_KarfarmaOstan);
			this.pnl_Karfarma.Controls.Add(this.Label38);
			this.pnl_Karfarma.Controls.Add(this.Label37);
			this.pnl_Karfarma.Controls.Add(this.Label36);
			this.pnl_Karfarma.Controls.Add(this.Label35);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaTel);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaAddress);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaCode);
			this.pnl_Karfarma.Controls.Add(this.txt_KarfarmaName);
			this.pnl_Karfarma.Location = new System.Drawing.Point(5, 489);
			this.pnl_Karfarma.Name = "pnl_Karfarma";
			this.pnl_Karfarma.Size = new System.Drawing.Size(1181, 89);
			this.pnl_Karfarma.TabIndex = 89;
			this.btn_Insert.Location = new System.Drawing.Point(759, 56);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Insert.Size = new System.Drawing.Size(100, 27);
			this.btn_Insert.TabIndex = 101;
			this.btn_Insert.Text = "(Ins) ایجاد ";
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.btn_copy.Location = new System.Drawing.Point(536, 56);
			this.btn_copy.Name = "btn_copy";
			this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_copy.Size = new System.Drawing.Size(100, 27);
			this.btn_copy.TabIndex = 102;
			this.btn_copy.Text = "(Clt+C) کپی";
			this.btn_copy.UseVisualStyleBackColor = true;
			this.btn_Save.Location = new System.Drawing.Point(961, 56);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Save.Size = new System.Drawing.Size(100, 27);
			this.btn_Save.TabIndex = 100;
			this.btn_Save.Text = "(F2) ذخیره";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Delete.Location = new System.Drawing.Point(322, 56);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(100, 27);
			this.btn_Delete.TabIndex = 103;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Exit.Location = new System.Drawing.Point(110, 56);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(100, 27);
			this.btn_Exit.TabIndex = 104;
			this.btn_Exit.Text = " خروج ";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.txt_KarfarmaMelliCode.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaMelliCode.Location = new System.Drawing.Point(440, 21);
			this.txt_KarfarmaMelliCode.Name = "txt_KarfarmaMelliCode";
			this.txt_KarfarmaMelliCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaMelliCode.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaMelliCode.TabIndex = 96;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(438, 5);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(102, 13);
			this.Label2.TabIndex = 109;
			this.Label2.Text = "کد ملی / شماره ثبت ";
			this.txt_KarfarmaCodeEghtesadi.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaCodeEghtesadi.Location = new System.Drawing.Point(541, 21);
			this.txt_KarfarmaCodeEghtesadi.Name = "txt_KarfarmaCodeEghtesadi";
			this.txt_KarfarmaCodeEghtesadi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaCodeEghtesadi.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaCodeEghtesadi.TabIndex = 95;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(563, 5);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(63, 13);
			this.Label1.TabIndex = 107;
			this.Label1.Text = "کد اقتصادی";
			this.txt_KarfarmaPostCode.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaPostCode.Location = new System.Drawing.Point(338, 21);
			this.txt_KarfarmaPostCode.Name = "txt_KarfarmaPostCode";
			this.txt_KarfarmaPostCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaPostCode.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaPostCode.TabIndex = 97;
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(366, 5);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(49, 13);
			this.Label24.TabIndex = 103;
			this.Label24.Text = "کد پستی";
			this.Label29.AutoSize = true;
			this.Label29.Location = new System.Drawing.Point(664, 5);
			this.Label29.Name = "Label29";
			this.Label29.Size = new System.Drawing.Size(54, 13);
			this.Label29.TabIndex = 101;
			this.Label29.Text = " شهرستان";
			this.cmbo_KarfarmaShahr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_KarfarmaShahr.FormattingEnabled = true;
			this.cmbo_KarfarmaShahr.Location = new System.Drawing.Point(642, 21);
			this.cmbo_KarfarmaShahr.Name = "cmbo_KarfarmaShahr";
			this.cmbo_KarfarmaShahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_KarfarmaShahr.Size = new System.Drawing.Size(100, 25);
			this.cmbo_KarfarmaShahr.TabIndex = 94;
			this.Label30.AutoSize = true;
			this.Label30.Location = new System.Drawing.Point(781, 5);
			this.Label30.Name = "Label30";
			this.Label30.Size = new System.Drawing.Size(34, 13);
			this.Label30.TabIndex = 99;
			this.Label30.Text = "استان";
			this.cmbo_KarfarmaOstan.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_KarfarmaOstan.FormattingEnabled = true;
			this.cmbo_KarfarmaOstan.Location = new System.Drawing.Point(743, 21);
			this.cmbo_KarfarmaOstan.Name = "cmbo_KarfarmaOstan";
			this.cmbo_KarfarmaOstan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_KarfarmaOstan.Size = new System.Drawing.Size(100, 25);
			this.cmbo_KarfarmaOstan.TabIndex = 93;
			this.Label38.AutoSize = true;
			this.Label38.Location = new System.Drawing.Point(72, 5);
			this.Label38.Name = "Label38";
			this.Label38.Size = new System.Drawing.Size(32, 13);
			this.Label38.TabIndex = 97;
			this.Label38.Text = " تلفن ";
			this.Label37.AutoSize = true;
			this.Label37.Location = new System.Drawing.Point(209, 5);
			this.Label37.Name = "Label37";
			this.Label37.Size = new System.Drawing.Size(72, 13);
			this.Label37.TabIndex = 96;
			this.Label37.Text = " آدرس کارفرما";
			this.Label36.AutoSize = true;
			this.Label36.Location = new System.Drawing.Point(922, 5);
			this.Label36.Name = "Label36";
			this.Label36.Size = new System.Drawing.Size(62, 13);
			this.Label36.TabIndex = 95;
			this.Label36.Text = " نام کارفرما";
			this.Label35.AutoSize = true;
			this.Label35.Location = new System.Drawing.Point(1062, 5);
			this.Label35.Name = "Label35";
			this.Label35.Size = new System.Drawing.Size(58, 13);
			this.Label35.TabIndex = 94;
			this.Label35.Text = "کد کارفرما";
			this.txt_KarfarmaTel.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaTel.Location = new System.Drawing.Point(47, 21);
			this.txt_KarfarmaTel.Name = "txt_KarfarmaTel";
			this.txt_KarfarmaTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaTel.Size = new System.Drawing.Size(80, 24);
			this.txt_KarfarmaTel.TabIndex = 99;
			this.txt_KarfarmaAddress.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaAddress.Location = new System.Drawing.Point(127, 21);
			this.txt_KarfarmaAddress.Name = "txt_KarfarmaAddress";
			this.txt_KarfarmaAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaAddress.Size = new System.Drawing.Size(210, 24);
			this.txt_KarfarmaAddress.TabIndex = 98;
			this.txt_KarfarmaCode.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaCode.Location = new System.Drawing.Point(1055, 21);
			this.txt_KarfarmaCode.Name = "txt_KarfarmaCode";
			this.txt_KarfarmaCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaCode.Size = new System.Drawing.Size(75, 24);
			this.txt_KarfarmaCode.TabIndex = 91;
			this.txt_KarfarmaName.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaName.Location = new System.Drawing.Point(844, 21);
			this.txt_KarfarmaName.Name = "txt_KarfarmaName";
			this.txt_KarfarmaName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaName.Size = new System.Drawing.Size(210, 24);
			this.txt_KarfarmaName.TabIndex = 92;
			this.dtg_Karfarma.AllowUserToAddRows = false;
			this.dtg_Karfarma.AllowUserToDeleteRows = false;
			this.dtg_Karfarma.AllowUserToOrderColumns = true;
			this.dtg_Karfarma.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Karfarma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Karfarma.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Karfarma.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Karfarma.Location = new System.Drawing.Point(5, 24);
			this.dtg_Karfarma.Name = "dtg_Karfarma";
			this.dtg_Karfarma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Karfarma.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dtg_Karfarma.RowTemplate.Height = 44;
			this.dtg_Karfarma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Karfarma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Karfarma.Size = new System.Drawing.Size(1180, 463);
			this.dtg_Karfarma.TabIndex = 91;
			this.pnl_filter.Controls.Add(this.btn_Filter);
			this.pnl_filter.Controls.Add(this.Label10);
			this.pnl_filter.Controls.Add(this.PictureBox1);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaTelFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaAddressFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaPostiCodeFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaCodeFltr);
			this.pnl_filter.Controls.Add(this.cmbo_KarfarmaShahrFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaNameFltr);
			this.pnl_filter.Controls.Add(this.cmbo_KarfarmaOstanFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaMelliCodelFltr);
			this.pnl_filter.Controls.Add(this.txt_KarfarmaEghtesadiCodeFltr);
			this.pnl_filter.Location = new System.Drawing.Point(5, 1);
			this.pnl_filter.Name = "pnl_filter";
			this.pnl_filter.Size = new System.Drawing.Size(1181, 48);
			this.pnl_filter.TabIndex = 92;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(1139, 1);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(40, 42);
			this.btn_Filter.TabIndex = 93;
			this.ToolTip1.SetToolTip(this.btn_Filter, "فیلتر");
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1090, 3);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(49, 43);
			this.Label10.TabIndex = 154;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(18, 1);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1161, 22);
			this.PictureBox1.TabIndex = 155;
			this.PictureBox1.TabStop = false;
			this.txt_KarfarmaTelFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaTelFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaTelFltr.Location = new System.Drawing.Point(18, 23);
			this.txt_KarfarmaTelFltr.Name = "txt_KarfarmaTelFltr";
			this.txt_KarfarmaTelFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaTelFltr.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaTelFltr.TabIndex = 86;
			this.txt_KarfarmaAddressFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaAddressFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaAddressFltr.Location = new System.Drawing.Point(118, 23);
			this.txt_KarfarmaAddressFltr.Name = "txt_KarfarmaAddressFltr";
			this.txt_KarfarmaAddressFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaAddressFltr.Size = new System.Drawing.Size(210, 24);
			this.txt_KarfarmaAddressFltr.TabIndex = 85;
			this.txt_KarfarmaPostiCodeFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaPostiCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaPostiCodeFltr.Location = new System.Drawing.Point(328, 23);
			this.txt_KarfarmaPostiCodeFltr.Name = "txt_KarfarmaPostiCodeFltr";
			this.txt_KarfarmaPostiCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaPostiCodeFltr.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaPostiCodeFltr.TabIndex = 84;
			this.txt_KarfarmaCodeFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaCodeFltr.Location = new System.Drawing.Point(1038, 23);
			this.txt_KarfarmaCodeFltr.Name = "txt_KarfarmaCodeFltr";
			this.txt_KarfarmaCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaCodeFltr.Size = new System.Drawing.Size(52, 24);
			this.txt_KarfarmaCodeFltr.TabIndex = 78;
			this.cmbo_KarfarmaShahrFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_KarfarmaShahrFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_KarfarmaShahrFltr.FormattingEnabled = true;
			this.cmbo_KarfarmaShahrFltr.Location = new System.Drawing.Point(628, 23);
			this.cmbo_KarfarmaShahrFltr.Name = "cmbo_KarfarmaShahrFltr";
			this.cmbo_KarfarmaShahrFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_KarfarmaShahrFltr.Size = new System.Drawing.Size(100, 25);
			this.cmbo_KarfarmaShahrFltr.TabIndex = 81;
			this.txt_KarfarmaNameFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaNameFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaNameFltr.Location = new System.Drawing.Point(828, 23);
			this.txt_KarfarmaNameFltr.Name = "txt_KarfarmaNameFltr";
			this.txt_KarfarmaNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaNameFltr.Size = new System.Drawing.Size(210, 24);
			this.txt_KarfarmaNameFltr.TabIndex = 79;
			this.cmbo_KarfarmaOstanFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_KarfarmaOstanFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_KarfarmaOstanFltr.FormattingEnabled = true;
			this.cmbo_KarfarmaOstanFltr.Location = new System.Drawing.Point(728, 23);
			this.cmbo_KarfarmaOstanFltr.Name = "cmbo_KarfarmaOstanFltr";
			this.cmbo_KarfarmaOstanFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_KarfarmaOstanFltr.Size = new System.Drawing.Size(100, 25);
			this.cmbo_KarfarmaOstanFltr.TabIndex = 80;
			this.txt_KarfarmaMelliCodelFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaMelliCodelFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaMelliCodelFltr.Location = new System.Drawing.Point(428, 23);
			this.txt_KarfarmaMelliCodelFltr.Name = "txt_KarfarmaMelliCodelFltr";
			this.txt_KarfarmaMelliCodelFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaMelliCodelFltr.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaMelliCodelFltr.TabIndex = 83;
			this.txt_KarfarmaEghtesadiCodeFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_KarfarmaEghtesadiCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_KarfarmaEghtesadiCodeFltr.Location = new System.Drawing.Point(528, 23);
			this.txt_KarfarmaEghtesadiCodeFltr.Name = "txt_KarfarmaEghtesadiCodeFltr";
			this.txt_KarfarmaEghtesadiCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_KarfarmaEghtesadiCodeFltr.Size = new System.Drawing.Size(100, 24);
			this.txt_KarfarmaEghtesadiCodeFltr.TabIndex = 82;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.Tan;
			base.ClientSize = new System.Drawing.Size(1190, 581);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_filter);
			base.Controls.Add(this.pnl_Karfarma);
			base.Controls.Add(this.dtg_Karfarma);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Location = new System.Drawing.Point(12, 114);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Frm_Karfarma";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "لیست کارفرماها";
			this.pnl_Karfarma.ResumeLayout(false);
			this.pnl_Karfarma.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Karfarma).EndInit();
			this.pnl_filter.ResumeLayout(false);
			this.pnl_filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
            this.cmbo_KarfarmaShahr.GotFocus += new System.EventHandler(this.cmbo_KarfarmaShahr_GotFocus);
            this.cmbo_KarfarmaShahr.TextChanged += new System.EventHandler(this.cmbo_KarfarmaShahr_TextChanged);
            this.cmbo_KarfarmaOstan.GotFocus += new System.EventHandler(this.cmbo_KarfarmaOstan_GotFocus);
            this.cmbo_KarfarmaOstan.TextChanged += new System.EventHandler(this.cmbo_KarfarmaOstan_TextChanged);
            this.cmbo_KarfarmaOstan.SelectedIndexChanged += new System.EventHandler(this.cmbo_KarfarmaOstan_SelectedIndexChanged);
            this.txt_KarfarmaTel.GotFocus += new System.EventHandler(this.txt_KarfarmaTel_GotFocus);
            this.txt_KarfarmaTel.TextChanged += new System.EventHandler(this.txt_KarfarmaTel_TextChanged);
            this.txt_KarfarmaAddress.GotFocus += new System.EventHandler(this.txt_KarfarmaAddress_GotFocus);
            this.txt_KarfarmaAddress.TextChanged += new System.EventHandler(this.txt_KarfarmaAddress_TextChanged);
            this.txt_KarfarmaCode.GotFocus += new System.EventHandler(this.txt_KarfarmaCode_GotFocus);
            this.txt_KarfarmaCode.TextChanged += new System.EventHandler(this.txt_KarfarmaCode_TextChanged);
            this.txt_KarfarmaName.GotFocus += new System.EventHandler(this.txt_Karfarma_GotFocus);
            this.txt_KarfarmaName.TextChanged += new System.EventHandler(this.txt_Karfarma_TextChanged);
            this.dtg_Karfarma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellClick);
            this.dtg_Karfarma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellContentClick);
            this.dtg_Karfarma.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellContentDoubleClick);
            this.dtg_Karfarma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellDoubleClick);
            this.dtg_Karfarma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Karfarma_KeyDown);
            this.dtg_Karfarma.SelectionChanged += new System.EventHandler(this.dtg_Karfarma_SelectionChanged);
            this.cmbo_KarfarmaShahrFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_KarfarmaShahrFltr_SelectedIndexChanged);
            this.cmbo_KarfarmaShahrFltr.TextChanged += new System.EventHandler(this.cmbo_KarfarmashahrFltr_TextChanged);
            this.txt_KarfarmaNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaNameFltr_KeyDown);
            this.cmbo_KarfarmaOstanFltr.TextChanged += new System.EventHandler(this.cmbo_KarfarmaOstanFltr_TextChanged);
            this.txt_KarfarmaMelliCodelFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaMelliCodelFltr_KeyDown);
            this.txt_KarfarmaEghtesadiCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaEghtesadiCodeFltr_KeyDown);
            this.txt_KarfarmaPostCode.GotFocus += new System.EventHandler(this.txt_KarfarmaPostCode_GotFocus);
            this.txt_KarfarmaPostCode.TextChanged += new System.EventHandler(this.txt_KarfarmaPostCode_TextChanged);
            this.txt_KarfarmaMelliCode.GotFocus += new System.EventHandler(this.txt_KarfarmaMelliCode_GotFocus);
            this.txt_KarfarmaMelliCode.TextChanged += new System.EventHandler(this.txt_KarfarmaMelliCode_TextChanged);
            this.txt_KarfarmaCodeEghtesadi.GotFocus += new System.EventHandler(this.txt_KarfarmaCodeEghtesadi_GotFocus);
            this.txt_KarfarmaCodeEghtesadi.TextChanged += new System.EventHandler(this.txt_KarfarmaCodeEghtesadi_TextChanged);
            this.txt_KarfarmaCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaCodeFltr_KeyDown);
            this.txt_KarfarmaTelFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaTelFltr_KeyDown);
            this.txt_KarfarmaAddressFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaAddressFltr_KeyDown);
            this.txt_KarfarmaPostiCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaPostiCodeFltr_KeyDown);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
        }

		private void cmbo_KarfarmaOstan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void btn_Return_Click(object sender, EventArgs e)
		{
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Module1.BtnKarfarmaList = false;
			Close();
		}

		public void ShowKarfarmaRecord()
		{
			int num = 0;
			ref KarfarmaDetailes karfarma = ref Karfarma;
			int lErl = default(int);
			if (dtg_Karfarma.RowCount != 0)
			{
				try
				{
					num = dtg_Karfarma.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				karfarma.Id = Conversions.ToInteger(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[0].Value);
				karfarma.KarfarmaCode = Conversions.ToInteger(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[2].Value);
				karfarma.KarfarmaName = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[3].Value.ToString();
				karfarma.Ostan = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[4].Value.ToString();
				karfarma.Shahr = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[5].Value.ToString();
				karfarma.KarfarmaEghtesadiCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[6].Value.ToString();
				karfarma.KarfarmaMelliCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[7].Value.ToString();
				karfarma.KarfarmaPostCode = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[8].Value.ToString();
				karfarma.KarfarmaAddress = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[9].Value.ToString();
				karfarma.KarfarmaTel = dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[10].Value.ToString();
				txt_KarfarmaCode.Text = Conversions.ToString(karfarma.KarfarmaCode);
				txt_KarfarmaName.Text = karfarma.KarfarmaName;
				cmbo_KarfarmaOstan.Text = karfarma.Ostan;
				cmbo_KarfarmaShahr.Text = karfarma.Shahr;
				txt_KarfarmaCodeEghtesadi.Text = karfarma.KarfarmaEghtesadiCode;
				txt_KarfarmaMelliCode.Text = karfarma.KarfarmaMelliCode;
				txt_KarfarmaPostCode.Text = karfarma.KarfarmaPostCode;
				txt_KarfarmaAddress.Text = karfarma.KarfarmaAddress;
				txt_KarfarmaTel.Text = karfarma.KarfarmaTel;
			}
			lErl = 60;
		}

		private void dtg_Karfarma_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowKarfarmaRecord();
		}

		private void dtg_Karfarma_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowKarfarmaRecord();
		}

		private void dtg_Karfarma_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (0 - (Module1.BtnKarfarmaList ? 1 : 0) == 1)
			{
				Frm_AsnadList frm_AsnadList = MyProject.Forms.Frm_AsnadList;
				frm_AsnadList.txt_Karfarma.Text = Conversions.ToString(dtg_Karfarma.Rows[dtg_Karfarma.CurrentRow.Index].Cells[2].Value);
				frm_AsnadList = null;
			}
		}

		private void dtg_Karfarma_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click_1(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dtg_Karfarma_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				txt_KarfarmaCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Karfarma_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Karfarma.BackColor == Color.LightPink) & (frmKarfarmaRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات کارفرما ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_KarfarmaBlue();
					break;
				case DialogResult.No:
					SetPnl_KarfarmaBlue();
					break;
				case DialogResult.Cancel:
					txt_KarfarmaCode.Focus();
					return;
				}
			}
			if (DtgKarfarmaRefresh == 1)
			{
				ShowKarfarmaRecord();
			}
		}

		public void Load_dtg_Karfarma()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[9];
			DtgKarfarmaRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 8);
				if (Operators.CompareString(KarfarmaCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaOstan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaShahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaEghtesadiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaMelliCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaPostiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
				}
				if (Operators.CompareString(KarfarmaAddress_filter, "", TextCompare: false) != 0 && Operators.CompareString(KarfarmaTel_filter, "", TextCompare: false) != 0)
				{
					array[8] = " And ";
				}
				Module1.strWhere = " WHERE " + KarfarmaCode_filter + array[1] + KarfarmaName_filter + array[2] + KarfarmaOstan_filter + array[3] + KarfarmaShahr_filter + array[4] + KarfarmaEghtesadiCode_filter + array[5] + KarfarmaMelliCode_filter + array[6] + KarfarmaPostiCode_filter + array[4] + KarfarmaAddress_filter + array[5] + KarfarmaTel_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = "";
				}
				if (base.Visible)
				{
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [indentradif] As 'Id',[radif] As 'ردیف',[kknum] As 'کد ', [kname] As 'نام کارفرما', [Oname] As 'استان', [ShahrName] As 'شهر' , [ShomareEghtesadi] As 'کد اقتصادی', [ShomareSabtYaMelli] As 'کد ملی', [KodPosti] As 'کد پستی',[adres] As 'آدرس کارفرما', [tel] As 'تلفن ' FROM [dbo].[etkarfar] " + Module1.strWhere + " Order By [kknum] Asc";
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
					dtg_Karfarma.DataSource = dataTable;
					dtg_Karfarma.Columns[0].Width = 75;
					dtg_Karfarma.Columns[0].Visible = false;
					dtg_Karfarma.Columns[1].Width = 50;
					dtg_Karfarma.Columns[2].Width = 50;
					dtg_Karfarma.Columns[3].Width = 210;
					dtg_Karfarma.Columns[4].Width = 100;
					dtg_Karfarma.Columns[5].Width = 100;
					dtg_Karfarma.Columns[6].Width = 100;
					dtg_Karfarma.Columns[7].Width = 100;
					dtg_Karfarma.Columns[8].Width = 100;
					dtg_Karfarma.Columns[9].Width = 210;
					dtg_Karfarma.Columns[10].Width = 100;
					base.Visible = true;
				}
				DtgKarfarmaRefresh = 1;
			}
		}

		private void Frm_Karfarma_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_Karfarma_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmKarfarmaRefresh = 0;
			Load_Cmbo_FrmKarfarma(cmbo_KarfarmaOstanFltr, "etkarfar", "Oname", "");
			Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
			Module1.Load_Cmbo(cmbo_KarfarmaOstan, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_KarfarmaShahr, "ZarayebMantaghe", "Shahr", "");
			Load_dtg_Karfarma();
			dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[0].Cells[1];
			ShowKarfarmaRecord();
			frmKarfarmaRefresh = 1;
			foreach (Control control in pnl_Karfarma.Controls)
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
			foreach (Control control in pnl_Karfarma.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		private void btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			if (!(pnl_Karfarma.BackColor == Color.Tan))
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
				{
					Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + txt_KarfarmaCode.Text + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[etkarfar] ([radif],[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah]) VALUES('0','" + txt_KarfarmaCode.Text + "','" + txt_KarfarmaName.Text + "','" + txt_KarfarmaAddress.Text + "','" + txt_KarfarmaTel.Text + "','" + txt_KarfarmaCodeEghtesadi.Text + "','" + txt_KarfarmaMelliCode.Text + "','" + Module1.FindCodeOrName(cmbo_KarfarmaOstan.Text, "[Ostan]", "[OstanCode]", "[ZarayebMantaghe]") + "','" + cmbo_KarfarmaOstan.Text + "','" + Module1.FindCodeOrName(cmbo_KarfarmaShahr.Text, "[Shahr]", "[ShahrCode]", "[ZarayebMantaghe]") + "','" + cmbo_KarfarmaShahr.Text + "','" + txt_KarfarmaPostCode.Text + "','" + Environment.MachineName + "','','','')";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_KarfarmaBlue();
						goto IL_04af;
					}
					MessageBox.Show("کد کارفرما " + txt_KarfarmaCode.Text + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_KarfarmaCode.Text = "";
					txt_KarfarmaName.Focus();
					sqlDataReader.Close();
				}
				else
				{
					Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + txt_KarfarmaCode.Text + "' And [indentradif] <> '" + Conversions.ToString(Karfarma.Id) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo].[etkarfar] SET [radif] ='0',[kknum] = '" + txt_KarfarmaCode.Text + "',[kname] = '" + txt_KarfarmaName.Text + "',[adres] = '" + txt_KarfarmaAddress.Text + "',[tel] = '" + txt_KarfarmaTel.Text + "',[ShomareEghtesadi] = '" + txt_KarfarmaCodeEghtesadi.Text + "',[ShomareSabtYaMelli] = '" + txt_KarfarmaMelliCode.Text + "',[okod] = '" + Module1.FindCodeOrName(cmbo_KarfarmaOstan.Text, "[Ostan]", "[OstanCode]", "[ZarayebMantaghe]") + "',[Oname] = '" + cmbo_KarfarmaOstan.Text + "',[ShahrKod] = '" + Module1.FindCodeOrName(cmbo_KarfarmaShahr.Text, "[Shahr]", "[ShahrCode]", "[ZarayebMantaghe]") + "',[ShahrName] = '" + cmbo_KarfarmaShahr.Text + "',[KodPosti] = '" + txt_KarfarmaPostCode.Text + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = ''WHERE [indentradif] = '" + Conversions.ToString(Karfarma.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						goto IL_04af;
					}
					MessageBox.Show("کد کارفرما " + txt_KarfarmaCode.Text + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_KarfarmaCode.Text = "";
					txt_KarfarmaCode.Focus();
				}
			}
			goto IL_0551;
			IL_04af:
			SetPnl_KarfarmaBlue();
			text = txt_KarfarmaCode.Text;
			Frm_Karfarma_Load(RuntimeHelpers.GetObjectValue(sender), e);
			checked
			{
				int num = dtg_Karfarma.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectEqual(dtg_Karfarma.Rows[i].Cells[2].Value, text, TextCompare: false))
					{
						dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[i].Cells[1];
						ShowKarfarmaRecord();
					}
				}
				goto IL_0551;
			}
			IL_0551:
			BtnCommand = "";
		}

		private void SetPnl_KarfarmaBlue()
		{
			pnl_Karfarma.BackColor = Color.Tan;
			foreach (object control in pnl_Karfarma.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Karfarma.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		public void btn_Insert_Click(object sender, EventArgs e)
		{
			frm_Karfarma_btn_insert();
		}

		private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_KarfarmaCode.Text;
			string defaultResponse = "";
			BtnCommand = "Copy";
			if (pnl_Karfarma.BackColor == Color.LightPink)
			{
				dtg_Karfarma_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [kknum] FROM [dbo].[etkarfar] Order By [kknum] Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				while (sqlDataReader.Read())
				{
					defaultResponse = Conversions.ToString(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1);
				}
				sqlDataReader.Close();
				string text2 = Interaction.InputBox(" کپی کارفرما " + Conversions.ToString(Karfarma.KarfarmaCode) + " تحت عنوان کد کارفرمای ذیل انجام شود؟ ", " ", defaultResponse);
				if (Operators.CompareString(text2, "", TextCompare: false) == 0)
				{
					return;
				}
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [kknum] FROM [dbo].[etkarfar] Where [kknum]='" + text2 + "'";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show("کارفرما با کد " + text2 + " موجود است کد کارفرمای جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				sqlDataReader.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[etkarfar] ([radif],[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah])(SELECT [radif],'" + text2 + "'[kknum],[kname],[adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[okod],[Oname],[ShahrKod],[ShahrName],[KodPosti],'" + Environment.MachineName + "',[EslahSystem],'',[TimeEslah] FROM [dbo].[etkarfar] Where [kknum]='" + text + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Karfarma();
				int num = dtg_Karfarma.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Karfarma.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[i].Cells[1];
						ShowKarfarmaRecord();
						break;
					}
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			string text = txt_KarfarmaCode.Text;
			int index = dtg_Karfarma.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Karfarma.RowCount - 1 != 0)
				{
					int index2 = dtg_Karfarma.CurrentRow.Index;
					if (MessageBox.Show("کارفرما با کد   " + txt_KarfarmaCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE karkod1 = '" + text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مربط به کد کارفرمای   " + txt_KarfarmaCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE [karkod1] = '" + text + "'";
						sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مربوط به کد کارفرمای   " + txt_KarfarmaCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.Connection = Module1.MyConn;
						Module1.cmd.CommandText = "DELETE FROM [dbo].[etkarfar] WHERE kknum = '" + text + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_Karfarma();
				if (index != 0)
				{
					dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Karfarma.CurrentCell = dtg_Karfarma.Rows[index].Cells[1];
				}
				ShowKarfarmaRecord();
			}
		}

		private void btn_Exit_Click_1(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Karfarma_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.txt_Karfarma.Focus();
				MyProject.Forms.Frm_AsnadList.txt_Karfarma.Text = txt_KarfarmaName.Text;
				Module1.FromAsnadList = 0;
			}
			Close();
		}

		private void txt_KarfarmaCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_Karfarma_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_KarfarmaShahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_KarfarmaCodeEghtesadi_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_KarfarmaMelliCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_KarfarmaPostCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_KarfarmaAddress_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_KarfarmaTel_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_Karfarma_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaName.Text.Trim(), Karfarma.KarfarmaName.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaName.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaName.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void CheckKarfarmaChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Karfarma.BackColor = Color.Tan;
			foreach (object control in pnl_Karfarma.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Karfarma.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Karfarma.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Karfarma.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void txt_KarfarmaCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaCode.Text, Conversions.ToString(Karfarma.KarfarmaCode), TextCompare: false) != 0)
				{
					txt_KarfarmaCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void cmbo_KarfarmaOstan_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmKarfarmaRefresh != 0)
			{
				string left = cmbo_KarfarmaOstan.Text.Trim();
				try
				{
					if (Operators.CompareString(left, "", TextCompare: false) != 0)
					{
						Module1.Load_Cmbo(cmbo_KarfarmaShahr, "ZarayebMantaghe", "Shahr", "Where REPLACE(REPLACE(Ostan,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(cmbo_KarfarmaOstan.Text.Trim()) + "%'");
					}
					if ((Operators.CompareString(left, Karfarma.Ostan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_KarfarmaShahr.Text.Trim(), Karfarma.Shahr.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_KarfarmaOstan.ForeColor = Color.Red;
						cmbo_KarfarmaShahr.ForeColor = Color.Red;
					}
					else
					{
						cmbo_KarfarmaOstan.ForeColor = Color.Black;
						cmbo_KarfarmaShahr.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckKarfarmaChange();
			}
			lErl = 20;
			cmbo_KarfarmaShahr.Text = "";
		}

		private void cmbo_KarfarmaShahr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmKarfarmaRefresh != 0)
			{
				try
				{
					if ((Operators.CompareString(cmbo_KarfarmaOstan.Text.Trim(), Karfarma.Ostan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_KarfarmaShahr.Text.Trim(), Karfarma.Shahr.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_KarfarmaShahr.ForeColor = Color.Red;
					}
					else
					{
						cmbo_KarfarmaOstan.ForeColor = Color.Black;
						cmbo_KarfarmaShahr.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckKarfarmaChange();
			}
			lErl = 20;
		}

		private void txt_KarfarmaAddress_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaAddress.Text.Trim(), Karfarma.KarfarmaAddress.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaAddress.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaAddress.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void txt_KarfarmaCodeEghtesadi_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaCodeEghtesadi.Text.Trim(), Karfarma.KarfarmaEghtesadiCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaCodeEghtesadi.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaCodeEghtesadi.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void txt_KarfarmaMelliCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaMelliCode.Text.Trim(), Karfarma.KarfarmaMelliCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaMelliCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaMelliCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void txt_KarfarmaPostCode_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaPostCode.Text.Trim(), Karfarma.KarfarmaPostCode.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaPostCode.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaPostCode.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void txt_KarfarmaTel_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				if (Operators.CompareString(txt_KarfarmaTel.Text.Trim(), Karfarma.KarfarmaTel.Trim(), TextCompare: false) != 0)
				{
					txt_KarfarmaTel.ForeColor = Color.Red;
				}
				else
				{
					txt_KarfarmaTel.ForeColor = Color.Black;
				}
				CheckKarfarmaChange();
			}
		}

		private void cmbo_KarfarmaShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void PictureBox1_Click(object sender, EventArgs e)
		{
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_filter.Visible)
			{
				pnl_filter.Visible = true;
				return;
			}
			pnl_filter.Visible = false;
			txt_KarfarmaCodeFltr.Text = "";
			txt_KarfarmaNameFltr.Text = "";
			cmbo_KarfarmaOstanFltr.Text = "";
			cmbo_KarfarmaOstanFltr.Text = "";
			cmbo_KarfarmaShahrFltr.Text = "";
			txt_KarfarmaEghtesadiCodeFltr.Text = "";
			txt_KarfarmaMelliCodelFltr.Text = "";
			txt_KarfarmaPostiCodeFltr.Text = "";
			txt_KarfarmaAddressFltr.Text = "";
			txt_KarfarmaTelFltr.Text = "";
			Frm_Karfarma_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void txt_KarfarmaCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaCodeFltr.Text;
					KarfarmaCode_filter = " ([kknum] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaNameFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_KarfarmaNameFltr.Text;
					KarfarmaName_filter = " (REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					KarfarmaName_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaAddressFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaAddressFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_KarfarmaAddressFltr.Text;
					KarfarmaAddress_filter = " (REPLACE(REPLACE([adres],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					KarfarmaAddress_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void cmbo_KarfarmaOstanFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				string text = cmbo_KarfarmaOstanFltr.Text;
				switch (text)
				{
				case "Null":
					KarfarmaOstan_filter = " ([Oname] is Null)";
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
					break;
				case null:
				case "":
					KarfarmaOstan_filter = "";
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "");
					break;
				default:
					Load_Cmbo_FrmKarfarma(cmbo_KarfarmaShahrFltr, "etkarfar", "ShahrName", "Where REPLACE(REPLACE(Oname,'ي',N'ی'),'ك',N'ک') Like N'" + Module1.ArbToPer(text) + "'");
					KarfarmaOstan_filter = " (REPLACE(REPLACE(Oname,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void cmbo_KarfarmashahrFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmKarfarmaRefresh != 0)
			{
				string text = cmbo_KarfarmaShahrFltr.Text;
				switch (text)
				{
				case "Null":
					KarfarmaShahr_filter = " ([ShahrName] is Null)";
					break;
				case null:
				case "":
					KarfarmaShahr_filter = "";
					break;
				default:
					KarfarmaShahr_filter = " (REPLACE(REPLACE(ShahrName,'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaEghtesadiCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaEghtesadiCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaEghtesadiCodeFltr.Text;
					KarfarmaEghtesadiCode_filter = " ([ShomareEghtesadi] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaEghtesadiCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaMelliCodelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaMelliCodelFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaMelliCodelFltr.Text;
					KarfarmaMelliCode_filter = " ([ShomareSabtYaMelli] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaMelliCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaPostiCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaPostiCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaPostiCodeFltr.Text;
					KarfarmaPostiCode_filter = " ([KodPosti] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaPostiCode_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void txt_KarfarmaTelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaTelFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_KarfarmaTelFltr.Text;
					KarfarmaTel_filter = " ([tel] Like N'%" + text + "%')";
				}
				else
				{
					KarfarmaTel_filter = "";
				}
				Load_dtg_Karfarma();
				ShowKarfarmaRecord();
			}
		}

		private void Load_Cmbo_FrmKarfarma(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT REPLACE(REPLACE(" + strField + ",'ي',N'ی'),'ك',N'ک') As " + Module1.ArbToPer(strField) + " FROM [dbo]." + strTable + " " + strWhere + " Group By " + strField + " Order By " + strField;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
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

		public void frm_Karfarma_btn_insert()
		{
			BtnCommand = "Insert";
			if (pnl_Karfarma.BackColor == Color.LightPink)
			{
				frm_Karfarma_btn_insert();
			}
			pnl_Karfarma.BackColor = Color.LightPink;
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [kknum] FROM [dbo].[etkarfar] order by Cast([kknum] As bigint) Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				txt_KarfarmaCode.Text = Conversions.ToString(checked(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1));
			}
			sqlDataReader.Close();
			txt_KarfarmaName.Text = "";
			cmbo_KarfarmaOstan.Text = "";
			cmbo_KarfarmaShahr.Text = "";
			txt_KarfarmaCodeEghtesadi.Text = "";
			txt_KarfarmaMelliCode.Text = "";
			txt_KarfarmaPostCode.Text = "";
			txt_KarfarmaAddress.Text = "";
			txt_KarfarmaTel.Text = "";
		}

		private void cmbo_KarfarmaOstan_SelectedIndexChanged(object sender, EventArgs e)
		{
		}
	}
}
