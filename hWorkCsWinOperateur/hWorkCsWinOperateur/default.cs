using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hWorkCsWinOperateur
{
    public partial class HomeWork : Form
    {
        public HomeWork()
        {
            InitializeComponent();
        }
       
       
        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }
        Single val1, val2, result;

        private void btnDivision_Click(object sender, EventArgs e)
        {
            

            val1 = Convert.ToSingle(txtVal1.Text);
            val2 = Convert.ToSingle(txtVal2.Text);
            result = val1 / val2;


            lblResultat.Text = (result).ToString();

            lblResultat.Text = "Mr ou Mm " + txtNom.Text;
            lblResultat.Text = lblResultat.Text + "\n Division de " + val1 + " et " + val2 + " est " + result;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            

            val1 = Convert.ToSingle(txtVal1.Text);
            val2 = Convert.ToSingle(txtVal2.Text);
            result = val1 * val2;


            lblResultat.Text = (result).ToString();

            lblResultat.Text = "Mr ou Mm " + txtNom.Text;
            lblResultat.Text = lblResultat.Text + "\n Multiplication de " + val1 + " et " + val2 + " est " + result;
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            

            
            result = val1 % val2;


            lblResultat.Text = (result).ToString();

            lblResultat.Text = "Mr ou Mm " + txtNom.Text;

            lblResultat.Text = lblResultat.Text + "\n Modulo de " + val1 + " et " + val2 + " est " + result;
        }

        private void btnSuperieur_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToSingle(txtVal1.Text);
            val2 = Convert.ToSingle(txtVal2.Text);
            bool resultat = val1 > val2;
            lblResultat.Text = lblResultat.Text + "\n" + resultat;
            
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
           

            val1 = Convert.ToSingle(txtVal1.Text);
            val2 = Convert.ToSingle(txtVal2.Text);
            result = val1 - val2;


            lblResultat.Text = (result).ToString();

            lblResultat.Text = "Mr ou Mm " + txtNom.Text;
            lblResultat.Text = lblResultat.Text + "\n Soustration  de " + val1 + " et " + val2 + " est " + result;
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            
           
            

            
            
            val1 = Convert.ToSingle(txtVal1.Text);
            val2 = Convert.ToSingle(txtVal2.Text);
            result = val1 + val2;


            lblResultat.Text=(result).ToString() ;

            lblResultat.Text = "Mr ou Mm " + txtNom.Text;
            lblResultat.Text = lblResultat.Text+ "\n Addition de " + val1 + " et " + val2 + " est " + result;


        }
    }
}
