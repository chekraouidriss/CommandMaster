using System;
using System.Windows.Forms;

namespace gstion_de_commande.formulairedossier
{
    partial class form_menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntcomm = new System.Windows.Forms.Button();
            this.bntprod = new System.Windows.Forms.Button();
            this.pnlbnt = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.bntclient = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelparam = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.bntdeconnecter = new System.Windows.Forms.Button();
            this.pnlfiche = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelparam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.bntcomm);
            this.panel1.Controls.Add(this.bntprod);
            this.panel1.Controls.Add(this.pnlbnt);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.bntclient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(115, 728);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bntcomm
            // 
            this.bntcomm.FlatAppearance.BorderSize = 0;
            this.bntcomm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntcomm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntcomm.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntcomm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntcomm.Image = ((System.Drawing.Image)(resources.GetObject("bntcomm.Image")));
            this.bntcomm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntcomm.Location = new System.Drawing.Point(20, 332);
            this.bntcomm.Name = "bntcomm";
            this.bntcomm.Size = new System.Drawing.Size(343, 75);
            this.bntcomm.TabIndex = 11;
            this.bntcomm.Text = "         commande ";
            this.bntcomm.UseVisualStyleBackColor = true;
            this.bntcomm.Click += new System.EventHandler(this.bntcomm_Click_1);
            // 
            // bntprod
            // 
            this.bntprod.FlatAppearance.BorderSize = 0;
            this.bntprod.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntprod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntprod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntprod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntprod.Image = ((System.Drawing.Image)(resources.GetObject("bntprod.Image")));
            this.bntprod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntprod.Location = new System.Drawing.Point(20, 215);
            this.bntprod.Name = "bntprod";
            this.bntprod.Size = new System.Drawing.Size(341, 75);
            this.bntprod.TabIndex = 9;
            this.bntprod.Text = "        Produit";
            this.bntprod.UseVisualStyleBackColor = true;
            this.bntprod.Click += new System.EventHandler(this.bntprod_Click_1);
            // 
            // pnlbnt
            // 
            this.pnlbnt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlbnt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlbnt.Location = new System.Drawing.Point(3, 81);
            this.pnlbnt.Name = "pnlbnt";
            this.pnlbnt.Size = new System.Drawing.Size(11, 86);
            this.pnlbnt.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(34, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 54);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bntclient
            // 
            this.bntclient.FlatAppearance.BorderSize = 0;
            this.bntclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntclient.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntclient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntclient.Image = ((System.Drawing.Image)(resources.GetObject("bntclient.Image")));
            this.bntclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntclient.Location = new System.Drawing.Point(20, 81);
            this.bntclient.Name = "bntclient";
            this.bntclient.Size = new System.Drawing.Size(335, 96);
            this.bntclient.TabIndex = 3;
            this.bntclient.Text = "               client";
            this.bntclient.UseVisualStyleBackColor = true;
            this.bntclient.Click += new System.EventHandler(this.bntclient_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(115, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1196, 30);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.panelparam);
            this.panel3.Controls.Add(this.pnlfiche);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(115, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1196, 698);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // panelparam
            // 
            this.panelparam.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelparam.Controls.Add(this.button1);
            this.panelparam.Controls.Add(this.bntdeconnecter);
            this.panelparam.Location = new System.Drawing.Point(67, 2);
            this.panelparam.Name = "panelparam";
            this.panelparam.Size = new System.Drawing.Size(523, 43);
            this.panelparam.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(481, 51);
            this.button1.TabIndex = 6;
            this.button1.Text = "se connecter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // bntdeconnecter
            // 
            this.bntdeconnecter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntdeconnecter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntdeconnecter.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.bntdeconnecter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntdeconnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntdeconnecter.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntdeconnecter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntdeconnecter.Image = ((System.Drawing.Image)(resources.GetObject("bntdeconnecter.Image")));
            this.bntdeconnecter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntdeconnecter.Location = new System.Drawing.Point(24, 116);
            this.bntdeconnecter.Name = "bntdeconnecter";
            this.bntdeconnecter.Size = new System.Drawing.Size(481, 51);
            this.bntdeconnecter.TabIndex = 5;
            this.bntdeconnecter.Text = "se deconnecter";
            this.bntdeconnecter.UseVisualStyleBackColor = false;
            this.bntdeconnecter.Click += new System.EventHandler(this.button4_Click);
            // 
            // pnlfiche
            // 
            this.pnlfiche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlfiche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlfiche.Location = new System.Drawing.Point(6, 62);
            this.pnlfiche.Name = "pnlfiche";
            this.pnlfiche.Size = new System.Drawing.Size(1178, 633);
            this.pnlfiche.TabIndex = 13;
            this.pnlfiche.Paint += new System.Windows.Forms.PaintEventHandler(this.pnfich_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // form_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 728);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_menu";
            this.Text = "form_menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.form_menu_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelparam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button bntclient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel pnlbnt;
        private System.Windows.Forms.Button bntcomm;
        private System.Windows.Forms.Button bntprod;
        private Panel panel3;
        private Panel panelparam;
        private Button bntdeconnecter;
        private PictureBox pictureBox2;
        private Button button1;
        private Panel pnlfiche;
    }
}