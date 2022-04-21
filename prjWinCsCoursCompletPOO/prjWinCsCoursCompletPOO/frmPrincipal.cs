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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            String titre = "Fermeture de l'application";
            String msg = " Etes vous sûre de vouloir quitter le programme?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Application.Exit();
            }
           
            
            
        }

        private void mnuVideo_Click(object sender, EventArgs e)
        {
            //creer une variable de type frmVideo(qui estun objet)
            frmVideo fv = new frmVideo();

            //Informer frmVideo que son parent est frmPrincipal
            fv.MdiParent = this;

            fv.Show();
        }

        private void mnuTimesheet_Click(object sender, EventArgs e)
        {
            //creer une variable de type frmVideo(qui estun objet)
            frmTimesheet ft = new frmTimesheet();

            //Informer frmVideo que son parent est frmPrincipal
            ft.MdiParent = this;

            ft.Show();
        }

        private void mnuConditions_Click(object sender, EventArgs e)
        {
            //creer une variable de type frmVideo(qui estun objet)
            frmCondition fc = new frmCondition();

            //Informer frmVideo que son parent est frmPrincipal
            fc.MdiParent = this;

            fc.Show();
        }

        private void mnuRepetitions_Click(object sender, EventArgs e)
        {
            //creer une variable de type frmVideo(qui estun objet)
            frmBoucle fb = new frmBoucle();

            //Informer frmVideo que son parent est frmPrincipal
            fb.MdiParent = this;

            fb.Show();
        }

        private void mnuFonctions_Click(object sender, EventArgs e)
        {
            //creer une variable de type frmVideo(qui estun objet)
            frmFonction ff = new frmFonction();

            //Informer frmVideo que son parent est frmPrincipal
            ff.MdiParent = this;

            ff.Show();
        }
    }
}
