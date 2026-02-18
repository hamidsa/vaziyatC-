using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class Frm_ZarayebBakhshname : Form
	{
		public struct BakhshnameDetailes
		{
			public int Id;

			public string ZaribCode;

			public string ZaribCodeComment;
		}

		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ZaribCode")]
		private TextBox _txt_ZaribCode;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Insert")]
		private Button _Btn_Insert;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Copy")]
		private Button _Btn_Copy;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Delete")]
		private Button _btn_Delete;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Exit")]
		private Button _Btn_Exit;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_ZaribCodeComment")]
		private TextBox _txt_ZaribCodeComment;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Btn_Save")]
		private Button _Btn_Save;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("dtg_Bakhshname")]
		private DataGridView _dtg_Bakhshname;

		public BakhshnameDetailes Bakhshname;

		private string BtnCommand;

		private string ChangeDtgOrPnl;

		private byte frmBakhshnameRefresh;

		private byte DtgBakhshnameRefresh;

        private System.Windows.Forms.Panel pnl_Bakhshname;
        private System.Windows.Forms.TextBox txt_ZaribCode;
        private System.Windows.Forms.Button Btn_Insert;
        private System.Windows.Forms.Button Btn_Copy;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txt_ZaribCodeComment;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Button Btn_Save;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.DataGridView dtg_Bakhshname;
        private System.Windows.Forms.Label lbl_RecNo;
        public Frm_ZarayebBakhshname()
		{
			base.KeyDown += Frm_ZarayebBakhshname_KeyDown;
			base.Load += Frm_ZaribCode_Load;
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

		private void Frm_ZarayebBakhshname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Btn_Exit_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void Frm_ZaribCode_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			base.KeyPreview = true;
			frmBakhshnameRefresh = 0;
			Load_dtg_Bakhshname();
			dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[0].Cells[1];
			ShowBakhshnameRecord();
			frmBakhshnameRefresh = 1;
			foreach (Control control in pnl_Bakhshname.Controls)
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
			foreach (Control control in pnl_Bakhshname.Controls)
			{
				if (control is TextBox || control is ComboBox || control is Button)
				{
					control.BackColor = Color.White;
				}
			}
			base.ActiveControl.BackColor = Color.Cyan;
		}

		public void Load_dtg_Bakhshname()
		{
			DataTable dataTable = new DataTable();
			base.Visible = true;
			base.KeyPreview = true;
			DtgBakhshnameRefresh = 0;
			base.KeyPreview = true;
			Module1.WhereZaribCode = "";
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [Id] As 'Id',[Id] As 'ردیف',[ZaribCode] As 'کد بخشنامه',[Comment] As 'شرح کد بخشنامه' FROM [dbo].[ZarayebBakhshname] " + Module1.WhereZaribCode + " Order By ZaribCode ";
			SqlDataReader reader = Module1.cmd.ExecuteReader();
			dataTable.Load(reader);
			foreach (DataColumn column in dataTable.Columns)
			{
				column.ReadOnly = false;
			}
			checked
			{
				int num = dataTable.Rows.Count - 1;
				for (int i = 0; i <= num; i++)
				{
					dataTable.Rows[i]["ردیف"] = i + 1;
				}
				dtg_Bakhshname.DataSource = dataTable;
				dtg_Bakhshname.Columns[0].Visible = false;
				dtg_Bakhshname.Columns[1].Width = 50;
				dtg_Bakhshname.Columns[2].Width = 50;
				dtg_Bakhshname.Columns[3].Width = 670;
			}
			foreach (Control control3 in pnl_Bakhshname.Controls)
			{
				if (control3 is TextBox || control3 is ComboBox || control3 is Button)
				{
					control3.KeyDown += GeneralKeyDownHandler;
				}
			}
			foreach (Control control4 in pnl_Bakhshname.Controls)
			{
				if (control4 is TextBox || control4 is ComboBox || control4 is Button)
				{
					control4.KeyDown += GeneralKeyDownHandler;
				}
			}
			DtgBakhshnameRefresh = 1;
			lbl_RecNo.Text = Conversions.ToString(dataTable.Rows.Count) + " :تعداد رکورد";
		}

		private void GeneralKeyDownHandler(object sender, KeyEventArgs e)
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

		public void ShowBakhshnameRecord()
		{
			int index = 0;
			ref BakhshnameDetailes bakhshname = ref Bakhshname;
			int lErl = default(int);
			if (dtg_Bakhshname.RowCount != 0)
			{
				try
				{
					index = dtg_Bakhshname.CurrentRow.Index;
				}
				catch (NullReferenceException ex)
				{
					ProjectData.SetProjectError(ex, lErl);
					NullReferenceException ex2 = ex;
					ProjectData.ClearProjectError();
				}
				if (dtg_Bakhshname.RowCount != 0)
				{
					try
					{
						bakhshname.Id = Conversions.ToInteger(dtg_Bakhshname.Rows[index].Cells[0].Value);
					}
					catch (NullReferenceException ex3)
					{
						ProjectData.SetProjectError(ex3, lErl);
						NullReferenceException ex4 = ex3;
						ProjectData.ClearProjectError();
						goto IL_0151;
					}
					bakhshname.Id = Conversions.ToInteger(dtg_Bakhshname.Rows[index].Cells[0].Value);
					bakhshname.ZaribCode = Conversions.ToString(dtg_Bakhshname.Rows[index].Cells[2].Value);
					bakhshname.ZaribCodeComment = dtg_Bakhshname.Rows[index].Cells[3].Value.ToString();
					txt_ZaribCode.Text = bakhshname.ZaribCode;
					txt_ZaribCodeComment.Text = bakhshname.ZaribCodeComment;
				}
			}
			goto IL_0151;
			IL_0151:
			lErl = 60;
		}

		private void Btn_Exit_Click(object sender, EventArgs e)
		{
			BtnCommand = "";
			dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			Close();
		}

		private void dtg_Bakhshname_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowBakhshnameRecord();
		}

		private void dtg_Bakhshname_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			ShowBakhshnameRecord();
		}

		private void dtg_Bakhshname_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.F2)
			{
				Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.Control && e.KeyCode == Keys.C)
			{
				Btn_Copy_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Insert)
			{
				Btn_Insert_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Delete)
			{
				btn_Delete_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_ZaribCode.Focus();
				e.SuppressKeyPress = true;
			}
		}

		private void dtg_Bakhshname_SelectionChanged(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "dtg";
			if ((pnl_Bakhshname.BackColor == Color.LightPink) & (frmBakhshnameRefresh == 1))
			{
				switch (MessageBox.Show("آیا تغییرمشخصات ذخیره شود؟", "پیغام مهم", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation))
				{
				case DialogResult.Yes:
					Btn_Save_Click(RuntimeHelpers.GetObjectValue(sender), e);
					pnl_Bakhshname.BackColor = Color.LightCyan;
					break;
				case DialogResult.No:
					pnl_Bakhshname.BackColor = Color.LightCyan;
					break;
				case DialogResult.Cancel:
					txt_ZaribCode.Focus();
					return;
				}
			}
			if (DtgBakhshnameRefresh == 1)
			{
				ShowBakhshnameRecord();
			}
			ShowBakhshnameRecord();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			foreach (Control control in pnl_Bakhshname.Controls)
			{
				if ((object)control.GetType() == typeof(TextBox) && Operators.CompareString(control.Text, "", TextCompare: false) == 0)
				{
					MessageBox.Show("اطلاعات را کامل کنید ", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					control.Focus();
					return;
				}
			}
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			if (Operators.CompareString(BtnCommand, "Insert", TextCompare: false) == 0)
			{
				Module1.cmd.CommandText = "SELECT [ZaribCode],[Comment] FROM [dbo].[ZarayebBakhshname] Where [ZaribCode]='" + txt_ZaribCode.Text + "' And [Comment]='" + txt_ZaribCodeComment.Text + "'";
				SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
				if (sqlDataReader.HasRows)
				{
					MessageBox.Show(". اطلاعات مذکور موجود است اطلاعات جدید وارد کنید", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
					txt_ZaribCode.Focus();
					sqlDataReader.Close();
					return;
				}
				sqlDataReader.Close();
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebBakhshname] ([ZaribCode],[Comment]) VALUES('" + txt_ZaribCode.Text + "','" + txt_ZaribCodeComment.Text + "')";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_BakhshnameGreen();
			}
			else
			{
				Module1.cmd.CommandText = "UPDATE [dbo].[ZarayebBakhshname] SET [ZaribCode] ='" + txt_ZaribCode.Text + "',[Comment] = '" + txt_ZaribCodeComment.Text + "' WHERE Id = '" + Conversions.ToString(Bakhshname.Id) + "'";
				Module1.cmd.ExecuteNonQuery();
				Setpnl_BakhshnameGreen();
			}
			Load_dtg_Bakhshname();
			DataGridView dataGridView = dtg_Bakhshname;
			checked
			{
				int num = dataGridView.RowCount - 1;
				for (int i = 0; i <= num; i++)
				{
					if (Conversions.ToBoolean(Operators.AndObject(Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[2].Value, txt_ZaribCode.Text, TextCompare: false), Operators.CompareObjectEqual(dataGridView.Rows[i].Cells[3].Value, txt_ZaribCodeComment.Text, TextCompare: false))))
					{
						dataGridView.CurrentCell = dataGridView.Rows[i].Cells[1];
						ShowBakhshnameRecord();
					}
				}
				dataGridView = null;
			}
		}

		private void Setpnl_BakhshnameGreen()
		{
			pnl_Bakhshname.BackColor = Color.LightCyan;
			foreach (object control in pnl_Bakhshname.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
			foreach (object control2 in pnl_Bakhshname.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				NewLateBinding.LateSet(objectValue2, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void Btn_Insert_Click(object sender, EventArgs e)
		{
			BtnCommand = "Insert";
			if (pnl_Bakhshname.BackColor == Color.LightPink)
			{
				dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			txt_ZaribCode.Text = "";
			txt_ZaribCodeComment.Text = "";
		}

		private void Btn_Copy_Click(object sender, EventArgs e)
		{
			ShowBakhshnameRecord();
			int rowIndex = dtg_Bakhshname.CurrentCell.RowIndex;
			int columnIndex = dtg_Bakhshname.CurrentCell.ColumnIndex;
			BtnCommand = "Copy";
			if (pnl_Bakhshname.BackColor == Color.LightPink)
			{
				dtg_Bakhshname_SelectionChanged(RuntimeHelpers.GetObjectValue(sender), e);
			}
			int index = dtg_Bakhshname.CurrentRow.Index;
			if (MessageBox.Show("ردیف با شماره   " + Conversions.ToString(checked(rowIndex + 1)) + " کپی شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) != DialogResult.Cancel)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[ZarayebBakhshname]([ZaribCode],[Comment]) (SELECT [ZaribCode],[Comment] FROM [dbo].[ZarayebBakhshname] Where [Id]='" + Conversions.ToString(Bakhshname.Id) + "')";
				Module1.cmd.ExecuteNonQuery();
				Load_dtg_Bakhshname();
				dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[rowIndex].Cells[columnIndex];
			}
		}

		private void btn_Delete_Click(object sender, EventArgs e)
		{
			int rowIndex = dtg_Bakhshname.CurrentCell.RowIndex;
			int columnIndex = dtg_Bakhshname.CurrentCell.ColumnIndex;
			BtnCommand = "Delete";
			checked
			{
				if (dtg_Bakhshname.RowCount - 1 != 0)
				{
					int index = dtg_Bakhshname.CurrentRow.Index;
					if (MessageBox.Show("کد بخشنامه با شماره   " + txt_ZaribCode.Text + " حذف شود؟", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button2) == DialogResult.Cancel)
					{
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT [FehrestFile] FROM [dbo].[Fosool] WHERE [ZaribCode] = '" + txt_ZaribCode.Text + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						MessageBox.Show("ابتدا فهرست بهاهایی که مرتبط با کد بخشنامه   " + txt_ZaribCode.Text + " هستند بایستی حذف شوند.", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
						return;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "DELETE FROM [dbo].[ZarayebBakhshname] WHERE [ZaribCode] = '" + txt_ZaribCode.Text + "'";
					Module1.cmd.ExecuteNonQuery();
					Module1.MyConn.Close();
				}
				Load_dtg_Bakhshname();
				if (rowIndex == 0)
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[0].Cells[columnIndex];
				}
				if (rowIndex > dtg_Bakhshname.RowCount)
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[dtg_Bakhshname.RowCount].Cells[columnIndex];
				}
				if ((rowIndex > 0) & (dtg_Bakhshname.RowCount <= dtg_Bakhshname.RowCount))
				{
					dtg_Bakhshname.CurrentCell = dtg_Bakhshname.Rows[rowIndex - 1].Cells[columnIndex];
				}
			}
		}

		private void txt_ZaribCode_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ZaribCode_TextChanged(object sender, EventArgs e)
		{
			if (frmBakhshnameRefresh != 0)
			{
				if (Operators.CompareString(txt_ZaribCode.Text, Bakhshname.ZaribCode.ToString(), TextCompare: false) != 0)
				{
					txt_ZaribCode.ForeColor = Color.Red;
				}
				else
				{
					txt_ZaribCode.ForeColor = Color.Black;
				}
			}
			CheckBakhshnameChange();
		}

		private void txt_ZaribCodeComment_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void txt_ZaribCodeComment_TextChanged(object sender, EventArgs e)
		{
			if (frmBakhshnameRefresh != 0)
			{
				if (Operators.CompareString(txt_ZaribCodeComment.Text, Bakhshname.ZaribCodeComment.ToString(), TextCompare: false) != 0)
				{
					txt_ZaribCodeComment.ForeColor = Color.Red;
				}
				else
				{
					txt_ZaribCodeComment.ForeColor = Color.Black;
				}
			}
			CheckBakhshnameChange();
		}

		private void CheckBakhshnameChange()
		{
			if (Operators.CompareString(ChangeDtgOrPnl, "dtg", TextCompare: false) == 0)
			{
				return;
			}
			pnl_Bakhshname.BackColor = Color.LightCyan;
			foreach (object control in pnl_Bakhshname.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					pnl_Bakhshname.BackColor = Color.LightPink;
					return;
				}
			}
			foreach (object control2 in pnl_Bakhshname.Controls)
			{
				object objectValue2 = RuntimeHelpers.GetObjectValue(control2);
				object obj2 = NewLateBinding.LateGet(objectValue2, null, "ForeColor", new object[0], null, null, null);
				if (((obj2 != null) ? ((Color)obj2) : default(Color)) == Color.Red)
				{
					pnl_Bakhshname.BackColor = Color.LightPink;
					break;
				}
			}
		}

		private void Btn_Save_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void Btn_Insert_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void Btn_Copy_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void Btn_Delet_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}

		private void Btn_Exit_GotFocus(object sender, EventArgs e)
		{
			ChangeDtgOrPnl = "pnl";
		}
	}
}
