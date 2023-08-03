using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_gestion
{
    public partial class parametres : Form
    {
        public parametres()
        {
            InitializeComponent();
        }

        private void parametres_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("     Etes vous sure de se deconnecter?", "Attention", MessageBoxButtons.YesNoCancel);
            if (dr == DialogResult.Yes)
            {
                this.Dispose(); // ou Close()
                Application.OpenForms["MenuPrincipal"].Dispose();
                login l = new login();
                l.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acces fen = new acces();
            fen.Show();

        }
         public void acces_au_parametre(bool test)
        { //this.pictureBox2.Visible = false;
           acces_pic.Visible = test;
            acces_btn.Visible = test;
        }
    }
}
