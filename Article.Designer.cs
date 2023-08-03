
namespace Application_gestion
{
    partial class Article
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Article));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fournis = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Prix_ach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cde = new System.Windows.Forms.TextBox();
            this.Designation = new System.Windows.Forms.TextBox();
            this.Quantite = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ajouter = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.NB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.indice = new System.Windows.Forms.TextBox();
            this.articles_list = new System.Windows.Forms.DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fourinisseur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recherche = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articles_list)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.AccessibleDescription = "border.color";
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.groupBox2.Controls.Add(this.fournis);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Prix_ach);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cde);
            this.groupBox2.Controls.Add(this.Designation);
            this.groupBox2.Controls.Add(this.Quantite);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.groupBox2.Location = new System.Drawing.Point(24, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(533, 397);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CARACTERISTIQUE D\'UN ARTICLE";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // fournis
            // 
            this.fournis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fournis.Location = new System.Drawing.Point(223, 333);
            this.fournis.Name = "fournis";
            this.fournis.Size = new System.Drawing.Size(253, 32);
            this.fournis.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fournisseur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Prix_ach
            // 
            this.Prix_ach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prix_ach.Location = new System.Drawing.Point(222, 274);
            this.Prix_ach.Name = "Prix_ach";
            this.Prix_ach.Size = new System.Drawing.Size(253, 32);
            this.Prix_ach.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(37, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 26);
            this.label7.TabIndex = 1;
            this.label7.Text = "Prix d\'achat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(35, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Code";
            // 
            // cde
            // 
            this.cde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cde.Location = new System.Drawing.Point(223, 75);
            this.cde.Name = "cde";
            this.cde.Size = new System.Drawing.Size(253, 32);
            this.cde.TabIndex = 4;
            this.cde.TextChanged += new System.EventHandler(this.reference_TextChanged);
            // 
            // Designation
            // 
            this.Designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Designation.Location = new System.Drawing.Point(222, 139);
            this.Designation.Name = "Designation";
            this.Designation.Size = new System.Drawing.Size(253, 32);
            this.Designation.TabIndex = 7;
            // 
            // Quantite
            // 
            this.Quantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantite.Location = new System.Drawing.Point(222, 208);
            this.Quantite.Name = "Quantite";
            this.Quantite.Size = new System.Drawing.Size(253, 32);
            this.Quantite.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(35, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(40, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 26);
            this.label8.TabIndex = 2;
            this.label8.Text = "Quantite en stock";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.modifier);
            this.panel1.Controls.Add(this.supprimer);
            this.panel1.Location = new System.Drawing.Point(24, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 115);
            this.panel1.TabIndex = 12;
            // 
            // ajouter
            // 
            this.ajouter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ajouter.BackColor = System.Drawing.Color.LightGray;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ajouter.Location = new System.Drawing.Point(71, 38);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(121, 45);
            this.ajouter.TabIndex = 0;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1005, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // modifier
            // 
            this.modifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(371, 40);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(118, 45);
            this.modifier.TabIndex = 2;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(650, 40);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(126, 45);
            this.supprimer.TabIndex = 1;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.label11.Location = new System.Drawing.Point(831, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Les Articles";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel5.Controls.Add(this.NB);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.Location = new System.Drawing.Point(584, 380);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 53);
            this.panel5.TabIndex = 13;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // NB
            // 
            this.NB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NB.Location = new System.Drawing.Point(231, 12);
            this.NB.Name = "NB";
            this.NB.Size = new System.Drawing.Size(320, 32);
            this.NB.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(23, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre d\'Articles";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // indice
            // 
            this.indice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indice.Location = new System.Drawing.Point(584, 81);
            this.indice.Name = "indice";
            this.indice.Size = new System.Drawing.Size(571, 34);
            this.indice.TabIndex = 16;
            this.indice.TextChanged += new System.EventHandler(this.indice_TextChanged);
            // 
            // articles_list
            // 
            this.articles_list.AccessibleDescription = "ControlPaint.DrawBorder(e.Graphics, this.panel1.ClientRectangle, Color.Red, Butto" +
    "nBorderStyle.Solid);";
            this.articles_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.articles_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.articles_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.articles_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Designa,
            this.Quant,
            this.Prix,
            this.Fourinisseur});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.articles_list.DefaultCellStyle = dataGridViewCellStyle2;
            this.articles_list.Location = new System.Drawing.Point(584, 124);
            this.articles_list.Name = "articles_list";
            this.articles_list.RowHeadersWidth = 51;
            this.articles_list.RowTemplate.Height = 24;
            this.articles_list.Size = new System.Drawing.Size(634, 250);
            this.articles_list.TabIndex = 18;
            this.articles_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articles_list_CellClick);
            this.articles_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.articles_list_CellContentClick);
            // 
            // code
            // 
            this.code.HeaderText = "code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            this.code.Width = 125;
            // 
            // Designa
            // 
            this.Designa.HeaderText = "Designation";
            this.Designa.MinimumWidth = 6;
            this.Designa.Name = "Designa";
            this.Designa.Width = 125;
            // 
            // Quant
            // 
            this.Quant.HeaderText = "Quantite";
            this.Quant.MinimumWidth = 6;
            this.Quant.Name = "Quant";
            this.Quant.Width = 125;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix d\'achat";
            this.Prix.MinimumWidth = 6;
            this.Prix.Name = "Prix";
            this.Prix.Width = 125;
            // 
            // Fourinisseur
            // 
            this.Fourinisseur.HeaderText = "Fourinisseur";
            this.Fourinisseur.MinimumWidth = 6;
            this.Fourinisseur.Name = "Fourinisseur";
            this.Fourinisseur.Width = 125;
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.Color.White;
            this.recherche.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.recherche.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recherche.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.recherche.FlatAppearance.BorderSize = 0;
            this.recherche.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.recherche.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recherche.ForeColor = System.Drawing.Color.White;
            this.recherche.Image = ((System.Drawing.Image)(resources.GetObject("recherche.Image")));
            this.recherche.Location = new System.Drawing.Point(1161, 78);
            this.recherche.Name = "recherche";
            this.recherche.Size = new System.Drawing.Size(57, 40);
            this.recherche.TabIndex = 17;
            this.recherche.UseVisualStyleBackColor = false;
            this.recherche.Click += new System.EventHandler(this.button5_Click);
            // 
            // Article
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1230, 587);
            this.ControlBox = false;
            this.Controls.Add(this.articles_list);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.indice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Article";
            this.Text = "Article";
            this.Load += new System.EventHandler(this.Article_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.articles_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox Prix_ach;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cde;
        private System.Windows.Forms.TextBox Designation;
        private System.Windows.Forms.TextBox Quantite;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox NB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox fournis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox indice;
        private System.Windows.Forms.Button recherche;
        private System.Windows.Forms.DataGridView articles_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fourinisseur;
    }
}