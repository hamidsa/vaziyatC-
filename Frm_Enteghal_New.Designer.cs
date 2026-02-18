using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_Enteghal_New
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
        private System.Windows.Forms.Button btn_Cansel;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_ImportSelect;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_FehrestFltr;
        private System.Windows.Forms.ComboBox cmbo_NoaSanadFltr;
        private System.Windows.Forms.ComboBox cmbo_SalMaliFltr;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_AsnadList;

        // Label
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label26;
        private System.Windows.Forms.Label Label28;
        private System.Windows.Forms.Label lbl_AsnadNum;
        private System.Windows.Forms.Label lbl_AsnadSum;

        // Panel
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.Panel pnl_Filter;

        // PictureBox
        private System.Windows.Forms.PictureBox PictureBox1;

        // TextBox
        private System.Windows.Forms.TextBox txt_AmaliatFltr;
        private System.Windows.Forms.TextBox txt_BahaFltr;
        private System.Windows.Forms.TextBox txt_CommentFltr;
        private System.Windows.Forms.TextBox txt_JobNoFltr;
        private System.Windows.Forms.TextBox txt_KarfarmaFltr;
        private System.Windows.Forms.TextBox txt_ProjectFltr;
        private System.Windows.Forms.TextBox txt_SanadDateFltr;
        private System.Windows.Forms.TextBox txt_SanadNoFltr;

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
    }
}
