using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsLibClassGAB
{
    public class clsTime
    {
        private Int32 vHeure;
        private Int32 vMinute;
        private Int32 vSeconde;

        public int Heure 
        {
            get 
            { return vHeure; }
            
            set 
            { 
                vHeure = (value >= 0 && value < 24)? value:DateTime.Now.Hour ; 
            } 
        }
        public int Minute
        {
            get
            { return vMinute; }

            set
            {
                vMinute = (value >= 0 && value < 60) ? value : DateTime.Now.Minute;
            }
        }

        public int Seconde
        {
            get
            { return vSeconde; }

            set
            {
                vSeconde = (value >= 0 && value < 60) ? value : DateTime.Now.Second;
            }
        }

        public void Regler(int Heure, int Minute, int Seconde)
        {
            this.Heure = Heure;
            this.Minute = Minute;
            this.Seconde = Seconde;
        }

        public string enUniversel()
        {
            return Heure + ":" + Minute + ":" + Seconde;
        }
    }
}
