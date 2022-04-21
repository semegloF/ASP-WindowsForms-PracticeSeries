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
    public partial class frmStandard : Form
    {
        public frmStandard()
        {
            InitializeComponent();
           
        }

        //Declaration public des variables
        Double valeur;
        char oper;

//--------------------------------les boutons numeriques------------------------------------------------------
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text == "0" || txtOperation.Text== "Division par zero impossible")
            {
                txtOperation.Text = btn1.Text;
            }
            else
            {
                txtOperation.Text += btn1.Text;
            }            
            
        }

        private void btn0_Click(object sender, EventArgs e)
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

        private void btn2_Click(object sender, EventArgs e)
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

        private void btn3_Click(object sender, EventArgs e)
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

        private void btn4_Click(object sender, EventArgs e)
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

        private void btn5_Click(object sender, EventArgs e)
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

        private void btn6_Click(object sender, EventArgs e)
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

        private void btn7_Click(object sender, EventArgs e)
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

        private void btn8_Click(object sender, EventArgs e)
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

        private void btn9_Click(object sender, EventArgs e)
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


//-------------------------------------------Les boutons d'operation-------------------------------------------------
        private void btnModulo_Click(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '%';
            txtOperation.Text = "0";
        }

        private void btn1parX_Click(object sender, EventArgs e)
        {
            // lblOperation.Text += btn1parX.Text;
            valeur = 1/ (Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();

        }

        private void btnCarre_Click(object sender, EventArgs e)
        {
            valeur = Math.Pow ((Double.Parse(txtOperation.Text)),2);
            txtOperation.Text = valeur.ToString();
        }

        private void btnRacineCarre_Click(object sender, EventArgs e)
        {
            valeur = Math.Sqrt(Double.Parse(txtOperation.Text));
            txtOperation.Text = valeur.ToString();
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtOperation.Text = "0";
        }

        private void btnAddiction_Click(object sender, EventArgs e)
        {
            /// lblOperation.Text +=btnAddiction.Text;
            valeur = double.Parse(txtOperation.Text);
            oper = '+';
            txtOperation.Text = "0";

        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '-';
            txtOperation.Text = "0";
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = 'x';
            txtOperation.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            valeur = double.Parse(txtOperation.Text);
            oper = '/';
            txtOperation.Text = "0";
        }

        private void btnAddSous_Click(object sender, EventArgs e)
        {
            valeur =( Double.Parse(txtOperation.Text))*(-1);
            txtOperation.Text = valeur.ToString();
        }
//-------------------------Bouton Egale-------------------------------------------------------------
        private void btnEgale_Click(object sender, EventArgs e)
        {
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
            else if (oper == '%')
            {
                valeur = double.Parse(txtOperation.Text)/100;
                txtOperation.Text = valeur.ToString();
            }
            else
            {
                txtOperation.Text = valeur.ToString();
            }

        }//----------Fin bouton egale----------------------------------------

        private void btnVirgul_Click(object sender, EventArgs e)
        {
            if (txtOperation.Text.Contains(",")==false)
            {
                txtOperation.Text += ",";
            }
                       
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtOperation.Text="0";
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            //Efface le dernier caractere du text qui est dans le txtOperation
            int length = txtOperation.TextLength -1;
            String text = txtOperation.Text;
            txtOperation.Clear();
            for(int i = 0; i< length; i++)
            {
                txtOperation.Text += text[i];
            }

        }
    }
}
