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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuMcDonald_Click(object sender, EventArgs e)
        {
            frmMacDo fm = new frmMacDo();

            fm.MdiParent = this;

            fm.Show();


        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            String titre = "Fermeture de l'application";
            String msg = " Etes vous sûre de vouloir quitter le programme?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.Yes)
                    {
                Application.Exit();   
                    };
        }
    }
}
