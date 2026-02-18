using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_Fehrest_New
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
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_copy;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_FehrestMabna;
        private System.Windows.Forms.ComboBox cmbo_FehrestMabnaFltr;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_Fehrest;

        // Label
        private System.Windows.Forms.Label Label36;
        private System.Windows.Forms.Label Label40;
        private System.Windows.Forms.Label Label42;

        // Panel
        private System.Windows.Forms.Panel pnl_Fehrest;
        private System.Windows.Forms.Panel pnl_FehrestFilter;

        // TextBox
        private System.Windows.Forms.TextBox txt_FehrestFile;
        private System.Windows.Forms.TextBox txt_FehrestFileFltr;
        private System.Windows.Forms.TextBox txt_FehrestName;
        private System.Windows.Forms.TextBox txt_FehrestNameFltr;

        private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_Fehrest));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
			this.pnl_FehrestFilter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.cmbo_FehrestMabnaFltr = new System.Windows.Forms.ComboBox();
			this.txt_FehrestNameFltr = new System.Windows.Forms.TextBox();
			this.txt_FehrestFileFltr = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.dtg_Fehrest = new System.Windows.Forms.DataGridView();
			this.pnl_Fehrest = new System.Windows.Forms.Panel();
			this.btn_Open = new System.Windows.Forms.Button();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.btn_copy = new System.Windows.Forms.Button();
			this.txt_FehrestFile = new System.Windows.Forms.TextBox();
			this.cmbo_FehrestMabna = new System.Windows.Forms.ComboBox();
			this.Label42 = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Label36 = new System.Windows.Forms.Label();
			this.Label40 = new System.Windows.Forms.Label();
			this.txt_FehrestName = new System.Windows.Forms.TextBox();
			this.pnl_FehrestFilter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Fehrest).BeginInit();
			this.pnl_Fehrest.SuspendLayout();
			base.SuspendLayout();
			this.pnl_FehrestFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_FehrestFilter.Controls.Add(this.btn_Filter);
			this.pnl_FehrestFilter.Controls.Add(this.cmbo_FehrestMabnaFltr);
			this.pnl_FehrestFilter.Controls.Add(this.txt_FehrestNameFltr);
			this.pnl_FehrestFilter.Controls.Add(this.txt_FehrestFileFltr);
			this.pnl_FehrestFilter.Controls.Add(this.Button7);
			this.pnl_FehrestFilter.Location = new System.Drawing.Point(19, 21);
			this.pnl_FehrestFilter.Name = "pnl_FehrestFilter";
			this.pnl_FehrestFilter.Size = new System.Drawing.Size(677, 26);
			this.pnl_FehrestFilter.TabIndex = 92;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(584, 0);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(95, 29);
			this.btn_Filter.TabIndex = 77;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.cmbo_FehrestMabnaFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestMabnaFltr.FormattingEnabled = true;
			this.cmbo_FehrestMabnaFltr.Location = new System.Drawing.Point(16, 2);
			this.cmbo_FehrestMabnaFltr.Name = "cmbo_FehrestMabnaFltr";
			this.cmbo_FehrestMabnaFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestMabnaFltr.Size = new System.Drawing.Size(69, 26);
			this.cmbo_FehrestMabnaFltr.TabIndex = 75;
			this.txt_FehrestNameFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FehrestNameFltr.Location = new System.Drawing.Point(86, 2);
			this.txt_FehrestNameFltr.Name = "txt_FehrestNameFltr";
			this.txt_FehrestNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FehrestNameFltr.Size = new System.Drawing.Size(349, 26);
			this.txt_FehrestNameFltr.TabIndex = 74;
			this.txt_FehrestFileFltr.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FehrestFileFltr.Location = new System.Drawing.Point(436, 2);
			this.txt_FehrestFileFltr.Name = "txt_FehrestFileFltr";
			this.txt_FehrestFileFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FehrestFileFltr.Size = new System.Drawing.Size(149, 26);
			this.txt_FehrestFileFltr.TabIndex = 73;
			this.Button7.BackColor = System.Drawing.Color.LightGray;
			this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button7.ForeColor = System.Drawing.Color.Black;
			this.Button7.Location = new System.Drawing.Point(1506, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(89, 21);
			this.Button7.TabIndex = 44;
			this.Button7.Text = "حذف فیلتر";
			this.Button7.UseVisualStyleBackColor = false;
			this.dtg_Fehrest.AllowUserToAddRows = false;
			this.dtg_Fehrest.AllowUserToDeleteRows = false;
			this.dtg_Fehrest.AllowUserToOrderColumns = true;
			this.dtg_Fehrest.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Fehrest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dtg_Fehrest.DefaultCellStyle = dataGridViewCellStyle;
			this.dtg_Fehrest.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Fehrest.Location = new System.Drawing.Point(19, 48);
			this.dtg_Fehrest.Name = "dtg_Fehrest";
			this.dtg_Fehrest.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Fehrest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Fehrest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Fehrest.Size = new System.Drawing.Size(680, 360);
			this.dtg_Fehrest.TabIndex = 91;
			this.pnl_Fehrest.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.pnl_Fehrest.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Fehrest.Controls.Add(this.btn_Open);
			this.pnl_Fehrest.Controls.Add(this.btn_Exit);
			this.pnl_Fehrest.Controls.Add(this.btn_Delete);
			this.pnl_Fehrest.Controls.Add(this.btn_copy);
			this.pnl_Fehrest.Controls.Add(this.txt_FehrestFile);
			this.pnl_Fehrest.Controls.Add(this.cmbo_FehrestMabna);
			this.pnl_Fehrest.Controls.Add(this.Label42);
			this.pnl_Fehrest.Controls.Add(this.Btn_Save);
			this.pnl_Fehrest.Controls.Add(this.Label36);
			this.pnl_Fehrest.Controls.Add(this.Label40);
			this.pnl_Fehrest.Controls.Add(this.txt_FehrestName);
			this.pnl_Fehrest.Location = new System.Drawing.Point(20, 412);
			this.pnl_Fehrest.Name = "pnl_Fehrest";
			this.pnl_Fehrest.Size = new System.Drawing.Size(679, 99);
			this.pnl_Fehrest.TabIndex = 89;
			this.btn_Open.Location = new System.Drawing.Point(430, 63);
			this.btn_Open.Name = "btn_Open";
			this.btn_Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Open.Size = new System.Drawing.Size(81, 23);
			this.btn_Open.TabIndex = 5;
			this.btn_Open.Text = "(DblClk) نمایش";
			this.btn_Open.UseVisualStyleBackColor = true;
			this.btn_Exit.Location = new System.Drawing.Point(18, 63);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Exit.Size = new System.Drawing.Size(78, 23);
			this.btn_Exit.TabIndex = 8;
			this.btn_Exit.Text = " خروج ";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.btn_Delete.Location = new System.Drawing.Point(146, 63);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(78, 23);
			this.btn_Delete.TabIndex = 7;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.btn_copy.Location = new System.Drawing.Point(290, 63);
			this.btn_copy.Name = "btn_copy";
			this.btn_copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_copy.Size = new System.Drawing.Size(78, 23);
			this.btn_copy.TabIndex = 6;
			this.btn_copy.Text = "(Clt+C) کپی";
			this.btn_copy.UseVisualStyleBackColor = true;
			this.txt_FehrestFile.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FehrestFile.Location = new System.Drawing.Point(545, 22);
			this.txt_FehrestFile.Name = "txt_FehrestFile";
			this.txt_FehrestFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FehrestFile.Size = new System.Drawing.Size(106, 26);
			this.txt_FehrestFile.TabIndex = 1;
			this.cmbo_FehrestMabna.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_FehrestMabna.FormattingEnabled = true;
			this.cmbo_FehrestMabna.Location = new System.Drawing.Point(18, 22);
			this.cmbo_FehrestMabna.Name = "cmbo_FehrestMabna";
			this.cmbo_FehrestMabna.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestMabna.Size = new System.Drawing.Size(70, 26);
			this.cmbo_FehrestMabna.TabIndex = 3;
			this.Label42.AutoSize = true;
			this.Label42.Location = new System.Drawing.Point(39, 6);
			this.Label42.Name = "Label42";
			this.Label42.Size = new System.Drawing.Size(24, 13);
			this.Label42.TabIndex = 90;
			this.Label42.Text = "پایه";
			this.Btn_Save.Location = new System.Drawing.Point(566, 63);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Save.Size = new System.Drawing.Size(87, 23);
			this.Btn_Save.TabIndex = 4;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Label36.AutoSize = true;
			this.Label36.Location = new System.Drawing.Point(297, 6);
			this.Label36.Name = "Label36";
			this.Label36.Size = new System.Drawing.Size(80, 13);
			this.Label36.TabIndex = 95;
			this.Label36.Text = " نام فهرست بها ";
			this.Label40.AutoSize = true;
			this.Label40.Location = new System.Drawing.Point(559, 6);
			this.Label40.Name = "Label40";
			this.Label40.Size = new System.Drawing.Size(82, 13);
			this.Label40.TabIndex = 92;
			this.Label40.Text = "فایل فهرست بها";
			this.txt_FehrestName.Font = new System.Drawing.Font("B Yekan", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_FehrestName.Location = new System.Drawing.Point(117, 22);
			this.txt_FehrestName.Name = "txt_FehrestName";
			this.txt_FehrestName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_FehrestName.Size = new System.Drawing.Size(401, 26);
			this.txt_FehrestName.TabIndex = 2;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			base.ClientSize = new System.Drawing.Size(722, 535);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_FehrestFilter);
			base.Controls.Add(this.dtg_Fehrest);
			base.Controls.Add(this.pnl_Fehrest);
			base.Name = "Frm_Fehrest";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "فهارس بها";
			this.pnl_FehrestFilter.ResumeLayout(false);
			this.pnl_FehrestFilter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Fehrest).EndInit();
			this.pnl_Fehrest.ResumeLayout(false);
			this.pnl_Fehrest.PerformLayout();
			base.ResumeLayout(false);

            this.cmbo_FehrestMabnaFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbo_FehrestMabnaFltr_KeyDown);
            this.txt_FehrestNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FehrestNameFltr_KeyDown);
            this.txt_FehrestFileFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_FehrestFileFltr_KeyDown);
            this.dtg_Fehrest.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Fehrest_CellClick);
            this.dtg_Fehrest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Fehrest_CellContentClick);
            this.dtg_Fehrest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Fehrest_CellDoubleClick);
            this.dtg_Fehrest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Fehrest_KeyDown);
            this.dtg_Fehrest.SelectionChanged += new System.EventHandler(this.dtg_Fehrest_SelectionChanged);
            this.cmbo_FehrestMabna.GotFocus += new System.EventHandler(this.cmbo_FehrestMabna_GotFocus);
            this.cmbo_FehrestMabna.SelectedIndexChanged += new System.EventHandler(this.cmbo_FehrestMabna_SelectedIndexChanged);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.txt_FehrestName.GotFocus += new System.EventHandler(this.txt_FehrestName_GotFocus);
            this.txt_FehrestName.TextChanged += new System.EventHandler(this.txt_FehrestName_TextChanged);
            this.txt_FehrestFile.GotFocus += new System.EventHandler(this.txt_FehrestFile_GotFocus);
            this.txt_FehrestFile.TextChanged += new System.EventHandler(this.txt_FehrestFile_TextChanged);
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click_1);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
        }
    }
}
