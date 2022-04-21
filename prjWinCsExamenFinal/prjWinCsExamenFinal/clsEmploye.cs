using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsExamenFinal
{
    class clsEmploye
    {
        //champs privés
        private String vNumero, vNom, vFonction;
        private Single vSalaire;

        // Proprietés Publics

        public String Numero
        {
            get { return vNumero; }
            set { vNumero = value; }
        }
        public String Nom
        {
            get { return vNom; }
            set { vNom = value; }
        }
        public String Fonction
        {
            get { return vFonction; }
            set { vFonction = value; }
        }
        public Single Salaire
        {
            get { return vSalaire; }
            set { vSalaire = value; }
        }

        //Les contructeur

        public clsEmploye(string Numero, string Nom, string fonction, Single Saliare)
        {
            this.Numero = Numero;
            this.Nom = Nom;
            this.Fonction = fonction;
            this.Salaire = Saliare;
           
        }

    }
}
