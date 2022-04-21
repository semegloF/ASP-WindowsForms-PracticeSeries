using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatriceBureauChange
{
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void toolStripScientifique_Click(object sender, EventArgs e)
        {
            //Creation d'un objet de type frmScientific
            frmScientific fsc = new frmScientific();

            //precision de la forme pricipale comme parent
            fsc.MdiParent = this;

            //Affiche frmScientific lors du click sur le menu Scientifique
            fsc.Show();
            
        }

        private void mnuScientifique_Click(object sender, EventArgs e)
        {
            //Creation d'un objet de type frmScientific
            frmScientific fsc = new frmScientific();

            //precision de la forme pricipale comme parent
            fsc.MdiParent = this;

            //Affiche frmScientific lors du click sur le menu Scientifique
            fsc.Show();
        }

        private void mnuStandard_Click(object sender, EventArgs e)
        {
            //Creation d'un objet de type frmStandard
            frmStandard fst = new frmStandard();

            //precision de la forme pricipale comme parent
            fst.MdiParent = this;

            //Affiche frmStandard lors du click sur le menu Scientifique
            fst.Show();
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            String titre = "Fermeture de l'application";
            String msg = "Etes vous sûre de vouloir quitter le programme?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void toolStripStandard_Click(object sender, EventArgs e)
        {
            //Creation d'un objet de type frmStandard
            frmStandard fst = new frmStandard();

            //precision de la forme pricipale comme parent
            fst.MdiParent = this;

            //Affiche frmStandard lors du click sur le menu Scientifique
            fst.Show();
        }

        private void toolStripChange2_Click(object sender, EventArgs e)
        {
            frmChange2 fchg2 = new frmChange2();
            fchg2.MdiParent = this;
            fchg2.Show();
        }

        private void toolStripChange1_Click(object sender, EventArgs e)
        {
            frmChange1 fchg1 = new frmChange1();
            fchg1.MdiParent = this;
            fchg1.Show();
            
        }
    }
}
