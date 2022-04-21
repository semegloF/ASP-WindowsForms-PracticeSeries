namespace prjWinCsLibClassGAB
{
    partial class frmExamen
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
            this.checkProf = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkProf
            // 
            this.checkProf.FormattingEnabled = true;
            this.checkProf.Location = new System.Drawing.Point(0, 0);
            this.checkProf.Name = "checkProf";
            this.checkProf.Size = new System.Drawing.Size(120, 96);
            this.checkProf.TabIndex = 0;
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkProf);
            this.Name = "frmExamen";
            this.Text = "frmExamen";
            this.Load += new System.EventHandler(this.frmExamen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkProf;
    }
}