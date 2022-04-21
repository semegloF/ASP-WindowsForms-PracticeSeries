using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // lire et ecrire dans fichier

namespace prjWinCsLibClassGAB
{
    public partial class frmDictionary : Form
    {
        public frmDictionary()
        {
            InitializeComponent();
        }
        List<clsEtudiant> macol = new List<clsEtudiant>();

        Dictionary<string,clsEtudiant> tabEtudiants = new Dictionary<string,clsEtudiant>();
        private void frmDictionary_Load(object sender, EventArgs e)
        {
            


            //RemplirListe();
           RemplirListeFromFichier();
           
            // afficher (remplir) le listebox avec les numeros de tous les etudiants de la collection tabetudiants
            //foreach (clsEtudiant et in tabEtudiants.Values)
            // {
            //     lstNumeros.Items.Add(et.Numero);
            // }
            foreach (string cle in tabEtudiants.Keys)
            {
                lstNumeros.Items.Add(cle);
            }

        }

        private void RemplirListe()
        {
            clsEtudiant et = new clsEtudiant("et001", "Bill Gates", 23, 11, 2000, 92);
            tabEtudiants.Add(et.Numero, et);
            tabEtudiants.Add("et025", new clsEtudiant("et025", "Steve Jobs", 23, 11, 1990, 97));
            tabEtudiants.Add("et034", new clsEtudiant("et034", "Sophie Marceau", 23, 11, 1991, 57));
            tabEtudiants.Add("et180", new clsEtudiant("et180", "Ali Baba", 23, 11, 1989, 46));
            tabEtudiants.Add("et012", new clsEtudiant("et012", "Alice Morgan", 23, 11, 1997, 80));
        }
         private void RemplirListeFromFichier()
        {
            StreamReader monfichier = new StreamReader("Etudiants.txt");
            string num, nom;
            int jr, mn, an;
            Single note;
            while (monfichier.EndOfStream == false)
            {
                num = monfichier.ReadLine();
                
                nom = monfichier.ReadLine();
                jr = Convert.ToInt32(monfichier.ReadLine());
                mn = Convert.ToInt32(monfichier.ReadLine());
                an = Convert.ToInt32(monfichier.ReadLine());
                note = Convert.ToSingle(monfichier.ReadLine());
                clsEtudiant tmp = new clsEtudiant(num, nom, jr, mn, an, note);
                tabEtudiants.Add(tmp.Numero, tmp);
            }


            monfichier.Close();
        }

        private void lstNumeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            // recuperer le numero etudiant selectionne (aussi la cle dans le dictionnaire)
            string cle = lstNumeros.SelectedItem.ToString();
            lblInfo.Text = tabEtudiants[cle].ToString();
            Single note = tabEtudiants[cle].Note;
            this.Text = (note >= 60) ? "Passe" : "Coule";
        }
    }
}
