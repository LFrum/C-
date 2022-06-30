namespace CalculateFlooringCosts
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewCarpetingCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNewHardwoodCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsCascadedLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsHorizontalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindowsVerticalLayout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCarpetingCosts = new System.Windows.Forms.ToolStripButton();
            this.btnHardwoodCosts = new System.Windows.Forms.ToolStripButton();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuWindows});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuWindows;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNewCarpetingCosts,
            this.mnuFileNewHardwoodCosts,
            this.mnuFileClose,
            this.toolStripSeparator1,
            this.mnuFileExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(44, 24);
            this.mnuFile.Text = "&File";
            // 
            // mnuFileNewCarpetingCosts
            // 
            this.mnuFileNewCarpetingCosts.Name = "mnuFileNewCarpetingCosts";
            this.mnuFileNewCarpetingCosts.Size = new System.Drawing.Size(228, 26);
            this.mnuFileNewCarpetingCosts.Text = "New &Carpeting Costs";
            this.mnuFileNewCarpetingCosts.Click += new System.EventHandler(this.mnuFileCarpetingCosts_Click);
            // 
            // mnuFileNewHardwoodCosts
            // 
            this.mnuFileNewHardwoodCosts.Name = "mnuFileNewHardwoodCosts";
            this.mnuFileNewHardwoodCosts.Size = new System.Drawing.Size(228, 26);
            this.mnuFileNewHardwoodCosts.Text = "New &Hardwood Costs";
            this.mnuFileNewHardwoodCosts.Click += new System.EventHandler(this.mnuFileHardwoodCosts_Click);
            // 
            // mnuFileClose
            // 
            this.mnuFileClose.Name = "mnuFileClose";
            this.mnuFileClose.Size = new System.Drawing.Size(228, 26);
            this.mnuFileClose.Text = "Cl&ose";
            this.mnuFileClose.Click += new System.EventHandler(this.mnuFileClose_Click);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(228, 26);
            this.mnuFileExit.Text = "E&xit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(225, 6);
            // 
            // mnuWindows
            // 
            this.mnuWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuWindowsCascadedLayout,
            this.mnuWindowsHorizontalLayout,
            this.mnuWindowsVerticalLayout});
            this.mnuWindows.Name = "mnuWindows";
            this.mnuWindows.Size = new System.Drawing.Size(82, 24);
            this.mnuWindows.Text = "&Windows";
            // 
            // mnuWindowsCascadedLayout
            // 
            this.mnuWindowsCascadedLayout.Name = "mnuWindowsCascadedLayout";
            this.mnuWindowsCascadedLayout.Size = new System.Drawing.Size(202, 26);
            this.mnuWindowsCascadedLayout.Text = "Ca&scaded Layout";
            this.mnuWindowsCascadedLayout.Click += new System.EventHandler(this.cascadeWindowToolStripMenuItem_Click);
            // 
            // mnuWindowsHorizontalLayout
            // 
            this.mnuWindowsHorizontalLayout.Name = "mnuWindowsHorizontalLayout";
            this.mnuWindowsHorizontalLayout.Size = new System.Drawing.Size(202, 26);
            this.mnuWindowsHorizontalLayout.Text = "Hori&zontal Layout";
            this.mnuWindowsHorizontalLayout.Click += new System.EventHandler(this.horizontalWindowToolStripMenuItem_Click);
            // 
            // mnuWindowsVerticalLayout
            // 
            this.mnuWindowsVerticalLayout.Name = "mnuWindowsVerticalLayout";
            this.mnuWindowsVerticalLayout.Size = new System.Drawing.Size(202, 26);
            this.mnuWindowsVerticalLayout.Text = "&Vertical Layout";
            this.mnuWindowsVerticalLayout.Click += new System.EventHandler(this.verticalWindowToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCarpetingCosts,
            this.btnHardwoodCosts});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(900, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCarpetingCosts
            // 
            this.btnCarpetingCosts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnCarpetingCosts.Image = ((System.Drawing.Image)(resources.GetObject("btnCarpetingCosts.Image")));
            this.btnCarpetingCosts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCarpetingCosts.Name = "btnCarpetingCosts";
            this.btnCarpetingCosts.Size = new System.Drawing.Size(117, 24);
            this.btnCarpetingCosts.Text = "&Carpeting Costs";
            this.btnCarpetingCosts.Click += new System.EventHandler(this.btnCarpetingCosts_Click);
            // 
            // btnHardwoodCosts
            // 
            this.btnHardwoodCosts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHardwoodCosts.Image = ((System.Drawing.Image)(resources.GetObject("btnHardwoodCosts.Image")));
            this.btnHardwoodCosts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHardwoodCosts.Name = "btnHardwoodCosts";
            this.btnHardwoodCosts.Size = new System.Drawing.Size(123, 24);
            this.btnHardwoodCosts.Text = "&Hardwood Costs";
            this.btnHardwoodCosts.Click += new System.EventHandler(this.btnHardwoodCosts_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 515);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.helpProvider1.SetHelpString(this, "This form will show windows for new carpeting costs application(s) and/or new har" +
        "dwood costs application(s).");
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flooring Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewCarpetingCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNewHardwoodCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuFileClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.ToolStripMenuItem mnuWindows;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowsCascadedLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowsHorizontalLayout;
        private System.Windows.Forms.ToolStripMenuItem mnuWindowsVerticalLayout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCarpetingCosts;
        private System.Windows.Forms.ToolStripButton btnHardwoodCosts;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}