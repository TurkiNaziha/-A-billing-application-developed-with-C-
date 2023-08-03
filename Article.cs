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
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listprd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reference_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<article> lesarticles = articleDAO.FindByDes(indice.Text);
            articles_list.Rows.Clear();
            foreach (article f in lesarticles)
            {
                articles_list.Rows.Add(f.Code, f.Designation, f.Qte_stk, f.Prix, f.Fournisseur);

            }
           
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Article_Load(object sender, EventArgs e)
        {
            Login user_actuelle = login.get_userActuelle();
            if (user_actuelle != null)
            {
                //acces au bouton ajouter
                if (user_actuelle.Ajo_prod == true) { ajouter.Enabled = true; }
                else { ajouter.Enabled = false; }
                // acces au bouton supprimer
                if (user_actuelle.Sup_prod == true) { ajouter.Enabled = true; }
                else { supprimer.Enabled = false; }
                //acces au bouton modifier
                if (user_actuelle.Mdf_prod == true) { ajouter.Enabled = true; }
                else { modifier.Enabled = false; }
            }
            List<article> lesarticles = articleDAO.findall();
            NB.Text = lesarticles.Count.ToString();
            NB.ReadOnly = true;
            articles_list.Rows.Clear();
            foreach (article f in lesarticles)
            {
                articles_list.Rows.Add(f.Code, f.Designation, f.Qte_stk, f.Prix, f.Fournisseur);
               
            }
        }
       
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void vider()
        {
            cde.Text = "";
            Designation.Text = "";
            fournis.Text = "";
            Quantite.Text = "";
            Prix_ach.Text="";
            
        }
        private void ajouter_Click(object sender, EventArgs e)
        {
            if ((cde.Text == "") ||( Designation.Text == "") || (Quantite.Text == "") || (Prix_ach.Text == "") || (fournis.Text == ""))
                MessageBox.Show("verifier les champs vides");
            else
            {
                char c;
                bool test_entier=false,test_lettre ;

                foreach (char ca in Quantite.Text )
                {
                    if ( Char.IsLetter(ca))
                    {
                        test_entier = true;
                        break;
                    }
                }
                foreach (char ca in Prix_ach.Text)
                {
                    if (Char.IsLetter(ca))
                    {
                        test_entier = true;
                        break;
                    }
                }
                if (test_entier==true)
                { MessageBox.Show("verifier les champs Prix ou Quantite,Type invalide!");
                }
             
                article a = new article(cde.Text, Designation.Text
            , fournis.Text, Convert.ToDecimal(Quantite.Text), Convert.ToDecimal(Prix_ach.Text));
                    List<article> lesArticles = articleDAO.findall();
                    bool trouve = lesArticles.Contains(a);
                    if (trouve)
                        MessageBox.Show("Article existe");
                    else
                    {
                        articleDAO.ajouterArticle(a);
                        Article_Load(sender, e);
                    vider();
                    }
                }

            }

        private void modifier_Click(object sender, EventArgs e)
        {
            if ((cde.Text == "") || (Designation.Text == "") || (Quantite.Text == "") || (Prix_ach.Text == "") || (fournis.Text == ""))
                MessageBox.Show("verifier les champs vides");
            else
            {
                char c;
                bool test_entier = false, test_lettre;

                foreach (char ca in Quantite.Text)
                {
                    if (Char.IsLetter(ca))
                    {
                        test_entier = true;
                        break;
                    }
                }
                foreach (char ca in Prix_ach.Text)
                {
                    if (Char.IsLetter(ca))
                    {
                        test_entier = true;
                        break;
                    }
                }
                if (test_entier == true)
                {
                    MessageBox.Show("verifier les champs Prix ou Quantite,Type invalide!");
                }

                article a = new article(cde.Text, Designation.Text
            , fournis.Text, Convert.ToDecimal(Quantite.Text), Convert.ToDecimal(Prix_ach.Text));
                List<article> lesArticles = articleDAO.findall();

                bool trouve = lesArticles.Contains(a);
                if (trouve)
                { articleDAO.modifArticle(a);
                    Article_Load(sender, e);
                    vider();
                }
                    
                else
                {
                    MessageBox.Show("Article n'existe pas");
                }
            }
        }

        private void articles_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void articles_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            List<article> lesarticles = articleDAO.findall();
           
            if (e.RowIndex != -1)
            {
                article a = lesarticles[e.RowIndex];
               

                cde.Text = a.Code;
                Designation.Text = a.Designation;
                fournis.Text = a.Fournisseur;
                Quantite.Text = a.Qte_stk.ToString();
                Prix_ach.Text = a.Prix.ToString();
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            article a = new article(cde.Text, Designation.Text
            , fournis.Text, Convert.ToDecimal(Quantite.Text), Convert.ToDecimal(Prix_ach.Text));
            articleDAO.remove(a.Code);
            Article_Load(sender, e);
            vider();
        }

        private void indice_TextChanged(object sender, EventArgs e)
        {
            if(indice.Text=="")
                Article_Load(sender, e);
            else
            {
                List<article> lesarticles = articleDAO.FindByindice(indice.Text);
                articles_list.Rows.Clear();
                foreach (article f in lesarticles)
                {
                    articles_list.Rows.Add(f.Code, f.Designation, f.Qte_stk, f.Prix, f.Fournisseur);

                }
            }
        }
    }
}
