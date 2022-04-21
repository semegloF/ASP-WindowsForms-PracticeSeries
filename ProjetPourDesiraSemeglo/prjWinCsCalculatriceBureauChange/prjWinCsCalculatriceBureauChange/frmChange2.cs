using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjWinCsCalculatriceBureauChange
{
    public partial class frmChange2 : Form
    {
        public frmChange2()
        {
            InitializeComponent();
        }

        private void frmChange2_Load(object sender, EventArgs e)
        {
            RemplirListe();

        }

        private void RemplirListe()
        {
            //StreamWriter monfichier = new StreamWriter("Devises.txt");
            StreamReader monfichier = new StreamReader("Devises.txt");

            while (monfichier.EndOfStream == false)
            {
                String pays = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                string montant = monfichier.ReadLine();
                cboInitialDevise.Items.Add(devise);
                cboFinalDevise.Items.Add(pays);

            }
            monfichier.Close();
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
