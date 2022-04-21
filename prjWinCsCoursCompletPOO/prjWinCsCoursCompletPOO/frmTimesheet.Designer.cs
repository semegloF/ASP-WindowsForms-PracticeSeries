namespace prjWinCsCoursCompletPOO
{
    partial class frmTimesheet
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEntree = new System.Windows.Forms.Button();
            this.btnSortie = new System.Windows.Forms.Button();
            this.txtEntree = new System.Windows.Forms.TextBox();
            this.txtSortie = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.lblResultat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIMESHEET";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(329, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "___________";
            // 
            // lblInfo
            // 
            this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(12, 83);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(311, 29);
            this.lblInfo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Heure d\'entrée";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Heure Sortie";
            // 
            // btnEntree
            // 
            this.btnEntree.Location = new System.Drawing.Point(40, 187);
            this.btnEntree.Name = "btnEntree";
            this.btnEntree.Size = new System.Drawing.Size(111, 33);
            this.btnEntree.TabIndex = 9;
            this.btnEntree.Text = "Miantenant";
            this.btnEntree.UseVisualStyleBackColor = true;
            this.btnEntree.Click += new System.EventHandler(this.btnEntree_Click);
            // 
            // btnSortie
            // 
            this.btnSortie.Location = new System.Drawing.Point(348, 187);
            this.btnSortie.Name = "btnSortie";
            this.btnSortie.Size = new System.Drawing.Size(124, 33);
            this.btnSortie.TabIndex = 10;
            this.btnSortie.Text = "Miantenant";
            this.btnSortie.UseVisualStyleBackColor = true;
            this.btnSortie.Click += new System.EventHandler(this.btnSortie_Click);
            // 
            // txtEntree
            // 
            this.txtEntree.Location = new System.Drawing.Point(40, 251);
            this.txtEntree.Name = "txtEntree";
            this.txtEntree.Size = new System.Drawing.Size(100, 26);
            this.txtEntree.TabIndex = 11;
            // 
            // txtSortie
            // 
            this.txtSortie.Location = new System.Drawing.Point(372, 251);
            this.txtSortie.Name = "txtSortie";
            this.txtSortie.Size = new System.Drawing.Size(100, 26);
            this.txtSortie.TabIndex = 12;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(212, 298);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(111, 33);
            this.btnCalculer.TabIndex = 13;
            this.btnCalculer.Text = "Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // lblResultat
            // 
            this.lblResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultat.Location = new System.Drawing.Point(12, 334);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(608, 73);
            this.lblResultat.TabIndex = 14;
            // 
            // frmTimesheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtSortie);
            this.Controls.Add(this.txtEntree);
            this.Controls.Add(this.btnSortie);
            this.Controls.Add(this.btnEntree);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTimesheet";
            this.Text = "frmTimesheet";
            this.Load += new System.EventHandler(this.frmTimesheet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEntree;
        private System.Windows.Forms.Button btnSortie;
        private System.Windows.Forms.TextBox txtEntree;
        private System.Windows.Forms.TextBox txtSortie;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Label lblResultat;
    }
}