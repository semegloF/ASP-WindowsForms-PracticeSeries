using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsExercicesPOO
{

    public partial class frmMacDo : Form
    {
        public frmMacDo()
        {
            InitializeComponent();
        }


        private void btnSalaire_Click(object sender, EventArgs e)
        {

            String employe = txtEmploye.Text;
            String anneeNaissance = txtAnnee.Text;
            String horaire = txtTauxHoraire.Text;
            String heures = txtTotalHeures.Text;
            String heureSup = txtHeureSup.Text;
            int age = 2021 - Convert.ToInt32(anneeNaissance);
            int salaire = Convert.ToInt32(horaire) * Convert.ToInt32(heures);
            int salaireSup = Convert.ToInt32(horaire) * Convert.ToInt32(heureSup);

            lblResultat.Text = employe + " a " + age +"\n";
            lblResultat.Text = lblResultat.Text + "Son salaire de base est   " + salaire + " $ \n";
            lblResultat.Text = lblResultat.Text + "Son salaire spplementaire " + salaireSup + " $ \n";
            lblResultat.Text = lblResultat.Text + "Revenu total " + (salaire +salaireSup) + " $ \n";

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtEmploye.Text = "";
            txtHeureSup.Text = "";
            txtEmploye.Focus();
            txtTauxHoraire.Text = "";
            txtTotalHeures.Text = "";
            txtAnnee.Text = "";
            lblResultat.Text = "";
            
        }
    }
}
