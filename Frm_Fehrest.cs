using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class Frm_Fehrest : Form
	{
		public struct FehrestDetailes
		{
			public int Id;

			public string FehrestFile;

			public string FehrestName;

			public string FehrestMabna;
		}

		private IContainer components;

		

		public FehrestDetailes Fehrest;

		private byte frmFehrestRefresh;

		private string BtnCommand;

		private string ChangeDtgOrPnl;

		private byte DtgFehrestRefresh;

        private System.Windows.Forms.Panel pnl_FehrestFilter;
        private System.Windows.Forms.Button btn_Filter;
        private System.Windows.Forms.ComboBox cmbo_FehrestMabnaFltr;
        private System.Windows.Forms.TextBox txt_FehrestNameFltr;
        private System.Windows.Forms.TextBox txt_FehrestFileFltr;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.DataGridView dtg_Fehrest;
        private System.Windows.Forms.Panel pnl_Fehrest;
        private System.Windows.Forms.ComboBox cmbo_FehrestMabna;
        private System.Windows.Forms.Label Label42;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Label36;
        private System.Windows.Forms.Label Label40;
        internal System.Windows.Forms.TextBox txt_FehrestName;
        private System.Windows.Forms.TextBox txt_FehrestFile;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_copy;
        public Frm_Fehrest()
		{
			base.KeyDown += Frm_Fehrest_KeyDown;
			base.Load += Frm_Fehrest_Load;
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

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			Close();
		}

		public void ShowFehrestRecord()
		{
			int index = 0;
			Module1.DatePikerSit = false;
			ref FehrestDetailes fehrest = ref Fehrest;
			int lErl = default(int);
			if (dtg_Fehrest.RowCount != 0)
			{
				try
				{
					index = dtg_Fehrest.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				fehrest.Id = Conversions.ToInteger(dtg_Fehrest.Rows[index].Cells[0].Value);
				fehrest.FehrestFile = Conversions.ToString(dtg_Fehrest.Rows[index].Cells[2].Value);
				fehrest.FehrestName = dtg_Fehrest.Rows[index].Cells[3].Value.ToString();
				fehrest.FehrestMabna = dtg_Fehrest.Rows[index].Cells[4].Value.ToString();
				txt_FehrestName.Text = fehrest.FehrestName;
				txt_FehrestFile.Text = fehrest.FehrestFile;
				cmbo_FehrestMabna.Text = fehrest.FehrestMabna;
			}
			lErl = 60;
		}

		private void dtg_Fehrest_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			ShowFehrestRecord();
		}

		private void dtg_Fehrest_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowFehrestRecord();
		}

		private void dtg_Fehrest_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			btn_Open_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void dtg_Fehrest_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				btn_copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_FehrestFile.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Fehrest_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				switch (MessageBox.Show("آیا تغییرمشخصات فهرست بها ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					SetPnl_FehrestBlue();
					break;
				case DialogResult.No:
					SetPnl_FehrestBlue();
					break;
				case DialogResult.Cancel:
					txt_FehrestFile.Focus();
					return;
				}
			}
			if (DtgFehrestRefresh == 1)
			{
				ShowFehrestRecord();
			}
		}

		private void Frm_Fehrest_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_Fehrest_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmFehrestRefresh = 0;
			DtgFehrestRefresh = 0;
			cmbo_FehrestMabna.Items.Clear();
			cmbo_FehrestMabna.Items.Add("(پايه)");
			cmbo_FehrestMabna.Items.Add("-");
			DtgFehrestRefresh = 1;
			frmFehrestRefresh = 1;
			foreach (Control control in pnl_Fehrest.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.GotFocus += [SpecialName] [DebuggerHidden] (object a0, EventArgs a1) =>
					{
						GeneralGotFocusHandler();
					};
					control.KeyDown += GeneralKeyDownHandler1;
				}
				if (control is TextBox || control is Button)
				{
					control.KeyDown += GeneralKeyDownHandler2;
				}
			}
		}

		private void GeneralKeyDownHandler1(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				SelectNextControl((Control)sender, forward: true, tabStopOnly: true, nested: true, wrap: true);
				e.Handled = true;
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
			foreach (Control control in pnl_Fehrest.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		public void Load_dtg_Fehrest()
		{
			DataTable dataTable = new DataTable();
			string[] array = new string[5];
			base.Visible = true;
			pnl_Fehrest.Visible = true;
			int num = 0;
			checked
			{
				do
				{
					array[num] = "";
					num++;
				}
				while (num <= 2);
				if (Operators.CompareString(Module1.FehrestFile_filter, "", TextCompare: false) != 0)
				{
					if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0)
					{
						array[1] = " And ";
					}
					if (Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
					{
						array[2] = " And ";
					}
				}
				if (Operators.CompareString(Module1.FehrestName_filter, "", TextCompare: false) != 0 && Operators.CompareString(Module1.FehrestMabna_filter, "", TextCompare: false) != 0)
				{
					array[2] = " And ";
				}
				Module1.strWhere = " WHERE " + Module1.FehrestFile_filter + array[1] + Module1.FehrestName_filter + array[2] + Module1.FehrestMabna_filter;
				if (Operators.CompareString(Module1.strWhere, " WHERE ", TextCompare: false) == 0)
				{
					Module1.strWhere = " ";
				}
				Module1.MyConn.Close();
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "SELECT [kod] As 'Id',[kod] As 'ردیف', [filename] As 'فایل فهرست', [fehrest] As 'نام فهرست',[jari] As 'پایه' FROM [dbo].[Fehrest] " + Module1.strWhere + " Order by [filename] desc";
				SqlDataReader reader = Module1.cmd.ExecuteReader();
				dataTable.Load(reader);
				foreach (DataColumn column in dataTable.Columns)
				{
					column.ReadOnly = false;
				}
				int num2 = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num2; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
					if (Operators.ConditionalCompareObjectEqual(dataTable.Rows[i]["پایه"], "(پايه)", TextCompare: false))
					{
						Module1.MabnaFehresrFile = Conversions.ToString(dataTable.Rows[i]["فایل فهرست"]);
					}
				}
				dtg_Fehrest.DataSource = dataTable;
				dtg_Fehrest.Columns[0].Visible = false;
				dtg_Fehrest.Columns[1].Width = 50;
				dtg_Fehrest.Columns[2].Width = 150;
				dtg_Fehrest.Columns[3].Width = 350;
				dtg_Fehrest.Columns[4].Width = 70;
			}
		}

		private void btn_Open_Click(object sender, EventArgs e)
		{
			Module1.FAslOrItem = "Fasl";
			MyProject.Forms.Frm_FehrestDetail.ShowDialog();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			string text = "";
			checked
			{
				if (Operators.CompareString(txt_FehrestFile.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("فایل فهرست بها را وارد کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_FehrestFile.Focus();
				}
				else
				{
					if (pnl_Fehrest.BackColor == Color.DarkSeaGreen)
					{
						return;
					}
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
					{
						Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + txt_FehrestFile.Text + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + txt_FehrestFile.Text + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FehrestFile.Text = "";
							txt_FehrestFile.Focus();
							sqlDataReader.Close();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "INSERT INTO [dbo].[Fehrest] ([filename],[Fehrest],[jari]) VALUES('" + txt_FehrestFile.Text + "','" + txt_FehrestName.Text + "','-')";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '(پايه)'  WHERE [filename] = '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '-'  WHERE [filename] <> '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_FehrestBlue();
					}
					else
					{
						Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + txt_FehrestFile.Text + "' And kod <> '" + Conversions.ToString(Fehrest.Id) + "'";
						SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
						if (sqlDataReader.HasRows)
						{
							MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + txt_FehrestFile.Text + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
							txt_FehrestFile.Text = "";
							txt_FehrestFile.Focus();
							return;
						}
						sqlDataReader.Close();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest] SET [filename] ='" + txt_FehrestFile.Text + "',[fehrest] = '" + txt_FehrestName.Text + "',[jari] = '" + cmbo_FehrestMabna.Text + "'WHERE kod = '" + Conversions.ToString(Fehrest.Id) + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '(پايه)'  WHERE [filename] = '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						Module1.cmd.CommandText = "UPDATE [dbo].[Fehrest]  SET [jari] = '-'  WHERE [filename] <> '" + Module1.MabnaFehresrFile + "'";
						Module1.cmd.ExecuteNonQuery();
						SetPnl_FehrestBlue();
					}
					text = txt_FehrestFile.Text;
					Load_dtg_Fehrest();
					int num = dtg_Fehrest.RowCount - 1;
					for (int i = 0; i <= num; i++)
					{
						if (Operators.ConditionalCompareObjectEqual(dtg_Fehrest.Rows[i].Cells[2].Value, text, TextCompare: false))
						{
							dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[i].Cells[1];
							ShowFehrestRecord();
						}
					}
				}
			}
		}

		private void SetPnl_FehrestBlue()
		{
			pnl_Fehrest.BackColor = Color.DarkSeaGreen;
			foreach (object control in pnl_Fehrest.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Fehrest.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			pnl_Fehrest.BackColor = Color.LightPink;
			txt_FehrestFile.Text = "";
			txt_FehrestName.Text = "";
			cmbo_FehrestMabna.Text = "-";
		}

		private void btn_copy_Click(object sender, EventArgs e)
		{
			string text = txt_FehrestFile.Text;
			BtnCommand = "Copy";
			if (pnl_Fehrest.BackColor == Color.LightPink)
			{
				dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			string text2 = Interaction.InputBox("  کپی فایل فهرست بهای " + Fehrest.FehrestFile + " با چه نامی انجام شود؟ ", " ");
			if (Operators.CompareString(text2, "", TextCompare: false) == 0)
			{
				return;
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [filename] FROM [dbo].[Fehrest] Where [filename]='" + text2 + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				MessageBox.Show(".موجود است نام فایل جدید انتخاب کنید " + text2 + " فایل  ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			sqlDataReader.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fehrest]([filename],[fehrest],[jari]) (Select '" + text2 + "'[filename],[fehrest],''[jari] FROM [dbo].[Fehrest] Where [filename]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "CREATE TABLE [dbo].[" + text2 + "]([radif] [nvarchar](10) NULL,[shomar] [nvarchar](10) NOT NULL,[Sharh] [nvarchar](1000) NOT NULL,[Fasl] [nvarchar](5) NOT NULL,[vkod] [decimal](18, 1) NULL,[Vahed] [nvarchar](100) NOT NULL,[baha] [nvarchar](100) NOT NULL,[darsad] [bit] NULL,[setareh] [bit] NULL,[ItemNoa] [nvarchar](20) NOT NULL,[ItemDarsad] [nvarchar](200) NULL,[GroupNo] [nchar](10) NULL,[GroupName] [nvarchar](200) NULL,[Selection] [bit] NULL) ON [PRIMARY]";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[" + text2 + "] ([radif],[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection]) (SELECT [radif],[shomar],[Sharh],[Fasl],[vkod],[Vahed],[baha],[darsad],[setareh],[ItemNoa],[ItemDarsad],[GroupNo],[GroupName],[Selection] FROM [Jahdazma1].[dbo].[" + text + "])";
			Module1.cmd.ExecuteNonQuery();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "INSERT INTO [dbo].[Fosool] ([Id],[FehrestFile],[FaslCode],[FaslComment],[ZaribCode])(SELECT [Id],'" + text2 + "'[FehrestFile],[FaslCode],[FaslComment],[ZaribCode] FROM [dbo].[Fosool] where [FehrestFile]='" + text + "')";
			Module1.cmd.ExecuteNonQuery();
			Load_dtg_Fehrest();
			checked
			{
				int num = dtg_Fehrest.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Operators.CompareString(dtg_Fehrest.Rows[i].Cells[2].Value.ToString(), text2, TextCompare: false) == 0)
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[i].Cells[1];
						ShowFehrestRecord();
						break;
					}
				}
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand = new SqlCommand();
			string text = txt_FehrestFile.Text;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Fehrest.RowCount - 1 != 0 && MessageBox.Show(" حذف شود؟ " + txt_FehrestFile.Text + " فهرست با نام فایل ", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "SELECT [sanadnum] FROM [dbo].[asnad1] WHERE fehrestfile = '" + text + "'";
					SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						MessageBox.Show(".ابتدا سند های مرتبط به این فهرست بها بایستی حذف شوند ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					sqlDataReader.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = ("DELETE FROM [dbo].[Fehrest]  WHERE [filename] = '" + text) ?? "";
					sqlCommand.ExecuteNonQuery();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = ("DELETE FROM [dbo].[Fosool] where [FehrestFile] = '" + text) ?? "";
					sqlCommand.ExecuteNonQuery();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					sqlCommand.Connection = Module1.MyConn;
					sqlCommand.CommandText = "DROP TABLE [dbo].[" + text + "]";
					sqlCommand.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				int lErl = 20;
				Load_dtg_Fehrest();
				try
				{
					int index = dtg_Fehrest.CurrentRow.Index;
					if (index != 0)
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[index - 1].Cells[1];
					}
					else
					{
						dtg_Fehrest.CurrentCell = dtg_Fehrest.Rows[index].Cells[1];
					}
				}
				catch (Exception ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					Exception ex2 = ex;
					ProjectData.ClearProjectError();
				}
				ShowFehrestRecord();
			}
		}

		private void btn_Exit_Click_1(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Fehrest_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

		private void txt_FehrestName_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_FehrestName_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FehrestName.Text.Trim(), Fehrest.FehrestName.Trim(), TextCompare: false) != 0)
			{
				txt_FehrestName.ForeColor = Color.Red;
			}
			else
			{
				txt_FehrestName.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

		private void txt_FehrestFile_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_FehrestFile_TextChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(txt_FehrestFile.Text.Trim(), Fehrest.FehrestFile.Trim(), TextCompare: false) != 0)
			{
				txt_FehrestFile.ForeColor = Color.Red;
			}
			else
			{
				txt_FehrestFile.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

		private void cmbo_FehrestMabna_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void cmbo_FehrestMabna_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Operators.CompareString(cmbo_FehrestMabna.Text.Trim(), Fehrest.FehrestMabna.Trim(), TextCompare: false) != 0)
			{
				if (Operators.CompareString(cmbo_FehrestMabna.Text, "(پايه)", TextCompare: false) == 0)
				{
					Module1.MabnaFehresrName = txt_FehrestName.Text;
					Module1.MabnaFehresrFile = txt_FehrestFile.Text;
				}
				cmbo_FehrestMabna.ForeColor = Color.Red;
			}
			else
			{
				cmbo_FehrestMabna.ForeColor = Color.Black;
			}
			CheckFehrestChange();
		}

		private void CheckFehrestChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Fehrest.BackColor = Color.Tan;
			foreach (object control in pnl_Fehrest.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Fehrest.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Fehrest.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Fehrest.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void txt_FehrestFileFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_FehrestFileFltr.Text, "", TextCompare: false) != 0)
				{
					string text = txt_FehrestFileFltr.Text;
					Module1.FehrestFile_filter = " ([filename] Like N'%" + text + "%')";
				}
				else
				{
					Module1.FehrestFile_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}

		private void txt_FehrestNameFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(txt_FehrestNameFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = txt_FehrestNameFltr.Text;
					Module1.FehrestName_filter = " (REPLACE(REPLACE([fehrest],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					Module1.FehrestName_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}

		private void cmbo_FehrestMabnaFltr_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Return)
			{
				if (Operators.CompareString(cmbo_FehrestMabnaFltr.Text, "", TextCompare: false) != 0)
				{
					string arab = cmbo_FehrestMabnaFltr.Text;
					Module1.FehrestMabna_filter = " (REPLACE(REPLACE([jari],'ي',N'ی'),'ك',N'ک') Like N'%" + Module1.ArbToPer(arab) + "%')";
				}
				else
				{
					Module1.FehrestMabna_filter = "";
				}
				Load_dtg_Fehrest();
				ShowFehrestRecord();
			}
		}
	}
}
