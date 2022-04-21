namespace prjWinCsCoursCompletPOO
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chapitresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuConditions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepetitions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFonctions = new System.Windows.Forms.ToolStripMenuItem();
            this.projetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVideo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimesheet = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chapitresToolStripMenuItem,
            this.projetsToolStripMenuItem,
            this.mnuQuitter});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // chapitresToolStripMenuItem
            // 
            this.chapitresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConditions,
            this.mnuRepetitions,
            this.mnuFonctions});
            this.chapitresToolStripMenuItem.Name = "chapitresToolStripMenuItem";
            this.chapitresToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.chapitresToolStripMenuItem.Text = "Chapitres";
            // 
            // mnuConditions
            // 
            this.mnuConditions.Name = "mnuConditions";
            this.mnuConditions.Size = new System.Drawing.Size(270, 34);
            this.mnuConditions.Text = "Conditions";
            this.mnuConditions.Click += new System.EventHandler(this.mnuConditions_Click);
            // 
            // mnuRepetitions
            // 
            this.mnuRepetitions.Name = "mnuRepetitions";
            this.mnuRepetitions.Size = new System.Drawing.Size(270, 34);
            this.mnuRepetitions.Text = "Repetions";
            this.mnuRepetitions.Click += new System.EventHandler(this.mnuRepetitions_Click);
            // 
            // mnuFonctions
            // 
            this.mnuFonctions.Name = "mnuFonctions";
            this.mnuFonctions.Size = new System.Drawing.Size(270, 34);
            this.mnuFonctions.Text = "Fonctions";
            this.mnuFonctions.Click += new System.EventHandler(this.mnuFonctions_Click);
            // 
            // projetsToolStripMenuItem
            // 
            this.projetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVideo,
            this.mnuTimesheet});
            this.projetsToolStripMenuItem.Name = "projetsToolStripMenuItem";
            this.projetsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.projetsToolStripMenuItem.Text = "Projets";
            // 
            // mnuVideo
            // 
            this.mnuVideo.Name = "mnuVideo";
            this.mnuVideo.Size = new System.Drawing.Size(270, 34);
            this.mnuVideo.Text = "Videotheques";
            this.mnuVideo.Click += new System.EventHandler(this.mnuVideo_Click);
            // 
            // mnuTimesheet
            // 
            this.mnuTimesheet.Name = "mnuTimesheet";
            this.mnuTimesheet.Size = new System.Drawing.Size(270, 34);
            this.mnuTimesheet.Text = "Timesheet";
            this.mnuTimesheet.Click += new System.EventHandler(this.mnuTimesheet_Click);
            // 
            // mnuQuitter
            // 
            this.mnuQuitter.Name = "mnuQuitter";
            this.mnuQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.mnuQuitter.Size = new System.Drawing.Size(270, 34);
            this.mnuQuitter.Text = "Qitter";
            this.mnuQuitter.Click += new System.EventHandler(this.mnuQuitter_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chapitresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuConditions;
        private System.Windows.Forms.ToolStripMenuItem mnuRepetitions;
        private System.Windows.Forms.ToolStripMenuItem mnuFonctions;
        private System.Windows.Forms.ToolStripMenuItem projetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVideo;
        private System.Windows.Forms.ToolStripMenuItem mnuTimesheet;
        private System.Windows.Forms.ToolStripMenuItem mnuQuitter;
    }
}