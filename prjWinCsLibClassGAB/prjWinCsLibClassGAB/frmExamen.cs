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

namespace prjWinCsLibClassGAB
{
    public partial class frmExamen : Form
    {
        public frmExamen()
        {
            InitializeComponent();
        }

        //Declaration de strucure et variable globale

        struct prof
        {
            public string numero;
            public string nom;
            public Int16 age;
        }

        //declaration collection
        List<prof> tabProfs = new List<prof>();

        private void frmExamen_Load(object sender, EventArgs e)
        {
            //il va ouvrir(ou creer si le fichier n'existe pas) en ecriture;
            //StreamWriter monFichier = new StreamWriter("Films.txt", true);
            //monFichier.WriteLine("poo1");
            //monFichier.WriteLine("Rambo4");
            //monFichier.WriteLine("1981");

            //monFichier.Close();
            //MessageBox.Show("ok");
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //StreamReader monFichier = new StreamReader("Professeurs.txt");
            //String nom, numero;
            //Int16 age;
            //string tout = "";


            ////tant qu'on a pas atteind la fin du fichier
            //while(monFichier.EndOfStream==false)
            //{
            //    numero = monFichier.ReadLine();
            //    nom = monFichier.ReadLine();
            //    age = Convert.ToInt16(monFichier.ReadLine());

            //    tout+= numero + "\n" + nom + "\n" + age;
            //}
            //MessageBox.Show(tout);

            //monFichier.Close();
            //-----------------------------------------------------------------------------------------------------////////////////////////////////
            //----------------Lire le contenu du fichier Professeurs.txt et l'afficher dans la collection---------------------
            StreamReader monFichier = new StreamReader("Professeurs.txt");
            string tout = "";

            while (monFichier.EndOfStream == false)
            {
                prof unProf;

                unProf.numero = monFichier.ReadLine();
                unProf.nom = monFichier.ReadLine();
                unProf.age = Convert.ToInt16(monFichier.ReadLine());

                //Ajouter le prof dans la collection
                tabProfs.Add(unProf);

            }
            MessageBox.Show("Nombre de prof est " + tabProfs.Count);
            monFichier.Close();

            foreach (prof elmProf in tabProfs)
            {
                
                if (elmProf.age > 27)
                {
                    checkProf.Items.Add(elmProf.nom);
                }

            }

            //----------------------------------------------------------------------------------------------------
            //---------------Ecrire les elements de la collection dans le fichier Professeurs.txt--------------------
            //StreamWriter monFichier2 = new StreamWriter("Professeurs.txt", true);

            //prof profAdd, profAdd2, profAdd3;
            //profAdd.numero = "p004";
            //profAdd.nom = "lolo4";
            //profAdd.age = 23;

            //profAdd2.numero = "p005";
            //profAdd2.nom = "lala5";
            //profAdd2.age = 26;

            //profAdd3.numero = "p006";
            //profAdd3.nom = "lala6";
            //profAdd3.age = 29;


            //tabProfs.Add(profAdd);
            //tabProfs.Add(profAdd2);
            //tabProfs.Add(profAdd3);

            //foreach (prof elmtProf in tabProfs)
            //{
            //    monFichier2.WriteLine(elmtProf.numero);
            //    monFichier2.WriteLine(elmtProf.nom);
            //    monFichier2.WriteLine(elmtProf.age);



            //}
            //monFichier2.Close();








        }
    }
}
