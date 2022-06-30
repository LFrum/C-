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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewCarpetingCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNewHardwoodCosts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnCarpeting = new System.Windows.Forms.Button();
            this.btnHardwood = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNewCarpetingCosts,
            this.mnuNewHardwoodCosts,
            this.mnuClose,
            this.mnuExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuNewCarpetingCosts
            // 
            this.mnuNewCarpetingCosts.Name = "mnuNewCarpetingCosts";
            this.mnuNewCarpetingCosts.Size = new System.Drawing.Size(228, 26);
            this.mnuNewCarpetingCosts.Text = "New Carpeting Costs";
            this.mnuNewCarpetingCosts.Click += new System.EventHandler(this.newCarpetingCostToolStripMenuItem_Click);
            // 
            // mnuNewHardwoodCosts
            // 
            this.mnuNewHardwoodCosts.Name = "mnuNewHardwoodCosts";
            this.mnuNewHardwoodCosts.Size = new System.Drawing.Size(228, 26);
            this.mnuNewHardwoodCosts.Text = "New Hardwood Costs";
            this.mnuNewHardwoodCosts.Click += new System.EventHandler(this.newHardwoodCostsToolStripMenuItem_Click);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(228, 26);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(228, 26);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuTileVertical,
            this.mnuTileHorizontal});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(182, 26);
            this.mnuCascade.Text = "Cascade";
            this.mnuCascade.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // mnuTileVertical
            // 
            this.mnuTileVertical.Name = "mnuTileVertical";
            this.mnuTileVertical.Size = new System.Drawing.Size(182, 26);
            this.mnuTileVertical.Text = "Tile Vertical";
            this.mnuTileVertical.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // mnuTileHorizontal
            // 
            this.mnuTileHorizontal.Name = "mnuTileHorizontal";
            this.mnuTileHorizontal.Size = new System.Drawing.Size(182, 26);
            this.mnuTileHorizontal.Text = "Tile Horizontal";
            this.mnuTileHorizontal.Click += new System.EventHandler(this.tileHorizontalToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnCarpeting
            // 
            this.btnCarpeting.Location = new System.Drawing.Point(0, 31);
            this.btnCarpeting.Name = "btnCarpeting";
            this.btnCarpeting.Size = new System.Drawing.Size(170, 35);
            this.btnCarpeting.TabIndex = 2;
            this.btnCarpeting.Text = "New Carpeting Costs";
            this.btnCarpeting.UseVisualStyleBackColor = true;
            this.btnCarpeting.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHardwood
            // 
            this.btnHardwood.Location = new System.Drawing.Point(176, 31);
            this.btnHardwood.Name = "btnHardwood";
            this.btnHardwood.Size = new System.Drawing.Size(170, 35);
            this.btnHardwood.TabIndex = 3;
            this.btnHardwood.Text = "New Hardwood Costs";
            this.btnHardwood.UseVisualStyleBackColor = true;
            this.btnHardwood.Click += new System.EventHandler(this.btnHardwood_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 508);
            this.Controls.Add(this.btnHardwood);
            this.Controls.Add(this.btnCarpeting);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Floor Calculation Form";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuNewCarpetingCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuNewHardwoodCosts;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.Button btnCarpeting;
        private System.Windows.Forms.Button btnHardwood;
    }
}