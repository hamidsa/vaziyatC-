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
	public class Frm_Project : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_Project")]
		private DataGridView _dtg_Project;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ProjectShahrFltr")]
		private ComboBox _cmbo_ProjectShahrFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ProjectBakhshFltr")]
		private ComboBox _cmbo_ProjectBakhshFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectNameFltr")]
		private TextBox _txt_ProjectNameFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ProjectOstanFltr")]
		private ComboBox _cmbo_ProjectOstanFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectTelFltr")]
		private TextBox _txt_ProjectTelFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectAddressFltr")]
		private TextBox _txt_ProjectAddressFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectCodeFltr")]
		private TextBox _txt_ProjectCodeFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Exit")]
		private Button _btn_Exit;

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
		[AccessedThroughProperty("cmbo_ProjectBakhsh")]
		private ComboBox _cmbo_ProjectBakhsh;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ProjectShahr")]
		private ComboBox _cmbo_ProjectShahr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_ProjectOstan")]
		private ComboBox _cmbo_ProjectOstan;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Save")]
		private Button _Btn_Save;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectTel")]
		private TextBox _txt_ProjectTel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectAddress")]
		private TextBox _txt_ProjectAddress;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectCode")]
		private TextBox _txt_ProjectCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ProjectName")]
		private TextBox _txt_ProjectName;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Filter")]
		private Button _btn_Filter;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_FehrestNameFltr")]
		private ComboBox _cmbo_FehrestNameFltr;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("cmbo_FehrestName")]
		private ComboBox _cmbo_FehrestName;

		public string ProjectCode_filter;

		public string ProjectAddress_filter;

		public string ProjectTel_filter;

		public string ProjectOstan_filter;

		public string ProjectShahr_filter;

		public string ProjectBakhsh_filter;

		public string ProjectFehrestFile_filter;

		private string BtnCommand;

		public ProjectDetailes Project;

		private byte DtgProjectRefresh;

		private byte frmProjectRefresh;

		private string ChangeDtgOrPnl;
        private System.Windows.Forms.DataGridView dtg_Project;
        private System.Windows.Forms.Panel pnl_Filter;
        internal System.Windows.Forms.ComboBox cmbo_ProjectShahrFltr;
        internal System.Windows.Forms.ComboBox cmbo_ProjectBakhshFltr;
        internal System.Windows.Forms.TextBox txt_ProjectNameFltr;
        internal System.Windows.Forms.ComboBox cmbo_ProjectOstanFltr;
        private System.Windows.Forms.TextBox txt_ProjectTelFltr;
        private System.Windows.Forms.TextBox txt_ProjectAddressFltr;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.TextBox txt_ProjectCodeFltr;
        internal System.Windows.Forms.Panel pnl_Project;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_Insert;
        internal System.Windows.Forms.ComboBox cmbo_ProjectBakhsh;
        internal System.Windows.Forms.ComboBox cmbo_ProjectShahr;
        internal System.Windows.Forms.ComboBox cmbo_ProjectOstan;
        private System.Windows.Forms.Label Label42;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Label Label37;
        private System.Windows.Forms.Label Label36;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.TextBox txt_ProjectTel;
        internal System.Windows.Forms.TextBox txt_ProjectAddress;
        internal System.Windows.Forms.TextBox txt_ProjectCode;
        internal System.Windows.Forms.TextBox txt_ProjectName;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbo_FehrestNameFltr;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox cmbo_FehrestName;
        private System.Windows.Forms.Label lbl_SanadZaribComment2;
        private System.Windows.Forms.Label lbl_SanadZaribComment1;
        private System.Windows.Forms.Label lbl_SanadZarib2;
        private System.Windows.Forms.Label lbl_SanadZarib1;
        private System.Windows.Forms.Label Label39;

        public Frm_Project()
		{
			base.KeyDown += Frm_Project_KeyDown;
			base.Load += Frm_Project_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_Project));
			this.dtg_Project = new System.Windows.Forms.DataGridView();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_FehrestNameFltr = new System.Windows.Forms.ComboBox();
			this.txt_ProjectCodeFltr = new System.Windows.Forms.TextBox();
			this.cmbo_ProjectShahrFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ProjectBakhshFltr = new System.Windows.Forms.ComboBox();
			this.txt_ProjectNameFltr = new System.Windows.Forms.TextBox();
			this.cmbo_ProjectOstanFltr = new System.Windows.Forms.ComboBox();
			this.txt_ProjectTelFltr = new System.Windows.Forms.TextBox();
			this.txt_ProjectAddressFltr = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.pnl_Project = new System.Windows.Forms.Panel();
			this.lbl_SanadZaribComment2 = new System.Windows.Forms.Label();
			this.lbl_SanadZaribComment1 = new System.Windows.Forms.Label();
			this.lbl_SanadZarib2 = new System.Windows.Forms.Label();
			this.lbl_SanadZarib1 = new System.Windows.Forms.Label();
			this.Label39 = new System.Windows.Forms.Label();
			this.cmbo_FehrestName = new System.Windows.Forms.ComboBox();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_copy = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.cmbo_ProjectBakhsh = new System.Windows.Forms.ComboBox();
			this.cmbo_ProjectShahr = new System.Windows.Forms.ComboBox();
			this.cmbo_ProjectOstan = new System.Windows.Forms.ComboBox();
			this.Label42 = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Label41 = new System.Windows.Forms.Label();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label35 = new System.Windows.Forms.Label();
			this.Label40 = new System.Windows.Forms.Label();
			this.txt_ProjectTel = new System.Windows.Forms.TextBox();
			this.txt_ProjectAddress = new System.Windows.Forms.TextBox();
			this.txt_ProjectCode = new System.Windows.Forms.TextBox();
			this.txt_ProjectName = new System.Windows.Forms.TextBox();
			this.Label38 = new System.Windows.Forms.Label();
			this.Label37 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)this.dtg_Project).BeginInit();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.pnl_Project.SuspendLayout();
			base.SuspendLayout();
			this.dtg_Project.AllowUserToAddRows = false;
			this.dtg_Project.AllowUserToDeleteRows = false;
			this.dtg_Project.AllowUserToOrderColumns = true;
			this.dtg_Project.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Project.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_Project.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Project.Location = new System.Drawing.Point(5, 24);
			this.dtg_Project.Name = "dtg_Project";
			this.dtg_Project.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Project.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.dtg_Project.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Project.RowTemplate.Height = 44;
			this.dtg_Project.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Project.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Project.Size = new System.Drawing.Size(1180, 520);
			this.dtg_Project.TabIndex = 87;
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.cmbo_FehrestNameFltr);
			this.pnl_Filter.Controls.Add(this.txt_ProjectCodeFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ProjectShahrFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ProjectBakhshFltr);
			this.pnl_Filter.Controls.Add(this.txt_ProjectNameFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ProjectOstanFltr);
			this.pnl_Filter.Controls.Add(this.txt_ProjectTelFltr);
			this.pnl_Filter.Controls.Add(this.txt_ProjectAddressFltr);
			this.pnl_Filter.Controls.Add(this.Button7);
			this.pnl_Filter.Location = new System.Drawing.Point(5, 11);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1168, 48);
			this.pnl_Filter.TabIndex = 88;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Location = new System.Drawing.Point(1126, 0);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(40, 47);
			this.btn_Filter.TabIndex = 94;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1065, 0);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(61, 46);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(3, -7);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1162, 31);
			this.PictureBox1.TabIndex = 156;
			this.PictureBox1.TabStop = false;
			this.cmbo_FehrestNameFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_FehrestNameFltr.FormattingEnabled = true;
			this.cmbo_FehrestNameFltr.Location = new System.Drawing.Point(4, 25);
			this.cmbo_FehrestNameFltr.Name = "cmbo_FehrestNameFltr";
			this.cmbo_FehrestNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestNameFltr.Size = new System.Drawing.Size(139, 21);
			this.cmbo_FehrestNameFltr.TabIndex = 85;
			this.txt_ProjectCodeFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectCodeFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ProjectCodeFltr.Location = new System.Drawing.Point(1005, 25);
			this.txt_ProjectCodeFltr.Name = "txt_ProjectCodeFltr";
			this.txt_ProjectCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectCodeFltr.Size = new System.Drawing.Size(59, 21);
			this.txt_ProjectCodeFltr.TabIndex = 78;
			this.cmbo_ProjectShahrFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ProjectShahrFltr.FormattingEnabled = true;
			this.cmbo_ProjectShahrFltr.Location = new System.Drawing.Point(543, 25);
			this.cmbo_ProjectShahrFltr.Name = "cmbo_ProjectShahrFltr";
			this.cmbo_ProjectShahrFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectShahrFltr.Size = new System.Drawing.Size(99, 21);
			this.cmbo_ProjectShahrFltr.TabIndex = 81;
			this.cmbo_ProjectBakhshFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ProjectBakhshFltr.FormattingEnabled = true;
			this.cmbo_ProjectBakhshFltr.Location = new System.Drawing.Point(443, 25);
			this.cmbo_ProjectBakhshFltr.Name = "cmbo_ProjectBakhshFltr";
			this.cmbo_ProjectBakhshFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectBakhshFltr.Size = new System.Drawing.Size(100, 21);
			this.cmbo_ProjectBakhshFltr.TabIndex = 82;
			this.txt_ProjectNameFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectNameFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ProjectNameFltr.Location = new System.Drawing.Point(744, 25);
			this.txt_ProjectNameFltr.Name = "txt_ProjectNameFltr";
			this.txt_ProjectNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectNameFltr.Size = new System.Drawing.Size(260, 21);
			this.txt_ProjectNameFltr.TabIndex = 79;
			this.cmbo_ProjectOstanFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_ProjectOstanFltr.FormattingEnabled = true;
			this.cmbo_ProjectOstanFltr.Location = new System.Drawing.Point(643, 25);
			this.cmbo_ProjectOstanFltr.Name = "cmbo_ProjectOstanFltr";
			this.cmbo_ProjectOstanFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectOstanFltr.Size = new System.Drawing.Size(100, 21);
			this.cmbo_ProjectOstanFltr.TabIndex = 80;
			this.txt_ProjectTelFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectTelFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ProjectTelFltr.Location = new System.Drawing.Point(144, 25);
			this.txt_ProjectTelFltr.Name = "txt_ProjectTelFltr";
			this.txt_ProjectTelFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectTelFltr.Size = new System.Drawing.Size(98, 21);
			this.txt_ProjectTelFltr.TabIndex = 84;
			this.txt_ProjectAddressFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectAddressFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ProjectAddressFltr.Location = new System.Drawing.Point(242, 25);
			this.txt_ProjectAddressFltr.Name = "txt_ProjectAddressFltr";
			this.txt_ProjectAddressFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectAddressFltr.Size = new System.Drawing.Size(201, 21);
			this.txt_ProjectAddressFltr.TabIndex = 83;
			this.Button7.BackColor = System.Drawing.Color.LightGray;
			this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button7.ForeColor = System.Drawing.Color.Black;
			this.Button7.Location = new System.Drawing.Point(1506, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(89, 21);
			this.Button7.TabIndex = 44;
			this.Button7.Text = "حذف فیلتر";
			this.Button7.UseVisualStyleBackColor = false;
			this.pnl_Project.BackColor = System.Drawing.Color.LightSteelBlue;
			this.pnl_Project.Controls.Add(this.lbl_SanadZaribComment2);
			this.pnl_Project.Controls.Add(this.lbl_SanadZaribComment1);
			this.pnl_Project.Controls.Add(this.lbl_SanadZarib2);
			this.pnl_Project.Controls.Add(this.lbl_SanadZarib1);
			this.pnl_Project.Controls.Add(this.Label39);
			this.pnl_Project.Controls.Add(this.cmbo_FehrestName);
			this.pnl_Project.Controls.Add(this.btn_Exit);
			this.pnl_Project.Controls.Add(this.btn_Delete);
			this.pnl_Project.Controls.Add(this.btn_copy);
			this.pnl_Project.Controls.Add(this.btn_Insert);
			this.pnl_Project.Controls.Add(this.cmbo_ProjectBakhsh);
			this.pnl_Project.Controls.Add(this.cmbo_ProjectShahr);
			this.pnl_Project.Controls.Add(this.cmbo_ProjectOstan);
			this.pnl_Project.Controls.Add(this.Label42);
			this.pnl_Project.Controls.Add(this.Btn_Save);
			this.pnl_Project.Controls.Add(this.Label41);
			this.pnl_Project.Controls.Add(this.Label36);
			this.pnl_Project.Controls.Add(this.Label35);
			this.pnl_Project.Controls.Add(this.Label40);
			this.pnl_Project.Controls.Add(this.txt_ProjectTel);
			this.pnl_Project.Controls.Add(this.txt_ProjectAddress);
			this.pnl_Project.Controls.Add(this.txt_ProjectCode);
			this.pnl_Project.Controls.Add(this.txt_ProjectName);
			this.pnl_Project.Controls.Add(this.Label38);
			this.pnl_Project.Controls.Add(this.Label37);
			this.pnl_Project.Controls.Add(this.Label1);
			this.pnl_Project.Location = new System.Drawing.Point(5, 546);
			this.pnl_Project.Name = "pnl_Project";
			this.pnl_Project.Size = new System.Drawing.Size(1179, 143);
			this.pnl_Project.TabIndex = 92;
			this.lbl_SanadZaribComment2.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZaribComment2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZaribComment2.Location = new System.Drawing.Point(15, 78);
			this.lbl_SanadZaribComment2.Name = "lbl_SanadZaribComment2";
			this.lbl_SanadZaribComment2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZaribComment2.Size = new System.Drawing.Size(368, 20);
			this.lbl_SanadZaribComment2.TabIndex = 140;
			this.lbl_SanadZaribComment2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadZaribComment1.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZaribComment1.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZaribComment1.Location = new System.Drawing.Point(15, 55);
			this.lbl_SanadZaribComment1.Name = "lbl_SanadZaribComment1";
			this.lbl_SanadZaribComment1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZaribComment1.Size = new System.Drawing.Size(368, 20);
			this.lbl_SanadZaribComment1.TabIndex = 139;
			this.lbl_SanadZaribComment1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbl_SanadZarib2.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZarib2.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZarib2.Location = new System.Drawing.Point(387, 78);
			this.lbl_SanadZarib2.Name = "lbl_SanadZarib2";
			this.lbl_SanadZarib2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZarib2.Size = new System.Drawing.Size(43, 20);
			this.lbl_SanadZarib2.TabIndex = 138;
			this.lbl_SanadZarib2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbl_SanadZarib1.BackColor = System.Drawing.Color.White;
			this.lbl_SanadZarib1.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_SanadZarib1.Location = new System.Drawing.Point(387, 55);
			this.lbl_SanadZarib1.Name = "lbl_SanadZarib1";
			this.lbl_SanadZarib1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_SanadZarib1.Size = new System.Drawing.Size(43, 20);
			this.lbl_SanadZarib1.TabIndex = 137;
			this.lbl_SanadZarib1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.Label39.Location = new System.Drawing.Point(428, 69);
			this.Label39.Name = "Label39";
			this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label39.Size = new System.Drawing.Size(91, 27);
			this.Label39.TabIndex = 136;
			this.Label39.Text = " :ضریب منطقه ای";
			this.cmbo_FehrestName.Enabled = false;
			this.cmbo_FehrestName.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestName.FormattingEnabled = true;
			this.cmbo_FehrestName.Location = new System.Drawing.Point(14, 22);
			this.cmbo_FehrestName.Name = "cmbo_FehrestName";
			this.cmbo_FehrestName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestName.Size = new System.Drawing.Size(273, 26);
			this.cmbo_FehrestName.TabIndex = 125;
			this.btn_Exit.Location = new System.Drawing.Point(65, 110);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(100, 28);
			this.btn_Exit.TabIndex = 127;
			this.btn_Exit.Text = " خروج ";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Delete.Location = new System.Drawing.Point(295, 110);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(100, 28);
			this.btn_Delete.TabIndex = 132;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_copy.Location = new System.Drawing.Point(532, 110);
			this.btn_copy.Name = "btn_copy";
			this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_copy.Size = new System.Drawing.Size(100, 28);
			this.btn_copy.TabIndex = 131;
			this.btn_copy.Text = "(Clt+C) کپی";
			this.btn_copy.UseVisualStyleBackColor = true;
			this.btn_Insert.Location = new System.Drawing.Point(760, 110);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Insert.Size = new System.Drawing.Size(100, 28);
			this.btn_Insert.TabIndex = 130;
			this.btn_Insert.Text = "(Ins) ایجاد ";
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.cmbo_ProjectBakhsh.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ProjectBakhsh.FormattingEnabled = true;
			this.cmbo_ProjectBakhsh.Location = new System.Drawing.Point(291, 23);
			this.cmbo_ProjectBakhsh.Name = "cmbo_ProjectBakhsh";
			this.cmbo_ProjectBakhsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectBakhsh.Size = new System.Drawing.Size(100, 26);
			this.cmbo_ProjectBakhsh.TabIndex = 122;
			this.cmbo_ProjectShahr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ProjectShahr.FormattingEnabled = true;
			this.cmbo_ProjectShahr.Location = new System.Drawing.Point(392, 23);
			this.cmbo_ProjectShahr.Name = "cmbo_ProjectShahr";
			this.cmbo_ProjectShahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectShahr.Size = new System.Drawing.Size(100, 26);
			this.cmbo_ProjectShahr.TabIndex = 121;
			this.cmbo_ProjectOstan.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_ProjectOstan.FormattingEnabled = true;
			this.cmbo_ProjectOstan.Location = new System.Drawing.Point(493, 23);
			this.cmbo_ProjectOstan.Name = "cmbo_ProjectOstan";
			this.cmbo_ProjectOstan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ProjectOstan.Size = new System.Drawing.Size(100, 26);
			this.cmbo_ProjectOstan.TabIndex = 120;
			this.Label42.AutoSize = true;
			this.Label42.Location = new System.Drawing.Point(336, 7);
			this.Label42.Name = "Label42";
			this.Label42.Size = new System.Drawing.Size(30, 13);
			this.Label42.TabIndex = 115;
			this.Label42.Text = " بخش";
			this.Btn_Save.Location = new System.Drawing.Point(981, 110);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Save.Size = new System.Drawing.Size(100, 28);
			this.Btn_Save.TabIndex = 126;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Label41.AutoSize = true;
			this.Label41.Location = new System.Drawing.Point(423, 7);
			this.Label41.Name = "Label41";
			this.Label41.Size = new System.Drawing.Size(54, 13);
			this.Label41.TabIndex = 117;
			this.Label41.Text = " شهرستان";
			this.Label36.AutoSize = true;
			this.Label36.Location = new System.Drawing.Point(813, 7);
			this.Label36.Name = "Label36";
			this.Label36.Size = new System.Drawing.Size(55, 13);
			this.Label36.TabIndex = 123;
			this.Label36.Text = " نام پروژه ";
			this.Label35.AutoSize = true;
			this.Label35.Location = new System.Drawing.Point(1071, 7);
			this.Label35.Name = "Label35";
			this.Label35.Size = new System.Drawing.Size(51, 13);
			this.Label35.TabIndex = 122;
			this.Label35.Text = "کد پروژه ";
			this.Label40.AutoSize = true;
			this.Label40.Location = new System.Drawing.Point(530, 7);
			this.Label40.Name = "Label40";
			this.Label40.Size = new System.Drawing.Size(37, 13);
			this.Label40.TabIndex = 119;
			this.Label40.Text = "استان ";
			this.txt_ProjectTel.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectTel.Location = new System.Drawing.Point(545, 63);
			this.txt_ProjectTel.Name = "txt_ProjectTel";
			this.txt_ProjectTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectTel.Size = new System.Drawing.Size(97, 26);
			this.txt_ProjectTel.TabIndex = 124;
			this.txt_ProjectAddress.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectAddress.Location = new System.Drawing.Point(715, 63);
			this.txt_ProjectAddress.Name = "txt_ProjectAddress";
			this.txt_ProjectAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectAddress.Size = new System.Drawing.Size(350, 26);
			this.txt_ProjectAddress.TabIndex = 123;
			this.txt_ProjectCode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectCode.Location = new System.Drawing.Point(1066, 23);
			this.txt_ProjectCode.Name = "txt_ProjectCode";
			this.txt_ProjectCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectCode.Size = new System.Drawing.Size(59, 26);
			this.txt_ProjectCode.TabIndex = 118;
			this.txt_ProjectName.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ProjectName.Location = new System.Drawing.Point(595, 23);
			this.txt_ProjectName.Name = "txt_ProjectName";
			this.txt_ProjectName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ProjectName.Size = new System.Drawing.Size(470, 26);
			this.txt_ProjectName.TabIndex = 119;
			this.Label38.AutoSize = true;
			this.Label38.Location = new System.Drawing.Point(640, 69);
			this.Label38.Name = "Label38";
			this.Label38.Size = new System.Drawing.Size(61, 13);
			this.Label38.TabIndex = 125;
			this.Label38.Text = " تلفن پروژه:";
			this.Label37.AutoSize = true;
			this.Label37.Location = new System.Drawing.Point(1063, 67);
			this.Label37.Name = "Label37";
			this.Label37.Size = new System.Drawing.Size(68, 13);
			this.Label37.TabIndex = 124;
			this.Label37.Text = " آدرس پروژه :";
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(142, 7);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 13);
			this.Label1.TabIndex = 135;
			this.Label1.Text = "فهرست بها:";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			base.ClientSize = new System.Drawing.Size(1190, 692);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.pnl_Project);
			base.Controls.Add(this.dtg_Project);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Location = new System.Drawing.Point(90, 105);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Frm_Project";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "لیست پروژه ها";
			((System.ComponentModel.ISupportInitialize)this.dtg_Project).EndInit();
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.pnl_Project.ResumeLayout(false);
			this.pnl_Project.PerformLayout();
			base.ResumeLayout(false);

            this.dtg_Project.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_projectList_CellClick);
            this.dtg_Project.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_projectList_CellContentDoubleClick);
            this.dtg_Project.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_projectList_CellDoubleClick);
            this.dtg_Project.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_projectList_CellContentClick);
            this.dtg_Project.SelectionChanged += new System.EventHandler(this.dtg_project_SelectionChanged);
            this.dtg_Project.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Project_KeyDown);
            this.cmbo_ProjectShahrFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ProjectShahrFltr_SelectedIndexChanged);
            this.cmbo_ProjectShahrFltr.TextChanged += new System.EventHandler(this.cmbo_ProjectShahrFltr_TextChanged);
            this.cmbo_ProjectBakhshFltr.TextChanged += new System.EventHandler(this.cmbo_ProjectBakhshFltr_TextChanged);
            this.txt_ProjectNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectNameFltr_KeyDown);
            this.cmbo_ProjectOstanFltr.TextChanged += new System.EventHandler(this.cmbo_ProjectOstanFltr_TextChanged);
            this.txt_ProjectTelFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectTelFltr_KeyDown);
            this.txt_ProjectAddressFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectAddressFltr_KeyDown);
            this.txt_ProjectCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectCodeFltr_KeyDown);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.cmbo_ProjectBakhsh.GotFocus += new System.EventHandler(this.cmbo_ProjectBakhsh_GotFocus);
            this.cmbo_ProjectBakhsh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbo_ProjectBakhsh_MouseClick);
            this.cmbo_ProjectBakhsh.TextChanged += new System.EventHandler(this.cmbo_ProjectBakhsh_TextChanged);
            this.cmbo_ProjectBakhsh.SelectedIndexChanged += new System.EventHandler(this.cmbo_ProjectBakhsh_SelectedIndexChanged);
            this.cmbo_ProjectShahr.GotFocus += new System.EventHandler(this.cmbo_ProjectShahr_GotFocus);
            this.cmbo_ProjectShahr.SelectedValueChanged += new System.EventHandler(this.cmbo_ProjectShahr_SelectedValueChanged);
            this.cmbo_ProjectShahr.TextChanged += new System.EventHandler(this.cmbo_ProjectShahr_TextChanged);
            this.cmbo_ProjectShahr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ProjectShahr_SelectedIndexChanged);
            this.cmbo_ProjectOstan.GotFocus += new System.EventHandler(this.cmbo_ProjectOstan_GotFocus);
            this.cmbo_ProjectOstan.TextChanged += new System.EventHandler(this.cmbo_ProjectOstan_TextChanged);
            this.cmbo_ProjectOstan.SelectedIndexChanged += new System.EventHandler(this.cmbo_ProjectOstan_SelectedIndexChanged);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.txt_ProjectTel.GotFocus += new System.EventHandler(this.txt_ProjectTelList_GotFocus);
            this.txt_ProjectTel.TextChanged += new System.EventHandler(this.txt_ProjectTelList_TextChanged);
            this.txt_ProjectAddress.GotFocus += new System.EventHandler(this.txt_ProjectAddressList_GotFocus);
            this.txt_ProjectAddress.TextChanged += new System.EventHandler(this.txt_ProjectAddressList_TextChanged);
            this.txt_ProjectCode.GotFocus += new System.EventHandler(this.txt_ProjectCodeList_GotFocus);
            this.txt_ProjectCode.TextChanged += new System.EventHandler(this.txt_ProjectCodeList_TextChanged);
            this.txt_ProjectName.GotFocus += new System.EventHandler(this.txt_ProjectList_GotFocus);
            this.txt_ProjectName.TextChanged += new System.EventHandler(this.txt_ProjectList_TextChanged);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.cmbo_FehrestNameFltr.TextChanged += new System.EventHandler(this.cmbo_FehrestFltr_TextChanged);
            this.cmbo_FehrestName.GotFocus += new System.EventHandler(this.cmbo_FehrestName_GotFocus);
            this.cmbo_FehrestName.TextChanged += new System.EventHandler(this.cmbo_FehrestName_TextChanged);
        }

		private void dtg_projectsList_SelectionChanged(object sender, EventArgs e)
		{
			if (DtgProjectRefresh == 1)
			{
				ShowProjectRecord();
			}
		}

		private void dtg_projectList_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowProjectRecord();
		}

		private void dtg_projectList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dtg_projectList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dtg_projectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowProjectRecord();
		}

		private void dtg_project_SelectionChanged(object sender, EventArgs e)
		{
			dtg_project_SelectionChanged();
		}

		private void txt_ProjectNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectNameFltr.Text;
					Module1.ProjectName_filter = " (REPLACE(REPLACE([pname],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					Module1.ProjectName_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

		private void txt_ProjectCodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectCodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectCodeFltr.Text;
					ProjectCode_filter = " ([pkod] Like N'%" + text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectCode_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

		private void txt_ProjectAddressFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectAddressFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					ProjectAddress_filter = " (REPLACE(REPLACE([padres],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(txt_ProjectAddressFltr.Text) + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectAddress_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

		private void txt_ProjectTelFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectTelFltr.Text, "", TextCompare: false) != 0)
				{
					ProjectTel_filter = " ([ptel] Like N'%" + txt_ProjectTelFltr.Text + "%')";
					btn_Filter.Text = "حذف فیلتر";
					btn_Filter.BackColor = Color.Red;
				}
				else
				{
					ProjectTel_filter = "";
					btn_Filter.Text = "فیلتر";
					btn_Filter.BackColor = Color.WhiteSmoke;
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

		private void cmbo_ProjectShahrFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void Frm_Project_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_Project_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			frmProjectRefresh = 0;
			Module1.Load_Cmbo(cmbo_ProjectOstanFltr, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_ProjectOstan, "ZarayebMantaghe", "Ostan", "");
			Module1.Load_Cmbo(cmbo_ProjectShahrFltr, "ZarayebMantaghe", "Shahr", "");
			Module1.Load_Cmbo(cmbo_ProjectShahr, "ZarayebMantaghe", "Shahr", "");
			Module1.Load_Cmbo(cmbo_ProjectBakhshFltr, "ZarayebMantaghe", "Bakhsh", "");
			Module1.Load_Cmbo(cmbo_ProjectBakhsh, "ZarayebMantaghe", "Bakhsh", "");
			Module1.Load_Cmbo(cmbo_FehrestNameFltr, "fehrest", "fehrest", "");
			Module1.Load_Cmbo(cmbo_FehrestName, "fehrest", "fehrest", "");
			cmbo_FehrestNameFltr.Text = Module1.MabnaFehresrFile;
			frmProjectRefresh = 1;
			if (Module1.FromAsnadList == 1)
			{
				cmbo_FehrestNameFltr.Text = Module1.CurrentFehrestName;
			}
			else
			{
				cmbo_FehrestNameFltr.Text = Module1.MabnaFehresrName;
			}
			foreach (Control control in pnl_Project.Controls)
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
			foreach (Control control in pnl_Project.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		private void GeneralKeyDownHandler(object sender, KeyEventArgs e)
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

		public void Load_dtg_Project()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[8];
			DtgProjectRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 7);
				if (Operators.CompareString(ProjectCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Module1.ProjectName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(Module1.ProjectName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectAddress_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectTel_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectOstan_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectShahr_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
				}
				if (Operators.CompareString(ProjectBakhsh_filter, "", TextCompare: false) != 0 && Operators.CompareString(ProjectFehrestFile_filter, "", TextCompare: false) != 0)
				{
					array[7] = " And ";
				}
				Module1.strWhere = " WHERE " + ProjectCode_filter + array[1] + Module1.ProjectName_filter + array[2] + ProjectAddress_filter + array[3] + ProjectTel_filter + array[4] + ProjectOstan_filter + array[5] + ProjectShahr_filter + array[6] + ProjectBakhsh_filter + array[7] + ProjectFehrestFile_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = "";
				}
				if (base.Visible)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [identradif] As 'Id',[identradif] As 'ردیف',[pkod] As 'کد پروژه', [pname] As 'نام پروژه',(SELECT Top 1 [Ostan] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Ostan]) As 'استان',(SELECT Top 1 [Shahr] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Shahr]) As 'شهر',(SELECT Top 1 [Bakhsh] FROM [dbo].[ZarayebMantaghe] where BakhshCode= [bakhshkod] group by [Bakhsh]) As 'بخش',[bakhshkod] As 'کد بخش',[padres] As 'آدرس پروژه',[ptel] As 'تلفن پروژه',[fehrest] ,(SELECT top 1 [fehrest] FROM [dbo].[fehrest] where filename = [etproj].[fehrest]) As 'فهرست بها'FROM [dbo].[etproj] " + Module1.strWhere + " Order By [pkod],[fehrest] Asc";
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
					dtg_Project.DataSource = dataTable;
					dtg_Project.Columns[0].Width = 75;
					dtg_Project.Columns[0].Visible = false;
					dtg_Project.Columns[1].Width = 60;
					dtg_Project.Columns[2].Width = 60;
					dtg_Project.Columns[3].Width = 260;
					dtg_Project.Columns[4].Width = 100;
					dtg_Project.Columns[5].Width = 100;
					dtg_Project.Columns[6].Width = 100;
					dtg_Project.Columns[7].Visible = false;
					dtg_Project.Columns[8].Width = 200;
					dtg_Project.Columns[9].Width = 100;
					dtg_Project.Columns[10].Visible = false;
					dtg_Project.Columns[11].Width = 140;
					base.Visible = true;
				}
				DtgProjectRefresh = 1;
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_project_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.txt_Project.Focus();
				MyProject.Forms.Frm_AsnadList.txt_Project.Text = txt_ProjectName.Text;
				Module1.StrProjectCode = txt_ProjectCode.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadOstan.Text = cmbo_ProjectOstan.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadShahr.Text = cmbo_ProjectShahr.Text;
				MyProject.Forms.Frm_AsnadList.lbl_SanadBakhsh.Text = cmbo_ProjectBakhsh.Text;
				MyProject.Forms.Frm_AsnadList.cmbo_FehrestName.Text = cmbo_FehrestName.Text;
				MyProject.Forms.Frm_AsnadList.FindZaribMantaghe(Project.BakhshCode, Project.ProjectFehrestFile);
				Module1.FromAsnadList = 0;
			}
			Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			Btn_Save_Click();
		}

		public void btn_Insert_Click(object sender, EventArgs e)
		{
			frm_Project_btn_insert();
		}

		private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_ProjectCode.Text;
			string defaultResponse = "";
			BtnCommand = "Copy";
			if (pnl_Project.BackColor == Color.LightPink)
			{
				dtg_project_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [pkod] FROM [dbo].[etproj] Where [fehrest] ='" + Project.ProjectFehrestFile + "' Order By [pkod] Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				while (sqlDataReader.Read())
				{
					defaultResponse = Conversions.ToString(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1);
				}
				sqlDataReader.Close();
				string text2 = Interaction.InputBox(" کپی پروژه " + Conversions.ToString(Project.ProjectCode) + " تحت عنوان کد پروژه ذیل انجام شود؟ ", " ", defaultResponse);
				if (Operators.CompareString(text2, "", TextCompare: false) == 0)
				{
					return;
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [pkod] FROM [dbo].[etproj] Where [pkod]='" + text2 + "' And [fehrest] ='" + Project.ProjectFehrestFile + "'";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show("پروژه با کد " + text2 + " موجود است کد پروژه جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					return;
				}
				sqlDataReader.Close();
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[etproj]([radif],[pkod],[pname],[padres],[ptel],[bakhshkod],[fehrest],[fehname],[bakhshkod_old])(SELECT [radif],'" + text2 + "' [pkod],[pname],[padres],[ptel],[bakhshkod],[fehrest],[fehname],[bakhshkod_old] FROM [dbo].[etproj] Where [pkod]='" + text + "' And [fehrest] ='" + Project.ProjectFehrestFile + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Project();
				int num = dtg_Project.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Project.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Project.CurrentCell = dtg_Project.Rows[i].Cells[1];
						ShowProjectRecord();
						break;
					}
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_ProjectCode.Text;
			int index = dtg_Project.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Project.RowCount - 1 != 0)
				{
					int index2 = dtg_Project.CurrentRow.Index;
					if (MessageBox.Show("پروژه با کد   " + txt_ProjectCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE pkod = '" + text + "'";
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("ابتدا سند هایی که مرتبط به کد پروژه   " + txt_ProjectCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "DELETE FROM [dbo].[etproj] WHERE pkod = '" + text + "'";
						sqlCommand.ExecuteNonQuery();
					}
				}
				Load_dtg_Project();
				if (index != 0)
				{
					dtg_Project.CurrentCell = dtg_Project.Rows[index - 1].Cells[1];
				}
				else
				{
					dtg_Project.CurrentCell = dtg_Project.Rows[index].Cells[1];
				}
				ShowProjectRecord();
			}
		}

		private void cmbo_ProjectShahr_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_ProjectShahr_SelectedValueChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
		}

		private void cmbo_ProjectOstan_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_ProjectOstan_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectOstan.Text.Trim();
				try
				{
					if ((Operators.CompareString(text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectShahr.Text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectBakhsh.Text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						Module1.Load_Cmbo(cmbo_ProjectShahr, "ZarayebMantaghe", "Shahr", "Where Ostan = N'" + text + "'");
						try
						{
							cmbo_ProjectShahr.Text = "";
						}
						catch (ArgumentException ex)
						{
							ProjectData.SetProjectError(ex, lErl);
							ArgumentException ex2 = ex;
							ProjectData.ClearProjectError();
						}
						cmbo_ProjectOstan.ForeColor = Color.Red;
						cmbo_ProjectShahr.ForeColor = Color.Red;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex3)
				{
					ProjectData.SetProjectError(ex3, lErl);
					NullReferenceException ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

		private void cmbo_ProjectShahr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectShahr.Text.Trim();
				try
				{
					if ((Operators.CompareString(cmbo_ProjectOstan.Text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectBakhsh.Text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						Module1.Load_Cmbo(cmbo_ProjectBakhsh, "ZarayebMantaghe", "Bakhsh", "Where Ostan = N'" + cmbo_ProjectOstan.Text.Trim() + "' And [Shahr]= N'" + text + "'");
						try
						{
							cmbo_ProjectBakhsh.Text = "";
						}
						catch (ArgumentException ex)
						{
							ProjectData.SetProjectError(ex, lErl);
							ArgumentException ex2 = ex;
							ProjectData.ClearProjectError();
						}
						cmbo_ProjectShahr.ForeColor = Color.Red;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex3)
				{
					ProjectData.SetProjectError(ex3, lErl);
					NullReferenceException ex4 = ex3;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

		private void cmbo_ProjectBakhsh_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_ProjectBakhsh_MouseClick(object sender, MouseEventArgs e)
		{
		}

		private void cmbo_ProjectBakhsh_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectBakhsh.Text.Trim();
				try
				{
					if ((Operators.CompareString(cmbo_ProjectOstan.Text.Trim(), Project.ProjectOstan.Trim(), TextCompare: false) != 0) | (Operators.CompareString(cmbo_ProjectShahr.Text.Trim(), Project.ProjectShahr.Trim(), TextCompare: false) != 0) | (Operators.CompareString(text.Trim(), Project.ProjectBakhsh.Trim(), TextCompare: false) != 0))
					{
						Module1.FromFilter = false;
						cmbo_ProjectBakhsh.ForeColor = Color.Red;
					}
					else
					{
						cmbo_ProjectOstan.ForeColor = Color.Black;
						cmbo_ProjectShahr.ForeColor = Color.Black;
						cmbo_ProjectBakhsh.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

		private void CheckProjectChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Project.BackColor = Color.LightSteelBlue;
			foreach (object control in pnl_Project.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Project.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Project.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Project.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void SetPnl_ProjectBlue()
		{
			pnl_Project.BackColor = Color.LightSteelBlue;
			foreach (object control in pnl_Project.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Project.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void txt_ProjectCodeList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ProjectCodeList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectCode.Text, Conversions.ToString(Project.ProjectCode), TextCompare: false) != 0)
				{
					txt_ProjectCode.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectCode.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

		private void txt_ProjectList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ProjectList_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				try
				{
					if (Operators.CompareString(txt_ProjectName.Text.Trim(), Project.ProjectName.Trim(), TextCompare: false) != 0)
					{
						txt_ProjectName.ForeColor = Color.Red;
					}
					else
					{
						txt_ProjectName.ForeColor = Color.Black;
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ProjectData.ClearProjectError();
				}
				CheckProjectChange();
			}
			lErl = 20;
		}

		private void txt_ProjectAddressList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ProjectAddressList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectAddress.Text.Trim(), Project.ProjectAddress.Trim(), TextCompare: false) != 0)
				{
					txt_ProjectAddress.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectAddress.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

		private void txt_ProjectTelList_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ProjectTelList_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(txt_ProjectTel.Text.Trim(), Project.ProjectTel.Trim(), TextCompare: false) != 0)
				{
					txt_ProjectTel.ForeColor = Color.Red;
				}
				else
				{
					txt_ProjectTel.ForeColor = Color.Black;
				}
				CheckProjectChange();
			}
		}

		public object FindBakhshCode(string Ostan, string Shahr, string Bakhsh)
		{
			string result = "";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [BakhshCode] FROM [dbo].[ZarayebMantaghe] Where [Ostan] = N'" + Ostan + "' And [Shahr]= N'" + Shahr + "' And [Bakhsh]= N'" + Bakhsh + "' group by [BakhshCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				result = sqlDataReader[0].ToString();
			}
			sqlDataReader.Close();
			return result;
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_Filter.Text, "حذف فیلتر", TextCompare: false) == 0)
			{
				txt_ProjectCodeFltr.Text = "";
				txt_ProjectNameFltr.Text = "";
				txt_ProjectAddressFltr.Text = "";
				txt_ProjectTelFltr.Text = "";
				cmbo_ProjectOstanFltr.Text = "";
				cmbo_ProjectShahrFltr.Text = "";
				cmbo_ProjectBakhshFltr.Text = "";
				Frm_Project_Load(RuntimeHelpers.GetObjectValue(sender), e);
				btn_Filter.Text = "فیلتر";
				btn_Filter.BackColor = Color.WhiteSmoke;
			}
		}

		private void cmbo_ProjectOstanFltr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectOstanFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [OstanCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Ostan],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectOstan_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectOstan_filter = "";
					break;
				default:
					ProjectOstan_filter = " (SUBSTRING(Cast([bakhshkod] As varchar(10)), 1, 2) Like N'%" + text2 + "%')";
					break;
				}
				Module1.Load_Cmbo(cmbo_ProjectShahrFltr, "[ZarayebMantaghe]", "Shahr", "Where [Ostan] = N'" + text + "'");
				try
				{
					cmbo_ProjectShahrFltr.Text = "";
				}
				catch (ArgumentException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ArgumentException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
			lErl = 20;
		}

		private void cmbo_ProjectShahrFltr_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectShahrFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [ShahrCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Shahr],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "' And REPLACE(REPLACE([Ostan],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(cmbo_ProjectOstanFltr.Text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectShahr_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectShahr_filter = "";
					break;
				default:
					ProjectShahr_filter = " (SUBSTRING(Cast([bakhshkod] As varchar(10)), 1, 4) Like N'%" + text2 + "%')";
					break;
				}
				Module1.Load_Cmbo(cmbo_ProjectBakhshFltr, "[ZarayebMantaghe]", "Bakhsh", "Where [Shahr] = N'" + text + "' And [Ostan]= N'" + cmbo_ProjectOstanFltr.Text + "'");
				try
				{
					cmbo_ProjectBakhshFltr.Text = "";
				}
				catch (ArgumentException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ArgumentException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
			lErl = 20;
		}

		private void cmbo_ProjectBakhshFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				string text = cmbo_ProjectBakhshFltr.Text;
				string text2 = "";
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT Top 1 [BakhshCode] FROM [dbo].[ZarayebMantaghe] Where REPLACE(REPLACE([Bakhsh],'ي',N'ی'),'ك',N'ک')  = N'" + Module1.ArbToPer(text) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					text2 = sqlDataReader[0].ToString();
				}
				switch (text)
				{
				case "Null":
					ProjectBakhsh_filter = " ([bakhshkod] is Null)";
					break;
				case null:
				case "":
					ProjectBakhsh_filter = "";
					break;
				default:
					ProjectBakhsh_filter = " ([bakhshkod] Like N'%" + text2 + "%')";
					break;
				}
				Load_dtg_Project();
				if (DtgProjectRefresh == 1)
				{
					ShowProjectRecord();
				}
			}
		}

		private void dtg_Project_KeyDown(object sender, KeyEventArgs e)
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
				txt_ProjectCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void cmbo_FehrestFltr_TextChanged(object sender, EventArgs e)
		{
			if (frmProjectRefresh != 0)
			{
				if (Operators.CompareString(cmbo_FehrestNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = Module1.FindCodeOrName(cmbo_FehrestNameFltr.Text, "[fehrest]", "[filename]", "[fehrest]");
					ProjectFehrestFile_filter = " ([fehrest] Like '%" + text + "%')";
				}
				else
				{
					ProjectFehrestFile_filter = "";
				}
				Load_dtg_Project();
				ShowProjectRecord();
			}
		}

		private void cmbo_FehrestName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_FehrestName_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			if (frmProjectRefresh != 0)
			{
				string inputData = cmbo_FehrestName.Text.Trim();
				try
				{
					if (Operators.CompareString(Module1.FindCodeOrName(inputData, "[fehrest]", "[filename]", "[fehrest]"), Project.ProjectFehrestFile.Trim(), TextCompare: false) != 0)
					{
						cmbo_FehrestName.ForeColor = Color.Red;
					}
					else
					{
						cmbo_FehrestName.ForeColor = Color.Black;
					}
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				lErl = 10;
				CheckProjectChange();
			}
			lErl = 20;
		}

		private object CheckProjectExist()
		{
			object obj = 0;
			if (Operators.CompareString(txt_ProjectName.Text, "", TextCompare: false) == 0)
			{
				DialogResult dialogResult = MessageBox.Show(".نام پروژه را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [pkod] FROM [dbo].[etproj] Where [pkod]='" + txt_ProjectCode.Text + "' And [fehrest]='" + Module1.FindCodeOrName(cmbo_FehrestName.Text, "[fehrest]", "[filename]", "[fehrest]") + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			obj = ((!sqlDataReader.HasRows) ? ((object)0) : ((object)1));
			sqlDataReader.Close();
			return obj;
		}

		public void frm_Project_btn_insert()
		{
			BtnCommand = "Insert";
			if (pnl_Project.BackColor == Color.LightPink)
			{
				dtg_project_SelectionChanged();
			}
			pnl_Project.BackColor = Color.LightPink;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [pkod] FROM [dbo].[etproj] order by Cast([pkod] As bigint) Desc";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				txt_ProjectCode.Text = Conversions.ToString(checked(Conversions.ToInteger(sqlDataReader[0].ToString()) + 1));
			}
			sqlDataReader.Close();
			txt_ProjectName.Text = "";
			cmbo_FehrestName.Enabled = true;
			cmbo_ProjectOstan.Text = "";
			cmbo_ProjectShahr.Text = "";
			cmbo_ProjectBakhsh.Text = "";
			txt_ProjectAddress.Text = "";
			txt_ProjectTel.Text = "";
			cmbo_FehrestName.Text = Module1.MabnaFehresrName;
		}

		public void dtg_project_SelectionChanged()
		{
			if (frmProjectRefresh == 0)
			{
				return;
			}
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Project.BackColor == Color.LightPink) & (frmProjectRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات پروژه ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click();
					SetPnl_ProjectBlue();
					break;
				case DialogResult.No:
					SetPnl_ProjectBlue();
					break;
				case DialogResult.Cancel:
					txt_ProjectCode.Focus();
					return;
				}
			}
			if (DtgProjectRefresh == 1)
			{
				ShowProjectRecord();
			}
		}

		private void Btn_Save_Click()
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(txt_ProjectCode.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("کد پروژه را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_ProjectCode.Focus();
				}
				else if (Operators.CompareString(cmbo_ProjectOstan.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("استان پروژه را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbo_ProjectOstan.Focus();
				}
				else if (Operators.CompareString(cmbo_ProjectShahr.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("شهر پروژه را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbo_ProjectShahr.Focus();
				}
				else if (Operators.CompareString(cmbo_ProjectBakhsh.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("بخش پروژه را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					cmbo_ProjectBakhsh.Focus();
				}
				else if (!(pnl_Project.BackColor == Color.LightSteelBlue))
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0, Operators.CompareObjectEqual(CheckProjectExist(), 1, TextCompare: false))))
					{
						MessageBox.Show("کد پروژه " + txt_ProjectCode.Text + " موجود است کد پروژه جدید انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_ProjectCode.Text = "";
						txt_ProjectCode.Focus();
					}
					else
					{
						string text2 = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
						if (Operators.CompareString(text2, "", TextCompare: false) == 0)
						{
							MessageBox.Show("کد بخش در بانک اطلاعات موجود نیست ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							cmbo_ProjectBakhsh.Focus();
						}
						else
						{
							string text3 = Module1.FindCodeOrName(cmbo_FehrestName.Text, "[fehrest]", "[filename]", "[fehrest]");
							MyProject.Forms.Frm_AsnadList.FindZaribMantaghe(text2, text3);
							string text4 = Conversions.ToString(Module1.Zarib_I);
							Module1.MyConn.Close();
							if (Module1.MyConn.State == ConnectionState.Closed)
							{
								Module1.MyConn.Open();
							}
							Module1.cmd.Connection = Module1.MyConn;
							Module1.MyConn1.Close();
							if (Module1.MyConn1.State == ConnectionState.Closed)
							{
								Module1.MyConn1.Open();
							}
							Module1.cmd1.Connection = Module1.MyConn1;
							if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
							{
								Module1.cmd.CommandText = "INSERT INTO [dbo].[etproj] ([radif],[pkod],[pname],[padres],[ptel],[bakhshkod],[fehrest],[fehname]) VALUES('0','" + Conversions.ToString(Conversions.ToSingle(txt_ProjectCode.Text)) + "','" + txt_ProjectName.Text + "','" + txt_ProjectAddress.Text + "','" + txt_ProjectTel.Text + "','" + Conversions.ToString(Conversions.ToSingle(text2)) + "','" + text3 + "','" + cmbo_FehrestName.Text + "')";
								Module1.cmd.ExecuteNonQuery();
								SetPnl_ProjectBlue();
							}
							else
							{
								Module1.cmd.CommandText = "UPDATE [dbo].[etproj] SET [radif] ='0',[pkod] ='" + txt_ProjectCode.Text + "',[pname] = '" + txt_ProjectName.Text + "',[padres] = '" + txt_ProjectAddress.Text + "',[ptel] = '" + txt_ProjectTel.Text + "',[bakhshkod] = '" + text2 + "',[fehrest] = '" + Module1.FindCodeOrName(cmbo_FehrestName.Text, "[fehrest]", "[filename]", "[fehrest]") + "',[fehname] = '" + cmbo_FehrestName.Text + "' WHERE identradif = '" + Conversions.ToString(Project.Id) + "'";
								Module1.cmd.ExecuteNonQuery();
								SetPnl_ProjectBlue();
							}
							Module1.cmd.CommandText = "SELECT [okod],[oname],[fehrest] FROM [dbo].[etostan] where [okod]='" + text2.Substring(0, 2) + "' And [oname]='" + cmbo_ProjectOstan.Text + "' And [fehrest]='" + text3 + "'";
							SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
							if (!sqlDataReader.HasRows)
							{
								Module1.cmd1.CommandText = "INSERT INTO [dbo].[etostan]([okod],[oname],[fehrest]) VALUES('" + text2.Substring(0, 2) + "','" + cmbo_ProjectOstan.Text + "','" + text3 + "')";
								Module1.cmd1.ExecuteNonQuery();
							}
							sqlDataReader.Close();
							Module1.cmd.CommandText = "SELECT [okod],[shkod],[shname],[fehrest] FROM [dbo].[etshahr] where [okod]='" + text2.Substring(0, 2) + "' And [shkod]='" + text2.Substring(0, 4) + "' And [shname]='" + cmbo_ProjectShahr.Text + "' And [fehrest]='" + text3 + "'";
							sqlDataReader = Module1.cmd.ExecuteReader();
							if (!sqlDataReader.HasRows)
							{
								Module1.cmd1.CommandText = "INSERT INTO [dbo].[etshahr]([okod],[shkod],[shname],[fehrest]) VALUES('" + text2.Substring(0, 2) + "','" + text2.Substring(0, 4) + "','" + cmbo_ProjectShahr.Text + "','" + text3 + "')";
								Module1.cmd1.ExecuteNonQuery();
							}
							sqlDataReader.Close();
							Module1.cmd.CommandText = "SELECT [okod],[shkod],[bkod],[bname],[zarib],[fehrest] FROM [dbo].[etbakhsh] where [okod]='" + text2.Substring(0, 2) + "' And [shkod]='" + text2.Substring(0, 4) + "' And [bkod]='" + text2 + "' And [bname]='" + cmbo_ProjectBakhsh.Text + "' And [zarib]='" + text4 + "' And [fehrest]='" + text3 + "'";
							sqlDataReader = Module1.cmd.ExecuteReader();
							if (!sqlDataReader.HasRows)
							{
								Module1.cmd1.CommandText = "INSERT INTO [dbo].[etbakhsh] ([okod],[shkod],[bkod],[bname],[zarib],[fehrest]) VALUES('" + text2.Substring(0, 2) + "','" + text2.Substring(0, 4) + "','" + text2 + "','" + cmbo_ProjectBakhsh.Text + "','" + text4 + "','" + text3 + "')";
								Module1.cmd1.ExecuteNonQuery();
							}
							sqlDataReader.Close();
							Module1.MyConn.Close();
							Module1.MyConn1.Close();
							text = txt_ProjectCode.Text;
							if (Module1.FromAsnadList == 1)
							{
								MyProject.Forms.Frm_AsnadList.txt_Project.Focus();
								MyProject.Forms.Frm_AsnadList.txt_Project.Text = txt_ProjectName.Text;
								Module1.StrProjectCode = txt_ProjectCode.Text;
								MyProject.Forms.Frm_AsnadList.lbl_SanadOstan.Text = cmbo_ProjectOstan.Text;
								MyProject.Forms.Frm_AsnadList.lbl_SanadShahr.Text = cmbo_ProjectShahr.Text;
								MyProject.Forms.Frm_AsnadList.lbl_SanadBakhsh.Text = cmbo_ProjectBakhsh.Text;
								MyProject.Forms.Frm_AsnadList.cmbo_FehrestName.Text = cmbo_FehrestName.Text;
								MyProject.Forms.Frm_AsnadList.FindZaribMantaghe(text2, text3);
								Module1.FromAsnadList = 0;
								Close();
							}
							Load_dtg_Project();
							int num = dtg_Project.RowCount - 1;
							for (int i = 0; i <= num; i++)
							{
								if (Operators.ConditionalCompareObjectEqual(dtg_Project.Rows[i].Cells[2].Value, text, TextCompare: false))
								{
									dtg_Project.CurrentCell = dtg_Project.Rows[i].Cells[1];
									ShowProjectRecord();
								}
							}
						}
					}
				}
				BtnCommand = "";
			}
		}

		public void FindZaribMantaghe(string BakhshCode, string FehrestFile)
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[3];
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ZaribCode] FROM [dbo].[Fosool] where [FehrestFile] =N'" + FehrestFile + "' Group by zaribcode Order by [ZaribCode]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			int num = 0;
			checked
			{
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])) && Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectNotEqual(sqlDataReader[0], 0, TextCompare: false), num < 5)))
					{
						num++;
						array[num] = Conversions.ToString(sqlDataReader[0]);
					}
				}
				sqlDataReader.Close();
				dataTable.Columns.Clear();
				dataTable.Rows.Clear();
				Module1.cmd.CommandText = "SELECT Top 1 [zarib]  As 'Zarib_i' FROM [dbo].[etbakhsh] where ([bkod]='" + BakhshCode + "' and [fehrest] ='" + FehrestFile + "') ";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					while (sqlDataReader.Read())
					{
						Module1.Zarib_I = Conversions.ToSingle(sqlDataReader[0]);
					}
					sqlDataReader.Close();
					if (Module1.Zarib_I != 0f)
					{
						if ((Operators.CompareString(FehrestFile.Trim(), "FEHBAHA1400", TextCompare: false) == 0) | (Operators.CompareString(FehrestFile.Trim(), "FEHBAHA1401", TextCompare: false) == 0))
						{
							lbl_SanadZaribComment1.Text = "ضریب منطقه ای برای فصل 1 و 2 و6 طبق بخش نامه 1403/169890  سازمان مدیریت ";
							lbl_SanadZaribComment2.Text = "ضریب منطقه ای برای فصل 5 طبق بخش نامه 1403/169890 سازمان مدیریت";
						}
						else
						{
							lbl_SanadZaribComment1.Text = "(فصول 1 و 2 و6 طبق بخش نامه 3730 سازمان مديريت)";
							lbl_SanadZaribComment2.Text = "(فصل 5 طبق بخش نامه 3730 سازمان مديريت)";
						}
						goto IL_02e4;
					}
				}
				else
				{
					sqlDataReader.Close();
				}
				Module1.cmd.CommandText = "SELECT zarib_i , comment FROM [dbo].[ZarayebMantaghe] where BakhshCode='" + BakhshCode + "' And (ZaribCode='" + array[1] + "' Or ZaribCode ='" + array[2] + "') Order By ZaribCode";
				sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					num = 0;
					while (sqlDataReader.Read())
					{
						num++;
						if (num == 1)
						{
							Module1.Zarib_I = Conversions.ToSingle(sqlDataReader[0]);
							lbl_SanadZaribComment1.Text = sqlDataReader[1].ToString();
						}
						else
						{
							lbl_SanadZaribComment2.Text = sqlDataReader[1].ToString();
						}
					}
				}
				sqlDataReader.Close();
				Module1.MyConn.Close();
				goto IL_02e4;
			}
			IL_02e4:
			if ((Module1.Zarib_I != 0f) & (Operators.CompareString(BakhshCode, "", TextCompare: false) != 0))
			{
				Module1.Zarib_1 = (float)Math.Round(((double)Module1.Zarib_I + 1.7) / 2.7, 3);
				lbl_SanadZarib1.Text = Strings.FormatCurrency(Module1.Zarib_1, 3, TriState.True, TriState.False);
				Module1.Zarib_2 = (float)Math.Round(((double)Module1.Zarib_I + 1.4) / 2.4, 3);
				lbl_SanadZarib2.Text = Strings.FormatCurrency(Module1.Zarib_2, 3, TriState.True, TriState.False);
			}
			else
			{
				lbl_SanadZarib1.Text = "";
				lbl_SanadZarib2.Text = "";
			}
		}

		public void FindOstanShahrBakhsh(string Bakhshcode)
		{
			SqlCommand sqlCommand = new SqlCommand();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			sqlCommand.Connection = Module1.MyConn;
			sqlCommand.CommandText = "Select REPLACE((REPLACE([Ostan],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Shahr],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([Bakhsh],'ي',N'ی')),'ك',N'ک') FROM [dbo].[ZarayebMantaghe] where BakhshCode ='" + Bakhshcode + "'";
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					Module1.StrOstan = sqlDataReader[0].ToString();
					Module1.StrShahr = sqlDataReader[1].ToString();
					Module1.StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			else
			{
				sqlDataReader.Close();
				sqlCommand.CommandText = "Select REPLACE((REPLACE([etostan].[oname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etshahr].[shname],'ي',N'ی')),'ك',N'ک'),REPLACE((REPLACE([etbakhsh].[bname],'ي',N'ی')),'ك',N'ک') FROM [dbo].[etbakhsh] INNER JOIN [etostan] ON [etbakhsh].okod =[etostan].okod  INNER JOIN [etshahr] ON [etbakhsh].shkod =[etshahr].shkod  where bkod ='" + Bakhshcode + "' group by [etbakhsh].[okod],[etostan].[oname],[etbakhsh].[shkod],[etshahr].[shname],[etbakhsh].[bkod],[etbakhsh].[bname],[etbakhsh].[zarib]";
				sqlDataReader = sqlCommand.ExecuteReader();
				while (sqlDataReader.Read())
				{
					Module1.StrOstan = sqlDataReader[0].ToString();
					Module1.StrShahr = sqlDataReader[1].ToString();
					Module1.StrBakhsh = sqlDataReader[2].ToString();
				}
			}
			sqlDataReader.Close();
		}

		private void cmbo_ProjectOstan_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

		private void cmbo_ProjectShahr_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

		private void cmbo_ProjectBakhsh_SelectedIndexChanged(object sender, EventArgs e)
		{
			Module1.FromFilter = false;
			string bakhshCode = Conversions.ToString(FindBakhshCode(cmbo_ProjectOstan.Text, cmbo_ProjectShahr.Text, cmbo_ProjectBakhsh.Text));
			FindZaribMantaghe(bakhshCode, Project.ProjectFehrestFile);
		}

		public void ShowProjectRecord()
		{
			cmbo_FehrestName.Enabled = false;
			int index = 0;
			ref ProjectDetailes project = ref Project;
			int lErl = default(int);
			if (dtg_Project.RowCount != 0)
			{
				try
				{
					index = dtg_Project.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				project.Id = Conversions.ToInteger(dtg_Project.Rows[index].Cells[0].Value);
				project.ProjectCode = Conversions.ToInteger(dtg_Project.Rows[index].Cells[2].Value);
				project.ProjectName = dtg_Project.Rows[index].Cells[3].Value.ToString();
				project.BakhshCode = dtg_Project.Rows[index].Cells[7].Value.ToString();
				if ((Operators.CompareString(dtg_Project.Rows[index].Cells[4].Value.ToString(), "", TextCompare: false) == 0) | (Operators.CompareString(dtg_Project.Rows[index].Cells[5].Value.ToString(), "", TextCompare: false) == 0) | (Operators.CompareString(dtg_Project.Rows[index].Cells[6].Value.ToString(), "", TextCompare: false) == 0))
				{
					FindOstanShahrBakhsh(project.BakhshCode);
					project.ProjectOstan = Module1.StrOstan;
					project.ProjectShahr = Module1.StrShahr;
					project.ProjectBakhsh = Module1.StrBakhsh;
				}
				else
				{
					project.ProjectOstan = dtg_Project.Rows[index].Cells[4].Value.ToString();
					project.ProjectShahr = dtg_Project.Rows[index].Cells[5].Value.ToString();
					project.ProjectBakhsh = dtg_Project.Rows[index].Cells[6].Value.ToString();
				}
				project.ProjectAddress = dtg_Project.Rows[index].Cells[8].Value.ToString();
				project.ProjectTel = dtg_Project.Rows[index].Cells[9].Value.ToString();
				project.ProjectFehrestFile = dtg_Project.Rows[index].Cells[10].Value.ToString();
				txt_ProjectCode.Text = Conversions.ToString(project.ProjectCode);
				txt_ProjectName.Text = project.ProjectName;
				txt_ProjectAddress.Text = project.ProjectAddress;
				txt_ProjectTel.Text = project.ProjectTel;
				cmbo_ProjectOstan.Text = project.ProjectOstan;
				cmbo_ProjectShahr.Text = project.ProjectShahr;
				cmbo_ProjectBakhsh.Text = project.ProjectBakhsh;
				cmbo_FehrestName.Text = Module1.FindCodeOrName(project.ProjectFehrestFile, "[filename]", "[fehrest]", "[fehrest]");
				string bakhshCode = Conversions.ToString(FindBakhshCode(project.ProjectOstan, project.ProjectShahr, project.ProjectBakhsh));
				FindZaribMantaghe(bakhshCode, project.ProjectFehrestFile);
			}
			lErl = 60;
		}
	}
}
