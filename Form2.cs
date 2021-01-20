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
    public partial class Form2 : Form
    {
        
        Metier metier;
        Form1 f1;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            this.f1 = frm1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = f1.textcin.Text;
            DataTable dataT = new DataTable();
           

            f1 = new Form1();
            string cin = textBox1.Text;
            metier = new Metier();
            dataT = metier.Affinf(cin).Copy();
            dataT.Merge((metier.Affinfo(cin)), true);
            
            dataGridView1.DataSource = dataT;

        }

        
    }
}
