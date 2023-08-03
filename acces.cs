using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using des_objets;
using DAO;

namespace Application_gestion
{
    public partial class acces : Form
    {
        public acces()
        {
            InitializeComponent();
        }

        private void acces_Load(object sender, EventArgs e)
        {
            list_users.Items.Clear();
            
           
            list_users.Items.AddRange(loginDAO.afficher().ToArray());
            if(list_users.Items.Count>0)
            list_users.SelectedIndex = 0;
            
            ajouter.Enabled = true;
            supprimer.Enabled = false;
            modifier.Enabled = false;
            
            typ_user.Items.Clear();
            string[] choix = new string[] { "admin", "employe" };
            typ_user.Items.AddRange(choix);
            typ_user.SelectedIndex = 0;
            vider();

        }
        public void vider()
        {
            nom_user.Clear();
            user_CIN.Clear();
            
            mdp_user.Clear();
            aj_cli.Checked =false;
            modif_cli.Checked = false;
            supp_cli.Checked = false;
            aj_prod.Checked = false;
            modif_prod.Checked = false;
            supp_prod.Checked = false;
            aj_fact.Checked = false;
            modif_fact.Checked = false;
            supp_fact.Checked = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if ((nom_user.Text == "") || (mdp_user.Text == "") || (user_CIN.Text == ""))
                MessageBox.Show("verifier les champs vides");
            else
            {
                
                List<Login> leslogins = loginDAO.afficher();
                bool trouve;
                Login la = new Login(nom_user.Text, mdp_user.Text, typ_user.Text, Convert.ToInt32(user_CIN.Text), aj_cli.Checked, modif_cli.Checked, supp_cli.Checked,
                    aj_prod.Checked, modif_prod.Checked, supp_prod.Checked, aj_fact.Checked, modif_fact.Checked, supp_fact.Checked);
                
                if (!leslogins.Contains(la))
                    {
                    trouve = false;
                    if (typ_user.Text == "admin")
                    {
                        la.Sup_cli = true;
                        la.Sup_prod = true;
                        la.Sup_fact = true;
                        la.Ajo_cli = true;
                        la.Ajo_prod = true;
                        la.Ajo_fact = true;
                        la.Mdf_cli = true;
                        la.Mdf_prod = true;
                        la.Mdf_fact = true;

                        loginDAO.Ajouter(la);
                        
                        acces_Load(sender, e);
                    }
                    else
                    {
                        loginDAO.Ajouter(la);
                        
                        list_users.Items.Clear();
                        acces_Load(sender, e);
                    }
                    
                    vider();
                   
                }
                else { trouve = true; }
                if (trouve) { MessageBox.Show("Utilisateur existe"); }
              
            }

        }

        private void typ_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typ_user.Text == "admin")
            {
                aj_cli.Enabled = false;
                modif_cli.Enabled = false;
                supp_cli.Enabled = false;
                aj_prod.Enabled = false;
                modif_prod.Enabled = false;
                supp_prod.Enabled = false;
                aj_fact.Enabled = false;
                modif_fact.Enabled = false;
                supp_fact.Enabled = false;
            }
            else
            {
                aj_cli.Enabled = true;
                modif_cli.Enabled = true;
                supp_cli.Enabled = true;
                aj_prod.Enabled = true;
                modif_prod.Enabled = true;
                supp_prod.Enabled = true;
                aj_fact.Enabled = true;
                modif_fact.Enabled = true;
                supp_fact.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Login l = (Login)list_users.SelectedItem;
            Login la = new Login(nom_user.Text, mdp_user.Text, typ_user.Text, Convert.ToInt32(user_CIN.Text), aj_cli.Checked, modif_cli.Checked, supp_cli.Checked,
                aj_prod.Checked, modif_prod.Checked, supp_prod.Checked, aj_fact.Checked, modif_fact.Checked, supp_fact.Checked);
            List<Login> leslogins = loginDAO.afficher();
            bool trouve= leslogins.Contains(la);
            if (trouve)
            { loginDAO.modifLogin(la);
               // loginDAO.removeUser(l.CIN1);
                acces_Load( sender,  e);
                vider();
                ajouter.Enabled = true;
            }
            else { MessageBox.Show("utilisateur n'existe pas"); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            int n = list_users.SelectedIndex;
            Login l = (Login)list_users.SelectedItem;

            nom_user.Text = l.Username;
            user_CIN.Text = l.CIN1.ToString();
            typ_user.Text = l.Typ;
            mdp_user.Text = l.Mot_de_passe;
            aj_cli.Checked = l.Ajo_cli;
            modif_cli.Checked = l.Mdf_cli;
            supp_cli.Checked = l.Sup_cli;
            aj_prod.Checked = l.Ajo_prod;
            modif_prod.Checked = l.Mdf_prod;
            supp_prod.Checked = l.Sup_prod;
            aj_fact.Checked = l.Ajo_prod;
            modif_fact.Checked = l.Mdf_prod;
            supp_fact.Checked = l.Sup_prod;
            loginDAO.removeUser(l.CIN1);
            //list_users.Items.RemoveAt(n);
            //list_users.Items.Clear();
            
            acces_Load(sender, e);
            vider();
            ajouter.Enabled = true;
        }

        private void list_users_SelectedIndexChanged(object sender, EventArgs e)
        {
            user_CIN.ReadOnly = true;
            supprimer.Enabled = true;
            //ajouter.Enabled = true;
            Login l = (Login)list_users.SelectedItem;
            nom_user.Text = l.Username;
            user_CIN.Text = l.CIN1.ToString();
            typ_user.Text = l.Typ;
            mdp_user.Text = l.Mot_de_passe;
            aj_cli.Checked = l.Ajo_cli;
            modif_cli.Checked = l.Mdf_cli;
            supp_cli.Checked = l.Sup_cli;
            aj_prod.Checked = l.Ajo_prod;
            modif_prod.Checked = l.Mdf_prod;
            supp_prod.Checked = l.Sup_prod;
            aj_fact.Checked = l.Ajo_prod;
            modif_fact.Checked = l.Mdf_prod;
            supp_fact.Checked = l.Sup_prod;
           
            ajouter.Enabled = false;
            if (typ_user.Text == "admin")
             modifier.Enabled = false; 
            else
                modifier.Enabled = true;
            
        }

        private void vide_Click(object sender, EventArgs e)
        {
            vider();
            ajouter.Enabled = true;
        }
    }
}
