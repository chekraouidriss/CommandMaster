namespace gstion_de_commande.formulairedossier
{
    partial class form_ajouter_modifier_PROD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_ajouter_modifier_PROD));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labtitre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNOMPROD = new System.Windows.Forms.TextBox();
            this.textQUANT = new System.Windows.Forms.TextBox();
            this.textPRIX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bntactu = new System.Windows.Forms.Button();
            this.bntsort = new System.Windows.Forms.Button();
            this.textcat = new System.Windows.Forms.TextBox();
            this.bntenreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(817, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 467);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 3);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 464);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 464);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(814, 3);
            this.panel4.TabIndex = 3;
            // 
            // labtitre
            // 
            this.labtitre.AutoSize = true;
            this.labtitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labtitre.Location = new System.Drawing.Point(271, 33);
            this.labtitre.Name = "labtitre";
            this.labtitre.Size = new System.Drawing.Size(396, 52);
            this.labtitre.TabIndex = 5;
            this.labtitre.Text = "Ajouter un produit ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Categorie :";
            // 
            // textNOMPROD
            // 
            this.textNOMPROD.Location = new System.Drawing.Point(228, 128);
            this.textNOMPROD.Multiline = true;
            this.textNOMPROD.Name = "textNOMPROD";
            this.textNOMPROD.Size = new System.Drawing.Size(271, 42);
            this.textNOMPROD.TabIndex = 11;
            this.textNOMPROD.TextChanged += new System.EventHandler(this.textNOMPROD_TextChanged);
            this.textNOMPROD.Enter += new System.EventHandler(this.textNOMPROD_Enter);
            // 
            // textQUANT
            // 
            this.textQUANT.Location = new System.Drawing.Point(228, 206);
            this.textQUANT.Multiline = true;
            this.textQUANT.Name = "textQUANT";
            this.textQUANT.Size = new System.Drawing.Size(271, 42);
            this.textQUANT.TabIndex = 12;
            // 
            // textPRIX
            // 
            this.textPRIX.Location = new System.Drawing.Point(228, 283);
            this.textPRIX.Multiline = true;
            this.textPRIX.Name = "textPRIX";
            this.textPRIX.Size = new System.Drawing.Size(271, 42);
            this.textPRIX.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(25, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 42);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nom : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(15, 206);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(184, 47);
            this.label4.TabIndex = 15;
            this.label4.Text = "    Quantitee :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(25, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 42);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prix :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bntactu
            // 
            this.bntactu.BackColor = System.Drawing.Color.Silver;
            this.bntactu.FlatAppearance.BorderSize = 0;
            this.bntactu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntactu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntactu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntactu.Location = new System.Drawing.Point(596, 300);
            this.bntactu.Name = "bntactu";
            this.bntactu.Size = new System.Drawing.Size(200, 52);
            this.bntactu.TabIndex = 29;
            this.bntactu.Text = "Actualiser";
            this.bntactu.UseVisualStyleBackColor = false;
            this.bntactu.Click += new System.EventHandler(this.bntactu_Click);
            // 
            // bntsort
            // 
            this.bntsort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntsort.FlatAppearance.BorderSize = 0;
            this.bntsort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsort.Image = ((System.Drawing.Image)(resources.GetObject("bntsort.Image")));
            this.bntsort.Location = new System.Drawing.Point(759, 3);
            this.bntsort.Name = "bntsort";
            this.bntsort.Size = new System.Drawing.Size(58, 52);
            this.bntsort.TabIndex = 30;
            this.bntsort.UseVisualStyleBackColor = false;
            this.bntsort.Click += new System.EventHandler(this.bntsort_Click);
            // 
            // textcat
            // 
            this.textcat.Location = new System.Drawing.Point(228, 375);
            this.textcat.Multiline = true;
            this.textcat.Name = "textcat";
            this.textcat.Size = new System.Drawing.Size(271, 42);
            this.textcat.TabIndex = 33;
            this.textcat.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bntenreg
            // 
            this.bntenreg.BackColor = System.Drawing.Color.Silver;
            this.bntenreg.FlatAppearance.BorderSize = 0;
            this.bntenreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntenreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntenreg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bntenreg.Location = new System.Drawing.Point(596, 167);
            this.bntenreg.Name = "bntenreg";
            this.bntenreg.Size = new System.Drawing.Size(200, 53);
            this.bntenreg.TabIndex = 34;
            this.bntenreg.Text = "Enregistrer";
            this.bntenreg.UseVisualStyleBackColor = false;
            this.bntenreg.Click += new System.EventHandler(this.bntenreg_Click_1);
            // 
            // form_ajouter_modifier_PROD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(820, 467);
            this.Controls.Add(this.bntenreg);
            this.Controls.Add(this.textcat);
            this.Controls.Add(this.bntsort);
            this.Controls.Add(this.bntactu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPRIX);
            this.Controls.Add(this.textQUANT);
            this.Controls.Add(this.textNOMPROD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labtitre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "form_ajouter_modifier_PROD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_ajouter_modifier_PROD";
            this.Load += new System.EventHandler(this.form_ajouter_modifier_PROD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label labtitre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNOMPROD;
        private System.Windows.Forms.TextBox textQUANT;
        private System.Windows.Forms.TextBox textPRIX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button bntactu;
        private System.Windows.Forms.Button bntsort;
        private System.Windows.Forms.TextBox textcat;
        private System.Windows.Forms.Button bntenreg;
    }
}