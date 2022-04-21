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

namespace prjWinCsExamenFinal
{
    public partial class frmExamen : Form
    {
        public frmExamen()
        {
            InitializeComponent();
        }

        //Declaration de varibles globales
        Dictionary<string, clsEmploye> tabEmployes = new Dictionary<string, clsEmploye>();       
        int i = 1;
        string mode = "";
     

        private void frmExamen_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void frmExamen_Load(object sender, EventArgs e)
        {
             //Appelation de la fonction
            RemplirListeFromFichierCompagnie();

            lstNumEmploye.SelectedIndex = 0;

            //Remplissage des textBox et albel
            StreamReader monfichier = new StreamReader("Compagnie.txt");
            string clePremier = monfichier.ReadLine();
           
            txtNumero.Text = tabEmployes[clePremier].Numero;
            txtNom.Text = tabEmployes[clePremier].Nom;
            txtFonction.Text = tabEmployes[clePremier].Fonction;
            txtSalaire.Text = tabEmployes[clePremier].Salaire.ToString();
                        

            lblNbrEmploye.Text = "Employé " + i + " sur un total de " + tabEmployes.Count;
            monfichier.Close();
        }


        private void RemplirListeFromFichierCompagnie()
        {
            StreamReader monfichier = new StreamReader("Compagnie.txt");

            string numero,nom,fonction;
            Single salaire;
            while (monfichier.EndOfStream == false)
            {
                numero = monfichier.ReadLine();
                nom = monfichier.ReadLine();
                fonction = monfichier.ReadLine();
                salaire = Convert.ToSingle(monfichier.ReadLine());

                clsEmploye emp = new clsEmploye(numero,nom,fonction,salaire);
                //Ajout dans la liste tabaaaaaaaemployes
                tabEmployes.Add(emp.Numero,emp);
                lstNumEmploye.Items.Add(emp.Numero);
            }
            monfichier.Close();

        }

        private void lstNumEmploye_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader monfichier = new StreamReader("Compagnie.txt");
            string cle = lstNumEmploye.Text;

            lblNumero.Text = "Numero: " + lstNumEmploye.Text;
            lblNom .Text= "Nom: " + tabEmployes[cle].Nom;
            lblFonction.Text = "Fonction: " + tabEmployes[cle].Fonction;
            lblSalaire.Text = "Salaire: " + tabEmployes[cle].Salaire ;
        }

        private void btnPrecede_Click(object sender, EventArgs e)
        {
            //Remplissage des textBox et albel
            StreamReader monfichier = new StreamReader("Compagnie.txt");
            string clePremier = monfichier.ReadLine();
            ////lstNumEmploye.SelectedIndex = 0;

            //string cle = lstNumEmploye;

            //txtNumero.Text = tabEmployes[clePremier].Numero;
            //txtNom.Text = tabEmployes[clePremier].Nom;
            //txtFonction.Text = tabEmployes[clePremier].Fonction;
            //txtSalaire.Text = tabEmployes[clePremier].Salaire.ToString();


            lblNbrEmploye.Text = "Employé " + (i-1) + " sur un total de " + tabEmployes.Count;
            monfichier.Close();

        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            lblNbrEmploye.Text = "Employé " + (i + 1) + " sur un total de " + tabEmployes.Count;
            
        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            lblNbrEmploye.Text = "Employé " + tabEmployes.Count + " sur un total de " + tabEmployes.Count;
           // monfichier.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNumero.Focus();
            txtNumero.Clear();
            txtNom.Clear();
            txtFonction.Clear();
            txtSalaire.Clear();

            btnModifier.Enabled = btnSupprimer.Enabled = false;
            mode = "Ajout";
            

        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            String numeroAdd = txtNumero.Text;
            String nomAdd = txtNom.Text;
            string fonctionAdd = txtFonction.Text;
            Single salaireAdd = Convert.ToSingle(txtSalaire.Text);
            if (mode == "Ajout")
            {
                clsEmploye addEmp = new clsEmploye(numeroAdd,nomAdd,fonctionAdd,salaireAdd);
               
                tabEmployes.Add(addEmp.Numero, addEmp);         

                


            }
            if (mode == "Modifier")
            {
                clsEmploye addEmp = new clsEmploye(numeroAdd, nomAdd, fonctionAdd, salaireAdd);
                
              
                tabEmployes.Add(addEmp.Numero, addEmp);
               

               
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            btnAjouter.Enabled = btnSupprimer.Enabled = false;
            mode = "Modifier";
        }
    }
}
