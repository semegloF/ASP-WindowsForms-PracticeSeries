namespace hWorkCsWinOperateur
{
    partial class HomeWork
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVal1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVal2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnMultiplication = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDifferent = new System.Windows.Forms.Button();
            this.btnEgal = new System.Windows.Forms.Button();
            this.btnInferieur = new System.Windows.Forms.Button();
            this.btnSuperieur = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "LES OPERATEURS DE BASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(468, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "___________________________________________________";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(13, 83);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(91, 20);
            this.lblNom.TabIndex = 3;
            this.lblNom.Text = "Votre nom: ";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(166, 83);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(464, 26);
            this.txtNom.TabIndex = 4;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valeur 1 : ";
            // 
            // txtVal1
            // 
            this.txtVal1.Location = new System.Drawing.Point(148, 128);
            this.txtVal1.Name = "txtVal1";
            this.txtVal1.Size = new System.Drawing.Size(100, 26);
            this.txtVal1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Valeur 2 : ";
            // 
            // txtVal2
            // 
            this.txtVal2.Location = new System.Drawing.Point(461, 128);
            this.txtVal2.Name = "txtVal2";
            this.txtVal2.Size = new System.Drawing.Size(100, 26);
            this.txtVal2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnModulo);
            this.groupBox1.Controls.Add(this.btnMultiplication);
            this.groupBox1.Controls.Add(this.btnDivision);
            this.groupBox1.Controls.Add(this.btnSoustraction);
            this.groupBox1.Controls.Add(this.btnAddition);
            this.groupBox1.Location = new System.Drawing.Point(78, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operateurs Arithmeques";
            // 
            // btnModulo
            // 
            this.btnModulo.Location = new System.Drawing.Point(273, 53);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(35, 24);
            this.btnModulo.TabIndex = 4;
            this.btnModulo.Text = "%";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnMultiplication
            // 
            this.btnMultiplication.Location = new System.Drawing.Point(215, 53);
            this.btnMultiplication.Name = "btnMultiplication";
            this.btnMultiplication.Size = new System.Drawing.Size(35, 24);
            this.btnMultiplication.TabIndex = 3;
            this.btnMultiplication.Text = "*";
            this.btnMultiplication.UseVisualStyleBackColor = true;
            this.btnMultiplication.Click += new System.EventHandler(this.btnMultiplication_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(133, 53);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(37, 23);
            this.btnDivision.TabIndex = 2;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Location = new System.Drawing.Point(70, 53);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(37, 23);
            this.btnSoustraction.TabIndex = 1;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(7, 53);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(38, 23);
            this.btnAddition.TabIndex = 0;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDifferent);
            this.groupBox2.Controls.Add(this.btnEgal);
            this.groupBox2.Controls.Add(this.btnInferieur);
            this.groupBox2.Controls.Add(this.btnSuperieur);
            this.groupBox2.Location = new System.Drawing.Point(78, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 111);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operateurs Arithmeques";
            // 
            // btnDifferent
            // 
            this.btnDifferent.Location = new System.Drawing.Point(439, 53);
            this.btnDifferent.Name = "btnDifferent";
            this.btnDifferent.Size = new System.Drawing.Size(115, 33);
            this.btnDifferent.TabIndex = 3;
            this.btnDifferent.Text = "Different";
            this.btnDifferent.UseVisualStyleBackColor = true;
            // 
            // btnEgal
            // 
            this.btnEgal.Location = new System.Drawing.Point(273, 53);
            this.btnEgal.Name = "btnEgal";
            this.btnEgal.Size = new System.Drawing.Size(118, 33);
            this.btnEgal.TabIndex = 2;
            this.btnEgal.Text = "Egal";
            this.btnEgal.UseVisualStyleBackColor = true;
            // 
            // btnInferieur
            // 
            this.btnInferieur.Location = new System.Drawing.Point(133, 53);
            this.btnInferieur.Name = "btnInferieur";
            this.btnInferieur.Size = new System.Drawing.Size(117, 33);
            this.btnInferieur.TabIndex = 1;
            this.btnInferieur.Text = "Inferieur";
            this.btnInferieur.UseVisualStyleBackColor = true;
            // 
            // btnSuperieur
            // 
            this.btnSuperieur.Location = new System.Drawing.Point(7, 53);
            this.btnSuperieur.Name = "btnSuperieur";
            this.btnSuperieur.Size = new System.Drawing.Size(120, 33);
            this.btnSuperieur.TabIndex = 0;
            this.btnSuperieur.Text = "Superieur";
            this.btnSuperieur.UseVisualStyleBackColor = true;
            this.btnSuperieur.Click += new System.EventHandler(this.btnSuperieur_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.Location = new System.Drawing.Point(41, 482);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(661, 138);
            this.lblResultat.TabIndex = 11;
            // 
            // HomeWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 650);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtVal2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtVal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HomeWork";
            this.Text = "Home Work";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVal1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVal2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.Button btnMultiplication;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDifferent;
        private System.Windows.Forms.Button btnEgal;
        private System.Windows.Forms.Button btnInferieur;
        private System.Windows.Forms.Button btnSuperieur;
        private System.Windows.Forms.Label lblResultat;
    }
}