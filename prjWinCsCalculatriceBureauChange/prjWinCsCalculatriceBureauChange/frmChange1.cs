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
    public partial class frmChange1 : Form
    {
        public frmChange1()
        {
            InitializeComponent();
        }
        struct infoPays
        {
            public string pays;
            public string devise;
            public Single valeur;
        }

        //Variable globale
        StreamReader monfichier = new StreamReader("Devises.txt");
        string pays, devise;
        Single valeur;

        Dictionary<string, infoPays> tabInfoPays = new Dictionary<string, infoPays>();

        private void frmChange1_Load(object sender, EventArgs e)
        {
           
            
            while (monfichier.EndOfStream == false)
            {
                infoPays unInfoPays = new infoPays();
                unInfoPays.pays = monfichier.ReadLine();
                unInfoPays.devise= monfichier.ReadLine();
                unInfoPays.valeur = Convert.ToSingle(monfichier.ReadLine());                
                tabInfoPays.Add(unInfoPays.pays,unInfoPays);   
            }

            foreach (string elmtpays in tabInfoPays.Keys )            {
                cboPays.Items.Add(elmtpays);                
                
            }
            monfichier.Close();
            cboPays.SelectedIndex = 0;

            if (cboPays.SelectedIndex == 0)
            {
                btnRadUsdToVal.Checked = true;
            }
            else
            {
                btnRadValToUsd.Checked = true;
            }
        }

        private void btnRadUsdAFranc_CheckedChanged(object sender, EventArgs e)
        {
            string Key = cboPays.SelectedItem.ToString();
            String devise =tabInfoPays[Key].devise.ToString();
            if (btnRadUsdToVal.Checked)
            {
                lblInitDevise.Text ="US Dollar";
                txtMontant.Focus();
            }
            else
            {
                lblInitDevise.Text = devise;
                txtMontant.Focus();
            }            
        }

        private void btnRadFancAUsd_CheckedChanged(object sender, EventArgs e)
        {
            //string Key = cboPays.SelectedItem.ToString();
            //String Devise = tabInfoPays[Key].devise.ToString();
            //lblInitDevise.Text = de;
            txtMontant.Focus();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtMontant.Text == "")
            {
                txtMontant.Text = "1,00";
            }
            Single montant = Convert.ToSingle(txtMontant.Text);
            Single resultat;
            string Key = cboPays.SelectedItem.ToString();
            String devise = tabInfoPays[Key].devise.ToString();
            Single valeur = tabInfoPays[Key].valeur;

            if (btnRadUsdToVal.Checked == true)
            {
                

                resultat = montant *  (Convert.ToSingle( 1)/valeur);
                lblResultat.Text = resultat.ToString() + " "+devise;
            }
            else
            { 
                resultat = (montant * valeur);
                lblResultat.Text = resultat.ToString() + " US Dollars";
                lblInitDevise.Text = "US Dollar";
            }           
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtMontant.Clear();
            lblResultat.Text = "";
            txtMontant.Focus();
        }

        private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Key = cboPays.SelectedItem.ToString();
            String devise = tabInfoPays[Key].devise.ToString();
            Single valeur = Convert.ToSingle (tabInfoPays[Key].valeur);

            btnRadUsdToVal.Text = "De US Dollars en" + devise.ToString();
            btnRadValToUsd.Text = "De " + devise.ToString() + " En " + "US Dollars";

            lblConvert1.Text = "1 US Dollar = " + valeur.ToString() + " " + devise.ToString();
            lblConvert2.Text = "1 " + devise + " = " + (1 / valeur) + "US Dollar";
            lblInitDevise.Text = devise;           
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            String titre = "Fermeture de l'application";
            String msg = "Etes vous sûre de vouloir quitter le programme?";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.Close();
                
                
            }
        }
    }
}
