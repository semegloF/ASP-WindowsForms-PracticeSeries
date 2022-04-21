namespace prjWinCsCoursCompletPOO
{
    partial class frmCondition
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResultatNum = new System.Windows.Forms.Label();
            this.btnValiderNum = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNoteNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblResultatAlpha = new System.Windows.Forms.Label();
            this.btnValiderAlpha = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNoteAlpha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(248, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "INSTITUT-TECCART";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Non étudiant : ";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNom.Location = new System.Drawing.Point(201, 59);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 28);
            this.txtNom.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblResultatNum);
            this.groupBox1.Controls.Add(this.btnValiderNum);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNoteNum);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 156);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numerique a Alphabetique";
            // 
            // lblResultatNum
            // 
            this.lblResultatNum.Location = new System.Drawing.Point(17, 73);
            this.lblResultatNum.Name = "lblResultatNum";
            this.lblResultatNum.Size = new System.Drawing.Size(395, 64);
            this.lblResultatNum.TabIndex = 6;
            // 
            // btnValiderNum
            // 
            this.btnValiderNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValiderNum.Location = new System.Drawing.Point(306, 30);
            this.btnValiderNum.Name = "btnValiderNum";
            this.btnValiderNum.Size = new System.Drawing.Size(106, 40);
            this.btnValiderNum.TabIndex = 5;
            this.btnValiderNum.Text = "Valider";
            this.btnValiderNum.UseVisualStyleBackColor = false;
            this.btnValiderNum.Click += new System.EventHandler(this.btnValiderNum_Click);
            this.btnValiderNum.MouseHover += new System.EventHandler(this.btnValiderNum_MouseHover);
            this.btnValiderNum.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnValiderNum_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "/ 100";
            // 
            // txtNoteNum
            // 
            this.txtNoteNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNoteNum.Location = new System.Drawing.Point(87, 30);
            this.txtNoteNum.Name = "txtNoteNum";
            this.txtNoteNum.Size = new System.Drawing.Size(100, 28);
            this.txtNoteNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Note : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblResultatAlpha);
            this.groupBox2.Controls.Add(this.btnValiderAlpha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtNoteAlpha);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(16, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alphabetique a Numerique";
            // 
            // lblResultatAlpha
            // 
            this.lblResultatAlpha.Location = new System.Drawing.Point(6, 77);
            this.lblResultatAlpha.Name = "lblResultatAlpha";
            this.lblResultatAlpha.Size = new System.Drawing.Size(395, 64);
            this.lblResultatAlpha.TabIndex = 6;
            // 
            // btnValiderAlpha
            // 
            this.btnValiderAlpha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnValiderAlpha.Location = new System.Drawing.Point(306, 30);
            this.btnValiderAlpha.Name = "btnValiderAlpha";
            this.btnValiderAlpha.Size = new System.Drawing.Size(106, 44);
            this.btnValiderAlpha.TabIndex = 5;
            this.btnValiderAlpha.Text = "Valider";
            this.btnValiderAlpha.UseVisualStyleBackColor = false;
            this.btnValiderAlpha.Click += new System.EventHandler(this.btnValiderAlpha_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(193, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "A--E";
            // 
            // txtNoteAlpha
            // 
            this.txtNoteAlpha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtNoteAlpha.Location = new System.Drawing.Point(87, 30);
            this.txtNoteAlpha.Name = "txtNoteAlpha";
            this.txtNoteAlpha.Size = new System.Drawing.Size(100, 28);
            this.txtNoteAlpha.TabIndex = 4;
            this.txtNoteAlpha.TextChanged += new System.EventHandler(this.txtNoteAlpha_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note : ";
            // 
            // btnEffacer
            // 
            this.btnEffacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEffacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(26, 481);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(107, 41);
            this.btnEffacer.TabIndex = 6;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = false;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFermer.Location = new System.Drawing.Point(253, 481);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(118, 41);
            this.btnFermer.TabIndex = 7;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = false;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmCondition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 607);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCondition";
            this.Text = "frmCondition";
            this.Load += new System.EventHandler(this.frmCondition_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblResultatNum;
        private System.Windows.Forms.Button btnValiderNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoteNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblResultatAlpha;
        private System.Windows.Forms.Button btnValiderAlpha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNoteAlpha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnFermer;
    }
}