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

    public partial class Form1 : Form
    {

        Metier metier;
        public Form1()
        {
            InitializeComponent();
        }

        private void Ajout_Click(object sender, EventArgs e)
        {
            Citoyen c1 = new Citoyen();

            c1.setcin(textcin.Text);
            c1.setNom(textnom.Text);
            c1.setPrenom(textprenom.Text);
            c1.setAdresse(textadress.Text);
            c1.setAge(Convert.ToInt32(textage.Text));
            c1.setMaladie_grave(textmalad.Text);
            c1.setEtat(Convert.ToInt32(textetat.Text));
            metier = new Metier();
            metier.insertCit(c1);
        }

        private void Supp_Click(object sender, EventArgs e)
        {
            string cin = textcin.Text;
            metier = new Metier();
            metier.supCit(cin);

        }

        private void Affich_Click(object sender, EventArgs e)
        {
           /* Form2 S = new Form2();
            S.Show();*/
            string cin = textcin.Text;
            metier = new Metier();
            dataGridView1.DataSource
                = metier.Affinfo(cin);
        }
    }
}
