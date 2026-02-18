using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class frm_AsnadOnvan_New
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
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cmbo_OnvanMabna;
        private System.Windows.Forms.ComboBox cmbo_OnvanMabnaFltr;
        private System.Windows.Forms.DataGridView dtg_Onvan;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel pnl_Filter;
        private System.Windows.Forms.Panel pnl_Onvan;
        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.PictureBox PictureBox2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer2;
        private System.Windows.Forms.TextBox txt_ArzeshAfzoode;
        private System.Windows.Forms.TextBox txt_ArzeshAfzoodeFltr;
        private System.Windows.Forms.TextBox txt_AvarezShahrdari;
        private System.Windows.Forms.TextBox txt_AvarezShahrdariFltr;
        private System.Windows.Forms.TextBox txt_CodeEghtesadi;
        private System.Windows.Forms.TextBox txt_CodeEghtesadiFltr;
        private System.Windows.Forms.TextBox txt_EsmRamzCode;
        private System.Windows.Forms.TextBox txt_EsmRamzFltr;
        private System.Windows.Forms.TextBox txt_OnvanFactorFltr;
        private System.Windows.Forms.TextBox txt_OnvanSanad;
        private System.Windows.Forms.TextBox txt_SahebEmza;
        private System.Windows.Forms.TextBox txt_SahebEmzaFltr;
        private System.Windows.Forms.TextBox txt_Semat;
        private System.Windows.Forms.TextBox txt_SematFltr;
        private System.Windows.Forms.TextBox txt_ShName;
        private System.Windows.Forms.TextBox txt_ShNameFltr;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AsnadOnvan_New));
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

            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Onvan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            this.pnl_Onvan.SuspendLayout();
            this.pnl_Filter.SuspendLayout();
            this.SuspendLayout();

            // pnl_Filter
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

            // btn_Filter
            this.btn_Filter.BackColor = System.Drawing.Color.White;
            this.btn_Filter.Enabled = false;
            this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Filter.ForeColor = System.Drawing.Color.Black;
            this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
            this.btn_Filter.Location = new System.Drawing.Point(1140, 0);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(38, 58);
            this.btn_Filter.TabIndex = 97;
            this.btn_Filter.UseVisualStyleBackColor = false;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);

            // Label10
            this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label10.BackColor = System.Drawing.Color.White;
            this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label10.Location = new System.Drawing.Point(1087, -1);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(55, 60);
            this.Label10.TabIndex = 156;
            this.Label10.Text = "ردیف";
            this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // PictureBox1
            this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
            this.PictureBox1.InitialImage = (System.Drawing.Image)resources.GetObject("PictureBox1.InitialImage");
            this.PictureBox1.Location = new System.Drawing.Point(2, 1);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(1174, 32);
            this.PictureBox1.TabIndex = 161;
            this.PictureBox1.TabStop = false;

            // cmbo_OnvanMabnaFltr
            this.cmbo_OnvanMabnaFltr.AllowDrop = true;
            this.cmbo_OnvanMabnaFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.cmbo_OnvanMabnaFltr.ForeColor = System.Drawing.Color.Red;
            this.cmbo_OnvanMabnaFltr.FormattingEnabled = true;
            this.cmbo_OnvanMabnaFltr.Location = new System.Drawing.Point(2, 35);
            this.cmbo_OnvanMabnaFltr.Name = "cmbo_OnvanMabnaFltr";
            this.cmbo_OnvanMabnaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_OnvanMabnaFltr.Size = new System.Drawing.Size(44, 26);
            this.cmbo_OnvanMabnaFltr.TabIndex = 23;
            this.cmbo_OnvanMabnaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_OnvanMabnaFltr_KeyDown);

            // txt_SematFltr
            this.txt_SematFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_SematFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_SematFltr.Location = new System.Drawing.Point(47, 35);
            this.txt_SematFltr.Name = "txt_SematFltr";
            this.txt_SematFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SematFltr.Size = new System.Drawing.Size(148, 26);
            this.txt_SematFltr.TabIndex = 22;
            this.txt_SematFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SematFltr_KeyDown);

            // txt_SahebEmzaFltr
            this.txt_SahebEmzaFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_SahebEmzaFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_SahebEmzaFltr.Location = new System.Drawing.Point(196, 35);
            this.txt_SahebEmzaFltr.Name = "txt_SahebEmzaFltr";
            this.txt_SahebEmzaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SahebEmzaFltr.Size = new System.Drawing.Size(148, 26);
            this.txt_SahebEmzaFltr.TabIndex = 21;
            this.txt_SahebEmzaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_SahebEmzaFltr_KeyDown);

            // txt_OnvanFactorFltr
            this.txt_OnvanFactorFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_OnvanFactorFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_OnvanFactorFltr.Location = new System.Drawing.Point(345, 35);
            this.txt_OnvanFactorFltr.Name = "txt_OnvanFactorFltr";
            this.txt_OnvanFactorFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_OnvanFactorFltr.Size = new System.Drawing.Size(230, 26);
            this.txt_OnvanFactorFltr.TabIndex = 20;
            this.txt_OnvanFactorFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_OnvanFactorFltr_KeyDown);

            // txt_CodeEghtesadiFltr
            this.txt_CodeEghtesadiFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_CodeEghtesadiFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_CodeEghtesadiFltr.Location = new System.Drawing.Point(675, 35);
            this.txt_CodeEghtesadiFltr.Name = "txt_CodeEghtesadiFltr";
            this.txt_CodeEghtesadiFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeEghtesadiFltr.Size = new System.Drawing.Size(120, 26);
            this.txt_CodeEghtesadiFltr.TabIndex = 17;
            this.txt_CodeEghtesadiFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_CodeEghtesadiFltr_KeyDown);

            // txt_ShNameFltr
            this.txt_ShNameFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_ShNameFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ShNameFltr.Location = new System.Drawing.Point(796, 35);
            this.txt_ShNameFltr.Name = "txt_ShNameFltr";
            this.txt_ShNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ShNameFltr.Size = new System.Drawing.Size(228, 26);
            this.txt_ShNameFltr.TabIndex = 16;
            this.txt_ShNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ShNameFltr_KeyDown);

            // txt_ArzeshAfzoodeFltr
            this.txt_ArzeshAfzoodeFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_ArzeshAfzoodeFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_ArzeshAfzoodeFltr.Location = new System.Drawing.Point(576, 35);
            this.txt_ArzeshAfzoodeFltr.Name = "txt_ArzeshAfzoodeFltr";
            this.txt_ArzeshAfzoodeFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ArzeshAfzoodeFltr.Size = new System.Drawing.Size(49, 26);
            this.txt_ArzeshAfzoodeFltr.TabIndex = 19;
            this.txt_ArzeshAfzoodeFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ArzeshAfzoodeFltr_KeyDown);

            // txt_AvarezShahrdariFltr
            this.txt_AvarezShahrdariFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_AvarezShahrdariFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_AvarezShahrdariFltr.Location = new System.Drawing.Point(626, 35);
            this.txt_AvarezShahrdariFltr.Name = "txt_AvarezShahrdariFltr";
            this.txt_AvarezShahrdariFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_AvarezShahrdariFltr.Size = new System.Drawing.Size(48, 26);
            this.txt_AvarezShahrdariFltr.TabIndex = 18;
            this.txt_AvarezShahrdariFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_AvarezShahrdariFltr_KeyDown);

            // txt_EsmRamzFltr
            this.txt_EsmRamzFltr.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_EsmRamzFltr.ForeColor = System.Drawing.Color.Red;
            this.txt_EsmRamzFltr.Location = new System.Drawing.Point(1025, 35);
            this.txt_EsmRamzFltr.Name = "txt_EsmRamzFltr";
            this.txt_EsmRamzFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_EsmRamzFltr.Size = new System.Drawing.Size(61, 26);
            this.txt_EsmRamzFltr.TabIndex = 15;
            this.txt_EsmRamzFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_EsmRamzFltr_KeyDown);

            // Button7
            this.Button7.BackColor = System.Drawing.Color.LightGray;
            this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button7.ForeColor = System.Drawing.Color.Black;
            this.Button7.Location = new System.Drawing.Point(1506, 7);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(89, 21);
            this.Button7.TabIndex = 44;
            this.Button7.Text = "حذف فیلتر";
            this.Button7.UseVisualStyleBackColor = false;

            // dtg_Onvan
            this.dtg_Onvan.AllowUserToAddRows = false;
            this.dtg_Onvan.AllowUserToDeleteRows = false;
            this.dtg_Onvan.AllowUserToOrderColumns = true;
            this.dtg_Onvan.BackgroundColor = System.Drawing.Color.Beige;
            this.dtg_Onvan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9F);
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
            this.dtg_Onvan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Onvan_CellClick);
            this.dtg_Onvan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Onvan_CellContentClick);
            this.dtg_Onvan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Onvan_KeyDown);
            this.dtg_Onvan.SelectionChanged += new System.EventHandler(this.dtg_Onvan_SelectionChanged);

            // btn_Exit
            this.btn_Exit.Location = new System.Drawing.Point(947, 506);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Exit.Size = new System.Drawing.Size(79, 23);
            this.btn_Exit.TabIndex = 14;
            this.btn_Exit.Text = "(Esc) خروج ";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);

            // btn_Copy
            this.btn_Copy.Location = new System.Drawing.Point(584, 506);
            this.btn_Copy.Name = "btn_Copy";
            this.btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Copy.Size = new System.Drawing.Size(79, 23);
            this.btn_Copy.TabIndex = 12;
            this.btn_Copy.Text = "(Ctrl + C) کپی ";
            this.btn_Copy.UseVisualStyleBackColor = true;
            this.btn_Copy.Visible = false;
            this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);

            // btn_Insert
            this.btn_Insert.Location = new System.Drawing.Point(403, 506);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Insert.Size = new System.Drawing.Size(79, 23);
            this.btn_Insert.TabIndex = 11;
            this.btn_Insert.Text = "(Insert) جدید  ";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Visible = false;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);

            // btn_Delete
            this.btn_Delete.Location = new System.Drawing.Point(777, 506);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Delete.Size = new System.Drawing.Size(79, 23);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "(Del) حذف";
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Visible = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);

            // btn_Save
            this.btn_Save.Location = new System.Drawing.Point(243, 506);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Save.Size = new System.Drawing.Size(79, 23);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "(F2) ذخیره ";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);

            // RectangleShape2
            this.RectangleShape2.Location = new System.Drawing.Point(119, 221);
            this.RectangleShape2.Name = "RectangleShape2";
            this.RectangleShape2.Size = new System.Drawing.Size(16, 54);

            // ShapeContainer2
            this.ShapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.ShapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.ShapeContainer2.Name = "ShapeContainer2";
            this.ShapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
                this.RectangleShape2
            });
            this.ShapeContainer2.Size = new System.Drawing.Size(1194, 545);
            this.ShapeContainer2.TabIndex = 96;
            this.ShapeContainer2.TabStop = false;

            // pnl_Onvan
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

            // PictureBox2
            this.PictureBox2.Image = (System.Drawing.Image)resources.GetObject("PictureBox2.Image");
            this.PictureBox2.InitialImage = (System.Drawing.Image)resources.GetObject("PictureBox2.InitialImage");
            this.PictureBox2.Location = new System.Drawing.Point(0, 1);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(1082, 32);
            this.PictureBox2.TabIndex = 162;
            this.PictureBox2.TabStop = false;

            // cmbo_OnvanMabna
            this.cmbo_OnvanMabna.AllowDrop = true;
            this.cmbo_OnvanMabna.Font = new System.Drawing.Font("B Yekan", 9F);
            this.cmbo_OnvanMabna.FormattingEnabled = true;
            this.cmbo_OnvanMabna.Location = new System.Drawing.Point(0, 35);
            this.cmbo_OnvanMabna.Name = "cmbo_OnvanMabna";
            this.cmbo_OnvanMabna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbo_OnvanMabna.Size = new System.Drawing.Size(43, 26);
            this.cmbo_OnvanMabna.TabIndex = 9;
            this.cmbo_OnvanMabna.GotFocus += new System.EventHandler(this.cmbo_OnvanMabna_GotFocus);
            this.cmbo_OnvanMabna.SelectedIndexChanged += new System.EventHandler(this.cmbo_OnvanMabna_SelectedIndexChanged);
            this.cmbo_OnvanMabna.TextChanged += new System.EventHandler(this.cmbo_OnvanMabna_TextChanged);

            // txt_Semat
            this.txt_Semat.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_Semat.Location = new System.Drawing.Point(44, 35);
            this.txt_Semat.Name = "txt_Semat";
            this.txt_Semat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Semat.Size = new System.Drawing.Size(148, 26);
            this.txt_Semat.TabIndex = 8;
            this.txt_Semat.GotFocus += new System.EventHandler(this.txt_Semat_GotFocus);
            this.txt_Semat.TextChanged += new System.EventHandler(this.txt_Semat_TextChanged);

            // txt_SahebEmza
            this.txt_SahebEmza.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_SahebEmza.Location = new System.Drawing.Point(193, 35);
            this.txt_SahebEmza.Name = "txt_SahebEmza";
            this.txt_SahebEmza.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_SahebEmza.Size = new System.Drawing.Size(149, 26);
            this.txt_SahebEmza.TabIndex = 7;
            this.txt_SahebEmza.GotFocus += new System.EventHandler(this.txt_SahebEmza_GotFocus);
            this.txt_SahebEmza.TextChanged += new System.EventHandler(this.txt_SahebEmza_TextChanged);

            // txt_OnvanSanad
            this.txt_OnvanSanad.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_OnvanSanad.Location = new System.Drawing.Point(343, 35);
            this.txt_OnvanSanad.Name = "txt_OnvanSanad";
            this.txt_OnvanSanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_OnvanSanad.Size = new System.Drawing.Size(230, 26);
            this.txt_OnvanSanad.TabIndex = 6;
            this.txt_OnvanSanad.GotFocus += new System.EventHandler(this.txt_OnvanSanad_GotFocus);
            this.txt_OnvanSanad.TextChanged += new System.EventHandler(this.txt_OnvanFactor_TextChanged);

            // txt_CodeEghtesadi
            this.txt_CodeEghtesadi.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_CodeEghtesadi.Location = new System.Drawing.Point(672, 35);
            this.txt_CodeEghtesadi.Name = "txt_CodeEghtesadi";
            this.txt_CodeEghtesadi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_CodeEghtesadi.Size = new System.Drawing.Size(121, 26);
            this.txt_CodeEghtesadi.TabIndex = 3;
            this.txt_CodeEghtesadi.GotFocus += new System.EventHandler(this.txt_CodeEghtesadi_GotFocus);
            this.txt_CodeEghtesadi.TextChanged += new System.EventHandler(this.txt_EghtesadiCode_TextChanged);

            // txt_ShName
            this.txt_ShName.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_ShName.Location = new System.Drawing.Point(794, 35);
            this.txt_ShName.Name = "txt_ShName";
            this.txt_ShName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ShName.Size = new System.Drawing.Size(227, 26);
            this.txt_ShName.TabIndex = 2;
            this.txt_ShName.GotFocus += new System.EventHandler(this.txt_ShName_GotFocus);
            this.txt_ShName.TextChanged += new System.EventHandler(this.txt_ShName_TextChanged);

            // txt_ArzeshAfzoode
            this.txt_ArzeshAfzoode.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_ArzeshAfzoode.Location = new System.Drawing.Point(574, 35);
            this.txt_ArzeshAfzoode.Name = "txt_ArzeshAfzoode";
            this.txt_ArzeshAfzoode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_ArzeshAfzoode.Size = new System.Drawing.Size(48, 26);
            this.txt_ArzeshAfzoode.TabIndex = 5;
            this.txt_ArzeshAfzoode.GotFocus += new System.EventHandler(this.txt_ArzeshAfzoode_GotFocus);
            this.txt_ArzeshAfzoode.TextChanged += new System.EventHandler(this.txt_ArzeshAfzoode_TextChanged);

            // txt_AvarezShahrdari
            this.txt_AvarezShahrdari.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_AvarezShahrdari.Location = new System.Drawing.Point(623, 35);
            this.txt_AvarezShahrdari.Name = "txt_AvarezShahrdari";
            this.txt_AvarezShahrdari.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_AvarezShahrdari.Size = new System.Drawing.Size(48, 26);
            this.txt_AvarezShahrdari.TabIndex = 4;
            this.txt_AvarezShahrdari.TextChanged += new System.EventHandler(this.txt_AvarezShahrdari_TextChanged);

            // txt_EsmRamzCode
            this.txt_EsmRamzCode.Font = new System.Drawing.Font("B Yekan", 9F);
            this.txt_EsmRamzCode.Location = new System.Drawing.Point(1022, 35);
            this.txt_EsmRamzCode.Name = "txt_EsmRamzCode";
            this.txt_EsmRamzCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_EsmRamzCode.Size = new System.Drawing.Size(59, 26);
            this.txt_EsmRamzCode.TabIndex = 1;
            this.txt_EsmRamzCode.GotFocus += new System.EventHandler(this.txt_EsmRamzCode_GotFocus);
            this.txt_EsmRamzCode.TextChanged += new System.EventHandler(this.txt_EsmRamz_TextChanged);

            // Button2
            this.Button2.BackColor = System.Drawing.Color.LightGray;
            this.Button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold);
            this.Button2.ForeColor = System.Drawing.Color.Black;
            this.Button2.Location = new System.Drawing.Point(1506, 7);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(89, 21);
            this.Button2.TabIndex = 44;
            this.Button2.Text = "حذف فیلتر";
            this.Button2.UseVisualStyleBackColor = false;

            // frm_AsnadOnvan_New
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1194, 545);
            this.ControlBox = false;
            this.Controls.Add(this.pnl_Onvan);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.btn_Copy);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.pnl_Filter);
            this.Controls.Add(this.dtg_Onvan);
            this.Controls.Add(this.ShapeContainer2);
            this.Name = "frm_AsnadOnvan_New";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عناوین ثابت اسناد";

            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Onvan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            this.pnl_Onvan.ResumeLayout(false);
            this.pnl_Onvan.PerformLayout();
            this.pnl_Filter.ResumeLayout(false);
            this.pnl_Filter.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}