using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_AsnadGhaleb_New
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
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.Button btn_Select;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_FehrestNameFltr;

        // DataGridView
        private System.Windows.Forms.DataGridView dtg_AsnadGhaleb;

        // Label
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label10;

        // Panel
        private System.Windows.Forms.Panel pnl_Filter;

        // PictureBox
        private System.Windows.Forms.PictureBox PictureBox1;

        // TableLayoutPanel
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;

        // TextBox
        private System.Windows.Forms.TextBox txt_GhalebNameFltr;
        private System.Windows.Forms.TextBox txt_GhalebNoFltr;

        private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_AsnadGhaleb));
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btn_Select = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.dtg_AsnadGhaleb = new System.Windows.Forms.DataGridView();
			this.Label1 = new System.Windows.Forms.Label();
			this.pnl_Filter = new System.Windows.Forms.Panel();
			this.btn_Filter = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.cmbo_FehrestNameFltr = new System.Windows.Forms.ComboBox();
			this.txt_GhalebNoFltr = new System.Windows.Forms.TextBox();
			this.txt_GhalebNameFltr = new System.Windows.Forms.TextBox();
			this.Button7 = new System.Windows.Forms.Button();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadGhaleb).BeginInit();
			this.pnl_Filter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.btn_Select, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.btn_Cancel, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(34, 419);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(809, 29);
			this.TableLayoutPanel1.TabIndex = 0;
			this.btn_Select.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Select.Location = new System.Drawing.Point(169, 3);
			this.btn_Select.Name = "btn_Select";
			this.btn_Select.Size = new System.Drawing.Size(67, 23);
			this.btn_Select.TabIndex = 0;
			this.btn_Select.Text = "انتخاب";
			this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_Cancel.Location = new System.Drawing.Point(574, 3);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(67, 23);
			this.btn_Cancel.TabIndex = 1;
			this.btn_Cancel.Text = "انصراف";
			this.dtg_AsnadGhaleb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dtg_AsnadGhaleb.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dtg_AsnadGhaleb.Location = new System.Drawing.Point(34, 73);
			this.dtg_AsnadGhaleb.MultiSelect = false;
			this.dtg_AsnadGhaleb.Name = "dtg_AsnadGhaleb";
			this.dtg_AsnadGhaleb.ReadOnly = true;
			this.dtg_AsnadGhaleb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dtg_AsnadGhaleb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dtg_AsnadGhaleb.Size = new System.Drawing.Size(810, 316);
			this.dtg_AsnadGhaleb.TabIndex = 1;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("B Homa", 14.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.Location = new System.Drawing.Point(350, 14);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(194, 35);
			this.Label1.TabIndex = 2;
			this.Label1.Text = " قالب سند را انتخاب کنید :";
			this.pnl_Filter.BackColor = System.Drawing.Color.White;
			this.pnl_Filter.Controls.Add(this.btn_Filter);
			this.pnl_Filter.Controls.Add(this.Label10);
			this.pnl_Filter.Controls.Add(this.PictureBox1);
			this.pnl_Filter.Controls.Add(this.cmbo_FehrestNameFltr);
			this.pnl_Filter.Controls.Add(this.txt_GhalebNoFltr);
			this.pnl_Filter.Controls.Add(this.txt_GhalebNameFltr);
			this.pnl_Filter.Controls.Add(this.Button7);
			this.pnl_Filter.Location = new System.Drawing.Point(34, 53);
			this.pnl_Filter.Name = "pnl_Filter";
			this.pnl_Filter.Size = new System.Drawing.Size(810, 56);
			this.pnl_Filter.TabIndex = 89;
			this.btn_Filter.BackColor = System.Drawing.Color.White;
			this.btn_Filter.Enabled = false;
			this.btn_Filter.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Filter.ForeColor = System.Drawing.Color.Black;
			this.btn_Filter.Image = (System.Drawing.Image)resources.GetObject("btn_Filter.Image");
			this.btn_Filter.Location = new System.Drawing.Point(766, 1);
			this.btn_Filter.Name = "btn_Filter";
			this.btn_Filter.Size = new System.Drawing.Size(43, 54);
			this.btn_Filter.TabIndex = 157;
			this.btn_Filter.UseVisualStyleBackColor = false;
			this.Label10.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Label10.Location = new System.Drawing.Point(720, 1);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(46, 53);
			this.Label10.TabIndex = 155;
			this.Label10.Text = "ردیف";
			this.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(19, 0);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(776, 31);
			this.PictureBox1.TabIndex = 156;
			this.PictureBox1.TabStop = false;
			this.cmbo_FehrestNameFltr.FormattingEnabled = true;
			this.cmbo_FehrestNameFltr.Location = new System.Drawing.Point(18, 33);
			this.cmbo_FehrestNameFltr.Name = "cmbo_FehrestNameFltr";
			this.cmbo_FehrestNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbo_FehrestNameFltr.Size = new System.Drawing.Size(150, 21);
			this.cmbo_FehrestNameFltr.TabIndex = 95;
			this.txt_GhalebNoFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_GhalebNoFltr.Location = new System.Drawing.Point(670, 33);
			this.txt_GhalebNoFltr.Name = "txt_GhalebNoFltr";
			this.txt_GhalebNoFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_GhalebNoFltr.Size = new System.Drawing.Size(49, 21);
			this.txt_GhalebNoFltr.TabIndex = 55;
			this.txt_GhalebNameFltr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_GhalebNameFltr.Location = new System.Drawing.Point(169, 33);
			this.txt_GhalebNameFltr.Name = "txt_GhalebNameFltr";
			this.txt_GhalebNameFltr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txt_GhalebNameFltr.Size = new System.Drawing.Size(500, 21);
			this.txt_GhalebNameFltr.TabIndex = 54;
			this.Button7.BackColor = System.Drawing.Color.LightGray;
			this.Button7.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Button7.ForeColor = System.Drawing.Color.Black;
			this.Button7.Location = new System.Drawing.Point(1506, 7);
			this.Button7.Name = "Button7";
			this.Button7.Size = new System.Drawing.Size(89, 21);
			this.Button7.TabIndex = 44;
			this.Button7.Text = "حذف فیلتر";
			this.Button7.UseVisualStyleBackColor = false;
			base.AcceptButton = this.btn_Select;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.CancelButton = this.btn_Cancel;
			base.ClientSize = new System.Drawing.Size(875, 457);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Filter);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.TableLayoutPanel1);
			base.Controls.Add(this.dtg_AsnadGhaleb);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Frm_AsnadGhaleb";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "انتخاب قالب سند";
			this.TableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)this.dtg_AsnadGhaleb).EndInit();
			this.pnl_Filter.ResumeLayout(false);
			this.pnl_Filter.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.Cancel_Button_Click);
            this.dtg_AsnadGhaleb.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellContentDoubleClick);
            this.dtg_AsnadGhaleb.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellDoubleClick);
            this.dtg_AsnadGhaleb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_AsnadGhaleb_CellContentClick);
            this.cmbo_FehrestNameFltr.TextChanged += new System.EventHandler(this.cmbo_FehrestNameFltr_TextChanged);
            this.txt_GhalebNoFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GhalebNoFltr_KeyDown);
            this.txt_GhalebNameFltr.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_GhalebNameFltr_KeyDown);
        }
    }
}
