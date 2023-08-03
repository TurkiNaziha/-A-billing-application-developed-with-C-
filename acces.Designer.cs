
namespace Application_gestion
{
    partial class acces
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(acces));
            this.supprimer = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.modifier = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.list_users = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nom_user = new System.Windows.Forms.TextBox();
            this.mdp_user = new System.Windows.Forms.TextBox();
            this.user_CIN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.supp_fact = new System.Windows.Forms.CheckBox();
            this.modif_fact = new System.Windows.Forms.CheckBox();
            this.aj_fact = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.typ_user = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supp_cli = new System.Windows.Forms.CheckBox();
            this.modif_cli = new System.Windows.Forms.CheckBox();
            this.aj_cli = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.supp_prod = new System.Windows.Forms.CheckBox();
            this.modif_prod = new System.Windows.Forms.CheckBox();
            this.aj_prod = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.vide = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.SystemColors.Control;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(497, 30);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(122, 46);
            this.supprimer.TabIndex = 10;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            this.supprimer.Click += new System.EventHandler(this.button1_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.SystemColors.Control;
            this.fermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fermer.Location = new System.Drawing.Point(936, 30);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(122, 46);
            this.fermer.TabIndex = 11;
            this.fermer.Text = "Fermer";
            this.fermer.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vide);
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.modifier);
            this.panel1.Controls.Add(this.supprimer);
            this.panel1.Controls.Add(this.fermer);
            this.panel1.Location = new System.Drawing.Point(25, 381);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 100);
            this.panel1.TabIndex = 12;
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.SystemColors.Control;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(271, 30);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(122, 46);
            this.modifier.TabIndex = 12;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.SystemColors.Control;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.Location = new System.Drawing.Point(44, 30);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(122, 46);
            this.ajouter.TabIndex = 13;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(9, 366);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(640, 374);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // list_users
            // 
            this.list_users.FormattingEnabled = true;
            this.list_users.Location = new System.Drawing.Point(193, 48);
            this.list_users.Name = "list_users";
            this.list_users.Size = new System.Drawing.Size(443, 33);
            this.list_users.TabIndex = 12;
            this.list_users.SelectedIndexChanged += new System.EventHandler(this.list_users_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Liste d\'utilisateurs";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // nom_user
            // 
            this.nom_user.Location = new System.Drawing.Point(179, 128);
            this.nom_user.Name = "nom_user";
            this.nom_user.Size = new System.Drawing.Size(146, 30);
            this.nom_user.TabIndex = 16;
            // 
            // mdp_user
            // 
            this.mdp_user.Location = new System.Drawing.Point(179, 173);
            this.mdp_user.Name = "mdp_user";
            this.mdp_user.Size = new System.Drawing.Size(146, 30);
            this.mdp_user.TabIndex = 17;
            // 
            // user_CIN
            // 
            this.user_CIN.Location = new System.Drawing.Point(179, 225);
            this.user_CIN.Name = "user_CIN";
            this.user_CIN.Size = new System.Drawing.Size(146, 30);
            this.user_CIN.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "CIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mot de passe";
            // 
            // supp_fact
            // 
            this.supp_fact.AutoSize = true;
            this.supp_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_fact.ForeColor = System.Drawing.Color.Black;
            this.supp_fact.Location = new System.Drawing.Point(6, 103);
            this.supp_fact.Name = "supp_fact";
            this.supp_fact.Size = new System.Drawing.Size(224, 28);
            this.supp_fact.TabIndex = 23;
            this.supp_fact.Text = "Supprimer une facture ";
            this.supp_fact.UseVisualStyleBackColor = true;
            // 
            // modif_fact
            // 
            this.modif_fact.AutoSize = true;
            this.modif_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif_fact.ForeColor = System.Drawing.Color.Black;
            this.modif_fact.Location = new System.Drawing.Point(6, 68);
            this.modif_fact.Name = "modif_fact";
            this.modif_fact.Size = new System.Drawing.Size(198, 28);
            this.modif_fact.TabIndex = 24;
            this.modif_fact.Text = "Modifier une facture";
            this.modif_fact.UseVisualStyleBackColor = true;
            // 
            // aj_fact
            // 
            this.aj_fact.AutoSize = true;
            this.aj_fact.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aj_fact.ForeColor = System.Drawing.Color.Black;
            this.aj_fact.Location = new System.Drawing.Point(6, 32);
            this.aj_fact.Name = "aj_fact";
            this.aj_fact.Size = new System.Drawing.Size(191, 28);
            this.aj_fact.TabIndex = 25;
            this.aj_fact.Text = "Ajouter une facture";
            this.aj_fact.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(40, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 24);
            this.label5.TabIndex = 27;
            this.label5.Text = "Type";
            // 
            // typ_user
            // 
            this.typ_user.FormattingEnabled = true;
            this.typ_user.Location = new System.Drawing.Point(179, 275);
            this.typ_user.Name = "typ_user";
            this.typ_user.Size = new System.Drawing.Size(146, 33);
            this.typ_user.TabIndex = 28;
            this.typ_user.SelectedIndexChanged += new System.EventHandler(this.typ_user_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.aj_cli);
            this.groupBox1.Controls.Add(this.modif_cli);
            this.groupBox1.Controls.Add(this.supp_cli);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(358, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 134);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // supp_cli
            // 
            this.supp_cli.AutoSize = true;
            this.supp_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_cli.ForeColor = System.Drawing.Color.Black;
            this.supp_cli.Location = new System.Drawing.Point(6, 93);
            this.supp_cli.Name = "supp_cli";
            this.supp_cli.Size = new System.Drawing.Size(196, 28);
            this.supp_cli.TabIndex = 2;
            this.supp_cli.Text = "Supprimer un client";
            this.supp_cli.UseVisualStyleBackColor = true;
            // 
            // modif_cli
            // 
            this.modif_cli.AutoSize = true;
            this.modif_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif_cli.ForeColor = System.Drawing.Color.Black;
            this.modif_cli.Location = new System.Drawing.Point(6, 59);
            this.modif_cli.Name = "modif_cli";
            this.modif_cli.Size = new System.Drawing.Size(175, 28);
            this.modif_cli.TabIndex = 8;
            this.modif_cli.Text = "Modifier un client";
            this.modif_cli.UseVisualStyleBackColor = true;
            // 
            // aj_cli
            // 
            this.aj_cli.AutoSize = true;
            this.aj_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aj_cli.ForeColor = System.Drawing.Color.Black;
            this.aj_cli.Location = new System.Drawing.Point(6, 29);
            this.aj_cli.Name = "aj_cli";
            this.aj_cli.Size = new System.Drawing.Size(168, 28);
            this.aj_cli.TabIndex = 7;
            this.aj_cli.Text = "Ajouter un client";
            this.aj_cli.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aj_prod);
            this.groupBox2.Controls.Add(this.modif_prod);
            this.groupBox2.Controls.Add(this.supp_prod);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(601, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 134);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Article";
            // 
            // supp_prod
            // 
            this.supp_prod.AutoSize = true;
            this.supp_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supp_prod.ForeColor = System.Drawing.Color.Black;
            this.supp_prod.Location = new System.Drawing.Point(6, 96);
            this.supp_prod.Name = "supp_prod";
            this.supp_prod.Size = new System.Drawing.Size(206, 28);
            this.supp_prod.TabIndex = 21;
            this.supp_prod.Text = " Supprimer un article";
            this.supp_prod.UseVisualStyleBackColor = true;
            // 
            // modif_prod
            // 
            this.modif_prod.AutoSize = true;
            this.modif_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modif_prod.ForeColor = System.Drawing.Color.Black;
            this.modif_prod.Location = new System.Drawing.Point(6, 59);
            this.modif_prod.Name = "modif_prod";
            this.modif_prod.Size = new System.Drawing.Size(180, 28);
            this.modif_prod.TabIndex = 22;
            this.modif_prod.Text = "Modifier un article";
            this.modif_prod.UseVisualStyleBackColor = true;
            // 
            // aj_prod
            // 
            this.aj_prod.AutoSize = true;
            this.aj_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aj_prod.ForeColor = System.Drawing.Color.Black;
            this.aj_prod.Location = new System.Drawing.Point(6, 29);
            this.aj_prod.Name = "aj_prod";
            this.aj_prod.Size = new System.Drawing.Size(173, 28);
            this.aj_prod.TabIndex = 6;
            this.aj_prod.Text = "Ajouter un article";
            this.aj_prod.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.aj_fact);
            this.groupBox5.Controls.Add(this.modif_fact);
            this.groupBox5.Controls.Add(this.supp_fact);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(854, 135);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 137);
            this.groupBox5.TabIndex = 30;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Facture";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.typ_user);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.user_CIN);
            this.groupBox3.Controls.Add(this.mdp_user);
            this.groupBox3.Controls.Add(this.nom_user);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.list_users);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.groupBox3.Location = new System.Drawing.Point(25, 34);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1101, 325);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Droit d\'acces de chaque utilistaur";
            // 
            // vide
            // 
            this.vide.BackColor = System.Drawing.SystemColors.Control;
            this.vide.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vide.Location = new System.Drawing.Point(704, 30);
            this.vide.Name = "vide";
            this.vide.Size = new System.Drawing.Size(122, 46);
            this.vide.TabIndex = 14;
            this.vide.Text = "Vider";
            this.vide.UseVisualStyleBackColor = false;
            this.vide.Click += new System.EventHandler(this.vide_Click);
            // 
            // acces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1139, 527);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "acces";
            this.Text = "acces";
            this.Load += new System.EventHandler(this.acces_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox list_users;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nom_user;
        private System.Windows.Forms.TextBox mdp_user;
        private System.Windows.Forms.TextBox user_CIN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox supp_fact;
        private System.Windows.Forms.CheckBox modif_fact;
        private System.Windows.Forms.CheckBox aj_fact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox typ_user;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox aj_cli;
        private System.Windows.Forms.CheckBox modif_cli;
        private System.Windows.Forms.CheckBox supp_cli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox aj_prod;
        private System.Windows.Forms.CheckBox modif_prod;
        private System.Windows.Forms.CheckBox supp_prod;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button vide;
    }
}