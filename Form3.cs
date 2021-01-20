using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Covid
{
    public partial class Form3 : Form

    {

        Metier metier;
        Form1 f2;
        public Form3(Form1 frm2)
        {
            InitializeComponent();
            this.f2 = frm2;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textcin2.Text = f2.textcin.Text;
        }
        
        
        
private void ok_Btn_Click(object sender, EventArgs e)
        {
            Citoyen c1 = new Citoyen();

            c1.setcin(textcin2.Text);
            c1.setNom(textnom.Text);
            c1.setPrenom(textprenom.Text);
            c1.setAdresse(textadress.Text);
            c1.setAge(Convert.ToInt32(textage.Text));
            c1.setMaladie_grave(textmalad.Text);
            c1.setEtat(Convert.ToInt32(textetat.Text));
            metier = new Metier();
            metier.insertCit(c1);

        }
    }
}
