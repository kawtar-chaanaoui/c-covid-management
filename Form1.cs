﻿using System;
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
            Form3 F = new Form3(this);

            F.ShowDialog();
          
        }

        private void Supp_Click(object sender, EventArgs e)
        {
            string cin = textcin.Text;
            metier = new Metier();
            metier.supCit(cin);

        }

        private void Affich_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2(this);
           
             F.ShowDialog();


           

        }
    }
}


