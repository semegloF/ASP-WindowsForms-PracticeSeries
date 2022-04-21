using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWinCsClasses
{
   public class clsEtudiant
    {
        private string vNumero;
        private string vNom;
        private clsDate vNaissance;
        private Single vNote;

        //proprietes publiques
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
        public clsDate Naissance 
        {
            get { return vNaissance; }
           // set { vNaissance = value; }
        }
        public Single Note
        {
            get { return vNote; }
            set { vNote = (value>=100 && value<=0)?value:0 ; }
        }
        public int age
        {
            get { return (DateTime.Today.Year - vNaissance.Annee); }
        }
    }
}
