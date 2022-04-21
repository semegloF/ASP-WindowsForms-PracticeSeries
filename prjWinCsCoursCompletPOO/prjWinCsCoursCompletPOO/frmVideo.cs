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
    public partial class frmVideo : Form
    {
        public frmVideo()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
           
           // String titre = "Information du clinet";
           // String info = "Les Infos sont - elles exactes?";
           // String info2 = "Numero : " + txtNumero.Text + "\n "+"Client : "+txtClient.Text + "\n Adresse : "+txtAdresse.Text + "\n " + info;
           // MessageBox.Show(info2, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
           String titre = "Informations Clinet et Films";
            String msg = "numero : " + txtNumero.Text + " \n";
            msg += "Client : "+txtClient.Text+ " \n";
            msg += "Adresse : " +txtAdresse.Text + " \n";  
            
//---------------------Forme Contractee de if else--------------------------------------------------
            //msg += (chkPreuveId.Checked==true) ?  "Preuve ID :  OUI  \n" :  "Preuve ID :  NON  \n";
            // msg= msg+ "Preuve ID" +  (chkPreuveId.Checked==true) ?  "Preuve ID :  OUI  \n" :  "Preuve ID :  NON  \n"; 

            if (btnRadCelibataire.Checked == true)
            {
                msg += "Statut : Celibataire  \n";
            }
            else if (btnRadMarie.Checked == true)
            {
                msg += "Statut : Marie(e)  \n";
            }
            else if (btnRadSepare.Checked == true)
            {
                msg += "Statut : Separer(e)  \n";
            }
            else
            {
                msg += "Statut : Conjoint(e)  \n";
            }

//-------------------------------Mode de payement--------------------------------------------

            if (btnRadVisa.Checked == true)
            {
                msg += "Statut: VISA  \n";
                
            }
            else if (btnRadMastercard.Checked == true)
            {
                msg += "Statut : Mastercard  \n";
                
            }
            else if (btnRadAmex.Checked == true)
            {
                msg += "Statut : Amex  \n";
               
            }
            else
            {
                MessageBox.Show("Choisissez un Mode de payemenrt");
            }

            msg += "N : " + txtNumCarte.Text+ "  \n";
 //-------------------------Affichage de la liste des films-------------------------------------------

            msg += "Films loués \n";
            //for (int i = 0; i < lstFilms.Items.Count; i++)
            //{
            //    msg += "\t -" + lstFilms.Items[i].ToString() + "\n";
            //}
            foreach (String element in lstFilms.Items)
            {
                msg += "\t-" + element + "\n";
            }

 //-------------------------Affichage des specials-------------------------------------------

            msg += "Special : " + cboSpecial.SelectedItem.ToString()+"\n";

            //---------------------------Calcule de la facture----------------------------------------------
            ////if (cboSpecial.SelectedIndex == 2)
            ////{

            ////    int nbfilm = lstFilms.Items.Count;
            ////    int resulat = 4 * (nbfilm / 2);
            ////    if (nbfilm % 2 == 0)
            ////    {                   
            ////        msg += "Facture : " + resulat + " $ \n";
            ////    }
            ////    else
            ////    {
            ////        int total = resulat + 4;
            ////        msg += "Facture : " + total + " $ \n";
            ////    }

            ////}
            ////else
            ////{
            ////    int total = 4 * lstFilms.Items.Count;
            ////    msg += "Facture : " + total + " $ \n";
            ////}
            ///


            
            Int32 facture, nbfilm;
            nbfilm = lstFilms.Items.Count;
            if (cboSpecial.SelectedItem.ToString() != "2 pour 1")
            {
                facture = nbfilm * 4;
            }
            else
            {
                //Formule qui fait le paire et le impaire
                facture = (nbfilm + 1) / 2 * 4;
            }

            msg += "Facture : " + facture + " $ \n";






            msg += "\n \n \n \n \n \n Les Info sont-elles exactes? ";                 
           
            MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Question);       

        }

        private void frmVideo_Load(object sender, EventArgs e)
        {
            //Rendre ces element invisisble
            lblTitre.Visible=txtTitre.Visible=btnOK.Visible = false;

            //Ajout dans le combo box
            cboSpecial.Items.Add("Regulier");
            cboSpecial.Items.Add("Popcorn gartuit");
            cboSpecial.Items.Add("2 pour 1");

            //Regulier selectionner par defaut
            cboSpecial.SelectedIndex = 0;

        }

        private void btnRadVisa_CheckedChanged(object sender, EventArgs e)
        {
            txtNumCarte.Focus();
        }

        private void btnRadMastercard_CheckedChanged(object sender, EventArgs e)
        {
            txtNumCarte.Focus();
        }

        private void btnRadAmex_CheckedChanged(object sender, EventArgs e)
        {
            txtNumCarte.Focus();
        }

        private void chkPreuveId_CheckedChanged(object sender, EventArgs e)
        {
            //Version contractee de if else
            // btnLouer.Enabled = (chkPreuveId.Checked == true) ?  true :  false;

            //-------Version detaillee de IF et ELSE

            //Autre Forme plus optimisée de programmer
            btnLouer.Enabled = chkPreuveId.Checked;
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String film = txtTitre.Text;
            if (film != "")
            {
                lstFilms.Items.Add(film);
                lblTitre.Visible = txtTitre.Visible = btnOK.Visible = false;
            }
            else
            {
                //Placer le curseur sur le txtTitre
                txtTitre.Focus();
            }


        }

        private void btnLouer_Click(object sender, EventArgs e)
        {
            //Rendre ces element visisble
            lblTitre.Visible = txtTitre.Visible = btnOK.Visible = true;
            txtTitre.Clear();
            txtTitre.Focus();

        }

        private void btnRetourner_Click(object sender, EventArgs e)
        {
            
            lstFilms.Items.RemoveAt(lstFilms.SelectedIndex); //SelectedIndex) = reourne l'element selectionner
             btnRetourner.Enabled = false;
           
            if (lstFilms.SelectedIndex != -1)
            {
                btnRetourner.Enabled = true;
            }
            else
            {
                btnRetourner.Enabled = false;
            }
            

        }

        private void lstFilms_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
