using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf ;
using System.Diagnostics;

namespace Application_gestion
{
    public partial class facture : Form
    {
        public facture()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string outFile = Environment.CurrentDirectory + "/facture.pdf";
            Document doc = new Document();
            PdfWriter.GetInstance(doc, new  FileStream(outFile, FileMode.Create));
            doc.Open();
            doc.Add(new Paragraph("Hello World!"));
            doc.Close();
            Process.Start(@"cmd.exe", @"/c" + outFile);
            MessageBox.Show("hh");
        }

        
    }
}
