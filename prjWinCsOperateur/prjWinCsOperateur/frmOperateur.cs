using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsOperateur
{
    public partial class frmOperateur : Form
    {
        public frmOperateur()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Ayooy tu m'as cliqué");
            txtValeur1.Text = "";
            txtValeur2.Text = "";
            lblResultat.Text = "";
            txtValeur1.Focus();

        }

        private void txtValeur2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            Single val1, val2, result ;
             val1 = Convert.ToSingle(txtValeur1.Text);
             val2 = Convert.ToSingle(txtValeur2.Text);
             result = val1 + val2;


            //lblResultat.Text=(result).ToString() ;

            lblResultat.Text="Addition de "+val1+" et "+val2 + " est " + result;


            
            result = val1 - val2;  
            

            //Garde l'ancienne valeur de lblresultat et ajoute la nouvelle ......
            lblResultat.Text = lblResultat.Text + "\n Sostration de " + val1 + " et " + val2 + " est " + result;



        }
    }
}
