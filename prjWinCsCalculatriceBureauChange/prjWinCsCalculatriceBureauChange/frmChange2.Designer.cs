namespace prjWinCsCalculatriceBureauChange
{
    partial class frmChange2
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
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboInitialDevise = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboFinalDevise = new System.Windows.Forms.ComboBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.txtInitialVal = new System.Windows.Forms.TextBox();
            this.txtFinalVal = new System.Windows.Forms.TextBox();
            this.btnImprimer = new System.Windows.Forms.Button();
            this.btnMiseAJour = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "BC1-EXCHANGE";
            // 
            // grpInfo
            // 
            this.grpInfo.Location = new System.Drawing.Point(681, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(200, 100);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Conversion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "De : ";
            // 
            // cboInitialDevise
            // 
            this.cboInitialDevise.FormattingEnabled = true;
            this.cboInitialDevise.Location = new System.Drawing.Point(89, 165);
            this.cboInitialDevise.Name = "cboInitialDevise";
            this.cboInitialDevise.Size = new System.Drawing.Size(202, 28);
            this.cboInitialDevise.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(657, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "A : ";
            // 
            // cboFinalDevise
            // 
            this.cboFinalDevise.FormattingEnabled = true;
            this.cboFinalDevise.Location = new System.Drawing.Point(719, 160);
            this.cboFinalDevise.Name = "cboFinalDevise";
            this.cboFinalDevise.Size = new System.Drawing.Size(194, 28);
            this.cboFinalDevise.TabIndex = 6;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(438, 253);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(75, 33);
            this.btnCalculer.TabIndex = 7;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            // 
            // txtInitialVal
            // 
            this.txtInitialVal.Location = new System.Drawing.Point(89, 241);
            this.txtInitialVal.Name = "txtInitialVal";
            this.txtInitialVal.Size = new System.Drawing.Size(181, 26);
            this.txtInitialVal.TabIndex = 8;
            // 
            // txtFinalVal
            // 
            this.txtFinalVal.Location = new System.Drawing.Point(719, 260);
            this.txtFinalVal.Name = "txtFinalVal";
            this.txtFinalVal.Size = new System.Drawing.Size(194, 26);
            this.txtFinalVal.TabIndex = 9;
            // 
            // btnImprimer
            // 
            this.btnImprimer.Location = new System.Drawing.Point(61, 427);
            this.btnImprimer.Name = "btnImprimer";
            this.btnImprimer.Size = new System.Drawing.Size(143, 33);
            this.btnImprimer.TabIndex = 10;
            this.btnImprimer.Text = "Imprimer Reçu";
            this.btnImprimer.UseVisualStyleBackColor = true;
            // 
            // btnMiseAJour
            // 
            this.btnMiseAJour.Location = new System.Drawing.Point(264, 427);
            this.btnMiseAJour.Name = "btnMiseAJour";
            this.btnMiseAJour.Size = new System.Drawing.Size(175, 33);
            this.btnMiseAJour.TabIndex = 11;
            this.btnMiseAJour.Text = "Mise à Jour";
            this.btnMiseAJour.UseVisualStyleBackColor = true;
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(774, 427);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(75, 33);
            this.btnFermer.TabIndex = 12;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmChange2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 508);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnMiseAJour);
            this.Controls.Add(this.btnImprimer);
            this.Controls.Add(this.txtFinalVal);
            this.Controls.Add(this.txtInitialVal);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.cboFinalDevise);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboInitialDevise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmChange2";
            this.Text = "Devises";
            this.Load += new System.EventHandler(this.frmChange2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboInitialDevise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboFinalDevise;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.TextBox txtInitialVal;
        private System.Windows.Forms.TextBox txtFinalVal;
        private System.Windows.Forms.Button btnImprimer;
        private System.Windows.Forms.Button btnMiseAJour;
        private System.Windows.Forms.Button btnFermer;
    }
}