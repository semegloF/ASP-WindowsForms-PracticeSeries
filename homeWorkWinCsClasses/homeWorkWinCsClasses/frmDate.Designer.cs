namespace homeWorkWinCsClasses
{
    partial class frmDate
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
            this.lblChiffre = new System.Windows.Forms.Label();
            this.lblLettre = new System.Windows.Forms.Label();
            this.btnSuivant = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChiffre
            // 
            this.lblChiffre.AutoSize = true;
            this.lblChiffre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiffre.Location = new System.Drawing.Point(338, 46);
            this.lblChiffre.Name = "lblChiffre";
            this.lblChiffre.Size = new System.Drawing.Size(70, 25);
            this.lblChiffre.TabIndex = 0;
            this.lblChiffre.Text = "label1";
            // 
            // lblLettre
            // 
            this.lblLettre.AutoSize = true;
            this.lblLettre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLettre.Location = new System.Drawing.Point(339, 126);
            this.lblLettre.Name = "lblLettre";
            this.lblLettre.Size = new System.Drawing.Size(57, 20);
            this.lblLettre.TabIndex = 1;
            this.lblLettre.Text = "label2";
            // 
            // btnSuivant
            // 
            this.btnSuivant.Location = new System.Drawing.Point(526, 198);
            this.btnSuivant.Name = "btnSuivant";
            this.btnSuivant.Size = new System.Drawing.Size(241, 70);
            this.btnSuivant.TabIndex = 2;
            this.btnSuivant.Text = "Page Etudiants";
            this.btnSuivant.UseVisualStyleBackColor = true;
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);
            // 
            // frmDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSuivant);
            this.Controls.Add(this.lblLettre);
            this.Controls.Add(this.lblChiffre);
            this.Name = "frmDate";
            this.Text = "frmDate";
            this.Load += new System.EventHandler(this.frmDate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChiffre;
        private System.Windows.Forms.Label lblLettre;
        private System.Windows.Forms.Button btnSuivant;
    }
}