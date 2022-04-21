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
    public partial class frmTimesheet : Form
    {
        public frmTimesheet()
        {
            InitializeComponent();
        }

        private void frmTimesheet_Load(object sender, EventArgs e)
        {

             lblInfo.Text = "Aujourd' hui" + DateTime.Today.Day.ToString() + "," + DateTime.Today.Month.ToString()
               +"," +DateTime.Today.Year.ToString();

           // lblInfo.Text = "Aujourd' hui" + DateTime.Today.ToShortDateString();

           // DateTime anniversaire = new DateTime (2002, 05, 08);
           //lblResultat.Text = anniversaire.DayOfWeek.ToString();
        }

        private void btnEntree_Click(object sender, EventArgs e)
        {
            //Retourne juste l'heure
            txtEntree.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnSortie_Click(object sender, EventArgs e)
        {
            txtSortie.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            DateTime tmpEntree = Convert.ToDateTime(txtEntree.Text);
            DateTime tmpSortie = Convert.ToDateTime(txtSortie.Text);
            int h, hs, he, m, ms, me, s, ss, se;

            ss = tmpSortie.Second;
            ms = tmpSortie.Minute;
            hs = tmpSortie.Hour;

            se = tmpEntree.Second;
            me = tmpEntree.Minute;
            he = tmpEntree.Hour;

            if (se > ss)
            {
                ms -= 1;
                ss += 60;
            }
            s = ss - se;
            if (me > ms)
            {
                hs -= 1;
                ms += 60;
            }
            m = ms - me;
            h = hs - he;

            lblResultat.Text = "Temps travaillés " + h + " h" + m + " m" + s + " s";




        }
    }
}
