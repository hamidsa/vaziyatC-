using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using GeoBaha.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.PowerPacks;

namespace GeoBaha
{
	[DesignerGenerated]
	public class frm_Factor_b : Form
	{
		private IContainer components;


        private System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Panel pnl_b;
        private System.Windows.Forms.RadioButton rdb_b_11;
        private System.Windows.Forms.RadioButton rdb_b_7;
        private System.Windows.Forms.RadioButton rdb_b_10;
        private System.Windows.Forms.RadioButton rdb_b_8;
        private System.Windows.Forms.RadioButton rdb_b_4;
        private System.Windows.Forms.RadioButton rdb_b_6;
        private System.Windows.Forms.RadioButton rdb_b_5;
        private System.Windows.Forms.RadioButton rdb_b_1;
        private System.Windows.Forms.RadioButton rdb_b_3;
        private System.Windows.Forms.RadioButton rdb_b_2;
        private System.Windows.Forms.RadioButton rdb_b_9;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Label Label11;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape RectangleShape1;

        public frm_Factor_b()
		{
			base.Load += frm_Factor_b_Load;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.frm_Factor_b));
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.pnl_b = new System.Windows.Forms.Panel();
			this.rdb_b_9 = new System.Windows.Forms.RadioButton();
			this.rdb_b_11 = new System.Windows.Forms.RadioButton();
			this.rdb_b_7 = new System.Windows.Forms.RadioButton();
			this.rdb_b_10 = new System.Windows.Forms.RadioButton();
			this.rdb_b_8 = new System.Windows.Forms.RadioButton();
			this.rdb_b_4 = new System.Windows.Forms.RadioButton();
			this.rdb_b_6 = new System.Windows.Forms.RadioButton();
			this.rdb_b_5 = new System.Windows.Forms.RadioButton();
			this.rdb_b_1 = new System.Windows.Forms.RadioButton();
			this.rdb_b_3 = new System.Windows.Forms.RadioButton();
			this.rdb_b_2 = new System.Windows.Forms.RadioButton();
			this.btn_Exit = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.RectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).BeginInit();
			this.pnl_b.SuspendLayout();
			base.SuspendLayout();
			this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
			this.PictureBox1.Location = new System.Drawing.Point(31, 31);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(695, 561);
			this.PictureBox1.TabIndex = 0;
			this.PictureBox1.TabStop = false;
			this.pnl_b.BackColor = System.Drawing.SystemColors.Control;
			this.pnl_b.Controls.Add(this.rdb_b_9);
			this.pnl_b.Controls.Add(this.rdb_b_11);
			this.pnl_b.Controls.Add(this.rdb_b_7);
			this.pnl_b.Controls.Add(this.rdb_b_10);
			this.pnl_b.Controls.Add(this.rdb_b_8);
			this.pnl_b.Controls.Add(this.rdb_b_4);
			this.pnl_b.Controls.Add(this.rdb_b_6);
			this.pnl_b.Controls.Add(this.rdb_b_5);
			this.pnl_b.Controls.Add(this.rdb_b_1);
			this.pnl_b.Controls.Add(this.rdb_b_3);
			this.pnl_b.Controls.Add(this.rdb_b_2);
			this.pnl_b.Location = new System.Drawing.Point(727, 85);
			this.pnl_b.Name = "pnl_b";
			this.pnl_b.Size = new System.Drawing.Size(16, 508);
			this.pnl_b.TabIndex = 6;
			this.rdb_b_9.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_9.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_9.Location = new System.Drawing.Point(0, 418);
			this.rdb_b_9.Name = "rdb_b_9";
			this.rdb_b_9.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_9.TabIndex = 18;
			this.rdb_b_9.TabStop = true;
			this.rdb_b_9.Text = "b=3.00";
			this.rdb_b_9.UseVisualStyleBackColor = false;
			this.rdb_b_11.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_11.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_11.Location = new System.Drawing.Point(0, 484);
			this.rdb_b_11.Name = "rdb_b_11";
			this.rdb_b_11.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_11.TabIndex = 17;
			this.rdb_b_11.TabStop = true;
			this.rdb_b_11.Text = "b=2.50";
			this.rdb_b_11.UseVisualStyleBackColor = false;
			this.rdb_b_7.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_7.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_7.Location = new System.Drawing.Point(0, 319);
			this.rdb_b_7.Name = "rdb_b_7";
			this.rdb_b_7.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_7.TabIndex = 16;
			this.rdb_b_7.TabStop = true;
			this.rdb_b_7.Text = "b=1.15";
			this.rdb_b_7.UseVisualStyleBackColor = false;
			this.rdb_b_10.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_10.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_10.Location = new System.Drawing.Point(0, 449);
			this.rdb_b_10.Name = "rdb_b_10";
			this.rdb_b_10.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_10.TabIndex = 15;
			this.rdb_b_10.TabStop = true;
			this.rdb_b_10.Text = "b=1.60";
			this.rdb_b_10.UseVisualStyleBackColor = false;
			this.rdb_b_8.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_8.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_8.Location = new System.Drawing.Point(0, 380);
			this.rdb_b_8.Name = "rdb_b_8";
			this.rdb_b_8.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_8.TabIndex = 14;
			this.rdb_b_8.TabStop = true;
			this.rdb_b_8.Text = "b=1.25";
			this.rdb_b_8.UseVisualStyleBackColor = false;
			this.rdb_b_4.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_4.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_4.Location = new System.Drawing.Point(0, 177);
			this.rdb_b_4.Name = "rdb_b_4";
			this.rdb_b_4.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_4.TabIndex = 13;
			this.rdb_b_4.TabStop = true;
			this.rdb_b_4.Text = "b=2.00";
			this.rdb_b_4.UseVisualStyleBackColor = false;
			this.rdb_b_6.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_6.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_6.Location = new System.Drawing.Point(0, 281);
			this.rdb_b_6.Name = "rdb_b_6";
			this.rdb_b_6.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_6.TabIndex = 12;
			this.rdb_b_6.TabStop = true;
			this.rdb_b_6.Text = "b=1.00";
			this.rdb_b_6.UseVisualStyleBackColor = false;
			this.rdb_b_5.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_5.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_5.Location = new System.Drawing.Point(0, 244);
			this.rdb_b_5.Name = "rdb_b_5";
			this.rdb_b_5.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_5.TabIndex = 11;
			this.rdb_b_5.TabStop = true;
			this.rdb_b_5.Text = "b=2.50";
			this.rdb_b_5.UseVisualStyleBackColor = false;
			this.rdb_b_1.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_1.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_1.Location = new System.Drawing.Point(0, 7);
			this.rdb_b_1.Name = "rdb_b_1";
			this.rdb_b_1.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_1.TabIndex = 10;
			this.rdb_b_1.TabStop = true;
			this.rdb_b_1.Text = "b=1.00";
			this.rdb_b_1.UseVisualStyleBackColor = false;
			this.rdb_b_3.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_3.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_3.Location = new System.Drawing.Point(0, 111);
			this.rdb_b_3.Name = "rdb_b_3";
			this.rdb_b_3.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_3.TabIndex = 9;
			this.rdb_b_3.TabStop = true;
			this.rdb_b_3.Text = "b=1.60";
			this.rdb_b_3.UseVisualStyleBackColor = false;
			this.rdb_b_2.BackColor = System.Drawing.SystemColors.Control;
			this.rdb_b_2.ForeColor = System.Drawing.Color.Black;
			this.rdb_b_2.Location = new System.Drawing.Point(0, 42);
			this.rdb_b_2.Name = "rdb_b_2";
			this.rdb_b_2.Size = new System.Drawing.Size(15, 18);
			this.rdb_b_2.TabIndex = 8;
			this.rdb_b_2.TabStop = true;
			this.rdb_b_2.Text = "b=1.25";
			this.rdb_b_2.UseVisualStyleBackColor = false;
			this.btn_Exit.Location = new System.Drawing.Point(44, 610);
			this.btn_Exit.Name = "btn_Exit";
			this.btn_Exit.Size = new System.Drawing.Size(75, 23);
			this.btn_Exit.TabIndex = 8;
			this.btn_Exit.Text = "خروج";
			this.btn_Exit.UseVisualStyleBackColor = true;
			this.Label1.BackColor = System.Drawing.Color.White;
			this.Label1.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label1.Location = new System.Drawing.Point(650, 89);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(70, 23);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "b = 1.00";
			this.Label2.BackColor = System.Drawing.Color.White;
			this.Label2.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label2.Location = new System.Drawing.Point(650, 125);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label2.Size = new System.Drawing.Size(70, 23);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "b = 1.25";
			this.Label3.BackColor = System.Drawing.Color.White;
			this.Label3.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label3.Location = new System.Drawing.Point(650, 194);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(70, 23);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "b = 1.60";
			this.Label4.BackColor = System.Drawing.Color.White;
			this.Label4.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label4.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label4.Location = new System.Drawing.Point(650, 260);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label4.Size = new System.Drawing.Size(70, 23);
			this.Label4.TabIndex = 12;
			this.Label4.Text = "b = 2.00";
			this.Label5.BackColor = System.Drawing.Color.White;
			this.Label5.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label5.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label5.Location = new System.Drawing.Point(650, 327);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label5.Size = new System.Drawing.Size(70, 23);
			this.Label5.TabIndex = 13;
			this.Label5.Text = "b = 2.50";
			this.Label6.BackColor = System.Drawing.Color.White;
			this.Label6.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label6.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label6.Location = new System.Drawing.Point(650, 364);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label6.Size = new System.Drawing.Size(70, 23);
			this.Label6.TabIndex = 14;
			this.Label6.Text = "b = 1.00";
			this.Label7.BackColor = System.Drawing.Color.White;
			this.Label7.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label7.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label7.Location = new System.Drawing.Point(650, 401);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label7.Size = new System.Drawing.Size(70, 23);
			this.Label7.TabIndex = 15;
			this.Label7.Text = "b = 1.15";
			this.Label8.BackColor = System.Drawing.Color.White;
			this.Label8.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label8.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label8.Location = new System.Drawing.Point(650, 463);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label8.Size = new System.Drawing.Size(70, 23);
			this.Label8.TabIndex = 16;
			this.Label8.Text = "b = 1.25";
			this.Label9.BackColor = System.Drawing.Color.White;
			this.Label9.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label9.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label9.Location = new System.Drawing.Point(650, 501);
			this.Label9.Name = "Label9";
			this.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label9.Size = new System.Drawing.Size(70, 23);
			this.Label9.TabIndex = 17;
			this.Label9.Text = "b = 3.00";
			this.Label10.BackColor = System.Drawing.Color.White;
			this.Label10.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label10.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label10.Location = new System.Drawing.Point(650, 530);
			this.Label10.Name = "Label10";
			this.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label10.Size = new System.Drawing.Size(70, 23);
			this.Label10.TabIndex = 18;
			this.Label10.Text = "b = 1.60";
			this.Label11.BackColor = System.Drawing.Color.White;
			this.Label11.Font = new System.Drawing.Font("Times New Roman", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label11.ForeColor = System.Drawing.Color.FromArgb(64, 64, 64);
			this.Label11.Location = new System.Drawing.Point(650, 568);
			this.Label11.Name = "Label11";
			this.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label11.Size = new System.Drawing.Size(70, 23);
			this.Label11.TabIndex = 19;
			this.Label11.Text = "b = 2.50";
			this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer1.Name = "ShapeContainer1";
			this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[1] { this.RectangleShape1 });
			this.ShapeContainer1.Size = new System.Drawing.Size(777, 649);
			this.ShapeContainer1.TabIndex = 7;
			this.ShapeContainer1.TabStop = false;
			this.RectangleShape1.BorderWidth = 2;
			this.RectangleShape1.Location = new System.Drawing.Point(31, 29);
			this.RectangleShape1.Name = "RectangleShape1";
			this.RectangleShape1.Size = new System.Drawing.Size(695, 564);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(777, 649);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_b);
			base.Controls.Add(this.Label11);
			base.Controls.Add(this.Label10);
			base.Controls.Add(this.Label9);
			base.Controls.Add(this.Label8);
			base.Controls.Add(this.Label7);
			base.Controls.Add(this.Label6);
			base.Controls.Add(this.Label5);
			base.Controls.Add(this.Label4);
			base.Controls.Add(this.Label3);
			base.Controls.Add(this.Label2);
			base.Controls.Add(this.Label1);
			base.Controls.Add(this.btn_Exit);
			base.Controls.Add(this.PictureBox1);
			base.Controls.Add(this.ShapeContainer1);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frm_Factor_b";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ضریب b";
			((System.ComponentModel.ISupportInitialize)this.PictureBox1).EndInit();
			this.pnl_b.ResumeLayout(false);
			base.ResumeLayout(false);

            this.rdb_b_11.CheckedChanged += new System.EventHandler(this.rdb_b_11_CheckedChanged);
            this.rdb_b_7.CheckedChanged += new System.EventHandler(this.rdb_b_7_CheckedChanged);
            this.rdb_b_10.CheckedChanged += new System.EventHandler(this.rdb_b_10_CheckedChanged);
            this.rdb_b_8.CheckedChanged += new System.EventHandler(this.rdb_b_8_CheckedChanged);
            this.rdb_b_4.CheckedChanged += new System.EventHandler(this.rdb_b_4_CheckedChanged);
            this.rdb_b_6.CheckedChanged += new System.EventHandler(this.rdb_b_6_CheckedChanged);
            this.rdb_b_5.CheckedChanged += new System.EventHandler(this.rdb_b_5_CheckedChanged);
            this.rdb_b_1.CheckedChanged += new System.EventHandler(this.rdb_b_1_CheckedChanged);
            this.rdb_b_3.CheckedChanged += new System.EventHandler(this.rdb_b_3_CheckedChanged);
            this.rdb_b_2.CheckedChanged += new System.EventHandler(this.rdb_b_2_CheckedChanged);
            this.rdb_b_9.CheckedChanged += new System.EventHandler(this.rdb_b_9_CheckedChanged);
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
        }

		private void frm_Factor_b_Load(object sender, EventArgs e)
		{
			base.TopMost = false;
			foreach (Control control in base.Controls)
			{
				if (!(control is Panel))
				{
					continue;
				}
				foreach (RadioButton control2 in control.Controls)
				{
					if (control is RadioButton && Operators.CompareString(control2.Text.Substring(2, 4).Trim(), Module1.b_Factor.Trim(), TextCompare: false) == 0)
					{
						control2.Checked = true;
					}
				}
			}
		}

		private void btn_Exit_Click(object sender, EventArgs e)
		{
			foreach (Control control in base.Controls)
			{
				if (!(control is Panel))
				{
					continue;
				}
				foreach (RadioButton control2 in control.Controls)
				{
					if (control2.Checked)
					{
						Module1.b_Factor = control2.Text.Substring(2, 4).Trim();
					}
				}
			}
			if (Module1.FactorHasRow == 1)
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "UPDATE [dbo].[Factors40401]SET [b] = '" + Module1.b_Factor + "' Where [SanadNo]='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
				Module1.cmd.ExecuteNonQuery();
			}
			else
			{
				if (Module1.MyConn.State == ConnectionState.Closed)
				{
					Module1.MyConn.Open();
				}
				Module1.cmd.Connection = Module1.MyConn;
				Module1.cmd.CommandText = "INSERT INTO [dbo].[Factors40401] ([SanadNo],[a1],[a2],[a3],[a4],[a5],[a6],[a7],[a8],[b],[fopf],[SalMali],[Soori],[Ghaleb],[Eslah],[EslahTime]) VALUES ('" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "','" + Module1.a1_Factor + "','" + Module1.a2_Factor + "','" + Module1.a3_Factor + "','" + Module1.a4_Factor + "','" + Module1.a5_Factor + "','" + Module1.a6_Factor + "','" + Module1.a7_Factor + "','" + Module1.a8_Factor + "','" + Module1.b_Factor + "','" + Conversions.ToString(Module1.SanadRec.forpf) + "','" + Module1.SanadRec.SalMali + "','" + Conversions.ToString(Module1.SanadRec.Soori) + "','" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "','" + Environment.MachineName + "','')";
				Module1.cmd.ExecuteNonQuery();
				Module1.FactorHasRow = 1;
			}
			MyProject.Forms.Frm_Calculate.txt_b.Text = Module1.b_Factor;
			Close();
		}

		private void rdb_b_1_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_1.Checked)
			{
				Module1.b_Factor = rdb_b_1.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_2_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_2.Checked)
			{
				Module1.b_Factor = rdb_b_2.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_3_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_3.Checked)
			{
				Module1.b_Factor = rdb_b_3.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_4_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_4.Checked)
			{
				Module1.b_Factor = rdb_b_4.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_5_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_5.Checked)
			{
				Module1.b_Factor = rdb_b_5.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_6_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_6.Checked)
			{
				Module1.b_Factor = rdb_b_6.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_7_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_7.Checked)
			{
				Module1.b_Factor = rdb_b_7.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_8_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_8.Checked)
			{
				Module1.b_Factor = rdb_b_8.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_9_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_9.Checked)
			{
				Module1.b_Factor = rdb_b_9.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_10_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_10.Checked)
			{
				Module1.b_Factor = rdb_b_10.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}

		private void rdb_b_11_CheckedChanged(object sender, EventArgs e)
		{
			if (rdb_b_11.Checked)
			{
				Module1.b_Factor = rdb_b_11.Text.Substring(2, 4).Trim();
				MyProject.Forms.Frm_Calculate.txt_b.Text = Strings.Format(Conversions.ToSingle(Module1.b_Factor), "###0.00");
			}
		}
	}
}
