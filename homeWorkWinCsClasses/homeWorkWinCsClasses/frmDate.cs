using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeWorkWinCsClasses
{
    public partial class frmDate : Form
    {
        public frmDate()
        {
            InitializeComponent();
        }

        private void frmDate_Load(object sender, EventArgs e)
        {
            clsDate rv = new clsDate();
            rv.Regler(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);
            lblChiffre.Text = rv.EnChiffre();
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEtudiant fEtud = new frmEtudiant();
            fEtud.ShowDialog();
        }
    }
}
