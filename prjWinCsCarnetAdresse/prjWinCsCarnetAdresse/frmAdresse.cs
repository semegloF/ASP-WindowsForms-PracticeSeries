using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCarnetAdresse
{
    public partial class frmAdresse : Form
    {
        public frmAdresse()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string np, nom, prenom, adresse,VPCP,ville,province, cp;
            int posV,posV1,posV2;
            np = txtNomPrenom.Text;

            //Eleve les espaces à l'extremité du text
            np = np.Trim();
            if (np.Length == 0)
            {
                MessageBox.Show("Entrez un nom et prenom SVP!");
                //Pointe le curceur dans le txtNomPrenom
                txtNomPrenom.Focus();
                return;
            }

            //Recupre la postion de la virgule
            posV = np.IndexOf(",");
            if (posV == -1)
            {
                MessageBox.Show("Entrez une virgule entre nom et prenom!");
                txtNomPrenom.Focus();
                return;
            }
            
            //recupere la chaine de caractere commencant par la position 0 et de longueur posV(Position de la virgule)
            nom = np.Substring(0, posV);
            nom = nom.Trim();
            if (nom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un nom avant la virgule!");
                txtNomPrenom.Focus();
                return;
            }

            //Recupere la chaine de caractere de la postion posV(position de la vigule) jusqu' à la fin
            prenom = np.Substring( posV+1);
            prenom.Trim();
            if (nom.Length == 0)
            {
                MessageBox.Show("Veuillez entrer un prenom apres la virgule!");
                txtNomPrenom.Focus();
                return;
            }

            adresse = txtAdresse.Text.Trim();
            if (np.Length == 0)
            {
                MessageBox.Show("Entrez une sdresse SVP!");
                //Pointe le curceur dans le txtNomPrenom
                txtNomPrenom.Focus();
                return;
            }

            VPCP = txtVPCP.Text.Trim();
            posV1 = txtVPCP.Text.IndexOf(",");
            posV2 = txtVPCP.Text.IndexOf(",",posV1+1);
            ville = VPCP.Substring(0, posV1).Trim();
            province = VPCP.Substring(posV1 + 1, posV2 - posV1 - 1).Trim();
            cp = VPCP.Substring(posV2+1).Trim();

            lblNom.Text = nom.Substring(0,1).ToUpper() + nom.Substring(1).ToLower(); 
            lblPrenom.Text = prenom.Substring(0,1).ToUpper() + prenom.Substring(1).ToLower(); ;
            lblVille.Text = ville;
            lblAdresse.Text = txtAdresse.Text;
            lblProvince.Text = province;
            lblCP.Text = cp;
            


        }
    }
}
