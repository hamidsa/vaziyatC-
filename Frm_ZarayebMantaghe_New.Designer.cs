using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_ZarayebMantaghe_New
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

        // Control declarations
        private System.Windows.Forms.ToolTip ToolTip1;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Button17;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_ZaribCode;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.ComboBox cmbo_Bakhsh;
        private System.Windows.Forms.ComboBox cmbo_BakhshCode;
        private System.Windows.Forms.ComboBox cmbo_BakhshCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_BakhshFltr;
        private System.Windows.Forms.ComboBox cmbo_Comment;
        private System.Windows.Forms.ComboBox cmbo_CommentFltr;
        private System.Windows.Forms.ComboBox cmbo_Ostan;
        private System.Windows.Forms.ComboBox cmbo_OstanCode;
        private System.Windows.Forms.ComboBox cmbo_OstanCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_OstanFltr;
        private System.Windows.Forms.ComboBox cmbo_Shahr;
        private System.Windows.Forms.ComboBox cmbo_ShahrCode;
        private System.Windows.Forms.ComboBox cmbo_ShahrCodeFltr;
        private System.Windows.Forms.ComboBox cmbo_ShahrFltr;
        private System.Windows.Forms.ComboBox cmbo_ZaribBakhshname;
        private System.Windows.Forms.ComboBox cmbo_ZaribCode;
        private System.Windows.Forms.ComboBox cmbo_ZaribCodeFltr;
        private System.Windows.Forms.DataGridView dtg_ZarayebMantaghe;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label lbl_RecNo;
        private System.Windows.Forms.Panel Pnl_Zarib;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txt_ZaribMantagheFltr;
        private System.Windows.Forms.TextBox txt_Zarib_F;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ZarayebMantaghe_New));
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_ZaribCode = new System.Windows.Forms.Button();
            this.btn_Filter = new System.Windows.Forms.Button();
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
            this.pnl_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ZarayebMantaghe)).BeginInit();
            this.Pnl_Zarib.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ZaribCode
            // 
            this.btn_ZaribCode.Image = ((System.Drawing.Image)(resources.GetObject("btn_ZaribCode.Image")));
            this.btn_ZaribCode.Location = new System.Drawing.Point(178, 24);
            this.btn_ZaribCode.Name = "btn_ZaribCode";
            this.btn_ZaribCode.Size = new System.Drawing.Size(28, 26);
            this.btn_ZaribCode.TabIndex = 149;
            this.ToolTip1.SetToolTip(this.btn_ZaribCode, "اصلاح");
            this.btn_ZaribCode.UseVisualStyleBackColor = true;
            this.btn_ZaribCode.Click += new System.EventHandler(this.btn_ZaribCode_Click);
            this.btn_ZaribCode.GotFocus += new System.EventHandler(this.btn_ZaribCode_GotFocus);
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.LightGray;
            this.btn_Filter.Enabled = false;
            this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.Black;
            this.btn_Filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filter.Image")));
            this.btn_Filter.Location = new System.Drawing.Point(1236, 43);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(38, 32);
            this.btn_Filter.TabIndex = 145;
            this.ToolTip1.SetToolTip(this.btn_Filter, "فیلتر");
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // cmbo_ZaribBakhshname
            // 
            this.cmbo_ZaribBakhshname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbo_ZaribBakhshname.FormattingEnabled = true;
            this.cmbo_ZaribBakhshname.Location = new System.Drawing.Point(44, 12);
            this.cmbo_ZaribBakhshname.Name = "cmbo_ZaribBakhshname";
            this.cmbo_ZaribBakhshname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ZaribBakhshname.Size = new System.Drawing.Size(719, 28);
            this.cmbo_ZaribBakhshname.TabIndex = 139;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(1009, 16);
            this.Label11.Name = "Label11";
            this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label11.Size = new System.Drawing.Size(54, 13);
            this.Label11.TabIndex = 141;
            this.Label11.Text = "کد ضریب :";
            this.Label11.Visible = false;
            // 
            // pnl_Filter
            // 
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
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Location = new System.Drawing.Point(1685, -15);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(49, 56);
            this.Label10.TabIndex = 153;
            this.Label10.Text = "ردیف";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbo_ZaribCodeFltr
            // 
            this.cmbo_ZaribCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_ZaribCodeFltr.FormattingEnabled = true;
            this.cmbo_ZaribCodeFltr.Location = new System.Drawing.Point(458, 40);
            this.cmbo_ZaribCodeFltr.Name = "cmbo_ZaribCodeFltr";
            this.cmbo_ZaribCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ZaribCodeFltr.Size = new System.Drawing.Size(70, 21);
            this.cmbo_ZaribCodeFltr.TabIndex = 89;
            this.cmbo_ZaribCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ZaribCodeFltr_SelectedIndexChanged);
            this.cmbo_ZaribCodeFltr.TextChanged += new System.EventHandler(this.cmbo_ZaribCodeFltr_TextChanged);
            // 
            // cmbo_CommentFltr
            // 
            this.cmbo_CommentFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_CommentFltr.FormattingEnabled = true;
            this.cmbo_CommentFltr.Location = new System.Drawing.Point(16, 40);
            this.cmbo_CommentFltr.Name = "cmbo_CommentFltr";
            this.cmbo_CommentFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_CommentFltr.Size = new System.Drawing.Size(441, 21);
            this.cmbo_CommentFltr.TabIndex = 90;
            this.cmbo_CommentFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_CommentFltr_SelectedIndexChanged);
            this.cmbo_CommentFltr.TextChanged += new System.EventHandler(this.cmbo_CommentFltr_TextChanged);
            // 
            // cmbo_BakhshCodeFltr
            // 
            this.cmbo_BakhshCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_BakhshCodeFltr.FormattingEnabled = true;
            this.cmbo_BakhshCodeFltr.Location = new System.Drawing.Point(724, 40);
            this.cmbo_BakhshCodeFltr.Name = "cmbo_BakhshCodeFltr";
            this.cmbo_BakhshCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_BakhshCodeFltr.Size = new System.Drawing.Size(67, 21);
            this.cmbo_BakhshCodeFltr.TabIndex = 86;
            this.cmbo_BakhshCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshCodeFltr_SelectedIndexChanged);
            this.cmbo_BakhshCodeFltr.TextChanged += new System.EventHandler(this.cmbo_BakhshCodeFltr_TextChanged);
            // 
            // cmbo_ShahrFltr
            // 
            this.cmbo_ShahrFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_ShahrFltr.FormattingEnabled = true;
            this.cmbo_ShahrFltr.Location = new System.Drawing.Point(792, 40);
            this.cmbo_ShahrFltr.Name = "cmbo_ShahrFltr";
            this.cmbo_ShahrFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ShahrFltr.Size = new System.Drawing.Size(120, 21);
            this.cmbo_ShahrFltr.TabIndex = 85;
            this.cmbo_ShahrFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrFltr_SelectedIndexChanged);
            this.cmbo_ShahrFltr.TextChanged += new System.EventHandler(this.cmbo_ShahrFltr_TextChanged);
            // 
            // cmbo_BakhshFltr
            // 
            this.cmbo_BakhshFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_BakhshFltr.FormattingEnabled = true;
            this.cmbo_BakhshFltr.Location = new System.Drawing.Point(604, 40);
            this.cmbo_BakhshFltr.Name = "cmbo_BakhshFltr";
            this.cmbo_BakhshFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_BakhshFltr.Size = new System.Drawing.Size(119, 21);
            this.cmbo_BakhshFltr.TabIndex = 87;
            this.cmbo_BakhshFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshFltr_SelectedIndexChanged);
            this.cmbo_BakhshFltr.TextChanged += new System.EventHandler(this.cmbo_BakhshFltr_TextChanged);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(17, 2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1206, 36);
            this.PictureBox1.TabIndex = 147;
            this.PictureBox1.TabStop = false;
            // 
            // txt_ZaribMantagheFltr
            // 
            this.txt_ZaribMantagheFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ZaribMantagheFltr.Location = new System.Drawing.Point(529, 40);
            this.txt_ZaribMantagheFltr.Name = "txt_ZaribMantagheFltr";
            this.txt_ZaribMantagheFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ZaribMantagheFltr.Size = new System.Drawing.Size(74, 20);
            this.txt_ZaribMantagheFltr.TabIndex = 88;
            this.txt_ZaribMantagheFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ZaribMantagheFltr_KeyDown);
            // 
            // cmbo_OstanCodeFltr
            // 
            this.cmbo_OstanCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_OstanCodeFltr.FormattingEnabled = true;
            this.cmbo_OstanCodeFltr.Location = new System.Drawing.Point(1102, 40);
            this.cmbo_OstanCodeFltr.Name = "cmbo_OstanCodeFltr";
            this.cmbo_OstanCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_OstanCodeFltr.Size = new System.Drawing.Size(69, 21);
            this.cmbo_OstanCodeFltr.TabIndex = 82;
            this.cmbo_OstanCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanCodeCodeFltr_SelectedIndexChanged);
            this.cmbo_OstanCodeFltr.TextChanged += new System.EventHandler(this.cmbo_OstanCodeFltr_TextChanged);
            // 
            // cmbo_OstanFltr
            // 
            this.cmbo_OstanFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_OstanFltr.FormattingEnabled = true;
            this.cmbo_OstanFltr.Location = new System.Drawing.Point(983, 40);
            this.cmbo_OstanFltr.Name = "cmbo_OstanFltr";
            this.cmbo_OstanFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_OstanFltr.Size = new System.Drawing.Size(118, 21);
            this.cmbo_OstanFltr.TabIndex = 83;
            this.cmbo_OstanFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanFltr_SelectedIndexChanged);
            this.cmbo_OstanFltr.TextChanged += new System.EventHandler(this.cmbo_OstanFltr_TextChanged);
            // 
            // cmbo_ShahrCodeFltr
            // 
            this.cmbo_ShahrCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_ShahrCodeFltr.FormattingEnabled = true;
            this.cmbo_ShahrCodeFltr.Location = new System.Drawing.Point(913, 40);
            this.cmbo_ShahrCodeFltr.Name = "cmbo_ShahrCodeFltr";
            this.cmbo_ShahrCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ShahrCodeFltr.Size = new System.Drawing.Size(69, 21);
            this.cmbo_ShahrCodeFltr.TabIndex = 84;
            this.cmbo_ShahrCodeFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrCodeFltr_SelectedIndexChanged);
            this.cmbo_ShahrCodeFltr.TextChanged += new System.EventHandler(this.cmbo_ShahrCodeFltr_TextChanged);
            // 
            // Button17
            // 
            this.Button17.BackColor = System.Drawing.Color.LightGray;
            this.Button17.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button17.ForeColor = System.Drawing.Color.Black;
            this.Button17.Location = new System.Drawing.Point(1506, 7);
            this.Button17.Name = "Button17";
            this.Button17.Size = new System.Drawing.Size(89, 21);
            this.Button17.TabIndex = 44;
            this.Button17.Text = "حذف فیلتر";
            this.Button17.UseVisualStyleBackColor = false;
            // 
            // dtg_ZarayebMantaghe
            // 
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
            this.dtg_ZarayebMantaghe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ZarayebMantaghe_CellClick);
            this.dtg_ZarayebMantaghe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_ZarayebMantaghe_CellContentClick);
            this.dtg_ZarayebMantaghe.SelectionChanged += new System.EventHandler(this.dtg_ZarayebMantaghe_SelectionChanged);
            this.dtg_ZarayebMantaghe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_ZarayebMantaghe_KeyDown);
            // 
            // Pnl_Zarib
            // 
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
            // 
            // lbl_RecNo
            // 
            this.lbl_RecNo.AutoSize = true;
            this.lbl_RecNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lbl_RecNo.Location = new System.Drawing.Point(1172, 8);
            this.lbl_RecNo.Name = "lbl_RecNo";
            this.lbl_RecNo.Size = new System.Drawing.Size(61, 13);
            this.lbl_RecNo.TabIndex = 150;
            this.lbl_RecNo.Text = "تعداد رکورد";
            // 
            // cmbo_ZaribCode
            // 
            this.cmbo_ZaribCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_ZaribCode.FormattingEnabled = true;
            this.cmbo_ZaribCode.Location = new System.Drawing.Point(988, 27);
            this.cmbo_ZaribCode.Name = "cmbo_ZaribCode";
            this.cmbo_ZaribCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ZaribCode.Size = new System.Drawing.Size(85, 21);
            this.cmbo_ZaribCode.TabIndex = 91;
            this.cmbo_ZaribCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_ZaribCode_SelectedIndexChanged);
            this.cmbo_ZaribCode.TextChanged += new System.EventHandler(this.cmbo_ZaribCode_TextChanged);
            this.cmbo_ZaribCode.GotFocus += new System.EventHandler(this.cmbo_ZaribCode_GotFocus);
            // 
            // cmbo_Comment
            // 
            this.cmbo_Comment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbo_Comment.FormattingEnabled = true;
            this.cmbo_Comment.Location = new System.Drawing.Point(207, 27);
            this.cmbo_Comment.Name = "cmbo_Comment";
            this.cmbo_Comment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_Comment.Size = new System.Drawing.Size(781, 21);
            this.cmbo_Comment.TabIndex = 92;
            this.cmbo_Comment.SelectedIndexChanged += new System.EventHandler(this.cmbo_Comment_SelectedIndexChanged);
            this.cmbo_Comment.TextChanged += new System.EventHandler(this.cmbo_Comment_TextChanged);
            this.cmbo_Comment.GotFocus += new System.EventHandler(this.cmbo_Comment_GotFocus);
            // 
            // cmbo_BakhshCode
            // 
            this.cmbo_BakhshCode.FormattingEnabled = true;
            this.cmbo_BakhshCode.Location = new System.Drawing.Point(459, 80);
            this.cmbo_BakhshCode.Name = "cmbo_BakhshCode";
            this.cmbo_BakhshCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_BakhshCode.Size = new System.Drawing.Size(78, 21);
            this.cmbo_BakhshCode.TabIndex = 97;
            this.cmbo_BakhshCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_BakhshCode_SelectedIndexChanged);
            this.cmbo_BakhshCode.TextChanged += new System.EventHandler(this.cmbo_BakhshCode_TextChanged);
            this.cmbo_BakhshCode.GotFocus += new System.EventHandler(this.cmbo_BakhshCode_GotFocus);
            // 
            // cmbo_Shahr
            // 
            this.cmbo_Shahr.FormattingEnabled = true;
            this.cmbo_Shahr.Location = new System.Drawing.Point(574, 80);
            this.cmbo_Shahr.Name = "cmbo_Shahr";
            this.cmbo_Shahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_Shahr.Size = new System.Drawing.Size(151, 21);
            this.cmbo_Shahr.TabIndex = 96;
            this.cmbo_Shahr.SelectedIndexChanged += new System.EventHandler(this.cmbo_Shahr_SelectedIndexChanged);
            this.cmbo_Shahr.TextChanged += new System.EventHandler(this.cmbo_Shahr_TextChanged);
            this.cmbo_Shahr.GotFocus += new System.EventHandler(this.cmbo_Shahr_GotFocus);
            // 
            // cmbo_Bakhsh
            // 
            this.cmbo_Bakhsh.FormattingEnabled = true;
            this.cmbo_Bakhsh.Location = new System.Drawing.Point(313, 80);
            this.cmbo_Bakhsh.Name = "cmbo_Bakhsh";
            this.cmbo_Bakhsh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_Bakhsh.Size = new System.Drawing.Size(146, 21);
            this.cmbo_Bakhsh.TabIndex = 98;
            this.cmbo_Bakhsh.SelectedIndexChanged += new System.EventHandler(this.cmbo_Bakhsh_SelectedIndexChanged);
            this.cmbo_Bakhsh.TextChanged += new System.EventHandler(this.cmbo_Bakhsh_TextChanged);
            this.cmbo_Bakhsh.GotFocus += new System.EventHandler(this.cmbo_Bakhsh_GotFocus);
            this.cmbo_Bakhsh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_Bakhsh_KeyUp);
            this.cmbo_Bakhsh.LostFocus += new System.EventHandler(this.cmbo_Bakhsh_LostFocus);
            // 
            // cmbo_OstanCode
            // 
            this.cmbo_OstanCode.FormattingEnabled = true;
            this.cmbo_OstanCode.Location = new System.Drawing.Point(988, 80);
            this.cmbo_OstanCode.Name = "cmbo_OstanCode";
            this.cmbo_OstanCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_OstanCode.Size = new System.Drawing.Size(85, 21);
            this.cmbo_OstanCode.TabIndex = 93;
            this.cmbo_OstanCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_OstanCode_SelectedIndexChanged);
            this.cmbo_OstanCode.TextChanged += new System.EventHandler(this.cmbo_OstanCode_TextChanged);
            this.cmbo_OstanCode.GotFocus += new System.EventHandler(this.cmbo_OstanCode_GotFocus);
            this.cmbo_OstanCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_OstanCode_KeyDown);
            this.cmbo_OstanCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cmbo_OstanCode_KeyUp);
            // 
            // cmbo_Ostan
            // 
            this.cmbo_Ostan.FormattingEnabled = true;
            this.cmbo_Ostan.Location = new System.Drawing.Point(838, 80);
            this.cmbo_Ostan.Name = "cmbo_Ostan";
            this.cmbo_Ostan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_Ostan.Size = new System.Drawing.Size(150, 21);
            this.cmbo_Ostan.TabIndex = 94;
            this.cmbo_Ostan.SelectedIndexChanged += new System.EventHandler(this.cmbo_Ostan_SelectedIndexChanged);
            this.cmbo_Ostan.TextChanged += new System.EventHandler(this.cmbo_Ostan_TextChanged);
            this.cmbo_Ostan.GotFocus += new System.EventHandler(this.cmbo_Ostan_GotFocus);
            // 
            // cmbo_ShahrCode
            // 
            this.cmbo_ShahrCode.FormattingEnabled = true;
            this.cmbo_ShahrCode.Location = new System.Drawing.Point(725, 80);
            this.cmbo_ShahrCode.Name = "cmbo_ShahrCode";
            this.cmbo_ShahrCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_ShahrCode.Size = new System.Drawing.Size(83, 21);
            this.cmbo_ShahrCode.TabIndex = 95;
            this.cmbo_ShahrCode.SelectedIndexChanged += new System.EventHandler(this.cmbo_ShahrCode_SelectedIndexChanged);
            this.cmbo_ShahrCode.FormatStringChanged += new System.EventHandler(this.cmbo_ShahrCode_FormatStringChanged);
            this.cmbo_ShahrCode.TextChanged += new System.EventHandler(this.cmbo_ShahrCode_TextChanged);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.Location = new System.Drawing.Point(335, 116);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.Size = new System.Drawing.Size(80, 25);
            this.btn_Delete.TabIndex = 103;
            this.btn_Delete.Text = "(Del) حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.GotFocus += new System.EventHandler(this.btn_Delete_GotFocus);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(572, 116);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_copy.Size = new System.Drawing.Size(80, 25);
            this.btn_copy.TabIndex = 102;
            this.btn_copy.Text = "(Clt+C) کپی";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            this.btn_copy.GotFocus += new System.EventHandler(this.btn_copy_GotFocus);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(800, 116);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Insert.Size = new System.Drawing.Size(80, 25);
            this.btn_Insert.TabIndex = 101;
            this.btn_Insert.Text = "(Ins) ایجاد ";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            this.btn_Insert.GotFocus += new System.EventHandler(this.btn_Insert_GotFocus);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(549, 11);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 13);
            this.Label5.TabIndex = 139;
            this.Label5.Text = "شرح کد بخش نامه";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(1008, 11);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(60, 13);
            this.Label4.TabIndex = 138;
            this.Label4.Text = "کد بخشنامه";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(480, 65);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(42, 13);
            this.Label3.TabIndex = 134;
            this.Label3.Text = "کد بخش";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(744, 65);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(42, 13);
            this.Label2.TabIndex = 132;
            this.Label2.Text = "کد شهر";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(1007, 65);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(49, 13);
            this.Label1.TabIndex = 130;
            this.Label1.Text = "کد استان";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(388, 65);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(27, 13);
            this.Label6.TabIndex = 122;
            this.Label6.Text = "بخش";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(641, 65);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(27, 13);
            this.Label7.TabIndex = 120;
            this.Label7.Text = "شهر";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(904, 65);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(34, 13);
            this.Label8.TabIndex = 117;
            this.Label8.Text = "استان";
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(132, 116);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Exit.Size = new System.Drawing.Size(80, 25);
            this.btn_Exit.TabIndex = 104;
            this.btn_Exit.Text = " خروج ";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            this.btn_Exit.GotFocus += new System.EventHandler(this.btn_Exit_GotFocus);
            // 
            // Btn_Save
            // 
            this.Btn_Save.Location = new System.Drawing.Point(1050, 116);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(80, 25);
            this.Btn_Save.TabIndex = 100;
            this.Btn_Save.Text = "(F2) ذخیره ";
            this.Btn_Save.UseVisualStyleBackColor = true;
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.Btn_Save.GotFocus += new System.EventHandler(this.Btn_Save_GotFocus);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(214, 65);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(33, 13);
            this.Label9.TabIndex = 95;
            this.Label9.Text = "ضریب";
            // 
            // txt_Zarib_F
            // 
            this.txt_Zarib_F.Location = new System.Drawing.Point(176, 80);
            this.txt_Zarib_F.Name = "txt_Zarib_F";
            this.txt_Zarib_F.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Zarib_F.Size = new System.Drawing.Size(100, 20);
            this.txt_Zarib_F.TabIndex = 99;
            this.txt_Zarib_F.TextChanged += new System.EventHandler(this.txt_Zarib_F_TextChanged);
            this.txt_Zarib_F.GotFocus += new System.EventHandler(this.txt_Zarib_F_GotFocus);
            this.txt_Zarib_F.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Zarib_F_KeyPress);
            this.txt_Zarib_F.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Zarib_F_KeyUp);
            // 
            // Frm_ZarayebMantaghe_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 702);
            this.Controls.Add(this.btn_Filter);
            this.Controls.Add(this.pnl_Filter);
            this.Controls.Add(this.dtg_ZarayebMantaghe);
            this.Controls.Add(this.Pnl_Zarib);
            this.Controls.Add(this.Label11);
            this.Name = "Frm_ZarayebMantaghe_New";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست ضرایب منطقه ای";
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_ZarayebMantaghe)).EndInit();
            this.Pnl_Zarib.ResumeLayout(false);
            this.Pnl_Zarib.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}