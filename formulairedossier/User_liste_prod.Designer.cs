namespace gstion_de_commande.formulairedossier
{
    partial class User_liste_prod
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User_liste_prod));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comborech = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bntsuppPROD = new System.Windows.Forms.Button();
            this.bntajoutPROD = new System.Windows.Forms.Button();
            this.dvgprod = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.combofiltre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).BeginInit();
            this.SuspendLayout();
            // 
            // comborech
            // 
            this.comborech.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comborech.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comborech.FormattingEnabled = true;
            this.comborech.Items.AddRange(new object[] {
            "Toutes les catégories",
            "telephone",
            "vetement ",
            "accessoire"});
            this.comborech.Location = new System.Drawing.Point(307, 137);
            this.comborech.Name = "comborech";
            this.comborech.Size = new System.Drawing.Size(259, 38);
            this.comborech.TabIndex = 34;
            this.comborech.SelectedIndexChanged += new System.EventHandler(this.comborech_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel3.Location = new System.Drawing.Point(622, 181);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 3);
            this.panel3.TabIndex = 33;
            // 
            // txtrecherche
            // 
            this.txtrecherche.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtrecherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.Color.Black;
            this.txtrecherche.Location = new System.Drawing.Point(622, 132);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(332, 43);
            this.txtrecherche.TabIndex = 32;
            this.txtrecherche.Text = "recherche ";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel2.Location = new System.Drawing.Point(14, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1429, 3);
            this.panel2.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.panel1.Location = new System.Drawing.Point(14, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1429, 3);
            this.panel1.TabIndex = 30;
            // 
            // bntsuppPROD
            // 
            this.bntsuppPROD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bntsuppPROD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntsuppPROD.FlatAppearance.BorderSize = 0;
            this.bntsuppPROD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntsuppPROD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntsuppPROD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntsuppPROD.Image = ((System.Drawing.Image)(resources.GetObject("bntsuppPROD.Image")));
            this.bntsuppPROD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntsuppPROD.Location = new System.Drawing.Point(841, 16);
            this.bntsuppPROD.Name = "bntsuppPROD";
            this.bntsuppPROD.Size = new System.Drawing.Size(364, 77);
            this.bntsuppPROD.TabIndex = 29;
            this.bntsuppPROD.Text = "supprimer";
            this.bntsuppPROD.UseVisualStyleBackColor = false;
            this.bntsuppPROD.Click += new System.EventHandler(this.bntsuppPROD_Click);
            // 
            // bntajoutPROD
            // 
            this.bntajoutPROD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.bntajoutPROD.FlatAppearance.BorderSize = 0;
            this.bntajoutPROD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntajoutPROD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntajoutPROD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bntajoutPROD.Image = ((System.Drawing.Image)(resources.GetObject("bntajoutPROD.Image")));
            this.bntajoutPROD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntajoutPROD.Location = new System.Drawing.Point(256, 16);
            this.bntajoutPROD.Name = "bntajoutPROD";
            this.bntajoutPROD.Size = new System.Drawing.Size(378, 77);
            this.bntajoutPROD.TabIndex = 27;
            this.bntajoutPROD.Text = "Ajouter";
            this.bntajoutPROD.UseVisualStyleBackColor = false;
            this.bntajoutPROD.Click += new System.EventHandler(this.bntajoutPROD_Click);
            // 
            // dvgprod
            // 
            this.dvgprod.AllowUserToAddRows = false;
            this.dvgprod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgprod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgprod.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgprod.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dvgprod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgprod.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dvgprod.EnableHeadersVisualStyles = false;
            this.dvgprod.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dvgprod.Location = new System.Drawing.Point(14, 226);
            this.dvgprod.Name = "dvgprod";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgprod.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgprod.RowHeadersVisible = false;
            this.dvgprod.RowHeadersWidth = 62;
            this.dvgprod.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgprod.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dvgprod.RowTemplate.Height = 28;
            this.dvgprod.Size = new System.Drawing.Size(1429, 592);
            this.dvgprod.TabIndex = 35;
            this.dvgprod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgprod_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Select";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(22, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 26);
            this.label1.TabIndex = 36;
            this.label1.Text = "choisire une categorie :";
            // 
            // combofiltre
            // 
            this.combofiltre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.combofiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combofiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combofiltre.FormattingEnabled = true;
            this.combofiltre.Items.AddRange(new object[] {
            "Du moins cher au plus cher",
            "Du plus cher au moins cher"});
            this.combofiltre.Location = new System.Drawing.Point(1109, 132);
            this.combofiltre.Name = "combofiltre";
            this.combofiltre.Size = new System.Drawing.Size(334, 38);
            this.combofiltre.TabIndex = 37;
            this.combofiltre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(866, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "selectioner le filtre:";
            // 
            // User_liste_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combofiltre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comborech);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bntsuppPROD);
            this.Controls.Add(this.bntajoutPROD);
            this.Controls.Add(this.dvgprod);
            this.Name = "User_liste_prod";
            this.Size = new System.Drawing.Size(1457, 834);
            this.Load += new System.EventHandler(this.User_liste_prod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgprod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comborech;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bntsuppPROD;
        private System.Windows.Forms.Button bntajoutPROD;
        private System.Windows.Forms.DataGridView dvgprod;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combofiltre;
        private System.Windows.Forms.Label label2;
    }
}
