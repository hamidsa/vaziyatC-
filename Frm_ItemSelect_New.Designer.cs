using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_ItemSelect_New
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
        private System.Windows.Forms.Button btn_DelSelect;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_ImportSelect;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_FehrestItem;
        private System.Windows.Forms.ComboBox cmbo_GroupFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemFaslFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemNoaFltr;
        private System.Windows.Forms.ComboBox cmbo_ItemVahedSharhFltr;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_Item;

        // Label
        private System.Windows.Forms.Label Label10;

        // Panel
        private System.Windows.Forms.Panel pnl_Filter;

        // PictureBox
        private System.Windows.Forms.PictureBox PictureBox1;

        // TextBox
        private System.Windows.Forms.TextBox txt_ItemBahavahedFltr;
        private System.Windows.Forms.TextBox txt_ItemNoFltr;
        private System.Windows.Forms.TextBox txt_ItemSharhFltr;

        private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_ItemSelect));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_Cansel = new System.Windows.Forms.Button();
			this.btn_ImportSelect = new System.Windows.Forms.Button();
			this.btn_DelSelect = new System.Windows.Forms.Button();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.Label10 = new System.Windows.Forms.Label();
			this.cmbo_GroupFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ItemVahedSharhFltr = new System.Windows.Forms.ComboBox();
			this.cmbo_ItemFaslFltr = new System.Windows.Forms.ComboBox();
			this.txt_ItemNoFltr = new System.Windows.Forms.TextBox();
			this.cmbo_ItemNoaFltr = new System.Windows.Forms.ComboBox();
			this.txt_ItemBahavahedFltr = new System.Windows.Forms.TextBox();
			this.txt_ItemSharhFltr = new System.Windows.Forms.TextBox();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_FehrestItem = new System.Windows.Forms.ComboBox();
			this.dtg_Item = new System.Windows.Forms.DataGridView();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).BeginInit();
			base.SuspendLayout();
			this.btn_Cansel.Location = new System.Drawing.Point(934, 479);
			this.btn_Cansel.Name = "btn_Cansel";
			this.btn_Cansel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Cansel.Size = new System.Drawing.Size(125, 30);
			this.btn_Cansel.TabIndex = 143;
			this.btn_Cansel.Text = "انصراف";
			this.btn_Cansel.UseVisualStyleBackColor = true;
			this.btn_ImportSelect.Location = new System.Drawing.Point(156, 479);
			this.btn_ImportSelect.Name = "btn_ImportSelect";
			this.btn_ImportSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_ImportSelect.Size = new System.Drawing.Size(125, 30);
			this.btn_ImportSelect.TabIndex = 141;
			this.btn_ImportSelect.Text = "انتقال انتخاب ها به سند";
			this.btn_ImportSelect.UseVisualStyleBackColor = true;
			this.btn_DelSelect.Location = new System.Drawing.Point(555, 479);
			this.btn_DelSelect.Name = "btn_DelSelect";
			this.btn_DelSelect.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_DelSelect.Size = new System.Drawing.Size(125, 30);
			this.btn_DelSelect.TabIndex = 142;
			this.btn_DelSelect.Text = "حذف انتخاب ها";
			this.btn_DelSelect.UseVisualStyleBackColor = true;
			this.pnl_Filter.BackColor = System.Drawing.Color.White;
			this.pnl_Filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.cmbo_GroupFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemVahedSharhFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemFaslFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemNoFltr);
			this.pnl_Filter.Controls.Add(this.cmbo_ItemNoaFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemBahavahedFltr);
			this.pnl_Filter.Controls.Add(this.txt_ItemSharhFltr);
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Location = new System.Drawing.Point(12, 46);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(1180, 49);
			this.pnl_Filter.TabIndex = 139;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(1078, 4);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(54, 43);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.cmbo_GroupFltr.Font = new System.Drawing.Font("B Yekan", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_GroupFltr.FormattingEnabled = true;
			this.cmbo_GroupFltr.Location = new System.Drawing.Point(0, 26);
			this.cmbo_GroupFltr.Name = "cmbo_GroupFltr";
			this.cmbo_GroupFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_GroupFltr.Size = new System.Drawing.Size(205, 25);
			this.cmbo_GroupFltr.TabIndex = 135;
			this.cmbo_ItemVahedSharhFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemVahedSharhFltr.FormattingEnabled = true;
			this.cmbo_ItemVahedSharhFltr.Location = new System.Drawing.Point(378, 26);
			this.cmbo_ItemVahedSharhFltr.Name = "cmbo_ItemVahedSharhFltr";
			this.cmbo_ItemVahedSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemVahedSharhFltr.Size = new System.Drawing.Size(97, 25);
			this.cmbo_ItemVahedSharhFltr.TabIndex = 77;
			this.cmbo_ItemFaslFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemFaslFltr.FormattingEnabled = true;
			this.cmbo_ItemFaslFltr.Location = new System.Drawing.Point(476, 26);
			this.cmbo_ItemFaslFltr.Name = "cmbo_ItemFaslFltr";
			this.cmbo_ItemFaslFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemFaslFltr.Size = new System.Drawing.Size(41, 25);
			this.cmbo_ItemFaslFltr.TabIndex = 76;
			this.txt_ItemNoFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemNoFltr.Location = new System.Drawing.Point(1017, 26);
			this.txt_ItemNoFltr.Name = "txt_ItemNoFltr";
			this.txt_ItemNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemNoFltr.Size = new System.Drawing.Size(60, 24);
			this.txt_ItemNoFltr.TabIndex = 74;
			this.cmbo_ItemNoaFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.cmbo_ItemNoaFltr.FormattingEnabled = true;
			this.cmbo_ItemNoaFltr.Location = new System.Drawing.Point(206, 26);
			this.cmbo_ItemNoaFltr.Name = "cmbo_ItemNoaFltr";
			this.cmbo_ItemNoaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_ItemNoaFltr.Size = new System.Drawing.Size(99, 25);
			this.cmbo_ItemNoaFltr.TabIndex = 73;
			this.txt_ItemBahavahedFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemBahavahedFltr.Location = new System.Drawing.Point(306, 26);
			this.txt_ItemBahavahedFltr.Name = "txt_ItemBahavahedFltr";
			this.txt_ItemBahavahedFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemBahavahedFltr.Size = new System.Drawing.Size(71, 24);
			this.txt_ItemBahavahedFltr.TabIndex = 54;
			this.txt_ItemSharhFltr.Font = new System.Drawing.Font("B Yekan", 8.25f);
			this.txt_ItemSharhFltr.Location = new System.Drawing.Point(518, 26);
			this.txt_ItemSharhFltr.Name = "txt_ItemSharhFltr";
			this.txt_ItemSharhFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ItemSharhFltr.Size = new System.Drawing.Size(498, 24);
			this.txt_ItemSharhFltr.TabIndex = 50;
			this.btn_Filter.BackColor = System.Drawing.Color.LightGray;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Location = new System.Drawing.Point(1132, 3);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(43, 44);
			this.btn_Filter.TabIndex = 44;
			this.btn_Filter.Text = "حذف فیلتر";
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(16, 3);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(1159, 25);
			this.PictureBox1.TabIndex = 75;
			this.PictureBox1.TabStop = false;
			this.cmbo_FehrestItem.BackColor = System.Drawing.SystemColors.Window;
			this.cmbo_FehrestItem.Font = new System.Drawing.Font("B Titr", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestItem.ForeColor = System.Drawing.Color.Black;
			this.cmbo_FehrestItem.FormattingEnabled = true;
			this.cmbo_FehrestItem.Location = new System.Drawing.Point(204, 6);
			this.cmbo_FehrestItem.Name = "cmbo_FehrestItem";
			this.cmbo_FehrestItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestItem.Size = new System.Drawing.Size(800, 37);
			this.cmbo_FehrestItem.TabIndex = 140;
			this.dtg_Item.AllowUserToAddRows = false;
			this.dtg_Item.AllowUserToDeleteRows = false;
			this.dtg_Item.AllowUserToOrderColumns = true;
			this.dtg_Item.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
			this.dtg_Item.BackgroundColor = System.Drawing.SystemColors.Info;
			this.dtg_Item.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Item.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Item.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Item.GridColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Item.Location = new System.Drawing.Point(12, 73);
			this.dtg_Item.Name = "dtg_Item";
			this.dtg_Item.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Item.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Item.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Item.Size = new System.Drawing.Size(1180, 400);
			this.dtg_Item.TabIndex = 138;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackColor = System.Drawing.SystemColors.Info;
			base.ClientSize = new System.Drawing.Size(1204, 512);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.btn_Cansel);
			base.Controls.Add(this.btn_ImportSelect);
			base.Controls.Add(this.btn_DelSelect);
			base.Controls.Add(this.cmbo_FehrestItem);
			base.Controls.Add(this.dtg_Item);
			base.Name = "Frm_ItemSelect";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتقال ایتم به سند";
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)this.dtg_Item).EndInit();
			base.ResumeLayout(false);
            this.btn_Cansel.Click += new System.EventHandler(this.btn_Cansel_Click);
            this.btn_ImportSelect.Click += new System.EventHandler(this.btn_ImportSelect_Click);
            this.btn_DelSelect.Click += new System.EventHandler(this.btn_DelSelect_Click);
            this.cmbo_GroupFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_GroupFltr_SelectedIndexChanged);
            this.cmbo_GroupFltr.TextChanged += new System.EventHandler(this.cmbo_GroupFltr_TextChanged);
            this.cmbo_GroupFltr.LostFocus += new System.EventHandler(this.cmbo_GroupFltr_LostFocus);
            this.cmbo_GroupFltr.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbo_GroupFltr_MouseClick);
            this.cmbo_ItemVahedSharhFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemVahedSharhFltr_SelectedIndexChanged);
            this.cmbo_ItemFaslFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemFaslFltr_SelectedIndexChanged);
            this.txt_ItemNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemNoFltr_KeyDown);
            this.cmbo_ItemNoaFltr.SelectedIndexChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_SelectedIndexChanged);
            this.cmbo_ItemNoaFltr.TextChanged += new System.EventHandler(this.cmbo_ItemNoaFltr_TextChanged);
            this.txt_ItemBahavahedFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemBahavahedFltr_KeyDown);
            this.txt_ItemSharhFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ItemSharhFltr_KeyDown);
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
            this.cmbo_FehrestItem.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestItem_SelectedIndexChanged);
            this.dtg_Item.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellClick);
            this.dtg_Item.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Item_CellDoubleClick);
            this.dtg_Item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Item_KeyDown);
        }
    }
}
