using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatriceBureauChange
{
    public partial class frmScientific : Form
    {
        public frmScientific()
        {
            InitializeComponent();
        }

        //Declaration public des variables
        Double valeur;
        char oper;


        //--------------------------Bouton de fonction-----------------------------------------------------------------------

        private void btnLog_Click(object sender, EventArgs e)
        {
             valeur =Math.Log10( Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnRacineCarre_Click(object sender, EventArgs e)
        {
             valeur = Math.Sqrt(Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnXcarre_Click(object sender, EventArgs e)
        {
            valeur = Math.Pow((Double.Parse(txtOperation.Text)), 2);
            txtOperation.Text = valeur.ToString();
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            valeur = Double.Parse(txtOperation.Text);
            txtOperation.Text = Math.Exp(valeur * Math.Log(valeur * 4)).ToString();
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            txtOperation.Text = " 3, 141592653589793";
        }

        private void btnXexpoY_Click(object sender, EventArgs e)
        {
            lblY.Visible=txtY.Visible = true;
            txtY.Focus();
            txtOperation.Text = valeur.ToString();

        }

        private void btn10expoX_Click(object sender, EventArgs e)
        {
            valeur = Math.Pow((10), Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            valeur = Math.Log(Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnUnParX_Click(object sender, EventArgs e)
        {
            valeur = 1 / (Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
           
            valeur = double.Parse(txtOperation.Text);
            oper = 'm';
            txtOperation.Text = "0";
        }

        private void btn1parX_Click(object sender, EventArgs e)
        {
            
            valeur = 1 / (Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();

        }

        private void btnCarre_Click(object sender, EventArgs e)
        {
            valeur = Math.Pow((Double.Parse(txtOperation.Text)), 2);
            txtOperation.Text = valeur.ToString();
        }




      
 ///------------------------------Bouton egale---------------------------------------------------
        private void btnEgale_Click(object sender, EventArgs e)
        {
            //Achaque operation effectue un calcul
            if (oper == '+')
            {
                valeur = valeur + double.Parse(txtOperation.Text);
                txtOperation.Text = valeur.ToString();
            }
            else if (oper == '-')
            {
                valeur = valeur - double.Parse(txtOperation.Text);
                txtOperation.Text = valeur.ToString();
            }
            else if (oper == 'x')
            {
                valeur = valeur * double.Parse(txtOperation.Text);
                txtOperation.Text = valeur.ToString();
            }
            else if (oper == '/')
            {
                //Affiche un message quand il ya division par "0"
                if (txtOperation.Text == "0")
                {
                    txtOperation.Text = "Division par zero impossible";
                }
                else
                {
                    valeur = valeur / double.Parse(txtOperation.Text);
                    txtOperation.Text = valeur.ToString();
                }

            }
            else if (oper == 'm')
            {
                valeur = valeur % double.Parse(txtOperation.Text);
                txtOperation.Text = valeur.ToString();
            }

            else
            {
                txtOperation.Text = valeur.ToString();
            }
        }



  //------------------Buton numerique--------------------------------------------------------------------------------------------
        private void btn0_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn0.Text;
            }
            else
            {
                txtOperation.Text += btn0.Text;
            }
        }
        private void btn1_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn1.Text;
            }
            else
            {
                txtOperation.Text += btn1.Text;
            }
        
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn2.Text;
            }
            else
            {
                txtOperation.Text += btn2.Text;
            }
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {

            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn3.Text;
            }
            else
            {
                txtOperation.Text += btn3.Text;
            }
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn4.Text;
            }
            else
            {
                txtOperation.Text += btn4.Text;
            }
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn5.Text;
            }
            else
            {
                txtOperation.Text += btn5.Text;
            }
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0")
            {
                txtOperation.Text = btn6.Text;
            }
            else
            {
                txtOperation.Text += btn6.Text;
            }
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn7.Text;
            }
            else
            {
                txtOperation.Text += btn7.Text;
            }
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn8.Text;
            }
            else
            {
                txtOperation.Text += btn8.Text;
            }
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btn9.Text;
            }
            else
            {
                txtOperation.Text += btn9.Text;
            }
        }



 //-------------------------Bouton de symbole------------------------------------------------------------

        private void btnParentheseOuvert_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btnParentheseOuvert.Text;
            }
            else
            {
                txtOperation.Text += btnParentheseOuvert.Text;
            }
        }

        private void btnParentheseFermer_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text == "Division par zero impossible")
            {
                txtOperation.Text = btnParentheseFermer.Text;
            }
            else
            {
                txtOperation.Text += btnParentheseFermer;
            }
        }
         
        private void btnVirgul_Click_1(object sender, EventArgs e)
        {
            if (txtOperation.Text.Contains(",") == false)
            {
                txtOperation.Text += ",";
            }
        }

        private void btnAddiction_Click_1(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '+';
            txtOperation.Text = "0";
        }

        private void btnSoustraction_Click_1(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '-';
            txtOperation.Text = "0";
        }

        private void btnMultiplication_Click_1(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = 'x';
            txtOperation.Text = "0";
        }

        private void btnDivision_Click_1(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '/';
            txtOperation.Text = "0";
        }

        private void btnAddSous_Click_1(object sender, EventArgs e)
        {
            valeur = (Double.Parse(txtOperation.Text)) * (-1);
            txtOperation.Text = valeur.ToString();
        }

        private void btnEffacer_Click_1(object sender, EventArgs e)
        {
            int length = txtOperation.TextLength - 1;
            String text = txtOperation.Text;
            txtOperation.Clear();
            for (int i = 0; i < length; i++)
            {
                txtOperation.Text += text[i];
            }
        }

        private void btnC_Click_1(object sender, EventArgs e)
        {
            txtOperation.Text = "0";
        }
//---------------------------------------------------------------------------------------------------------------------
                //--------------Fonction factoriel------------------------------
                private long Factoriel(int nb)
                {
                    return nb > 1 ? nb * this.Factoriel(nb - 1) : 1;
                }

        private void btnFactoriel_Click(object sender, EventArgs e)
        {
            int valeurFacto = Convert.ToInt32(txtOperation.Text);
            Factoriel(valeurFacto);

            txtOperation.Text = valeurFacto.ToString(); 
        }

       
    }

   
    
}
