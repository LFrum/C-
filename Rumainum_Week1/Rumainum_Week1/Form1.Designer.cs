namespace Rumainum_Week1
{
    partial class frmDailyWorkDrivingCost
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
            this.txtTotalMiles = new System.Windows.Forms.TextBox();
            this.txtCostPerGallon = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAverageMPG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtParkingFees = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTolls = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtTotalWorkDailyCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total miles driven per day";
            // 
            // txtTotalMiles
            // 
            this.txtTotalMiles.Location = new System.Drawing.Point(277, 24);
            this.txtTotalMiles.Name = "txtTotalMiles";
            this.txtTotalMiles.Size = new System.Drawing.Size(100, 22);
            this.txtTotalMiles.TabIndex = 0;
            // 
            // txtCostPerGallon
            // 
            this.txtCostPerGallon.Location = new System.Drawing.Point(277, 74);
            this.txtCostPerGallon.Name = "txtCostPerGallon";
            this.txtCostPerGallon.Size = new System.Drawing.Size(100, 22);
            this.txtCostPerGallon.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cost per gallon of gasoline (in cents)";
            // 
            // txtAverageMPG
            // 
            this.txtAverageMPG.Location = new System.Drawing.Point(277, 124);
            this.txtAverageMPG.Name = "txtAverageMPG";
            this.txtAverageMPG.Size = new System.Drawing.Size(100, 22);
            this.txtAverageMPG.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average miles per gallon";
            // 
            // txtParkingFees
            // 
            this.txtParkingFees.Location = new System.Drawing.Point(277, 174);
            this.txtParkingFees.Name = "txtParkingFees";
            this.txtParkingFees.Size = new System.Drawing.Size(100, 22);
            this.txtParkingFees.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Parking fees per day (in cents)";
            // 
            // txtTolls
            // 
            this.txtTolls.Location = new System.Drawing.Point(277, 224);
            this.txtTolls.Name = "txtTolls";
            this.txtTolls.Size = new System.Drawing.Size(100, 22);
            this.txtTolls.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tolls per day (in cents)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "User\'s cost per day of driving to work: ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(84, 337);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(102, 33);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(237, 337);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtTotalWorkDailyCost
            // 
            this.txtTotalWorkDailyCost.Location = new System.Drawing.Point(277, 284);
            this.txtTotalWorkDailyCost.Name = "txtTotalWorkDailyCost";
            this.txtTotalWorkDailyCost.ReadOnly = true;
            this.txtTotalWorkDailyCost.Size = new System.Drawing.Size(100, 22);
            this.txtTotalWorkDailyCost.TabIndex = 7;
            // 
            // frmDailyWorkDrivingCost
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(418, 392);
            this.Controls.Add(this.txtTotalWorkDailyCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTolls);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtParkingFees);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAverageMPG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCostPerGallon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalMiles);
            this.Controls.Add(this.label1);
            this.Name = "frmDailyWorkDrivingCost";
            this.Text = "Daily Work Driving Cost";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalMiles;
        private System.Windows.Forms.TextBox txtCostPerGallon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAverageMPG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtParkingFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTolls;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtTotalWorkDailyCost;
    }
}

