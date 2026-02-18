using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_AsnadDetail_New
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Component declarations

        // Controls

        // Button
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Return1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Delete1;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Modify1;
        private System.Windows.Forms.Button btn_New1;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Save1;
        private System.Windows.Forms.Button btn_View;
        private System.Windows.Forms.Button btn_copy;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_DarsadItem;
        private System.Windows.Forms.ComboBox cmbo_ItemFasl;
        private System.Windows.Forms.ComboBox cmbo_ItemNoaFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemVahed;
        private System.Windows.Forms.ComboBox cmbo_SumNoa;
        private System.Windows.Forms.ComboBox cmbo_SumSharh;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_AsnadDetail;
        private System.Windows.Forms.DataGridView dtg_FosoolSum;
        private System.Windows.Forms.DataGridView dtg_SanadSum;

        // Label
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.Label Label14;
        private System.Windows.Forms.Label Label15;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.Label Label22;
        private System.Windows.Forms.Label Label24;
        private System.Windows.Forms.Label Label29;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label30;
        private System.Windows.Forms.Label Label32;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.Label Label37;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Label Label39;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label40;
        private System.Windows.Forms.Label Label41;
        private System.Windows.Forms.Label Label42;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lbl_Amaliat;
        private System.Windows.Forms.Label lbl_Comment;
        private System.Windows.Forms.Label lbl_DarsadItem;
        private System.Windows.Forms.Label lbl_Fehrest;
        private System.Windows.Forms.Label lbl_GhabelPardakht;
        private System.Windows.Forms.Label lbl_ItemNoa;
        private System.Windows.Forms.Label lbl_JobNo;
        private System.Windows.Forms.Label lbl_Karfarma;
        private System.Windows.Forms.Label lbl_MablaghKol1;
        private System.Windows.Forms.Label lbl_MablaghKol2;
        private System.Windows.Forms.Label lbl_NoaSanad;
        private System.Windows.Forms.Label lbl_Project;
        private System.Windows.Forms.Label lbl_SalMali;
        private System.Windows.Forms.Label lbl_SanadBakhsh;
        private System.Windows.Forms.Label lbl_SanadBakhshCode;
        private System.Windows.Forms.Label lbl_SanadDay;
        private System.Windows.Forms.Label lbl_SanadMonth;
        private System.Windows.Forms.Label lbl_SanadNo;
        private System.Windows.Forms.Label lbl_SanadOstan;
        private System.Windows.Forms.Label lbl_SanadShahr;
        private System.Windows.Forms.Label lbl_SanadYear;
        private System.Windows.Forms.Label lbl_SanadZarib1;
        private System.Windows.Forms.Label lbl_SanadZarib2;
        private System.Windows.Forms.Label lbl_SanadZaribComment1;
        private System.Windows.Forms.Label lbl_SanadZaribComment2;
        private System.Windows.Forms.Label lbl_SumMande;

        // Panel
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Panel Panel8;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.Panel pnl_Fosool;
        private System.Windows.Forms.Panel pnl_Item;
        private System.Windows.Forms.Panel pnl_MablaghKol;
        private System.Windows.Forms.Panel pnl_SanadSum;

        // PictureBox
        private System.Windows.Forms.PictureBox PictureBox1;

        // TextBox
        private System.Windows.Forms.TextBox txt_DarsadItemFltr;
        private System.Windows.Forms.TextBox txt_DarsadMablagh;
        private System.Windows.Forms.TextBox txt_DarsadMablaghFltr;
        private System.Windows.Forms.TextBox txt_DarsadMeghdar;
        private System.Windows.Forms.TextBox txt_DarsadMeghdarFltr;
        private System.Windows.Forms.TextBox txt_FaslNoFltr;
        private System.Windows.Forms.TextBox txt_ItemBahaKol;
        private System.Windows.Forms.TextBox txt_ItemBahaKolFltr;
        private System.Windows.Forms.TextBox txt_ItemBahavahed;
        private System.Windows.Forms.TextBox txt_ItemBahavahedFltr;
        private System.Windows.Forms.TextBox txt_ItemFaslFltr;
        private System.Windows.Forms.TextBox txt_ItemNo;
        private System.Windows.Forms.TextBox txt_ItemNoFltr;
        private System.Windows.Forms.TextBox txt_ItemRadifFltr;
        private System.Windows.Forms.TextBox txt_ItemSharh;
        private System.Windows.Forms.TextBox txt_ItemSharhFltr;
        private System.Windows.Forms.TextBox txt_ItemTedad;
        private System.Windows.Forms.TextBox txt_ItemTedadFltr;
        private System.Windows.Forms.TextBox txt_ItemVahedFltr;
        private System.Windows.Forms.TextBox txt_SumDarsad;
        private System.Windows.Forms.TextBox txt_SumMablagh;
        private System.Windows.Forms.TextBox txt_SumRadif;
        private System.Windows.Forms.TextBox txt_Tozihat;
        private System.Windows.Forms.TextBox txt_TozihatFltr;

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
    }
}
