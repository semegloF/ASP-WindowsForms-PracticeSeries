using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWinCsClasses
{
   public class clsDate
    {
        private int vJour;
        private int vMois;
        private int vAnnee;

        public int Jour
        {
            get { return vJour; }
            set { vJour = (value >= 1 && value<= 31) ? value : 1; }
        }
        public int Mois
        {
            get { return vMois; }
            set { vMois = (value >= 1 && value <= 12) ? value : 1; ; }
        }
        public int Annee
        {
            get { return vAnnee; }
            set { vAnnee = (value >= 1 && value <= 9999) ? value : 1;  }
        }

        public void Regler(int Jour, int Mois, int Annee)
        {
            this.Jour = Jour;
            this.Mois = Mois;
            this.Annee = Annee;
        }

        public string EnChiffre()
        {
            return Jour + "/" + Mois + "/" + Annee;
        }
        public string enLettre()
        {
            string nomJour, nomMois;
            string[] tabMois = { "Janvier ", "Fevrier ", "Mars " , "Avril ", "Mai " , "Juin " , "Juillet ", "Aout ", "Septembre " , "Octobre ", "Novembre " ,"Decembre " };
            string[] tabJours = { "Dimance ", "Lundi ", "Mardi ", "mercredi ", "Jeudi ", "Vendredi", "Samedi " };

            DateTime uneDate = new DateTime(Annee, Mois, Jour);
            Int32 indxJour = Convert.ToInt32(uneDate.DayOfWeek);

            return tabJours[indxJour] + Jour + " " + tabMois[Mois - 1] + Annee;  

        }
    }

   
        

}
