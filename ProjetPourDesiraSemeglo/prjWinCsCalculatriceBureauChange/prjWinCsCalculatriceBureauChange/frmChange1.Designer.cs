namespace prjWinCsCalculatriceBureauChange
{
    partial class frmChange1
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblResultat = new System.Windows.Forms.Label();
            this.lblInitDevise = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRadValToUsd = new System.Windows.Forms.RadioButton();
            this.btnRadUsdToVal = new System.Windows.Forms.RadioButton();
            this.lblConvert1 = new System.Windows.Forms.Label();
            this.lblConvert2 = new System.Windows.Forms.Label();
            this.cboPays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(636, 327);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(145, 39);
            this.btnQuitter.TabIndex = 21;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(636, 282);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(145, 39);
            this.btnEffacer.TabIndex = 20;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(636, 237);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(145, 39);
            this.btnConvertir.TabIndex = 19;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(401, 293);
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(185, 26);
            this.txtMontant.TabIndex = 18;
            this.txtMontant.Text = "1,00";
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Location = new System.Drawing.Point(35, 387);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(536, 39);
            this.lblResultat.TabIndex = 17;
            // 
            // lblInitDevise
            // 
            this.lblInitDevise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInitDevise.Location = new System.Drawing.Point(401, 237);
            this.lblInitDevise.Name = "lblInitDevise";
            this.lblInitDevise.Size = new System.Drawing.Size(185, 39);
            this.lblInitDevise.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRadValToUsd);
            this.groupBox1.Controls.Add(this.btnRadUsdToVal);
            this.groupBox1.Location = new System.Drawing.Point(20, 237);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 104);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de conversion";
            // 
            // btnRadValToUsd
            // 
            this.btnRadValToUsd.AutoSize = true;
            this.btnRadValToUsd.Location = new System.Drawing.Point(15, 74);
            this.btnRadValToUsd.Name = "btnRadValToUsd";
            this.btnRadValToUsd.Size = new System.Drawing.Size(21, 20);
            this.btnRadValToUsd.TabIndex = 1;
            this.btnRadValToUsd.TabStop = true;
            this.btnRadValToUsd.UseVisualStyleBackColor = true;
            this.btnRadValToUsd.CheckedChanged += new System.EventHandler(this.btnRadFancAUsd_CheckedChanged);
            // 
            // btnRadUsdToVal
            // 
            this.btnRadUsdToVal.AutoSize = true;
            this.btnRadUsdToVal.Location = new System.Drawing.Point(15, 34);
            this.btnRadUsdToVal.Name = "btnRadUsdToVal";
            this.btnRadUsdToVal.Size = new System.Drawing.Size(21, 20);
            this.btnRadUsdToVal.TabIndex = 0;
            this.btnRadUsdToVal.TabStop = true;
            this.btnRadUsdToVal.UseVisualStyleBackColor = true;
            this.btnRadUsdToVal.CheckedChanged += new System.EventHandler(this.btnRadUsdAFranc_CheckedChanged);
            // 
            // lblConvert1
            // 
            this.lblConvert1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConvert1.Location = new System.Drawing.Point(293, 116);
            this.lblConvert1.Name = "lblConvert1";
            this.lblConvert1.Size = new System.Drawing.Size(504, 34);
            this.lblConvert1.TabIndex = 14;
            // 
            // lblConvert2
            // 
            this.lblConvert2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConvert2.Location = new System.Drawing.Point(293, 165);
            this.lblConvert2.Name = "lblConvert2";
            this.lblConvert2.Size = new System.Drawing.Size(504, 39);
            this.lblConvert2.TabIndex = 13;
            // 
            // cboPays
            // 
            this.cboPays.FormattingEnabled = true;
            this.cboPays.Location = new System.Drawing.Point(20, 75);
            this.cboPays.Name = "cboPays";
            this.cboPays.Size = new System.Drawing.Size(121, 28);
            this.cboPays.TabIndex = 12;
            this.cboPays.SelectedIndexChanged += new System.EventHandler(this.cboPays_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "BUREAU-XCHANGE";
            // 
            // frmChange1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblInitDevise);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblConvert1);
            this.Controls.Add(this.lblConvert2);
            this.Controls.Add(this.cboPays);
            this.Controls.Add(this.label1);
            this.Name = "frmChange1";
            this.Text = "frmChange1";
            this.Load += new System.EventHandler(this.frmChange1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.TextBox txtMontant;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Label lblInitDevise;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnRadValToUsd;
        private System.Windows.Forms.RadioButton btnRadUsdToVal;
        private System.Windows.Forms.Label lblConvert1;
        private System.Windows.Forms.Label lblConvert2;
        private System.Windows.Forms.ComboBox cboPays;
        private System.Windows.Forms.Label label1;
    }
}