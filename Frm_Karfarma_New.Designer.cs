using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_Karfarma_New
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
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaOstan;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaOstanFltr;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaShahr;
        private System.Windows.Forms.ComboBox cmbo_KarfarmaShahrFltr;
        private System.Windows.Forms.DataGridView dtg_Karfarma;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label24;
        private System.Windows.Forms.Label Label29;
        private System.Windows.Forms.Label Label30;
        private System.Windows.Forms.Label Label35;
        private System.Windows.Forms.Label Label36;
        private System.Windows.Forms.Label Label37;
        private System.Windows.Forms.Label Label38;
        private System.Windows.Forms.Panel pnl_Karfarma;
        private System.Windows.Forms.Panel pnl_filter;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.TextBox txt_KarfarmaAddress;
        private System.Windows.Forms.TextBox txt_KarfarmaAddressFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaCode;
        private System.Windows.Forms.TextBox txt_KarfarmaCodeEghtesadi;
        private System.Windows.Forms.TextBox txt_KarfarmaCodeFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaEghtesadiCodeFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaMelliCode;
        private System.Windows.Forms.TextBox txt_KarfarmaMelliCodelFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaName;
        private System.Windows.Forms.TextBox txt_KarfarmaNameFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaPostCode;
        private System.Windows.Forms.TextBox txt_KarfarmaPostiCodeFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaTel;
        private System.Windows.Forms.TextBox txt_KarfarmaTelFltr;
        private System.Windows.Forms.ToolTip ToolTip1;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Karfarma_New));
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
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Karfarma)).BeginInit();
            this.pnl_filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Karfarma
            // 
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
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(759, 56);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Insert.Size = new System.Drawing.Size(100, 27);
            this.btn_Insert.TabIndex = 101;
            this.btn_Insert.Text = "(Ins) ایجاد ";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(536, 56);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_copy.Size = new System.Drawing.Size(100, 27);
            this.btn_copy.TabIndex = 102;
            this.btn_copy.Text = "(Clt+C) کپی";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(961, 56);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(100, 27);
            this.btn_Save.TabIndex = 100;
            this.btn_Save.Text = "(F2) ذخیره";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(322, 56);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.Size = new System.Drawing.Size(100, 27);
            this.btn_Delete.TabIndex = 103;
            this.btn_Delete.Text = "(Del) حذف";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(110, 56);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Exit.Size = new System.Drawing.Size(100, 27);
            this.btn_Exit.TabIndex = 104;
            this.btn_Exit.Text = " خروج ";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            // 
            // txt_KarfarmaMelliCode
            // 
            this.txt_KarfarmaMelliCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaMelliCode.Location = new System.Drawing.Point(440, 21);
            this.txt_KarfarmaMelliCode.Name = "txt_KarfarmaMelliCode";
            this.txt_KarfarmaMelliCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaMelliCode.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaMelliCode.TabIndex = 96;
            this.txt_KarfarmaMelliCode.TextChanged += new System.EventHandler(this.txt_KarfarmaMelliCode_TextChanged);
            this.txt_KarfarmaMelliCode.GotFocus += new System.EventHandler(this.txt_KarfarmaMelliCode_GotFocus);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(438, 5);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(102, 13);
            this.Label2.TabIndex = 109;
            this.Label2.Text = "کد ملی / شماره ثبت ";
            // 
            // txt_KarfarmaCodeEghtesadi
            // 
            this.txt_KarfarmaCodeEghtesadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaCodeEghtesadi.Location = new System.Drawing.Point(541, 21);
            this.txt_KarfarmaCodeEghtesadi.Name = "txt_KarfarmaCodeEghtesadi";
            this.txt_KarfarmaCodeEghtesadi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaCodeEghtesadi.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaCodeEghtesadi.TabIndex = 95;
            this.txt_KarfarmaCodeEghtesadi.TextChanged += new System.EventHandler(this.txt_KarfarmaCodeEghtesadi_TextChanged);
            this.txt_KarfarmaCodeEghtesadi.GotFocus += new System.EventHandler(this.txt_KarfarmaCodeEghtesadi_GotFocus);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(563, 5);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 107;
            this.Label1.Text = "کد اقتصادی";
            // 
            // txt_KarfarmaPostCode
            // 
            this.txt_KarfarmaPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaPostCode.Location = new System.Drawing.Point(338, 21);
            this.txt_KarfarmaPostCode.Name = "txt_KarfarmaPostCode";
            this.txt_KarfarmaPostCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaPostCode.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaPostCode.TabIndex = 97;
            this.txt_KarfarmaPostCode.TextChanged += new System.EventHandler(this.txt_KarfarmaPostCode_TextChanged);
            this.txt_KarfarmaPostCode.GotFocus += new System.EventHandler(this.txt_KarfarmaPostCode_GotFocus);
            // 
            // Label24
            // 
            this.Label24.AutoSize = true;
            this.Label24.Location = new System.Drawing.Point(366, 5);
            this.Label24.Name = "Label24";
            this.Label24.Size = new System.Drawing.Size(49, 13);
            this.Label24.TabIndex = 103;
            this.Label24.Text = "کد پستی";
            // 
            // Label29
            // 
            this.Label29.AutoSize = true;
            this.Label29.Location = new System.Drawing.Point(664, 5);
            this.Label29.Name = "Label29";
            this.Label29.Size = new System.Drawing.Size(54, 13);
            this.Label29.TabIndex = 101;
            this.Label29.Text = " شهرستان";
            // 
            // cmbo_KarfarmaShahr
            // 
            this.cmbo_KarfarmaShahr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbo_KarfarmaShahr.FormattingEnabled = true;
            this.cmbo_KarfarmaShahr.Location = new System.Drawing.Point(642, 21);
            this.cmbo_KarfarmaShahr.Name = "cmbo_KarfarmaShahr";
            this.cmbo_KarfarmaShahr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_KarfarmaShahr.Size = new System.Drawing.Size(100, 21);
            this.cmbo_KarfarmaShahr.TabIndex = 94;
            this.cmbo_KarfarmaShahr.TextChanged += new System.EventHandler(this.cmbo_KarfarmaShahr_TextChanged);
            this.cmbo_KarfarmaShahr.GotFocus += new System.EventHandler(this.cmbo_KarfarmaShahr_GotFocus);
            // 
            // Label30
            // 
            this.Label30.AutoSize = true;
            this.Label30.Location = new System.Drawing.Point(781, 5);
            this.Label30.Name = "Label30";
            this.Label30.Size = new System.Drawing.Size(34, 13);
            this.Label30.TabIndex = 99;
            this.Label30.Text = "استان";
            // 
            // cmbo_KarfarmaOstan
            // 
            this.cmbo_KarfarmaOstan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbo_KarfarmaOstan.FormattingEnabled = true;
            this.cmbo_KarfarmaOstan.Location = new System.Drawing.Point(743, 21);
            this.cmbo_KarfarmaOstan.Name = "cmbo_KarfarmaOstan";
            this.cmbo_KarfarmaOstan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_KarfarmaOstan.Size = new System.Drawing.Size(100, 21);
            this.cmbo_KarfarmaOstan.TabIndex = 93;
            this.cmbo_KarfarmaOstan.SelectedIndexChanged += new System.EventHandler(this.cmbo_KarfarmaOstan_SelectedIndexChanged);
            this.cmbo_KarfarmaOstan.TextChanged += new System.EventHandler(this.cmbo_KarfarmaOstan_TextChanged);
            this.cmbo_KarfarmaOstan.GotFocus += new System.EventHandler(this.cmbo_KarfarmaOstan_GotFocus);
            // 
            // Label38
            // 
            this.Label38.AutoSize = true;
            this.Label38.Location = new System.Drawing.Point(72, 5);
            this.Label38.Name = "Label38";
            this.Label38.Size = new System.Drawing.Size(32, 13);
            this.Label38.TabIndex = 97;
            this.Label38.Text = " تلفن ";
            // 
            // Label37
            // 
            this.Label37.AutoSize = true;
            this.Label37.Location = new System.Drawing.Point(209, 5);
            this.Label37.Name = "Label37";
            this.Label37.Size = new System.Drawing.Size(72, 13);
            this.Label37.TabIndex = 96;
            this.Label37.Text = " آدرس کارفرما";
            // 
            // Label36
            // 
            this.Label36.AutoSize = true;
            this.Label36.Location = new System.Drawing.Point(922, 5);
            this.Label36.Name = "Label36";
            this.Label36.Size = new System.Drawing.Size(62, 13);
            this.Label36.TabIndex = 95;
            this.Label36.Text = " نام کارفرما";
            // 
            // Label35
            // 
            this.Label35.AutoSize = true;
            this.Label35.Location = new System.Drawing.Point(1062, 5);
            this.Label35.Name = "Label35";
            this.Label35.Size = new System.Drawing.Size(58, 13);
            this.Label35.TabIndex = 94;
            this.Label35.Text = "کد کارفرما";
            // 
            // txt_KarfarmaTel
            // 
            this.txt_KarfarmaTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaTel.Location = new System.Drawing.Point(47, 21);
            this.txt_KarfarmaTel.Name = "txt_KarfarmaTel";
            this.txt_KarfarmaTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaTel.Size = new System.Drawing.Size(80, 20);
            this.txt_KarfarmaTel.TabIndex = 99;
            this.txt_KarfarmaTel.TextChanged += new System.EventHandler(this.txt_KarfarmaTel_TextChanged);
            this.txt_KarfarmaTel.GotFocus += new System.EventHandler(this.txt_KarfarmaTel_GotFocus);
            // 
            // txt_KarfarmaAddress
            // 
            this.txt_KarfarmaAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaAddress.Location = new System.Drawing.Point(127, 21);
            this.txt_KarfarmaAddress.Name = "txt_KarfarmaAddress";
            this.txt_KarfarmaAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaAddress.Size = new System.Drawing.Size(210, 20);
            this.txt_KarfarmaAddress.TabIndex = 98;
            this.txt_KarfarmaAddress.TextChanged += new System.EventHandler(this.txt_KarfarmaAddress_TextChanged);
            this.txt_KarfarmaAddress.GotFocus += new System.EventHandler(this.txt_KarfarmaAddress_GotFocus);
            // 
            // txt_KarfarmaCode
            // 
            this.txt_KarfarmaCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaCode.Location = new System.Drawing.Point(1055, 21);
            this.txt_KarfarmaCode.Name = "txt_KarfarmaCode";
            this.txt_KarfarmaCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaCode.Size = new System.Drawing.Size(75, 20);
            this.txt_KarfarmaCode.TabIndex = 91;
            this.txt_KarfarmaCode.TextChanged += new System.EventHandler(this.txt_KarfarmaCode_TextChanged);
            this.txt_KarfarmaCode.GotFocus += new System.EventHandler(this.txt_KarfarmaCode_GotFocus);
            // 
            // txt_KarfarmaName
            // 
            this.txt_KarfarmaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaName.Location = new System.Drawing.Point(844, 21);
            this.txt_KarfarmaName.Name = "txt_KarfarmaName";
            this.txt_KarfarmaName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaName.Size = new System.Drawing.Size(210, 20);
            this.txt_KarfarmaName.TabIndex = 92;
            this.txt_KarfarmaName.TextChanged += new System.EventHandler(this.txt_Karfarma_TextChanged);
            this.txt_KarfarmaName.GotFocus += new System.EventHandler(this.txt_Karfarma_GotFocus);
            // 
            // dtg_Karfarma
            // 
            this.dtg_Karfarma.AllowUserToAddRows = false;
            this.dtg_Karfarma.AllowUserToDeleteRows = false;
            this.dtg_Karfarma.AllowUserToOrderColumns = true;
            this.dtg_Karfarma.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_Karfarma.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Karfarma.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtg_Karfarma.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_Karfarma.Location = new System.Drawing.Point(5, 24);
            this.dtg_Karfarma.Name = "dtg_Karfarma";
            this.dtg_Karfarma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtg_Karfarma.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtg_Karfarma.RowTemplate.Height = 44;
            this.dtg_Karfarma.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtg_Karfarma.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_Karfarma.Size = new System.Drawing.Size(1180, 463);
            this.dtg_Karfarma.TabIndex = 91;
            this.dtg_Karfarma.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellClick);
            this.dtg_Karfarma.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellContentClick);
            this.dtg_Karfarma.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellContentDoubleClick);
            this.dtg_Karfarma.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Karfarma_CellDoubleClick);
            this.dtg_Karfarma.SelectionChanged += new System.EventHandler(this.dtg_Karfarma_SelectionChanged);
            this.dtg_Karfarma.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Karfarma_KeyDown);
            // 
            // pnl_filter
            // 
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
            // 
            // btn_Filter
            // 
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.Enabled = false;
            this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.Black;
            this.btn_Filter.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filter.Image")));
            this.btn_Filter.Location = new System.Drawing.Point(1139, 1);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(40, 42);
            this.btn_Filter.TabIndex = 93;
            this.ToolTip1.SetToolTip(this.btn_Filter, "فیلتر");
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            // 
            // Label10
            // 
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Location = new System.Drawing.Point(1580, -23);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(49, 43);
            this.Label10.TabIndex = 154;
            this.Label10.Text = "ردیف";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(18, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1161, 22);
            this.PictureBox1.TabIndex = 155;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // txt_KarfarmaTelFltr
            // 
            this.txt_KarfarmaTelFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaTelFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaTelFltr.Location = new System.Drawing.Point(18, 23);
            this.txt_KarfarmaTelFltr.Name = "txt_KarfarmaTelFltr";
            this.txt_KarfarmaTelFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaTelFltr.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaTelFltr.TabIndex = 86;
            this.txt_KarfarmaTelFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaTelFltr_KeyDown);
            // 
            // txt_KarfarmaAddressFltr
            // 
            this.txt_KarfarmaAddressFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaAddressFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaAddressFltr.Location = new System.Drawing.Point(118, 23);
            this.txt_KarfarmaAddressFltr.Name = "txt_KarfarmaAddressFltr";
            this.txt_KarfarmaAddressFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaAddressFltr.Size = new System.Drawing.Size(210, 20);
            this.txt_KarfarmaAddressFltr.TabIndex = 85;
            this.txt_KarfarmaAddressFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaAddressFltr_KeyDown);
            // 
            // txt_KarfarmaPostiCodeFltr
            // 
            this.txt_KarfarmaPostiCodeFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaPostiCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaPostiCodeFltr.Location = new System.Drawing.Point(328, 23);
            this.txt_KarfarmaPostiCodeFltr.Name = "txt_KarfarmaPostiCodeFltr";
            this.txt_KarfarmaPostiCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaPostiCodeFltr.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaPostiCodeFltr.TabIndex = 84;
            this.txt_KarfarmaPostiCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaPostiCodeFltr_KeyDown);
            // 
            // txt_KarfarmaCodeFltr
            // 
            this.txt_KarfarmaCodeFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaCodeFltr.Location = new System.Drawing.Point(1038, 23);
            this.txt_KarfarmaCodeFltr.Name = "txt_KarfarmaCodeFltr";
            this.txt_KarfarmaCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaCodeFltr.Size = new System.Drawing.Size(52, 20);
            this.txt_KarfarmaCodeFltr.TabIndex = 78;
            this.txt_KarfarmaCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaCodeFltr_KeyDown);
            // 
            // cmbo_KarfarmaShahrFltr
            // 
            this.cmbo_KarfarmaShahrFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbo_KarfarmaShahrFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_KarfarmaShahrFltr.FormattingEnabled = true;
            this.cmbo_KarfarmaShahrFltr.Location = new System.Drawing.Point(628, 23);
            this.cmbo_KarfarmaShahrFltr.Name = "cmbo_KarfarmaShahrFltr";
            this.cmbo_KarfarmaShahrFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_KarfarmaShahrFltr.Size = new System.Drawing.Size(100, 21);
            this.cmbo_KarfarmaShahrFltr.TabIndex = 81;
            this.cmbo_KarfarmaShahrFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_KarfarmaShahrFltr_SelectedIndexChanged);
            this.cmbo_KarfarmaShahrFltr.TextChanged += new System.EventHandler(this.cmbo_KarfarmashahrFltr_TextChanged);
            // 
            // txt_KarfarmaNameFltr
            // 
            this.txt_KarfarmaNameFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaNameFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaNameFltr.Location = new System.Drawing.Point(828, 23);
            this.txt_KarfarmaNameFltr.Name = "txt_KarfarmaNameFltr";
            this.txt_KarfarmaNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaNameFltr.Size = new System.Drawing.Size(210, 20);
            this.txt_KarfarmaNameFltr.TabIndex = 79;
            this.txt_KarfarmaNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaNameFltr_KeyDown);
            // 
            // cmbo_KarfarmaOstanFltr
            // 
            this.cmbo_KarfarmaOstanFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cmbo_KarfarmaOstanFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_KarfarmaOstanFltr.FormattingEnabled = true;
            this.cmbo_KarfarmaOstanFltr.Location = new System.Drawing.Point(728, 23);
            this.cmbo_KarfarmaOstanFltr.Name = "cmbo_KarfarmaOstanFltr";
            this.cmbo_KarfarmaOstanFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_KarfarmaOstanFltr.Size = new System.Drawing.Size(100, 21);
            this.cmbo_KarfarmaOstanFltr.TabIndex = 80;
            this.cmbo_KarfarmaOstanFltr.TextChanged += new System.EventHandler(this.cmbo_KarfarmaOstanFltr_TextChanged);
            // 
            // txt_KarfarmaMelliCodelFltr
            // 
            this.txt_KarfarmaMelliCodelFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaMelliCodelFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaMelliCodelFltr.Location = new System.Drawing.Point(428, 23);
            this.txt_KarfarmaMelliCodelFltr.Name = "txt_KarfarmaMelliCodelFltr";
            this.txt_KarfarmaMelliCodelFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaMelliCodelFltr.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaMelliCodelFltr.TabIndex = 83;
            this.txt_KarfarmaMelliCodelFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaMelliCodelFltr_KeyDown);
            // 
            // txt_KarfarmaEghtesadiCodeFltr
            // 
            this.txt_KarfarmaEghtesadiCodeFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_KarfarmaEghtesadiCodeFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_KarfarmaEghtesadiCodeFltr.Location = new System.Drawing.Point(528, 23);
            this.txt_KarfarmaEghtesadiCodeFltr.Name = "txt_KarfarmaEghtesadiCodeFltr";
            this.txt_KarfarmaEghtesadiCodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_KarfarmaEghtesadiCodeFltr.Size = new System.Drawing.Size(100, 20);
            this.txt_KarfarmaEghtesadiCodeFltr.TabIndex = 82;
            this.txt_KarfarmaEghtesadiCodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_KarfarmaEghtesadiCodeFltr_KeyDown);
            // 
            // Frm_Karfarma_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(1190, 581);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_filter);
            this.Controls.Add(this.pnl_Karfarma);
            this.Controls.Add(this.dtg_Karfarma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Karfarma_New";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "لیست کارفرماها";
            this.pnl_Karfarma.ResumeLayout(false);
            this.pnl_Karfarma.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Karfarma)).EndInit();
            this.pnl_filter.ResumeLayout(false);
            this.pnl_filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
    }
}