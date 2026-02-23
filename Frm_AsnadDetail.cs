using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using JntNum2Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class Frm_AsnadDetail : Form
	{
		public struct SanadSumDetailes
		{
			public int recnum;

			public string sanadnum;

			public int Radif;

			public string Sharh;

			public string Noa;

			public string Darsad;

			public string Mablagh;
		}

		private IContainer components;


		private byte Nsit;

		private byte SetItemNomFocus;

		private byte SetDarsadMablaghFocus;

		private byte DtgAsnadDetailRefresh;

		private string Btn_AsnadDetailSit;

		private string ItemNo_Filter;

		private string ItemFasl_Filter;

		private string ItemNoa_Filter;

		private string ItemSharh_Filter;

		private string ItemVahed_Filter;

		private string ItemBahavahed_Filter;

		private string ItemTedad_Filter;

		private string ItemBahaKol_Filter;

		private string DarsadMeghdar_Filter;

		private string DarsadItem_Filter;

		private string DarsadMablagh_Filter;

		private string DarsadItemBaha;

		private string Tozihat_Filter;

		private string ItemSearch;

		private double SumFosoolWithZarib;

		private double SumFosoolNoZarib;

		private string GhabelPardakht;

		private int IdNo;

		private string BtnCommand1;

		private byte LoadDtgAsnadDetail;

		private byte LoadDtgAsnadSanadSum;

		private byte ExitFrmAsnadDetail;

		private bool fopf;

		public DataTable TableFosoolSum;

		public DataTable TableSanadSum;

		public DataTable AsnadDetailTable;

		public SanadSumDetailes SanadSumRec;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.TextBox txt_ItemRadifFltr;
        private System.Windows.Forms.TextBox txt_DarsadMablaghFltr;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txt_ItemNoFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemNoaFltr;
        private System.Windows.Forms.TextBox txt_ItemTedadFltr;
        private System.Windows.Forms.TextBox txt_ItemBahavahedFltr;
        private System.Windows.Forms.TextBox txt_ItemVahedFltr;
        private System.Windows.Forms.TextBox txt_DarsadMeghdarFltr;
        private System.Windows.Forms.TextBox txt_ItemSharhFltr;
        private System.Windows.Forms.TextBox txt_ItemFaslFltr;
        private System.Windows.Forms.TextBox txt_ItemBahaKolFltr;
        private System.Windows.Forms.TextBox txt_DarsadItemFltr;
        private System.Windows.Forms.TextBox txt_TozihatFltr;
        private System.Windows.Forms.DataGridView dtg_AsnadDetail;
        private System.Windows.Forms.Panel Panel2;
        public System.Windows.Forms.Label lbl_Comment;
        public System.Windows.Forms.Label lbl_Amaliat;
        public System.Windows.Forms.Label lbl_Karfarma;
        public System.Windows.Forms.Label lbl_Fehrest;
        public System.Windows.Forms.Label lbl_Project;
        public System.Windows.Forms.Label lbl_JobNo;
        public System.Windows.Forms.Label lbl_SanadNo;
        public System.Windows.Forms.Label lbl_NoaSanad;
        public System.Windows.Forms.Label lbl_SalMali;
        private System.Windows.Forms.Panel Panel8;
        public System.Windows.Forms.Label lbl_SanadZaribComment2;
        public System.Windows.Forms.Label lbl_SanadZaribComment1;
        public System.Windows.Forms.Label lbl_SanadZarib2;
        public System.Windows.Forms.Label lbl_SanadZarib1;
        public System.Windows.Forms.Label lbl_SanadBakhsh;
        public System.Windows.Forms.Label lbl_SanadShahr;
        public System.Windows.Forms.Label lbl_SanadOstan;
        private System.Windows.Forms.Label Label39;
        private System.Windows.Forms.Label Label40;
        private System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Label Label42;
        public System.Windows.Forms.Label lbl_SanadBakhshCode;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label32;
        private System.Windows.Forms.Panel Panel4;
        public System.Windows.Forms.Label lbl_SanadYear;
        public System.Windows.Forms.Label lbl_SanadMonth;
        public System.Windows.Forms.Label lbl_SanadDay;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label22;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Panel pnl_Fosool;
        private System.Windows.Forms.Panel pnl_SanadSum;
        private System.Windows.Forms.ComboBox cmbo_SumSharh;
        private System.Windows.Forms.TextBox txt_SumRadif;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label lbl_SumMande;
        private System.Windows.Forms.Button Btn_Return1;
        private System.Windows.Forms.Button btn_Delete1;
        private System.Windows.Forms.Button btn_New1;
        private System.Windows.Forms.TextBox txt_SumDarsad;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Button btn_Save1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.TextBox txt_SumMablagh;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.ComboBox cmbo_SumNoa;
        private System.Windows.Forms.Button btn_Modify1;
        private System.Windows.Forms.DataGridView dtg_FosoolSum;
        internal System.Windows.Forms.DataGridView dtg_SanadSum;
        private System.Windows.Forms.Panel pnl_MablaghKol;
        private System.Windows.Forms.Label lbl_GhabelPardakht;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label lbl_MablaghKol1;
        private System.Windows.Forms.Label lbl_MablaghKol2;
        private System.Windows.Forms.TextBox txt_FaslNoFltr;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Label Label37;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.Label Label30;
        internal System.Windows.Forms.TextBox txt_ItemBahavahed;
        private System.Windows.Forms.Label Label29;
        internal System.Windows.Forms.TextBox txt_ItemTedad;
        private System.Windows.Forms.Label Label24;
        internal System.Windows.Forms.TextBox txt_ItemBahaKol;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.TextBox txt_DarsadMeghdar;
        private System.Windows.Forms.ComboBox cmbo_ItemVahed;
        private System.Windows.Forms.ComboBox cmbo_ItemFasl;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lbl_ItemNoa;
        private System.Windows.Forms.Label lbl_DarsadItem;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_DarsadMablagh;
        private System.Windows.Forms.ComboBox cmbo_DarsadItem;
        private System.Windows.Forms.Button btn_Import;
        internal System.Windows.Forms.TextBox txt_Tozihat;
        private System.Windows.Forms.TextBox txt_ItemSharh;
        internal System.Windows.Forms.TextBox txt_ItemNo;
        private System.Windows.Forms.Panel pnl_Item;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Save;
       

		public Frm_AsnadDetail()
		{
			base.KeyDown += Frm_AsnadDetail_KeyDown;
			base.Load += Frm_AsnadDetail_Load;
			SetItemNomFocus = 0;
			SetDarsadMablaghFocus = 0;
			DarsadItemBaha = "0";
			ItemSearch = "";
			ExitFrmAsnadDetail = 0;
			TableFosoolSum = new DataTable();
			TableSanadSum = new DataTable();
			AsnadDetailTable = new DataTable();
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AsnadDetail));
            this.pnl_Filter = new System.Windows.Forms.Panel();
            this.btn_View = new System.Windows.Forms.Button();
            this.txt_ItemRadifFltr = new System.Windows.Forms.TextBox();
            this.txt_DarsadMablaghFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemNoFltr = new System.Windows.Forms.TextBox();
            this.cmbo_ItemNoaFltr = new System.Windows.Forms.ComboBox();
            this.txt_ItemTedadFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemBahavahedFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemVahedFltr = new System.Windows.Forms.TextBox();
            this.txt_DarsadMeghdarFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemSharhFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemFaslFltr = new System.Windows.Forms.TextBox();
            this.txt_ItemBahaKolFltr = new System.Windows.Forms.TextBox();
            this.txt_DarsadItemFltr = new System.Windows.Forms.TextBox();
            this.txt_TozihatFltr = new System.Windows.Forms.TextBox();
            this.dtg_AsnadDetail = new System.Windows.Forms.DataGridView();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.lbl_Comment = new System.Windows.Forms.Label();
            this.lbl_Amaliat = new System.Windows.Forms.Label();
            this.lbl_Karfarma = new System.Windows.Forms.Label();
            this.lbl_Fehrest = new System.Windows.Forms.Label();
            this.lbl_Project = new System.Windows.Forms.Label();
            this.lbl_JobNo = new System.Windows.Forms.Label();
            this.lbl_SanadNo = new System.Windows.Forms.Label();
            this.lbl_NoaSanad = new System.Windows.Forms.Label();
            this.lbl_SalMali = new System.Windows.Forms.Label();
            this.Panel8 = new System.Windows.Forms.Panel();
            this.lbl_SanadZaribComment2 = new System.Windows.Forms.Label();
            this.lbl_SanadZaribComment1 = new System.Windows.Forms.Label();
            this.lbl_SanadZarib2 = new System.Windows.Forms.Label();
            this.lbl_SanadZarib1 = new System.Windows.Forms.Label();
            this.lbl_SanadBakhsh = new System.Windows.Forms.Label();
            this.lbl_SanadShahr = new System.Windows.Forms.Label();
            this.lbl_SanadOstan = new System.Windows.Forms.Label();
            this.Label39 = new System.Windows.Forms.Label();
            this.Label40 = new System.Windows.Forms.Label();
            this.Label41 = new System.Windows.Forms.Label();
            this.Label42 = new System.Windows.Forms.Label();
            this.lbl_SanadBakhshCode = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label32 = new System.Windows.Forms.Label();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lbl_SanadYear = new System.Windows.Forms.Label();
            this.lbl_SanadMonth = new System.Windows.Forms.Label();
            this.lbl_SanadDay = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label18 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label22 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label19 = new System.Windows.Forms.Label();
            this.Label20 = new System.Windows.Forms.Label();
            this.pnl_Fosool = new System.Windows.Forms.Panel();
            this.pnl_SanadSum = new System.Windows.Forms.Panel();
            this.cmbo_SumSharh = new System.Windows.Forms.ComboBox();
            this.txt_SumRadif = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.lbl_SumMande = new System.Windows.Forms.Label();
            this.Btn_Return1 = new System.Windows.Forms.Button();
            this.btn_Delete1 = new System.Windows.Forms.Button();
            this.btn_New1 = new System.Windows.Forms.Button();
            this.txt_SumDarsad = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.btn_Save1 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.txt_SumMablagh = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.cmbo_SumNoa = new System.Windows.Forms.ComboBox();
            this.btn_Modify1 = new System.Windows.Forms.Button();
            this.dtg_FosoolSum = new System.Windows.Forms.DataGridView();
            this.dtg_SanadSum = new System.Windows.Forms.DataGridView();
            this.pnl_MablaghKol = new System.Windows.Forms.Panel();
            this.lbl_GhabelPardakht = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.lbl_MablaghKol1 = new System.Windows.Forms.Label();
            this.lbl_MablaghKol2 = new System.Windows.Forms.Label();
            this.txt_FaslNoFltr = new System.Windows.Forms.TextBox();
            this.Label38 = new System.Windows.Forms.Label();
            this.Label37 = new System.Windows.Forms.Label();
            this.Label35 = new System.Windows.Forms.Label();
            this.Label30 = new System.Windows.Forms.Label();
            this.txt_ItemBahavahed = new System.Windows.Forms.TextBox();
            this.Label29 = new System.Windows.Forms.Label();
            this.txt_ItemTedad = new System.Windows.Forms.TextBox();
            this.Label24 = new System.Windows.Forms.Label();
            this.txt_ItemBahaKol = new System.Windows.Forms.TextBox();
            this.Label21 = new System.Windows.Forms.Label();
            this.txt_DarsadMeghdar = new System.Windows.Forms.TextBox();
            this.cmbo_ItemVahed = new System.Windows.Forms.ComboBox();
            this.cmbo_ItemFasl = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.lbl_ItemNoa = new System.Windows.Forms.Label();
            this.lbl_DarsadItem = new System.Windows.Forms.Label();
            this.txt_DarsadMablagh = new System.Windows.Forms.TextBox();
            this.cmbo_DarsadItem = new System.Windows.Forms.ComboBox();
            this.txt_Tozihat = new System.Windows.Forms.TextBox();
            this.txt_ItemSharh = new System.Windows.Forms.TextBox();
            this.txt_ItemNo = new System.Windows.Forms.TextBox();
            this.pnl_Item = new System.Windows.Forms.Panel();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.Btn_Save = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.pnl_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AsnadDetail)).BeginInit();
            this.Panel2.SuspendLayout();
            this.Panel8.SuspendLayout();
            this.Panel4.SuspendLayout();
            this.pnl_Fosool.SuspendLayout();
            this.pnl_SanadSum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_FosoolSum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanadSum)).BeginInit();
            this.pnl_MablaghKol.SuspendLayout();
            this.pnl_Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Filter
            // 
            this.pnl_Filter.BackColor = System.Drawing.Color.White;
            this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Filter.Controls.Add(this.btn_View);
            this.pnl_Filter.Controls.Add(this.btn_Filter);
            this.pnl_Filter.Controls.Add(this.txt_ItemRadifFltr);
            this.pnl_Filter.Controls.Add(this.txt_DarsadMablaghFltr);
            this.pnl_Filter.Controls.Add(this.PictureBox1);
            this.pnl_Filter.Controls.Add(this.txt_ItemNoFltr);
            this.pnl_Filter.Controls.Add(this.cmbo_ItemNoaFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemTedadFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemBahavahedFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemVahedFltr);
            this.pnl_Filter.Controls.Add(this.txt_DarsadMeghdarFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemSharhFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemFaslFltr);
            this.pnl_Filter.Controls.Add(this.txt_ItemBahaKolFltr);
            this.pnl_Filter.Controls.Add(this.txt_DarsadItemFltr);
            this.pnl_Filter.Controls.Add(this.txt_TozihatFltr);
            this.pnl_Filter.Location = new System.Drawing.Point(15, 307);
            this.pnl_Filter.Name = "pnl_Filter";
            this.pnl_Filter.Size = new System.Drawing.Size(1180, 60);
            this.pnl_Filter.TabIndex = 89;
            this.pnl_Filter.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Filter_Paint);
            // 
            // btn_View
            // 
            this.btn_View.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View.Location = new System.Drawing.Point(1136, 0);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(42, 58);
            this.btn_View.TabIndex = 213;
            this.btn_View.Text = "نمایش بیشتر";
            this.btn_View.UseVisualStyleBackColor = true;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // txt_ItemRadifFltr
            // 
            this.txt_ItemRadifFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemRadifFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemRadifFltr.Location = new System.Drawing.Point(1097, 36);
            this.txt_ItemRadifFltr.Name = "txt_ItemRadifFltr";
            this.txt_ItemRadifFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemRadifFltr.Size = new System.Drawing.Size(39, 21);
            this.txt_ItemRadifFltr.TabIndex = 77;
            this.txt_ItemRadifFltr.TextChanged += new System.EventHandler(this.txt_ItemRadifFltr_TextChanged);
            this.txt_ItemRadifFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemRadifFltr_KeyDown);
            this.txt_ItemRadifFltr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemRadifFltr_KeyPress);
            // 
            // txt_DarsadMablaghFltr
            // 
            this.txt_DarsadMablaghFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DarsadMablaghFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_DarsadMablaghFltr.Location = new System.Drawing.Point(156, 36);
            this.txt_DarsadMablaghFltr.Name = "txt_DarsadMablaghFltr";
            this.txt_DarsadMablaghFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DarsadMablaghFltr.Size = new System.Drawing.Size(70, 21);
            this.txt_DarsadMablaghFltr.TabIndex = 76;
            this.txt_DarsadMablaghFltr.TextChanged += new System.EventHandler(this.txt_DarsadMablaghFltr_TextChanged);
            this.txt_DarsadMablaghFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMablaghFltr_KeyDown);
            // 
            // txt_ItemNoFltr
            // 
            this.txt_ItemNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemNoFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemNoFltr.Location = new System.Drawing.Point(1047, 36);
            this.txt_ItemNoFltr.Name = "txt_ItemNoFltr";
            this.txt_ItemNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemNoFltr.Size = new System.Drawing.Size(49, 21);
            this.txt_ItemNoFltr.TabIndex = 74;
            this.txt_ItemNoFltr.TextChanged += new System.EventHandler(this.txt_ItemNoFltr_TextChanged);
            this.txt_ItemNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNoFltr_KeyDown);
            // 
            // cmbo_ItemNoaFltr
            // 
            this.cmbo_ItemNoaFltr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_ItemNoaFltr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbo_ItemNoaFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_ItemNoaFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_ItemNoaFltr.FormattingEnabled = true;
            this.cmbo_ItemNoaFltr.Location = new System.Drawing.Point(947, 36);
            this.cmbo_ItemNoaFltr.Name = "cmbo_ItemNoaFltr";
            this.cmbo_ItemNoaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ItemNoaFltr.Size = new System.Drawing.Size(59, 23);
            this.cmbo_ItemNoaFltr.TabIndex = 73;
            this.cmbo_ItemNoaFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_SelectedIndexChanged);
            // 
            // txt_ItemTedadFltr
            // 
            this.txt_ItemTedadFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemTedadFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemTedadFltr.Location = new System.Drawing.Point(447, 36);
            this.txt_ItemTedadFltr.Name = "txt_ItemTedadFltr";
            this.txt_ItemTedadFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemTedadFltr.Size = new System.Drawing.Size(59, 21);
            this.txt_ItemTedadFltr.TabIndex = 55;
            this.txt_ItemTedadFltr.TextChanged += new System.EventHandler(this.txt_ItemTedadFltr_TextChanged);
            this.txt_ItemTedadFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemTedadFltr_KeyDown);
            // 
            // txt_ItemBahavahedFltr
            // 
            this.txt_ItemBahavahedFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemBahavahedFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemBahavahedFltr.Location = new System.Drawing.Point(507, 36);
            this.txt_ItemBahavahedFltr.Name = "txt_ItemBahavahedFltr";
            this.txt_ItemBahavahedFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemBahavahedFltr.Size = new System.Drawing.Size(79, 21);
            this.txt_ItemBahavahedFltr.TabIndex = 54;
            this.txt_ItemBahavahedFltr.TextChanged += new System.EventHandler(this.txt_ItemBahavahedFltr_TextChanged);
            this.txt_ItemBahavahedFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahedFltr_KeyDown);
            // 
            // txt_ItemVahedFltr
            // 
            this.txt_ItemVahedFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemVahedFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemVahedFltr.Location = new System.Drawing.Point(587, 36);
            this.txt_ItemVahedFltr.Name = "txt_ItemVahedFltr";
            this.txt_ItemVahedFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemVahedFltr.Size = new System.Drawing.Size(69, 21);
            this.txt_ItemVahedFltr.TabIndex = 53;
            this.txt_ItemVahedFltr.TextChanged += new System.EventHandler(this.txt_ItemVahedFltr_TextChanged);
            this.txt_ItemVahedFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemVahedFltr_KeyDown);
            // 
            // txt_DarsadMeghdarFltr
            // 
            this.txt_DarsadMeghdarFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DarsadMeghdarFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_DarsadMeghdarFltr.Location = new System.Drawing.Point(297, 36);
            this.txt_DarsadMeghdarFltr.Name = "txt_DarsadMeghdarFltr";
            this.txt_DarsadMeghdarFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DarsadMeghdarFltr.Size = new System.Drawing.Size(49, 21);
            this.txt_DarsadMeghdarFltr.TabIndex = 52;
            this.txt_DarsadMeghdarFltr.TextChanged += new System.EventHandler(this.txt_DarsadMeghdarFltr_TextChanged);
            this.txt_DarsadMeghdarFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMeghdarFltr_KeyDown);
            // 
            // txt_ItemSharhFltr
            // 
            this.txt_ItemSharhFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemSharhFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemSharhFltr.Location = new System.Drawing.Point(657, 36);
            this.txt_ItemSharhFltr.Name = "txt_ItemSharhFltr";
            this.txt_ItemSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemSharhFltr.Size = new System.Drawing.Size(289, 21);
            this.txt_ItemSharhFltr.TabIndex = 50;
            this.txt_ItemSharhFltr.TextChanged += new System.EventHandler(this.txt_ItemSharhFltr_TextChanged);
            this.txt_ItemSharhFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemSharhFltr_KeyDown);
            // 
            // txt_ItemFaslFltr
            // 
            this.txt_ItemFaslFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemFaslFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemFaslFltr.Location = new System.Drawing.Point(1007, 36);
            this.txt_ItemFaslFltr.Name = "txt_ItemFaslFltr";
            this.txt_ItemFaslFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemFaslFltr.Size = new System.Drawing.Size(39, 21);
            this.txt_ItemFaslFltr.TabIndex = 54;
            this.txt_ItemFaslFltr.TextChanged += new System.EventHandler(this.txt_ItemFaslFltr_TextChanged);
            this.txt_ItemFaslFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemFaslFltr_KeyDown);
            // 
            // txt_ItemBahaKolFltr
            // 
            this.txt_ItemBahaKolFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemBahaKolFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ItemBahaKolFltr.Location = new System.Drawing.Point(347, 36);
            this.txt_ItemBahaKolFltr.Name = "txt_ItemBahaKolFltr";
            this.txt_ItemBahaKolFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemBahaKolFltr.Size = new System.Drawing.Size(99, 21);
            this.txt_ItemBahaKolFltr.TabIndex = 47;
            this.txt_ItemBahaKolFltr.TextChanged += new System.EventHandler(this.txt_ItemBahaKolFltr_TextChanged);
            this.txt_ItemBahaKolFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahaKolFltr_KeyDown);
            // 
            // txt_DarsadItemFltr
            // 
            this.txt_DarsadItemFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DarsadItemFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_DarsadItemFltr.Location = new System.Drawing.Point(227, 36);
            this.txt_DarsadItemFltr.Name = "txt_DarsadItemFltr";
            this.txt_DarsadItemFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DarsadItemFltr.Size = new System.Drawing.Size(69, 21);
            this.txt_DarsadItemFltr.TabIndex = 48;
            this.txt_DarsadItemFltr.TextChanged += new System.EventHandler(this.txt_DarsadItemFltr_TextChanged);
            this.txt_DarsadItemFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadItemFltr_KeyDown);
            // 
            // txt_TozihatFltr
            // 
            this.txt_TozihatFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_TozihatFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_TozihatFltr.Location = new System.Drawing.Point(15, 36);
            this.txt_TozihatFltr.Name = "txt_TozihatFltr";
            this.txt_TozihatFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_TozihatFltr.Size = new System.Drawing.Size(140, 21);
            this.txt_TozihatFltr.TabIndex = 57;
            this.txt_TozihatFltr.TextChanged += new System.EventHandler(this.txt_TozihatFltr_TextChanged);
            this.txt_TozihatFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_TozihatFltr_KeyDown);
            // 
            // dtg_AsnadDetail
            // 
            this.dtg_AsnadDetail.AllowDrop = true;
            this.dtg_AsnadDetail.AllowUserToAddRows = false;
            this.dtg_AsnadDetail.AllowUserToDeleteRows = false;
            this.dtg_AsnadDetail.AllowUserToOrderColumns = true;
            this.dtg_AsnadDetail.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_AsnadDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtg_AsnadDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_AsnadDetail.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_AsnadDetail.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_AsnadDetail.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_AsnadDetail.Location = new System.Drawing.Point(15, 329);
            this.dtg_AsnadDetail.Name = "dtg_AsnadDetail";
            this.dtg_AsnadDetail.ReadOnly = true;
            this.dtg_AsnadDetail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_AsnadDetail.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_AsnadDetail.RowTemplate.Height = 44;
            this.dtg_AsnadDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_AsnadDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_AsnadDetail.Size = new System.Drawing.Size(1180, 235);
            this.dtg_AsnadDetail.TabIndex = 86;
            this.dtg_AsnadDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadDetail_CellClick);
            this.dtg_AsnadDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadDetail_CellContentClick);
            this.dtg_AsnadDetail.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadDetail_RowValidated);
            this.dtg_AsnadDetail.SelectionChanged += new System.EventHandler(this.dtg_AsnadDetail_SelectionChanged);
            this.dtg_AsnadDetail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_AsnadDetail_KeyDown);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel2.Controls.Add(this.lbl_Comment);
            this.Panel2.Controls.Add(this.lbl_Amaliat);
            this.Panel2.Controls.Add(this.lbl_Karfarma);
            this.Panel2.Controls.Add(this.lbl_Fehrest);
            this.Panel2.Controls.Add(this.lbl_Project);
            this.Panel2.Controls.Add(this.lbl_JobNo);
            this.Panel2.Controls.Add(this.lbl_SanadNo);
            this.Panel2.Controls.Add(this.lbl_NoaSanad);
            this.Panel2.Controls.Add(this.lbl_SalMali);
            this.Panel2.Controls.Add(this.Panel8);
            this.Panel2.Controls.Add(this.Label4);
            this.Panel2.Controls.Add(this.Label32);
            this.Panel2.Controls.Add(this.Panel4);
            this.Panel2.Controls.Add(this.Label11);
            this.Panel2.Controls.Add(this.Label13);
            this.Panel2.Controls.Add(this.Label22);
            this.Panel2.Controls.Add(this.Label14);
            this.Panel2.Controls.Add(this.Label15);
            this.Panel2.Controls.Add(this.Label19);
            this.Panel2.Controls.Add(this.Label20);
            this.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Panel2.ForeColor = System.Drawing.Color.Yellow;
            this.Panel2.Location = new System.Drawing.Point(15, 1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(1180, 101);
            this.Panel2.TabIndex = 91;
            this.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2_Paint);
            // 
            // lbl_Comment
            // 
            this.lbl_Comment.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Comment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Comment.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Comment.Location = new System.Drawing.Point(12, 21);
            this.lbl_Comment.Name = "lbl_Comment";
            this.lbl_Comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Comment.Size = new System.Drawing.Size(558, 20);
            this.lbl_Comment.TabIndex = 95;
            this.lbl_Comment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Comment.Click += new System.EventHandler(this.lbl_Comment_Click);
            // 
            // lbl_Amaliat
            // 
            this.lbl_Amaliat.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Amaliat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Amaliat.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Amaliat.Location = new System.Drawing.Point(12, 2);
            this.lbl_Amaliat.Name = "lbl_Amaliat";
            this.lbl_Amaliat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Amaliat.Size = new System.Drawing.Size(558, 20);
            this.lbl_Amaliat.TabIndex = 94;
            this.lbl_Amaliat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Amaliat.Click += new System.EventHandler(this.lbl_Amaliat_Click);
            // 
            // lbl_Karfarma
            // 
            this.lbl_Karfarma.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Karfarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Karfarma.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Karfarma.Location = new System.Drawing.Point(654, 57);
            this.lbl_Karfarma.Name = "lbl_Karfarma";
            this.lbl_Karfarma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Karfarma.Size = new System.Drawing.Size(450, 20);
            this.lbl_Karfarma.TabIndex = 93;
            this.lbl_Karfarma.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Karfarma.Click += new System.EventHandler(this.lbl_Karfarma_Click);
            // 
            // lbl_Fehrest
            // 
            this.lbl_Fehrest.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Fehrest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Fehrest.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Fehrest.Location = new System.Drawing.Point(654, 73);
            this.lbl_Fehrest.Name = "lbl_Fehrest";
            this.lbl_Fehrest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Fehrest.Size = new System.Drawing.Size(450, 20);
            this.lbl_Fehrest.TabIndex = 92;
            this.lbl_Fehrest.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Fehrest.Click += new System.EventHandler(this.lbl_Fehrest_Click);
            // 
            // lbl_Project
            // 
            this.lbl_Project.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_Project.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Project.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_Project.Location = new System.Drawing.Point(654, 40);
            this.lbl_Project.Name = "lbl_Project";
            this.lbl_Project.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_Project.Size = new System.Drawing.Size(450, 20);
            this.lbl_Project.TabIndex = 91;
            this.lbl_Project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_Project.Click += new System.EventHandler(this.lbl_Project_Click);
            // 
            // lbl_JobNo
            // 
            this.lbl_JobNo.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_JobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_JobNo.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_JobNo.Location = new System.Drawing.Point(654, 1);
            this.lbl_JobNo.Name = "lbl_JobNo";
            this.lbl_JobNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_JobNo.Size = new System.Drawing.Size(90, 19);
            this.lbl_JobNo.TabIndex = 90;
            this.lbl_JobNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_JobNo.Click += new System.EventHandler(this.lbl_JobNo_Click);
            // 
            // lbl_SanadNo
            // 
            this.lbl_SanadNo.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadNo.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadNo.Location = new System.Drawing.Point(829, 4);
            this.lbl_SanadNo.Name = "lbl_SanadNo";
            this.lbl_SanadNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadNo.Size = new System.Drawing.Size(90, 19);
            this.lbl_SanadNo.TabIndex = 89;
            this.lbl_SanadNo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadNo.Click += new System.EventHandler(this.lbl_SanadNo_Click);
            // 
            // lbl_NoaSanad
            // 
            this.lbl_NoaSanad.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_NoaSanad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_NoaSanad.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_NoaSanad.Location = new System.Drawing.Point(1016, 23);
            this.lbl_NoaSanad.Name = "lbl_NoaSanad";
            this.lbl_NoaSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_NoaSanad.Size = new System.Drawing.Size(90, 20);
            this.lbl_NoaSanad.TabIndex = 88;
            this.lbl_NoaSanad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_NoaSanad.Click += new System.EventHandler(this.lbl_NoaSanad_Click);
            // 
            // lbl_SalMali
            // 
            this.lbl_SalMali.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SalMali.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SalMali.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SalMali.Location = new System.Drawing.Point(1016, 4);
            this.lbl_SalMali.Name = "lbl_SalMali";
            this.lbl_SalMali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SalMali.Size = new System.Drawing.Size(90, 20);
            this.lbl_SalMali.TabIndex = 87;
            this.lbl_SalMali.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SalMali.Click += new System.EventHandler(this.lbl_SalMali_Click);
            // 
            // Panel8
            // 
            this.Panel8.Controls.Add(this.lbl_SanadZaribComment2);
            this.Panel8.Controls.Add(this.lbl_SanadZaribComment1);
            this.Panel8.Controls.Add(this.lbl_SanadZarib2);
            this.Panel8.Controls.Add(this.lbl_SanadZarib1);
            this.Panel8.Controls.Add(this.lbl_SanadBakhsh);
            this.Panel8.Controls.Add(this.lbl_SanadShahr);
            this.Panel8.Controls.Add(this.lbl_SanadOstan);
            this.Panel8.Controls.Add(this.Label39);
            this.Panel8.Controls.Add(this.Label40);
            this.Panel8.Controls.Add(this.Label41);
            this.Panel8.Controls.Add(this.Label42);
            this.Panel8.Controls.Add(this.lbl_SanadBakhshCode);
            this.Panel8.Location = new System.Drawing.Point(3, 37);
            this.Panel8.Name = "Panel8";
            this.Panel8.Size = new System.Drawing.Size(623, 61);
            this.Panel8.TabIndex = 85;
            this.Panel8.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel8_Paint);
            // 
            // lbl_SanadZaribComment2
            // 
            this.lbl_SanadZaribComment2.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadZaribComment2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadZaribComment2.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadZaribComment2.Location = new System.Drawing.Point(9, 39);
            this.lbl_SanadZaribComment2.Name = "lbl_SanadZaribComment2";
            this.lbl_SanadZaribComment2.Size = new System.Drawing.Size(513, 20);
            this.lbl_SanadZaribComment2.TabIndex = 107;
            this.lbl_SanadZaribComment2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadZaribComment2.Click += new System.EventHandler(this.lbl_SanadZaribComment2_Click);
            // 
            // lbl_SanadZaribComment1
            // 
            this.lbl_SanadZaribComment1.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadZaribComment1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadZaribComment1.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadZaribComment1.Location = new System.Drawing.Point(9, 18);
            this.lbl_SanadZaribComment1.Name = "lbl_SanadZaribComment1";
            this.lbl_SanadZaribComment1.Size = new System.Drawing.Size(513, 20);
            this.lbl_SanadZaribComment1.TabIndex = 106;
            this.lbl_SanadZaribComment1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadZaribComment1.Click += new System.EventHandler(this.lbl_SanadZaribComment1_Click);
            // 
            // lbl_SanadZarib2
            // 
            this.lbl_SanadZarib2.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadZarib2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadZarib2.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadZarib2.Location = new System.Drawing.Point(524, 39);
            this.lbl_SanadZarib2.Name = "lbl_SanadZarib2";
            this.lbl_SanadZarib2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadZarib2.Size = new System.Drawing.Size(42, 20);
            this.lbl_SanadZarib2.TabIndex = 105;
            this.lbl_SanadZarib2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SanadZarib2.Click += new System.EventHandler(this.lbl_SanadZarib2_Click);
            // 
            // lbl_SanadZarib1
            // 
            this.lbl_SanadZarib1.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadZarib1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadZarib1.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadZarib1.Location = new System.Drawing.Point(524, 18);
            this.lbl_SanadZarib1.Name = "lbl_SanadZarib1";
            this.lbl_SanadZarib1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadZarib1.Size = new System.Drawing.Size(43, 20);
            this.lbl_SanadZarib1.TabIndex = 104;
            this.lbl_SanadZarib1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SanadZarib1.Click += new System.EventHandler(this.lbl_SanadZarib1_Click);
            // 
            // lbl_SanadBakhsh
            // 
            this.lbl_SanadBakhsh.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadBakhsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadBakhsh.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadBakhsh.Location = new System.Drawing.Point(9, -1);
            this.lbl_SanadBakhsh.Name = "lbl_SanadBakhsh";
            this.lbl_SanadBakhsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadBakhsh.Size = new System.Drawing.Size(111, 20);
            this.lbl_SanadBakhsh.TabIndex = 103;
            this.lbl_SanadBakhsh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadBakhsh.Click += new System.EventHandler(this.lbl_SanadBakhsh_Click);
            // 
            // lbl_SanadShahr
            // 
            this.lbl_SanadShahr.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadShahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadShahr.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadShahr.Location = new System.Drawing.Point(216, -1);
            this.lbl_SanadShahr.Name = "lbl_SanadShahr";
            this.lbl_SanadShahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadShahr.Size = new System.Drawing.Size(110, 20);
            this.lbl_SanadShahr.TabIndex = 102;
            this.lbl_SanadShahr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadShahr.Click += new System.EventHandler(this.lbl_SanadShahr_Click);
            // 
            // lbl_SanadOstan
            // 
            this.lbl_SanadOstan.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadOstan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadOstan.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadOstan.Location = new System.Drawing.Point(456, -1);
            this.lbl_SanadOstan.Name = "lbl_SanadOstan";
            this.lbl_SanadOstan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadOstan.Size = new System.Drawing.Size(110, 20);
            this.lbl_SanadOstan.TabIndex = 101;
            this.lbl_SanadOstan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadOstan.Click += new System.EventHandler(this.lbl_SanadOstan_Click);
            // 
            // Label39
            // 
            this.Label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label39.ForeColor = System.Drawing.Color.White;
            this.Label39.Location = new System.Drawing.Point(566, 20);
            this.Label39.Name = "Label39";
            this.Label39.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label39.Size = new System.Drawing.Size(54, 31);
            this.Label39.TabIndex = 93;
            this.Label39.Text = "ضریب منطقه ای:";
            this.Label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Label39.Click += new System.EventHandler(this.Label39_Click);
            // 
            // Label40
            // 
            this.Label40.AutoSize = true;
            this.Label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label40.ForeColor = System.Drawing.Color.White;
            this.Label40.Location = new System.Drawing.Point(565, 3);
            this.Label40.Name = "Label40";
            this.Label40.Size = new System.Drawing.Size(37, 13);
            this.Label40.TabIndex = 92;
            this.Label40.Text = "استان:";
            this.Label40.Click += new System.EventHandler(this.Label40_Click);
            // 
            // Label41
            // 
            this.Label41.AutoSize = true;
            this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label41.ForeColor = System.Drawing.Color.White;
            this.Label41.Location = new System.Drawing.Point(325, 3);
            this.Label41.Name = "Label41";
            this.Label41.Size = new System.Drawing.Size(54, 13);
            this.Label41.TabIndex = 91;
            this.Label41.Text = "شهرستان:";
            this.Label41.Click += new System.EventHandler(this.Label41_Click);
            // 
            // Label42
            // 
            this.Label42.AutoSize = true;
            this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label42.ForeColor = System.Drawing.Color.White;
            this.Label42.Location = new System.Drawing.Point(120, 3);
            this.Label42.Name = "Label42";
            this.Label42.Size = new System.Drawing.Size(33, 13);
            this.Label42.TabIndex = 90;
            this.Label42.Text = " بخش:";
            this.Label42.Click += new System.EventHandler(this.Label42_Click);
            // 
            // lbl_SanadBakhshCode
            // 
            this.lbl_SanadBakhshCode.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadBakhshCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadBakhshCode.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadBakhshCode.Location = new System.Drawing.Point(3, 38);
            this.lbl_SanadBakhshCode.Name = "lbl_SanadBakhshCode";
            this.lbl_SanadBakhshCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SanadBakhshCode.Size = new System.Drawing.Size(85, 19);
            this.lbl_SanadBakhshCode.TabIndex = 108;
            this.lbl_SanadBakhshCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_SanadBakhshCode.Visible = false;
            this.lbl_SanadBakhshCode.Click += new System.EventHandler(this.lbl_SanadBakhshCode_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label4.ForeColor = System.Drawing.Color.White;
            this.Label4.Location = new System.Drawing.Point(1104, 7);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 13);
            this.Label4.TabIndex = 78;
            this.Label4.Text = "سال مالی:";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // Label32
            // 
            this.Label32.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Label32.AutoSize = true;
            this.Label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label32.ForeColor = System.Drawing.Color.White;
            this.Label32.Location = new System.Drawing.Point(1105, 25);
            this.Label32.Name = "Label32";
            this.Label32.Size = new System.Drawing.Size(51, 13);
            this.Label32.TabIndex = 77;
            this.Label32.Text = " نوع سند:";
            this.Label32.Click += new System.EventHandler(this.Label32_Click);
            // 
            // Panel4
            // 
            this.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Panel4.Controls.Add(this.lbl_SanadYear);
            this.Panel4.Controls.Add(this.lbl_SanadMonth);
            this.Panel4.Controls.Add(this.lbl_SanadDay);
            this.Panel4.Controls.Add(this.Label16);
            this.Panel4.Controls.Add(this.Label17);
            this.Panel4.Controls.Add(this.Label18);
            this.Panel4.Location = new System.Drawing.Point(709, 19);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(246, 26);
            this.Panel4.TabIndex = 59;
            this.Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel4_Paint);
            // 
            // lbl_SanadYear
            // 
            this.lbl_SanadYear.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadYear.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadYear.Location = new System.Drawing.Point(40, 5);
            this.lbl_SanadYear.Name = "lbl_SanadYear";
            this.lbl_SanadYear.Size = new System.Drawing.Size(40, 20);
            this.lbl_SanadYear.TabIndex = 86;
            this.lbl_SanadYear.Click += new System.EventHandler(this.lbl_SanadYear_Click);
            // 
            // lbl_SanadMonth
            // 
            this.lbl_SanadMonth.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadMonth.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadMonth.Location = new System.Drawing.Point(94, 5);
            this.lbl_SanadMonth.Name = "lbl_SanadMonth";
            this.lbl_SanadMonth.Size = new System.Drawing.Size(40, 20);
            this.lbl_SanadMonth.TabIndex = 85;
            this.lbl_SanadMonth.Click += new System.EventHandler(this.lbl_SanadMonth_Click);
            // 
            // lbl_SanadDay
            // 
            this.lbl_SanadDay.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_SanadDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_SanadDay.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_SanadDay.Location = new System.Drawing.Point(148, 5);
            this.lbl_SanadDay.Name = "lbl_SanadDay";
            this.lbl_SanadDay.Size = new System.Drawing.Size(40, 20);
            this.lbl_SanadDay.TabIndex = 84;
            this.lbl_SanadDay.Click += new System.EventHandler(this.lbl_SanadDay_Click);
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label16.ForeColor = System.Drawing.Color.Cyan;
            this.Label16.Location = new System.Drawing.Point(138, 6);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(12, 13);
            this.Label16.TabIndex = 41;
            this.Label16.Text = "/";
            this.Label16.Click += new System.EventHandler(this.Label16_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label17.ForeColor = System.Drawing.Color.Cyan;
            this.Label17.Location = new System.Drawing.Point(84, 6);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(12, 13);
            this.Label17.TabIndex = 40;
            this.Label17.Text = "/";
            this.Label17.Click += new System.EventHandler(this.Label17_Click);
            // 
            // Label18
            // 
            this.Label18.AutoSize = true;
            this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label18.ForeColor = System.Drawing.Color.White;
            this.Label18.Location = new System.Drawing.Point(189, 9);
            this.Label18.Name = "Label18";
            this.Label18.Size = new System.Drawing.Size(38, 13);
            this.Label18.TabIndex = 39;
            this.Label18.Text = " تاریخ:";
            this.Label18.Click += new System.EventHandler(this.Label18_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label11.ForeColor = System.Drawing.Color.White;
            this.Label11.Location = new System.Drawing.Point(567, 23);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(52, 13);
            this.Label11.TabIndex = 50;
            this.Label11.Text = "توضیحات:";
            this.Label11.Click += new System.EventHandler(this.Label11_Click);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label13.ForeColor = System.Drawing.Color.White;
            this.Label13.Location = new System.Drawing.Point(1105, 75);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(64, 13);
            this.Label13.TabIndex = 47;
            this.Label13.Text = " فهرست بها:";
            this.Label13.Click += new System.EventHandler(this.Label13_Click);
            // 
            // Label22
            // 
            this.Label22.AutoSize = true;
            this.Label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label22.ForeColor = System.Drawing.Color.White;
            this.Label22.Location = new System.Drawing.Point(917, 7);
            this.Label22.Name = "Label22";
            this.Label22.Size = new System.Drawing.Size(60, 13);
            this.Label22.TabIndex = 36;
            this.Label22.Text = "شماره سند:";
            this.Label22.Click += new System.EventHandler(this.Label22_Click);
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label14.ForeColor = System.Drawing.Color.White;
            this.Label14.Location = new System.Drawing.Point(740, 6);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(58, 13);
            this.Label14.TabIndex = 0;
            this.Label14.Text = "شماره کار:";
            this.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label15.ForeColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(1105, 42);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(55, 13);
            this.Label15.TabIndex = 4;
            this.Label15.Text = " نام پروژه:";
            this.Label15.Click += new System.EventHandler(this.Label15_Click);
            // 
            // Label19
            // 
            this.Label19.AutoSize = true;
            this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label19.ForeColor = System.Drawing.Color.White;
            this.Label19.Location = new System.Drawing.Point(567, 5);
            this.Label19.Name = "Label19";
            this.Label19.Size = new System.Drawing.Size(64, 13);
            this.Label19.TabIndex = 7;
            this.Label19.Text = "موضوع سند:";
            this.Label19.Click += new System.EventHandler(this.Label19_Click);
            // 
            // Label20
            // 
            this.Label20.AutoSize = true;
            this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label20.ForeColor = System.Drawing.Color.White;
            this.Label20.Location = new System.Drawing.Point(1106, 59);
            this.Label20.Name = "Label20";
            this.Label20.Size = new System.Drawing.Size(65, 13);
            this.Label20.TabIndex = 9;
            this.Label20.Text = " نام کارفرما:";
            this.Label20.Click += new System.EventHandler(this.Label20_Click);
            // 
            // pnl_Fosool
            // 
            this.pnl_Fosool.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_Fosool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_Fosool.Controls.Add(this.pnl_SanadSum);
            this.pnl_Fosool.Controls.Add(this.btn_Modify1);
            this.pnl_Fosool.Controls.Add(this.dtg_FosoolSum);
            this.pnl_Fosool.Controls.Add(this.dtg_SanadSum);
            this.pnl_Fosool.Controls.Add(this.pnl_MablaghKol);
            this.pnl_Fosool.Location = new System.Drawing.Point(15, 93);
            this.pnl_Fosool.Name = "pnl_Fosool";
            this.pnl_Fosool.Size = new System.Drawing.Size(1180, 213);
            this.pnl_Fosool.TabIndex = 92;
            this.pnl_Fosool.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Fosool_Paint);
            // 
            // pnl_SanadSum
            // 
            this.pnl_SanadSum.Controls.Add(this.cmbo_SumSharh);
            this.pnl_SanadSum.Controls.Add(this.txt_SumRadif);
            this.pnl_SanadSum.Controls.Add(this.Label3);
            this.pnl_SanadSum.Controls.Add(this.lbl_SumMande);
            this.pnl_SanadSum.Controls.Add(this.Btn_Return1);
            this.pnl_SanadSum.Controls.Add(this.btn_Delete1);
            this.pnl_SanadSum.Controls.Add(this.btn_New1);
            this.pnl_SanadSum.Controls.Add(this.txt_SumDarsad);
            this.pnl_SanadSum.Controls.Add(this.Label8);
            this.pnl_SanadSum.Controls.Add(this.btn_Save1);
            this.pnl_SanadSum.Controls.Add(this.Label1);
            this.pnl_SanadSum.Controls.Add(this.Label7);
            this.pnl_SanadSum.Controls.Add(this.txt_SumMablagh);
            this.pnl_SanadSum.Controls.Add(this.Label6);
            this.pnl_SanadSum.Controls.Add(this.Label5);
            this.pnl_SanadSum.Controls.Add(this.cmbo_SumNoa);
            this.pnl_SanadSum.Location = new System.Drawing.Point(3, 152);
            this.pnl_SanadSum.Name = "pnl_SanadSum";
            this.pnl_SanadSum.Size = new System.Drawing.Size(585, 60);
            this.pnl_SanadSum.TabIndex = 104;
            this.pnl_SanadSum.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_SanadSum_Paint);
            // 
            // cmbo_SumSharh
            // 
            this.cmbo_SumSharh.FormattingEnabled = true;
            this.cmbo_SumSharh.Location = new System.Drawing.Point(302, 19);
            this.cmbo_SumSharh.Name = "cmbo_SumSharh";
            this.cmbo_SumSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_SumSharh.Size = new System.Drawing.Size(229, 21);
            this.cmbo_SumSharh.TabIndex = 119;
            this.cmbo_SumSharh.SelectedIndexChanged += new System.EventHandler(this.cmbo_SumSharh_SelectedIndexChanged);
            this.cmbo_SumSharh.TextChanged += new System.EventHandler(this.cmbo_SumSharh_TextChanged);
            this.cmbo_SumSharh.Leave += new System.EventHandler(this.cmbo_SumSharh_Leave);
            // 
            // txt_SumRadif
            // 
            this.txt_SumRadif.Location = new System.Drawing.Point(532, 19);
            this.txt_SumRadif.Name = "txt_SumRadif";
            this.txt_SumRadif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SumRadif.Size = new System.Drawing.Size(45, 20);
            this.txt_SumRadif.TabIndex = 118;
            this.txt_SumRadif.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SumRadif.TextChanged += new System.EventHandler(this.txt_SumRadif_TextChanged);
            this.txt_SumRadif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SumRadif_KeyPress);
            this.txt_SumRadif.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SumRadif_KeyUp);
            this.txt_SumRadif.Leave += new System.EventHandler(this.txt_SumRadif_Leave);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(536, 6);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(30, 13);
            this.Label3.TabIndex = 117;
            this.Label3.Text = "ردیف";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // lbl_SumMande
            // 
            this.lbl_SumMande.BackColor = System.Drawing.Color.White;
            this.lbl_SumMande.Location = new System.Drawing.Point(3, 19);
            this.lbl_SumMande.Name = "lbl_SumMande";
            this.lbl_SumMande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_SumMande.Size = new System.Drawing.Size(90, 20);
            this.lbl_SumMande.TabIndex = 116;
            this.lbl_SumMande.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_SumMande.TextChanged += new System.EventHandler(this.lbl_SumMande_TextChanged);
            this.lbl_SumMande.Click += new System.EventHandler(this.lbl_SumMande_Click);
            // 
            // Btn_Return1
            // 
            this.Btn_Return1.Location = new System.Drawing.Point(18, 40);
            this.Btn_Return1.Name = "Btn_Return1";
            this.Btn_Return1.Size = new System.Drawing.Size(70, 20);
            this.Btn_Return1.TabIndex = 115;
            this.Btn_Return1.Text = " بازگشت ";
            this.Btn_Return1.UseVisualStyleBackColor = true;
            this.Btn_Return1.Click += new System.EventHandler(this.Btn_Return1_Click);
            // 
            // btn_Delete1
            // 
            this.btn_Delete1.Location = new System.Drawing.Point(161, 40);
            this.btn_Delete1.Name = "btn_Delete1";
            this.btn_Delete1.Size = new System.Drawing.Size(70, 20);
            this.btn_Delete1.TabIndex = 113;
            this.btn_Delete1.Text = "حذف";
            this.btn_Delete1.UseVisualStyleBackColor = true;
            this.btn_Delete1.Click += new System.EventHandler(this.btn_Delete1_Click);
            // 
            // btn_New1
            // 
            this.btn_New1.Location = new System.Drawing.Point(317, 40);
            this.btn_New1.Name = "btn_New1";
            this.btn_New1.Size = new System.Drawing.Size(70, 20);
            this.btn_New1.TabIndex = 112;
            this.btn_New1.Text = "جدید";
            this.btn_New1.UseVisualStyleBackColor = true;
            this.btn_New1.Click += new System.EventHandler(this.btn_New1_Click);
            // 
            // txt_SumDarsad
            // 
            this.txt_SumDarsad.Location = new System.Drawing.Point(187, 19);
            this.txt_SumDarsad.Name = "txt_SumDarsad";
            this.txt_SumDarsad.Size = new System.Drawing.Size(56, 20);
            this.txt_SumDarsad.TabIndex = 121;
            this.txt_SumDarsad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SumDarsad.TextChanged += new System.EventHandler(this.txt_SumDarsad_TextChanged);
            this.txt_SumDarsad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SumDarsad_KeyDown);
            this.txt_SumDarsad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SumDarsad_KeyPress);
            this.txt_SumDarsad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SumDarsad_KeyUp);
            this.txt_SumDarsad.Leave += new System.EventHandler(this.txt_SumDarsad_Leave);
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(203, 5);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(31, 13);
            this.Label8.TabIndex = 110;
            this.Label8.Text = "درصد";
            this.Label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // btn_Save1
            // 
            this.btn_Save1.Location = new System.Drawing.Point(489, 40);
            this.btn_Save1.Name = "btn_Save1";
            this.btn_Save1.Size = new System.Drawing.Size(70, 20);
            this.btn_Save1.TabIndex = 123;
            this.btn_Save1.Text = "ذخیره";
            this.btn_Save1.UseVisualStyleBackColor = true;
            this.btn_Save1.Click += new System.EventHandler(this.btn_Save1_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(427, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(29, 13);
            this.Label1.TabIndex = 94;
            this.Label1.Text = "شرح";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(58, 5);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(31, 13);
            this.Label7.TabIndex = 102;
            this.Label7.Text = "مانده";
            this.Label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // txt_SumMablagh
            // 
            this.txt_SumMablagh.Location = new System.Drawing.Point(95, 19);
            this.txt_SumMablagh.Name = "txt_SumMablagh";
            this.txt_SumMablagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SumMablagh.Size = new System.Drawing.Size(90, 20);
            this.txt_SumMablagh.TabIndex = 122;
            this.txt_SumMablagh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SumMablagh.TextChanged += new System.EventHandler(this.txt_SumMablagh_TextChanged);
            this.txt_SumMablagh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SumMablagh_KeyPress);
            this.txt_SumMablagh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_SumMablagh_KeyUp);
            this.txt_SumMablagh.Leave += new System.EventHandler(this.txt_SumMablagh_Leave);
            this.txt_SumMablagh.MouseEnter += new System.EventHandler(this.txt_SumMablagh_MouseEnter);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(120, 5);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(26, 13);
            this.Label6.TabIndex = 100;
            this.Label6.Text = "مبلغ";
            this.Label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(263, 5);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(24, 13);
            this.Label5.TabIndex = 98;
            this.Label5.Text = "نوع";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // cmbo_SumNoa
            // 
            this.cmbo_SumNoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_SumNoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbo_SumNoa.FormattingEnabled = true;
            this.cmbo_SumNoa.Location = new System.Drawing.Point(245, 19);
            this.cmbo_SumNoa.Name = "cmbo_SumNoa";
            this.cmbo_SumNoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_SumNoa.Size = new System.Drawing.Size(55, 21);
            this.cmbo_SumNoa.TabIndex = 120;
            this.cmbo_SumNoa.SelectedIndexChanged += new System.EventHandler(this.cmbo_SumNoa_SelectedIndexChanged);
            this.cmbo_SumNoa.TextChanged += new System.EventHandler(this.cmbo_SumNoa_TextChanged);
            this.cmbo_SumNoa.Leave += new System.EventHandler(this.cmbo_SumNoa_Leave);
            // 
            // btn_Modify1
            // 
            this.btn_Modify1.Location = new System.Drawing.Point(4, 156);
            this.btn_Modify1.Name = "btn_Modify1";
            this.btn_Modify1.Size = new System.Drawing.Size(56, 21);
            this.btn_Modify1.TabIndex = 108;
            this.btn_Modify1.Text = "تغییرات";
            this.btn_Modify1.UseVisualStyleBackColor = true;
            this.btn_Modify1.Click += new System.EventHandler(this.btn_Modify1_Click);
            // 
            // dtg_FosoolSum
            // 
            this.dtg_FosoolSum.AllowDrop = true;
            this.dtg_FosoolSum.AllowUserToAddRows = false;
            this.dtg_FosoolSum.BackgroundColor = System.Drawing.Color.White;
            this.dtg_FosoolSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_FosoolSum.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtg_FosoolSum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_FosoolSum.Location = new System.Drawing.Point(592, 4);
            this.dtg_FosoolSum.MultiSelect = false;
            this.dtg_FosoolSum.Name = "dtg_FosoolSum";
            this.dtg_FosoolSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_FosoolSum.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtg_FosoolSum.Size = new System.Drawing.Size(585, 206);
            this.dtg_FosoolSum.TabIndex = 93;
            this.dtg_FosoolSum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_FosoolSum_CellClick);
            this.dtg_FosoolSum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_FosoolSum_CellContentClick);
            // 
            // dtg_SanadSum
            // 
            this.dtg_SanadSum.AllowDrop = true;
            this.dtg_SanadSum.AllowUserToAddRows = false;
            this.dtg_SanadSum.AllowUserToDeleteRows = false;
            this.dtg_SanadSum.AllowUserToOrderColumns = true;
            this.dtg_SanadSum.BackgroundColor = System.Drawing.Color.White;
            this.dtg_SanadSum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtg_SanadSum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtg_SanadSum.DefaultCellStyle = dataGridViewCellStyle4;
            this.dtg_SanadSum.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_SanadSum.Location = new System.Drawing.Point(3, 5);
            this.dtg_SanadSum.Name = "dtg_SanadSum";
            this.dtg_SanadSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtg_SanadSum.ShowRowErrors = false;
            this.dtg_SanadSum.Size = new System.Drawing.Size(585, 145);
            this.dtg_SanadSum.TabIndex = 106;
            this.dtg_SanadSum.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SanadSum_CellClick);
            this.dtg_SanadSum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_SanadSum_CellContentClick);
            this.dtg_SanadSum.SelectionChanged += new System.EventHandler(this.dtg_SanadSum_SelectionChanged);
            // 
            // pnl_MablaghKol
            // 
            this.pnl_MablaghKol.Controls.Add(this.lbl_GhabelPardakht);
            this.pnl_MablaghKol.Controls.Add(this.Label12);
            this.pnl_MablaghKol.Controls.Add(this.lbl_MablaghKol1);
            this.pnl_MablaghKol.Controls.Add(this.lbl_MablaghKol2);
            this.pnl_MablaghKol.Location = new System.Drawing.Point(3, 164);
            this.pnl_MablaghKol.Name = "pnl_MablaghKol";
            this.pnl_MablaghKol.Size = new System.Drawing.Size(583, 54);
            this.pnl_MablaghKol.TabIndex = 107;
            this.pnl_MablaghKol.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_MablaghKol_Paint);
            // 
            // lbl_GhabelPardakht
            // 
            this.lbl_GhabelPardakht.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lbl_GhabelPardakht.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_GhabelPardakht.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_GhabelPardakht.Location = new System.Drawing.Point(0, 3);
            this.lbl_GhabelPardakht.Name = "lbl_GhabelPardakht";
            this.lbl_GhabelPardakht.Size = new System.Drawing.Size(582, 15);
            this.lbl_GhabelPardakht.TabIndex = 95;
            this.lbl_GhabelPardakht.Visible = false;
            this.lbl_GhabelPardakht.Click += new System.EventHandler(this.lbl_GhabelPardakht_Click);
            // 
            // Label12
            // 
            this.Label12.BackColor = System.Drawing.Color.SteelBlue;
            this.Label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label12.ForeColor = System.Drawing.Color.Cyan;
            this.Label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label12.Location = new System.Drawing.Point(507, 10);
            this.Label12.Name = "Label12";
            this.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label12.Size = new System.Drawing.Size(76, 34);
            this.Label12.TabIndex = 99;
            this.Label12.Text = "مبلغ قابل پرداخت (ریال) : ";
            this.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label12.Click += new System.EventHandler(this.Label12_Click);
            // 
            // lbl_MablaghKol1
            // 
            this.lbl_MablaghKol1.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_MablaghKol1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MablaghKol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_MablaghKol1.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_MablaghKol1.Location = new System.Drawing.Point(3, 10);
            this.lbl_MablaghKol1.Name = "lbl_MablaghKol1";
            this.lbl_MablaghKol1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MablaghKol1.Size = new System.Drawing.Size(105, 33);
            this.lbl_MablaghKol1.TabIndex = 96;
            this.lbl_MablaghKol1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MablaghKol1.TextChanged += new System.EventHandler(this.lbl_MablaghKol1_TextChanged);
            this.lbl_MablaghKol1.Click += new System.EventHandler(this.lbl_MablaghKol1_Click);
            // 
            // lbl_MablaghKol2
            // 
            this.lbl_MablaghKol2.BackColor = System.Drawing.Color.SteelBlue;
            this.lbl_MablaghKol2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_MablaghKol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_MablaghKol2.ForeColor = System.Drawing.Color.Cyan;
            this.lbl_MablaghKol2.Location = new System.Drawing.Point(108, 10);
            this.lbl_MablaghKol2.Name = "lbl_MablaghKol2";
            this.lbl_MablaghKol2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_MablaghKol2.Size = new System.Drawing.Size(400, 33);
            this.lbl_MablaghKol2.TabIndex = 97;
            this.lbl_MablaghKol2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_MablaghKol2.Click += new System.EventHandler(this.lbl_MablaghKol2_Click);
            // 
            // txt_FaslNoFltr
            // 
            this.txt_FaslNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_FaslNoFltr.Location = new System.Drawing.Point(1394, 50);
            this.txt_FaslNoFltr.Name = "txt_FaslNoFltr";
            this.txt_FaslNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_FaslNoFltr.Size = new System.Drawing.Size(39, 21);
            this.txt_FaslNoFltr.TabIndex = 54;
            this.txt_FaslNoFltr.TextChanged += new System.EventHandler(this.txt_FaslNoFltr_TextChanged);
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Location = new System.Drawing.Point(439, 9);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(34, 13);
            this.Label38.TabIndex = 9;
            this.Label38.Text = " واحد:";
            this.Label38.Click += new System.EventHandler(this.Label38_Click);
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(437, 62);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(55, 13);
            this.Label37.TabIndex = 50;
            this.Label37.Text = " توضیحات:";
            this.Label37.Click += new System.EventHandler(this.Label37_Click);
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(1118, 7);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(26, 13);
            this.Label35.TabIndex = 78;
            this.Label35.Text = "ایتم:";
            this.Label35.Click += new System.EventHandler(this.Label35_Click);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(1117, 56);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(58, 13);
            this.Label30.TabIndex = 110;
            this.Label30.Text = "بهای واحد:";
            this.Label30.Click += new System.EventHandler(this.Label30_Click);
            // 
            // txt_ItemBahavahed
            // 
            this.txt_ItemBahavahed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemBahavahed.Location = new System.Drawing.Point(1019, 54);
            this.txt_ItemBahavahed.Name = "txt_ItemBahavahed";
            this.txt_ItemBahavahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemBahavahed.Size = new System.Drawing.Size(100, 21);
            this.txt_ItemBahavahed.TabIndex = 102;
            this.txt_ItemBahavahed.TextChanged += new System.EventHandler(this.txt_ItemBahavahed_TextChanged);
            this.txt_ItemBahavahed.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahed_KeyDown);
            this.txt_ItemBahavahed.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahed_KeyUp);
            this.txt_ItemBahavahed.Leave += new System.EventHandler(this.txt_ItemBahavahed_Leave);
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(1116, 33);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(33, 13);
            this.Label29.TabIndex = 112;
            this.Label29.Text = "تعداد:";
            this.Label29.Click += new System.EventHandler(this.Label29_Click);
            // 
            // txt_ItemTedad
            // 
            this.txt_ItemTedad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemTedad.Location = new System.Drawing.Point(1019, 29);
            this.txt_ItemTedad.Name = "txt_ItemTedad";
            this.txt_ItemTedad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemTedad.Size = new System.Drawing.Size(100, 21);
            this.txt_ItemTedad.TabIndex = 101;
            this.txt_ItemTedad.TextChanged += new System.EventHandler(this.txt_ItemTedad_TextChanged);
            this.txt_ItemTedad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemTedad_KeyDown);
            this.txt_ItemTedad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ItemTedad_KeyPress);
            this.txt_ItemTedad.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ItemTedad_KeyUp);
            this.txt_ItemTedad.Leave += new System.EventHandler(this.txt_ItemTedad_Leave);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(1117, 79);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(51, 13);
            this.Label24.TabIndex = 114;
            this.Label24.Text = "بهای کل:";
            this.Label24.Click += new System.EventHandler(this.Label24_Click);
            // 
            // txt_ItemBahaKol
            // 
            this.txt_ItemBahaKol.Enabled = false;
            this.txt_ItemBahaKol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemBahaKol.Location = new System.Drawing.Point(1019, 79);
            this.txt_ItemBahaKol.Name = "txt_ItemBahaKol";
            this.txt_ItemBahaKol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemBahaKol.Size = new System.Drawing.Size(100, 21);
            this.txt_ItemBahaKol.TabIndex = 115;
            this.txt_ItemBahaKol.TextChanged += new System.EventHandler(this.txt_ItemBahaKol_TextChanged);
            this.txt_ItemBahaKol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahaKol_KeyDown);
            // 
            // Label21
            // 
            this.Label21.AutoSize = true;
            this.Label21.Location = new System.Drawing.Point(275, 8);
            this.Label21.Name = "Label21";
            this.Label21.Size = new System.Drawing.Size(35, 13);
            this.Label21.TabIndex = 116;
            this.Label21.Text = " فصل:";
            this.Label21.Click += new System.EventHandler(this.Label21_Click);
            // 
            // txt_DarsadMeghdar
            // 
            this.txt_DarsadMeghdar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DarsadMeghdar.Location = new System.Drawing.Point(400, 33);
            this.txt_DarsadMeghdar.Name = "txt_DarsadMeghdar";
            this.txt_DarsadMeghdar.Size = new System.Drawing.Size(40, 21);
            this.txt_DarsadMeghdar.TabIndex = 135;
            this.txt_DarsadMeghdar.TextChanged += new System.EventHandler(this.txt_DarsadMeghdar_TextChanged);
            this.txt_DarsadMeghdar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMeghdar_KeyDown);
            this.txt_DarsadMeghdar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMeghdar_KeyUp);
            this.txt_DarsadMeghdar.Leave += new System.EventHandler(this.txt_DarsadMeghdar_Leave);
            // 
            // cmbo_ItemVahed
            // 
            this.cmbo_ItemVahed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_ItemVahed.FormattingEnabled = true;
            this.cmbo_ItemVahed.Location = new System.Drawing.Point(330, 5);
            this.cmbo_ItemVahed.Name = "cmbo_ItemVahed";
            this.cmbo_ItemVahed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ItemVahed.Size = new System.Drawing.Size(110, 23);
            this.cmbo_ItemVahed.TabIndex = 139;
            this.cmbo_ItemVahed.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemVahed_SelectedIndexChanged_1);
            // 
            // cmbo_ItemFasl
            // 
            this.cmbo_ItemFasl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_ItemFasl.FormattingEnabled = true;
            this.cmbo_ItemFasl.Location = new System.Drawing.Point(166, 4);
            this.cmbo_ItemFasl.Name = "cmbo_ItemFasl";
            this.cmbo_ItemFasl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ItemFasl.Size = new System.Drawing.Size(110, 23);
            this.cmbo_ItemFasl.TabIndex = 140;
            this.cmbo_ItemFasl.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemFasl_SelectedIndexChanged);
            this.cmbo_ItemFasl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_ItemFasl_KeyDown);
            this.cmbo_ItemFasl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbo_ItemFasl_KeyPress);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(119, 9);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(33, 13);
            this.Label9.TabIndex = 204;
            this.Label9.Text = " نوع :";
            this.Label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // lbl_ItemNoa
            // 
            this.lbl_ItemNoa.BackColor = System.Drawing.Color.White;
            this.lbl_ItemNoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_ItemNoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_ItemNoa.Location = new System.Drawing.Point(13, 5);
            this.lbl_ItemNoa.Name = "lbl_ItemNoa";
            this.lbl_ItemNoa.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ItemNoa.Size = new System.Drawing.Size(108, 21);
            this.lbl_ItemNoa.TabIndex = 203;
            this.lbl_ItemNoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_ItemNoa.Click += new System.EventHandler(this.lbl_ItemNoa_Click_1);
            // 
            // lbl_DarsadItem
            // 
            this.lbl_DarsadItem.AutoSize = true;
            this.lbl_DarsadItem.Location = new System.Drawing.Point(317, 36);
            this.lbl_DarsadItem.Name = "lbl_DarsadItem";
            this.lbl_DarsadItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_DarsadItem.Size = new System.Drawing.Size(80, 13);
            this.lbl_DarsadItem.TabIndex = 206;
            this.lbl_DarsadItem.Text = "درصد نسبت به  :";
            this.lbl_DarsadItem.Click += new System.EventHandler(this.lbl_DarsadItem_Click);
            // 
            // txt_DarsadMablagh
            // 
            this.txt_DarsadMablagh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_DarsadMablagh.Location = new System.Drawing.Point(13, 33);
            this.txt_DarsadMablagh.Name = "txt_DarsadMablagh";
            this.txt_DarsadMablagh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_DarsadMablagh.Size = new System.Drawing.Size(227, 21);
            this.txt_DarsadMablagh.TabIndex = 102;
            this.txt_DarsadMablagh.TextChanged += new System.EventHandler(this.txt_DarsadMablagh_TextChanged);
            this.txt_DarsadMablagh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMablagh_KeyDown);
            this.txt_DarsadMablagh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_DarsadMablagh_KeyUp);
            this.txt_DarsadMablagh.Leave += new System.EventHandler(this.txt_DarsadMablagh_Leave);
            // 
            // cmbo_DarsadItem
            // 
            this.cmbo_DarsadItem.BackColor = System.Drawing.SystemColors.Window;
            this.cmbo_DarsadItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_DarsadItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbo_DarsadItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbo_DarsadItem.FormattingEnabled = true;
            this.cmbo_DarsadItem.Location = new System.Drawing.Point(245, 32);
            this.cmbo_DarsadItem.Name = "cmbo_DarsadItem";
            this.cmbo_DarsadItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbo_DarsadItem.Size = new System.Drawing.Size(73, 23);
            this.cmbo_DarsadItem.TabIndex = 99;
            this.cmbo_DarsadItem.SelectedIndexChanged += new System.EventHandler(this.cmbo_DarsadItem_SelectedIndexChanged_1);
            // 
            // txt_Tozihat
            // 
            this.txt_Tozihat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_Tozihat.Location = new System.Drawing.Point(12, 60);
            this.txt_Tozihat.Name = "txt_Tozihat";
            this.txt_Tozihat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Tozihat.Size = new System.Drawing.Size(428, 21);
            this.txt_Tozihat.TabIndex = 142;
            this.txt_Tozihat.TextChanged += new System.EventHandler(this.txt_Tozihat_TextChanged_1);
            this.txt_Tozihat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Tozihat_KeyDown);
            // 
            // txt_ItemSharh
            // 
            this.txt_ItemSharh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txt_ItemSharh.Location = new System.Drawing.Point(501, 7);
            this.txt_ItemSharh.Multiline = true;
            this.txt_ItemSharh.Name = "txt_ItemSharh";
            this.txt_ItemSharh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ItemSharh.Size = new System.Drawing.Size(472, 91);
            this.txt_ItemSharh.TabIndex = 141;
            this.txt_ItemSharh.TextChanged += new System.EventHandler(this.txt_ItemSharh_TextChanged);
            this.txt_ItemSharh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemSharh_KeyDown);
            // 
            // txt_ItemNo
            // 
            this.txt_ItemNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txt_ItemNo.Location = new System.Drawing.Point(1019, 4);
            this.txt_ItemNo.Name = "txt_ItemNo";
            this.txt_ItemNo.Size = new System.Drawing.Size(100, 21);
            this.txt_ItemNo.TabIndex = 100;
            this.txt_ItemNo.TextChanged += new System.EventHandler(this.txt_ItemNo_TextChanged_1);
            this.txt_ItemNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNo_KeyDown1);
            this.txt_ItemNo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNo_KeyUp);
            this.txt_ItemNo.Leave += new System.EventHandler(this.txt_ItemNo_Leave);
            // 
            // pnl_Item
            // 
            this.pnl_Item.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnl_Item.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Item.Controls.Add(this.btn_Insert);
            this.pnl_Item.Controls.Add(this.btn_Print);
            this.pnl_Item.Controls.Add(this.btn_Delete);
            this.pnl_Item.Controls.Add(this.btn_copy);
            this.pnl_Item.Controls.Add(this.Btn_Return);
            this.pnl_Item.Controls.Add(this.Btn_Save);
            this.pnl_Item.Controls.Add(this.txt_ItemNo);
            this.pnl_Item.Controls.Add(this.txt_ItemSharh);
            this.pnl_Item.Controls.Add(this.txt_Tozihat);
            this.pnl_Item.Controls.Add(this.btn_Import);
            this.pnl_Item.Controls.Add(this.cmbo_DarsadItem);
            this.pnl_Item.Controls.Add(this.txt_DarsadMablagh);
            this.pnl_Item.Controls.Add(this.btn_Calculate);
            this.pnl_Item.Controls.Add(this.lbl_DarsadItem);
            this.pnl_Item.Controls.Add(this.lbl_ItemNoa);
            this.pnl_Item.Controls.Add(this.Label9);
            this.pnl_Item.Controls.Add(this.cmbo_ItemFasl);
            this.pnl_Item.Controls.Add(this.cmbo_ItemVahed);
            this.pnl_Item.Controls.Add(this.txt_DarsadMeghdar);
            this.pnl_Item.Controls.Add(this.Label21);
            this.pnl_Item.Controls.Add(this.txt_ItemBahaKol);
            this.pnl_Item.Controls.Add(this.Label24);
            this.pnl_Item.Controls.Add(this.txt_ItemTedad);
            this.pnl_Item.Controls.Add(this.Label29);
            this.pnl_Item.Controls.Add(this.txt_ItemBahavahed);
            this.pnl_Item.Controls.Add(this.Label30);
            this.pnl_Item.Controls.Add(this.Label35);
            this.pnl_Item.Controls.Add(this.Label37);
            this.pnl_Item.Controls.Add(this.Label38);
            this.pnl_Item.Location = new System.Drawing.Point(15, 566);
            this.pnl_Item.Name = "pnl_Item";
            this.pnl_Item.Size = new System.Drawing.Size(1180, 141);
            this.pnl_Item.TabIndex = 88;
            this.pnl_Item.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Item_Paint);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(773, 109);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(80, 26);
            this.btn_Insert.TabIndex = 211;
            this.btn_Insert.Text = " ایجاد (Ins)";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(294, 109);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(80, 26);
            this.btn_Print.TabIndex = 144;
            this.btn_Print.Text = "چاپ (Ctrl + P)  ";
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(461, 109);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(80, 26);
            this.btn_Delete.TabIndex = 202;
            this.btn_Delete.Text = " حذف (Del)";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(617, 109);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(80, 26);
            this.btn_copy.TabIndex = 201;
            this.btn_copy.Text = "کپی (Ctrl + C) ";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // Btn_Return
            // 
            this.Btn_Return.Location = new System.Drawing.Point(143, 109);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(80, 26);
            this.Btn_Return.TabIndex = 200;
            this.Btn_Return.Text = "بازگشت (Esc)";
            this.Btn_Return.UseVisualStyleBackColor = true;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(953, 109);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(80, 26);
            this.Btn_Save.TabIndex = 143;
            this.Btn_Save.Text = " ذخیره  (F2)";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.LightGray;
            this.btn_Filter.Enabled = false;
            this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Filter.ForeColor = System.Drawing.Color.Black;
            this.btn_Filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filter.Image")));
            this.btn_Filter.Location = new System.Drawing.Point(1137, 0);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(38, 59);
            this.btn_Filter.TabIndex = 93;
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Visible = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click_1);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(15, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1158, 34);
            this.PictureBox1.TabIndex = 75;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.BackColor = System.Drawing.Color.LightGray;
            this.btn_Import.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Import.ForeColor = System.Drawing.Color.Black;
            this.btn_Import.Image = ((System.Drawing.Image)(resources.GetObject("btn_Import.Image")));
            this.btn_Import.Location = new System.Drawing.Point(996, 8);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(22, 22);
            this.btn_Import.TabIndex = 210;
            this.btn_Import.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Import.UseVisualStyleBackColor = false;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.BackColor = System.Drawing.Color.LightGray;
            this.btn_Calculate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Black;
            this.btn_Calculate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Calculate.Image")));
            this.btn_Calculate.Location = new System.Drawing.Point(997, 54);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(22, 22);
            this.btn_Calculate.TabIndex = 207;
            this.btn_Calculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Calculate.UseVisualStyleBackColor = false;
            this.btn_Calculate.Visible = false;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // Frm_AsnadDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1204, 711);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Filter);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.pnl_Fosool);
            this.Controls.Add(this.pnl_Item);
            this.Controls.Add(this.dtg_AsnadDetail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_AsnadDetail";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند شماره :";
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_AsnadDetail)).EndInit();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel8.ResumeLayout(false);
            this.Panel8.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            this.pnl_Fosool.ResumeLayout(false);
            this.pnl_SanadSum.ResumeLayout(false);
            this.pnl_SanadSum.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_FosoolSum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_SanadSum)).EndInit();
            this.pnl_MablaghKol.ResumeLayout(false);
            this.pnl_Item.ResumeLayout(false);
            this.pnl_Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

		private void Frm_AsnadDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_AsnadDetail_Load(object sender, EventArgs e)
		{
			DtgAsnadDetailRefresh = 0;
			TableSanadSum.Columns.AddRange(new DataColumn[8]
			{
				new DataColumn("recnum", typeof(int)),
				new DataColumn("SanadNo", typeof(string)),
				new DataColumn("ردیف", typeof(string)),
				new DataColumn("شرح", typeof(string)),
				new DataColumn("نوع", typeof(string)),
				new DataColumn("درصد", typeof(decimal)),
				new DataColumn("مبلغ", typeof(decimal)),
				new DataColumn("مانده", typeof(decimal))
			});
			TableFosoolSum.Columns.AddRange(new DataColumn[7]
			{
				new DataColumn("sanadnum", typeof(string)),
				new DataColumn("ردیف", typeof(string)),
				new DataColumn("فصل", typeof(string)),
				new DataColumn("شرح", typeof(string)),
				new DataColumn("جمع_بدون_ضریب", typeof(decimal)),
				new DataColumn("ضریب", typeof(decimal)),
				new DataColumn("جمع_با_ضریب", typeof(decimal))
			});
			lbl_SanadNo.Text = Module1.SanadNoSelected;
			base.KeyPreview = true;
			pnl_SanadSum.Visible = false;
			dtg_SanadSum.Height = 160;
			pnl_MablaghKol.Visible = true;
			Btn_AsnadDetailSit = "";
			cmbo_ItemNoaFltr.Items.Clear();
			cmbo_ItemNoaFltr.Items.Add("بها دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی");
			cmbo_ItemNoaFltr.Items.Add("ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("درصدی - ستاره دار");
			cmbo_ItemNoaFltr.Items.Add("توافقی");
			cmbo_ItemNoaFltr.Items.Add("");
			cmbo_SumSharh.Items.Clear();
			if (Operators.CompareString(Module1.SanadRec.fehrestfile, "FEHBAHA1401", TextCompare: false) == 0)
			{
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/47 فصول اول تا سوم بخشنامه 1403/129444");
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/50 فصل چهارم بخشنامه 1403/129444");
				cmbo_SumSharh.Items.Add("تعدیل بابت ضریب 1/55 فصول پنجم و ششم بخشنامه 1403/129444");
			}
			cmbo_SumSharh.Items.Add("مالیات و عوارض");
			cmbo_SumSharh.Items.Add("تخفیف");
			cmbo_SumSharh.Items.Add("کسر می شود پیش پرداخت");
			cmbo_SumSharh.Items.Add(" کسر می شود صورت وضعیت موقت شماره");
			cmbo_SumSharh.Items.Add("سایر موارد");
			cmbo_SumNoa.Items.Clear();
			cmbo_SumNoa.Items.Add("درصد");
			cmbo_SumNoa.Items.Add("مقطوع");
			switch (Module1.SanadRec.NoaSanad.Trim())
			{
			case "فاکتور":
				fopf = true;
				Module1.NoaSanad = "فاکتور";
				Text = "فاکتور شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "پیش فاکتور":
				fopf = false;
				Module1.NoaSanad = "پیش فاکتور";
				Text = "پیش فاکتور شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "صوری":
				Module1.soori = 1;
				Module1.Ghaleb = 0;
				fopf = Module1.SanadRec.forpf;
				Module1.NoaSanad = "صوری";
				Text = "فاکتور صوری شماره : " + Module1.SanadRec.sanadnum;
				break;
			case "قالب":
				Module1.Ghaleb = 1;
				Module1.soori = 0;
				fopf = Module1.SanadRec.forpf;
				Module1.NoaSanad = "قالب";
				Text = "قالب شماره : " + Module1.SanadRec.sanadnum;
				break;
			}
			Load_dtg_AsnadDetail(Module1.SanadNoSelected);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			foreach (Control control7 in pnl_Item.Controls)
			{
				if (control7 is TextBox || control7 is ComboBox || control7 is Button)
				{
					control7.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control7.KeyDown += GeneralKeyDownHandler1;
				}
				if (control7 is TextBox || control7 is Button)
				{
					control7.KeyDown += GeneralKeyDownHandler2;
				}
			}
			foreach (Control control8 in pnl_SanadSum.Controls)
			{
				if (control8 is TextBox || control8 is ComboBox || control8 is Button)
				{
					control8.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control8.KeyDown += GeneralKeyDownHandler1;
				}
				if (control8 is TextBox || control8 is Button)
				{
					control8.KeyDown += GeneralKeyDownHandler2;
				}
			}
			DtgAsnadDetailRefresh = 1;
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [ShomareSanad] FROM [Dabirkhane].[dbo].[SoratVazeyatGharardadha] Where [ShomareSanad] = '" + Module1.SanadNoSelected + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(" .سند توسط امور قراردادها ثبت شده است تغییرات ممکن نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				Module1.SanadSabtGharardadha = true;
				foreach (Control control9 in pnl_Item.Controls)
				{
					if (!(control9 is Button))
					{
						control9.Enabled = false;
					}
				}
				foreach (Control control10 in pnl_SanadSum.Controls)
				{
					if (!(control10 is Button))
					{
						control10.Enabled = false;
					}
				}
				btn_Modify1.Visible = false;
			}
			else
			{
				Module1.SanadSabtGharardadha = false;
				foreach (Control control11 in pnl_Item.Controls)
				{
					if (!(control11 is Button))
					{
						control11.Enabled = true;
					}
				}
				foreach (Control control12 in pnl_SanadSum.Controls)
				{
					if (!(control12 is Button))
					{
						control12.Enabled = true;
					}
				}
				btn_Modify1.Visible = true;
			}
			sqlDataReader.Close();
		}

		private void GeneralKeyDownHandler1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
			}
			if (SetItemNomFocus == 1)
			{
				txt_ItemNo.Text = "";
				txt_ItemNo.Focus();
				SetItemNomFocus = 0;
			}
			else if (SetItemNomFocus == 2)
			{
				Btn_Return.Focus();
				SetDarsadMablaghFocus = 0;
			}
			if (SetDarsadMablaghFocus == 1)
			{
				txt_DarsadMablagh.Text = "";
				txt_DarsadMablagh.Focus();
				SetDarsadMablaghFocus = 0;
			}
			else if (SetDarsadMablaghFocus == 2)
			{
				cmbo_DarsadItem.Focus();
				SetDarsadMablaghFocus = 0;
			}
			if (e.KeyCode == Keys.Escape)
			{
				dtg_AsnadDetail.Focus();
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
			foreach (Control control4 in pnl_SanadSum.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		private void ShowItemRecord()
		{
			int index = 0;
			int lErl = default(int);
			if (dtg_AsnadDetail.RowCount != 0)
			{
				try
				{
					index = dtg_AsnadDetail.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				Module1.DatePikerSit = false;
				if (dtg_AsnadDetail.RowCount != 0)
				{
					Module1.ItemRec.recnum = Conversions.ToInteger(dtg_AsnadDetail.Rows[index].Cells[0].Value);
					Module1.ItemRec.Radif = dtg_AsnadDetail.Rows[index].Cells[2].Value.ToString();
					Module1.ItemRec.sanadnum = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[3].Value);
					Module1.ItemRec.itemnum = dtg_AsnadDetail.Rows[index].Cells[4].Value.ToString();
					Module1.ItemRec.fasl = dtg_AsnadDetail.Rows[index].Cells[5].Value.ToString();
					Module1.ItemRec.ItemNoa = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[6].Value);
					switch (Module1.ItemRec.ItemNoa.Trim())
					{
					case "بها دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("0");
						Module1.ItemRec.setarehdar = Conversions.ToByte("0");
						break;
					case "درصدی":
						Module1.ItemRec.darsadi = Conversions.ToByte("1");
						Module1.ItemRec.setarehdar = Conversions.ToByte("0");
						break;
					case "ستاره دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("0");
						Module1.ItemRec.setarehdar = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						Module1.ItemRec.darsadi = Conversions.ToByte("1");
						Module1.ItemRec.setarehdar = Conversions.ToByte("1");
						break;
					}
					Module1.ItemRec.sharhitem = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[7].Value);
					Module1.ItemRec.shvahed = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[8].Value);
					Module1.ItemRec.ghvahed = dtg_AsnadDetail.Rows[index].Cells[9].Value.ToString();
					Module1.ItemRec.total = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[10].Value);
					Module1.ItemRec.mablagh = dtg_AsnadDetail.Rows[index].Cells[11].Value.ToString();
					Module1.ItemRec.DarsadMeghdar = Conversions.ToString(dtg_AsnadDetail.Rows[index].Cells[12].Value);
					Module1.ItemRec.DarsadItem = dtg_AsnadDetail.Rows[index].Cells[13].Value.ToString();
					Module1.ItemRec.DarsadMablagh = dtg_AsnadDetail.Rows[index].Cells[14].Value.ToString();
					switch (Module1.ItemRec.DarsadMablagh.Trim())
					{
					case "0":
						Module1.ItemRec.Mablaghi = Conversions.ToByte("0");
						break;
					case null:
					case "":
						Module1.ItemRec.Mablaghi = Conversions.ToByte("0");
						break;
					default:
						Module1.ItemRec.Mablaghi = Conversions.ToByte("1");
						break;
					}
					Module1.ItemRec.molahezat = dtg_AsnadDetail.Rows[index].Cells[15].Value.ToString();
					txt_ItemNo.Text = Module1.ItemRec.itemnum;
					cmbo_ItemFasl.Text = Module1.ItemRec.fasl;
					lbl_ItemNoa.Text = Module1.ItemRec.ItemNoa;
					txt_ItemSharh.Text = Module1.ItemRec.sharhitem;
					cmbo_ItemVahed.Text = Module1.ItemRec.shvahed;
					txt_ItemBahavahed.Text = Module1.ItemRec.ghvahed;
					txt_ItemTedad.Text = Module1.ItemRec.total;
					if (Operators.CompareString(Module1.ItemRec.mablagh, "", TextCompare: false) != 0)
					{
						txt_ItemBahaKol.Text = Conversions.ToString(Convert.ToInt64(Conversions.ToDouble(Module1.ItemRec.mablagh)));
					}
					txt_DarsadMeghdar.Text = Module1.ItemRec.DarsadMeghdar;
					if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
					{
						LoadCmboDarsadItems();
						if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0))
						{
							cmbo_DarsadItem.Text = ": مبلغ";
							txt_DarsadMablagh.Text = Module1.ItemRec.DarsadMablagh;
						}
						else
						{
							cmbo_DarsadItem.Text = ": ایتم";
							txt_DarsadMablagh.Text = Module1.ItemRec.DarsadItem;
						}
					}
					else
					{
						cmbo_DarsadItem.DataSource = null;
					}
					txt_Tozihat.Text = Module1.ItemRec.molahezat;
				}
			}
			lErl = 60;
		}

		private void ShowSanadSumRecord()
		{
			if (ExitFrmAsnadDetail == 1)
			{
				ExitFrmAsnadDetail = 0;
				return;
			}
			ref SanadSumDetailes sanadSumRec = ref SanadSumRec;
			int num;
			int lErl = default(int);
			try
			{
				num = dtg_SanadSum.CurrentRow.Index;
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				num = 0;
				ProjectData.ClearProjectError();
			}
			if (dtg_SanadSum.RowCount == 1 || num == 0)
			{
				BtnCommand1 = "New";
				sanadSumRec.recnum = Conversions.ToInteger("0");
				sanadSumRec.sanadnum = lbl_SanadNo.Text;
				sanadSumRec.Radif = Conversions.ToInteger("0");
				sanadSumRec.Sharh = "جمع سند با ضریب";
				sanadSumRec.Noa = "";
				sanadSumRec.Darsad = "0";
				sanadSumRec.Mablagh = Conversions.ToString(SumFosoolWithZarib);
				txt_SumRadif.Text = "0";
				cmbo_SumSharh.Text = "جمع سند با ضریب";
				cmbo_SumNoa.Text = "";
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				lbl_SumMande.Text = Conversions.ToString(SumFosoolWithZarib);
				txt_SumRadif.Enabled = false;
				cmbo_SumSharh.Enabled = false;
				cmbo_SumNoa.Enabled = false;
				txt_SumDarsad.Enabled = false;
				txt_SumMablagh.Enabled = false;
				foreach (Control control in pnl_SanadSum.Controls)
				{
					if (((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox)))
					{
						control.ForeColor = Color.Black;
					}
				}
				pnl_SanadSum.BackColor = Color.LightSteelBlue;
			}
			else
			{
				txt_SumRadif.Enabled = true;
				cmbo_SumSharh.Enabled = true;
				cmbo_SumNoa.Enabled = true;
				txt_SumDarsad.Enabled = true;
				txt_SumMablagh.Enabled = true;
				BtnCommand1 = "";
				checked
				{
					if (dtg_SanadSum.RowCount != 0)
					{
						int index = dtg_SanadSum.CurrentRow.Index;
						sanadSumRec.recnum = Conversions.ToInteger(dtg_SanadSum.Rows[index].Cells[0].Value);
						sanadSumRec.sanadnum = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[1].Value.ToString();
						sanadSumRec.Radif = Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[2].Value.ToString());
						sanadSumRec.Sharh = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[3].Value.ToString();
						sanadSumRec.Noa = dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[4].Value.ToString();
						sanadSumRec.Darsad = Conversions.ToString(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[5].Value);
						txt_SumRadif.Text = Conversions.ToString(sanadSumRec.Radif);
						cmbo_SumSharh.Text = sanadSumRec.Sharh;
						cmbo_SumNoa.Text = sanadSumRec.Noa;
						txt_SumDarsad.Text = sanadSumRec.Darsad;
						if (dtg_SanadSum.CurrentRow.Index != 0)
						{
							string left = sanadSumRec.Noa.Trim();
							if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
							{
								if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
								{
									sanadSumRec.Mablagh = Conversions.ToString(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index].Cells[6].Value);
									txt_SumMablagh.Enabled = true;
									txt_SumDarsad.Text = "";
									txt_SumDarsad.Enabled = false;
								}
							}
							else
							{
								sanadSumRec.Mablagh = Math.Truncate(Conversions.ToDouble(Operators.DivideObject(Operators.MultiplyObject(sanadSumRec.Darsad, dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index - 1].Cells[7].Value), 100))).ToString();
								txt_SumMablagh.Enabled = false;
							}
							txt_SumMablagh.Text = Strings.FormatNumber(Conversions.ToLong(sanadSumRec.Mablagh), 0, TriState.True);
							lbl_SumMande.Text = Strings.FormatNumber(Operators.AddObject(dtg_SanadSum.Rows[dtg_SanadSum.CurrentRow.Index - 1].Cells[7].Value, Conversions.ToDouble(sanadSumRec.Mablagh)), 0, TriState.True);
						}
					}
				}
			}
			lErl = 10;
		}

		private void dtg_AsnadDetail_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

		private void dtg_AsnadDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowItemRecord();
		}

		private void dtg_AsnadDetail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.P)
			{
				btn_Print_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_ItemNo.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_AsnadDetail_RowValidated(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dtg_AsnadDetail_SelectionChanged(object sender, EventArgs e)
		{
			SetItemNomFocus = 0;
			if ((LoadDtgAsnadDetail == 1) | (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0))
			{
				ShowItemRecord();
				SetPnl_ItemBlue();
				return;
			}
			if (pnl_Item.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				switch (dialogResult)
				{
				case DialogResult.No:
					SetPnl_ItemBlue();
					break;
				case DialogResult.Cancel:
					txt_ItemNo.Focus();
					return;
				}
			}
			ShowItemRecord();
		}

		private void cmbo_ItemNoaFltr_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_ItemNoaFltr.Text, "", TextCompare: false) != 0)
			{
				string text = null;
				text = cmbo_ItemNoaFltr.Text;
				switch (text.Trim())
				{
				case "بها دار":
					ItemNoa_Filter = " ([darsad] Like '0'And [setarehdar] Like '0')";
					break;
				case "درصدی":
					ItemNoa_Filter = " ([darsad] Like '1'And [setarehdar] Like '0')";
					break;
				case "ستاره دار":
					ItemNoa_Filter = " ([darsad] Like '0'And [setarehdar] Like '1')";
					break;
				case "درصدی - ستاره دار":
					ItemNoa_Filter = " ([darsad] Like '1'And [setarehdar] Like '1')";
					break;
				case null:
				case "":
					ItemNoa_Filter = "";
					break;
				}
			}
			else
			{
				ItemNoa_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		public void Load_dtg_FosoolSum()
		{
			TableFosoolSum.Clear();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = " SELECT sanadnum,fasl As 'ردیف', fasl As 'فصل' ,(SELECT [FaslComment] FROM [dbo].[Fosool] where FehrestFile ='" + Module1.CurrentFehrestFile + "' and FaslCode =fasl) As 'شرح' ,Sum([mablagh]) As 'جمع_بدون_ضریب' ,(SELECT Cast([ZaribCode] As float) FROM [dbo].[Fosool] where FehrestFile ='" + Module1.CurrentFehrestFile + "' and FaslCode =fasl) As 'ضریب' ,(SELECT CAST([mablaghk] AS FLOAT) FROM [dbo].[Asnad1] where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fehrestfile]='" + Module1.CurrentFehrestFile + "' And [forpf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "') As 'جمع_با_ضریب'  FROM [dbo].[Asnad2] Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' Group by [sanadnum],[fasl] Order by [sanadnum],[fasl]";
			int lErl = 1;
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			TableFosoolSum.Load(sqlDataReader);
			sqlDataReader.Close();
			foreach (DataColumn column in TableFosoolSum.Columns)
			{
				column.ReadOnly = false;
			}
			SumFosoolWithZarib = 0.0;
			SumFosoolNoZarib = 0.0;
			checked
			{
				int num = TableFosoolSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					TableFosoolSum.Rows[i]["ردیف"] = i + 1;
					try
					{
						object left = TableFosoolSum.Rows[i]["ضریب"];
						if (Operators.ConditionalCompareObjectEqual(left, 0, TextCompare: false))
						{
							TableFosoolSum.Rows[i]["ضریب"] = "1";
						}
						else if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, 1, TextCompare: false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 3, TextCompare: false))))
						{
							TableFosoolSum.Rows[i]["ضریب"] = Module1.Zarib_1;
						}
						else if (Conversions.ToBoolean(Conversions.ToBoolean(Operators.CompareObjectEqual(left, 2, TextCompare: false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(left, 4, TextCompare: false))))
						{
							TableFosoolSum.Rows[i]["ضریب"] = Module1.Zarib_2;
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, lErl);
						Exception ex2 = ex;
						TableFosoolSum.Rows[i]["ضریب"] = "1";
						ProjectData.ClearProjectError();
					}
					TableFosoolSum.Rows[i]["جمع_با_ضریب"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Round", new object[1] { Operators.MultiplyObject(TableFosoolSum.Rows[i]["جمع_بدون_ضریب"], TableFosoolSum.Rows[i]["ضریب"]) }, null, null, null));
					SumFosoolNoZarib = Conversions.ToDouble(Operators.AddObject(SumFosoolNoZarib, TableFosoolSum.Rows[i]["جمع_بدون_ضریب"]));
					SumFosoolWithZarib = Conversions.ToDouble(Operators.AddObject(SumFosoolWithZarib, TableFosoolSum.Rows[i]["جمع_با_ضریب"]));
				}
				DataRow dataRow = TableFosoolSum.NewRow();
				dataRow["sanadnum"] = "0";
				dataRow["ردیف"] = "";
				dataRow["فصل"] = "";
				dataRow["شرح"] = "جمع فصول";
				dataRow["جمع_بدون_ضریب"] = SumFosoolNoZarib;
				dataRow["جمع_با_ضریب"] = SumFosoolWithZarib;
				TableFosoolSum.Rows.Add(dataRow);
				dtg_FosoolSum.DataSource = TableFosoolSum;
				dtg_FosoolSum.Columns[4].DefaultCellStyle.Format = "N0";
				dtg_FosoolSum.Columns[5].DefaultCellStyle.Format = "C3";
				dtg_FosoolSum.Columns[6].DefaultCellStyle.Format = "N0";
				dtg_FosoolSum.Columns[0].Width = 0;
				dtg_FosoolSum.Columns[0].Visible = false;
				dtg_FosoolSum.Columns[1].Width = 35;
				dtg_FosoolSum.Columns[2].Width = 35;
				dtg_FosoolSum.Columns[3].Width = 222;
				dtg_FosoolSum.Columns[4].Width = 100;
				dtg_FosoolSum.Columns[5].Width = 50;
				dtg_FosoolSum.Columns[6].Width = 100;
				dtg_FosoolSum.Refresh();
				Module1.dtg_Color(dtg_FosoolSum);
				foreach (object column2 in dtg_FosoolSum.Columns)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(column2);
					NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
				}
			}
		}

		public void Load_dtg_SanadSum()
		{
			double num = Conversions.ToDouble(lbl_SanadZarib1.Text);
			double num2 = Conversions.ToDouble(lbl_SanadZarib2.Text);
			TableSanadSum.Clear();
			LoadDtgAsnadSanadSum = 1;
			foreach (DataColumn column in TableSanadSum.Columns)
			{
				column.ReadOnly = false;
			}
			DataRow dataRow = TableSanadSum.NewRow();
			dataRow["recnum"] = 0;
			dataRow["SanadNo"] = lbl_SanadNo.Text;
			dataRow["ردیف"] = 0;
			dataRow["شرح"] = "جمع سند با ضریب";
			dataRow["نوع"] = "";
			dataRow["درصد"] = 0;
			dataRow["مبلغ"] = SumFosoolWithZarib;
			dataRow["مانده"] = SumFosoolWithZarib;
			TableSanadSum.Rows.Add(dataRow);
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "Select [recnum],[sanadnum],[recnum] As 'ردیف',[Sharh] As 'شرح',[darsad] As 'نوع',[Darsad] As 'درصد',Cast([mablagh] As decimal(18,2)) As 'مبلغ', Cast([mablaghk] As numeric(18,2)) As 'مانده' FROM [dbo].[asnad4] Where sanadnum ='" + lbl_SanadNo.Text + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' And ([darsad] <> '0' or [maghtoo] <> '0') Order by [recnum]";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			checked
			{
				if (sqlDataReader.HasRows)
				{
					while (sqlDataReader.Read())
					{
						DataRow dataRow2 = TableSanadSum.NewRow();
						dataRow2["recnum"] = sqlDataReader[0].ToString();
						dataRow2["SanadNo"] = sqlDataReader[1].ToString();
						dataRow2["ردیف"] = sqlDataReader[2].ToString();
						dataRow2["شرح"] = sqlDataReader[3].ToString();
						if (Operators.CompareString(sqlDataReader[5].ToString().Trim(), "0", TextCompare: false) != 0)
						{
							dataRow2["نوع"] = "درصد";
						}
						else
						{
							dataRow2["نوع"] = "مقطوع";
						}
						dataRow2["درصد"] = RuntimeHelpers.GetObjectValue(sqlDataReader[5]);
						dataRow2["مبلغ"] = RuntimeHelpers.GetObjectValue(sqlDataReader[6]);
						dataRow2["مانده"] = RuntimeHelpers.GetObjectValue(sqlDataReader[7]);
						TableSanadSum.Rows.Add(dataRow2);
					}
					sqlDataReader.Close();
					TableSanadSum.Rows[0]["مانده"] = SumFosoolWithZarib;
					int num3 = TableSanadSum.Rows.Count - 1;
					for (int i = 0; i <= num3; i++)
					{
						TableSanadSum.Rows[i]["ردیف"] = i;
						if (i != 0)
						{
							if (Operators.CompareString(TableSanadSum.Rows[i]["درصد"].ToString(), "0", TextCompare: false) != 0)
							{
								TableSanadSum.Rows[i]["مبلغ"] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(null, typeof(Math), "Truncate", new object[1] { Operators.DivideObject(Operators.MultiplyObject(TableSanadSum.Rows[i]["درصد"], TableSanadSum.Rows[i - 1]["مانده"]), 100) }, null, null, null));
							}
							switch (TableSanadSum.Rows[i]["شرح"].ToString())
							{
							case "تعديل بابت ضريب 1/47 فصول اول تا سوم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.47 * (num * (SumFasl("1") + SumFasl("2")) + SumFasl("3"));
								break;
							case "تعديل بابت ضريب 1/50 فصل چهارم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.5 * SumFasl("4");
								break;
							case "تعديل بابت ضريب 1/55 فصول پنجم و ششم بخشنامه 1403/129444":
								TableSanadSum.Rows[i]["مبلغ"] = 0.55 * (num2 * SumFasl("5") + num * SumFasl("6"));
								break;
							}
							TableSanadSum.Rows[i]["مانده"] = Operators.AddObject(TableSanadSum.Rows[i - 1]["مانده"], TableSanadSum.Rows[i]["مبلغ"]);
						}
					}
				}
				dtg_SanadSum.DataSource = TableSanadSum;
				dtg_SanadSum.Columns[6].DefaultCellStyle.Format = "N0";
				dtg_SanadSum.Columns[7].DefaultCellStyle.Format = "N0";
				dtg_SanadSum.Columns[0].Visible = false;
				dtg_SanadSum.Columns[1].Visible = false;
				dtg_SanadSum.Columns[2].Width = 40;
				dtg_SanadSum.Columns[3].Width = 190;
				dtg_SanadSum.Columns[4].Width = 40;
				dtg_SanadSum.Columns[5].Width = 70;
				dtg_SanadSum.Columns[6].Width = 100;
				dtg_SanadSum.Columns[7].Width = 100;
				GhabelPardakht = Conversions.ToString(TableSanadSum.Rows[TableSanadSum.Rows.Count - 1]["مانده"]);
				lbl_MablaghKol1.Text = Strings.FormatNumber(GhabelPardakht, 0, TriState.True);
				lbl_MablaghKol2.Text = "( " + Num2Text.ToFarsi(Conversions.ToLong(lbl_MablaghKol1.Text)) + "  ریال )";
				lbl_GhabelPardakht.Text = "       " + lbl_MablaghKol2.Text + "       " + lbl_MablaghKol1.Text;
				foreach (object column2 in dtg_SanadSum.Columns)
				{
					object objectValue = RuntimeHelpers.GetObjectValue(column2);
					NewLateBinding.LateSet(objectValue, null, "SortMode", new object[1] { DataGridViewColumnSortMode.NotSortable }, null, null);
				}
				dtg_SanadSum.Rows[0].ReadOnly = true;
				Module1.dtg_Color(dtg_SanadSum);
				int num4 = dtg_SanadSum.Columns.Count - 1;
				for (int j = 0; j <= num4; j++)
				{
					dtg_SanadSum.Rows[0].Cells[j].Style.BackColor = Color.SteelBlue;
					dtg_SanadSum.Rows[0].Cells[j].Style.ForeColor = Color.White;
				}
				LoadDtgAsnadSanadSum = 0;
			}
		}

		private void dtg_SanadSum_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_SanadSum.CurrentCell.RowIndex == 0)
			{
				dtg_SanadSum.CurrentCell.Selected = false;
				BtnCommand1 = "New";
			}
			else
			{
				BtnCommand1 = "";
			}
			if (pnl_SanadSum.Visible)
			{
				ShowSanadSumRecord();
			}
		}

		private void dtg_SanadSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dtg_SanadSum.CurrentCell.RowIndex == 0)
			{
				dtg_SanadSum.CurrentCell.Selected = false;
				BtnCommand1 = "New";
			}
			else
			{
				BtnCommand1 = "";
			}
			if (pnl_SanadSum.Visible)
			{
				ShowSanadSumRecord();
			}
		}

		public void Load_dtg_AsnadDetail(string SanadNo)
		{
			LoadDtgAsnadDetail = 1;
			AsnadDetailTable.Clear();
			string[] array = new string[12];
			int lErl = default(int);
			try
			{
                //Module1.CurrRow = dtg_AsnadDetail.CurrentRow.Index;
                if (dtg_AsnadDetail.CurrentRow != null)
                {
                    Module1.CurrRow = dtg_AsnadDetail.CurrentRow.Index;
                }
                else if (dtg_AsnadDetail.Rows.Count > 0)
                {
                    // اگر هیچ سطری انتخاب نشده، اولین سطر را انتخاب کن
                    dtg_AsnadDetail.Rows[0].Selected = true;
                    dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[0].Cells[0];
                    Module1.CurrRow = 0;
                }
                else
                {
                    Module1.CurrRow = -1; // یا هر مقدار پیش‌فرض دیگر
                }
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
				if (Operators.CompareString(ItemNo_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemFasl_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemNoa_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
					{
						array[3] = " And ";
					}
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemSharh_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
					{
						array[4] = " And ";
					}
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemVahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
					{
						array[5] = " And ";
					}
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahavahed_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
					{
						array[6] = " And ";
					}
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemTedad_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
					{
						array[7] = " And ";
					}
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(ItemBahaKol_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
					{
						array[8] = " And ";
					}
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadMeghdar_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
					{
						array[9] = " And ";
					}
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadItem_Filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0)
					{
						array[10] = " And ";
					}
					if (Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
					{
						array[11] = " And ";
					}
				}
				if (Operators.CompareString(DarsadMablagh_Filter, "", TextCompare: false) != 0 && Operators.CompareString(Tozihat_Filter, "", TextCompare: false) != 0)
				{
					array[11] = " And ";
				}
				Module1.strWhere = " WHERE " + ItemNo_Filter + array[1] + ItemFasl_Filter + array[2] + ItemNoa_Filter + array[3] + ItemSharh_Filter + array[4] + ItemVahed_Filter + array[5] + ItemBahavahed_Filter + array[6] + ItemTedad_Filter + array[7] + ItemBahaKol_Filter + array[8] + DarsadMeghdar_Filter + array[9] + DarsadItem_Filter + array[10] + DarsadMablagh_Filter + array[11] + Tozihat_Filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " Where sanadnum ='" + SanadNo + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				}
				else
				{
					Module1.strWhere = Module1.strWhere + " And sanadnum ='" + SanadNo + "' And [fopf] = '" + Conversions.ToString(fopf) + "' And [Salmali]='" + lbl_SalMali.Text + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					txt_ItemRadifFltr.Text = "";
				}
				lErl = 10;
				Module1.MyConn.Close();
				Module1.MyConn.Open();
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [recnum] As 'recnum',[radif] As 'ردیف',[radif] As 'ردیف ایتم',[sanadnum] As 'شماره سند', [itemnum] As 'شماره ایتم',[fasl] As 'فصل',Cast([darsad] As varchar(25))+Cast([setarehdar]  As varchar(25)) As 'نوع ایتم', [sharhitem] As 'شرح ایتم', [shvahed] As 'واحد', Cast([ghvahed]  As Float) As 'بهای واحد',Cast([total]  As Float) As 'تعداد', Cast([mablagh] As Float) As 'بهای_کل',[itemdarsad] As 'درصد',[itemname] As 'نسبت به ایتم',[NesbatbeMablagh] As 'نسبت به مبلغ', [molahezat] As 'توضیحات' FROM [dbo].[asnad2]  " + Module1.strWhere + " order by [itemnum],[itemname]";
				lErl = 1;
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				AsnadDetailTable.Load(sqlDataReader);
				sqlDataReader.Close();
				foreach (DataColumn column in AsnadDetailTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = AsnadDetailTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					AsnadDetailTable.Rows[i]["ردیف"] = i + 1;
					object left = AsnadDetailTable.Rows[i]["نوع ایتم"];
					if (Operators.ConditionalCompareObjectEqual(left, "00", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "بها دار";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "10", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "درصدی";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "01", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "ستاره دار";
					}
					else if (Operators.ConditionalCompareObjectEqual(left, "11", TextCompare: false))
					{
						AsnadDetailTable.Rows[i]["نوع ایتم"] = "درصدی - ستاره دار";
					}
					AsnadDetailTable.Rows[i]["بهای_کل"] = Strings.Format(Conversions.ToDouble(AsnadDetailTable.Rows[i]["تعداد"].ToString()) * Conversions.ToDouble(AsnadDetailTable.Rows[i]["بهای واحد"].ToString()), "###0");
				}
				dtg_AsnadDetail.DataSource = AsnadDetailTable;
				dtg_AsnadDetail.Columns[9].DefaultCellStyle.Format = "N0";
				dtg_AsnadDetail.Columns[10].DefaultCellStyle.Format = "C2";
				dtg_AsnadDetail.Columns[11].DefaultCellStyle.Format = "N0";
				dtg_AsnadDetail.Columns[0].Visible = false;
				dtg_AsnadDetail.Columns[1].Width = 40;
				dtg_AsnadDetail.Columns[2].Visible = false;
				dtg_AsnadDetail.Columns[3].Visible = false;
				dtg_AsnadDetail.Columns[4].Width = 50;
				dtg_AsnadDetail.Columns[5].Width = 40;
				dtg_AsnadDetail.Columns[6].Width = 60;
				dtg_AsnadDetail.Columns[7].Width = 290;
				dtg_AsnadDetail.Columns[8].Width = 70;
				dtg_AsnadDetail.Columns[9].Width = 80;
				dtg_AsnadDetail.Columns[10].Width = 60;
				dtg_AsnadDetail.Columns[11].Width = 100;
				dtg_AsnadDetail.Columns[12].Width = 50;
				dtg_AsnadDetail.Columns[13].Width = 70;
				dtg_AsnadDetail.Columns[14].Width = 70;
				dtg_AsnadDetail.Columns[15].Width = 200;
				dtg_AsnadDetail.Refresh();
				LoadDtgAsnadDetail = 0;
				Module1.dtg_Color(dtg_AsnadDetail);
				if (DtgAsnadDetailRefresh == 0)
				{
					try
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow].Cells[1];
						ShowItemRecord();
					}
					catch (Exception ex2)
					{
						ProjectData.SetProjectError(ex2, lErl);
						Module1.CurrRow = 0;
						ProjectData.ClearProjectError();
						goto IL_11db;
					}
				}
				goto IL_1222;
			}
			IL_11db:
			try
			{
				dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow].Cells[1];
				ShowItemRecord();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3, lErl);
				ProjectData.ClearProjectError();
			}
			goto IL_1222;
			IL_1222:
			lErl = 20;
		}

		private void txt_ItemNo_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemBahavahed_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemBahavahed_KeyUp(object sender, KeyEventArgs e)
		{
			try
			{
				if ((Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) != 0))
				{
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
				}
				else
				{
					txt_ItemBahaKol.Text = "";
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".بهای واحد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_ItemBahavahed.Text = "";
				}
				else
				{
					txt_ItemTedad.Focus();
				}
				ProjectData.ClearProjectError();
			}
		}

		private void txt_ItemTedad_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemTedad_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void txt_ItemTedad_KeyUp(object sender, KeyEventArgs e)
		{
			if ((Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) == 0))
			{
				txt_ItemBahaKol.Text = "";
				return;
			}
			try
			{
				txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(txt_ItemTedad.Text) * Conversions.ToDouble(txt_ItemBahavahed.Text), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_ItemTedad.Text = "";
				}
				else
				{
					txt_ItemNo.Focus();
				}
				ProjectData.ClearProjectError();
			}
		}

		private void pnl_Item_Leave(object sender, EventArgs e)
		{
		}

		private void BlankItemRec()
		{
			txt_ItemTedad.Text = "";
			txt_ItemBahavahed.Text = "";
			txt_ItemBahaKol.Text = "";
			cmbo_ItemVahed.Text = "";
			txt_ItemSharh.Text = "";
			txt_DarsadMeghdar.Text = "";
			cmbo_DarsadItem.Text = "";
			txt_DarsadMablagh.Text = "";
			txt_Tozihat.Text = "";
			ItemSearch = "";
			txt_ItemNo.Text = "";
			Module1.ItemRec.recnum = 0;
			Module1.ItemRec.Radif = "";
			Module1.ItemRec.sanadnum = "";
			Module1.ItemRec.itemnum = "";
			Module1.ItemRec.fasl = "";
			Module1.ItemRec.ItemNoa = "";
			Module1.ItemRec.sharhitem = "";
			Module1.ItemRec.shvahed = "";
			Module1.ItemRec.ghvahed = "";
			Module1.ItemRec.total = "";
			Module1.ItemRec.mablagh = "";
			Module1.ItemRec.DarsadMeghdar = "";
			Module1.ItemRec.DarsadItem = "";
			Module1.ItemRec.DarsadMablagh = "";
			Module1.ItemRec.molahezat = "";
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Module1.BtnKarfarmaList = false;
			Close();
		}

		private void Btn_New_Click(object sender, EventArgs e)
		{
		}

		private void txt_ItemTedad_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemTedad.Text.Trim(), Module1.ItemRec.total.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_ItemTedad.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemTedad.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void lbl_ItemNoa_TextChanged(object sender, EventArgs e)
		{
			switch (lbl_ItemNoa.Text.Trim())
			{
			case "بها دار":
				cmbo_DarsadItem.Text = "";
				txt_DarsadMeghdar.Text = "";
				txt_ItemBahavahed.Enabled = false;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemTedad.TabIndex = 101;
				Btn_Save.TabIndex = 102;
				break;
			case "درصدی":
			case "درصدي":
				txt_ItemBahavahed.Enabled = false;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = true;
				txt_DarsadMeghdar.Visible = true;
				txt_DarsadMeghdar.Enabled = false;
				cmbo_DarsadItem.Enabled = true;
				cmbo_DarsadItem.Visible = true;
				txt_DarsadMablagh.Visible = true;
				txt_DarsadMeghdar.Text = txt_ItemBahavahed.Text;
				txt_DarsadMablagh.Enabled = true;
				cmbo_DarsadItem.TabIndex = 101;
				txt_ItemTedad.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				break;
			case "ستاره دار":
				txt_ItemTedad.TabIndex = 101;
				txt_ItemBahavahed.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				cmbo_DarsadItem.Text = "";
				txt_DarsadMeghdar.Text = "";
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemTedad.TabIndex = 101;
				txt_ItemBahavahed.TabIndex = 102;
				Btn_Save.TabIndex = 103;
				break;
			case "درصدی - ستاره دار":
			case "درصدي - ستاره دار":
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = false;
				cmbo_ItemFasl.Enabled = false;
				txt_ItemSharh.Enabled = false;
				lbl_DarsadItem.Visible = true;
				txt_DarsadMeghdar.Visible = true;
				cmbo_DarsadItem.Visible = true;
				txt_DarsadMablagh.Visible = true;
				txt_DarsadMeghdar.Enabled = true;
				cmbo_DarsadItem.Enabled = true;
				txt_DarsadMablagh.Enabled = true;
				txt_DarsadMeghdar.TabIndex = 101;
				cmbo_DarsadItem.TabIndex = 102;
				txt_ItemTedad.TabIndex = 103;
				Btn_Save.TabIndex = 104;
				break;
			case "توافقی":
			case "توافقي":
				txt_ItemNo.Enabled = true;
				txt_ItemBahavahed.Enabled = true;
				cmbo_ItemVahed.Enabled = true;
				cmbo_ItemFasl.Enabled = true;
				Module1.Load_Cmbo(cmbo_ItemFasl, "Fosool", "FaslCode", "where [FehrestFile] = '" + Module1.CurrentFehrestFile + "' and [FaslComment] like N'%توافقی%'");
				cmbo_ItemFasl.SelectedIndex = 0;
				txt_ItemSharh.Enabled = true;
				lbl_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Visible = false;
				cmbo_DarsadItem.Visible = false;
				txt_DarsadMeghdar.Text = "0";
				txt_DarsadMeghdar.Enabled = false;
				cmbo_DarsadItem.Enabled = false;
				txt_DarsadMablagh.Text = "0";
				txt_DarsadMablagh.Visible = false;
				txt_ItemSharh.TabIndex = 101;
				cmbo_ItemVahed.TabIndex = 102;
				txt_ItemTedad.TabIndex = 103;
				txt_ItemBahavahed.TabIndex = 104;
				Btn_Save.TabIndex = 104;
				break;
			}
		}

		private void txt_ItemBahavahed_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_ItemBahavahed.Text.Trim(), Module1.ItemRec.ghvahed.Trim(), TextCompare: false) != 0)
				{
					txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemBahavahed.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_Tozihat_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void txt_Tozihat_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void txt_Tozihat_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_Tozihat.Text.Trim(), Module1.ItemRec.molahezat.Trim(), TextCompare: false) != 0)
				{
					txt_Tozihat.ForeColor = Color.Red;
				}
				else
				{
					txt_Tozihat.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_Tozihat_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_Tozihat.Text.Trim(), Module1.ItemRec.molahezat.Trim(), TextCompare: false) != 0)
				{
					txt_Tozihat.ForeColor = Color.Red;
				}
				else
				{
					txt_Tozihat.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void cmbo_ItemVahed_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void cmbo_ItemVahed_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void cmbo_ItemVahed_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(cmbo_ItemVahed.Text.Trim(), Module1.ItemRec.shvahed.Trim(), TextCompare: false) != 0)
				{
					cmbo_ItemVahed.ForeColor = Color.Red;
				}
				else
				{
					cmbo_ItemVahed.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void cmbo_ItemVahed_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void txt_ItemSharh_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemSharh_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemSharh_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemSharh.Text.Trim(), Module1.ItemRec.sharhitem.Trim(), TextCompare: false) != 0)
			{
				txt_ItemSharh.ForeColor = Color.Red;
			}
			else
			{
				txt_ItemSharh.ForeColor = Color.Black;
			}
			CheckItemRecChange();
		}

		private void txt_DarsadMeghdar_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void txt_DarsadMeghdar_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".بهای واحد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_DarsadMeghdar.Text = "";
			}
			try
			{
				txt_ItemBahavahed.Text = (Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha)).ToString();
				txt_ItemBahaKol.Text = (Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text)).ToString();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_DarsadMeghdar_Leave(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_DarsadMeghdar.Text.Trim(), Module1.ItemRec.DarsadMeghdar.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_DarsadMeghdar.ForeColor = Color.Red;
				}
				else
				{
					txt_DarsadMeghdar.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_DarsadMeghdar_TextChanged(object sender, EventArgs e)
		{
		}

		public void CheckItemRecChange()
		{
			foreach (Control control in pnl_Item.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && control.ForeColor == Color.Red)
				{
					pnl_Item.BackColor = Color.LightPink;
					return;
				}
			}
			SetPnl_ItemBlue();
		}

		private void Btn_Return1_Click(object sender, EventArgs e)
		{
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					btn_Save1_Click(RuntimeHelpers.GetObjectValue(sender), e);
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
				}
				if (dialogResult == DialogResult.No)
				{
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
				}
				if (dialogResult == DialogResult.Cancel)
				{
					txt_SumRadif.Focus();
					return;
				}
			}
			pnl_SanadSum.Visible = false;
			pnl_MablaghKol.Visible = true;
			dtg_SanadSum.Height = 160;
			btn_Modify1.Visible = true;
		}

		private void btn_Save1_Click(object sender, EventArgs e)
		{
			Save_dtgSanadSum();
			if (Operators.CompareString(Module1.BtnCommand, "New", TextCompare: false) == 0)
			{
				Btn_New_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void dtg_FosoolSum_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			dtg_FosoolSum.ClearSelection();
		}

		private void dtg_FosoolSum_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dtg_FosoolSum.ClearSelection();
		}

		private void dtg_SanadSum_SelectionChanged(object sender, EventArgs e)
		{
			BtnCommand1 = "";
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
					foreach (Control control2 in pnl_SanadSum.Controls)
					{
						if (((object)control2.GetType() == typeof(ComboBox)) | ((object)control2.GetType() == typeof(TextBox)))
						{
							control2.ForeColor = Color.Black;
						}
					}
					Save_dtgSanadSum();
					break;
				case DialogResult.No:
					pnl_SanadSum.BackColor = Color.LightSteelBlue;
					foreach (Control control3 in pnl_SanadSum.Controls)
					{
						if (((object)control3.GetType() == typeof(ComboBox)) | ((object)control3.GetType() == typeof(TextBox)))
						{
							control3.ForeColor = Color.Black;
						}
					}
					break;
				}
			}
			ShowSanadSumRecord();
			int lErl = default(int);
			try
			{
				if (dtg_SanadSum.CurrentCell.RowIndex == 0)
				{
					dtg_SanadSum.CurrentCell.Selected = false;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 20;
		}

		private void btn_New1_Click(object sender, EventArgs e)
		{
			txt_SumRadif.Enabled = true;
			cmbo_SumSharh.Enabled = true;
			cmbo_SumNoa.Enabled = true;
			txt_SumDarsad.Enabled = true;
			txt_SumMablagh.Enabled = true;
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				dtg_SanadSum_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
				return;
			}
			BtnCommand1 = "New";
			txt_SumRadif.Text = Conversions.ToString(dtg_SanadSum.RowCount);
			cmbo_SumSharh.Text = "";
			cmbo_SumSharh.Focus();
			cmbo_SumNoa.Text = "درصد";
			txt_SumDarsad.Text = "";
			txt_SumMablagh.Text = "";
			txt_SumMablagh.Enabled = false;
			lbl_SumMande.Text = "";
			foreach (Control control in pnl_SanadSum.Controls)
			{
				if (((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox)))
				{
					control.ForeColor = Color.Black;
				}
			}
		}

		private void btn_Delete1_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			int index = dtg_SanadSum.CurrentRow.Index;
			int num = Conversions.ToInteger(dtg_SanadSum.Rows[index].Cells[0].Value);
			checked
			{
				if (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)
				{
					MessageBox.Show(" ابتدا ردیف مورد نظر را انتخاب کنید.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				}
				else
				{
					BtnCommand1 = "Delete";
					if (dtg_SanadSum.RowCount - 1 != 0)
					{
						int index2 = dtg_SanadSum.CurrentRow.Index;
						if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject("ردیف ", dtg_SanadSum[2, index2].Value), " حذف شود؟")), "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
						{
							Module1.MyConn.Close();
							if (Module1.MyConn.State == ConnectionState.Closed)
							{
								Module1.MyConn.Open();
							}
							sqlCommand.Connection = Module1.MyConn;
							sqlCommand.CommandText = "DELETE FROM [dbo].[Asnad4] WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [recnum]='" + Conversions.ToString(SanadSumRec.recnum) + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
							sqlCommand.ExecuteNonQuery();
						}
					}
				}
				Load_dtg_SanadSum();
				dtg_SanadSum.CurrentCell = dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[4];
				ShowSanadSumRecord();
			}
		}

		private void btn_Modify1_Click(object sender, EventArgs e)
		{
			pnl_SanadSum.Visible = true;
			btn_Modify1.Visible = false;
			pnl_MablaghKol.Visible = false;
			dtg_SanadSum.CurrentCell = dtg_SanadSum.Rows[0].Cells[4];
			dtg_SanadSum.Height = 150;
			ShowSanadSumRecord();
		}

		private void cmbo_SumSharh_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && !((dtg_SanadSum.CurrentRow.Index == 0) | (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)))
			{
				if (Operators.CompareString(cmbo_SumSharh.Text.Trim(), SanadSumRec.Sharh.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumSharh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumSharh.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

		private void cmbo_SumSharh_TextChanged(object sender, EventArgs e)
		{
			double num = Conversions.ToDouble(lbl_SanadZarib1.Text);
			double num2 = Conversions.ToDouble(lbl_SanadZarib2.Text);
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			switch (cmbo_SumSharh.Text.Trim())
			{
			case "مالیات و عوارض":
				cmbo_SumNoa.Text = "درصد";
				txt_SumDarsad.Text = "10";
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/47 فصول اول تا سوم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.47 * (num * (SumFasl("1") + SumFasl("2")) + SumFasl("3")), "###0");
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/50 فصل چهارم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.5 * SumFasl("4"), "###0");
				Calculate_SanadSumMande();
				break;
			case "تعدیل بابت ضریب 1/55 فصول پنجم و ششم بخشنامه 1403/129444":
				txt_SumDarsad.Text = "";
				cmbo_SumNoa.Text = "مقطوع";
				txt_SumMablagh.Text = Strings.Format(0.55 * (num2 * SumFasl("5") + num * SumFasl("6")), "###0");
				Calculate_SanadSumMande();
				break;
			default:
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				lbl_SumMande.Text = "";
				break;
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(cmbo_SumSharh.Text.Trim(), SanadSumRec.Sharh.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumSharh.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumSharh.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
				goto IL_02ac;
			}
			CheckSumRecChange();
			goto IL_02ac;
			IL_02ac:
			lErl = 10;
		}

		private void CheckSumRecChange()
		{
			foreach (Control control in pnl_SanadSum.Controls)
			{
				if ((((object)control.GetType() == typeof(ComboBox)) | ((object)control.GetType() == typeof(TextBox))) && control.ForeColor == Color.Red)
				{
					pnl_SanadSum.BackColor = Color.LightPink;
					return;
				}
			}
			pnl_SanadSum.BackColor = Color.LightSteelBlue;
		}

		private void cmbo_SumNoa_Leave(object sender, EventArgs e)
		{
			CheckSumRecChange();
		}

		private void cmbo_SumNoa_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			string left = cmbo_SumNoa.Text.Trim();
			if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
				{
					txt_SumMablagh.Enabled = true;
					txt_SumDarsad.Text = "";
					txt_SumMablagh.Text = "";
					txt_SumDarsad.Enabled = false;
				}
			}
			else
			{
				txt_SumDarsad.Enabled = true;
				txt_SumDarsad.Text = "";
				txt_SumMablagh.Text = "";
				txt_SumMablagh.Enabled = false;
			}
			try
			{
				if (Operators.CompareString(cmbo_SumNoa.Text.Trim(), SanadSumRec.Noa.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumNoa.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_SumDarsad_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_SumDarsad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Versioned.IsNumeric(e.KeyChar) && Convert.ToByte(e.KeyChar) != 8 && Convert.ToByte(e.KeyChar) != 45 && Convert.ToByte(e.KeyChar) != 46)
			{
				e.Handled = true;
			}
			string @string = "-0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) != 0)
			{
			}
		}

		private void txt_SumMablagh_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Versioned.IsNumeric(e.KeyChar) && Convert.ToByte(e.KeyChar) != 8 && Convert.ToByte(e.KeyChar) != 45)
			{
				e.Handled = true;
			}
			string @string = "-0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) != 0)
			{
			}
		}

		private void txt_SumMablagh_KeyUp(object sender, KeyEventArgs e)
		{
			if ((Operators.CompareString(txt_SumMablagh.Text, "-", TextCompare: false) == 0) | (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".درصد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumMablagh.Text = "";
			}
			Calculate_SanadSumMande();
		}

		private void txt_SumDarsad_KeyUp(object sender, KeyEventArgs e)
		{
			if (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0 || ((Operators.CompareString(txt_SumDarsad.Text, "-", TextCompare: false) == 0) | (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0)))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".درصد باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
			Calculate_SanadSumMande();
		}

		private void txt_SumMablagh_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumMablagh.Text, "-", TextCompare: false) != 0)
			{
				string value = ((Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) != 0) ? txt_SumMablagh.Text : "0");
				string value2 = ((Operators.CompareString(SanadSumRec.Mablagh, "", TextCompare: false) != 0) ? SanadSumRec.Mablagh : "0");
				if (checked(Conversions.ToLong(value) - Conversions.ToLong(value2)) != 0)
				{
					txt_SumMablagh.ForeColor = Color.Red;
				}
				else
				{
					txt_SumMablagh.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

		private void txt_SumMablagh_MouseEnter(object sender, EventArgs e)
		{
		}

		private void txt_SumMablagh_TextChanged(object sender, EventArgs e)
		{
		}

		private void Save_dtgSanadSum()
		{
			if (Module1.SanadSabtGharardadha)
			{
				MessageBox.Show(" سند توسط امور قراردادها ثبت شده است تغییر ممکن نیست.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else if (!(pnl_SanadSum.BackColor == Color.LightSteelBlue))
			{
				if ((Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_SumMablagh.Text, "0", TextCompare: false) == 0))
				{
					MessageBox.Show(".اطلاعات ورودی را کامل کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					goto IL_04d8;
				}
				if (Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0)
				{
					txt_SumDarsad.Text = "0";
				}
				if (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0)
				{
					txt_SumMablagh.Text = "0";
				}
				if (Operators.CompareString(lbl_SumMande.Text, "", TextCompare: false) == 0)
				{
					lbl_SumMande.Text = "0";
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				if (Operators.CompareString(BtnCommand1, "New", TextCompare: false) == 0)
				{
					Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad4] ([sanadnum], [fopf], [Sharh], [darsad], [maghtoo], [mablagh], [mablaghk], [Salmali], [IjadSystem], [TimeIjad],[Soori],[Ghaleb])VALUES ('" + lbl_SanadNo.Text + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + cmbo_SumSharh.Text + "','" + txt_SumDarsad.Text + "','" + txt_SumMablagh.Text + "','" + txt_SumMablagh.Text + "','" + lbl_SumMande.Text + "','" + Module1.SanadRec.SalMali + "','" + Environment.MachineName + "','','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
					Module1.cmd.ExecuteNonQuery();
				}
				else
				{
					int index = dtg_SanadSum.CurrentRow.Index;
					if (dtg_SanadSum.CurrentRow.Index != 0)
					{
						Module1.cmd.CommandText = "Update [dbo].[asnad4] SET [sanadnum] = '" + Conversions.ToString(Conversions.ToDouble(lbl_SanadNo.Text)) + "',[fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "',[Sharh] = '" + cmbo_SumSharh.Text + "',[darsad] = '" + Conversions.ToString(Conversions.ToDouble(txt_SumDarsad.Text)) + "',[maghtoo] = '" + txt_SumMablagh.Text + "',[mablagh] = '" + txt_SumMablagh.Text + "',[mablaghk] = '" + Conversions.ToString(Conversions.ToDouble(lbl_SumMande.Text)) + "',[Salmali] = '" + Module1.SanadRec.SalMali + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = '',[Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "',[Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' WHERE [recnum]='" + Conversions.ToString(SanadSumRec.recnum) + "' And [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
						Module1.cmd.ExecuteNonQuery();
					}
				}
			}
			pnl_SanadSum.BackColor = Color.LightSteelBlue;
			Load_dtg_SanadSum();
			ShowSanadSumRecord();
			goto IL_04d8;
			IL_04d8:
			BtnCommand1 = "";
		}

		private void txt_SumRadif_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789.";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_SumRadif.Text = "";
			}
		}

		private void txt_SumRadif_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".ردیف باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
		}

		private void txt_SumRadif_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				return;
			}
			checked
			{
				int num = dtg_SanadSum.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToInteger(txt_SumRadif.Text) == Conversions.ToInteger(dtg_SanadSum.Rows[i].Cells[2].Value))
					{
						MessageBox.Show(". ردیف تکراری است مجددا وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_SumRadif.Focus();
						return;
					}
				}
				if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) != 0)
				{
					if (Conversions.ToDouble(txt_SumRadif.Text) != (double)SanadSumRec.Radif)
					{
						txt_SumRadif.ForeColor = Color.Red;
					}
					else
					{
						txt_SumRadif.ForeColor = Color.Black;
					}
					CheckSumRecChange();
				}
			}
		}

		private void txt_SumRadif_TextChanged(object sender, EventArgs e)
		{
			try
			{
				if (Operators.CompareString(txt_SumRadif.Text.Trim(), SanadSumRec.Radif.ToString().Trim(), TextCompare: false) != 0)
				{
					txt_SumRadif.ForeColor = Color.Red;
				}
				else
				{
					txt_SumRadif.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			if (!string.IsNullOrWhiteSpace(txt_SumRadif.Text) && !Versioned.IsNumeric(txt_SumRadif.Text))
			{
				txt_SumRadif.Text = "";
				MessageBox.Show(".ورودی باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
			}
			Calculate_SanadSumMande();
		}

		private void Calculate_SanadSumMande()
		{
			if (dtg_SanadSum.RowCount == 0)
			{
				return;
			}
			float num = 1f;
			if ((Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) == 0) & (Operators.CompareString(txt_SumMablagh.Text, "", TextCompare: false) == 0))
			{
				return;
			}
			if (Operators.CompareString(txt_SumRadif.Text, "", TextCompare: false) == 0)
			{
				MessageBox.Show(". ردیف را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumRadif.Focus();
				return;
			}
			checked
			{
				long num2 = default(long);
				if (Conversions.ToInteger(txt_SumRadif.Text) > Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[2].Value))
				{
					num2 = Conversions.ToLong(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[7].Value);
				}
				else if (Conversions.ToInteger(txt_SumRadif.Text) == Conversions.ToInteger(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 1].Cells[2].Value))
				{
					num2 = Conversions.ToLong(dtg_SanadSum.Rows[dtg_SanadSum.RowCount - 2].Cells[7].Value);
				}
				else
				{
					int num3 = dtg_SanadSum.RowCount - 2;
					for (int i = 0; i <= num3; i++)
					{
						if ((Conversions.ToInteger(txt_SumRadif.Text) > Conversions.ToInteger(dtg_SanadSum.Rows[i].Cells[2].Value)) & (Conversions.ToInteger(txt_SumRadif.Text) <= Conversions.ToInteger(dtg_SanadSum.Rows[i + 1].Cells[2].Value)))
						{
							num2 = Conversions.ToLong(dtg_SanadSum.Rows[i].Cells[7].Value);
						}
					}
				}
				long num4 = default(long);
				if (Operators.CompareString(cmbo_SumNoa.Text, "درصد", TextCompare: false) == 0)
				{
					num4 = (long)(Conversions.ToDouble(txt_SumDarsad.Text) * (double)num2 / 100.0);
					txt_SumMablagh.Text = Conversions.ToString(num4);
				}
				if (Operators.CompareString(cmbo_SumNoa.Text, "مقطوع", TextCompare: false) == 0)
				{
					num4 = (long)Math.Round(Conversions.ToDouble(txt_SumMablagh.Text));
				}
				num2 += num4;
				lbl_SumMande.Text = Conversions.ToString(num2);
			}
		}

		private void btn_Filter_Click_1(object sender, EventArgs e)
		{
			if (pnl_Filter.Visible)
			{
				dtg_AsnadDetail.Location = new Point(15, 351);
				dtg_AsnadDetail.Height = 354;
				txt_ItemRadifFltr.Text = "";
				txt_ItemNoFltr.Text = "";
				txt_ItemFaslFltr.Text = "";
				cmbo_ItemNoaFltr.Text = "";
				txt_ItemSharhFltr.Text = "";
				txt_ItemVahedFltr.Text = "";
				txt_ItemBahavahedFltr.Text = "";
				txt_ItemTedadFltr.Text = "";
				txt_ItemBahaKolFltr.Text = "";
				txt_DarsadMeghdarFltr.Text = "";
				txt_DarsadItemFltr.Text = "";
				txt_DarsadMablaghFltr.Text = "";
				txt_TozihatFltr.Text = "";
				ItemNo_Filter = "";
				ItemFasl_Filter = "";
				ItemNoa_Filter = "";
				ItemSharh_Filter = "";
				ItemVahed_Filter = "";
				ItemBahavahed_Filter = "";
				ItemTedad_Filter = "";
				ItemBahaKol_Filter = "";
				DarsadMeghdar_Filter = "";
				DarsadItem_Filter = "";
				DarsadMablagh_Filter = "";
				Tozihat_Filter = "";
				pnl_Filter.Visible = false;
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
			else
			{
				pnl_Filter.Visible = true;
				dtg_AsnadDetail.Location = new Point(15, 372);
				dtg_AsnadDetail.Height = 331;
			}
		}

		private void txt_ItemRadifFltr_KeyPress(object sender, KeyPressEventArgs e)
		{
			string @string = "0123456789-";
			if (Strings.InStr(@string, Conversions.ToString(e.KeyChar)) == 0)
			{
				txt_SumRadif.Text = "";
			}
		}

		private void btn_Print_Click1(object sender, EventArgs e)
		{
			if (pnl_Item.BackColor == Color.LightPink)
			{
				MessageBox.Show(" اطلاعات ایتم ذخیره شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT [SanadNo],[ItemFasl],[ItemNo],[ItemSharh],[ItemVahed],ItemTedad,ItemBahavahed,ItemBahaKol ,[Tozihat] FROM [dbo].[AsnadDetail] Where [SanadNo]= '" + lbl_SanadNo.Text.Trim() + "'", Module1.MyConn);
			DataSet dataSet = new DataSet();
			sqlDataAdapter.Fill(dataSet, "Sanad1");
			CrystalReport1 crystalReport = new CrystalReport1();
			crystalReport.SetDataSource(dataSet.Tables[0]);
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_JobNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_Project.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + lbl_Karfarma.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + lbl_Fehrest.Text + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

		private void SetPnl_ItemBlue()
		{
			pnl_Item.BackColor = Color.LightSteelBlue;
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

		private void txt_SumDarsad_Leave(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum != 1 && Operators.CompareString(txt_SumDarsad.Text, "-", TextCompare: false) != 0)
			{
				string value = ((Operators.CompareString(txt_SumDarsad.Text, "", TextCompare: false) != 0) ? txt_SumDarsad.Text : "0");
				string value2 = ((Operators.CompareString(SanadSumRec.Darsad, "", TextCompare: false) != 0) ? SanadSumRec.Darsad : "0");
				if (Conversions.ToDouble(value) != Conversions.ToDouble(value2))
				{
					txt_SumDarsad.ForeColor = Color.Red;
				}
				else
				{
					txt_SumDarsad.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
		}

		private void cmbo_DarsadItem_GotFocus(object sender, EventArgs e)
		{
			if ((Operators.CompareString(Module1.ItemRec.DarsadItem, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadItem, "", TextCompare: false) != 0))
			{
				cmbo_DarsadItem.Text = ": ایتم";
			}
			else if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0))
			{
				cmbo_DarsadItem.Text = ": مبلغ";
			}
			else
			{
				cmbo_DarsadItem.Text = "";
			}
		}

		private void cmbo_DarsadItem_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void cmbo_DarsadItem_Leave(object sender, EventArgs e)
		{
			try
			{
				switch (lbl_ItemNoa.Text.Trim())
				{
				case "درصدی":
				case "درصدي":
				case "درصدی - ستاره دار":
				case "درصدي - ستاره دار":
					txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
					break;
				}
				if ((Operators.CompareString(Module1.ItemRec.DarsadItem, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadItem, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_DarsadItem.Text, ": ایتم", TextCompare: false) != 0))
				{
					cmbo_DarsadItem.ForeColor = Color.Red;
				}
				else if ((Operators.CompareString(Module1.ItemRec.DarsadMablagh, "0", TextCompare: false) != 0) & (Operators.CompareString(Module1.ItemRec.DarsadMablagh, "", TextCompare: false) != 0) & (Operators.CompareString(cmbo_DarsadItem.Text, ": مبلغ", TextCompare: false) != 0))
				{
					cmbo_DarsadItem.ForeColor = Color.Red;
				}
				else
				{
					cmbo_DarsadItem.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void cmbo_DarsadItem_SelectedIndexChanged(object sender, EventArgs e)
		{
			DarsadItemBaha = "0";
			string left = cmbo_DarsadItem.Text.Trim();
			int lErl = default(int);
			if (Operators.CompareString(left, ": مبلغ", TextCompare: false) == 0 || Operators.CompareString(left, ": ایتم", TextCompare: false) == 0)
			{
				txt_DarsadMablagh.Visible = true;
			}
			else
			{
				txt_DarsadMablagh.Visible = false;
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT TOP 1 [ghvahed] FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [itemnum] ='" + cmbo_DarsadItem.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					DarsadItemBaha = sqlDataReader[0].ToString();
				}
				sqlDataReader.Close();
				try
				{
					txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
					if (string.IsNullOrEmpty(txt_ItemTedad.Text))
					{
						txt_ItemTedad.Text = "0";
					}
					txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					MessageBox.Show(" اطلاعات ورودی بررسی شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					ProjectData.ClearProjectError();
				}
			}
			lErl = 10;
		}

		private void Btn_Save_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemNo_TextChanged(object sender, EventArgs e)
		{
			switch (txt_ItemNo.Text.Trim())
			{
			case "40101":
			case "40201":
			case "40301":
			case "40401":
				btn_Calculate.Visible = true;
				break;
			default:
				btn_Calculate.Visible = false;
				break;
			}
		}

		private void btn_Calculate_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_Calculate.chk_40201.Checked = false;
			MyProject.Forms.Frm_Calculate.chk_40301.Checked = false;
			MyProject.Forms.Frm_Calculate.chk_40401.Checked = false;
			MyProject.Forms.Frm_Calculate.CalculateItemFasl4();
			MyProject.Forms.Frm_Calculate.ShowDialog();
		}

		private void Btn_Save_KeyUp(object sender, KeyEventArgs e)
		{
		}

		private void lbl_ItemNoa_Click(object sender, EventArgs e)
		{
		}

		private void txt_DarsadMablagh_KeyDown(object sender, KeyEventArgs e)
		{
			checked
			{
				try
				{
					if (e.KeyCode == Keys.Prior)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index - 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
					if (e.KeyCode == Keys.Next)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[dtg_AsnadDetail.CurrentRow.Index + 1].Cells[4];
						ShowItemRecord();
						txt_ItemNo.Focus();
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
			}
		}

		private void txt_DarsadMablagh_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void txt_DarsadMablagh_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				MessageBox.Show(".ورودی باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_SumDarsad.Text = "";
			}
		}

		private void txt_DarsadMablagh_Leave(object sender, EventArgs e)
		{
			if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_DarsadMablagh.Text, "0", TextCompare: false) == 0))
			{
				switch (MessageBox.Show(".ایتم یا مبلغ را جهت محاسبه وارد کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					SetDarsadMablaghFocus = 1;
					return;
				case DialogResult.Cancel:
					SetDarsadMablaghFocus = 2;
					return;
				}
			}
			string left = cmbo_DarsadItem.Text.Trim();
			if (Operators.CompareString(left, ": مبلغ", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, ": ایتم", TextCompare: false) == 0)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT TOP 1 [ghvahed] FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [itemnum] ='" + txt_DarsadMablagh.Text.Trim() + "' And [fopf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (!sqlDataReader.HasRows)
					{
						MessageBox.Show(" . ایتم  وارد شده در سند موجود نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						SetDarsadMablaghFocus = 2;
						sqlDataReader.Close();
						return;
					}
					while (sqlDataReader.Read())
					{
						DarsadItemBaha = sqlDataReader[0].ToString();
					}
					sqlDataReader.Close();
				}
			}
			else if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) != 0))
			{
				DarsadItemBaha = txt_DarsadMablagh.Text;
			}
			else
			{
				if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0))
				{
					txt_DarsadMeghdar.Focus();
				}
				if ((Operators.CompareString(txt_DarsadMablagh.Text, "", TextCompare: false) == 0) & (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0))
				{
					txt_DarsadMablagh.Focus();
				}
			}
			try
			{
				if ((Operators.CompareString(txt_DarsadMablagh.Text.Trim(), Module1.ItemRec.DarsadMablagh.ToString().Trim(), TextCompare: false) != 0) & (Operators.CompareString(txt_DarsadMablagh.Text.Trim(), Module1.ItemRec.DarsadItem.ToString().Trim(), TextCompare: false) != 0))
				{
					txt_DarsadMablagh.ForeColor = Color.Red;
				}
				else
				{
					txt_DarsadMablagh.ForeColor = Color.Black;
				}
				CheckItemRecChange();
				txt_ItemBahavahed.Text = Conversions.ToString(Conversions.ToDouble(txt_DarsadMeghdar.Text) / 100.0 * Conversions.ToDouble(DarsadItemBaha));
				txt_ItemBahaKol.Text = Conversions.ToString(Conversions.ToDouble(txt_ItemBahavahed.Text) * Conversions.ToDouble(txt_ItemTedad.Text));
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_DarsadMablagh_TextChanged(object sender, EventArgs e)
		{
		}

		private void LoadCmboDarsadItems()
		{
			cmbo_DarsadItem.Items.Clear();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [ItemDarsad] FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] where [shomar] ='" + txt_ItemNo.Text.Trim() + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			string[] array = null;
			while (sqlDataReader.Read())
			{
				if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
				{
					array = sqlDataReader[0].ToString().Split(',');
					continue;
				}
				sqlDataReader.Close();
				return;
			}
			sqlDataReader.Close();
			string text = "";
			string text2 = "";
			int num = Information.UBound(array);
			for (int i = 0; i <= num; i = checked(i + 1))
			{
				string[] array2 = null;
				array2 = array[i].Split('-');
				if (Information.UBound(array2) == 0)
				{
					text = " ([itemnum] Like N'%" + array2[0] + "%') Order By [itemnum]";
				}
				if (Information.UBound(array2) == 1)
				{
					text = " ([itemnum] Between '" + Conversions.ToString(Conversion.Val(array2[0])) + "' And '" + Conversions.ToString(Conversion.Val(array2[1])) + "') Order By [itemnum]";
				}
				text2 = ((Operators.CompareString(text, "", TextCompare: false) != 0) ? "And " : "");
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [itemnum] FROM [dbo].[Asnad2] where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori]= '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' " + text2 + text;
				sqlDataReader = Module1.cmd.ExecuteReader();
				while (sqlDataReader.Read())
				{
					cmbo_DarsadItem.Items.Add(RuntimeHelpers.GetObjectValue(sqlDataReader[0]));
				}
				sqlDataReader.Close();
			}
			cmbo_DarsadItem.Items.Add(": ایتم");
			cmbo_DarsadItem.Items.Add(": مبلغ");
		}

		private void Btn_Save_Leave(object sender, EventArgs e)
		{
			txt_ItemNo.Focus();
		}

		private void txt_ItemTedad_TextChanged(object sender, EventArgs e)
		{
		}

		private void cmbo_SumNoa_TextChanged(object sender, EventArgs e)
		{
			if (LoadDtgAsnadSanadSum == 1)
			{
				return;
			}
			string left = cmbo_SumNoa.Text.Trim();
			if (Operators.CompareString(left, "درصد", TextCompare: false) != 0)
			{
				if (Operators.CompareString(left, "مقطوع", TextCompare: false) == 0)
				{
					txt_SumMablagh.Enabled = true;
					txt_SumDarsad.Text = "";
					txt_SumDarsad.Enabled = false;
				}
			}
			else
			{
				txt_SumDarsad.Enabled = true;
				txt_SumMablagh.Text = "";
				txt_SumMablagh.Enabled = false;
			}
			try
			{
				if (Operators.CompareString(cmbo_SumNoa.Text.Trim(), SanadSumRec.Noa.Trim(), TextCompare: false) != 0)
				{
					cmbo_SumNoa.ForeColor = Color.Red;
				}
				else
				{
					cmbo_SumNoa.ForeColor = Color.Black;
				}
				CheckSumRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void btn_Import_Click(object sender, EventArgs e)
		{
			MyProject.Forms.Frm_ItemSelect.ShowDialog();
			MyProject.Forms.Frm_ItemSelect.Load_dtg_Item();
		}

		private void txt_ItemNoFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemNoFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemNoFltr.Text;
					ItemNo_Filter = " ([itemnum] Like '%" + text + "%')";
				}
				else
				{
					ItemNo_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

		private void txt_ItemRadifFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			if ((Operators.CompareString(txt_ItemRadifFltr.Text, "", TextCompare: false) == 0) | (Operators.CompareString(txt_ItemRadifFltr.Text, "-", TextCompare: false) == 0))
			{
				return;
			}
			string[] array = null;
			string[] array2 = new string[3];
			array = txt_ItemRadifFltr.Text.Split('-');
			array2 = null;
			dtg_AsnadDetail.CurrentCell = null;
			checked
			{
				if (Information.UBound(array) == 0)
				{
					int num = dtg_AsnadDetail.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.CompareString(dtg_AsnadDetail.Rows[i].Cells[1].Value.ToString(), array[0], TextCompare: false) != 0)
						{
							dtg_AsnadDetail.Rows[i].Visible = false;
						}
					}
				}
				if (Information.UBound(array) == 1)
				{
					if (Operators.CompareString(array[1], "", TextCompare: false) == 0)
					{
						return;
					}
					int num2 = dtg_AsnadDetail.RowCount - 1;
					for (int j = 0; j <= num2; j++)
					{
						if ((Conversions.ToInteger(dtg_AsnadDetail.Rows[j].Cells[1].Value.ToString()) < Conversions.ToInteger(array[0])) | (Conversions.ToInteger(dtg_AsnadDetail.Rows[j].Cells[1].Value.ToString()) > Conversions.ToInteger(array[1])))
						{
							dtg_AsnadDetail.Rows[j].Visible = false;
						}
					}
				}
				int num3 = dtg_AsnadDetail.RowCount - 1;
				for (int k = 0; k <= num3; k++)
				{
					if (dtg_AsnadDetail.Rows[k].Visible)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[k].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

		private void txt_ItemFaslFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemFaslFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemFaslFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemFasl_Filter = " ([fasl] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemFasl_Filter = "([fasl] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemFasl_Filter = "";
				}
			}
			else
			{
				ItemFasl_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_ItemSharhFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemSharhFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemSharhFltr.Text;
					ItemSharh_Filter = " (REPLACE(REPLACE([sharhitem],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ItemSharh_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

		private void txt_ItemVahedFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_ItemVahedFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_ItemVahedFltr.Text;
					ItemVahed_Filter = " (REPLACE(REPLACE([shvahed],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					ItemVahed_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
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
					ItemBahavahed_Filter = " (cast([ghvahed] as decimal(18,0)) Like '%" + Conversions.ToString(Conversion.Val(array[0])) + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahavahed_Filter = "([ghvahed] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahavahed_Filter = "";
				}
			}
			else
			{
				ItemBahavahed_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_ItemTedadFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemTedadFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemTedadFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemTedad_Filter = " (cast([total] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemTedad_Filter = "([total] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemTedad_Filter = "";
				}
			}
			else
			{
				ItemTedad_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_ItemBahaKolFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_ItemBahaKolFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_ItemBahaKolFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					ItemBahaKol_Filter = " (cast([mablagh] as decimal(18,0)) Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					ItemBahaKol_Filter = "([mablagh] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					ItemBahaKol_Filter = "";
				}
			}
			else
			{
				ItemBahaKol_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_DarsadMeghdarFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadMeghdarFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadMeghdarFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadMeghdar_Filter = " ([itemdarsad] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadMeghdar_Filter = "([itemdarsad] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadMeghdar_Filter = "";
				}
			}
			else
			{
				DarsadMeghdar_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_DarsadItemFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadItemFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadItemFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadItem_Filter = " ([itemname] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadItem_Filter = "([itemname] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadItem_Filter = "";
				}
			}
			else
			{
				DarsadItem_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_DarsadMablaghFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode != Keys.Return)
			{
				return;
			}
			if (Operators.CompareString(txt_DarsadMablaghFltr.Text, "", TextCompare: false) != 0)
			{
				string[] array = null;
				string[] array2 = new string[3];
				array2 = null;
				array = txt_DarsadMablaghFltr.Text.Split('-');
				if (Information.UBound(array) == 0)
				{
					DarsadMeghdar_Filter = " ([NesbatbeMablagh] Like N'%" + array[0] + "%')";
				}
				if (Information.UBound(array) == 1)
				{
					DarsadMeghdar_Filter = "([NesbatbeMablagh] Between '" + Conversions.ToString(Conversion.Val(array[0])) + "' and '" + Conversions.ToString(Conversion.Val(array[1])) + "')";
				}
				if (Information.UBound(array) > 1)
				{
					DarsadMeghdar_Filter = "";
				}
			}
			else
			{
				DarsadMeghdar_Filter = "";
			}
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
		}

		private void txt_TozihatFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_TozihatFltr.Text, "", TextCompare: false) != 0)
				{
					string text = null;
					text = txt_TozihatFltr.Text;
					Tozihat_Filter = " (REPLACE(REPLACE([Tozihat],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(text) + "%')";
				}
				else
				{
					Tozihat_Filter = "";
				}
				Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			}
		}

		private void btn_View_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(btn_View.Text, "نمایش بیشتر", TextCompare: false) == 0)
			{
				pnl_Filter.Location = new Point(17, 93);
				dtg_AsnadDetail.Location = new Point(15, 115);
				dtg_AsnadDetail.Height = 445;
				btn_View.Text = "نمایش کمتر";
				pnl_Fosool.Visible = false;
			}
			else
			{
				pnl_Filter.Location = new Point(17, 307);
				dtg_AsnadDetail.Location = new Point(15, 329);
				dtg_AsnadDetail.Height = 235;
				btn_View.Text = "نمایش بیشتر";
				pnl_Fosool.Visible = true;
			}
		}

		private void txt_ItemNo_KeyDown1(object sender, KeyEventArgs e)
		{
		}

		private void txt_ItemNo_KeyUp(object sender, KeyEventArgs e)
		{
			ItemSearch = txt_ItemNo.Text;
			txt_ItemNo.SelectionStart = checked(txt_ItemNo.Text.Length + 1);
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [recnum],[itemnum] FROM [dbo].[asnad2] Where [recnum] = '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					if (Operators.CompareString(txt_ItemNo.Text, sqlDataReader[1].ToString(), TextCompare: false) == 0)
					{
						return;
					}
				}
			}
			sqlDataReader.Close();
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "SELECT Top 1 [radif],[shomar],[Sharh],[Fasl],[Vahed],[baha],Cast([darsad] As varchar(25))+Cast([setareh] As varchar(25)) FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] Where [shomar] = '" + txt_ItemNo.Text + "'";
			sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					txt_ItemNo.Text = sqlDataReader[1].ToString();
					try
					{
						if (Operators.CompareString(txt_ItemNo.Text.Trim(), Module1.ItemRec.itemnum.Trim(), TextCompare: false) != 0)
						{
							txt_ItemTedad.Text = "";
						}
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
					txt_ItemSharh.Text = sqlDataReader[2].ToString();
					cmbo_ItemFasl.Text = sqlDataReader[3].ToString();
					cmbo_ItemVahed.Text = sqlDataReader[4].ToString();
					txt_ItemBahavahed.Text = sqlDataReader[5].ToString();
					txt_ItemBahaKol.Text = "";
					txt_Tozihat.Text = "";
					switch (sqlDataReader[6].ToString().Trim())
					{
					case "00":
						lbl_ItemNoa.Text = "بها دار";
						break;
					case "10":
						lbl_ItemNoa.Text = "درصدی";
						txt_DarsadMeghdar.Text = sqlDataReader[5].ToString();
						txt_ItemBahavahed.Text = "";
						break;
					case "01":
						lbl_ItemNoa.Text = "ستاره دار";
						break;
					case "11":
						lbl_ItemNoa.Text = "درصدی - ستاره دار";
						break;
					}
				}
			}
			sqlDataReader.Close();
		}

		private void txt_ItemNo_Leave(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_ItemNo.Text, "", TextCompare: false) == 0)
			{
				switch (MessageBox.Show(".شماره ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.OK:
					SetItemNomFocus = 1;
					return;
				case DialogResult.Cancel:
					SetItemNomFocus = 2;
					return;
				}
			}
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_ItemNo.Text.Trim(), Module1.ItemRec.itemnum.Trim(), TextCompare: false) != 0)
				{
					txt_ItemNo.ForeColor = Color.Red;
				}
				else
				{
					txt_ItemNo.ForeColor = Color.Black;
				}
				CheckItemRecChange();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [radif],[shomar],[Sharh],[Fasl],[Vahed],[baha],Cast([darsad] As varchar(25))+Cast([setareh] As varchar(25)) FROM [dbo].[" + Module1.SanadRec.fehrestfile + "] Where [shomar] = '" + txt_ItemNo.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (!sqlDataReader.HasRows)
			{
				DialogResult dialogResult = MessageBox.Show(".ایتم در فهرست بها نیست بصورت توافقی در نظر گرقته می شود", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				pnl_Item.BackColor = Color.LightPink;
				if (dialogResult != DialogResult.OK)
				{
					if (dialogResult == DialogResult.Cancel)
					{
						sqlDataReader.Close();
						SetItemNomFocus = 1;
						goto IL_03cb;
					}
				}
				else
				{
					lbl_ItemNoa.Text = "توافقی";
				}
				sqlDataReader.Close();
			}
			else if (sqlDataReader.Read())
			{
				txt_ItemNo.Text = sqlDataReader[1].ToString();
				txt_ItemSharh.Text = sqlDataReader[2].ToString();
				cmbo_ItemFasl.Text = sqlDataReader[3].ToString();
				cmbo_ItemVahed.Text = sqlDataReader[4].ToString();
				txt_ItemBahavahed.Text = sqlDataReader[5].ToString();
				switch (sqlDataReader[6].ToString().Trim())
				{
				case "00":
					lbl_ItemNoa.Text = "بها دار";
					break;
				case "10":
					lbl_ItemNoa.Text = "درصدی";
					break;
				case "01":
					lbl_ItemNoa.Text = "ستاره دار";
					break;
				case "11":
					lbl_ItemNoa.Text = "درصدی - ستاره دار";
					break;
				}
				if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
				{
					LoadCmboDarsadItems();
				}
				else
				{
					cmbo_DarsadItem.DataSource = null;
				}
				sqlDataReader.Close();
			}
			else
			{
				sqlDataReader.Close();
				ItemSearch = "";
				lbl_ItemNoa_TextChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			goto IL_03cb;
			IL_03cb:
			lErl = 10;
		}

		private void cmbo_ItemFasl_KeyDown(object sender, KeyEventArgs e)
		{
		}

		private void cmbo_ItemFasl_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void txt_ItemBahaKol_KeyDown(object sender, KeyEventArgs e)
		{
		}

		public void PrintSanad()
		{
			string text = "";
			string text2 = "";
			string text3 = "";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT TOP 1 [ShName],[CodeEghtesadi],[OnvanSanad],[NameAmel],[EsmRamz],[MatnNameh],[AvarezShahrdari],[AvarezArzeshAfzoode],[Semat],[OnvanMabna] From [Moshakhasat] Where [EsmRamz] ='" + MyProject.Forms.Frm_AsnadList.cmbo_OnvanCode.Text + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			while (sqlDataReader.Read())
			{
				Module1.Onvan.ShName = sqlDataReader[0].ToString();
				Module1.Onvan.CodeEghtesadi = sqlDataReader[1].ToString();
				Module1.Onvan.OnvanSanad = sqlDataReader[2].ToString();
				Module1.Onvan.NameAmel = sqlDataReader[3].ToString();
				Module1.Onvan.EsmRamz = sqlDataReader[4].ToString();
				Module1.Onvan.MatnNameh = sqlDataReader[5].ToString();
				Module1.Onvan.AvarezShahrdari = sqlDataReader[6].ToString();
				Module1.Onvan.AvarezArzeshAfzoode = sqlDataReader[7].ToString();
				Module1.Onvan.Semat = sqlDataReader[8].ToString();
				Module1.Onvan.OnvanMabna = sqlDataReader[9].ToString();
			}
			sqlDataReader.Close();
			if (Operators.CompareString(lbl_NoaSanad.Text.Trim(), "فاکتور", TextCompare: false) == 0)
			{
				text = Module1.Onvan.OnvanSanad;
			}
			CrystalReport1 crystalReport = new CrystalReport1();
			crystalReport.Subreports[0].Database.Tables["DataTable1"].SetDataSource(TableFosoolSum);
			checked
			{
				int num = TableSanadSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (i != 0)
					{
						if (Operators.ConditionalCompareObjectNotEqual(TableSanadSum.Rows[i]["درصد"], 0, TextCompare: false))
						{
							TableSanadSum.Rows[i]["شرح"] = TableSanadSum.Rows[i]["شرح"].ToString() + " (" + TableSanadSum.Rows[i]["درصد"].ToString() + TableSanadSum.Rows[i]["نوع"].ToString() + ")";
							TableSanadSum.Rows[i]["درصد"] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
						}
						else
						{
							TableSanadSum.Rows[i]["شرح"] = TableSanadSum.Rows[i]["شرح"].ToString();
						}
						TableSanadSum.Rows[i]["نوع"] = "";
					}
				}
				crystalReport.Subreports[1].Database.Tables["DataTable2"].SetDataSource(TableSanadSum);
				int num2 = AsnadDetailTable.Rows.Count - 1;
				for (int j = 0; j <= num2; j++)
				{
					if ((Operators.CompareString(AsnadDetailTable.Rows[j]["نسبت به ایتم"].ToString(), "0", TextCompare: false) != 0) & (Operators.CompareString(AsnadDetailTable.Rows[j]["نسبت به ایتم"].ToString(), "", TextCompare: false) != 0))
					{
						AsnadDetailTable.Rows[j]["توضیحات"] = Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(AsnadDetailTable.Rows[j]["توضیحات"], " ( نسبت به ایتم "), AsnadDetailTable.Rows[j]["نسبت به ایتم"]), ")");
						AsnadDetailTable.Rows[j]["واحد"] = Operators.ConcatenateObject(Operators.ConcatenateObject(AsnadDetailTable.Rows[j]["درصد"], " "), AsnadDetailTable.Rows[j]["واحد"]);
					}
				}
				crystalReport.Database.Tables["DataTable3"].SetDataSource(AsnadDetailTable);
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
				crystalReport.DataDefinition.FormulaFields["UnboundString22"].Text = "'" + lbl_SanadNo.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString23"].Text = "'" + lbl_JobNo.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_Project.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + lbl_Fehrest.Text + "'";
				string text4 = "";
				switch (lbl_NoaSanad.Text.Trim())
				{
				case "فاکتور":
					text4 = " صورت هزینه ";
					break;
				case "پیش فاکتور":
					text4 = " برآورد هزینه ";
					break;
				case "صوری":
					text4 = " صورت هزینه ";
					break;
				case "قالب":
					text4 = " نمونه صورت هزینه ";
					break;
				}
				crystalReport.DataDefinition.FormulaFields["UnboundString25"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + text4 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString12"].Text = "'" + lbl_Project.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString13"].Text = "'" + lbl_Karfarma.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString17"].Text = "'" + lbl_Fehrest.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString10"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString14"].Text = "'" + lbl_Comment.Text + "'";
				string text5 = lbl_SanadOstan.Text + "-" + lbl_SanadShahr.Text + "-" + lbl_SanadBakhsh.Text;
				crystalReport.DataDefinition.FormulaFields["UnboundString11"].Text = "'" + text5 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString15"].Text = "'" + lbl_SanadZarib1.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString20"].Text = "'" + lbl_SanadZarib2.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString19"].Text = "'" + lbl_SanadZaribComment1.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString21"].Text = "'" + lbl_SanadZaribComment2.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString30"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString32"].Text = "'" + text4 + "'";
				crystalReport.DataDefinition.FormulaFields["UnboundString33"].Text = "'" + lbl_Amaliat.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_MablaghKol1.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString2"].Text = "'" + lbl_MablaghKol2.Text + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString3"].Text = "'" + Module1.Onvan.Semat + "'";
				crystalReport.Subreports[1].DataDefinition.FormulaFields["UnboundString4"].Text = "'" + Module1.Onvan.NameAmel + "'";
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(70);
				MyProject.Forms.frm_PrintSanad.ShowDialog();
				MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
				Load_dtg_SanadSum();
			}
		}

		public void PrintNameh()
		{
			string text = " موضوع: صورت هزینه " + lbl_Project.Text;
			string text2 = ((Operators.CompareString(MyProject.Forms.frm_PrintDialog.txt_Ronevwsht.Text.Trim(), "", TextCompare: false) == 0) ? "" : (" رونوشت : " + MyProject.Forms.frm_PrintDialog.txt_Ronevwsht.Text));
			CrystalReport3 crystalReport = new CrystalReport3();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_Karfarma.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString8"].Text = "'" + MyProject.Forms.frm_PrintDialog.txt_Karnam2.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString2"].Text = "'" + text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + lbl_Comment.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + lbl_MablaghKol1.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString9"].Text = "'" + text2 + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(90);
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

		public void PrintArzeshAfzoode()
		{
			CrystalReport4 crystalReport = new CrystalReport4();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.ReportSource = crystalReport;
			crystalReport.DataDefinition.FormulaFields["UnboundString1"].Text = "'" + lbl_Project.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString2"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString3"].Text = "'" + lbl_Karfarma.Text + "'";
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT Top 1 [adres],[tel],[ShomareEghtesadi],[ShomareSabtYaMelli],[Oname],[ShahrName],[KodPosti] FROM [Jahdazma1].[dbo].[etkarfar]Where REPLACE(REPLACE([kname],'ي',N'ی'),'ك',N'ک') = N'" + Module1.ArbToPer(lbl_Karfarma.Text) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					crystalReport.DataDefinition.FormulaFields["UnboundString4"].Text = "'" + sqlDataReader[4].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString5"].Text = "'" + sqlDataReader[5].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString6"].Text = "'" + sqlDataReader[0].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString7"].Text = "'" + sqlDataReader[6].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString8"].Text = "'" + sqlDataReader[2].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString9"].Text = "'" + sqlDataReader[3].ToString() + "'";
					crystalReport.DataDefinition.FormulaFields["UnboundString10"].Text = "'" + sqlDataReader[1].ToString() + "'";
				}
			}
			crystalReport.DataDefinition.FormulaFields["UnboundString11"].Text = "'" + lbl_SanadNo.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundString12"].Text = "'" + lbl_Comment.Text + "'";
			crystalReport.DataDefinition.FormulaFields["UnboundNumber2"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat + (double)Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber3"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat + (double)Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber4"].Text = Conversions.ToString(Module1.Takhfif);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber5"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text) - (double)Module1.Maliat);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber6"].Text = Conversions.ToString(Module1.Maliat);
			crystalReport.DataDefinition.FormulaFields["UnboundNumber7"].Text = Conversions.ToString(Conversions.ToDouble(lbl_MablaghKol1.Text));
			crystalReport.DataDefinition.FormulaFields["UnboundString20"].Text = "'" + MyProject.Forms.frm_PrintDialog.txt_Tozihat.Text + "'";
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Zoom(85);
			MyProject.Forms.frm_PrintSanad.ShowDialog();
			MyProject.Forms.frm_PrintSanad.CrystalReportViewer1.Refresh();
		}

		public double SumFasl(string Fasl)
		{
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT sum(cast([mablagh] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + lbl_SanadNo.Text + "' And [fasl] = '" + Fasl + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			double result = default(double);
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					result = (Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])) ? 0.0 : Conversions.ToDouble(sqlDataReader[0].ToString()));
				}
			}
			else
			{
				result = 0.0;
			}
			sqlDataReader.Close();
			return result;
		}

		private void lbl_MablaghKol1_TextChanged(object sender, EventArgs e)
		{
			if (Module1.FromEdari == 1)
			{
				return;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.CommandText = "UPDATE [dbo].[Asnad1] SET [mablaghk] ='" + GhabelPardakht + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			checked
			{
				int num = TableSanadSum.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.ConditionalCompareObjectNotEqual(TableSanadSum.Rows[i]["recnum"], 0, TextCompare: false))
					{
						Module1.cmd.CommandText = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject("UPDATE [dbo].[Asnad4] SET [mablagh] = '", TableSanadSum.Rows[i]["مبلغ"]), "'"), ",[mablaghk] = '"), TableSanadSum.Rows[i]["مانده"]), "'"), " WHERE [sanadnum] ='"), Module1.SanadRec.sanadnum), "' AND [recnum] ='"), TableSanadSum.Rows[i]["recnum"]), "'"));
						Module1.cmd.ExecuteNonQuery();
					}
				}
			}
		}

		private void txt_ItemBahavahed_TextChanged(object sender, EventArgs e)
		{
		}

		private void Btn_Return_Click(object sender, EventArgs e)
		{
			Btn_Return1_Click(RuntimeHelpers.GetObjectValue(sender), e);
			if (pnl_SanadSum.BackColor == Color.LightPink)
			{
				Btn_Return1_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (pnl_Item.BackColor == Color.LightPink)
			{
				DialogResult dialogResult = MessageBox.Show("آیا تغییرات ایتم ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.Yes)
				{
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
				}
				if (dialogResult == DialogResult.No)
				{
					SetPnl_ItemBlue();
				}
			}
			dtg_AsnadDetail.Focus();
			ExitFrmAsnadDetail = 1;
			TableSanadSum.Columns.Clear();
			TableFosoolSum.Columns.Clear();
			Close();
			Module1.SanadRecordRefresh = 1;
			MyProject.Forms.Frm_AsnadList.Load_dtg_AsnadList();
			MyProject.Forms.Frm_AsnadList.SetPnl_AsnadBlue();
		}

		private void btn_Print_Click(object sender, EventArgs e)
		{
			if (pnl_Item.BackColor == Color.LightPink)
			{
				MessageBox.Show(" اطلاعات سند ذخیره شود.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				MyProject.Forms.frm_PrintDialog.ShowDialog();
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			int index = default(int);
			int lErl = default(int);
			try
			{
				index = dtg_AsnadDetail.CurrentRow.Index;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				ProjectData.ClearProjectError();
			}
			if (dtg_AsnadDetail.RowCount != 0)
			{
				int index2 = dtg_AsnadDetail.CurrentRow.Index;
				if (MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ایتم ردیف ", dtg_AsnadDetail[1, index2].Value), " با شماره ایتم "), dtg_AsnadDetail[4, index2].Value), " حذف شود؟ ")), "حذف ایتم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "DELETE FROM [dbo].[Asnad2]  WHERE [recnum]= '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
					sqlCommand.ExecuteNonQuery();
				}
			}
			lErl = 20;
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			Module1.BtnCommand = "Delete";
			try
			{
				if (index != 0)
				{
					dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[index].Cells[1];
				}
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, lErl);
				dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[checked(index - 1)].Cells[1];
				ProjectData.ClearProjectError();
			}
			ShowItemRecord();
		}

		private void btn_copy_Click(object sender, EventArgs e)
		{
			string itemnum = Module1.ItemRec.itemnum;
			if (pnl_Item.BackColor == Color.LightPink)
			{
				dtg_AsnadDetail_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_AsnadDetail.CurrentRow.Index;
			DialogResult dialogResult = MessageBox.Show(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(" ایتم ردیف ", dtg_AsnadDetail[1, index].Value), " با شماره ایتم "), dtg_AsnadDetail[4, index].Value), " کپی شود؟ ")), "کپی ایتم", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[asnad2]([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[TimeIjad] ,[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) (SELECT [radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],'" + Environment.MachineName + "','',[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb] FROM [dbo].[asnad2]  WHERE [sanadnum] = '" + Module1.ItemRec.sanadnum + "' And [itemnum] = '" + Module1.ItemRec.itemnum + "' And [fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] = '" + Module1.SanadRec.SalMali + "' And [Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_AsnadDetail(lbl_SanadNo.Text);
			Load_dtg_FosoolSum();
			Load_dtg_SanadSum();
			Module1.BtnCommand = "Copy";
			checked
			{
				int num = dtg_AsnadDetail.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_AsnadDetail.Rows[i].Cells[4].Value.ToString(), itemnum, TextCompare: false) == 0)
					{
						dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[i].Cells[1];
						ShowItemRecord();
						break;
					}
				}
			}
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			BlankItemRec();
			Module1.BtnCommand = "New";
			txt_ItemNo.Focus();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = cmbo_DarsadItem.Text;
			string text2 = txt_DarsadMablagh.Text;
			string text3 = "";
			float num = 0f;
			string text4 = "";
			checked
			{
				int lErl = default(int);
				if (Module1.SanadSabtGharardadha)
				{
					MessageBox.Show(" .سند توسط امور قراردادها ثبت شده است تغییر ممکن نیست", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					Load_dtg_AsnadDetail(lbl_SanadNo.Text);
					Load_dtg_FosoolSum();
					Load_dtg_SanadSum();
					SetPnl_ItemBlue();
				}
				else
				{
					try
					{
						Module1.CurrRow = dtg_AsnadDetail.CurrentRow.Index;
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex, lErl);
						ProjectData.ClearProjectError();
					}
					if (Operators.CompareString(txt_ItemTedad.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult = MessageBox.Show(".تعداد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_ItemTedad.Focus();
						return;
					}
					if (Operators.CompareString(txt_ItemBahavahed.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult2 = MessageBox.Show(".بهای واحد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						txt_ItemBahavahed.Focus();
						return;
					}
					if (Operators.CompareString(cmbo_ItemVahed.Text, "", TextCompare: false) == 0)
					{
						DialogResult dialogResult3 = MessageBox.Show(". واحد ایتم را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						cmbo_ItemVahed.Focus();
					}
					if ((Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدی - ستاره دار", TextCompare: false) == 0) | (Operators.CompareString(lbl_ItemNoa.Text.Trim(), "درصدي - ستاره دار", TextCompare: false) == 0))
					{
						if (Operators.CompareString(txt_DarsadMeghdar.Text, "", TextCompare: false) == 0)
						{
							DialogResult dialogResult4 = MessageBox.Show(". مقدار درصد را وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_DarsadMeghdar.Focus();
							return;
						}
					}
					else
					{
						txt_DarsadMeghdar.Text = "0";
						text = "";
					}
					byte b = default(byte);
					byte b2 = default(byte);
					switch (lbl_ItemNoa.Text.Trim())
					{
					case "بها دار":
						b = Conversions.ToByte("0");
						b2 = Conversions.ToByte("0");
						break;
					case "درصدی":
						b = Conversions.ToByte("1");
						b2 = Conversions.ToByte("0");
						break;
					case "ستاره دار":
					case "توافقی":
						b = Conversions.ToByte("0");
						b2 = Conversions.ToByte("1");
						break;
					case "درصدی - ستاره دار":
						b = Conversions.ToByte("1");
						b2 = Conversions.ToByte("1");
						break;
					}
					string left = cmbo_DarsadItem.Text.Trim();
					byte b3;
					if (Operators.CompareString(left, ": ایتم", TextCompare: false) != 0)
					{
						if (Operators.CompareString(left, ": مبلغ", TextCompare: false) == 0)
						{
							text2 = txt_DarsadMablagh.Text;
							b3 = Conversions.ToByte("1");
							text = "0";
						}
						else
						{
							text = cmbo_DarsadItem.Text;
							text2 = "0";
							b3 = Conversions.ToByte("1");
						}
					}
					else
					{
						text = txt_DarsadMablagh.Text;
						text2 = "0";
						b3 = Conversions.ToByte("1");
					}
					lErl = 20;
					if (Module1.ItemRec.recnum == 0)
					{
						Module1.BtnCommand = "New";
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Asnad2] ([radif],[sanadnum],[itemnum],[sharhitem],[mablagh],[groupnum],[groupname],[fasl],[vahed],[ghvahed],[shvahed],[total],[darsad],[setarehdar],[itemdarsad],[itemname],[molahezat],[fopf],[SalMali],[IjadSystem],[EslahSystem],[TimeIjad],[TimeEslah],[KodDafaterVaBakhsh],[NameDafaterVaBakhsh],[KodGroup],[NameGroup],[Mablaghi],[NesbatbeMablagh],[Soori],[Ghaleb]) VALUES('0','" + lbl_SanadNo.Text + "','" + txt_ItemNo.Text + "','" + txt_ItemSharh.Text + "','" + Conversions.ToString(Math.Round(Conversions.ToSingle(txt_ItemBahaKol.Text))) + "','','','" + cmbo_ItemFasl.Text + "','0','" + Conversions.ToString(Math.Round(Conversions.ToSingle(txt_ItemBahavahed.Text))) + "','" + cmbo_ItemVahed.Text + "','" + txt_ItemTedad.Text + "','" + Conversions.ToString(b) + "','" + Conversions.ToString(b2) + "','" + Conversions.ToString(Conversions.ToSingle(txt_DarsadMeghdar.Text)) + "','" + text + "','" + txt_Tozihat.Text + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + Module1.SanadRec.SalMali + "','" + Environment.MachineName + "','','','','','','','','" + Conversions.ToString(b3) + "','" + text2 + "','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "')";
						Module1.cmd.ExecuteNonQuery();
					}
					else
					{
						Module1.BtnCommand = "Modify";
						Module1.MyConn.Close();
						if (Module1.MyConn.State == ConnectionState.Closed)
						{
							Module1.MyConn.Open();
						}
						Module1.cmd.CommandText = "UPDATE [dbo].[Asnad2] SET [radif] = '0',[sanadnum] = '" + lbl_SanadNo.Text + "',[itemnum] = '" + txt_ItemNo.Text + "',[sharhitem] = '" + txt_ItemSharh.Text + "',[mablagh] = '" + Conversions.ToString(Math.Round(Conversions.ToDouble(txt_ItemBahaKol.Text))) + "',[fasl] = '" + cmbo_ItemFasl.Text + "',[vahed] = '0',[ghvahed] = '" + Conversions.ToString(Math.Round(Conversions.ToDouble(txt_ItemBahavahed.Text))) + "',[shvahed] = '" + cmbo_ItemVahed.Text + "',[total] = '" + txt_ItemTedad.Text + "',[darsad] = '" + Conversions.ToString(b) + "',[setarehdar] = '" + Conversions.ToString(b2) + "',[itemdarsad] = '" + txt_DarsadMeghdar.Text + "',[itemname] = '" + text + "',[molahezat] = '" + txt_Tozihat.Text + "',[fopf] = '" + Conversions.ToString(Module1.SanadRec.forpf) + "',[SalMali] = '" + Module1.SanadRec.SalMali + "',[EslahSystem] = '" + Environment.MachineName + "',[TimeEslah] = '',[Mablaghi] = '" + Conversions.ToString(b3) + "',[NesbatbeMablagh] = '" + text2 + "',[Soori] = '" + Conversions.ToString(Module1.SanadRec.Soori) + "',[Ghaleb] = '" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "' WHERE [recnum] = '" + Conversions.ToString(Module1.ItemRec.recnum) + "'";
						Module1.cmd.ExecuteNonQuery();
					}
					text3 = txt_ItemNo.Text;
					num = Conversions.ToSingle(txt_ItemTedad.Text);
					text4 = txt_Tozihat.Text;
					lErl = 30;
					Load_dtg_AsnadDetail(lbl_SanadNo.Text);
					Load_dtg_FosoolSum();
					Load_dtg_SanadSum();
					SetPnl_ItemBlue();
					int num2 = -1;
					foreach (DataGridViewRow item in (IEnumerable)dtg_AsnadDetail.Rows)
					{
						num2++;
						if (Conversions.ToBoolean(Operators.AndObject(Operators.AndObject(Operators.CompareObjectEqual(item.Cells[4].Value, text3, TextCompare: false), Operators.CompareObjectEqual(item.Cells[10].Value, num, TextCompare: false)), Operators.CompareObjectEqual(item.Cells[15].Value, text4, TextCompare: false))))
						{
							dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[num2].Cells[1];
							ShowItemRecord();
						}
					}
					dtg_AsnadDetail.Focus();
					if (Operators.CompareString(Module1.BtnCommand, "New", TextCompare: false) == 0)
					{
						BlankItemRec();
						txt_ItemNo.Focus();
					}
					else
					{
						try
						{
							dtg_AsnadDetail.CurrentCell = dtg_AsnadDetail.Rows[Module1.CurrRow + 1].Cells[1];
							ShowItemRecord();
							dtg_AsnadDetail.Focus();
						}
						catch (Exception ex2)
						{
							ProjectData.SetProjectError(ex2, lErl);
							ProjectData.ClearProjectError();
						}
					}
				}
				lErl = 10;
			}
		}

		private void cmbo_SumSharh_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		private void txt_SumDarsad_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_SumDarsad.Text, SanadSumRec.Darsad, TextCompare: false) != 0)
			{
				txt_SumDarsad.ForeColor = Color.Red;
			}
			else
			{
				txt_SumDarsad.ForeColor = Color.Black;
			}
		}

		private void lbl_GhabelPardakht_Click(object sender, EventArgs e)
		{
		}

		private void lbl_SumMande_TextChanged(object sender, EventArgs e)
		{
		}

		private void cmbo_ItemFasl_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

        private void pnl_Filter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_ItemRadifFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DarsadMablaghFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemNoFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemTedadFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemBahavahedFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemVahedFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DarsadMeghdarFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemSharhFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemFaslFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemBahaKolFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_DarsadItemFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_TozihatFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Comment_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Amaliat_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Karfarma_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Fehrest_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Project_Click(object sender, EventArgs e)
        {

        }

        private void lbl_JobNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadNo_Click(object sender, EventArgs e)
        {

        }

        private void lbl_NoaSanad_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SalMali_Click(object sender, EventArgs e)
        {

        }

        private void Panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_SanadZaribComment2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadZaribComment1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadZarib2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadZarib1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadBakhsh_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadShahr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadOstan_Click(object sender, EventArgs e)
        {

        }

        private void Label39_Click(object sender, EventArgs e)
        {

        }

        private void Label40_Click(object sender, EventArgs e)
        {

        }

        private void Label41_Click(object sender, EventArgs e)
        {

        }

        private void Label42_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadBakhshCode_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label32_Click(object sender, EventArgs e)
        {

        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_SanadYear_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadMonth_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SanadDay_Click(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Label17_Click(object sender, EventArgs e)
        {

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label22_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void Label19_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }

        private void pnl_Fosool_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_SanadSum_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_SumMande_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void pnl_MablaghKol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MablaghKol1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_MablaghKol2_Click(object sender, EventArgs e)
        {

        }

        private void txt_FaslNoFltr_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label38_Click(object sender, EventArgs e)
        {

        }

        private void Label37_Click(object sender, EventArgs e)
        {

        }

        private void Label35_Click(object sender, EventArgs e)
        {

        }

        private void Label30_Click(object sender, EventArgs e)
        {

        }

        private void Label29_Click(object sender, EventArgs e)
        {

        }

        private void Label24_Click(object sender, EventArgs e)
        {

        }

        private void txt_ItemBahaKol_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label21_Click(object sender, EventArgs e)
        {

        }

        private void cmbo_ItemVahed_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ItemNoa_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_DarsadItem_Click(object sender, EventArgs e)
        {

        }

        private void cmbo_DarsadItem_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_Tozihat_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_ItemSharh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_ItemNo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void pnl_Item_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
