using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCoursCompletPOO
{
    public partial class frmCondition : Form
    {
        public frmCondition()
        {
            InitializeComponent();
        }


        private void btnValiderNum_Click(object sender, EventArgs e)

        {
            Single note = Convert.ToSingle(txtNoteNum.Text);
            String nom = txtNom.Text;
            if (note >= 90 && note <= 100)
            {
                lblResultatNum.Text = nom + " \n Avec " + note + " vous avez A";
            }

            else if (note >= 80 && note < 90)
            {
                lblResultatNum.Text = nom + ", \n Avec " + note + " vous avez B";
            }

            else if (note >= 70 && note < 80)
            {
                lblResultatNum.Text = nom + ", \n Avec " + note + " vous avez C";
            }

            else if (note >= 60 && note < 70)
            {
                lblResultatNum.Text = nom + ", \n Avec " + note + " vous avez D";
            }

            else if (note >= 0 && note < 60)
            {
                lblResultatNum.Text = nom + ", \n Avec " + note + " vous avez E";
            }

            else
            {
               lblResultatNum.Text=  "Note Invalide";
            }

        }

        private void btnValiderAlpha_Click(object sender, EventArgs e)
        {
            char mention = Convert.ToChar( txtNoteAlpha.Text);
            if ( mention== 'A' || mention == 'a')
            {
                lblResultatAlpha.Text = txtNom.Text + ", \n Avec " + txtNoteAlpha.Text + " vous avez  90 à 100";
            }

           else if (mention == 'B' || mention == 'b')
            {
                lblResultatAlpha.Text = txtNom.Text + ", \n Avec " + txtNoteAlpha.Text + " vous avez  80 à 89";
            }

            else if (mention == 'C' || mention == 'c')
            {
                lblResultatAlpha.Text = txtNom.Text + ", \n Avec " + txtNoteAlpha.Text + " vous avez  70 à 79";
            }

           else if (mention == 'D' || mention == 'd')
            {
                lblResultatAlpha.Text = txtNom.Text + ", \n Avec " + txtNoteAlpha.Text + "vous avez  60 à 69";
            }

           else if (mention == 'E' || mention == 'e')
            {
                lblResultatAlpha.Text = txtNom.Text + ", \n Avec " + txtNoteAlpha.Text + " vous avez  0 à 59";
            }

            else
            {
                lblResultatAlpha.Text = "Note Invalide";
            }

        }

        private void txtNoteAlpha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtNom.Text = "";
            txtNoteAlpha.Text = "";
            txtNoteNum.Text = "";
            lblResultatNum.Text = "";
            lblResultatAlpha.Text = "";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            String titre = "Fermeture de l'application";
            String msg = " Etes vous sûre de vouloir quitter la page?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnValiderNum_MouseHover(object sender, EventArgs e)
        {
            btnValiderNum.ForeColor= Color.Red;
        }

        private void btnValiderNum_MouseMove(object sender, MouseEventArgs e)
        {
            btnValiderNum.ForeColor = Color.Black;
        }

        private void frmCondition_Load(object sender, EventArgs e)
        {

        }
    }
}
