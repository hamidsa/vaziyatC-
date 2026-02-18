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
	public class Frm_Calculate : Form
	{
		private IContainer components;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_40101B")]
		private TextBox _txt_40101B;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("Txt_D")]
		private TextBox _Txt_D;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_rs")]
		private TextBox _txt_rs;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_b")]
		private TextBox _txt_b;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_S")]
		private TextBox _txt_S;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_a")]
		private TextBox _txt_a;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("txt_k1")]
		private TextBox _txt_k1;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Find_a")]
		private Button _btn_Find_a;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Ok")]
		private Button _btn_Ok;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Cancel")]
		private Button _btn_Cancel;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chk_40201")]
		private CheckBox _chk_40201;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chk_40301")]
		private CheckBox _chk_40301;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("chk_40401")]
		private CheckBox _chk_40401;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[AccessedThroughProperty("btn_Find_b")]
		private Button _btn_Find_b;

		public double k1;

        private System.Windows.Forms.Panel pnl_40101;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txt_40101B;
        private System.Windows.Forms.TextBox Txt_D;
        private System.Windows.Forms.TextBox txt_rs;
        private System.Windows.Forms.Panel pnl_40201;
        private System.Windows.Forms.TextBox txt_40201B;
        private System.Windows.Forms.TextBox txt_F;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel pnl_40301;
        private System.Windows.Forms.TextBox txt_L;
        private System.Windows.Forms.Label Label12;
        private System.Windows.Forms.Panel pnl_40401;
        internal System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label Label21;
        private System.Windows.Forms.Label Label20;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.Label Label13;
        private System.Windows.Forms.TextBox txt_40401B;
        internal System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.TextBox txt_k1;
        private System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label Label17;
        private System.Windows.Forms.Label Label18;
        private System.Windows.Forms.Label Label19;
        private System.Windows.Forms.Button btn_Find_a;
        private System.Windows.Forms.Panel pnl_Command;
        private System.Windows.Forms.Button btn_Ok;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_40101C2;
        private System.Windows.Forms.TextBox txt_40101C1;
        private System.Windows.Forms.Label Label6;
        private System.Windows.Forms.TextBox txt_40201C1;
        private System.Windows.Forms.TextBox txt_40201C2;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.TextBox txt_40301C1;
        private System.Windows.Forms.TextBox txt_40301C2;
        private System.Windows.Forms.Label Label9;
        private System.Windows.Forms.Label Label11;
        private System.Windows.Forms.TextBox txt_40301B;
        private System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.CheckBox chk_40201;
        internal System.Windows.Forms.CheckBox chk_40301;
        private System.Windows.Forms.TextBox txt_Fasl_3;
        private System.Windows.Forms.Label Label22;
        private System.Windows.Forms.TextBox txt_Fasl_6;
        private System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.CheckBox chk_40401;
        private System.Windows.Forms.Button btn_Find_b;
        public Frm_Calculate()
		{
			k1 = 0.0;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeoBaha.Frm_Calculate));
			this.pnl_40101 = new System.Windows.Forms.Panel();
			this.txt_40101C2 = new System.Windows.Forms.TextBox();
			this.txt_40101C1 = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txt_40101B = new System.Windows.Forms.TextBox();
			this.Txt_D = new System.Windows.Forms.TextBox();
			this.txt_rs = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.pnl_40201 = new System.Windows.Forms.Panel();
			this.chk_40201 = new System.Windows.Forms.CheckBox();
			this.txt_40201C1 = new System.Windows.Forms.TextBox();
			this.txt_40201C2 = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.txt_40201B = new System.Windows.Forms.TextBox();
			this.txt_F = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label10 = new System.Windows.Forms.Label();
			this.pnl_40301 = new System.Windows.Forms.Panel();
			this.txt_Fasl_3 = new System.Windows.Forms.TextBox();
			this.Label22 = new System.Windows.Forms.Label();
			this.txt_Fasl_6 = new System.Windows.Forms.TextBox();
			this.Label15 = new System.Windows.Forms.Label();
			this.chk_40301 = new System.Windows.Forms.CheckBox();
			this.txt_40301C1 = new System.Windows.Forms.TextBox();
			this.txt_40301C2 = new System.Windows.Forms.TextBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txt_40301B = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.txt_L = new System.Windows.Forms.TextBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.pnl_40401 = new System.Windows.Forms.Panel();
			this.chk_40401 = new System.Windows.Forms.CheckBox();
			this.btn_Find_b = new System.Windows.Forms.Button();
			this.btn_Find_a = new System.Windows.Forms.Button();
			this.txt_b = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.Label20 = new System.Windows.Forms.Label();
			this.txt_S = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.txt_40401B = new System.Windows.Forms.TextBox();
			this.txt_a = new System.Windows.Forms.TextBox();
			this.txt_k1 = new System.Windows.Forms.TextBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.Label19 = new System.Windows.Forms.Label();
			this.pnl_Command = new System.Windows.Forms.Panel();
			this.btn_Ok = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.pnl_40101.SuspendLayout();
			this.pnl_40201.SuspendLayout();
			this.pnl_40301.SuspendLayout();
			this.pnl_40401.SuspendLayout();
			this.pnl_Command.SuspendLayout();
			base.SuspendLayout();
			this.pnl_40101.Controls.Add(this.txt_40101C2);
			this.pnl_40101.Controls.Add(this.txt_40101C1);
			this.pnl_40101.Controls.Add(this.Label6);
			this.pnl_40101.Controls.Add(this.txt_40101B);
			this.pnl_40101.Controls.Add(this.Txt_D);
			this.pnl_40101.Controls.Add(this.txt_rs);
			this.pnl_40101.Controls.Add(this.Label4);
			this.pnl_40101.Controls.Add(this.Label3);
			this.pnl_40101.Controls.Add(this.Label2);
			this.pnl_40101.Controls.Add(this.Label1);
			this.pnl_40101.Location = new System.Drawing.Point(28, 26);
			this.pnl_40101.Name = "pnl_40101";
			this.pnl_40101.Size = new System.Drawing.Size(481, 90);
			this.pnl_40101.TabIndex = 0;
			this.txt_40101C2.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40101C2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40101C2.ForeColor = System.Drawing.Color.Blue;
			this.txt_40101C2.Location = new System.Drawing.Point(188, 17);
			this.txt_40101C2.Name = "txt_40101C2";
			this.txt_40101C2.Size = new System.Drawing.Size(41, 13);
			this.txt_40101C2.TabIndex = 12;
			this.txt_40101C2.Text = "123000";
			this.txt_40101C1.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40101C1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40101C1.ForeColor = System.Drawing.Color.Blue;
			this.txt_40101C1.Location = new System.Drawing.Point(121, 17);
			this.txt_40101C1.Name = "txt_40101C1";
			this.txt_40101C1.Size = new System.Drawing.Size(52, 13);
			this.txt_40101C1.TabIndex = 11;
			this.txt_40101C1.Text = "11740000";
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(174, 17);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(13, 13);
			this.Label6.TabIndex = 9;
			this.Label6.Text = "+";
			this.txt_40101B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_40101B.ForeColor = System.Drawing.Color.Red;
			this.txt_40101B.Location = new System.Drawing.Point(332, 13);
			this.txt_40101B.Name = "txt_40101B";
			this.txt_40101B.Size = new System.Drawing.Size(90, 20);
			this.txt_40101B.TabIndex = 7;
			this.Txt_D.Location = new System.Drawing.Point(357, 50);
			this.Txt_D.Name = "Txt_D";
			this.Txt_D.Size = new System.Drawing.Size(90, 20);
			this.Txt_D.TabIndex = 6;
			this.txt_rs.Enabled = false;
			this.txt_rs.Location = new System.Drawing.Point(134, 50);
			this.txt_rs.Name = "txt_rs";
			this.txt_rs.Size = new System.Drawing.Size(57, 20);
			this.txt_rs.TabIndex = 5;
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(235, 53);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(123, 13);
			this.Label4.TabIndex = 3;
			this.Label4.Text = "= مجموع عمق حفاری (D) ";
			this.Label3.AutoSize = true;
			this.Label3.Location = new System.Drawing.Point(26, 53);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(119, 13);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "=  ضریب منطقه ای  ( rs ) ";
			this.Label2.ForeColor = System.Drawing.Color.Blue;
			this.Label2.Location = new System.Drawing.Point(229, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(100, 13);
			this.Label2.TabIndex = 1;
			this.Label2.Text = " = * ( 1 + rs ) / 2 * D";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Label1.AutoSize = true;
			this.Label1.ForeColor = System.Drawing.Color.Blue;
			this.Label1.Location = new System.Drawing.Point(59, 16);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(64, 13);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "=بهای واحد ";
			this.pnl_40201.Controls.Add(this.chk_40201);
			this.pnl_40201.Controls.Add(this.txt_40201C1);
			this.pnl_40201.Controls.Add(this.txt_40201C2);
			this.pnl_40201.Controls.Add(this.Label5);
			this.pnl_40201.Controls.Add(this.Label8);
			this.pnl_40201.Controls.Add(this.txt_40201B);
			this.pnl_40201.Controls.Add(this.txt_F);
			this.pnl_40201.Controls.Add(this.Label7);
			this.pnl_40201.Controls.Add(this.Label10);
			this.pnl_40201.Location = new System.Drawing.Point(28, 131);
			this.pnl_40201.Name = "pnl_40201";
			this.pnl_40201.Size = new System.Drawing.Size(481, 90);
			this.pnl_40201.TabIndex = 1;
			this.chk_40201.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chk_40201.Location = new System.Drawing.Point(73, 52);
			this.chk_40201.Name = "chk_40201";
			this.chk_40201.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chk_40201.Size = new System.Drawing.Size(138, 17);
			this.chk_40201.TabIndex = 17;
			this.chk_40201.Text = "با اعمال ضریب منطقه ای";
			this.chk_40201.UseVisualStyleBackColor = true;
			this.txt_40201C1.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40201C1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40201C1.ForeColor = System.Drawing.Color.Blue;
			this.txt_40201C1.Location = new System.Drawing.Point(168, 17);
			this.txt_40201C1.Name = "txt_40201C1";
			this.txt_40201C1.Size = new System.Drawing.Size(50, 13);
			this.txt_40201C1.TabIndex = 16;
			this.txt_40201C1.Text = "4370000";
			this.txt_40201C2.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40201C2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40201C2.ForeColor = System.Drawing.Color.Blue;
			this.txt_40201C2.Location = new System.Drawing.Point(229, 17);
			this.txt_40201C2.Name = "txt_40201C2";
			this.txt_40201C2.Size = new System.Drawing.Size(23, 13);
			this.txt_40201C2.TabIndex = 15;
			this.txt_40201C2.Text = "0.05";
			this.Label5.AutoSize = true;
			this.Label5.ForeColor = System.Drawing.Color.Blue;
			this.Label5.Location = new System.Drawing.Point(215, 17);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(13, 13);
			this.Label5.TabIndex = 14;
			this.Label5.Text = "+";
			this.Label8.ForeColor = System.Drawing.Color.Blue;
			this.Label8.Location = new System.Drawing.Point(252, 17);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(32, 13);
			this.Label8.TabIndex = 13;
			this.Label8.Text = "= * F ";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txt_40201B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_40201B.ForeColor = System.Drawing.Color.Red;
			this.txt_40201B.Location = new System.Drawing.Point(287, 14);
			this.txt_40201B.Name = "txt_40201B";
			this.txt_40201B.Size = new System.Drawing.Size(90, 20);
			this.txt_40201B.TabIndex = 7;
			this.txt_F.Location = new System.Drawing.Point(309, 50);
			this.txt_F.Name = "txt_F";
			this.txt_F.Size = new System.Drawing.Size(90, 20);
			this.txt_F.TabIndex = 6;
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(211, 53);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(107, 13);
			this.Label7.TabIndex = 3;
			this.Label7.Text = "= مجموع فصل 2 ( F )  ";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Label10.AutoSize = true;
			this.Label10.ForeColor = System.Drawing.Color.Blue;
			this.Label10.Location = new System.Drawing.Point(103, 16);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(64, 13);
			this.Label10.TabIndex = 0;
			this.Label10.Text = "=بهای واحد ";
			this.pnl_40301.Controls.Add(this.txt_Fasl_3);
			this.pnl_40301.Controls.Add(this.Label22);
			this.pnl_40301.Controls.Add(this.txt_Fasl_6);
			this.pnl_40301.Controls.Add(this.Label15);
			this.pnl_40301.Controls.Add(this.chk_40301);
			this.pnl_40301.Controls.Add(this.txt_40301C1);
			this.pnl_40301.Controls.Add(this.txt_40301C2);
			this.pnl_40301.Controls.Add(this.Label9);
			this.pnl_40301.Controls.Add(this.Label11);
			this.pnl_40301.Controls.Add(this.txt_40301B);
			this.pnl_40301.Controls.Add(this.Label14);
			this.pnl_40301.Controls.Add(this.txt_L);
			this.pnl_40301.Controls.Add(this.Label12);
			this.pnl_40301.Location = new System.Drawing.Point(28, 236);
			this.pnl_40301.Name = "pnl_40301";
			this.pnl_40301.Size = new System.Drawing.Size(481, 155);
			this.pnl_40301.TabIndex = 2;
			this.txt_Fasl_3.Location = new System.Drawing.Point(286, 50);
			this.txt_Fasl_3.Name = "txt_Fasl_3";
			this.txt_Fasl_3.Size = new System.Drawing.Size(90, 20);
			this.txt_Fasl_3.TabIndex = 27;
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(201, 53);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(86, 13);
			this.Label22.TabIndex = 26;
			this.Label22.Text = " = مجموع فصل 3 ";
			this.txt_Fasl_6.Location = new System.Drawing.Point(286, 76);
			this.txt_Fasl_6.Name = "txt_Fasl_6";
			this.txt_Fasl_6.Size = new System.Drawing.Size(90, 20);
			this.txt_Fasl_6.TabIndex = 25;
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(197, 79);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(89, 13);
			this.Label15.TabIndex = 24;
			this.Label15.Text = "= مجموع فصل 6   ";
			this.chk_40301.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chk_40301.Location = new System.Drawing.Point(57, 78);
			this.chk_40301.Name = "chk_40301";
			this.chk_40301.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chk_40301.Size = new System.Drawing.Size(138, 17);
			this.chk_40301.TabIndex = 23;
			this.chk_40301.Text = "با اعمال ضریب منطقه ای";
			this.chk_40301.UseVisualStyleBackColor = true;
			this.txt_40301C1.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40301C1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40301C1.ForeColor = System.Drawing.Color.Blue;
			this.txt_40301C1.Location = new System.Drawing.Point(167, 16);
			this.txt_40301C1.Name = "txt_40301C1";
			this.txt_40301C1.Size = new System.Drawing.Size(50, 13);
			this.txt_40301C1.TabIndex = 22;
			this.txt_40301C1.Text = "1531000";
			this.txt_40301C2.BackColor = System.Drawing.SystemColors.Control;
			this.txt_40301C2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txt_40301C2.ForeColor = System.Drawing.Color.Blue;
			this.txt_40301C2.Location = new System.Drawing.Point(228, 16);
			this.txt_40301C2.Name = "txt_40301C2";
			this.txt_40301C2.Size = new System.Drawing.Size(23, 13);
			this.txt_40301C2.TabIndex = 21;
			this.txt_40301C2.Text = "0.07";
			this.Label9.AutoSize = true;
			this.Label9.ForeColor = System.Drawing.Color.Blue;
			this.Label9.Location = new System.Drawing.Point(214, 16);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(13, 13);
			this.Label9.TabIndex = 20;
			this.Label9.Text = "+";
			this.Label11.ForeColor = System.Drawing.Color.Blue;
			this.Label11.Location = new System.Drawing.Point(251, 16);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(32, 13);
			this.Label11.TabIndex = 19;
			this.Label11.Text = "= * L ";
			this.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.txt_40301B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_40301B.ForeColor = System.Drawing.Color.Red;
			this.txt_40301B.Location = new System.Drawing.Point(286, 13);
			this.txt_40301B.Name = "txt_40301B";
			this.txt_40301B.Size = new System.Drawing.Size(90, 20);
			this.txt_40301B.TabIndex = 18;
			this.Label14.AutoSize = true;
			this.Label14.ForeColor = System.Drawing.Color.Blue;
			this.Label14.Location = new System.Drawing.Point(102, 15);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(64, 13);
			this.Label14.TabIndex = 17;
			this.Label14.Text = " =بهای واحد";
			this.txt_L.Location = new System.Drawing.Point(286, 102);
			this.txt_L.Name = "txt_L";
			this.txt_L.Size = new System.Drawing.Size(90, 20);
			this.txt_L.TabIndex = 6;
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(157, 105);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(128, 13);
			this.Label12.TabIndex = 3;
			this.Label12.Text = "= مجموع فصول 3 و 6  ( L )";
			this.pnl_40401.Controls.Add(this.chk_40401);
			this.pnl_40401.Controls.Add(this.btn_Find_b);
			this.pnl_40401.Controls.Add(this.btn_Find_a);
			this.pnl_40401.Controls.Add(this.txt_b);
			this.pnl_40401.Controls.Add(this.Label21);
			this.pnl_40401.Controls.Add(this.Label20);
			this.pnl_40401.Controls.Add(this.txt_S);
			this.pnl_40401.Controls.Add(this.Label13);
			this.pnl_40401.Controls.Add(this.txt_40401B);
			this.pnl_40401.Controls.Add(this.txt_a);
			this.pnl_40401.Controls.Add(this.txt_k1);
			this.pnl_40401.Controls.Add(this.Label16);
			this.pnl_40401.Controls.Add(this.Label17);
			this.pnl_40401.Controls.Add(this.Label18);
			this.pnl_40401.Controls.Add(this.Label19);
			this.pnl_40401.Location = new System.Drawing.Point(28, 397);
			this.pnl_40401.Name = "pnl_40401";
			this.pnl_40401.Size = new System.Drawing.Size(481, 167);
			this.pnl_40401.TabIndex = 3;
			this.chk_40401.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.chk_40401.Location = new System.Drawing.Point(59, 49);
			this.chk_40401.Name = "chk_40401";
			this.chk_40401.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chk_40401.Size = new System.Drawing.Size(138, 17);
			this.chk_40401.TabIndex = 210;
			this.chk_40401.Text = "با اعمال ضریب منطقه ای";
			this.chk_40401.UseVisualStyleBackColor = true;
			this.btn_Find_b.BackColor = System.Drawing.Color.LightGray;
			this.btn_Find_b.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Find_b.ForeColor = System.Drawing.Color.Black;
			this.btn_Find_b.Image = (System.Drawing.Image)resources.GetObject("btn_Find_b.Image");
			this.btn_Find_b.Location = new System.Drawing.Point(439, 126);
			this.btn_Find_b.Name = "btn_Find_b";
			this.btn_Find_b.Size = new System.Drawing.Size(24, 24);
			this.btn_Find_b.TabIndex = 209;
			this.btn_Find_b.UseVisualStyleBackColor = false;
			this.btn_Find_a.BackColor = System.Drawing.Color.LightGray;
			this.btn_Find_a.Font = new System.Drawing.Font("Times New Roman", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.btn_Find_a.ForeColor = System.Drawing.Color.Black;
			this.btn_Find_a.Image = (System.Drawing.Image)resources.GetObject("btn_Find_a.Image");
			this.btn_Find_a.Location = new System.Drawing.Point(439, 99);
			this.btn_Find_a.Name = "btn_Find_a";
			this.btn_Find_a.Size = new System.Drawing.Size(24, 24);
			this.btn_Find_a.TabIndex = 208;
			this.btn_Find_a.UseVisualStyleBackColor = false;
			this.txt_b.Location = new System.Drawing.Point(349, 128);
			this.txt_b.Name = "txt_b";
			this.txt_b.Size = new System.Drawing.Size(90, 20);
			this.txt_b.TabIndex = 12;
			this.Label21.AutoSize = true;
			this.Label21.Location = new System.Drawing.Point(2, 131);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(349, 13);
			this.Label21.TabIndex = 11;
			this.Label21.Text = "=ضریب مربوط به مستحدثات از جدول 4 بخش اول فهرست بهای ژئوتکنیک ( b )";
			this.Label20.AutoSize = true;
			this.Label20.Location = new System.Drawing.Point(172, 104);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(57, 13);
			this.Label20.TabIndex = 10;
			this.Label20.Text = "( a8 تا a1 )";
			this.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.txt_S.Location = new System.Drawing.Point(349, 47);
			this.txt_S.Name = "txt_S";
			this.txt_S.Size = new System.Drawing.Size(90, 20);
			this.txt_S.TabIndex = 9;
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(202, 50);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(149, 13);
			this.Label13.TabIndex = 8;
			this.Label13.Text = "= مجموع فصول 1 ، 2 و 3 ( S )  ";
			this.txt_40401B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_40401B.ForeColor = System.Drawing.Color.Red;
			this.txt_40401B.Location = new System.Drawing.Point(260, 11);
			this.txt_40401B.Name = "txt_40401B";
			this.txt_40401B.Size = new System.Drawing.Size(90, 20);
			this.txt_40401B.TabIndex = 7;
			this.txt_a.Location = new System.Drawing.Point(349, 101);
			this.txt_a.Name = "txt_a";
			this.txt_a.Size = new System.Drawing.Size(90, 20);
			this.txt_a.TabIndex = 6;
			this.txt_k1.Location = new System.Drawing.Point(349, 74);
			this.txt_k1.Name = "txt_k1";
			this.txt_k1.Size = new System.Drawing.Size(90, 20);
			this.txt_k1.TabIndex = 5;
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(244, 104);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(106, 13);
			this.Label16.TabIndex = 3;
			this.Label16.Text = "=حاصل ضرب ضرایب a";
			this.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(46, 77);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(305, 13);
			this.Label17.TabIndex = 2;
			this.Label17.Text = "=ضریب حق الزحمه جدول 1 بخش اول فهرست بهای ژئوتکنیک ( k1 ) ";
			this.Label18.AutoSize = true;
			this.Label18.ForeColor = System.Drawing.Color.Blue;
			this.Label18.Location = new System.Drawing.Point(193, 14);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(65, 13);
			this.Label18.TabIndex = 1;
			this.Label18.Text = "=k1 .a .b .S ";
			this.Label19.AutoSize = true;
			this.Label19.ForeColor = System.Drawing.Color.Blue;
			this.Label19.Location = new System.Drawing.Point(127, 13);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(64, 13);
			this.Label19.TabIndex = 0;
			this.Label19.Text = "=بهای واحد ";
			this.pnl_Command.Controls.Add(this.btn_Ok);
			this.pnl_Command.Controls.Add(this.btn_Cancel);
			this.pnl_Command.Location = new System.Drawing.Point(109, 577);
			this.pnl_Command.Name = "pnl_Command";
			this.pnl_Command.Size = new System.Drawing.Size(321, 31);
			this.pnl_Command.TabIndex = 6;
			this.btn_Ok.Location = new System.Drawing.Point(242, 4);
			this.btn_Ok.Name = "btn_Ok";
			this.btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.btn_Ok.TabIndex = 6;
			this.btn_Ok.Text = "Ok";
			this.btn_Ok.UseVisualStyleBackColor = true;
			this.btn_Cancel.Location = new System.Drawing.Point(3, 4);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.btn_Cancel.TabIndex = 5;
			this.btn_Cancel.Text = "Cancel";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(538, 620);
			base.ControlBox = false;
			base.Controls.Add(this.pnl_Command);
			base.Controls.Add(this.pnl_40401);
			base.Controls.Add(this.pnl_40301);
			base.Controls.Add(this.pnl_40201);
			base.Controls.Add(this.pnl_40101);
			base.Name = "Frm_Calculate";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "محاسبات";
			this.pnl_40101.ResumeLayout(false);
			this.pnl_40101.PerformLayout();
			this.pnl_40201.ResumeLayout(false);
			this.pnl_40201.PerformLayout();
			this.pnl_40301.ResumeLayout(false);
			this.pnl_40301.PerformLayout();
			this.pnl_40401.ResumeLayout(false);
			this.pnl_40401.PerformLayout();
			this.pnl_Command.ResumeLayout(false);
			base.ResumeLayout(false);


            this.txt_40101B.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_40101B_KeyUp);
            this.Txt_D.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Txt_D_KeyUp);
            this.txt_rs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_rs_KeyUp);
            this.txt_b.TextChanged += new System.EventHandler(this.txt_b_TextChanged);
            this.txt_S.TextChanged += new System.EventHandler(this.txt_S_TextChanged);
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            this.txt_k1.TextChanged += new System.EventHandler(this.txt_k1_TextChanged);
            this.btn_Find_a.Click += new System.EventHandler(this.btn_Find_a_Click);
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            this.chk_40201.CheckedChanged += new System.EventHandler(this.chk_40201_CheckedChanged);
            this.chk_40301.CheckedChanged += new System.EventHandler(this.chk_40301_CheckedChanged);
            this.chk_40401.CheckedChanged += new System.EventHandler(this.chk_40401_CheckedChanged);
            this.btn_Find_b.Click += new System.EventHandler(this.btn_Find_b_Click);
        }

		private void Txt_D_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					Txt_D.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			else if ((Conversions.ToSingle(txt_rs.Text) != 0f) & (Operators.CompareString(txt_rs.Text, "", TextCompare: false) != 0) & ((Conversions.ToSingle(Txt_D.Text) != 0f) & (Operators.CompareString(Txt_D.Text, "", TextCompare: false) != 0)))
			{
				txt_40101B.Text = Strings.Format(Conversions.ToSingle(txt_40101C1.Text) + Conversions.ToSingle(txt_40101C2.Text) * (1f + Conversions.ToSingle(txt_rs.Text)) / 2f * Conversions.ToSingle(Txt_D.Text), "###0");
			}
			else
			{
				txt_40101B.Text = "";
			}
			if (e.KeyCode == Keys.Return)
			{
				btn_Ok.Select();
			}
		}

		private void txt_rs_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_rs.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			else if ((Conversions.ToSingle(txt_rs.Text) != 0f) & (Operators.CompareString(txt_rs.Text, "", TextCompare: false) != 0) & ((Conversions.ToSingle(Txt_D.Text) != 0f) & (Operators.CompareString(Txt_D.Text, "", TextCompare: false) != 0)))
			{
				txt_40101B.Text = Strings.Format(Conversions.ToSingle(txt_40101C1.Text) + Conversions.ToSingle(txt_40101C2.Text) * (1f + Conversions.ToSingle(txt_rs.Text)) / 2f * Conversions.ToSingle(Txt_D.Text), "###0");
			}
			else
			{
				txt_40101B.Text = "";
			}
			if (e.KeyCode == Keys.Return)
			{
				Txt_D.Focus();
			}
		}

		private void txt_40101B_KeyUp(object sender, KeyEventArgs e)
		{
			if ((e.KeyValue >= 65) & (e.KeyValue <= 90))
			{
				DialogResult dialogResult = MessageBox.Show(".داده باید بصورت عدد باشد", "پیغام مهم", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
				if (dialogResult == DialogResult.OK)
				{
					txt_40101B.Text = "";
				}
				if (dialogResult == DialogResult.Cancel)
				{
					return;
				}
			}
			if (e.KeyCode == Keys.Return)
			{
				txt_rs.Focus();
			}
		}

		private void btn_Ok_Click(object sender, EventArgs e)
		{
			try
			{
				Frm_AsnadDetail frm_AsnadDetail = MyProject.Forms.Frm_AsnadDetail;
				if (pnl_40101.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40101B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40201.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40201B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40301.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40301B.Text;
					frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
				}
				if (pnl_40401.Visible)
				{
					frm_AsnadDetail.txt_ItemBahavahed.Text = txt_40401B.Text;
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahaKol.Text = Strings.Format(Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.txt_ItemTedad.Text) * Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.Text), "###0");
					MyProject.Forms.Frm_AsnadDetail.txt_Tozihat.Text = "k1=" + txt_k1.Text + " , a1=" + Module1.a1_Factor + " , a2=" + Module1.a2_Factor + " , a3=" + Module1.a3_Factor + " , a4=" + Module1.a4_Factor + " , a5=" + Module1.a5_Factor + " , a6=" + Module1.a6_Factor + " , a7=" + Module1.a7_Factor + " , a8=" + Module1.a8_Factor + " , b=" + txt_b.Text + " , S=" + txt_S.Text;
				}
				frm_AsnadDetail.txt_ItemBahavahed.Focus();
				frm_AsnadDetail = null;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
			try
			{
				if (Operators.CompareString(MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.Text.Trim(), Module1.ItemRec.ghvahed.Trim(), TextCompare: false) != 0)
				{
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.ForeColor = Color.Red;
				}
				else
				{
					MyProject.Forms.Frm_AsnadDetail.txt_ItemBahavahed.ForeColor = Color.Black;
				}
				MyProject.Forms.Frm_AsnadDetail.CheckItemRecChange();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				ProjectData.ClearProjectError();
			}
			Close();
		}

		private void btn_Cancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void chk_40201_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

		private void chk_40301_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

		public void CalculateItemFasl4()
		{
			string value = "0";
			string value2 = "0";
			string value3 = "0";
			string value4 = "0";
			string value5 = "0";
			string value6 = "0";
			string value7 = "0";
			string value8 = "0";
			double SumFasl = Conversions.ToDouble(value);
			CalculateSumFasl("1", ref SumFasl);
			value = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value2);
			CalculateSumFasl("1*", ref SumFasl);
			value2 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value3);
			CalculateSumFasl("2", ref SumFasl);
			value3 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value4);
			CalculateSumFasl("2*", ref SumFasl);
			value4 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value5);
			CalculateSumFasl("3", ref SumFasl);
			value5 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value6);
			CalculateSumFasl("3*", ref SumFasl);
			value6 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value7);
			CalculateSumFasl("6", ref SumFasl);
			value7 = Conversions.ToString(SumFasl);
			SumFasl = Conversions.ToDouble(value8);
			CalculateSumFasl("6*", ref SumFasl);
			value8 = Conversions.ToString(SumFasl);
			checked
			{
				switch (MyProject.Forms.Frm_AsnadDetail.txt_ItemNo.Text.Trim())
				{
				case "40101":
				{
					pnl_40101.Visible = true;
					pnl_40201.Visible = false;
					pnl_40301.Visible = false;
					pnl_40401.Visible = false;
					pnl_40101.Location = new Point(35, 23);
					base.Height = pnl_40101.Location.Y + pnl_40101.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_rs.Text = MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text;
					Txt_D.Text = "0";
					txt_40101B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40101C1.Text = "40000000";
						txt_40101C2.Text = "400000";
						break;
					case "FEHBAHA1401":
						txt_40101C1.Text = "24000000";
						txt_40101C2.Text = "300000";
						break;
					case "FEHBAHA1400":
						txt_40101C1.Text = "18197000";
						txt_40101C2.Text = "190000";
						break;
					case "FEHBAHA1399":
						txt_40101C1.Text = "11740000";
						txt_40101C2.Text = "123000";
						break;
					case "FEHBAHA1397":
						txt_40101C1.Text = "6180000";
						txt_40101C2.Text = "123000";
						break;
					case "FEHBAHA1393":
						txt_40101C1.Text = "3640000";
						txt_40101C2.Text = "72700";
						break;
					case "FEHBAHA1391":
						txt_40101C1.Text = "1966500";
						txt_40101C2.Text = "39330";
						break;
					case "FEHBAHA1387":
						txt_40101C1.Text = "1150000";
						txt_40101C2.Text = "23000";
						break;
					case "FEHBAHA1384":
						txt_40101C1.Text = "800000";
						txt_40101C2.Text = "16000";
						break;
					}
					Module1.MyConn.Close();
					if (Module1.MyConn.State == ConnectionState.Closed)
					{
						Module1.MyConn.Open();
					}
					Module1.cmd.Connection = Module1.MyConn;
					Module1.cmd.CommandText = "SELECT sum(cast([total] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And ([itemnum]  between '10401' And '10407' Or [itemnum]  between '10501' And '10507' Or [itemnum]  between '10701' And '10713' Or  [itemnum]  between '11001' And '11004') And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
					SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
					if (sqlDataReader.HasRows)
					{
						while (sqlDataReader.Read())
						{
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
							{
								Txt_D.Text = Strings.Format(Conversions.ToDouble(sqlDataReader[0].ToString()), "###0.00");
							}
						}
					}
					sqlDataReader.Close();
					if (Conversions.ToDouble(Txt_D.Text) != 0.0)
					{
						txt_40101B.Text = Strings.Format(Conversions.ToDouble(txt_40101C1.Text) + Conversions.ToDouble(txt_40101C2.Text) * (1.0 + Conversions.ToDouble(txt_rs.Text)) / 2.0 * Conversions.ToDouble(Txt_D.Text), "###0");
					}
					else
					{
						txt_40101B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40201":
				{
					pnl_40101.Visible = false;
					pnl_40201.Visible = true;
					pnl_40301.Visible = false;
					pnl_40401.Visible = false;
					pnl_40201.Location = new Point(35, 23);
					base.Height = pnl_40201.Location.Y + pnl_40201.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_F.Text = "0";
					txt_40201B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40201C1.Text = "16000000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1401":
						txt_40201C1.Text = "9000000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1400":
						txt_40201C1.Text = "6770000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1399":
						txt_40201C1.Text = "4370000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1397":
						txt_40201C1.Text = "2300000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1393":
						txt_40201C1.Text = "1360000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1391":
						txt_40201C1.Text = "735300";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1387":
						txt_40201C1.Text = "430000";
						txt_40201C2.Text = "0.05";
						break;
					case "FEHBAHA1384":
						txt_40201C1.Text = "300000";
						txt_40201C2.Text = "0.05";
						break;
					}
					double num = ((!chk_40201.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_F.Text = Strings.Format(Conversions.ToDouble(value3) * num + Conversions.ToDouble(value4), "###0");
					if (Conversions.ToDouble(txt_F.Text) != 0.0)
					{
						txt_40201B.Text = Strings.Format(Conversions.ToDouble(txt_40201C1.Text) + Conversions.ToDouble(txt_40201C2.Text) * Conversions.ToDouble(txt_F.Text), "###0");
					}
					else
					{
						txt_40201B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40301":
				{
					pnl_40101.Visible = false;
					pnl_40201.Visible = false;
					pnl_40301.Visible = true;
					pnl_40401.Visible = false;
					pnl_40301.Location = new Point(35, 23);
					base.Height = pnl_40301.Location.Y + pnl_40301.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					txt_L.Text = "0";
					txt_40301B.Text = "0";
					switch (Module1.SanadRec.fehrestfile)
					{
					case "FEHBAHA1403":
						txt_40301C1.Text = "4000000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1401":
						txt_40301C1.Text = "3000000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1400":
						txt_40301C1.Text = "2370000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1399":
						txt_40301C1.Text = "1531000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1397":
						txt_40301C1.Text = "806000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1393":
						txt_40301C1.Text = "475000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1391":
						txt_40301C1.Text = "256500";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1387":
						txt_40301C1.Text = "150000";
						txt_40301C2.Text = "0.07";
						break;
					case "FEHBAHA1384":
						txt_40301C1.Text = "100000";
						txt_40301C2.Text = "0.07";
						break;
					}
					double num = ((!chk_40301.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_Fasl_3.Text = Strings.Format(Conversions.ToDouble(value5) + Conversions.ToDouble(value6), "###0");
					txt_Fasl_6.Text = Strings.Format(Conversions.ToDouble(value7) * num + Conversions.ToDouble(value8), "###0");
					txt_L.Text = Strings.Format(Conversions.ToDouble(txt_Fasl_3.Text) + Conversions.ToDouble(txt_Fasl_6.Text), "###0");
					if (Conversions.ToDouble(txt_L.Text) != 0.0)
					{
						txt_40301B.Text = Strings.Format(Conversions.ToDouble(txt_40301C1.Text) + Conversions.ToDouble(txt_40301C2.Text) * Conversions.ToDouble(txt_L.Text), "###0");
					}
					else
					{
						txt_40301B.Text = Conversions.ToString(0);
					}
					break;
				}
				case "40401":
				{
					LoadFactor_a_b();
					k1 = 0.0;
					pnl_40101.Visible = false;
					pnl_40201.Visible = false;
					pnl_40301.Visible = false;
					pnl_40401.Visible = true;
					pnl_40401.Location = new Point(35, 23);
					base.Height = pnl_40401.Location.Y + pnl_40401.Size.Height + 90;
					pnl_Command.Location = new Point(90, base.Height - 90);
					double num = ((!chk_40401.Checked) ? 1.0 : Conversions.ToDouble(MyProject.Forms.Frm_AsnadDetail.lbl_SanadZarib1.Text));
					txt_S.Text = Strings.Format(Conversions.ToDouble(value) * num + Conversions.ToDouble(value2) + Conversions.ToDouble(value3) * num + Conversions.ToDouble(value4) + Conversions.ToDouble(value5) + Conversions.ToDouble(value6), "###0");
					Calculate_k1((float)(Conversions.ToDouble(txt_S.Text) / 1000000.0), ref k1);
					txt_k1.Text = Strings.Format(k1 / 100.0, "###0.0000");
					LoadFactor_a_b();
					Module1.a_Factor = Conversions.ToString(Math.Round(Conversions.ToDouble(Module1.a1_Factor) * Conversions.ToDouble(Module1.a2_Factor) * Conversions.ToDouble(Module1.a3_Factor) * Conversions.ToDouble(Module1.a4_Factor) * Conversions.ToDouble(Module1.a5_Factor) * Conversions.ToDouble(Module1.a6_Factor) * Conversions.ToDouble(Module1.a7_Factor) * Conversions.ToDouble(Module1.a8_Factor), 4));
					txt_a.Text = Module1.a_Factor;
					txt_b.Text = Module1.b_Factor;
					break;
				}
				}
				btn_Ok.Select();
			}
		}

		private void CalculateSumFasl(string Fasl, ref double SumFasl)
		{
			Module1.MyConn.Close();
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT sum(cast([mablagh] as float)) FROM [dbo].[Asnad2]  Where [sanadnum] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fasl] = '" + Fasl + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				while (sqlDataReader.Read())
				{
					if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(sqlDataReader[0])))
					{
						SumFasl = Conversions.ToDouble(sqlDataReader[0].ToString());
					}
				}
			}
			sqlDataReader.Close();
		}

		private void Calculate_k1(float S, ref double k1)
		{
			switch (Module1.SanadRec.fehrestfile)
			{
			case "FEHBAHA1403":
				if (S <= 1350f)
				{
					k1 = 6.57;
				}
				if (S > 1350f && S <= 2900f)
				{
					k1 = 6.57 - (double)((S - 1350f) / 1550f) * 0.4400000000000004;
				}
				if (S > 2900f && S <= 4200f)
				{
					k1 = 6.13 - (double)((S - 2900f) / 1300f) * 0.28000000000000025;
				}
				if (S > 4200f && S <= 7000f)
				{
					k1 = 5.85 - (double)((S - 4200f) / 2800f) * 0.22999999999999954;
				}
				if (S > 7000f && S <= 18000f)
				{
					k1 = 5.62 - (double)((S - 7000f) / 11000f) * 0.5;
				}
				if (S > 18000f && S <= 35000f)
				{
					k1 = 5.12 - (double)((S - 18000f) / 17000f) * 0.25;
				}
				if (S > 35000f && S <= 70000f)
				{
					k1 = 4.87 - (double)((S - 35000f) / 35000f) * 0.41000000000000014;
				}
				if (S > 70000f && S <= 175000f)
				{
					k1 = 4.46 - (double)((S - 70000f) / 105000f) * 0.3899999999999997;
				}
				if (S > 175000f && S <= 290000f)
				{
					k1 = 4.07 - (double)((S - 175000f) / 115000f) * 0.20000000000000018;
				}
				if (S > 290000f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1401":
				if (S <= 700f)
				{
					k1 = 6.57;
				}
				if (S > 700f && S <= 1500f)
				{
					k1 = 6.57 - (double)((S - 700f) / 800f) * 0.4400000000000004;
				}
				if (S > 1500f && S <= 2400f)
				{
					k1 = 6.13 - (double)((S - 1500f) / 900f) * 0.28000000000000025;
				}
				if (S > 2400f && S <= 3600f)
				{
					k1 = 5.85 - (double)((S - 2400f) / 1200f) * 0.22999999999999954;
				}
				if (S > 3600f && S <= 9000f)
				{
					k1 = 5.62 - (double)((S - 3600f) / 5400f) * 0.5;
				}
				if (S > 9000f && S <= 18000f)
				{
					k1 = 5.12 - (double)((S - 9000f) / 9000f) * 0.25;
				}
				if (S > 18000f && S <= 36000f)
				{
					k1 = 4.87 - (double)((S - 18000f) / 18000f) * 0.41000000000000014;
				}
				if (S > 36000f && S <= 90000f)
				{
					k1 = 4.46 - (double)((S - 36000f) / 54000f) * 0.3899999999999997;
				}
				if (S > 90000f && S <= 150000f)
				{
					k1 = 4.07 - (double)((S - 90000f) / 60000f) * 0.20000000000000018;
				}
				if (S > 150000f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1400":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				k1 = Math.Round(k1, 2);
				break;
			case "FEHBAHA1399":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			case "FEHBAHA1397":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			case "FEHBAHA1393":
				if (S <= 35f)
				{
					k1 = 6.57;
				}
				if (S > 35f && S <= 75f)
				{
					k1 = 6.57 - (double)((S - 35f) / 40f) * 0.4400000000000004;
				}
				if (S > 75f && S <= 120f)
				{
					k1 = 6.13 - (double)((S - 75f) / 45f) * 0.28000000000000025;
				}
				if (S > 120f && S <= 180f)
				{
					k1 = 5.85 - (double)((S - 120f) / 60f) * 0.22999999999999954;
				}
				if (S > 180f && S <= 450f)
				{
					k1 = 5.62 - (double)((S - 180f) / 270f) * 0.5;
				}
				if (S > 450f && S <= 900f)
				{
					k1 = 5.12 - (double)((S - 450f) / 450f) * 0.25;
				}
				if (S > 900f && S <= 1800f)
				{
					k1 = 4.87 - (double)((S - 900f) / 900f) * 0.41000000000000014;
				}
				if (S > 1800f && S <= 4500f)
				{
					k1 = 4.46 - (double)((S - 1800f) / 2700f) * 0.3899999999999997;
				}
				if (S > 4500f && S <= 7500f)
				{
					k1 = 4.07 - (double)((S - 4500f) / 3000f) * 0.20000000000000018;
				}
				if (S > 7500f)
				{
					k1 = 3.87;
				}
				break;
			}
		}

		private void chk_40401_CheckedChanged(object sender, EventArgs e)
		{
			CalculateItemFasl4();
		}

		private void txt_S_TextChanged(object sender, EventArgs e)
		{
			Calculate_k1((float)(Conversions.ToDouble(txt_S.Text) / 1000000.0), ref k1);
			txt_k1.Text = Strings.Format(k1 / 100.0, "###0.00000");
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void btn_Find_a_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_Factor_a.ShowDialog();
		}

		private void btn_Find_b_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frm_Factor_b.ShowDialog();
		}

		private void LoadFactor_a_b()
		{
			if (Module1.MyConn.State == ConnectionState.Closed)
			{
				Module1.MyConn.Open();
			}
			Module1.cmd.Connection = Module1.MyConn;
			Module1.cmd.CommandText = "SELECT [SanadNo],[a1],[a2],[a3],[a4],[a5],[a6],[a7],[a8],[b] FROM [dbo].[Factors40401] Where [SanadNo] ='" + MyProject.Forms.Frm_AsnadDetail.lbl_SanadNo.Text + "' And [fopf]= '" + Conversions.ToString(Module1.SanadRec.forpf) + "' And [SalMali] ='" + Module1.SanadRec.SalMali + "' And [Soori] ='" + Conversions.ToString(Module1.SanadRec.Soori) + "' And [Ghaleb] ='" + Conversions.ToString(Module1.SanadRec.Ghaleb) + "'";
			SqlDataReader sqlDataReader = Module1.cmd.ExecuteReader();
			if (sqlDataReader.HasRows)
			{
				Module1.FactorHasRow = 1;
				while (sqlDataReader.Read())
				{
					Module1.a1_Factor = sqlDataReader[1].ToString().Trim();
					Module1.a2_Factor = sqlDataReader[2].ToString().Trim();
					Module1.a3_Factor = sqlDataReader[3].ToString().Trim();
					Module1.a4_Factor = sqlDataReader[4].ToString().Trim();
					Module1.a5_Factor = sqlDataReader[5].ToString().Trim();
					Module1.a6_Factor = sqlDataReader[6].ToString().Trim();
					Module1.a7_Factor = sqlDataReader[7].ToString().Trim();
					Module1.a8_Factor = sqlDataReader[8].ToString().Trim();
					Module1.b_Factor = sqlDataReader[9].ToString().Trim();
				}
			}
			else
			{
				Module1.FactorHasRow = 0;
				foreach (Control control in MyProject.Forms.frm_Factor_a.Controls)
				{
					if (!(control is Panel))
					{
						continue;
					}
					foreach (RadioButton control2 in control.Controls)
					{
						if (Operators.CompareString(control2.Text.Substring(3, 4), "1.00", TextCompare: false) == 0)
						{
							control2.Checked = true;
						}
					}
				}
				Module1.a7_Factor = "1.00";
				Module1.a8_Factor = "1.00";
				Module1.b_Factor = "1.00";
			}
			sqlDataReader.Close();
		}

		private void txt_k1_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_a_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}

		private void txt_b_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_40401B.Text = Strings.Format(Conversions.ToDouble(txt_k1.Text.Trim()) * Conversions.ToDouble(txt_a.Text.Trim()) * Conversions.ToDouble(txt_b.Text.Trim()) * Conversions.ToDouble(txt_S.Text.Trim()), "###0");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
	}
}
