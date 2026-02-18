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
using Microsoft.VisualBasic.PowerPacks;

namespace GeoBaha
{
	[DesignerGenerated]
	public class frm_AsnadOnvan : Form
	{
		private IContainer components;


		public string EsmRamz_filter;

		public string ShName_filter;

		public string EghtesadiCode_filter;

		public string AvarezShahrdari_filter;

		public string ArzeshAfzoode_filter;

		public string OnvanMabna_filter;

		public string OnvanFactor_filter;

		public string MatnName_filter;

		public string SahebEmza_filter;

		public string Semat_filter;

		private string BtnCommand;

		private byte frmOnvanRefresh;

		private byte DtgOnvanRefresh;

		private string ChangeDtgOrPnl;

		private string MabnaEsmRamz;
        private System.Windows.Forms.Panel pnl_Filter;
        internal System.Windows.Forms.TextBox txt_EsmRamzFltr;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.DataGridView dtg_Onvan;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.TextBox txt_ArzeshAfzoodeFltr;
        private System.Windows.Forms.TextBox txt_AvarezShahrdariFltr;
        private System.Windows.Forms.TextBox txt_CodeEghtesadiFltr;
        private System.Windows.Forms.TextBox txt_ShNameFltr;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer2;
        private System.Windows.Forms.TextBox txt_OnvanFactorFltr;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.TextBox txt_SematFltr;
        private System.Windows.Forms.TextBox txt_SahebEmzaFltr;
        private System.Windows.Forms.ComboBox cmbo_OnvanMabnaFltr;
        private System.Windows.Forms.Panel pnl_Onvan;
        private System.Windows.Forms.ComboBox cmbo_OnvanMabna;
        private System.Windows.Forms.TextBox txt_Semat;
        private System.Windows.Forms.TextBox txt_SahebEmza;
        private System.Windows.Forms.TextBox txt_OnvanSanad;
        private System.Windows.Forms.TextBox txt_CodeEghtesadi;
        private System.Windows.Forms.TextBox txt_ShName;
        private System.Windows.Forms.TextBox txt_ArzeshAfzoode;
        private System.Windows.Forms.TextBox txt_AvarezShahrdari;
        private System.Windows.Forms.TextBox txt_EsmRamzCode;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;

        public frm_AsnadOnvan()
		{
			base.KeyDown += frm_AsnadOnvan_KeyDown;
			base.Load += frm_AsnadAnavin_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.frm_AsnadOnvan));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_OnvanMabnaFltr = new System.Windows.Forms.ComboBox();
			this.txt_SematFltr = new System.Windows.Forms.TextBox();
			this.txt_SahebEmzaFltr = new System.Windows.Forms.TextBox();
			this.txt_OnvanFactorFltr = new System.Windows.Forms.TextBox();
			this.txt_CodeEghtesadiFltr = new System.Windows.Forms.TextBox();
			this.txt_ShNameFltr = new System.Windows.Forms.TextBox();
			this.txt_ArzeshAfzoodeFltr = new System.Windows.Forms.TextBox();
			this.txt_AvarezShahrdariFltr = new System.Windows.Forms.TextBox();
			this.txt_EsmRamzFltr = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.dtg_Onvan = new System.Windows.Forms.DataGridView();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.btn_Insert = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_Save = new System.Windows.Forms.Button();
			this.RectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.ShapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.pnl_Onvan = new System.Windows.Forms.Panel();
			this.PictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmbo_OnvanMabna = new System.Windows.Forms.ComboBox();
			this.txt_Semat = new System.Windows.Forms.TextBox();
			this.txt_SahebEmza = new System.Windows.Forms.TextBox();
			this.txt_OnvanSanad = new System.Windows.Forms.TextBox();
			this.txt_CodeEghtesadi = new System.Windows.Forms.TextBox();
			this.txt_ShName = new System.Windows.Forms.TextBox();
			this.txt_ArzeshAfzoode = new System.Windows.Forms.TextBox();
			this.txt_AvarezShahrdari = new System.Windows.Forms.TextBox();
			this.txt_EsmRamzCode = new System.Windows.Forms.TextBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Onvan).BeginInit();
			this.pnl_Onvan.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).BeginInit();
			base.SuspendLayout();
			this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.cmbo_OnvanMabnaFltr);
			this.pnl_Filter.Controls.Add(this.txt_SematFltr);
			this.pnl_Filter.Controls.Add(this.txt_SahebEmzaFltr);
			this.pnl_Filter.Controls.Add(this.txt_OnvanFactorFltr);
			this.pnl_Filter.Controls.Add(this.txt_CodeEghtesadiFltr);
			this.pnl_Filter.Controls.Add(this.txt_ShNameFltr);
			this.pnl_Filter.Controls.Add(this.txt_ArzeshAfzoodeFltr);
			this.pnl_Filter.Controls.Add(this.txt_AvarezShahrdariFltr);
			this.pnl_Filter.Controls.Add(this.txt_EsmRamzFltr);
			this.pnl_Filter.Controls.Add(this.Button7);
			this.pnl_Filter.Location = new System.Drawing.Point(8, 12);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1180, 60);
			this.pnl_Filter.TabIndex = 95;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(1140, 0);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(38, 58);
			this.btn_Filter.TabIndex = 97;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1087, -1);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(55, 60);
			this.Label10.TabIndex = 156;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("PictureBox1.InitialImage");
			this.PictureBox1.Location = new System.Drawing.Point(2, 1);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1174, 32);
			this.PictureBox1.TabIndex = 161;
			this.PictureBox1.TabStop = false;
			this.cmbo_OnvanMabnaFltr.AllowDrop = true;
			this.cmbo_OnvanMabnaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_OnvanMabnaFltr.ForeColor = System.Drawing.Color.Red;
			this.cmbo_OnvanMabnaFltr.FormattingEnabled = true;
			this.cmbo_OnvanMabnaFltr.Location = new System.Drawing.Point(2, 35);
			this.cmbo_OnvanMabnaFltr.Name = "cmbo_OnvanMabnaFltr";
			this.cmbo_OnvanMabnaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_OnvanMabnaFltr.Size = new System.Drawing.Size(44, 26);
			this.cmbo_OnvanMabnaFltr.TabIndex = 23;
			this.txt_SematFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SematFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_SematFltr.Location = new System.Drawing.Point(47, 35);
			this.txt_SematFltr.Name = "txt_SematFltr";
			this.txt_SematFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SematFltr.Size = new System.Drawing.Size(148, 26);
			this.txt_SematFltr.TabIndex = 22;
			this.txt_SahebEmzaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SahebEmzaFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_SahebEmzaFltr.Location = new System.Drawing.Point(196, 35);
			this.txt_SahebEmzaFltr.Name = "txt_SahebEmzaFltr";
			this.txt_SahebEmzaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SahebEmzaFltr.Size = new System.Drawing.Size(148, 26);
			this.txt_SahebEmzaFltr.TabIndex = 21;
			this.txt_OnvanFactorFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_OnvanFactorFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_OnvanFactorFltr.Location = new System.Drawing.Point(345, 35);
			this.txt_OnvanFactorFltr.Name = "txt_OnvanFactorFltr";
			this.txt_OnvanFactorFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_OnvanFactorFltr.Size = new System.Drawing.Size(230, 26);
			this.txt_OnvanFactorFltr.TabIndex = 20;
			this.txt_CodeEghtesadiFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_CodeEghtesadiFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_CodeEghtesadiFltr.Location = new System.Drawing.Point(675, 35);
			this.txt_CodeEghtesadiFltr.Name = "txt_CodeEghtesadiFltr";
			this.txt_CodeEghtesadiFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_CodeEghtesadiFltr.Size = new System.Drawing.Size(120, 26);
			this.txt_CodeEghtesadiFltr.TabIndex = 17;
			this.txt_ShNameFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ShNameFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ShNameFltr.Location = new System.Drawing.Point(796, 35);
			this.txt_ShNameFltr.Name = "txt_ShNameFltr";
			this.txt_ShNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ShNameFltr.Size = new System.Drawing.Size(228, 26);
			this.txt_ShNameFltr.TabIndex = 16;
			this.txt_ArzeshAfzoodeFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ArzeshAfzoodeFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_ArzeshAfzoodeFltr.Location = new System.Drawing.Point(576, 35);
			this.txt_ArzeshAfzoodeFltr.Name = "txt_ArzeshAfzoodeFltr";
			this.txt_ArzeshAfzoodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ArzeshAfzoodeFltr.Size = new System.Drawing.Size(49, 26);
			this.txt_ArzeshAfzoodeFltr.TabIndex = 19;
			this.txt_AvarezShahrdariFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_AvarezShahrdariFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_AvarezShahrdariFltr.Location = new System.Drawing.Point(626, 35);
			this.txt_AvarezShahrdariFltr.Name = "txt_AvarezShahrdariFltr";
			this.txt_AvarezShahrdariFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_AvarezShahrdariFltr.Size = new System.Drawing.Size(48, 26);
			this.txt_AvarezShahrdariFltr.TabIndex = 18;
			this.txt_EsmRamzFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_EsmRamzFltr.ForeColor = System.Drawing.Color.Red;
			this.txt_EsmRamzFltr.Location = new System.Drawing.Point(1025, 35);
			this.txt_EsmRamzFltr.Name = "txt_EsmRamzFltr";
			this.txt_EsmRamzFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_EsmRamzFltr.Size = new System.Drawing.Size(61, 26);
			this.txt_EsmRamzFltr.TabIndex = 15;
			this.Button7.BackColor = System.Drawing.Color.LightGray;
			this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button7.ForeColor = System.Drawing.Color.Black;
			this.Button7.Location = new System.Drawing.Point(1506, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(89, 21);
			this.Button7.TabIndex = 44;
			this.Button7.Text = "حذف فیلتر";
			this.Button7.UseVisualStyleBackColor = false;
			this.dtg_Onvan.AllowUserToAddRows = false;
			this.dtg_Onvan.AllowUserToDeleteRows = false;
			this.dtg_Onvan.AllowUserToOrderColumns = true;
			this.dtg_Onvan.BackgroundColor = System.Drawing.Color.Beige;
			this.dtg_Onvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dtg_Onvan.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Onvan.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Onvan.Location = new System.Drawing.Point(8, 37);
			this.dtg_Onvan.Name = "dtg_Onvan";
			this.dtg_Onvan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Onvan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Onvan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Onvan.Size = new System.Drawing.Size(1180, 383);
			this.dtg_Onvan.TabIndex = 94;
			this.btn_Exit.Location = new System.Drawing.Point(947, 506);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(79, 23);
			this.btn_Exit.TabIndex = 14;
			this.btn_Exit.Text = "(Esc) خروج ";
			this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Copy.Location = new System.Drawing.Point(584, 506);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Copy.Size = new System.Drawing.Size(79, 23);
			this.btn_Copy.TabIndex = 12;
			this.btn_Copy.Text = "(Ctrl + C) کپی ";
			this.btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Copy.Visible = false;
			this.btn_Insert.Location = new System.Drawing.Point(403, 506);
			this.btn_Insert.Name = "btn_Insert";
			this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Insert.Size = new System.Drawing.Size(79, 23);
			this.btn_Insert.TabIndex = 11;
			this.btn_Insert.Text = "(Insert) جدید  ";
			this.btn_Insert.UseVisualStyleBackColor = true;
			this.btn_Insert.Visible = false;
			this.btn_Delete.Location = new System.Drawing.Point(777, 506);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(79, 23);
			this.btn_Delete.TabIndex = 13;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_Delete.Visible = false;
			this.btn_Save.Location = new System.Drawing.Point(243, 506);
			this.btn_Save.Name = "btn_Save";
			this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Save.Size = new System.Drawing.Size(79, 23);
			this.btn_Save.TabIndex = 10;
			this.btn_Save.Text = "(F2) ذخیره ";
			this.btn_Save.UseVisualStyleBackColor = true;
			this.btn_Save.Visible = false;
			this.RectangleShape2.Location = new System.Drawing.Point(119, 221);
			this.RectangleShape2.Name = "RectangleShape2";
			this.RectangleShape2.Size = new System.Drawing.Size(16, 54);
			this.ShapeContainer2.Location = new System.Drawing.Point(0, 0);
			this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer2.Name = "ShapeContainer2";
			this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[1] { this.RectangleShape2 });
			this.ShapeContainer2.Size = new System.Drawing.Size(1194, 545);
			this.ShapeContainer2.TabIndex = 96;
			this.ShapeContainer2.TabStop = false;
			this.pnl_Onvan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Onvan.Controls.Add(this.PictureBox2);
			this.pnl_Onvan.Controls.Add(this.cmbo_OnvanMabna);
			this.pnl_Onvan.Controls.Add(this.txt_Semat);
			this.pnl_Onvan.Controls.Add(this.txt_SahebEmza);
			this.pnl_Onvan.Controls.Add(this.txt_OnvanSanad);
			this.pnl_Onvan.Controls.Add(this.txt_CodeEghtesadi);
			this.pnl_Onvan.Controls.Add(this.txt_ShName);
			this.pnl_Onvan.Controls.Add(this.txt_ArzeshAfzoode);
			this.pnl_Onvan.Controls.Add(this.txt_AvarezShahrdari);
			this.pnl_Onvan.Controls.Add(this.txt_EsmRamzCode);
			this.pnl_Onvan.Controls.Add(this.Button2);
			this.pnl_Onvan.Location = new System.Drawing.Point(52, 427);
			this.pnl_Onvan.Name = "pnl_Onvan";
			this.pnl_Onvan.Size = new System.Drawing.Size(1083, 57);
			this.pnl_Onvan.TabIndex = 115;
			this.pnl_Onvan.Visible = false;
			this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
			this.PictureBox2.InitialImage = (System.Drawing.Image)resources.GetObject("PictureBox2.InitialImage");
			this.PictureBox2.Location = new System.Drawing.Point(0, 1);
			this.PictureBox2.Name = "PictureBox2";
			this.PictureBox2.Size = new System.Drawing.Size(1082, 32);
			this.PictureBox2.TabIndex = 162;
			this.PictureBox2.TabStop = false;
			this.cmbo_OnvanMabna.AllowDrop = true;
			this.cmbo_OnvanMabna.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_OnvanMabna.FormattingEnabled = true;
			this.cmbo_OnvanMabna.Location = new System.Drawing.Point(0, 35);
			this.cmbo_OnvanMabna.Name = "cmbo_OnvanMabna";
			this.cmbo_OnvanMabna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_OnvanMabna.Size = new System.Drawing.Size(43, 26);
			this.cmbo_OnvanMabna.TabIndex = 9;
			this.txt_Semat.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Semat.Location = new System.Drawing.Point(44, 35);
			this.txt_Semat.Name = "txt_Semat";
			this.txt_Semat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_Semat.Size = new System.Drawing.Size(148, 26);
			this.txt_Semat.TabIndex = 8;
			this.txt_SahebEmza.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SahebEmza.Location = new System.Drawing.Point(193, 35);
			this.txt_SahebEmza.Name = "txt_SahebEmza";
			this.txt_SahebEmza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_SahebEmza.Size = new System.Drawing.Size(149, 26);
			this.txt_SahebEmza.TabIndex = 7;
			this.txt_OnvanSanad.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_OnvanSanad.Location = new System.Drawing.Point(343, 35);
			this.txt_OnvanSanad.Name = "txt_OnvanSanad";
			this.txt_OnvanSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_OnvanSanad.Size = new System.Drawing.Size(230, 26);
			this.txt_OnvanSanad.TabIndex = 6;
			this.txt_CodeEghtesadi.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_CodeEghtesadi.Location = new System.Drawing.Point(672, 35);
			this.txt_CodeEghtesadi.Name = "txt_CodeEghtesadi";
			this.txt_CodeEghtesadi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_CodeEghtesadi.Size = new System.Drawing.Size(121, 26);
			this.txt_CodeEghtesadi.TabIndex = 3;
			this.txt_ShName.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ShName.Location = new System.Drawing.Point(794, 35);
			this.txt_ShName.Name = "txt_ShName";
			this.txt_ShName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ShName.Size = new System.Drawing.Size(227, 26);
			this.txt_ShName.TabIndex = 2;
			this.txt_ArzeshAfzoode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_ArzeshAfzoode.Location = new System.Drawing.Point(574, 35);
			this.txt_ArzeshAfzoode.Name = "txt_ArzeshAfzoode";
			this.txt_ArzeshAfzoode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ArzeshAfzoode.Size = new System.Drawing.Size(48, 26);
			this.txt_ArzeshAfzoode.TabIndex = 5;
			this.txt_AvarezShahrdari.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_AvarezShahrdari.Location = new System.Drawing.Point(623, 35);
			this.txt_AvarezShahrdari.Name = "txt_AvarezShahrdari";
			this.txt_AvarezShahrdari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_AvarezShahrdari.Size = new System.Drawing.Size(48, 26);
			this.txt_AvarezShahrdari.TabIndex = 4;
			this.txt_EsmRamzCode.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_EsmRamzCode.Location = new System.Drawing.Point(1022, 35);
			this.txt_EsmRamzCode.Name = "txt_EsmRamzCode";
			this.txt_EsmRamzCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_EsmRamzCode.Size = new System.Drawing.Size(59, 26);
			this.txt_EsmRamzCode.TabIndex = 1;
			this.Button2.BackColor = System.Drawing.Color.LightGray;
			this.Button2.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button2.ForeColor = System.Drawing.Color.Black;
			this.Button2.Location = new System.Drawing.Point(1506, 7);
			this.Button2.Name = "Button2";
			this.Button2.Size = new System.Drawing.Size(89, 21);
			this.Button2.TabIndex = 44;
			this.Button2.Text = "حذف فیلتر";
			this.Button2.UseVisualStyleBackColor = false;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Beige;
			base.ClientSize = new System.Drawing.Size(1194, 545);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Onvan);
			base.Controls.Add(this.btn_Save);
			base.Controls.Add(this.btn_Delete);
			base.Controls.Add(this.btn_Insert);
			base.Controls.Add(this.btn_Copy);
			base.Controls.Add(this.btn_Exit);
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.dtg_Onvan);
			base.Controls.Add(this.ShapeContainer2);
			base.Name = "frm_AsnadOnvan";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "عناوین ثابت اسناد";
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Onvan).EndInit();
			this.pnl_Onvan.ResumeLayout(false);
			this.pnl_Onvan.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox2).EndInit();
			base.ResumeLayout(false);

            this.txt_EsmRamzFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EsmRamzFltr_KeyDown);
            this.dtg_Onvan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Onvan_CellClick);
            this.dtg_Onvan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Onvan_CellContentClick);
            this.dtg_Onvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Onvan_KeyDown);
            this.dtg_Onvan.SelectionChanged += new System.EventHandler(this.dtg_Onvan_SelectionChanged);
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.txt_ArzeshAfzoodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ArzeshAfzoodeFltr_KeyDown);
            this.txt_AvarezShahrdariFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AvarezShahrdariFltr_KeyDown);
            this.txt_CodeEghtesadiFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CodeEghtesadiFltr_KeyDown);
            this.txt_ShNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ShNameFltr_KeyDown);
            this.txt_OnvanFactorFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OnvanFactorFltr_KeyDown);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.txt_SematFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SematFltr_KeyDown);
            this.txt_SahebEmzaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SahebEmzaFltr_KeyDown);
            this.cmbo_OnvanMabnaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_OnvanMabnaFltr_KeyDown);
            this.cmbo_OnvanMabna.GotFocus += new System.EventHandler(this.cmbo_OnvanMabna_GotFocus);
            this.cmbo_OnvanMabna.TextChanged += new System.EventHandler(this.cmbo_OnvanMabna_TextChanged);
            this.cmbo_OnvanMabna.SelectedIndexChanged += new System.EventHandler(this.cmbo_OnvanMabna_SelectedIndexChanged);
            this.txt_Semat.GotFocus += new System.EventHandler(this.txt_Semat_GotFocus);
            this.txt_Semat.TextChanged += new System.EventHandler(this.txt_Semat_TextChanged);
            this.txt_SahebEmza.GotFocus += new System.EventHandler(this.txt_SahebEmza_GotFocus);
            this.txt_SahebEmza.TextChanged += new System.EventHandler(this.txt_SahebEmza_TextChanged);
            this.txt_OnvanSanad.GotFocus += new System.EventHandler(this.txt_OnvanSanad_GotFocus);
            this.txt_OnvanSanad.TextChanged += new System.EventHandler(this.txt_OnvanFactor_TextChanged);
            this.txt_CodeEghtesadi.GotFocus += new System.EventHandler(this.txt_CodeEghtesadi_GotFocus);
            this.txt_CodeEghtesadi.TextChanged += new System.EventHandler(this.txt_EghtesadiCode_TextChanged);
            this.txt_ShName.GotFocus += new System.EventHandler(this.txt_ShName_GotFocus);
            this.txt_ShName.TextChanged += new System.EventHandler(this.txt_ShName_TextChanged);
            this.txt_ArzeshAfzoode.GotFocus += new System.EventHandler(this.txt_ArzeshAfzoode_GotFocus);
            this.txt_ArzeshAfzoode.TextChanged += new System.EventHandler(this.txt_ArzeshAfzoode_TextChanged);
            this.txt_AvarezShahrdari.TextChanged += new System.EventHandler(this.txt_AvarezShahrdari_TextChanged);
            this.txt_EsmRamzCode.GotFocus += new System.EventHandler(this.txt_EsmRamzCode_GotFocus);
            this.txt_EsmRamzCode.TextChanged += new System.EventHandler(this.txt_EsmRamz_TextChanged);
        }

		public void Load_dtg_AsnadOnvan()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[10];
			DtgOnvanRefresh = 0;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 9);
				if (Operators.CompareString(EsmRamz_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ShName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(ShName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(EghtesadiCode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(AvarezShahrdari_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(ArzeshAfzoode_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(OnvanFactor_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(MatnName_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(SahebEmza_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
				}
				if (Operators.CompareString(Semat_filter, "", TextCompare: false) != 0 && Operators.CompareString(OnvanMabna_filter, "", TextCompare: false) != 0)
				{
					array[9] = " And ";
				}
				Module1.strWhere = " WHERE " + EsmRamz_filter + array[1] + ShName_filter + array[2] + EghtesadiCode_filter + array[3] + AvarezShahrdari_filter + array[4] + ArzeshAfzoode_filter + array[5] + OnvanFactor_filter + array[6] + MatnName_filter + array[7] + SahebEmza_filter + array[8] + Semat_filter + array[9] + OnvanMabna_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				if (base.Visible)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [EsmRamz] As 'ردیف',[EsmRamz] As 'کد عنوان',[ShName] As 'نام شرکت',[CodeEghtesadi] As 'کد اقتصادی',[AvarezShahrdari] As 'عوارض شهرداری',[AvarezArzeshAfzoode] As 'ارزش افزوده',[OnvanSanad] As 'عنوان فاکتور',[NameAmel] As 'صاحب امضاء',[Semat] As 'سمت',[OnvanMabna] As 'مبنا'  FROM [dbo].[Moshakhasat] " + Module1.strWhere + " Order by [EsmRamz] ";
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
						if (Operators.CompareString(dataTable.Rows[i]["مبنا"].ToString(), "بلی", TextCompare: false) == 0)
						{
							MabnaEsmRamz = Conversions.ToString(dataTable.Rows[i]["کد عنوان"]);
						}
					}
					dtg_Onvan.DataSource = dataTable;
					dtg_Onvan.Columns[0].Width = 50;
					dtg_Onvan.Columns[1].Width = 60;
					dtg_Onvan.Columns[2].Width = 230;
					dtg_Onvan.Columns[3].Width = 120;
					dtg_Onvan.Columns[4].Width = 50;
					dtg_Onvan.Columns[5].Width = 50;
					dtg_Onvan.Columns[6].Width = 230;
					dtg_Onvan.Columns[7].Width = 150;
					dtg_Onvan.Columns[8].Width = 150;
					dtg_Onvan.Columns[9].Width = 44;
				}
				DtgOnvanRefresh = 1;
			}
		}

		private void frm_AsnadOnvan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void frm_AsnadAnavin_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmOnvanRefresh = 0;
			cmbo_OnvanMabna.Items.Clear();
			cmbo_OnvanMabna.Items.Add("بلی");
			cmbo_OnvanMabna.Items.Add("خیر");
			cmbo_OnvanMabnaFltr.Items.Clear();
			cmbo_OnvanMabnaFltr.Items.Add("بلی");
			cmbo_OnvanMabnaFltr.Items.Add("خیر");
			frmOnvanRefresh = 1;
			Load_dtg_AsnadOnvan();
			dtg_Onvan.CurrentCell = dtg_Onvan.Rows[0].Cells[1];
			ShowOnvanRecord();
			foreach (Control control in pnl_Onvan.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.KeyDown += GeneralKeyDownHandler1;
					control.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
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
			foreach (Control control in pnl_Onvan.Controls)
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
			checked
			{
				if (Operators.CompareString(txt_EsmRamzCode.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("کد عنوان را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_EsmRamzCode.Focus();
				}
				else
				{
					if (pnl_Onvan.BackColor == Color.Beige)
					{
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + txt_EsmRamzCode.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است کد جدید انتخاب کنید " + txt_EsmRamzCode.Text + " کد  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_EsmRamzCode.Text = "";
							txt_EsmRamzCode.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Moshakhasat] ([ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]) VALUES('" + txt_ShName.Text + "','" + txt_CodeEghtesadi.Text + "','" + txt_OnvanSanad.Text + "','" + txt_SahebEmza.Text + "','" + txt_EsmRamzCode.Text + "','','" + txt_AvarezShahrdari.Text + "','" + txt_ArzeshAfzoode.Text + "','" + txt_Semat.Text + "','" + cmbo_OnvanMabna.Text + "')";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'بلی'  WHERE [EsmRamz] = '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'خیر'  WHERE [EsmRamz] <> '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_OnvanBlue();
					}
					else
					{
						if (Operators.CompareString(txt_EsmRamzCode.Text, Module1.Onvan.EsmRamz, TextCompare: false) != 0)
						{
							Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + txt_EsmRamzCode.Text + "'";
							SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
							if (sqlDataReader.HasRows)
							{
								MessageBox.Show(".موجود است کد عنوان جدید انتخاب کنید " + txt_EsmRamzCode.Text + " کد عنوان  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
								txt_EsmRamzCode.Text = "";
								txt_EsmRamzCode.Focus();
								sqlDataReader.Close();
								return;
							}
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat] SET [EsmRamz] ='" + txt_EsmRamzCode.Text + "',[ShName] = '" + txt_ShName.Text + "',[CodeEghtesadi] ='" + txt_CodeEghtesadi.Text + "',[AvarezShahrdari] ='" + txt_AvarezShahrdari.Text + "',[AvarezArzeshAfzoode] ='" + txt_ArzeshAfzoode.Text + "',[OnvanSanad] ='" + txt_OnvanSanad.Text + "',[NameAmel] ='" + txt_SahebEmza.Text + "',[Semat] = '" + txt_Semat.Text + "',[OnvanMabna] = '" + cmbo_OnvanMabna.Text + "'WHERE EsmRamz = '" + txt_EsmRamzCode.Text + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'بلی'  WHERE [EsmRamz] = '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Moshakhasat]  SET [OnvanMabna] = 'خیر'  WHERE [EsmRamz] <> '" + MabnaEsmRamz + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_OnvanBlue();
					}
					text = txt_EsmRamzCode.Text;
					Load_dtg_AsnadOnvan();
					int num = dtg_Onvan.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Onvan.Rows[i].Cells[1].Value, text, TextCompare: false))
						{
							dtg_Onvan.CurrentCell = dtg_Onvan.Rows[i].Cells[0];
							ShowOnvanRecord();
						}
					}
				}
			}
		}

		private void SetPnl_OnvanBlue()
		{
			pnl_Onvan.BackColor = Color.Beige;
			foreach (object control in pnl_Onvan.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Onvan.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		public void ShowOnvanRecord()
		{
			int index = 0;
			Module1.DatePikerSit = false;
			int lErl = default(int);
			if (dtg_Onvan.RowCount != 0)
			{
				try
				{
					index = dtg_Onvan.CurrentRow.Index;
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					ProjectData.ClearProjectError();
				}
				Module1.Onvan.EsmRamz = Conversions.ToString(dtg_Onvan.Rows[index].Cells[1].Value);
				Module1.Onvan.ShName = Conversions.ToString(dtg_Onvan.Rows[index].Cells[2].Value);
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[3].Value)))
				{
					Module1.Onvan.CodeEghtesadi = "";
				}
				else
				{
					Module1.Onvan.CodeEghtesadi = Conversions.ToString(dtg_Onvan.Rows[index].Cells[3].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[4].Value)))
				{
					Module1.Onvan.AvarezShahrdari = "";
				}
				else
				{
					Module1.Onvan.AvarezShahrdari = Conversions.ToString(dtg_Onvan.Rows[index].Cells[4].Value);
				}
				if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(dtg_Onvan.Rows[index].Cells[5].Value)))
				{
					Module1.Onvan.AvarezArzeshAfzoode = "";
				}
				else
				{
					Module1.Onvan.AvarezArzeshAfzoode = Conversions.ToString(dtg_Onvan.Rows[index].Cells[5].Value);
				}
				Module1.Onvan.OnvanSanad = Conversions.ToString(dtg_Onvan.Rows[index].Cells[6].Value);
				Module1.Onvan.NameAmel = Conversions.ToString(dtg_Onvan.Rows[index].Cells[7].Value);
				Module1.Onvan.Semat = Conversions.ToString(dtg_Onvan.Rows[index].Cells[8].Value);
				Module1.Onvan.OnvanMabna = Conversions.ToString(dtg_Onvan.Rows[index].Cells[9].Value);
				txt_EsmRamzCode.Text = Module1.Onvan.EsmRamz;
				txt_ShName.Text = Module1.Onvan.ShName;
				txt_CodeEghtesadi.Text = Module1.Onvan.CodeEghtesadi;
				txt_AvarezShahrdari.Text = Module1.Onvan.AvarezShahrdari;
				txt_ArzeshAfzoode.Text = Module1.Onvan.AvarezArzeshAfzoode;
				txt_OnvanSanad.Text = Module1.Onvan.OnvanSanad;
				txt_SahebEmza.Text = Module1.Onvan.NameAmel;
				txt_Semat.Text = Module1.Onvan.Semat;
				cmbo_OnvanMabna.Text = Module1.Onvan.OnvanMabna;
			}
			lErl = 60;
		}

		private void dtg_Onvan_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			ShowOnvanRecord();
		}

		private void dtg_Onvan_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowOnvanRecord();
		}

		private void dtg_Onvan_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
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
				txt_EsmRamzCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Onvan_SelectionChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh == 0)
			{
				return;
			}
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Onvan.BackColor == Color.LightPink) & (frmOnvanRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات عناوین ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_OnvanBlue();
					break;
				case DialogResult.No:
					SetPnl_OnvanBlue();
					break;
				case DialogResult.Cancel:
					txt_EsmRamzCode.Focus();
					return;
				}
			}
			if (DtgOnvanRefresh == 1)
			{
				ShowOnvanRecord();
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			if (Module1.FromAsnadList == 1)
			{
				MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Focus();
				MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Text = txt_EsmRamzCode.Text;
				Module1.FromAsnadList = 0;
			}
			Close();
		}

		private void CheckOnvanChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Onvan.BackColor = Color.Tan;
			foreach (object control in pnl_Onvan.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Onvan.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Onvan.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Onvan.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void txt_EsmRamzCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_OnvanMabna_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_OnvanMabna_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OnvanMabna.Text.Trim(), Module1.Onvan.OnvanMabna.Trim(), TextCompare: false) != 0)
			{
				cmbo_OnvanMabna.ForeColor = Color.Red;
			}
			else
			{
				cmbo_OnvanMabna.ForeColor = Color.Black;
			}
			CheckOnvanChange();
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Onvan.BackColor == Color.LightPink)
			{
				dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Onvan.BackColor = Color.LightPink;
			txt_EsmRamzCode.Text = "";
			txt_ShName.Text = "";
			txt_CodeEghtesadi.Text = "";
			txt_AvarezShahrdari.Text = "";
			txt_ArzeshAfzoode.Text = "";
			txt_OnvanSanad.Text = "";
			txt_SahebEmza.Text = "";
			txt_Semat.Text = "";
			cmbo_OnvanMabna.Text = "خیر";
		}

		private void btn_Copy_Click(object sender, EventArgs e)
		{
			string text = txt_EsmRamzCode.Text;
			BtnCommand = "Copy";
			if (pnl_Onvan.BackColor == Color.LightPink)
			{
				dtg_Onvan_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text2 = Interaction.InputBox("  کپی کد عنوان " + Module1.Onvan.EsmRamz + " با چه کدی انجام شود؟ ", " ");
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
			Module1.cmd.CommandText = "SELECT [EsmRamz] FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + text2 + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show("کد " + text2 + " موجود است کد جدید انتخاب کنید  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Moshakhasat]([ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]) (Select [ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],'" + text2 + "'[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna]FROM [dbo].[Moshakhasat] Where [EsmRamz]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_AsnadOnvan();
			checked
			{
				int num = dtg_Onvan.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Onvan.Rows[i].Cells[1].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Onvan.CurrentCell = dtg_Onvan.Rows[i].Cells[0];
						ShowOnvanRecord();
						break;
					}
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_EsmRamzCode.Text;
			int index = dtg_Onvan.CurrentRow.Index;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Onvan.RowCount - 1 == 0)
				{
					MessageBox.Show(".امکان حذف نیست حداقل یک عنوان بایستی موجود باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					int index2 = dtg_Onvan.CurrentRow.Index;
					if (MessageBox.Show(" کد  " + txt_EsmRamzCode.Text + " حذف شود؟  ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
					{
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE OnvanCode = '" + text + "'";
						SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show("هستند بایستی حذف شوند. " + text + " ابتدا سند هایی که مرتبط به کد ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							return;
						}
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						sqlCommand.Connection = Module1.MyConn;
						sqlCommand.CommandText = "DELETE FROM [dbo].[Moshakhasat] WHERE [EsmRamz] = '" + text + "'";
						sqlCommand.ExecuteNonQuery();
						Module1.MyConn.Close();
					}
				}
				Load_dtg_AsnadOnvan();
				if (index != 0)
				{
					dtg_Onvan.CurrentCell = dtg_Onvan.Rows[index - 1].Cells[0];
				}
				else
				{
					dtg_Onvan.CurrentCell = dtg_Onvan.Rows[index].Cells[0];
				}
				ShowOnvanRecord();
			}
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			txt_EsmRamzFltr.Text = "";
			txt_ShNameFltr.Text = Module1.NoaSanad;
			txt_CodeEghtesadiFltr.Text = "";
			txt_AvarezShahrdariFltr.Text = "";
			txt_ArzeshAfzoodeFltr.Text = "";
			txt_OnvanFactorFltr.Text = "";
			txt_SahebEmzaFltr.Text = "";
			txt_SematFltr.Text = "";
			cmbo_OnvanMabnaFltr.Text = "";
			frm_AsnadAnavin_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void txt_EsmRamz_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_EsmRamzCode.Text.Trim()), Module1.PerToArb(Module1.Onvan.EsmRamz.Trim()), TextCompare: false) != 0)
				{
					txt_EsmRamzCode.ForeColor = Color.Red;
				}
				else
				{
					txt_EsmRamzCode.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_ShName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ShName_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_ShName.Text.Trim()), Module1.PerToArb(Module1.Onvan.ShName.Trim()), TextCompare: false) != 0)
				{
					txt_ShName.ForeColor = Color.Red;
				}
				else
				{
					txt_ShName.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_CodeEghtesadi_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_EghtesadiCode_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_CodeEghtesadi.Text.Trim()), Module1.PerToArb(Module1.Onvan.CodeEghtesadi.Trim()), TextCompare: false) != 0)
				{
					txt_CodeEghtesadi.ForeColor = Color.Red;
				}
				else
				{
					txt_CodeEghtesadi.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_AvarezShahrdari_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_AvarezShahrdari.Text.Trim()), Module1.PerToArb(Module1.Onvan.AvarezShahrdari.Trim()), TextCompare: false) != 0)
				{
					txt_AvarezShahrdari.ForeColor = Color.Red;
				}
				else
				{
					txt_AvarezShahrdari.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_ArzeshAfzoode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ArzeshAfzoode_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_ArzeshAfzoode.Text.Trim()), Module1.PerToArb(Module1.Onvan.AvarezArzeshAfzoode.Trim()), TextCompare: false) != 0)
				{
					txt_ArzeshAfzoode.ForeColor = Color.Red;
				}
				else
				{
					txt_ArzeshAfzoode.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_OnvanSanad_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_OnvanFactor_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_OnvanSanad.Text).Trim(), Module1.PerToArb(Module1.Onvan.OnvanSanad).Trim(), TextCompare: false) != 0)
				{
					txt_OnvanSanad.ForeColor = Color.Red;
				}
				else
				{
					txt_OnvanSanad.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_SahebEmza_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_SahebEmza_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_SahebEmza.Text).Trim(), Module1.PerToArb(Module1.Onvan.NameAmel).Trim(), TextCompare: false) != 0)
				{
					txt_SahebEmza.ForeColor = Color.Red;
				}
				else
				{
					txt_SahebEmza.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_Semat_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_Semat_TextChanged(object sender, EventArgs e)
		{
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(txt_Semat.Text).Trim(), Module1.PerToArb(Module1.Onvan.Semat).Trim(), TextCompare: false) != 0)
				{
					txt_Semat.ForeColor = Color.Red;
				}
				else
				{
					txt_Semat.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void cmbo_OnvanMabna_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_OnvanMabna.Text, "بلی", TextCompare: false) == 0)
			{
				MabnaEsmRamz = txt_EsmRamzCode.Text;
			}
			if (frmOnvanRefresh != 0)
			{
				if (Operators.CompareString(Module1.PerToArb(cmbo_OnvanMabna.Text).Trim(), Module1.PerToArb(Module1.Onvan.Semat).Trim(), TextCompare: false) != 0)
				{
					cmbo_OnvanMabna.ForeColor = Color.Red;
				}
				else
				{
					cmbo_OnvanMabna.ForeColor = Color.Black;
				}
				CheckOnvanChange();
			}
		}

		private void txt_EsmRamzFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_EsmRamzFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_EsmRamzFltr.Text);
					EsmRamz_filter = " ([EsmRamz] Like N'%" + text + "%')";
				}
				else
				{
					EsmRamz_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_ShNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ShNameFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_ShNameFltr.Text);
					ShName_filter = " (REPLACE(REPLACE([ShName],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ShName_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_CodeEghtesadiFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_CodeEghtesadiFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_CodeEghtesadiFltr.Text);
					EghtesadiCode_filter = " ([CodeEghtesadi] Like N'%" + text + "%')";
				}
				else
				{
					EghtesadiCode_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_AvarezShahrdariFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_AvarezShahrdariFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_AvarezShahrdariFltr.Text);
					AvarezShahrdari_filter = " ([AvarezShahrdari] Like N'%" + text + "%')";
				}
				else
				{
					AvarezShahrdari_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_ArzeshAfzoodeFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ArzeshAfzoodeFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_ArzeshAfzoodeFltr.Text);
					ArzeshAfzoode_filter = " ([AvarezArzeshAfzoode] Like N'%" + text + "%')";
				}
				else
				{
					ArzeshAfzoode_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_OnvanFactorFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_OnvanFactorFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_OnvanFactorFltr.Text);
					OnvanFactor_filter = " (REPLACE(REPLACE([OnvanSanad],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					OnvanFactor_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_SahebEmzaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SahebEmzaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_SahebEmzaFltr.Text);
					SahebEmza_filter = " (REPLACE(REPLACE([NameAmel],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					SahebEmza_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void txt_SematFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SematFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = Module1.PerToArb(txt_SematFltr.Text);
					Semat_filter = " (REPLACE(REPLACE([Semat],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Semat_filter = "";
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}

		private void cmbo_OnvanMabnaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				string text = Module1.PerToArb(cmbo_OnvanMabnaFltr.Text);
				switch (text)
				{
				case "Null":
					OnvanMabna_filter = " ([OnvanMabna] is Null)";
					break;
				case null:
				case "":
					OnvanMabna_filter = "";
					break;
				default:
					OnvanMabna_filter = " (REPLACE(REPLACE([OnvanMabna],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
					break;
				}
				Load_dtg_AsnadOnvan();
				ShowOnvanRecord();
			}
		}
	}
}
