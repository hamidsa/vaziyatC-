using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class frm_CopySanad_New
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
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button OK_Button;

        // ComboBox
        private System.Windows.Forms.ComboBox cmbo_NoaSanad;
        private System.Windows.Forms.ComboBox cmbo_SalMali;

        // Label
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;

        // Panel
        private System.Windows.Forms.Panel Panel2;

        // TableLayoutPanel
        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;

        // TextBox
        private System.Windows.Forms.TextBox txt_SanadNo;

        private void InitializeComponent()
		{
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Cancel_Button = new System.Windows.Forms.Button();
			this.OK_Button = new System.Windows.Forms.Button();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.cmbo_NoaSanad = new System.Windows.Forms.ComboBox();
			this.txt_SanadNo = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.cmbo_SalMali = new System.Windows.Forms.ComboBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.TableLayoutPanel1.SuspendLayout();
			this.Panel2.SuspendLayout();
			base.SuspendLayout();
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.ColumnCount = 2;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Controls.Add(this.Cancel_Button, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.OK_Button, 0, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(17, 290);
			this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 1;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50f));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(539, 46);
			this.TableLayoutPanel1.TabIndex = 0;
			this.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Cancel_Button.Location = new System.Drawing.Point(85, 4);
			this.Cancel_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Cancel_Button.Name = "Cancel_Button";
			this.Cancel_Button.Size = new System.Drawing.Size(100, 38);
			this.Cancel_Button.TabIndex = 1;
			this.Cancel_Button.Text = "لغو";
			this.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.OK_Button.Location = new System.Drawing.Point(355, 4);
			this.OK_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.OK_Button.Name = "OK_Button";
			this.OK_Button.Size = new System.Drawing.Size(100, 38);
			this.OK_Button.TabIndex = 0;
			this.OK_Button.Text = "انجام";
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.cmbo_NoaSanad);
			this.Panel2.Controls.Add(this.txt_SanadNo);
			this.Panel2.Controls.Add(this.Label3);
			this.Panel2.Controls.Add(this.cmbo_SalMali);
			this.Panel2.Controls.Add(this.Label2);
			this.Panel2.Controls.Add(this.Label1);
			this.Panel2.Location = new System.Drawing.Point(17, 20);
			this.Panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(538, 247);
			this.Panel2.TabIndex = 8;
			this.cmbo_NoaSanad.AllowDrop = true;
			this.cmbo_NoaSanad.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cmbo_NoaSanad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_NoaSanad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_NoaSanad.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_NoaSanad.FormattingEnabled = true;
			this.cmbo_NoaSanad.Location = new System.Drawing.Point(105, 10);
			this.cmbo_NoaSanad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbo_NoaSanad.Name = "cmbo_NoaSanad";
			this.cmbo_NoaSanad.Size = new System.Drawing.Size(175, 31);
			this.cmbo_NoaSanad.TabIndex = 10;
			this.txt_SanadNo.BackColor = System.Drawing.Color.White;
			this.txt_SanadNo.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.txt_SanadNo.Location = new System.Drawing.Point(105, 156);
			this.txt_SanadNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txt_SanadNo.Name = "txt_SanadNo";
			this.txt_SanadNo.Size = new System.Drawing.Size(175, 30);
			this.txt_SanadNo.TabIndex = 7;
			this.Label3.Font = new System.Drawing.Font("B Titr", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label3.Location = new System.Drawing.Point(278, 160);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label3.Size = new System.Drawing.Size(75, 42);
			this.Label3.TabIndex = 6;
			this.Label3.Text = "با شماره سند:";
			this.cmbo_SalMali.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.cmbo_SalMali.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbo_SalMali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbo_SalMali.Font = new System.Drawing.Font("B Koodak", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.cmbo_SalMali.FormattingEnabled = true;
			this.cmbo_SalMali.Location = new System.Drawing.Point(105, 80);
			this.cmbo_SalMali.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cmbo_SalMali.Name = "cmbo_SalMali";
			this.cmbo_SalMali.Size = new System.Drawing.Size(175, 31);
			this.cmbo_SalMali.TabIndex = 5;
			this.Label2.Font = new System.Drawing.Font("B Titr", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label2.Location = new System.Drawing.Point(274, 83);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label2.Size = new System.Drawing.Size(79, 42);
			this.Label2.TabIndex = 4;
			this.Label2.Text = "در سال مالی:";
			this.Label1.Font = new System.Drawing.Font("B Titr", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			this.Label1.Location = new System.Drawing.Point(271, 12);
			this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Label1.Size = new System.Drawing.Size(116, 42);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "کپی سند  به صورت :";
			base.AcceptButton = this.OK_Button;
			base.AutoScaleDimensions = new System.Drawing.SizeF(9f, 21f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCyan;
			base.CancelButton = this.Cancel_Button;
			base.ClientSize = new System.Drawing.Size(568, 354);
			base.ControlBox = false;
			base.Controls.Add(this.Panel2);
			base.Controls.Add(this.TableLayoutPanel1);
			this.Font = new System.Drawing.Font("B Titr", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 178);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "frm_CopySanad";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.RightToLeftLayout = true;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "کپی سند";
			this.TableLayoutPanel1.ResumeLayout(false);
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			base.ResumeLayout(false);
            this.OK_Button.Click += new System.EventHandler(this.OK_Button_Click);
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            this.cmbo_SalMali.SelectedIndexChanged += new System.EventHandler(this.cmbo_SalMali_SelectedIndexChanged);
            this.cmbo_NoaSanad.SelectedIndexChanged += new System.EventHandler(this.cmbo_NoaSanad_SelectedIndexChanged);
        }
    }
}
