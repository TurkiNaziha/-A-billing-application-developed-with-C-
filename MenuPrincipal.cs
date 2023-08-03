using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace Application_gestion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            //AliceBlue;
            button2.ResetBackColor();
            button4.ResetBackColor();
            button3.ResetBackColor();
            button1.BackColor = Color.SkyBlue;
            
            Article fen = new Article();
             fen.MdiParent = this;
            fen.TopLevel = false;
            fen.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(fen);
            panelDesktop.Tag = fen;
            fen.BringToFront();
            fen.Show();
        }

        private void button1_MouseCaptureChanged(object sender, EventArgs e)
        {
           // button1.BackColor = Color.FromArgb(27, 152, 206, 255);
            //button2.BackColor = Color.SkyBlue;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
           // button1.BackColor = Color.FromArgb(27, 152, 206, 255);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            //this.Text = "u did it";
            //this.BackColor = Color.FromArgb(27, 152, 206, 255);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //button2.BackColor = Color.SkyBlue;
            //Azure,aliceblue SteelBlue;
            button1.ResetBackColor();
            button4.ResetBackColor();
            button3.ResetBackColor();
            button2.BackColor = Color.SkyBlue;
            F_Client fen =new  F_Client();
            fen.MdiParent = this;
            fen.TopLevel = false;
            fen.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(fen);
            panelDesktop.Tag = fen;
            fen.BringToFront();
            fen.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.ResetBackColor();
            button3.ResetBackColor();
            button1.ResetBackColor();
            button4.BackColor = Color.SkyBlue;

            bool test = login.get_estAdmin();
            if (test == true)
            {
                parametres fen = new parametres();
                fen.acces_au_parametre(true);
                fen.MdiParent = this;
                fen.TopLevel = false;
                fen.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(fen);
                panelDesktop.Tag = fen;
                fen.BringToFront();
                fen.Show();
            }
            else
            {
                parametres fen = new parametres();
                fen.acces_au_parametre(false);
                fen.MdiParent = this;
                fen.TopLevel = false;
                fen.Dock = DockStyle.Fill;
                panelDesktop.Controls.Add(fen);
                panelDesktop.Tag = fen;
                fen.BringToFront();
                fen.Show();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
           // button1.BackColor = Color.SkyBlue;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
           // button2.BackColor = Color.SkyBlue;
            //button1.BackColor = Color.FromArgb(27, 152, 206, 255);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            
           // ResetBackColor();
        }

        private void button2_KeyUp(object sender, KeyEventArgs e)
        {
           // button2.BackColor = Color.Red;
        }

        private void button2_DragLeave(object sender, EventArgs e)
        {
           // button2.BackColor = Color.Red;
        }

        private void button2_MouseCaptureChanged(object sender, EventArgs e)
        {
           // button2.BackColor = Color.Red;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {// button1.BackColor = Color.SkyBlue;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.ResetBackColor();
            button1.ResetBackColor();
            button4.ResetBackColor();
            button3.BackColor = Color.SkyBlue;
            Facturation fen = new Facturation();
            fen.MdiParent = this;
            fen.TopLevel = false;
            fen.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(fen);
            panelDesktop.Tag = fen;
            fen.BringToFront();
            fen.Show();
        }
    }
    
}
