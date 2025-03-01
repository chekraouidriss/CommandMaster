using System.Diagnostics;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Diagnostics.Eventing;
using System.Data.SqlClient;

namespace gstion_de_commande.formulairedossier
{
    partial class form_ajouter_mmoifier_cli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ajouter_mmoifier_cli));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labtitre = new System.Windows.Forms.Label();
            this.textNOM = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bntsort = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textadrs = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.texttel = new System.Windows.Forms.TextBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.texville = new System.Windows.Forms.TextBox();
            this.bntactu = new System.Windows.Forms.Button();
            this.bntenreg = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(648, 3);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(645, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 591);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 591);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 591);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(642, 3);
            this.panel4.TabIndex = 3;
            // 
            // labtitre
            // 
            this.labtitre.AutoSize = true;
            this.labtitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labtitre.Location = new System.Drawing.Point(170, 33);
            this.labtitre.Name = "labtitre";
            this.labtitre.Size = new System.Drawing.Size(288, 52);
            this.labtitre.TabIndex = 4;
            this.labtitre.Text = "Ajouter client";
            // 
            // textNOM
            // 
            this.textNOM.BackColor = System.Drawing.Color.DimGray;
            this.textNOM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textNOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNOM.ForeColor = System.Drawing.Color.Silver;
            this.textNOM.Location = new System.Drawing.Point(92, 154);
            this.textNOM.Multiline = true;
            this.textNOM.Name = "textNOM";
            this.textNOM.Size = new System.Drawing.Size(200, 39);
            this.textNOM.TabIndex = 5;
            this.textNOM.TextChanged += new System.EventHandler(this.textNOM_TextChanged);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(92, 201);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 3);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(86, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "entrer le Nom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // bntsort
            // 
            this.bntsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntsort.FlatAppearance.BorderSize = 0;
            this.bntsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsort.Image = ((System.Drawing.Image)(resources.GetObject("bntsort.Image")));
            this.bntsort.Location = new System.Drawing.Point(587, 3);
            this.bntsort.Name = "bntsort";
            this.bntsort.Size = new System.Drawing.Size(58, 52);
            this.bntsort.TabIndex = 9;
            this.bntsort.UseVisualStyleBackColor = false;
            this.bntsort.Click += new System.EventHandler(this.bntsort_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 154);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(383, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "entrer le Prenom";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(380, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 3);
            this.panel6.TabIndex = 11;
            // 
            // textPrenom
            // 
            this.textPrenom.BackColor = System.Drawing.Color.DimGray;
            this.textPrenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrenom.ForeColor = System.Drawing.Color.Silver;
            this.textPrenom.Location = new System.Drawing.Point(380, 154);
            this.textPrenom.Multiline = true;
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(200, 39);
            this.textPrenom.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(34, 282);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(43, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(77, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "entrer l\'adresse";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(92, 338);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 3);
            this.panel7.TabIndex = 15;
            // 
            // textadrs
            // 
            this.textadrs.BackColor = System.Drawing.Color.DimGray;
            this.textadrs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textadrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textadrs.ForeColor = System.Drawing.Color.Silver;
            this.textadrs.Location = new System.Drawing.Point(92, 282);
            this.textadrs.Multiline = true;
            this.textadrs.Name = "textadrs";
            this.textadrs.Size = new System.Drawing.Size(200, 39);
            this.textadrs.TabIndex = 14;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(331, 280);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(43, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(385, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 32);
            this.label4.TabIndex = 20;
            this.label4.Text = "entrer le tel";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(382, 340);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 3);
            this.panel8.TabIndex = 19;
            // 
            // texttel
            // 
            this.texttel.BackColor = System.Drawing.Color.DimGray;
            this.texttel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texttel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttel.ForeColor = System.Drawing.Color.Silver;
            this.texttel.Location = new System.Drawing.Point(382, 282);
            this.texttel.Multiline = true;
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(200, 39);
            this.texttel.TabIndex = 18;
            this.texttel.TextChanged += new System.EventHandler(this.texttel_TextChanged);
            this.texttel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.texttel_KeyPress);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(34, 517);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(43, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 25;
            this.pictureBox5.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(77, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "entrer le pays";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(92, 569);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(200, 3);
            this.panel9.TabIndex = 23;
            // 
            // texville
            // 
            this.texville.BackColor = System.Drawing.Color.DimGray;
            this.texville.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.texville.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texville.ForeColor = System.Drawing.Color.Silver;
            this.texville.Location = new System.Drawing.Point(92, 524);
            this.texville.Multiline = true;
            this.texville.Name = "texville";
            this.texville.Size = new System.Drawing.Size(200, 39);
            this.texville.TabIndex = 22;
            // 
            // bntactu
            // 
            this.bntactu.BackColor = System.Drawing.Color.Silver;
            this.bntactu.FlatAppearance.BorderSize = 0;
            this.bntactu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntactu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntactu.Location = new System.Drawing.Point(380, 511);
            this.bntactu.Name = "bntactu";
            this.bntactu.Size = new System.Drawing.Size(200, 52);
            this.bntactu.TabIndex = 26;
            this.bntactu.Text = "Actualiser";
            this.bntactu.UseVisualStyleBackColor = false;
            this.bntactu.Click += new System.EventHandler(this.bntactu_Click);
            // 
            // bntenreg
            // 
            this.bntenreg.BackColor = System.Drawing.Color.Silver;
            this.bntenreg.FlatAppearance.BorderSize = 0;
            this.bntenreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntenreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntenreg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntenreg.Location = new System.Drawing.Point(380, 408);
            this.bntenreg.Name = "bntenreg";
            this.bntenreg.Size = new System.Drawing.Size(200, 53);
            this.bntenreg.TabIndex = 27;
            this.bntenreg.Text = "Enregistrer";
            this.bntenreg.UseVisualStyleBackColor = false;
            this.bntenreg.Click += new System.EventHandler(this.bntenreg_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(86, 362);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 32);
            this.label6.TabIndex = 30;
            this.label6.Text = "entrer l\'ID";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(92, 458);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(200, 3);
            this.panel10.TabIndex = 29;
            // 
            // textID
            // 
            this.textID.BackColor = System.Drawing.Color.DimGray;
            this.textID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textID.ForeColor = System.Drawing.Color.Silver;
            this.textID.Location = new System.Drawing.Point(92, 413);
            this.textID.Multiline = true;
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(200, 39);
            this.textID.TabIndex = 28;
            // 
            // form_ajouter_mmoifier_cli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(648, 594);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.textID);
            this.Controls.Add(this.bntenreg);
            this.Controls.Add(this.bntactu);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.texville);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.texttel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.textadrs);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.bntsort);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textNOM);
            this.Controls.Add(this.labtitre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ajouter_mmoifier_cli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ajouter_mmoifier_cli";
            this.Load += new System.EventHandler(this.form_ajouter_mmoifier_cli_Load);
            this.Leave += new System.EventHandler(this.form_ajouter_mmoifier_cli_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textNOM;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bntsort;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textadrs;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox texville;
        private System.Windows.Forms.Button bntenreg;
        public System.Windows.Forms.Label labtitre;
        public System.Windows.Forms.Button bntactu;

        public form_ajouter_mmoifier_cli(IContainer components, Panel panel1, Panel panel2, Panel panel3, Panel panel4, TextBox textNOM, Panel panel5, Label label1, PictureBox pictureBox1, Button bntsort, PictureBox pictureBox2, Label label2, Panel panel6, TextBox textPrenom, PictureBox pictureBox3, Label label3, Panel panel7, TextBox textadrs, PictureBox pictureBox4, Label label4, Panel panel8, TextBox texttel, PictureBox pictureBox5, Label label5, Panel panel9, TextBox texville, Button bntenreg, Label labtitre, Button bntactu, SqlConnection mycnx)
        {
            this.components = components ?? throw new ArgumentNullException(nameof(components));
            this.panel1 = panel1 ?? throw new ArgumentNullException(nameof(panel1));
            this.panel2 = panel2 ?? throw new ArgumentNullException(nameof(panel2));
            this.panel3 = panel3 ?? throw new ArgumentNullException(nameof(panel3));
            this.panel4 = panel4 ?? throw new ArgumentNullException(nameof(panel4));
            this.textNOM = textNOM ?? throw new ArgumentNullException(nameof(textNOM));
            this.panel5 = panel5 ?? throw new ArgumentNullException(nameof(panel5));
            this.label1 = label1 ?? throw new ArgumentNullException(nameof(label1));
            this.pictureBox1 = pictureBox1 ?? throw new ArgumentNullException(nameof(pictureBox1));
            this.bntsort = bntsort ?? throw new ArgumentNullException(nameof(bntsort));
            this.pictureBox2 = pictureBox2 ?? throw new ArgumentNullException(nameof(pictureBox2));
            this.label2 = label2 ?? throw new ArgumentNullException(nameof(label2));
            this.panel6 = panel6 ?? throw new ArgumentNullException(nameof(panel6));
            this.textPrenom = textPrenom ?? throw new ArgumentNullException(nameof(textPrenom));
            this.pictureBox3 = pictureBox3 ?? throw new ArgumentNullException(nameof(pictureBox3));
            this.label3 = label3 ?? throw new ArgumentNullException(nameof(label3));
            this.panel7 = panel7 ?? throw new ArgumentNullException(nameof(panel7));
            this.textadrs = textadrs ?? throw new ArgumentNullException(nameof(textadrs));
            this.pictureBox4 = pictureBox4 ?? throw new ArgumentNullException(nameof(pictureBox4));
            this.label4 = label4 ?? throw new ArgumentNullException(nameof(label4));
            this.panel8 = panel8 ?? throw new ArgumentNullException(nameof(panel8));
            this.texttel = texttel ?? throw new ArgumentNullException(nameof(texttel));
            this.pictureBox5 = pictureBox5 ?? throw new ArgumentNullException(nameof(pictureBox5));
            this.label5 = label5 ?? throw new ArgumentNullException(nameof(label5));
            this.panel9 = panel9 ?? throw new ArgumentNullException(nameof(panel9));
            this.texville = texville ?? throw new ArgumentNullException(nameof(texville));
            this.bntenreg = bntenreg ?? throw new ArgumentNullException(nameof(bntenreg));
            this.labtitre = labtitre ?? throw new ArgumentNullException(nameof(labtitre));
            this.bntactu = bntactu ?? throw new ArgumentNullException(nameof(bntactu));
            Mycnx = mycnx ?? throw new ArgumentNullException(nameof(mycnx));
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
        private Label label6;
        private Panel panel10;
        private TextBox textID;
    }
}