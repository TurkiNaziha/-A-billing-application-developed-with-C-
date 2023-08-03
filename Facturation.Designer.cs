
namespace Application_gestion
{
    partial class Facturation
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
            this.SL = new System.Windows.Forms.Button();
            this.lab = new System.Windows.Forms.Label();
            this.MT = new System.Windows.Forms.TextBox();
            this.lab3 = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.Button();
            this.prix_vente = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Enregitsrer = new System.Windows.Forms.Button();
            this.vider = new System.Windows.Forms.Button();
            this.QES = new System.Windows.Forms.TextBox();
            this.lab7 = new System.Windows.Forms.Label();
            this.lab5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.list_prod = new System.Windows.Forms.ComboBox();
            this.lab6 = new System.Windows.Forms.Label();
            this.lab4 = new System.Windows.Forms.Label();
            this.qte = new System.Windows.Forms.TextBox();
            this.list_ligne = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prix_de_vente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdtotale = new System.Windows.Forms.RadioButton();
            this.Partielle = new System.Windows.Forms.RadioButton();
            this.num = new System.Windows.Forms.TextBox();
            this.lab2 = new System.Windows.Forms.Label();
            this.dtpfacture = new System.Windows.Forms.DateTimePicker();
            this.lab1 = new System.Windows.Forms.Label();
            this.list_fact = new System.Windows.Forms.DataGridView();
            this.facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant_tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cli_list = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.indice_code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.indice_cli = new System.Windows.Forms.TextBox();
            this.indice_dte = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_ligne)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_fact)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SL
            // 
            this.SL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SL.Location = new System.Drawing.Point(615, 104);
            this.SL.Name = "SL";
            this.SL.Size = new System.Drawing.Size(224, 40);
            this.SL.TabIndex = 16;
            this.SL.Text = "Supprimer_Ligne";
            this.SL.UseVisualStyleBackColor = true;
            this.SL.Click += new System.EventHandler(this.SL_Click);
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.Location = new System.Drawing.Point(115, 618);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(123, 24);
            this.lab.TabIndex = 17;
            this.lab.Text = "Montant Total";
            // 
            // MT
            // 
            this.MT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MT.Location = new System.Drawing.Point(336, 618);
            this.MT.Name = "MT";
            this.MT.Size = new System.Drawing.Size(160, 26);
            this.MT.TabIndex = 17;
            // 
            // lab3
            // 
            this.lab3.AutoSize = true;
            this.lab3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab3.Location = new System.Drawing.Point(34, 154);
            this.lab3.Name = "lab3";
            this.lab3.Size = new System.Drawing.Size(48, 24);
            this.lab3.TabIndex = 1;
            this.lab3.Text = "Date";
            // 
            // AL
            // 
            this.AL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AL.Location = new System.Drawing.Point(615, 30);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(213, 40);
            this.AL.TabIndex = 15;
            this.AL.Text = "Ajouter_Ligne";
            this.AL.UseVisualStyleBackColor = true;
            this.AL.Click += new System.EventHandler(this.AL_Click);
            // 
            // prix_vente
            // 
            this.prix_vente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prix_vente.Location = new System.Drawing.Point(485, 109);
            this.prix_vente.Name = "prix_vente";
            this.prix_vente.Size = new System.Drawing.Size(100, 26);
            this.prix_vente.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Enregitsrer);
            this.panel4.Controls.Add(this.vider);
            this.panel4.Location = new System.Drawing.Point(38, 727);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 79);
            this.panel4.TabIndex = 18;
            // 
            // Enregitsrer
            // 
            this.Enregitsrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enregitsrer.Location = new System.Drawing.Point(410, 22);
            this.Enregitsrer.Name = "Enregitsrer";
            this.Enregitsrer.Size = new System.Drawing.Size(154, 40);
            this.Enregitsrer.TabIndex = 17;
            this.Enregitsrer.Text = "Enregitsrer";
            this.Enregitsrer.UseVisualStyleBackColor = true;
            this.Enregitsrer.Click += new System.EventHandler(this.Enregitsrer_Click);
            // 
            // vider
            // 
            this.vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vider.Location = new System.Drawing.Point(76, 23);
            this.vider.Name = "vider";
            this.vider.Size = new System.Drawing.Size(128, 40);
            this.vider.TabIndex = 18;
            this.vider.Text = "Vider";
            this.vider.UseVisualStyleBackColor = true;
            this.vider.Click += new System.EventHandler(this.vider_Click);
            // 
            // QES
            // 
            this.QES.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QES.Location = new System.Drawing.Point(218, 109);
            this.QES.Name = "QES";
            this.QES.Size = new System.Drawing.Size(121, 26);
            this.QES.TabIndex = 13;
            this.QES.TextChanged += new System.EventHandler(this.QES_TextChanged);
            // 
            // lab7
            // 
            this.lab7.AutoSize = true;
            this.lab7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab7.Location = new System.Drawing.Point(349, 110);
            this.lab7.Name = "lab7";
            this.lab7.Size = new System.Drawing.Size(97, 24);
            this.lab7.TabIndex = 9;
            this.lab7.Text = "Prix Vente";
            // 
            // lab5
            // 
            this.lab5.AutoSize = true;
            this.lab5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab5.Location = new System.Drawing.Point(349, 34);
            this.lab5.Name = "lab5";
            this.lab5.Size = new System.Drawing.Size(80, 24);
            this.lab5.TabIndex = 10;
            this.lab5.Text = "Quantite";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.list_prod);
            this.panel3.Controls.Add(this.SL);
            this.panel3.Controls.Add(this.AL);
            this.panel3.Controls.Add(this.prix_vente);
            this.panel3.Controls.Add(this.QES);
            this.panel3.Controls.Add(this.lab7);
            this.panel3.Controls.Add(this.lab5);
            this.panel3.Controls.Add(this.lab6);
            this.panel3.Controls.Add(this.lab4);
            this.panel3.Controls.Add(this.qte);
            this.panel3.Location = new System.Drawing.Point(3, 251);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(853, 174);
            this.panel3.TabIndex = 7;
            // 
            // list_prod
            // 
            this.list_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_prod.FormattingEnabled = true;
            this.list_prod.Location = new System.Drawing.Point(145, 30);
            this.list_prod.Name = "list_prod";
            this.list_prod.Size = new System.Drawing.Size(152, 28);
            this.list_prod.TabIndex = 17;
            this.list_prod.SelectedIndexChanged += new System.EventHandler(this.list_prod_SelectedIndexChanged);
            // 
            // lab6
            // 
            this.lab6.AutoSize = true;
            this.lab6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab6.Location = new System.Drawing.Point(7, 109);
            this.lab6.Name = "lab6";
            this.lab6.Size = new System.Drawing.Size(160, 24);
            this.lab6.TabIndex = 11;
            this.lab6.Text = "Quantite En Stock";
            // 
            // lab4
            // 
            this.lab4.AutoSize = true;
            this.lab4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab4.Location = new System.Drawing.Point(24, 29);
            this.lab4.Name = "lab4";
            this.lab4.Size = new System.Drawing.Size(62, 24);
            this.lab4.TabIndex = 12;
            this.lab4.Text = "Article";
            // 
            // qte
            // 
            this.qte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qte.Location = new System.Drawing.Point(485, 30);
            this.qte.Name = "qte";
            this.qte.Size = new System.Drawing.Size(100, 26);
            this.qte.TabIndex = 4;
            this.qte.TextChanged += new System.EventHandler(this.qte_TextChanged);
            // 
            // list_ligne
            // 
            this.list_ligne.BackgroundColor = System.Drawing.Color.White;
            this.list_ligne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_ligne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Prod,
            this.quantite,
            this.prix_de_vente,
            this.total});
            this.list_ligne.Location = new System.Drawing.Point(37, 456);
            this.list_ligne.Name = "list_ligne";
            this.list_ligne.ReadOnly = true;
            this.list_ligne.RowHeadersWidth = 51;
            this.list_ligne.RowTemplate.Height = 24;
            this.list_ligne.Size = new System.Drawing.Size(782, 137);
            this.list_ligne.TabIndex = 19;
            this.list_ligne.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_ligne_CellClick);
            this.list_ligne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            this.Numero.ToolTipText = "22";
            this.Numero.Width = 125;
            // 
            // Prod
            // 
            this.Prod.HeaderText = "Article";
            this.Prod.MinimumWidth = 6;
            this.Prod.Name = "Prod";
            this.Prod.ReadOnly = true;
            this.Prod.ToolTipText = "Prod";
            this.Prod.Width = 125;
            // 
            // quantite
            // 
            this.quantite.HeaderText = "Quantite";
            this.quantite.MinimumWidth = 6;
            this.quantite.Name = "quantite";
            this.quantite.ReadOnly = true;
            this.quantite.Width = 125;
            // 
            // prix_de_vente
            // 
            this.prix_de_vente.HeaderText = "Prix De Vente";
            this.prix_de_vente.MinimumWidth = 6;
            this.prix_de_vente.Name = "prix_de_vente";
            this.prix_de_vente.ReadOnly = true;
            this.prix_de_vente.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "Total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdtotale);
            this.groupBox1.Controls.Add(this.Partielle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(407, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(412, 69);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Livraison";
            // 
            // rdtotale
            // 
            this.rdtotale.AutoSize = true;
            this.rdtotale.Location = new System.Drawing.Point(76, 25);
            this.rdtotale.Name = "rdtotale";
            this.rdtotale.Size = new System.Drawing.Size(72, 28);
            this.rdtotale.TabIndex = 9;
            this.rdtotale.TabStop = true;
            this.rdtotale.Text = "Total";
            this.rdtotale.UseVisualStyleBackColor = true;
            // 
            // Partielle
            // 
            this.Partielle.AutoSize = true;
            this.Partielle.Location = new System.Drawing.Point(249, 25);
            this.Partielle.Name = "Partielle";
            this.Partielle.Size = new System.Drawing.Size(97, 28);
            this.Partielle.TabIndex = 8;
            this.Partielle.TabStop = true;
            this.Partielle.Text = "Partielle";
            this.Partielle.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            this.num.BackColor = System.Drawing.Color.White;
            this.num.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num.Location = new System.Drawing.Point(148, 62);
            this.num.Name = "num";
            this.num.ReadOnly = true;
            this.num.Size = new System.Drawing.Size(156, 26);
            this.num.TabIndex = 3;
            // 
            // lab2
            // 
            this.lab2.AutoSize = true;
            this.lab2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab2.Location = new System.Drawing.Point(403, 66);
            this.lab2.Name = "lab2";
            this.lab2.Size = new System.Drawing.Size(57, 24);
            this.lab2.TabIndex = 2;
            this.lab2.Text = "Client";
            this.lab2.Click += new System.EventHandler(this.lab2_Click);
            // 
            // dtpfacture
            // 
            this.dtpfacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpfacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfacture.Location = new System.Drawing.Point(148, 154);
            this.dtpfacture.Name = "dtpfacture";
            this.dtpfacture.Size = new System.Drawing.Size(156, 26);
            this.dtpfacture.TabIndex = 8;
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab1.Location = new System.Drawing.Point(17, 60);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(79, 24);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "Numero";
            this.lab1.Click += new System.EventHandler(this.lab1_Click);
            // 
            // list_fact
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            this.list_fact.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.list_fact.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.list_fact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_fact.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facture,
            this.Client,
            this.Date,
            this.Montant_tot});
            this.list_fact.Location = new System.Drawing.Point(877, 116);
            this.list_fact.Name = "list_fact";
            this.list_fact.ReadOnly = true;
            this.list_fact.RowHeadersWidth = 51;
            this.list_fact.RowTemplate.Height = 24;
            this.list_fact.Size = new System.Drawing.Size(717, 637);
            this.list_fact.TabIndex = 4;
            this.list_fact.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_fact_CellClick);
            // 
            // facture
            // 
            this.facture.HeaderText = "num_Facture";
            this.facture.MinimumWidth = 6;
            this.facture.Name = "facture";
            this.facture.ReadOnly = true;
            this.facture.Width = 125;
            // 
            // Client
            // 
            this.Client.HeaderText = "Client";
            this.Client.MinimumWidth = 6;
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            this.Client.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 125;
            // 
            // Montant_tot
            // 
            this.Montant_tot.HeaderText = "Montant Total";
            this.Montant_tot.MinimumWidth = 6;
            this.Montant_tot.Name = "Montant_tot";
            this.Montant_tot.ReadOnly = true;
            this.Montant_tot.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.modifier);
            this.panel1.Controls.Add(this.supprimer);
            this.panel1.Location = new System.Drawing.Point(877, 783);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 79);
            this.panel1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(743, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Telecharger";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modifier
            // 
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.Location = new System.Drawing.Point(380, 23);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(169, 40);
            this.modifier.TabIndex = 1;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = true;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // supprimer
            // 
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.Location = new System.Drawing.Point(48, 21);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(169, 40);
            this.supprimer.TabIndex = 0;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = true;
            this.supprimer.Click += new System.EventHandler(this.supprimer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel2.Controls.Add(this.cli_list);
            this.panel2.Controls.Add(this.list_ligne);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lab);
            this.panel2.Controls.Add(this.MT);
            this.panel2.Controls.Add(this.dtpfacture);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.num);
            this.panel2.Controls.Add(this.lab2);
            this.panel2.Controls.Add(this.lab3);
            this.panel2.Controls.Add(this.lab1);
            this.panel2.Location = new System.Drawing.Point(12, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(859, 830);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // cli_list
            // 
            this.cli_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cli_list.FormattingEnabled = true;
            this.cli_list.Location = new System.Drawing.Point(488, 64);
            this.cli_list.Name = "cli_list";
            this.cli_list.Size = new System.Drawing.Size(331, 33);
            this.cli_list.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.label1.Location = new System.Drawing.Point(1615, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Rechereche par ";
            // 
            // indice_code
            // 
            this.indice_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indice_code.Location = new System.Drawing.Point(1709, 266);
            this.indice_code.Name = "indice_code";
            this.indice_code.Size = new System.Drawing.Size(172, 26);
            this.indice_code.TabIndex = 8;
            this.indice_code.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1601, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1609, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1600, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "ID_Client";
            // 
            // indice_cli
            // 
            this.indice_cli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indice_cli.Location = new System.Drawing.Point(1710, 312);
            this.indice_cli.Name = "indice_cli";
            this.indice_cli.Size = new System.Drawing.Size(172, 26);
            this.indice_cli.TabIndex = 13;
            this.indice_cli.TextChanged += new System.EventHandler(this.indice_cli_TextChanged);
            // 
            // indice_dte
            // 
            this.indice_dte.CustomFormat = "yyyy-mm-dd ";
            this.indice_dte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.indice_dte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.indice_dte.Location = new System.Drawing.Point(1693, 358);
            this.indice_dte.Name = "indice_dte";
            this.indice_dte.Size = new System.Drawing.Size(226, 26);
            this.indice_dte.TabIndex = 14;
            this.indice_dte.CloseUp += new System.EventHandler(this.indice_dte_CloseUp);
            this.indice_dte.ValueChanged += new System.EventHandler(this.indice_dte_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.label5.Location = new System.Drawing.Point(1135, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Les Factures";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Application_gestion.Properties.Resources.search_3;
            this.pictureBox1.Location = new System.Drawing.Point(1851, 210);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 44);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Facturation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 898);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.indice_dte);
            this.Controls.Add(this.indice_cli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.indice_code);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_fact);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturation";
            this.Text = "Facturation";
            this.Load += new System.EventHandler(this.Facturation_Load);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_ligne)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_fact)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SL;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox MT;
        private System.Windows.Forms.Label lab3;
        private System.Windows.Forms.Button AL;
        private System.Windows.Forms.TextBox prix_vente;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Enregitsrer;
        private System.Windows.Forms.Button vider;
        private System.Windows.Forms.TextBox QES;
        private System.Windows.Forms.Label lab7;
        private System.Windows.Forms.Label lab5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lab6;
        private System.Windows.Forms.Label lab4;
        private System.Windows.Forms.TextBox qte;
        private System.Windows.Forms.DataGridView list_ligne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdtotale;
        private System.Windows.Forms.RadioButton Partielle;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Label lab2;
        private System.Windows.Forms.DateTimePicker dtpfacture;
        private System.Windows.Forms.Label lab1;
        private System.Windows.Forms.DataGridView list_fact;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modifier;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox indice_code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox indice_cli;
        private System.Windows.Forms.DateTimePicker indice_dte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox list_prod;
        private System.Windows.Forms.ComboBox cli_list;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantite;
        private System.Windows.Forms.DataGridViewTextBoxColumn prix_de_vente;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant_tot;
    }
}