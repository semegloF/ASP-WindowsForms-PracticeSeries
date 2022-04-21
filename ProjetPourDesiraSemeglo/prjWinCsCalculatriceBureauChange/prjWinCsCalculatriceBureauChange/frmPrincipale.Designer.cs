namespace prjWinCsCalculatriceBureauChange
{
    partial class frmPrincipale
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipale));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatricesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStandard = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuScientifique = new System.Windows.Forms.ToolStripMenuItem();
            this.bureauDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripStandard = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripScientifique = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripChange1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripChange2 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmeToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmeToolStripMenuItem
            // 
            this.programmeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatricesToolStripMenuItem,
            this.bureauDeToolStripMenuItem,
            this.mnuQuitter});
            this.programmeToolStripMenuItem.Name = "programmeToolStripMenuItem";
            this.programmeToolStripMenuItem.Size = new System.Drawing.Size(130, 29);
            this.programmeToolStripMenuItem.Text = "Programmes";
            // 
            // calculatricesToolStripMenuItem
            // 
            this.calculatricesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStandard,
            this.mnuScientifique});
            this.calculatricesToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.calculatricesToolStripMenuItem.Name = "calculatricesToolStripMenuItem";
            this.calculatricesToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.calculatricesToolStripMenuItem.Text = "Calculatrices";
            // 
            // mnuStandard
            // 
            this.mnuStandard.Name = "mnuStandard";
            this.mnuStandard.Size = new System.Drawing.Size(268, 34);
            this.mnuStandard.Text = "Version Standard";
            this.mnuStandard.Click += new System.EventHandler(this.mnuStandard_Click);
            // 
            // mnuScientifique
            // 
            this.mnuScientifique.Name = "mnuScientifique";
            this.mnuScientifique.Size = new System.Drawing.Size(268, 34);
            this.mnuScientifique.Text = "Version Scientifique";
            this.mnuScientifique.Click += new System.EventHandler(this.mnuScientifique_Click);
            // 
            // bureauDeToolStripMenuItem
            // 
            this.bureauDeToolStripMenuItem.Enabled = false;
            this.bureauDeToolStripMenuItem.Name = "bureauDeToolStripMenuItem";
            this.bureauDeToolStripMenuItem.Size = new System.Drawing.Size(330, 34);
            this.bureauDeToolStripMenuItem.Text = "Bureaux Change";
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuQuitter.Size = new System.Drawing.Size(330, 34);
            this.mnuQuitter.Text = "Quitter Programme";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStandard,
            this.toolStripSeparator1,
            this.toolStripScientifique,
            this.toolStripSeparator2,
            this.toolStripChange1,
            this.toolStripSeparator3,
            this.toolStripChange2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 33);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripStandard
            // 
            this.toolStripStandard.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripStandard.BackgroundImage")));
            this.toolStripStandard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripStandard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStandard.Image")));
            this.toolStripStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStandard.Name = "toolStripStandard";
            this.toolStripStandard.Size = new System.Drawing.Size(34, 28);
            this.toolStripStandard.Text = "toolStripButton1";
            this.toolStripStandard.Click += new System.EventHandler(this.toolStripStandard_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripScientifique
            // 
            this.toolStripScientifique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripScientifique.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripScientifique.Image = ((System.Drawing.Image)(resources.GetObject("toolStripScientifique.Image")));
            this.toolStripScientifique.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripScientifique.Name = "toolStripScientifique";
            this.toolStripScientifique.Size = new System.Drawing.Size(34, 28);
            this.toolStripScientifique.Text = "toolStripButton2";
            this.toolStripScientifique.Click += new System.EventHandler(this.toolStripScientifique_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripChange1
            // 
            this.toolStripChange1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripChange1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChange1.Image")));
            this.toolStripChange1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChange1.Name = "toolStripChange1";
            this.toolStripChange1.Size = new System.Drawing.Size(34, 28);
            this.toolStripChange1.Text = "toolStripButton3";
            this.toolStripChange1.Click += new System.EventHandler(this.toolStripChange1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripChange2
            // 
            this.toolStripChange2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripChange2.BackgroundImage")));
            this.toolStripChange2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripChange2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChange2.Image")));
            this.toolStripChange2.ImageTransparentColor = System.Drawing.Color.FloralWhite;
            this.toolStripChange2.Name = "toolStripChange2";
            this.toolStripChange2.Size = new System.Drawing.Size(34, 28);
            this.toolStripChange2.Text = "toolStripButton4";
            this.toolStripChange2.Click += new System.EventHandler(this.toolStripChange2_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 418);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 32);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "Status";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(60, 25);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // frmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipale";
            this.Text = "College Institut Teccart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatricesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStandard;
        private System.Windows.Forms.ToolStripMenuItem mnuScientifique;
        private System.Windows.Forms.ToolStripMenuItem bureauDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripStandard;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripScientifique;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripChange1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripChange2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}