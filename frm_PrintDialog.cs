using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic.CompilerServices;

namespace GeoBaha
{
	[DesignerGenerated]
	public class frm_PrintDialog : Form
	{
		private IContainer components;


        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Button OK_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Panel Panel1;
        private System.Windows.Forms.RadioButton rdo_Nameh;
        private System.Windows.Forms.RadioButton rdo_Sanad;
        private System.Windows.Forms.RadioButton rdo_ArzeshAfzoode;
        private System.Windows.Forms.Label lbl_Ronevwsht;
        internal System.Windows.Forms.TextBox txt_Ronevwsht;
        private System.Windows.Forms.Label lbl_Karnam2;
        internal System.Windows.Forms.TextBox txt_Karnam2;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txt_Takhfif;
        private System.Windows.Forms.RadioButton rdo_WithTakhfif;
        private System.Windows.Forms.RadioButton rdo_NoTakhfif;
        internal System.Windows.Forms.TextBox txt_Tozihat;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ComboBox cmbo_Pardakht;
        private System.Windows.Forms.Label Label2;

        public frm_PrintDialog()
		{
			base.KeyDown += frm_Dialog1_KeyDown;
			base.Load += frm_PrintDialog_Load;
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
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.txt_Tozihat = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cmbo_Pardakht = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.txt_Takhfif = new System.Windows.Forms.TextBox();
			this.rdo_WithTakhfif = new System.Windows.Forms.RadioButton();
			this.rdo_NoTakhfif = new System.Windows.Forms.RadioButton();
			this.txt_Ronevwsht = new System.Windows.Forms.TextBox();
			this.txt_Karnam2 = new System.Windows.Forms.TextBox();
			this.rdo_ArzeshAfzoode = new System.Windows.Forms.RadioButton();
			this.rdo_Nameh = new System.Windows.Forms.RadioButton();
			this.rdo_Sanad = new System.Windows.Forms.RadioButton();
			this.lbl_Ronevwsht = new System.Windows.Forms.Label();
			this.lbl_Karnam2 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(57, 337);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(636, 29);
			this.TableLayoutPanel1.TabIndex = 0;
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Location = new System.Drawing.Point(444, 3);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(67, 23);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "OK";
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Location = new System.Drawing.Point(126, 3);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(67, 23);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "Cancel (Esc)";
			this.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.Panel1.Controls.Add(this.Panel2);
			this.Panel1.Controls.Add(this.txt_Ronevwsht);
			this.Panel1.Controls.Add(this.txt_Karnam2);
			this.Panel1.Controls.Add(this.rdo_ArzeshAfzoode);
			this.Panel1.Controls.Add(this.rdo_Nameh);
			this.Panel1.Controls.Add(this.rdo_Sanad);
			this.Panel1.Controls.Add(this.lbl_Ronevwsht);
			this.Panel1.Controls.Add(this.lbl_Karnam2);
			this.Panel1.Location = new System.Drawing.Point(57, 43);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(636, 277);
			this.Panel1.TabIndex = 2;
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.txt_Tozihat);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.cmbo_Pardakht);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Controls.Add(this.txt_Takhfif);
			this.Panel2.Controls.Add(this.rdo_WithTakhfif);
			this.Panel2.Controls.Add(this.rdo_NoTakhfif);
			this.Panel2.Location = new System.Drawing.Point(20, 159);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(467, 106);
			this.Panel2.TabIndex = 7;
			this.txt_Tozihat.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Tozihat.Location = new System.Drawing.Point(3, 69);
			this.txt_Tozihat.Name = "txt_Tozihat";
			this.txt_Tozihat.Size = new System.Drawing.Size(400, 30);
			this.txt_Tozihat.TabIndex = 7;
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.Location = new System.Drawing.Point(403, 73);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(67, 26);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "توضیحات :";
			this.cmbo_Pardakht.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_Pardakht.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_Pardakht.FormattingEnabled = true;
			this.cmbo_Pardakht.Location = new System.Drawing.Point(258, 32);
			this.cmbo_Pardakht.Name = "cmbo_Pardakht";
			this.cmbo_Pardakht.Size = new System.Drawing.Size(69, 31);
			this.cmbo_Pardakht.TabIndex = 5;
			this.cmbo_Pardakht.Visible = false;
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.Location = new System.Drawing.Point(330, 35);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 26);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "نحوه پرداخت :";
			this.Label2.Visible = false;
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.Location = new System.Drawing.Point(26, 6);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(34, 26);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "ریال";
			this.txt_Takhfif.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Takhfif.Location = new System.Drawing.Point(63, 4);
			this.txt_Takhfif.Name = "txt_Takhfif";
			this.txt_Takhfif.Size = new System.Drawing.Size(95, 30);
			this.txt_Takhfif.TabIndex = 2;
			this.rdo_WithTakhfif.AutoSize = true;
			this.rdo_WithTakhfif.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.rdo_WithTakhfif.Location = new System.Drawing.Point(157, 2);
			this.rdo_WithTakhfif.Name = "rdo_WithTakhfif";
			this.rdo_WithTakhfif.Size = new System.Drawing.Size(75, 30);
			this.rdo_WithTakhfif.TabIndex = 1;
			this.rdo_WithTakhfif.Text = "با تخفیف";
			this.rdo_WithTakhfif.UseVisualStyleBackColor = true;
			this.rdo_NoTakhfif.AutoSize = true;
			this.rdo_NoTakhfif.Checked = true;
			this.rdo_NoTakhfif.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.rdo_NoTakhfif.Location = new System.Drawing.Point(319, 2);
			this.rdo_NoTakhfif.Name = "rdo_NoTakhfif";
			this.rdo_NoTakhfif.Size = new System.Drawing.Size(94, 30);
			this.rdo_NoTakhfif.TabIndex = 0;
			this.rdo_NoTakhfif.TabStop = true;
			this.rdo_NoTakhfif.Text = "بدون تخفیف";
			this.rdo_NoTakhfif.UseVisualStyleBackColor = true;
			this.txt_Ronevwsht.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Ronevwsht.Location = new System.Drawing.Point(20, 115);
			this.txt_Ronevwsht.Name = "txt_Ronevwsht";
			this.txt_Ronevwsht.Size = new System.Drawing.Size(407, 34);
			this.txt_Ronevwsht.TabIndex = 5;
			this.txt_Ronevwsht.Visible = false;
			this.txt_Karnam2.Font = new System.Drawing.Font("B Koodak", 11.25f, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_Karnam2.Location = new System.Drawing.Point(20, 78);
			this.txt_Karnam2.Name = "txt_Karnam2";
			this.txt_Karnam2.Size = new System.Drawing.Size(407, 34);
			this.txt_Karnam2.TabIndex = 3;
			this.txt_Karnam2.Visible = false;
			this.rdo_ArzeshAfzoode.AutoSize = true;
			this.rdo_ArzeshAfzoode.Font = new System.Drawing.Font("B Koodak", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.rdo_ArzeshAfzoode.Location = new System.Drawing.Point(501, 188);
			this.rdo_ArzeshAfzoode.Name = "rdo_ArzeshAfzoode";
			this.rdo_ArzeshAfzoode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdo_ArzeshAfzoode.Size = new System.Drawing.Size(122, 32);
			this.rdo_ArzeshAfzoode.TabIndex = 2;
			this.rdo_ArzeshAfzoode.Text = "فرم ارزش افزوده";
			this.rdo_ArzeshAfzoode.UseVisualStyleBackColor = true;
			this.rdo_Nameh.AutoSize = true;
			this.rdo_Nameh.Font = new System.Drawing.Font("B Koodak", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.rdo_Nameh.Location = new System.Drawing.Point(574, 100);
			this.rdo_Nameh.Name = "rdo_Nameh";
			this.rdo_Nameh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdo_Nameh.Size = new System.Drawing.Size(49, 32);
			this.rdo_Nameh.TabIndex = 1;
			this.rdo_Nameh.Text = "نامه";
			this.rdo_Nameh.UseVisualStyleBackColor = true;
			this.rdo_Nameh.Visible = false;
			this.rdo_Sanad.AutoSize = true;
			this.rdo_Sanad.Checked = true;
			this.rdo_Sanad.Font = new System.Drawing.Font("B Koodak", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.rdo_Sanad.Location = new System.Drawing.Point(572, 6);
			this.rdo_Sanad.Name = "rdo_Sanad";
			this.rdo_Sanad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rdo_Sanad.Size = new System.Drawing.Size(51, 32);
			this.rdo_Sanad.TabIndex = 0;
			this.rdo_Sanad.TabStop = true;
			this.rdo_Sanad.Text = "سند";
			this.rdo_Sanad.UseVisualStyleBackColor = true;
			this.lbl_Ronevwsht.AutoSize = true;
			this.lbl_Ronevwsht.Font = new System.Drawing.Font("B Koodak", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_Ronevwsht.Location = new System.Drawing.Point(425, 118);
			this.lbl_Ronevwsht.Name = "lbl_Ronevwsht";
			this.lbl_Ronevwsht.Size = new System.Drawing.Size(97, 28);
			this.lbl_Ronevwsht.TabIndex = 6;
			this.lbl_Ronevwsht.Text = "رونوشت نامه به :";
			this.lbl_Ronevwsht.Visible = false;
			this.lbl_Karnam2.AutoSize = true;
			this.lbl_Karnam2.Font = new System.Drawing.Font("B Koodak", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.lbl_Karnam2.Location = new System.Drawing.Point(425, 83);
			this.lbl_Karnam2.Name = "lbl_Karnam2";
			this.lbl_Karnam2.Size = new System.Drawing.Size(118, 28);
			this.lbl_Karnam2.TabIndex = 4;
			this.lbl_Karnam2.Text = "ادامه عنوان کارفرما :";
			this.lbl_Karnam2.Visible = false;
			base.AcceptButton = this.OK_Button;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			base.CancelButton = this.Cancel_Button;
			base.ClientSize = new System.Drawing.Size(748, 386);
			base.ControlBox = false;
			base.Controls.Add(this.Panel1);
			base.Controls.Add(this.TableLayoutPanel1);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frm_PrintDialog";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.ShowInTaskbar = false;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "پرینت";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			base.ResumeLayout(false);
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            this.rdo_Nameh.CheckedChanged += new System.EventHandler(this.rdo_Nameh_CheckedChanged);
            this.rdo_Nameh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Nameh_KeyDown);
            this.rdo_Sanad.CheckedChanged += new System.EventHandler(this.rdo_Sanad_CheckedChanged);
            this.rdo_Sanad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_Sanad_KeyDown);
            this.rdo_ArzeshAfzoode.CheckedChanged += new System.EventHandler(this.rdo_ArzeshAfzoode_CheckedChanged);
            this.rdo_ArzeshAfzoode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rdo_ArzeshAfzoode_KeyDown);
            this.txt_Ronevwsht.TextChanged += new System.EventHandler(this.txt_Ronevwsht_TextChanged);
            this.txt_Karnam2.TextChanged += new System.EventHandler(this.txt_Karnam2_TextChanged);
            this.rdo_WithTakhfif.CheckedChanged += new System.EventHandler(this.rdo_WithTakhfif_CheckedChanged);
            this.rdo_NoTakhfif.CheckedChanged += new System.EventHandler(this.rdo_NoTakhfif_CheckedChanged);
            this.cmbo_Pardakht.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbo_Pardakht_KeyPress);
        }

		private void OK_Button_Click(object sender, EventArgs e)
		{
			if (rdo_Sanad.Checked)
			{
				MyProject.Forms.Frm_AsnadDetail.PrintSanad();
			}
			if (rdo_Nameh.Checked)
			{
				MyProject.Forms.Frm_AsnadDetail.PrintNameh();
				if (Panel1.BackColor == Color.LightPink)
				{
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.CommandText = "UPDATE [dbo].[asnad1] SET [Karname2] = '" + txt_Karnam2.Text + "',[Ronevwsht] = '" + txt_Ronevwsht.Text + "' WHERE [sanadnum] ='" + Module1.SanadRec.sanadnum + "' And [Salmali]='" + Module1.SanadRec.SalMali + "' And [forpf]='" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [Soori]='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb]='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					Module1.cmd.ExecuteNonQuery();
					SetPanelBlue();
					Module1.SanadRec.karname2 = txt_Karnam2.Text;
					Module1.SanadRec.Ronevwsht = txt_Ronevwsht.Text;
				}
			}
			if (!rdo_ArzeshAfzoode.Checked)
			{
				return;
			}
			try
			{
				if ((Operators.CompareString(txt_Takhfif.Text, "", TextCompare: false) == 0) | rdo_NoTakhfif.Checked)
				{
					Module1.Takhfif = 0;
				}
				else
				{
					Module1.Takhfif = Conversions.ToInteger(txt_Takhfif.Text);
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				DialogResult dialogResult = MessageBox.Show(".مبلغ تخفیف درست وارد نشده است", "پیغام مهم", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txt_Takhfif.Focus();
				ProjectData.ClearProjectError();
				return;
			}
			MyProject.Forms.Frm_AsnadDetail.PrintArzeshAfzoode();
		}

		private void Cancel_Button_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			MyProject.Forms.Frm_AsnadDetail.txt_ItemNo.Focus();
			Close();
		}

		private void frm_Dialog1_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape)
			{
				Cancel_Button_Click(RuntimeHelpers.GetObjectValue(sender), e);
			}
		}

		private void frm_PrintDialog_Load(object sender, EventArgs e)
		{
			SetPanelBlue();
			cmbo_Pardakht.Items.Clear();
			cmbo_Pardakht.Items.Add("نقدی");
			cmbo_Pardakht.Items.Add("غیر نقدی");
			cmbo_Pardakht.Items.Add(" ");
			cmbo_Pardakht.Text = " ";
			rdo_NoTakhfif.Checked = true;
			txt_Takhfif.Text = "";
			rdo_Sanad.Checked = true;
			OK_Button.Focus();
		}

		private void rdo_Sanad_CheckedChanged(object sender, EventArgs e)
		{
			SetPanelBlue();
			if (rdo_Sanad.Checked)
			{
				lbl_Karnam2.Visible = false;
				lbl_Ronevwsht.Visible = false;
				txt_Karnam2.Visible = false;
				txt_Ronevwsht.Visible = false;
				Panel2.Visible = false;
				txt_Karnam2.Text = Module1.SanadRec.karname2;
				txt_Ronevwsht.Text = Module1.SanadRec.Ronevwsht;
			}
		}

		private void rdo_Sanad_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Down)
			{
				rdo_Nameh.Checked = true;
			}
		}

		private void rdo_Nameh_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_Nameh.Checked)
			{
				lbl_Karnam2.Visible = true;
				lbl_Ronevwsht.Visible = true;
				txt_Karnam2.Visible = true;
				txt_Ronevwsht.Visible = true;
				Panel2.Visible = false;
				txt_Karnam2.Text = Module1.SanadRec.karname2;
				txt_Ronevwsht.Text = Module1.SanadRec.Ronevwsht;
			}
		}

		private void rdo_Nameh_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				rdo_Sanad.Checked = true;
			}
			if (e.KeyCode == Keys.Down)
			{
				rdo_ArzeshAfzoode.Checked = true;
			}
		}

		private void rdo_ArzeshAfzoode_CheckedChanged(object sender, EventArgs e)
		{
			SetPanelBlue();
			if (rdo_ArzeshAfzoode.Checked)
			{
				lbl_Karnam2.Visible = false;
				lbl_Ronevwsht.Visible = false;
				txt_Karnam2.Visible = false;
				txt_Ronevwsht.Visible = false;
				Panel2.Visible = true;
			}
			foreach (DataGridViewRow item in (IEnumerable)MyProject.Forms.Frm_AsnadDetail.dtg_SanadSum.Rows)
			{
				if (item.Cells[3].Value.ToString().Contains("تخفيف"))
				{
					Type typeFromHandle = typeof(Math);
					DataGridViewCell dataGridViewCell;
					object[] obj = new object[1] { (dataGridViewCell = item.Cells[6]).Value };
					object[] array = obj;
					bool[] obj2 = new bool[1] { true };
					bool[] array2 = obj2;
					object value = NewLateBinding.LateGet(null, typeFromHandle, "Abs", obj, null, null, obj2);
					if (array2[0])
					{
						dataGridViewCell.Value = RuntimeHelpers.GetObjectValue(RuntimeHelpers.GetObjectValue(array[0]));
					}
					Module1.Takhfif = Conversions.ToInteger(value);
				}
				if (item.Cells[3].Value.ToString().Contains("ماليات"))
				{
					Module1.Maliat = Conversions.ToInteger(item.Cells[6].Value);
				}
			}
		}

		private void rdo_WithTakhfif_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_WithTakhfif.Checked)
			{
				txt_Takhfif.Visible = true;
				Label1.Visible = true;
				txt_Takhfif.Text = Conversions.ToString(Module1.Takhfif);
			}
		}

		private void rdo_NoTakhfif_CheckedChanged(object sender, EventArgs e)
		{
			if (rdo_NoTakhfif.Checked)
			{
				txt_Takhfif.Text = "";
				txt_Takhfif.Visible = false;
				Label1.Visible = false;
			}
		}

		private void rdo_ArzeshAfzoode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Up)
			{
				rdo_Nameh.Checked = true;
			}
		}

		private void txt_Karnam2_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_Karnam2.Text.Trim(), Module1.SanadRec.karname2.Trim(), TextCompare: false) != 0)
				{
					txt_Karnam2.ForeColor = Color.Red;
				}
				else
				{
					txt_Karnam2.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckNameChange();
		}

		private void txt_Ronevwsht_TextChanged(object sender, EventArgs e)
		{
			int lErl = default(int);
			try
			{
				if (Operators.CompareString(txt_Ronevwsht.Text.Trim(), Module1.SanadRec.Ronevwsht.Trim(), TextCompare: false) != 0)
				{
					txt_Ronevwsht.ForeColor = Color.Red;
				}
				else
				{
					txt_Ronevwsht.ForeColor = Color.Black;
				}
			}
			catch (NullReferenceException ex)
			{
				ProjectData.SetProjectError(ex, lErl);
				NullReferenceException ex2 = ex;
				ProjectData.ClearProjectError();
			}
			lErl = 10;
			CheckNameChange();
		}

		private void CheckNameChange()
		{
			foreach (object control in Panel1.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				object obj = NewLateBinding.LateGet(objectValue, null, "ForeColor", new object[0], null, null, null);
				if (((obj != null) ? ((Color)obj) : default(Color)) == Color.Red)
				{
					Panel1.BackColor = Color.LightPink;
					return;
				}
			}
			SetPanelBlue();
		}

		public void SetPanelBlue()
		{
			Panel1.BackColor = Color.WhiteSmoke;
			foreach (object control in Panel1.Controls)
			{
				object objectValue = RuntimeHelpers.GetObjectValue(control);
				NewLateBinding.LateSet(objectValue, null, "ForeColor", new object[1] { Color.Black }, null, null);
			}
		}

		private void cmbo_Pardakht_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
