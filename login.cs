using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using des_objets;
using DAO;

namespace Application_gestion
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static public Login user_actuelle;
        static public Login get_userActuelle() { return user_actuelle; }
        static public Boolean est_admin;
        static public Boolean get_estAdmin() { return est_admin; }
        private void button1_Click(object sender, EventArgs e)
        {
            
            Boolean trouve = false;
            if ((username.Text == "") || (mdp.Text == ""))
                MessageBox.Show("verifier les champs vides");

            else
            {
                MenuPrincipal fen = new MenuPrincipal();
                List<Login> leslogins = loginDAO.afficher();
                Login la = new Login(username.Text, mdp.Text, "", 0, false, false, false, false,
                    false, false, false, false, false);

                foreach (Login l in leslogins)
                {
                    if (l.Equals(la))
                    { //condition admin
                        trouve = true;
                        if (l.Typ == "admin")
                        {
                            fen.Show();
                            this.Visible = false;
                            est_admin = true;
                            break;
                        }
                        //condition des autres employes
                        else
                        {
                            user_actuelle = l;
                            fen.Show();
                            this.Visible = false;
                            est_admin = false;
                            break;
                        }
                    }

                }
                if (trouve == false)
                {
                    MessageBox.Show("verifier votre username or mot de passe");
                    username.Clear();
                    mdp.Clear();

                }
            }
            /*
            MenuPrincipal fen = new MenuPrincipal();
            est_admin = true;
            fen.Show();
            this.Visible = false;
            */
        }

        private void login_Load(object sender, EventArgs e)
        {
           
        }
    }
}
