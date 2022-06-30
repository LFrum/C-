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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarpetingCosts = new System.Windows.Forms.Button();
            this.btnHardwoodCosts = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "A to Z Flooring";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flooring Calculator";
            // 
            // btnCarpetingCosts
            // 
            this.btnCarpetingCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarpetingCosts.Location = new System.Drawing.Point(25, 109);
            this.btnCarpetingCosts.Name = "btnCarpetingCosts";
            this.btnCarpetingCosts.Size = new System.Drawing.Size(309, 45);
            this.btnCarpetingCosts.TabIndex = 2;
            this.btnCarpetingCosts.Text = "Calculate Carpeting Costs";
            this.btnCarpetingCosts.UseVisualStyleBackColor = true;
            this.btnCarpetingCosts.Click += new System.EventHandler(this.btnCarpetingCosts_Click);
            // 
            // btnHardwoodCosts
            // 
            this.btnHardwoodCosts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardwoodCosts.Location = new System.Drawing.Point(25, 167);
            this.btnHardwoodCosts.Name = "btnHardwoodCosts";
            this.btnHardwoodCosts.Size = new System.Drawing.Size(309, 45);
            this.btnHardwoodCosts.TabIndex = 3;
            this.btnHardwoodCosts.Text = "Calculate Hardwood Costs";
            this.btnHardwoodCosts.UseVisualStyleBackColor = true;
            this.btnHardwoodCosts.Click += new System.EventHandler(this.btnHardwoodCosts_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(25, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(309, 45);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 379);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHardwoodCosts);
            this.Controls.Add(this.btnCarpetingCosts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "Flooring Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarpetingCosts;
        private System.Windows.Forms.Button btnHardwoodCosts;
        private System.Windows.Forms.Button btnExit;
    }
}