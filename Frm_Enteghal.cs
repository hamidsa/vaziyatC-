using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class Frm_Enteghal : Form
	{
		private IContainer components;


		private string OnvanMabna;

		private string SalMali_filter;

		private string SanadNo_filter;

		private string NoaSanad_filter;

		private string JobNo_filter;

		private string SanadDate_filter;

		private string Project_filter;

		private string Karfarma_filter;

		private string Baha_filter;

		private string Amaliat_filter;

		private string Comment_filter;

		private string Fehrest_filter;

		private string FehrestCode_filter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.ComboBox cmbo_SalMaliFltr;
        private System.Windows.Forms.ComboBox cmbo_FehrestFltr;
        private System.Windows.Forms.ComboBox cmbo_NoaSanadFltr;
        private System.Windows.Forms.TextBox txt_CommentFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaFltr;
        private System.Windows.Forms.TextBox txt_ProjectFltr;
        private System.Windows.Forms.TextBox txt_SanadDateFltr;
        private System.Windows.Forms.TextBox txt_JobNoFltr;
        private System.Windows.Forms.TextBox txt_SanadNoFltr;
        private System.Windows.Forms.TextBox txt_BahaFltr;
        private System.Windows.Forms.TextBox txt_AmaliatFltr;
        private System.Windows.Forms.DataGridView dtg_AsnadList;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Label lbl_AsnadSum;
        private System.Windows.Forms.Label lbl_AsnadNum;
        private System.Windows.Forms.Label Label26;
        private System.Windows.Forms.Label Label28;
        private System.Windows.Forms.Button btn_Cansel;
        private System.Windows.Forms.Button btn_ImportSelect;
        public Frm_Enteghal()
		{
			base.Load += Frm_Enteghal_Load;
			OnvanMabna = "";
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.pnl_Filter = new System.Windows.Forms.Panel();
            this.Label10 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbo_SalMaliFltr = new System.Windows.Forms.ComboBox();
            this.cmbo_FehrestFltr = new System.Windows.Forms.ComboBox();
            this.cmbo_NoaSanadFltr = new System.Windows.Forms.ComboBox();
            this.txt_CommentFltr = new System.Windows.Forms.TextBox();
            this.txt_KarfarmaFltr = new System.Windows.Forms.TextBox();
            this.txt_ProjectFltr = new System.Windows.Forms.TextBox();
            this.txt_SanadDateFltr = new System.Windows.Forms.TextBox();
            this.txt_JobNoFltr = new System.Windows.Forms.TextBox();
            this.txt_SanadNoFltr = new System.Windows.Forms.TextBox();
            this.txt_BahaFltr = new System.Windows.Forms.TextBox();
            this.txt_AmaliatFltr = new System.Windows.Forms.TextBox();
            this.dtg_AsnadList = new System.Windows.Forms.DataGridView();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lbl_AsnadSum = new System.Windows.Forms.Label();
            this.lbl_AsnadNum = new System.Windows.Forms.Label();
            this.Label26 = new System.Windows.Forms.Label();
            this.Label28 = new System.Windows.Forms.Label();
            this.btn_Cansel = new System.Windows.Forms.Button();
            this.btn_ImportSelect = new System.Windows.Forms.Button();
            this.pnl_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AsnadList)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Filter.ForeColor = System.Drawing.Color.Black;
            this.btn_Filter.Location = new System.Drawing.Point(1491, 2);
            this.btn_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(55, 73);
            this.btn_Filter.TabIndex = 151;
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.BackColor = System.Drawing.Color.White;
            this.pnl_Filter.Controls.Add(this.btn_Filter);
            this.pnl_Filter.Controls.Add(this.Label10);
            this.pnl_Filter.Controls.Add(this.PictureBox1);
            this.pnl_Filter.Controls.Add(this.cmbo_SalMaliFltr);
            this.pnl_Filter.Controls.Add(this.cmbo_FehrestFltr);
            this.pnl_Filter.Controls.Add(this.cmbo_NoaSanadFltr);
            this.pnl_Filter.Controls.Add(this.txt_CommentFltr);
            this.pnl_Filter.Controls.Add(this.txt_KarfarmaFltr);
            this.pnl_Filter.Controls.Add(this.txt_ProjectFltr);
            this.pnl_Filter.Controls.Add(this.txt_SanadDateFltr);
            this.pnl_Filter.Controls.Add(this.txt_JobNoFltr);
            this.pnl_Filter.Controls.Add(this.txt_SanadNoFltr);
            this.pnl_Filter.Controls.Add(this.txt_BahaFltr);
            this.pnl_Filter.Controls.Add(this.txt_AmaliatFltr);
            this.pnl_Filter.Location = new System.Drawing.Point(31, 30);
            this.pnl_Filter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Size = new System.Drawing.Size(1549, 76);
            this.pnl_Filter.TabIndex = 150;
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Location = new System.Drawing.Point(1444, 1);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(46, 73);
            this.Label10.TabIndex = 154;
            this.Label10.Text = "ردیف";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(3, 1);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1547, 39);
            this.PictureBox1.TabIndex = 156;
            this.PictureBox1.TabStop = false;
            // 
            // cmbo_SalMaliFltr
            // 
            this.cmbo_SalMaliFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_SalMaliFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_SalMaliFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_SalMaliFltr.FormattingEnabled = true;
            this.cmbo_SalMaliFltr.Location = new System.Drawing.Point(1321, 43);
            this.cmbo_SalMaliFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbo_SalMaliFltr.Name = "cmbo_SalMaliFltr";
            this.cmbo_SalMaliFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_SalMaliFltr.Size = new System.Drawing.Size(53, 26);
            this.cmbo_SalMaliFltr.TabIndex = 155;
            this.cmbo_SalMaliFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_SalMaliFltr_SelectedIndexChanged);
            // 
            // cmbo_FehrestFltr
            // 
            this.cmbo_FehrestFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_FehrestFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_FehrestFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_FehrestFltr.FormattingEnabled = true;
            this.cmbo_FehrestFltr.Location = new System.Drawing.Point(1, 43);
            this.cmbo_FehrestFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbo_FehrestFltr.Name = "cmbo_FehrestFltr";
            this.cmbo_FehrestFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_FehrestFltr.Size = new System.Drawing.Size(129, 26);
            this.cmbo_FehrestFltr.TabIndex = 86;
            this.cmbo_FehrestFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestFltr_SelectedIndexChanged);
            // 
            // cmbo_NoaSanadFltr
            // 
            this.cmbo_NoaSanadFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_NoaSanadFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_NoaSanadFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_NoaSanadFltr.FormattingEnabled = true;
            this.cmbo_NoaSanadFltr.Location = new System.Drawing.Point(1377, 43);
            this.cmbo_NoaSanadFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbo_NoaSanadFltr.Name = "cmbo_NoaSanadFltr";
            this.cmbo_NoaSanadFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_NoaSanadFltr.Size = new System.Drawing.Size(64, 26);
            this.cmbo_NoaSanadFltr.TabIndex = 73;
            this.cmbo_NoaSanadFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_NoaSanadFltr_SelectedIndexChanged);
            // 
            // txt_CommentFltr
            // 
            this.txt_CommentFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_CommentFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_CommentFltr.Location = new System.Drawing.Point(133, 43);
            this.txt_CommentFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CommentFltr.Name = "txt_CommentFltr";
            this.txt_CommentFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CommentFltr.Size = new System.Drawing.Size(199, 24);
            this.txt_CommentFltr.TabIndex = 57;
            this.txt_CommentFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CommentFltr_KeyDown);
            // 
            // txt_KarfarmaFltr
            // 
            this.txt_KarfarmaFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_KarfarmaFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaFltr.Location = new System.Drawing.Point(668, 43);
            this.txt_KarfarmaFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_KarfarmaFltr.Name = "txt_KarfarmaFltr";
            this.txt_KarfarmaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaFltr.Size = new System.Drawing.Size(219, 24);
            this.txt_KarfarmaFltr.TabIndex = 55;
            this.txt_KarfarmaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaFltr_KeyDown);
            // 
            // txt_ProjectFltr
            // 
            this.txt_ProjectFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ProjectFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ProjectFltr.Location = new System.Drawing.Point(889, 43);
            this.txt_ProjectFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_ProjectFltr.Name = "txt_ProjectFltr";
            this.txt_ProjectFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ProjectFltr.Size = new System.Drawing.Size(215, 24);
            this.txt_ProjectFltr.TabIndex = 54;
            this.txt_ProjectFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ProjectFltr_KeyDown);
            // 
            // txt_SanadDateFltr
            // 
            this.txt_SanadDateFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SanadDateFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_SanadDateFltr.Location = new System.Drawing.Point(1107, 43);
            this.txt_SanadDateFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SanadDateFltr.Name = "txt_SanadDateFltr";
            this.txt_SanadDateFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SanadDateFltr.Size = new System.Drawing.Size(65, 24);
            this.txt_SanadDateFltr.TabIndex = 53;
            this.txt_SanadDateFltr.TextChanged += new System.EventHandler(this.txt_SanadDateFltr_TextChanged);
            this.txt_SanadDateFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SanadDateFltr_KeyDown);
            // 
            // txt_JobNoFltr
            // 
            this.txt_JobNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_JobNoFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_JobNoFltr.Location = new System.Drawing.Point(1175, 43);
            this.txt_JobNoFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_JobNoFltr.Name = "txt_JobNoFltr";
            this.txt_JobNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_JobNoFltr.Size = new System.Drawing.Size(63, 24);
            this.txt_JobNoFltr.TabIndex = 50;
            this.txt_JobNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_JobNoFltr_KeyDown);
            // 
            // txt_SanadNoFltr
            // 
            this.txt_SanadNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_SanadNoFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_SanadNoFltr.Location = new System.Drawing.Point(1240, 43);
            this.txt_SanadNoFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SanadNoFltr.Name = "txt_SanadNoFltr";
            this.txt_SanadNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SanadNoFltr.Size = new System.Drawing.Size(79, 24);
            this.txt_SanadNoFltr.TabIndex = 54;
            this.txt_SanadNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SanadNoFltr_KeyDown);
            // 
            // txt_BahaFltr
            // 
            this.txt_BahaFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_BahaFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_BahaFltr.Location = new System.Drawing.Point(535, 43);
            this.txt_BahaFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_BahaFltr.Name = "txt_BahaFltr";
            this.txt_BahaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_BahaFltr.Size = new System.Drawing.Size(131, 24);
            this.txt_BahaFltr.TabIndex = 47;
            this.txt_BahaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_BahaFltr_KeyDown);
            // 
            // txt_AmaliatFltr
            // 
            this.txt_AmaliatFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_AmaliatFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_AmaliatFltr.Location = new System.Drawing.Point(335, 43);
            this.txt_AmaliatFltr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_AmaliatFltr.Name = "txt_AmaliatFltr";
            this.txt_AmaliatFltr.Size = new System.Drawing.Size(197, 24);
            this.txt_AmaliatFltr.TabIndex = 48;
            this.txt_AmaliatFltr.TextChanged += new System.EventHandler(this.txt_AmaliatFltr_TextChanged);
            // 
            // dtg_AsnadList
            // 
            this.dtg_AsnadList.AllowUserToAddRows = false;
            this.dtg_AsnadList.AllowUserToDeleteRows = false;
            this.dtg_AsnadList.AllowUserToOrderColumns = true;
            this.dtg_AsnadList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_AsnadList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AsnadList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_AsnadList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_AsnadList.Location = new System.Drawing.Point(7, 62);
            this.dtg_AsnadList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtg_AsnadList.MultiSelect = false;
            this.dtg_AsnadList.Name = "dtg_AsnadList";
            this.dtg_AsnadList.ReadOnly = true;
            this.dtg_AsnadList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_AsnadList.RowHeadersWidth = 51;
            this.dtg_AsnadList.RowTemplate.Height = 44;
            this.dtg_AsnadList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_AsnadList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_AsnadList.Size = new System.Drawing.Size(1573, 609);
            this.dtg_AsnadList.StandardTab = true;
            this.dtg_AsnadList.TabIndex = 149;
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.lbl_AsnadSum);
            this.Panel1.Controls.Add(this.lbl_AsnadNum);
            this.Panel1.Controls.Add(this.Label26);
            this.Panel1.Controls.Add(this.Label28);
            this.Panel1.Location = new System.Drawing.Point(7, 673);
            this.Panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(1573, 34);
            this.Panel1.TabIndex = 152;
            // 
            // lbl_AsnadSum
            // 
            this.lbl_AsnadSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_AsnadSum.ForeColor = System.Drawing.Color.Black;
            this.lbl_AsnadSum.Location = new System.Drawing.Point(153, 5);
            this.lbl_AsnadSum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AsnadSum.Name = "lbl_AsnadSum";
            this.lbl_AsnadSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_AsnadSum.Size = new System.Drawing.Size(199, 25);
            this.lbl_AsnadSum.TabIndex = 46;
            this.lbl_AsnadSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_AsnadNum
            // 
            this.lbl_AsnadNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_AsnadNum.ForeColor = System.Drawing.Color.Black;
            this.lbl_AsnadNum.Location = new System.Drawing.Point(1095, 4);
            this.lbl_AsnadNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_AsnadNum.Name = "lbl_AsnadNum";
            this.lbl_AsnadNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_AsnadNum.Size = new System.Drawing.Size(157, 25);
            this.lbl_AsnadNum.TabIndex = 44;
            this.lbl_AsnadNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label26
            // 
            this.Label26.AutoSize = true;
            this.Label26.ForeColor = System.Drawing.Color.Black;
            this.Label26.Location = new System.Drawing.Point(357, 7);
            this.Label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label26.Name = "Label26";
            this.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label26.Size = new System.Drawing.Size(88, 16);
            this.Label26.TabIndex = 42;
            this.Label26.Text = ": جمع مبلغ اسناد";
            // 
            // Label28
            // 
            this.Label28.AutoSize = true;
            this.Label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Label28.ForeColor = System.Drawing.Color.Black;
            this.Label28.Location = new System.Drawing.Point(1259, 6);
            this.Label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label28.Name = "Label28";
            this.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label28.Size = new System.Drawing.Size(63, 17);
            this.Label28.TabIndex = 40;
            this.Label28.Text = ": تعداد اسناد";
            // 
            // btn_Cansel
            // 
            this.btn_Cansel.Location = new System.Drawing.Point(308, 730);
            this.btn_Cansel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Cansel.Name = "btn_Cansel";
            this.btn_Cansel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Cansel.Size = new System.Drawing.Size(167, 37);
            this.btn_Cansel.TabIndex = 154;
            this.btn_Cansel.Text = "انصراف";
            this.btn_Cansel.UseVisualStyleBackColor = true;
            this.btn_Cansel.Click += new System.EventHandler(this.btn_Cansel_Click);
            // 
            // btn_ImportSelect
            // 
            this.btn_ImportSelect.Location = new System.Drawing.Point(1136, 730);
            this.btn_ImportSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ImportSelect.Name = "btn_ImportSelect";
            this.btn_ImportSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_ImportSelect.Size = new System.Drawing.Size(167, 37);
            this.btn_ImportSelect.TabIndex = 153;
            this.btn_ImportSelect.Text = "انتقال ";
            this.btn_ImportSelect.UseVisualStyleBackColor = true;
            this.btn_ImportSelect.Click += new System.EventHandler(this.btn_ImportSelect_Click);
            // 
            // Frm_Enteghal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1589, 798);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Cansel);
            this.Controls.Add(this.btn_ImportSelect);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.pnl_Filter);
            this.Controls.Add(this.dtg_AsnadList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_Enteghal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AsnadList)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

		private void Frm_Enteghal_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			Module1.SanadRecordRefresh = 0;
			Load_Cmbo1(cmbo_SalMaliFltr, "asnad1", "Salmali", "");
			cmbo_SalMaliFltr.Items.Add(" ");
			Load_Cmbo1(cmbo_FehrestFltr, "fehrest", "fehrest", "");
			cmbo_FehrestFltr.Items.Add(" ");
			Module1.MyConn1.Close();
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad2] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Soori] = '0' WHERE [Soori]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.cmd.CommandText = "UPDATE [dbo].[asnad4] SET [Ghaleb] = '0' WHERE [Ghaleb]  is null";
			Module1.cmd.ExecuteNonQuery();
			Module1.MyConn1.Close();
			Module1.BtnCommand = "";
			Module1.BtnProjectList = false;
			Module1.BtnKarfarmaList = false;
			cmbo_NoaSanadFltr.Items.Clear();
			cmbo_NoaSanadFltr.Items.Add("فاکتور");
			cmbo_NoaSanadFltr.Items.Add("پیش فاکتور");
			cmbo_NoaSanadFltr.Items.Add("صوری");
			cmbo_NoaSanadFltr.Items.Add("قالب");
			cmbo_NoaSanadFltr.Items.Add(" ");
			cmbo_NoaSanadFltr.Text = Module1.NoaSanad;
			switch (Module1.NoaSanad)
			{
			case "فاکتور":
				NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
				Module1.forpf = true;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "پیش فاکتور":
				NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
				Module1.forpf = false;
				Module1.soori = 0;
				Module1.Ghaleb = 0;
				break;
			case "صوری":
				NoaSanad_filter = " ([Soori] = '1' And [Ghaleb] = '0')";
				Module1.soori = 1;
				Module1.Ghaleb = 0;
				break;
			case "قالب":
				NoaSanad_filter = " ([Soori] = '0' And [Ghaleb] = '1')";
				Module1.Ghaleb = 1;
				Module1.soori = 0;
				break;
			}
			cmbo_SalMaliFltr.SelectedIndex = checked(cmbo_SalMaliFltr.Items.Count - 2);
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
			Module1.cmd.CommandText = "SELECT [EsmRamz], REPLACE(REPLACE([OnvanMabna],'ي',N'ی'),'ك',N'ک') FROM [dbo].[Moshakhasat] ";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[1])) && Operators.CompareString(Module1.ArbToPer(Conversions.ToString(sqlDataReader[1])), "بلی", TextCompare: false) == 0)
				{
					OnvanMabna = Conversions.ToString(sqlDataReader[0]);
				}
			}
			cmbo_FehrestFltr.Text = "";
			sqlDataReader.Close();
			Load_dtg_AsnadList();
		}

		public void Load_dtg_AsnadList()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[11];
			Module1.SanadRecordRefresh = 0;
			int lErl = default(int);
			try
			{
				Module1.CurrRow = dtg_AsnadList.CurrentRow.Index;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				ProjectData.ClearProjectError();
			}
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 10);
				if (Operators.CompareString(SalMali_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SanadNo_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(SanadNo_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(NoaSanad_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(JobNo_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(SanadDate_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Project_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Karfarma_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Baha_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Amaliat_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
				}
				if (Operators.CompareString(Comment_filter, "", TextCompare: false) != 0 && Operators.CompareString(Fehrest_filter, "", TextCompare: false) != 0)
				{
					array[10] = " And ";
				}
				Module1.strWhere = " WHERE " + SalMali_filter + array[1] + SanadNo_filter + array[2] + NoaSanad_filter + array[3] + JobNo_filter + array[4] + SanadDate_filter + array[5] + Project_filter + array[6] + Karfarma_filter + array[7] + Baha_filter + array[8] + Amaliat_filter + array[9] + Comment_filter + array[10] + Fehrest_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				string text = ((Operators.CompareString(Module1.NoaSanad, "قالب", TextCompare: false) != 0) ? "  order by [sanadnum] desc" : "  order by [sanadnum]");
				Module1.MyConn1.Close();
				lErl = 10;
				if (Module1.MyConn1.State == ConnectionState.Closed)
				{
					Module1.MyConn1.Open();
				}
				Module1.cmd.Connection = Module1.MyConn1;
				Module1.cmd.CommandText = "SELECT DISTINCT [recnum] As 'recnum',[recnum] As 'ردیف', Cast([forpf] As Nvarchar(20)) As 'نوع سند', [Salmali] As 'سال مالی', [sanadnum] As 'شماره سند',[karnum] As 'شماره کار',[sanaddatey] + '/' + [sanaddatem] + '/' + [sanaddated]  As 'تاریخ', [asnad1].[pkod] As 'کد پروژه', [asnad1].[forpf],REPLACE(REPLACE([pname1],'ي',N'ی'),'ك',N'ک') As 'پروژه', [karkod1] As 'کد کارفرما', REPLACE(REPLACE([karname1],'ي',N'ی'),'ك',N'ک') As 'کارفرما',Cast([mablaghk] As Decimal(18,0)) As 'مبلغ',[etproj].[bakhshkod] As 'کد بخش',REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') As 'موضوع سند', REPLACE(REPLACE([Pname2],'ي',N'ی'),'ك',N'ک') As 'توضیحات', [fehrestfile] As 'فایل فهرست بها', OnvanCode As 'کد عنوان',REPLACE(REPLACE([asnad1].[fehrest],'ي',N'ی'),'ك',N'ک') As 'فهرست بها',REPLACE(REPLACE([Nameh],'ي',N'ی'),'ك',N'ک') As 'نامه', [Printed] As 'پرینت', [IjadSystem] As 'ایجاد کننده', [TimeIjad] As 'تاریخ ایجاد', [EslahSystem] As 'اصلاح کننده', [TimeEslah] As 'تاریخ اصلاح', Cast([Soori] As Nvarchar(20)) As 'صوری', Cast([Ghaleb] As Nvarchar(20)) As 'قالب' FROM [dbo].[asnad1] INNER JOIN [etproj] ON [asnad1].[pkod]=[etproj].[pkod] And [asnad1].[fehrestfile]=[etproj].[fehrest]" + Module1.strWhere + text;
				lErl = 1;
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				dataTable.Load(sqlDataReader);
				sqlDataReader.Close();
				Module1.MyConn1.Close();
				foreach (DataColumn column in dataTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["نوع سند"], "1", TextCompare: false))
					{
						dataTable.Rows[i]["نوع سند"] = "فاکتور";
						Module1.NoaSanad = "فاکتور";
					}
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["نوع سند"], "0", TextCompare: false))
					{
						dataTable.Rows[i]["نوع سند"] = "پیش فاکتور";
						Module1.NoaSanad = "پیش فاکتور";
					}
					if (Operators.CompareString(dataTable.Rows[i]["صوری"].ToString(), "1", TextCompare: false) == 0)
					{
						dataTable.Rows[i]["نوع سند"] = "صوری";
						Module1.NoaSanad = "صوری";
					}
					if (Operators.CompareString(dataTable.Rows[i]["قالب"].ToString(), "1", TextCompare: false) == 0)
					{
						dataTable.Rows[i]["نوع سند"] = "قالب";
						Module1.NoaSanad = "قالب";
					}
				}
				dtg_AsnadList.DataSource = null;
				dtg_AsnadList.DataSource = dataTable;
				dtg_AsnadList.Columns[1].DefaultCellStyle.Format = "##,0";
				dtg_AsnadList.Columns[11].DefaultCellStyle.Format = "##,0";
				dtg_AsnadList.Columns[0].Visible = false;
				dtg_AsnadList.Columns[1].Width = 40;
				dtg_AsnadList.Columns[2].Width = 50;
				dtg_AsnadList.Columns[3].Width = 40;
				dtg_AsnadList.Columns[4].Width = 60;
				dtg_AsnadList.Columns[5].Width = 50;
				dtg_AsnadList.Columns[6].Width = 50;
				dtg_AsnadList.Columns[7].Visible = false;
				dtg_AsnadList.Columns[8].Visible = false;
				dtg_AsnadList.Columns[9].Width = 165;
				dtg_AsnadList.Columns[10].Visible = false;
				dtg_AsnadList.Columns[11].Width = 165;
				dtg_AsnadList.Columns[12].Width = 100;
				dtg_AsnadList.Columns[13].Visible = false;
				dtg_AsnadList.Columns[14].Width = 150;
				dtg_AsnadList.Columns[15].Width = 150;
				dtg_AsnadList.Columns[16].Visible = false;
				dtg_AsnadList.Columns[17].Visible = false;
				dtg_AsnadList.Columns[18].Width = 100;
				dtg_AsnadList.Columns[19].Visible = false;
				dtg_AsnadList.Columns[20].Visible = false;
				dtg_AsnadList.Columns[21].Visible = false;
				dtg_AsnadList.Columns[22].Visible = false;
				dtg_AsnadList.Columns[23].Visible = false;
				dtg_AsnadList.Columns[24].Visible = false;
				dtg_AsnadList.Columns[25].Visible = false;
				dtg_AsnadList.Columns[26].Visible = false;
				Module1.dtg_Color(dtg_AsnadList);
				lbl_AsnadNum.Text = Strings.Format(dtg_AsnadList.RowCount, "##,0");
				decimal num3 = default(decimal);
				foreach (DataGridViewRow item in (IEnumerable)dtg_AsnadList.Rows)
				{
					num3 = new decimal(Convert.ToDouble(num3) + Conversion.Val(RuntimeHelpers.GetObjectValue(item.Cells[12].Value)));
				}
				lbl_AsnadSum.Text = Strings.Format(num3, "##,0");
				Module1.SanadRecordRefresh = 1;
				try
				{
					dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
				}
				catch (Exception ex2)
				{
					ProjectData.SetProjectError(ex2, lErl);
					Module1.CurrRow = 0;
					ProjectData.ClearProjectError();
					goto IL_107e;
				}
				goto IL_10bd;
			}
			IL_107e:
			try
			{
				dtg_AsnadList.CurrentCell = dtg_AsnadList.Rows[Module1.CurrRow].Cells[1];
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
			goto IL_10bd;
			IL_10bd:
			lErl = 20;
		}

		private void btn_Filter_Click(object sender, EventArgs e)
		{
			if (!pnl_Filter.Visible)
			{
				pnl_Filter.Visible = true;
				return;
			}
			pnl_Filter.Visible = false;
			txt_SanadNoFltr.Text = "";
			cmbo_NoaSanadFltr.Text = Module1.NoaSanad;
			txt_JobNoFltr.Text = "";
			txt_SanadDateFltr.Text = "";
			txt_ProjectFltr.Text = "";
			txt_KarfarmaFltr.Text = "";
			txt_BahaFltr.Text = "";
			txt_AmaliatFltr.Text = "";
			txt_CommentFltr.Text = "";
			cmbo_FehrestFltr.Text = "";
			SanadNo_filter = "";
			NoaSanad_filter = "";
			JobNo_filter = "";
			SanadDate_filter = "";
			Project_filter = "";
			Karfarma_filter = "";
			Baha_filter = "";
			Amaliat_filter = "";
			Comment_filter = "";
			Fehrest_filter = "";
			Frm_Enteghal_Load(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void cmbo_NoaSanadFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_NoaSanadFltr.Text.Trim(), "", TextCompare: false) != 0)
			{
				switch (cmbo_NoaSanadFltr.Text)
				{
				case "فاکتور":
					NoaSanad_filter = " ([forpf] = '1' And [Soori] = '0' And [Ghaleb] = '0')";
					Module1.forpf = true;
					Module1.soori = 0;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "فاکتور";
					break;
				case "پیش فاکتور":
					NoaSanad_filter = " ([forpf] = '0' And [Soori] = '0' And [Ghaleb] = '0')";
					Module1.forpf = false;
					Module1.soori = 0;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "پیش فاکتور";
					break;
				case "صوری":
					NoaSanad_filter = " ([Soori] = '1' And [Ghaleb] = '0')";
					Module1.soori = 1;
					Module1.Ghaleb = 0;
					Module1.NoaSanad = "صوری";
					break;
				case "قالب":
					NoaSanad_filter = " ([Soori] = '0' And [Ghaleb] = '1')";
					Module1.Ghaleb = 1;
					Module1.soori = 0;
					Module1.NoaSanad = "قالب";
					break;
				}
			}
			else
			{
				NoaSanad_filter = "";
				Module1.NoaSanad = "";
			}
			Load_dtg_AsnadList();
		}

		private void cmbo_SalMaliFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_SalMaliFltr.Text, "", TextCompare: false) != 0)
			{
				SalMali_filter = " ([SalMali] Like N'%" + cmbo_SalMaliFltr.Text.Trim() + "%')";
			}
			else
			{
				SalMali_filter = "";
			}
			Load_dtg_AsnadList();
		}

		private void txt_SanadNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SanadNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_SanadNoFltr.Text;
					SanadNo_filter = " ([sanadnum] Like N'%" + text + "%')";
				}
				else
				{
					SanadNo_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void txt_JobNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_JobNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_JobNoFltr.Text;
					JobNo_filter = " ([karnum] Like N'%" + text + "%')";
				}
				else
				{
					JobNo_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void txt_SanadDateFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_SanadDateFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_SanadDateFltr.Text;
					SanadDate_filter = " (([sanaddatey] + '/' + [sanaddatem] + '/' + [sanaddated]) Like N'%" + text + "%')";
				}
				else
				{
					SanadDate_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void txt_SanadDateFltr_TextChanged(object sender, EventArgs e)
		{
		}

		private void txt_ProjectFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ProjectFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ProjectFltr.Text;
					Project_filter = "  (REPLACE(REPLACE([pname1],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Project_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void txt_KarfarmaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_KarfarmaFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_KarfarmaFltr.Text;
					Karfarma_filter = " (REPLACE(REPLACE([karname1],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Karfarma_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void txt_BahaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_BahaFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				array = txt_BahaFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					Baha_filter = " (cast([mablaghk] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					Baha_filter = "([mablaghk] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					Baha_filter = "";
				}
			}
			else
			{
				Baha_filter = "";
			}
			Load_dtg_AsnadList();
		}

		private void txt_AmaliatFltr_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_AmaliatFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = txt_AmaliatFltr.Text;
				Amaliat_filter = " (REPLACE(REPLACE([noeSanad],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
			}
			else
			{
				Amaliat_filter = "";
			}
			Load_dtg_AsnadList();
		}

		private void txt_CommentFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_CommentFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_CommentFltr.Text;
					Comment_filter = " (REPLACE(REPLACE([Pname2],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Comment_filter = "";
				}
				Load_dtg_AsnadList();
			}
		}

		private void cmbo_FehrestFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_FehrestFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_FehrestFltr.Text;
				Fehrest_filter = " (REPLACE(REPLACE([asnad1].[fehrest],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
			}
			else
			{
				Fehrest_filter = "";
			}
			Load_dtg_AsnadList();
		}

		private void Load_Cmbo1(ComboBox strCmbo, string strTable, string strField, string strWhere)
		{
			DataTable dataTable = new DataTable();
			strCmbo.DataSource = null;
			Module1.MyConn1.Close();
			if (Module1.MyConn1.State == ConnectionState.Closed)
			{
				Module1.MyConn1.Open();
			}
			Module1.cmd.Connection = Module1.MyConn1;
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

        private void btn_Cansel_Click(object sender, EventArgs e)
        {

        }

        private void btn_ImportSelect_Click(object sender, EventArgs e)
        {

        }
    }
}
