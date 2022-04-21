using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsTeccart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private struct Etudiant
        {
            public string Nom;
            public DateTime Naissance;
            public Single Moyenne;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Etudiant unEtud;
            unEtud.Nom = txtNom.Text.Trim();
            unEtud.Naissance = datNaissance.Value;
            unEtud.Moyenne = Convert.ToSingle(txtMoyenne.Text);
            

            string info = unEtud.Nom + "\t" + unEtud.Naissance.ToShortDateString() + "\t" + unEtud.Moyenne + "\t" + ((unEtud.Moyenne >= 60) ? "Passe" : "Coule");

            lstEtudiant.Items.Add(info);
            txtNom.Text = txtMoyenne.Text = "";
            //Retourne la valeur par defaut de dateTime
            datNaissance.ResetText();
            txtNom.Focus();
        }
    }
}
