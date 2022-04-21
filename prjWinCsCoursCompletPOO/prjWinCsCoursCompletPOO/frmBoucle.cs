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
    public partial class frmBoucle : Form
    {
        public frmBoucle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int debut = Convert.ToInt32(txtDebut.Text);
            int fin = Convert.ToInt32(txtFin.Text);
            int intervalle = Convert.ToInt32(txtInterval.Text);


            lstResultats.Items.Clear();
            while (debut <= fin)
            {
                
                    lstResultats.Items.Add(debut.ToString());
                    debut += intervalle;
                               
           
            }


        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int debut = Convert.ToInt32(txtDebut.Text);
            int fin = Convert.ToInt32(txtFin.Text);
            int intervalle = Convert.ToInt32(txtInterval.Text);


            lstResultats.Items.Clear();
            for (int i= debut; i <= fin; i+=intervalle )
            {

                lstResultats.Items.Add(debut.ToString());
                debut += intervalle;
            }
        }

        private void btnDoWhile_Click(object sender, EventArgs e)
        {
            int debut = Convert.ToInt32(txtDebut.Text);
            int fin = Convert.ToInt32(txtFin.Text);
            int intervalle = Convert.ToInt32(txtInterval.Text);

            lstResultats.Items.Clear();
            do
            {
                if (debut <= fin)
                {
                    lstResultats.Items.Add(debut.ToString());
                    debut += intervalle;
                }              
                
            }
            while (debut <= fin);
           
        }
    }
}
