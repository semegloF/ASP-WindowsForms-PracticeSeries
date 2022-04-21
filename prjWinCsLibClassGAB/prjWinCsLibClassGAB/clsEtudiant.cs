using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsLibClassGAB
{
   public class clsEtudiant
    {
        // champs prives
        private string vNumero;
        private string vNom;
        private clsDate vNaissance;
        private Single vNote;

        // proprietes publiques
        public string Numero 
        {
            get { return vNumero; }
            set { vNumero = value; }
        }
        public string Nom
        {
            get { return vNom; }
            set { vNom = value; }
        }
        // naissance propriete en lecture seule
        public clsDate Naissance
        {
            get { return vNaissance; }
            //set { vNaissance = value; }
        }
        public Single Note
        {
            get { return vNote; }
            set { vNote = (value <= 100 && value >=0)? value: 0; }
        }
        public int Age
        {
            get { return (DateTime.Today.Year - vNaissance.Annee); }          
        }

        // Constructeurs
        public clsEtudiant()
        {
            vNumero = vNom = "Non defini";
            vNote = -1;
            vNaissance = new clsDate();
        }
        public clsEtudiant(string Numero, string Nom, int Jour, int Mois, int Annee, Single Note)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Note = Note;
            vNaissance = new clsDate(Jour,Mois,Annee);
           
        }
        public clsEtudiant(string Numero, string Nom, clsDate Naissance, Single Note)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Note = Note;
            vNaissance = Naissance;
        }

        // methodes publiques
        public void Inscrire(string Numero, string Nom, int Jour, int Mois, int Annee)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Note = -1;
            vNaissance = new clsDate(Jour, Mois, Annee);
        }

        public override string ToString()
        {
            string tmp = "\nNumero : " + vNumero + "\nNom : " + vNom;
            tmp += "\nNaissance : " + vNaissance.enChiffre() + "\nNote : " + vNote;
            tmp += "/100 \nAge : " + Age + " ans\n";
            return tmp;
        }
    }
}
