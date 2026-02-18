using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace GeoBaha
{
    partial class Frm_Main_New
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

        // Control declarations
        private System.Windows.Forms.MenuStrip mnu_Taarif;
        private System.Windows.Forms.ToolStripMenuItem mnu_Asnad;
        private System.Windows.Forms.ToolStripMenuItem mnu_Factor;
        private System.Windows.Forms.ToolStripMenuItem mnu_PishFactor;
        private System.Windows.Forms.ToolStripMenuItem mnu_Soori;
        private System.Windows.Forms.ToolStripMenuItem mnu_Ghaleb;
        private System.Windows.Forms.ToolStripMenuItem mnu_Enteghal;
        private System.Windows.Forms.ToolStripMenuItem mnu_Project;
        private System.Windows.Forms.ToolStripMenuItem mnu_Karfarma;
        private System.Windows.Forms.ToolStripMenuItem mnu_Fehrest;
        private System.Windows.Forms.ToolStripMenuItem فهرستبهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem فصولToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem آیتمهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_ZaribMantaghe;
        private System.Windows.Forms.ToolStripMenuItem mnu_Anavin;
        private System.Windows.Forms.ToolStripMenuItem mnu_Exit;
        private System.Windows.Forms.ToolStrip ToolStrip1;
        private System.Windows.Forms.ToolStripButton tlsb_Asnad;
        private System.Windows.Forms.ToolStripButton tlsb_Project;
        private System.Windows.Forms.ToolStripButton tlsb_Karfarma;
        private System.Windows.Forms.ToolStripButton tlsb_Fehrest;
        private System.Windows.Forms.ToolStripButton tlsb_ZaribMantaghe;
        private System.Windows.Forms.ToolStripButton tlsb_Exit;
        private System.Windows.Forms.Panel Pnl_Authen;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox txtRec1;
        private System.Windows.Forms.TextBox txtRec2;
        private System.Windows.Forms.TextBox txtRec3;
        private System.Windows.Forms.TextBox txtRec4;
        private System.Windows.Forms.TextBox txtAuth1;
        private System.Windows.Forms.TextBox txtAuth2;
        private System.Windows.Forms.TextBox txtAuth3;
        private System.Windows.Forms.TextBox txtAuth4;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.PictureBox PictureBox1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main_New));

            this.mnu_Taarif = new System.Windows.Forms.MenuStrip();
            this.mnu_Asnad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Factor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_PishFactor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Soori = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Ghaleb = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Enteghal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Karfarma = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Fehrest = new System.Windows.Forms.ToolStripMenuItem();
            this.فهرستبهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.فصولToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.آیتمهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ZaribMantaghe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Anavin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlsb_Asnad = new System.Windows.Forms.ToolStripButton();
            this.tlsb_Project = new System.Windows.Forms.ToolStripButton();
            this.tlsb_Karfarma = new System.Windows.Forms.ToolStripButton();
            this.tlsb_Fehrest = new System.Windows.Forms.ToolStripButton();
            this.tlsb_ZaribMantaghe = new System.Windows.Forms.ToolStripButton();
            this.tlsb_Exit = new System.Windows.Forms.ToolStripButton();
            this.Pnl_Authen = new System.Windows.Forms.Panel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtRec4 = new System.Windows.Forms.TextBox();
            this.txtRec3 = new System.Windows.Forms.TextBox();
            this.txtRec2 = new System.Windows.Forms.TextBox();
            this.txtRec1 = new System.Windows.Forms.TextBox();
            this.txtAuth4 = new System.Windows.Forms.TextBox();
            this.txtAuth3 = new System.Windows.Forms.TextBox();
            this.txtAuth2 = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.txtAuth1 = new System.Windows.Forms.TextBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();

            // mnu_Taarif
            this.mnu_Taarif.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mnu_Taarif.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnu_Asnad,
                this.mnu_Project,
                this.mnu_Karfarma,
                this.mnu_Fehrest,
                this.mnu_ZaribMantaghe,
                this.mnu_Anavin,
                this.mnu_Exit
            });
            this.mnu_Taarif.Location = new System.Drawing.Point(0, 0);
            this.mnu_Taarif.Name = "mnu_Taarif";
            this.mnu_Taarif.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mnu_Taarif.Size = new System.Drawing.Size(553, 24);
            this.mnu_Taarif.TabIndex = 0;
            this.mnu_Taarif.Text = "تعاریف";

            // mnu_Asnad
            this.mnu_Asnad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnu_Factor,
                this.mnu_PishFactor,
                this.mnu_Soori,
                this.mnu_Ghaleb,
                this.mnu_Enteghal
            });
            this.mnu_Asnad.Name = "mnu_Asnad";
            this.mnu_Asnad.Size = new System.Drawing.Size(45, 20);
            this.mnu_Asnad.Text = "اسناد";

            // mnu_Factor
            this.mnu_Factor.Name = "mnu_Factor";
            this.mnu_Factor.Size = new System.Drawing.Size(180, 22);
            this.mnu_Factor.Text = "فاکتور";
            this.mnu_Factor.Click += new System.EventHandler(this.mnu_Factor_Click);

            // mnu_PishFactor
            this.mnu_PishFactor.Name = "mnu_PishFactor";
            this.mnu_PishFactor.Size = new System.Drawing.Size(180, 22);
            this.mnu_PishFactor.Text = "پیش فاکتور";
            this.mnu_PishFactor.Click += new System.EventHandler(this.mnu_PishFactor_Click);

            // mnu_Soori
            this.mnu_Soori.Name = "mnu_Soori";
            this.mnu_Soori.Size = new System.Drawing.Size(180, 22);
            this.mnu_Soori.Text = "صوری";
            this.mnu_Soori.Click += new System.EventHandler(this.mnu_Soori_Click);

            // mnu_Ghaleb
            this.mnu_Ghaleb.Name = "mnu_Ghaleb";
            this.mnu_Ghaleb.Size = new System.Drawing.Size(180, 22);
            this.mnu_Ghaleb.Text = "قالب ";
            this.mnu_Ghaleb.Click += new System.EventHandler(this.mnu_Ghaleb_Click);

            // mnu_Enteghal
            this.mnu_Enteghal.Name = "mnu_Enteghal";
            this.mnu_Enteghal.Size = new System.Drawing.Size(180, 22);
            this.mnu_Enteghal.Text = "انتقال";
            this.mnu_Enteghal.Visible = false;
            this.mnu_Enteghal.Click += new System.EventHandler(this.mnu_Enteghal_Click);

            // mnu_Project
            this.mnu_Project.Name = "mnu_Project";
            this.mnu_Project.Size = new System.Drawing.Size(57, 20);
            this.mnu_Project.Text = "پروژه ها";
            this.mnu_Project.Click += new System.EventHandler(this.mnu_Project_Click);

            // mnu_Karfarma
            this.mnu_Karfarma.Name = "mnu_Karfarma";
            this.mnu_Karfarma.Size = new System.Drawing.Size(63, 20);
            this.mnu_Karfarma.Text = "کارفرماها";
            this.mnu_Karfarma.Click += new System.EventHandler(this.mnu_Karfarma_Click);

            // mnu_Fehrest
            this.mnu_Fehrest.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.فهرستبهاToolStripMenuItem,
                this.فصولToolStripMenuItem,
                this.آیتمهاToolStripMenuItem
            });
            this.mnu_Fehrest.Name = "mnu_Fehrest";
            this.mnu_Fehrest.Size = new System.Drawing.Size(68, 20);
            this.mnu_Fehrest.Text = "فهارس بها";
            this.mnu_Fehrest.Click += new System.EventHandler(this.mnu_Fehrest_Click);

            // فهرستبهاToolStripMenuItem
            this.فهرستبهاToolStripMenuItem.Name = "فهرستبهاToolStripMenuItem";
            this.فهرستبهاToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.فهرستبهاToolStripMenuItem.Text = "فهرست بها";
            this.فهرستبهاToolStripMenuItem.Visible = false;
            this.فهرستبهاToolStripMenuItem.Click += new System.EventHandler(this.فهرستبهاToolStripMenuItem_Click);

            // فصولToolStripMenuItem
            this.فصولToolStripMenuItem.Name = "فصولToolStripMenuItem";
            this.فصولToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.فصولToolStripMenuItem.Text = "فصول";
            this.فصولToolStripMenuItem.Visible = false;
            this.فصولToolStripMenuItem.Click += new System.EventHandler(this.فصولToolStripMenuItem_Click);

            // آیتمهاToolStripMenuItem
            this.آیتمهاToolStripMenuItem.Name = "آیتمهاToolStripMenuItem";
            this.آیتمهاToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.آیتمهاToolStripMenuItem.Text = "آیتم ها";
            this.آیتمهاToolStripMenuItem.Visible = false;
            this.آیتمهاToolStripMenuItem.Click += new System.EventHandler(this.آیتمهاToolStripMenuItem_Click);

            // mnu_ZaribMantaghe
            this.mnu_ZaribMantaghe.Name = "mnu_ZaribMantaghe";
            this.mnu_ZaribMantaghe.Size = new System.Drawing.Size(103, 20);
            this.mnu_ZaribMantaghe.Text = "ضرایب منطقه ای";
            this.mnu_ZaribMantaghe.Click += new System.EventHandler(this.mnu_ZaribMantaghe_Click);

            // mnu_Anavin
            this.mnu_Anavin.Name = "mnu_Anavin";
            this.mnu_Anavin.Size = new System.Drawing.Size(55, 20);
            this.mnu_Anavin.Text = "تعاریف";
            this.mnu_Anavin.Click += new System.EventHandler(this.mnu_Anavin_Click);

            // mnu_Exit
            this.mnu_Exit.Name = "mnu_Exit";
            this.mnu_Exit.Size = new System.Drawing.Size(44, 20);
            this.mnu_Exit.Text = "خروج";
            this.mnu_Exit.Click += new System.EventHandler(this.mnu_Exit_Click);

            // ToolStrip1
            this.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tlsb_Asnad,
                this.tlsb_Project,
                this.tlsb_Karfarma,
                this.tlsb_Fehrest,
                this.tlsb_ZaribMantaghe,
                this.tlsb_Exit
            });
            this.ToolStrip1.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ToolStrip1.Size = new System.Drawing.Size(553, 25);
            this.ToolStrip1.TabIndex = 1;
            this.ToolStrip1.Text = "ToolStrip1";
            this.ToolStrip1.Visible = false;

            // tlsb_Asnad
            this.tlsb_Asnad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_Asnad.Image = (System.Drawing.Image)resources.GetObject("tlsb_Asnad.Image");
            this.tlsb_Asnad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_Asnad.Name = "tlsb_Asnad";
            this.tlsb_Asnad.Size = new System.Drawing.Size(23, 22);
            this.tlsb_Asnad.Text = "اسناد";

            // tlsb_Project
            this.tlsb_Project.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_Project.Image = (System.Drawing.Image)resources.GetObject("tlsb_Project.Image");
            this.tlsb_Project.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_Project.Name = "tlsb_Project";
            this.tlsb_Project.Size = new System.Drawing.Size(23, 22);
            this.tlsb_Project.Text = "پروژه ها";
            this.tlsb_Project.Click += new System.EventHandler(this.tlsb_Project_Click);

            // tlsb_Karfarma
            this.tlsb_Karfarma.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_Karfarma.Image = (System.Drawing.Image)resources.GetObject("tlsb_Karfarma.Image");
            this.tlsb_Karfarma.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_Karfarma.Name = "tlsb_Karfarma";
            this.tlsb_Karfarma.Size = new System.Drawing.Size(23, 22);
            this.tlsb_Karfarma.Text = "کارفرماها";
            this.tlsb_Karfarma.Click += new System.EventHandler(this.tlsb_Karfarma_Click);

            // tlsb_Fehrest
            this.tlsb_Fehrest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_Fehrest.Image = (System.Drawing.Image)resources.GetObject("tlsb_Fehrest.Image");
            this.tlsb_Fehrest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_Fehrest.Name = "tlsb_Fehrest";
            this.tlsb_Fehrest.Size = new System.Drawing.Size(23, 22);
            this.tlsb_Fehrest.Text = "فهارس بها";

            // tlsb_ZaribMantaghe
            this.tlsb_ZaribMantaghe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_ZaribMantaghe.Image = (System.Drawing.Image)resources.GetObject("tlsb_ZaribMantaghe.Image");
            this.tlsb_ZaribMantaghe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_ZaribMantaghe.Name = "tlsb_ZaribMantaghe";
            this.tlsb_ZaribMantaghe.Size = new System.Drawing.Size(23, 22);
            this.tlsb_ZaribMantaghe.Text = "ضرایب منطقه ای";

            // tlsb_Exit
            this.tlsb_Exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlsb_Exit.Image = (System.Drawing.Image)resources.GetObject("tlsb_Exit.Image");
            this.tlsb_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlsb_Exit.Name = "tlsb_Exit";
            this.tlsb_Exit.Size = new System.Drawing.Size(23, 22);
            this.tlsb_Exit.Text = "خروج";
            this.tlsb_Exit.Click += new System.EventHandler(this.tlsb_Exit_Click);

            // Pnl_Authen
            this.Pnl_Authen.Controls.Add(this.Label2);
            this.Pnl_Authen.Controls.Add(this.Label1);
            this.Pnl_Authen.Controls.Add(this.txtRec4);
            this.Pnl_Authen.Controls.Add(this.txtRec3);
            this.Pnl_Authen.Controls.Add(this.txtRec2);
            this.Pnl_Authen.Controls.Add(this.txtRec1);
            this.Pnl_Authen.Controls.Add(this.txtAuth4);
            this.Pnl_Authen.Controls.Add(this.txtAuth3);
            this.Pnl_Authen.Controls.Add(this.txtAuth2);
            this.Pnl_Authen.Controls.Add(this.cmdOk);
            this.Pnl_Authen.Controls.Add(this.txtAuth1);
            this.Pnl_Authen.Controls.Add(this.PictureBox1);
            this.Pnl_Authen.Location = new System.Drawing.Point(76, 33);
            this.Pnl_Authen.Name = "Pnl_Authen";
            this.Pnl_Authen.Size = new System.Drawing.Size(401, 191);
            this.Pnl_Authen.TabIndex = 23;

            // Label2
            this.Label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label2.ForeColor = System.Drawing.Color.White;
            this.Label2.Location = new System.Drawing.Point(301, 84);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label2.Size = new System.Drawing.Size(89, 21);
            this.Label2.TabIndex = 33;
            this.Label2.Text = "کد فعال سازی :";

            // Label1
            this.Label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.Label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(291, 17);
            this.Label1.Name = "Label1";
            this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Label1.Size = new System.Drawing.Size(97, 21);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "کد سیستم شما :";

            // txtRec4
            this.txtRec4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRec4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRec4.Location = new System.Drawing.Point(306, 120);
            this.txtRec4.Name = "txtRec4";
            this.txtRec4.Size = new System.Drawing.Size(74, 13);
            this.txtRec4.TabIndex = 29;
            this.txtRec4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtRec3
            this.txtRec3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRec3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRec3.Location = new System.Drawing.Point(211, 120);
            this.txtRec3.Name = "txtRec3";
            this.txtRec3.Size = new System.Drawing.Size(74, 13);
            this.txtRec3.TabIndex = 28;
            this.txtRec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtRec2
            this.txtRec2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRec2.Location = new System.Drawing.Point(118, 120);
            this.txtRec2.Name = "txtRec2";
            this.txtRec2.Size = new System.Drawing.Size(74, 13);
            this.txtRec2.TabIndex = 27;
            this.txtRec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtRec1
            this.txtRec1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtRec1.Location = new System.Drawing.Point(27, 120);
            this.txtRec1.Name = "txtRec1";
            this.txtRec1.Size = new System.Drawing.Size(74, 13);
            this.txtRec1.TabIndex = 26;
            this.txtRec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            // txtAuth4
            this.txtAuth4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuth4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAuth4.Location = new System.Drawing.Point(305, 53);
            this.txtAuth4.Name = "txtAuth4";
            this.txtAuth4.Size = new System.Drawing.Size(74, 13);
            this.txtAuth4.TabIndex = 25;
            this.txtAuth4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuth4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRec4_KeyPress);

            // txtAuth3
            this.txtAuth3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuth3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAuth3.Location = new System.Drawing.Point(210, 53);
            this.txtAuth3.Name = "txtAuth3";
            this.txtAuth3.Size = new System.Drawing.Size(74, 13);
            this.txtAuth3.TabIndex = 24;
            this.txtAuth3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuth3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRec3_KeyPress);

            // txtAuth2
            this.txtAuth2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuth2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAuth2.Location = new System.Drawing.Point(115, 53);
            this.txtAuth2.Name = "txtAuth2";
            this.txtAuth2.Size = new System.Drawing.Size(74, 13);
            this.txtAuth2.TabIndex = 23;
            this.txtAuth2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuth2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRec2_KeyPress);

            // cmdOk
            this.cmdOk.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.cmdOk.Location = new System.Drawing.Point(12, 160);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(379, 23);
            this.cmdOk.TabIndex = 22;
            this.cmdOk.Text = "تایید";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);

            // txtAuth1
            this.txtAuth1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuth1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.txtAuth1.Location = new System.Drawing.Point(23, 53);
            this.txtAuth1.Name = "txtAuth1";
            this.txtAuth1.Size = new System.Drawing.Size(74, 13);
            this.txtAuth1.TabIndex = 30;
            this.txtAuth1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAuth1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRec1_KeyPress);

            // PictureBox1
            this.PictureBox1.Image = (System.Drawing.Image)resources.GetObject("PictureBox1.Image");
            this.PictureBox1.Location = new System.Drawing.Point(12, 10);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(379, 144);
            this.PictureBox1.TabIndex = 31;
            this.PictureBox1.TabStop = false;

            // Frm_Main_New
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 256);
            this.Controls.Add(this.Pnl_Authen);
            this.Controls.Add(this.ToolStrip1);
            this.Controls.Add(this.mnu_Taarif);
            this.MainMenuStrip = this.mnu_Taarif;
            this.Name = "Frm_Main_New";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Geobaha";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}