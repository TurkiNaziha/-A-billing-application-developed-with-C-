using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

using des_objets;
using DAO;
namespace Application_gestion
{
    public partial class Facturation : Form
    {
        public Facturation()
        {
            InitializeComponent();
        }

        private void lab1_Click(object sender, EventArgs e)
        {

        }

        private void lab2_Click(object sender, EventArgs e)
        {

        }

        private void Facturation_Load(object sender, EventArgs e)
        {
            //num.Text = ((Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count) -1).ToString().PadLeft(4, '0');
            Login user_actuelle = login.get_userActuelle();
            if (user_actuelle != null)
            {
                //acces au bouton ajouter
                if (user_actuelle.Ajo_fact == true) { Enregitsrer.Enabled = true; }
                else { Enregitsrer.Enabled = false; }
                // acces au bouton supprimer
                if (user_actuelle.Sup_fact == true) { supprimer.Enabled = true; }
                else { supprimer.Enabled = false; }
                //acces au bouton modifier
                if (user_actuelle.Mdf_fact == true) { modifier.Enabled = true; }
                else { modifier.Enabled = false; }
            }
            MT.ReadOnly = true;
            list_fact.Rows.Clear();
            cli_list.Items.Clear();
            List<Personne> lesClients = PersonneDAO.findall();
            cli_list.Items.AddRange(lesClients.ToArray());
            cli_list.SelectedIndex = 0;
            List<article> lesArticles = articleDAO.findall();
            list_prod.Items.AddRange(lesArticles.ToArray());
            list_prod.DisplayMember = "designation";
            list_prod.SelectedIndex = 0;
            QES.ReadOnly = true;
            prix_vente.ReadOnly = true;
            
            List<facturation> lesfactures = facturationDAO.findall();
           // num.Text = ((Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + lesfactures.Count)).ToString().PadLeft(4, '0');
            foreach (facturation f in lesfactures.ToArray())
            {

                list_fact.Rows.Add(f.Num, f.MF_cli1, f.Date, f.MT1);
            }
            MT.Text = "0";
            // num.Text = ((list_fact.Rows.Count)).ToString().PadLeft(4, '0');
           num.Text = ((Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count)-1 ).ToString().PadLeft(4, '0');

        }

        private void pro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void list_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            article a = (article)list_prod.SelectedItem;
           
            QES.Text = a.Qte_stk.ToString();
            prix_vente.Text = a.Prix.ToString();
          
        }

        private void qte_TextChanged(object sender, EventArgs e)
        {
           article a = (article)list_prod.SelectedItem;
            double n;
            double valeirOrigine = Convert.ToDouble(a.Qte_stk);
            char c;
            bool test = false;

            /*
              if (qte.Text == "")
                  n = 0;
              else
                  n = Convert.ToDouble(qte.Text);
            */
            foreach (char ca in qte.Text)
            {
                if (Char.IsLetter(ca))
                    test = true;

            }
            if ((qte.Text.Contains('-')) || (test == true))
            {
                c = '-';
                qte.Text = "";
                MessageBox.Show("le quantite ne put pas etre negative ou un caractere!");
            }

            if (qte.Text == "")
                n = 0;
            else
                n = Convert.ToDouble(qte.Text);



            if (n == 0)
            { QES.Text = valeirOrigine.ToString(); }

            if (n > 0)
            {
                QES.Text = (valeirOrigine - n).ToString();
            }
            if (n < 0)
            {
                MessageBox.Show("la quantite ne peut pas etre negative");
                qte.Text = "";
            }

        }

        private void AL_Click(object sender, EventArgs e)
        {
            article a = (article)list_prod.SelectedItem;
           // num.Text = ((list_fact.Rows.Count)).ToString().PadLeft(4, '0');
            if ((qte.Text == "") || (prix_vente.Text == "") || (QES.Text == ""))
                MessageBox.Show("verifier les champs vides");
            else
            {
                if((Convert.ToDouble(qte.Text) > Convert.ToDouble(QES.Text)
                    && Convert.ToDouble(QES.Text) < 0))
                {   
                    MessageBox.Show("la quantite depaase la quantite de stock,stock est insuffisant!");
                    qte.Text = "";
                }
                else
                {
                   // LigneFacture lf = new LigneFacture(Convert.ToInt32(num.Text), a
                              //     , list_ligne.Rows.Count , Convert.ToInt32(qte.Text), Convert.ToInt32(qte.Text) * Convert.ToDecimal(prix_vente.Text));
                   //LignefactureDAO.ajouterligne(lf);
                    list_ligne.Rows.Add(list_ligne.Rows.Count, a, qte.Text, prix_vente.Text,
                                           Convert.ToInt32(qte.Text) *
                                         Convert.ToDouble(prix_vente.Text));
                    
                    double somme = 0;
                    foreach (DataGridViewRow row in list_ligne.Rows)
                    {
                        somme += Convert.ToDouble(row.Cells[4].Value);
                    }
                    MT.Text = somme.ToString();
                    QES.Text = QES.Text;
                    prix_vente.Text = "";
                    qte.Text = "";
                }

            }
        }

        private void Enregitsrer_Click(object sender, EventArgs e)
        {
           // num.Text = (Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count +1).ToString().PadLeft(4, '0');

            if (  num.Text == ""
                || dtpfacture.Value > DateTime.Now || list_ligne.Rows.Count == 0)
            {
                MessageBox.Show("Vérifier les champs vides ou le tableau des articles");

            }
            else
            {
                string livraison="__" ;
                if (rdtotale.Checked)
                {
                    livraison = "livré";
                }
                if (Partielle.Checked)
                {
                    livraison = "livré partiellment";
                }
               Personne cl = (Personne)cli_list.SelectedItem;
                facturation f = new facturation(Convert.ToInt32(num.Text), dtpfacture.Value.ToString("yyyy-MM-dd"), livraison,cl ,Convert.ToDecimal(MT.Text));
                List < facturation > lesfactures = facturationDAO.findall();
                bool trouve = lesfactures.Contains(f);
                if (trouve)
                    MessageBox.Show("Article existe");
                else
                {
                    
                    list_fact.Rows.Add(f.Num, f.MF_cli1.Mat_fiscale1, f.Date, f.MT1);
                    facturationDAO.ajouterligne(f);
                  //  num.Text = (Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count - 1).ToString().PadLeft(4, '0');
                    List<article> lesArticles = articleDAO.findall();
                    article aa = new article();
                  //  num.Text = ((list_fact.Rows.Count)).ToString().PadLeft(4, '0');
                    foreach (DataGridViewRow row in list_ligne.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[2].Value) == 0)
                            break;
                        foreach (article a in lesArticles)

                            if (a.Equals(row.Cells[1].Value))
                            {
                                aa = (article)row.Cells[1].Value;
                                articleDAO.modifQTE(aa, Convert.ToInt32(a.Qte_stk) - Convert.ToInt32(row.Cells[2].Value));


                            }

                        LigneFacture lf = new LigneFacture(Convert.ToInt32(num.Text), aa,
                      row.Index, Convert.ToInt32(row.Cells[2].Value),
                      Convert.ToDecimal(row.Cells[3].Value), Convert.ToDecimal(row.Cells[2].Value) *
                       Convert.ToInt32(row.Cells[3].Value));
                        LignefactureDAO.ajouterligne(lf);


                    }
                    list_prod.Items.Clear();
                    list_prod.Items.AddRange(lesArticles.ToArray());
                    vider_Click(sender, e);
                }
                

            }
        }

        private void vider_Click(object sender, EventArgs e)
        {
            
            MT.Text = "0";
            QES.Text = "";
            prix_vente.Text = "";
            qte.Text = "";
            list_ligne.Rows.Clear();
            dtpfacture.Value = DateTime.Now;
           // num.Text = ((Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count)).ToString().PadLeft(4, '0');
        }

        private void QES_TextChanged(object sender, EventArgs e)
        {

        }

        private void SL_Click(object sender, EventArgs e)
        {
            int indice = list_ligne.SelectedCells[0].RowIndex;
            if (list_ligne.SelectedRows.Count >= 0)
            {
               
               
                    list_ligne.Rows.RemoveAt(indice);

                
            }
        }

        private void list_ligne_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<LigneFacture> lesfactures = LignefactureDAO.findall();

            if (e.RowIndex != -1)
            {
                LigneFacture a = lesfactures[e.RowIndex];


                
             
            }
        }

        private void list_fact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<facturation> lesfactures = facturationDAO.findall();
            list_ligne.Rows.Clear();
            if (e.RowIndex != -1)
            {
               // MessageBox.Show("bnj");
                facturation f = lesfactures[e.RowIndex];
               // MessageBox.Show("bnj");
                cli_list.Text = f.MF_cli1.ToString();
               MT.Text = f.MT1.ToString();
                num.Text =f.Num.ToString();
                dtpfacture.Value = Convert.ToDateTime(f.Date);
                if (f.Etat_livr== "livré")
                    rdtotale.Checked = true;
                else
                    Partielle.Checked = true;
                List<LigneFacture> lesLignes = LignefactureDAO.findall();
                
                foreach (LigneFacture l in lesLignes)
                {
                   
                    if (l.Num_fact==f.Num)
                        list_ligne.Rows.Add(list_ligne.Rows.Count,l.Code_article, l.Qte, l.Prixvente
                      , l.Prixvente * l.Qte);

                }



            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
           
            
             int indice = list_fact.SelectedCells[0].RowIndex;
           
            List<facturation> lesfactures = facturationDAO.findall();
            if (list_fact.SelectedRows.Count >= 0)
            {
                //foreach (DataGridViewRow row in list_fact.SelectedRows)
                //{
                     // indice = row.Index;
                    list_fact.Rows.RemoveAt(indice);
                LignefactureDAO.remove(lesfactures[indice].Num);
                facturationDAO.remove(lesfactures[indice].Num);
                
              //  }

                Facturation_Load(sender, e);
                
                vider_Click(sender, e);
               // num.Text = ((Convert.ToInt32(list_fact.Rows[0].Cells[0].Value) + list_fact.Rows.Count)).ToString().PadLeft(4, '0');


            }
        }

        private void modifier_Click(object sender, EventArgs e)
        {
           
            if (num.Text == ""
                || dtpfacture.Value > DateTime.Now || list_ligne.Rows.Count == 0)
            {
                MessageBox.Show("Vérifier les champs vides ou le tableau des articles");

            }
            else
            {
                string livraison = "__";
                if (rdtotale.Checked)
                {
                    livraison = "livré";
                }
                if (Partielle.Checked)
                {
                    livraison = "livré partiellment";
                }
                Personne cl = (Personne)cli_list.SelectedItem;
                facturation f = new facturation(Convert.ToInt32(num.Text), dtpfacture.Value.ToString(), livraison, cl, Convert.ToDecimal(MT.Text));
                List<facturation> lesfactures = facturationDAO.findall();
                //int i = list_fact.SelectedCells[0].RowIndex;
                bool trouve = lesfactures.Contains(f);
                if (trouve)
                {
                    facturationDAO.modifFAct(f);
                    //list_fact.Rows.Add(f.Num, f.MF_cli1.Mat_fiscale1, f.Date, f.MT1);
                    /*
                    List<article> lesArticles = articleDAO.findall();
                    article aa = new article();
                    // num.Text = ((list_fact.Rows.Count)).ToString().PadLeft(4, '0');
                    foreach (DataGridViewRow row in list_ligne.Rows)
                    {
                        if (Convert.ToInt32(row.Cells[2].Value) == 0)
                            break;
                        foreach (article a in lesArticles)

                            if (a.Equals(row.Cells[1].Value))
                            {
                                aa = (article)row.Cells[1].Value;
                                articleDAO.modifQTE(aa, Convert.ToInt32(a.Qte_stk) - Convert.ToInt32(row.Cells[2].Value));


                            }

                        LigneFacture lf = new LigneFacture(Convert.ToInt32(num.Text), aa,
                      row.Index, Convert.ToInt32(row.Cells[2].Value),
                      Convert.ToDecimal(row.Cells[3].Value), Convert.ToDecimal(row.Cells[2].Value) *
                       Convert.ToInt32(row.Cells[3].Value));
                        LignefactureDAO.ajouterligne(lf);


                    }
                    list_prod.Items.Clear();
                    list_prod.Items.AddRange(lesArticles.ToArray());*/
                    Facturation_Load(sender, e);
                    vider_Click(sender, e);
                    
                  
                }

                else
                {
                    MessageBox.Show("facture n'existe pas");
                }
                

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (indice_code.Text == "")
                Facturation_Load(sender, e);
            else
            {
                List<facturation> lesfactures = facturationDAO.FindByCode(indice_code.Text);
                list_fact.Rows.Clear();
                foreach (facturation f in lesfactures)
                {
                    list_fact.Rows.Add(f.Num, f.MF_cli1, f.Date, f.MT1);

                }
            }
        }

        private void indice_cli_TextChanged(object sender, EventArgs e)
        {
            if (indice_cli.Text == "")
                Facturation_Load(sender, e);
            else
            {
                List<facturation> lesfactures = facturationDAO.FindByCode(indice_cli.Text);
                list_fact.Rows.Clear();
                foreach (facturation f in lesfactures)
                {
                    list_fact.Rows.Add(f.Num, f.MF_cli1, f.Date, f.MT1);

                }
            }
        }

        private void indice_dte_ValueChanged(object sender, EventArgs e)
        {
            string todatDate = DateTime.Now.ToString("yyyy-MM-dd");
            string dateTape= indice_dte.Value.ToString("yyyy-MM-dd");
            if (todatDate == dateTape)
            {


                Facturation_Load(sender, e);
            }
            else
            {

                List<facturation> lesfactures = facturationDAO.FindByDate(indice_dte.Value.ToString("yyyy-MM-dd"));
              
                list_fact.Rows.Clear();
                foreach (facturation f in lesfactures)
                {
                    list_fact.Rows.Add(f.Num, f.MF_cli1, f.Date, f.MT1);

                }
            }
        }

        private void indice_dte_CloseUp(object sender, EventArgs e)
        {/*
            if (indice_dte.Value == DateTime.Now)
            {


                Facturation_Load(sender, e);
            }
            if (indice_dte.Value < DateTime.Now)
            {

                List<facturation> lesfactures = facturationDAO.FindByDate(indice_dte.Value);
                list_fact.Rows.Clear();
                MessageBox.Show(lesfactures.Count.ToString());
                foreach (facturation f in lesfactures)
                {
                    list_fact.Rows.Add(f.Num, f.MF_cli1, f.Date, f.MT1);

                }
            }*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            facture f = new facture();
            f.Show();
        }
    }
}
