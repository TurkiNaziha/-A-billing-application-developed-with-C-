
namespace Application_gestion
{
    partial class parametres
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
            this.acces_btn = new System.Windows.Forms.Button();
            this.deconnexion_btn = new System.Windows.Forms.Button();
            this.acces_pic = new System.Windows.Forms.PictureBox();
            this.deconnexion_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.acces_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deconnexion_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // acces_btn
            // 
            this.acces_btn.BackColor = System.Drawing.Color.White;
            this.acces_btn.FlatAppearance.BorderSize = 0;
            this.acces_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acces_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acces_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.acces_btn.Location = new System.Drawing.Point(1295, 534);
            this.acces_btn.Name = "acces_btn";
            this.acces_btn.Size = new System.Drawing.Size(308, 73);
            this.acces_btn.TabIndex = 18;
            this.acces_btn.Text = "Accessibilité";
            this.acces_btn.UseVisualStyleBackColor = false;
            this.acces_btn.UseWaitCursor = true;
            this.acces_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // deconnexion_btn
            // 
            this.deconnexion_btn.BackColor = System.Drawing.Color.White;
            this.deconnexion_btn.FlatAppearance.BorderSize = 0;
            this.deconnexion_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deconnexion_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deconnexion_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(152)))), ((int)(((byte)(206)))));
            this.deconnexion_btn.Location = new System.Drawing.Point(234, 545);
            this.deconnexion_btn.Name = "deconnexion_btn";
            this.deconnexion_btn.Size = new System.Drawing.Size(304, 62);
            this.deconnexion_btn.TabIndex = 16;
            this.deconnexion_btn.Text = "Déconnexion";
            this.deconnexion_btn.UseVisualStyleBackColor = false;
            this.deconnexion_btn.UseWaitCursor = true;
            this.deconnexion_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // acces_pic
            // 
            this.acces_pic.Image = global::Application_gestion.Properties.Resources.utilisateur;
            this.acces_pic.Location = new System.Drawing.Point(1311, 268);
            this.acces_pic.Name = "acces_pic";
            this.acces_pic.Size = new System.Drawing.Size(304, 245);
            this.acces_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.acces_pic.TabIndex = 17;
            this.acces_pic.TabStop = false;
            this.acces_pic.UseWaitCursor = true;
            // 
            // deconnexion_pic
            // 
            this.deconnexion_pic.Image = global::Application_gestion.Properties.Resources.se_deconnecter;
            this.deconnexion_pic.Location = new System.Drawing.Point(234, 268);
            this.deconnexion_pic.Name = "deconnexion_pic";
            this.deconnexion_pic.Size = new System.Drawing.Size(304, 245);
            this.deconnexion_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.deconnexion_pic.TabIndex = 15;
            this.deconnexion_pic.TabStop = false;
            this.deconnexion_pic.UseWaitCursor = true;
            // 
            // parametres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1942, 872);
            this.ControlBox = false;
            this.Controls.Add(this.deconnexion_btn);
            this.Controls.Add(this.acces_pic);
            this.Controls.Add(this.acces_btn);
            this.Controls.Add(this.deconnexion_pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "parametres";
            this.Text = "parametres";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.parametres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.acces_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deconnexion_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button acces_btn;
        public System.Windows.Forms.PictureBox deconnexion_pic;
        private System.Windows.Forms.PictureBox acces_pic;
        private System.Windows.Forms.Button deconnexion_btn;
    }
}