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
    public partial class F_Client : Form
    {
        public F_Client()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nature="",MF,mode_pay="",rib="",bank="",addBank="" ,Cin="";
            
            if (PM.Checked)
            {
                nature = "PM";
               Cin = "__";
                
            }
          if(PP.Checked)
            {
                nature = "PP";
                Cin = m1.Text + m2.Text + m3.Text + m4.Text + m5.Text + m6.Text + m7.Text + m8.Text;
               
            }
            
            if (E.Checked==true) 
            {
               
                mode_pay = "especes";
              
                rib = "__";
                bank = "__";
                addBank = "__";

            }
            else 
            {
                rib = R1.Text + R2.Text + R3.Text + R4.Text + R5.Text +
             R6.Text + R7.Text + R8.Text + R9.Text + R10.Text +
             R11.Text + R12.Text + R13.Text + R14.Text + R15.Text +
             R16.Text + R17.Text + R18.Text + R19.Text + R20.Text +
             R21.Text;
                bank = Ban.Text;
                addBank = addBan.Text;
            }
            if (ch_v.Checked)
                mode_pay = "check versaille";
            if (T.Checked)
                mode_pay = "Traite";
            
            MF = MF1.Text + MF2.Text + MF3.Text + MF4.Text + MF5.Text +
                MF6.Text + MF7.Text + MF8.Text + MF9.Text + MF10.Text +
                MF11.Text + MF12.Text+MF13.Text ;
            bool verif1 = true, verif2 = true;
            if (((T.Checked = true)|| (ch_v.Checked = true)) && (rib.Length != 13))
                verif1 = false;
            if ((PP.Checked = false) && (Cin.Length != 13))
                verif2 = false;
            if ((identif.Text == "") || (nom.Text == "") || (add.Text == "") ||
                    (num_tel.Text == "") || (Cin.Length != 8) || (MF.Length != 13) 
                   ||(verif1 = false)|| (verif2 = false))

            MessageBox.Show("verifier votre champs!");
                else
                {
                    Client cl = new Client(nature, MF, identif.Text, nom.Text, add.Text,
                    mode_pay, bank, addBank, Cin, Convert.ToInt32(num_tel.Text), rib);
                    List<Personne> lesClients = PersonneDAO.findall();
                    bool trouve = lesClients.Contains(cl);
                    if (trouve)
                        MessageBox.Show("Client existe");
                    else
                    {
                        PersonneDAO.ajouterCli(cl);
                        F_Client_Load(sender, e);
                    }

                }




        }

        private void modifier_Click(object sender, EventArgs e)
        {
            string nature = "", MF, mode_pay = "", rib = "", bank = "", addBank = "", Cin = "";

            if (PM.Checked)
            {
                nature = "PM";
                Cin = "__";

            }
            if (PP.Checked)
            {
                nature = "PP";
                Cin = m1.Text + m2.Text + m3.Text + m4.Text + m5.Text + m6.Text + m7.Text + m8.Text;

            }

            if (E.Checked == true)
            {

                mode_pay = "especes";

                rib = "__";
                bank = "__";
                addBank = "__";

            }
            else
            {
                rib = R1.Text + R2.Text + R3.Text + R4.Text + R5.Text +
             R6.Text + R7.Text + R8.Text + R9.Text + R10.Text +
             R11.Text + R12.Text + R13.Text + R14.Text + R15.Text +
             R16.Text + R17.Text + R18.Text + R19.Text + R20.Text +
             R21.Text;
                bank = Ban.Text;
                addBank = addBan.Text;
            }
            if (ch_v.Checked)
                mode_pay = "check versaille";
            if (T.Checked)
                mode_pay = "Traite";

            MF = MF1.Text + MF2.Text + MF3.Text + MF4.Text + MF5.Text +
                MF6.Text + MF7.Text + MF8.Text + MF9.Text + MF10.Text +
                MF11.Text + MF12.Text + MF13.Text;
            bool verif1 = true, verif2 = true;
            if (((T.Checked = true) || (ch_v.Checked = true)) && (rib.Length != 13))
                verif1 = false;
            if ((PP.Checked = false) && (Cin.Length != 13))
                verif2 = false;
            if ((identif.Text == "") || (nom.Text == "") || (add.Text == "") ||
                    (num_tel.Text == "") || (Cin.Length != 8) || (MF.Length != 13)
                   || (verif1 = false) || (verif2 = false))

                MessageBox.Show("verifier votre champs!");
            else
            {
                Client cl = new Client(nature, MF, identif.Text, nom.Text, add.Text,
                mode_pay, bank, addBank, Cin, Convert.ToInt32(num_tel.Text), rib);
                List<Personne> lesClients = PersonneDAO.findall();
                bool trouve = lesClients.Contains(cl);
                if (trouve)
                {
                    
                        PersonneDAO.updateClient(cl);
                        F_Client_Load(sender, e);
                    button4_Click( sender,  e);

                }
                else
                {
                    MessageBox.Show("Client n'existe pas");

                }

            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            
            int indice = client_list.SelectedCells[0].RowIndex;
            List<Personne> cls = PersonneDAO.findall();
            Personne p;
            if (client_list.Rows.Count > 1)
            {
                if (indice != -1)
                {
                    p = cls[indice];
                    PersonneDAO.remove(p.Identif_unik);
                }

                F_Client_Load(sender, e);
                button4_Click( sender, e);
            }
        }

        private void F_Client_Load(object sender, EventArgs e)
        {
            Login user_actuelle = login.get_userActuelle();
            if (user_actuelle != null)
            {
                //acces au bouton ajouter
                if (user_actuelle.Ajo_cli == true) { ajouter.Enabled = true; }
                else { ajouter.Enabled = false; }
                // acces au bouton supprimer
                if (user_actuelle.Sup_cli == true) { ajouter.Enabled = true; }
                else { supprimer.Enabled = false; }
                //acces au bouton modifier
                if (user_actuelle.Mdf_cli == true) { ajouter.Enabled = true; }
                else { modifier.Enabled = false; }
            }
            List<Personne> lesClients = PersonneDAO.findall();
            NB.Text = lesClients.Count.ToString();
            NB.ReadOnly = true;
            client_list.Rows.Clear();
            foreach (Personne f in lesClients)
            {
                client_list.Rows.Add(f.Nom_prenom, f.CIN1, f.Mat_fiscale1, f.Identif_unik, f.Adresse,
                  f.Num_tel,  f.Mod_paiment,f.Bank,f.Add_bank,f.RIB1,f.Nature);

            }

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {

        }

        private void client_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PM_CheckedChanged(object sender, EventArgs e)
        {
            
            if (PM.Checked)
            {
                PP.Checked = false;
                m1.Enabled = false;
                m2.Enabled = false;
                m3.Enabled = false;
                m4.Enabled = false;
                m5.Enabled = false;
                m6.Enabled = false;
                m7.Enabled = false;
                m8.Enabled = false;
          
            }
            else
            {
                PP.Checked = true;
                m1.Enabled = true;
                m2.Enabled = true;
                m3.Enabled = true;
                m4.Enabled = true;
                m5.Enabled = true;
                m6.Enabled = true;
                m7.Enabled = true;
                m8.Enabled = true;
            }
        }

        private void E_CheckedChanged(object sender, EventArgs e)
        {
            if (E.Checked)
            {
                ch_v.Enabled = false;
                T.Enabled = false;
                R1.Enabled = false;
                R2.Enabled = false;
                R3.Enabled = false;
                R4.Enabled = false;
                R5.Enabled = false;
                R6.Enabled = false;
                R7.Enabled = false;
                R8.Enabled = false;
                R9.Enabled = false;
                R10.Enabled = false;
                R11.Enabled = false;
                R12.Enabled = false;
                R13.Enabled = false;
                R14.Enabled = false;
                R15.Enabled = false;
                R16.Enabled = false;
                R17.Enabled = false;
                R18.Enabled = false;
                R19.Enabled = false;
                R20.Enabled = false;
                R21.Enabled = false;
                Ban.Enabled = false;
                addBan.Enabled = false;
            }
            else
            {
                ch_v.Enabled = true;
                T.Enabled = true;
                R1.Enabled = true;
                R2.Enabled = true;
                R3.Enabled = true;
                R4.Enabled = true;
                R5.Enabled = true;
                R6.Enabled = true;
                R7.Enabled = true;
                R8.Enabled = true;
                R9.Enabled = true;
                R10.Enabled = true;
                R11.Enabled = true;
                R12.Enabled = true;
                R13.Enabled = true;
                R14.Enabled = true;
                R15.Enabled = true;
                R16.Enabled = true;
                R17.Enabled = true;
                R18.Enabled = true;
                R19.Enabled = true;
                R20.Enabled = true;
                R21.Enabled = true;
                Ban.Enabled = true;
                addBan.Enabled = true;
            }
        }

        private void PP_CheckedChanged(object sender, EventArgs e)
        {if(PP.Checked)
            PM.Checked = false;
        else
                ch_v.Enabled = true;
            T.Enabled = true;
            R1.Enabled = true;
            R2.Enabled = true;
            R3.Enabled = true;
            R4.Enabled = true;
            R5.Enabled = true;
            R6.Enabled = true;
            R7.Enabled = true;
            R8.Enabled = true;
            R9.Enabled = true;
            R10.Enabled = true;
            R11.Enabled = true;
            R12.Enabled = true;
            R13.Enabled = true;
            R14.Enabled = true;
            R15.Enabled = true;
            R16.Enabled = true;
            R17.Enabled = true;
            R18.Enabled = true;
            R19.Enabled = true;
            R20.Enabled = true;
            R21.Enabled = true;
            Ban.Enabled = true;
            addBan.Enabled = true;
        }

        private void T_CheckedChanged(object sender, EventArgs e)
        {if (T.Checked)
            {
                ch_v.Enabled = false;
                E.Enabled = false;
            }
            else
            {
                ch_v.Enabled = true;
                E.Enabled = true;
            }
        }

        private void ch_v_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_v.Checked)
            {
                T.Enabled = false;
                E.Enabled = false;
            }
            else
            {
                T.Enabled = true;
                E.Enabled = true;
            }
        }
        
        private void client_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Personne> lesClients = PersonneDAO.findall();
            E.Checked = false;
            T.Checked = false;
            ch_v.Checked = false;
            PP.Checked = false;
            PM.Checked = false;
            if (e.RowIndex != -1)
            {
                Personne cl = lesClients[e.RowIndex];
              
                
                if (cl.Nature == "PM")
                {
                    PM.Checked = true;
                    PM_CheckedChanged( sender,  e);
                }
                    if (cl.Nature == "PP")
                {
                    PP.Checked = true;
                    PP_CheckedChanged(sender, e);

                   m1.Text = cl.CIN1[0].ToString();
                   m2.Text = cl.CIN1[1].ToString();
                   m3.Text = cl.CIN1[2].ToString();
                   m4.Text = cl.CIN1[3].ToString();
                   m5.Text = cl.CIN1[4].ToString();
                   m6.Text = cl.CIN1[5].ToString();
                   m7.Text = cl.CIN1[6].ToString();
                   m8.Text = cl.CIN1[7].ToString();
                  
                }
                
                List<char> MF = new List<char>();
                for (int i = 0; i<cl.Mat_fiscale1.Length; i++)
                    MF.Add(cl.Mat_fiscale1[i]);
                MF1.Text = MF[0].ToString();
                MF2.Text = MF[0].ToString();
                MF3.Text = MF[0].ToString();
                MF4.Text = MF[0].ToString();
                MF5.Text = MF[0].ToString();
                MF6.Text = MF[0].ToString();
                MF7.Text = MF[0].ToString();
                MF8.Text = MF[0].ToString();
                MF9.Text = MF[0].ToString();
                MF10.Text = MF[0].ToString();
                MF11.Text = MF[0].ToString();
                MF12.Text = MF[0].ToString();
                MF13.Text = MF[0].ToString();
                identif.Text = cl.Identif_unik;
                nom.Text = cl.Nom_prenom;
                add.Text = cl.Adresse;
                num_tel.Text = cl.Num_tel.ToString();
               
                string mod_pay = cl.Mod_paiment;
                if (mod_pay == "especes")
                {
                    E.Checked = true;
                    E_CheckedChanged(sender, e);
                }
                if (mod_pay == "Traite")
                {
                    T_CheckedChanged(sender, e);
                    T.Checked = true;
                    addBan.Text = cl.Add_bank;
                    Ban.Text = cl.Bank;
                    string rib = cl.RIB1;
                    R1.Text = rib[0].ToString();
                    R2.Text = rib[0].ToString();
                    R3.Text = rib[0].ToString();
                    R4.Text = rib[0].ToString();
                    R5.Text = rib[0].ToString();
                    R6.Text = rib[0].ToString();
                    R7.Text = rib[0].ToString();
                    R8.Text = rib[0].ToString();
                    R9.Text = rib[0].ToString();
                    R10.Text = rib[0].ToString();
                    R11.Text = rib[0].ToString();
                    R12.Text = rib[0].ToString();
                    R13.Text = rib[0].ToString();
                    R14.Text = rib[0].ToString();
                    R15.Text = rib[0].ToString();
                    R16.Text = rib[0].ToString();
                    R17.Text = rib[0].ToString();
                    R18.Text = rib[0].ToString();
                    R19.Text = rib[0].ToString();
                    R20.Text = rib[0].ToString();
                    R21.Text = rib[0].ToString();
                }
               if (mod_pay == "check versaille")
                {
                    ch_v.Checked = true;
                    ch_v_CheckedChanged(sender,  e);
                    addBan.Text = cl.Add_bank;
                    Ban.Text = cl.Bank;
                    string rib = cl.RIB1;
                    R1.Text = rib[0].ToString();
                    R2.Text = rib[0].ToString();
                    R3.Text = rib[0].ToString();
                    R4.Text = rib[0].ToString();
                    R5.Text = rib[0].ToString();
                    R6.Text = rib[0].ToString();
                    R7.Text = rib[0].ToString();
                    R8.Text = rib[0].ToString();
                    R9.Text = rib[0].ToString();
                    R10.Text = rib[0].ToString();
                    R11.Text = rib[0].ToString();
                    R12.Text = rib[0].ToString();
                    R13.Text = rib[0].ToString();
                    R14.Text = rib[0].ToString();
                    R15.Text = rib[0].ToString();
                    R16.Text = rib[0].ToString();
                    R17.Text = rib[0].ToString();
                    R18.Text = rib[0].ToString();
                    R19.Text = rib[0].ToString();
                    R20.Text = rib[0].ToString();
                    R21.Text = rib[0].ToString();
                }
               
              

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            E.Checked = false;
            T.Checked = false;
            ch_v.Checked = false;
            PP.Checked = false;
            PM.Checked = false;
            m1.Clear();
            m2.Clear(); 
            m3.Clear();
            m4.Clear();
            m5.Clear();
            m6.Clear();
            m7.Clear();
            m8.Clear();
            identif.Text = "";
            nom.Text = "";
            add.Text = "";
            num_tel.Text = "";
            R1.Clear();
            R2.Clear();
            R3.Clear();
            R4.Clear();
            R5.Clear();
            R6.Clear();
            R7.Clear();
            R8.Clear();
            R9.Clear();
            R10.Clear();
            R11.Clear();
            R12.Clear();
            R13.Clear();
            R14.Clear();
            R15.Clear();
            R16.Clear();
            R17.Clear();
            R18.Clear();
            R19.Clear();
            R20.Clear();
            R21.Clear();
            MF1.Clear();
            MF2.Clear();
            MF3.Clear();
            MF4.Clear();
            MF5.Clear();
            MF6.Clear();
            MF7.Clear();
            MF8.Clear();
            MF9.Clear();
            MF10.Clear();
            MF11.Clear();
            MF12.Clear(); 
            MF13.Clear();
            Ban.Clear();
            addBan.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Personne> lesClients = PersonneDAO.FindByDes(indice.Text);
            client_list.Rows.Clear();
            foreach (Personne f in lesClients)
            {
                client_list.Rows.Add(f.Nom_prenom, f.CIN1, f.Mat_fiscale1, f.Identif_unik, f.Adresse,
                 f.Num_tel, f.Mod_paiment, f.Bank, f.Add_bank, f.RIB1, f.Nature); 

            }
        }

        private void indice_TextChanged(object sender, EventArgs e)
        {
            if (indice.Text == "")
                F_Client_Load(sender, e);
            else
            {
                List<Personne> lesClients = PersonneDAO.FindByindice(indice.Text);
                client_list.Rows.Clear();
                foreach (Personne f in lesClients)
                {
                    client_list.Rows.Add(f.Nom_prenom, f.CIN1, f.Mat_fiscale1, f.Identif_unik, f.Adresse,
                     f.Num_tel, f.Mod_paiment, f.Bank, f.Add_bank, f.RIB1, f.Nature);

                }
            }
        }
    }
}
