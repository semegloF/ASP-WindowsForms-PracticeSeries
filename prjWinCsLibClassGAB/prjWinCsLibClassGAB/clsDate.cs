using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsLibClassGAB
{
    public class clsDate
    {
        private Int32 vJour;
        private Int32 vMois;
        private Int32 vAnnee;


        public clsDate()
        {
            vJour = vMois = vAnnee = 1;
        }
        public clsDate(int Jour)
        {
           this.Jour = Jour;
            vMois = DateTime.Today.Month;
            vAnnee = DateTime.Today.Year; 
        }
        public clsDate(int Jour, int Mois, int Annee)
        {
            this.Jour = Jour;
            this.Mois = Mois;
            this.Annee = Annee;
        }

        public int Jour
        {
            get
            { return vJour; }

            set
            {
                vJour = (value >= 1 && value <= 31) ? value : 1;
            }
        }
        public int Mois
        {
            get
            { return vMois; }

            set
            {
                vMois = (value >= 1 && value <= 12) ? value : 1;
            }
        }

        public int Annee
        {
            get
            { return vAnnee; }

            set
            {
                vAnnee = (value >= 1 && value < 9999) ? value : 1;
            }
        }

        public void Regler(int Jour, int Mois, int Annee)
        {
            this.Jour = Jour;
            this.Mois = Mois;
            this.Annee = Annee;
        }

        public string enChiffre()
        {
            return Jour + "/" + Mois + "/" + Annee;
        }

        public string enLettre()
        {
            string[] tabMois = {"Janvier ","Fevrier ","Mars ", "Avril ", "Mai ", "Juin ",
                "Juillet ", "Aout", "Septembre ","Octobre ","Novembre ","Decembre " };

            string[] tabJours = {"Dimanche ","Lundi ","Mardi ","Mercredi ", "Jeudi ", "Vendredi ", "Samedi "};
            DateTime uneDate = new DateTime(Annee, Mois, Jour);
            Int32 indxJour = Convert.ToInt32(uneDate.DayOfWeek);

            return tabJours[indxJour] + Jour + " " + tabMois[Mois - 1] + Annee;
        }
    }
}
