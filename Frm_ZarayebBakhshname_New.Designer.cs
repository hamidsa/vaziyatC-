using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_ZarayebBakhshname_New
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
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Button btn_Delete;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_Bakhshname;

        // Label
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lbl_RecNo;

        // Panel
        private System.Windows.Forms.Panel pnl_Bakhshname;

        // TextBox
        private System.Windows.Forms.TextBox txt_ZaribCode;
        private System.Windows.Forms.TextBox txt_ZaribCodeComment;

        private void InitializeComponent()
		{
			this.pnl_Bakhshname = new System.Windows.Forms.Panel();
			this.txt_ZaribCode = new System.Windows.Forms.TextBox();
			this.Btn_Insert = new System.Windows.Forms.Button();
			this.Btn_Copy = new System.Windows.Forms.Button();
			this.btn_Delete = new System.Windows.Forms.Button();
			this.Btn_Exit = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.txt_ZaribCodeComment = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.dtg_Bakhshname = new System.Windows.Forms.DataGridView();
			this.lbl_RecNo = new System.Windows.Forms.Label();
			this.pnl_Bakhshname.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Bakhshname).BeginInit();
			base.SuspendLayout();
			this.pnl_Bakhshname.BackColor = System.Drawing.Color.LightCyan;
			this.pnl_Bakhshname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnl_Bakhshname.Controls.Add(this.txt_ZaribCode);
			this.pnl_Bakhshname.Controls.Add(this.Btn_Insert);
			this.pnl_Bakhshname.Controls.Add(this.Btn_Copy);
			this.pnl_Bakhshname.Controls.Add(this.btn_Delete);
			this.pnl_Bakhshname.Controls.Add(this.Btn_Exit);
			this.pnl_Bakhshname.Controls.Add(this.Label1);
			this.pnl_Bakhshname.Controls.Add(this.txt_ZaribCodeComment);
			this.pnl_Bakhshname.Controls.Add(this.Label2);
			this.pnl_Bakhshname.Controls.Add(this.Btn_Save);
			this.pnl_Bakhshname.Controls.Add(this.Label10);
			this.pnl_Bakhshname.Location = new System.Drawing.Point(5, 539);
			this.pnl_Bakhshname.Name = "pnl_Bakhshname";
			this.pnl_Bakhshname.Size = new System.Drawing.Size(815, 92);
			this.pnl_Bakhshname.TabIndex = 101;
			this.txt_ZaribCode.Location = new System.Drawing.Point(700, 22);
			this.txt_ZaribCode.Name = "txt_ZaribCode";
			this.txt_ZaribCode.Size = new System.Drawing.Size(70, 20);
			this.txt_ZaribCode.TabIndex = 101;
			this.Btn_Insert.Location = new System.Drawing.Point(491, 54);
			this.Btn_Insert.Name = "Btn_Insert";
			this.Btn_Insert.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Insert.Size = new System.Drawing.Size(70, 28);
			this.Btn_Insert.TabIndex = 104;
			this.Btn_Insert.Text = "(Ins) ایجاد ";
			this.Btn_Insert.UseVisualStyleBackColor = true;
			this.Btn_Copy.Location = new System.Drawing.Point(357, 54);
			this.Btn_Copy.Name = "Btn_Copy";
			this.Btn_Copy.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Copy.Size = new System.Drawing.Size(70, 28);
			this.Btn_Copy.TabIndex = 105;
			this.Btn_Copy.Text = "(Clt+C) کپی";
			this.Btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Delete.Enabled = false;
			this.btn_Delete.Location = new System.Drawing.Point(216, 54);
			this.btn_Delete.Name = "btn_Delete";
			this.btn_Delete.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_Delete.Size = new System.Drawing.Size(70, 28);
			this.btn_Delete.TabIndex = 106;
			this.btn_Delete.Text = "(Del) حذف";
			this.btn_Delete.UseVisualStyleBackColor = true;
			this.Btn_Exit.Location = new System.Drawing.Point(91, 54);
			this.Btn_Exit.Name = "Btn_Exit";
			this.Btn_Exit.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Btn_Exit.Size = new System.Drawing.Size(70, 28);
			this.Btn_Exit.TabIndex = 107;
			this.Btn_Exit.Text = " خروج ";
			this.Btn_Exit.UseVisualStyleBackColor = true;
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(313, 6);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(88, 13);
			this.Label1.TabIndex = 114;
			this.Label1.Text = "شرح کد بخش نامه";
			this.txt_ZaribCodeComment.Location = new System.Drawing.Point(27, 22);
			this.txt_ZaribCodeComment.Name = "txt_ZaribCodeComment";
			this.txt_ZaribCodeComment.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_ZaribCodeComment.Size = new System.Drawing.Size(670, 20);
			this.txt_ZaribCodeComment.TabIndex = 102;
			this.Label2.AutoSize = true;
			this.Label2.Location = new System.Drawing.Point(711, 6);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(63, 13);
			this.Label2.TabIndex = 90;
			this.Label2.Text = "کد بخش نامه";
			this.Btn_Save.Location = new System.Drawing.Point(645, 54);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(70, 28);
			this.Btn_Save.TabIndex = 103;
			this.Btn_Save.Text = "(F2) ذخیره ";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(1209, 6);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(29, 13);
			this.Label10.TabIndex = 94;
			this.Label10.Text = "فصل";
			this.dtg_Bakhshname.AllowUserToAddRows = false;
			this.dtg_Bakhshname.AllowUserToDeleteRows = false;
			this.dtg_Bakhshname.AllowUserToOrderColumns = true;
			this.dtg_Bakhshname.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dtg_Bakhshname.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_Bakhshname.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_Bakhshname.Location = new System.Drawing.Point(5, 7);
			this.dtg_Bakhshname.Name = "dtg_Bakhshname";
			this.dtg_Bakhshname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_Bakhshname.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dtg_Bakhshname.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_Bakhshname.Size = new System.Drawing.Size(815, 508);
			this.dtg_Bakhshname.TabIndex = 100;
			this.lbl_RecNo.AutoSize = true;
			this.lbl_RecNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_RecNo.Location = new System.Drawing.Point(743, 519);
			this.lbl_RecNo.Name = "lbl_RecNo";
			this.lbl_RecNo.Size = new System.Drawing.Size(61, 13);
			this.lbl_RecNo.TabIndex = 151;
			this.lbl_RecNo.Text = "تعداد رکورد";
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			base.ClientSize = new System.Drawing.Size(824, 641);
			base.ControlBox = false;
			base.Controls.Add(this.lbl_RecNo);
			base.Controls.Add(this.pnl_Bakhshname);
			base.Controls.Add(this.dtg_Bakhshname);
			base.Name = "Frm_ZarayebBakhshname";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "لیست بخش نامه ها";
			this.pnl_Bakhshname.ResumeLayout(false);
			this.pnl_Bakhshname.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_Bakhshname).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
            this.txt_ZaribCode.GotFocus += new System.EventHandler(this.txt_ZaribCode_GotFocus);
            this.txt_ZaribCode.TextChanged += new System.EventHandler(this.txt_ZaribCode_TextChanged);
            this.Btn_Insert.Click += new System.EventHandler(this.Btn_Insert_Click);
            this.Btn_Insert.GotFocus += new System.EventHandler(this.Btn_Insert_GotFocus);
            this.Btn_Copy.Click += new System.EventHandler(this.Btn_Copy_Click);
            this.Btn_Copy.GotFocus += new System.EventHandler(this.Btn_Copy_GotFocus);
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            this.btn_Delete.GotFocus += new System.EventHandler(this.Btn_Delet_GotFocus);
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            this.Btn_Exit.GotFocus += new System.EventHandler(this.Btn_Exit_GotFocus);
            this.txt_ZaribCodeComment.GotFocus += new System.EventHandler(this.txt_ZaribCodeComment_GotFocus);
            this.txt_ZaribCodeComment.TextChanged += new System.EventHandler(this.txt_ZaribCodeComment_TextChanged);
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            this.Btn_Save.GotFocus += new System.EventHandler(this.Btn_Save_GotFocus);
            this.dtg_Bakhshname.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Bakhshname_CellClick);
            this.dtg_Bakhshname.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_Bakhshname_CellContentClick);
            this.dtg_Bakhshname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtg_Bakhshname_KeyDown);
            this.dtg_Bakhshname.SelectionChanged += new System.EventHandler(this.dtg_Bakhshname_SelectionChanged);
        }
    }
}
