namespace Rumainum_Week4
{
    partial class frmBankAccount
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInitialBalance = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.grpBankAccount = new System.Windows.Forms.GroupBox();
            this.txtInterestRateOrFee = new System.Windows.Forms.TextBox();
            this.lblInterestRateOrFee = new System.Windows.Forms.Label();
            this.rdoSavingsAccount = new System.Windows.Forms.RadioButton();
            this.rdoCheckingAccount = new System.Windows.Forms.RadioButton();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtDebit = new System.Windows.Forms.TextBox();
            this.lblDebit = new System.Windows.Forms.Label();
            this.grpTransactions = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotalInterestOrFee = new System.Windows.Forms.Label();
            this.txtTotalInterestOrFee = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBankAccount.SuspendLayout();
            this.grpTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(338, 114);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(132, 33);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(338, 176);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(132, 33);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(338, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 33);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInitialBalance
            // 
            this.lblInitialBalance.Location = new System.Drawing.Point(20, 74);
            this.lblInitialBalance.Name = "lblInitialBalance";
            this.lblInitialBalance.Size = new System.Drawing.Size(132, 19);
            this.lblInitialBalance.TabIndex = 13;
            this.lblInitialBalance.Text = "Initial Balance :";
            this.lblInitialBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Location = new System.Drawing.Point(158, 72);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(100, 22);
            this.txtInitialBalance.TabIndex = 2;
            this.txtInitialBalance.TextChanged += new System.EventHandler(this.txtInitialBalance_TextChanged);
            // 
            // grpBankAccount
            // 
            this.grpBankAccount.Controls.Add(this.txtInterestRateOrFee);
            this.grpBankAccount.Controls.Add(this.lblInterestRateOrFee);
            this.grpBankAccount.Controls.Add(this.rdoSavingsAccount);
            this.grpBankAccount.Controls.Add(this.txtInitialBalance);
            this.grpBankAccount.Controls.Add(this.rdoCheckingAccount);
            this.grpBankAccount.Controls.Add(this.lblInitialBalance);
            this.grpBankAccount.Location = new System.Drawing.Point(12, 12);
            this.grpBankAccount.Name = "grpBankAccount";
            this.grpBankAccount.Size = new System.Drawing.Size(318, 135);
            this.grpBankAccount.TabIndex = 9;
            this.grpBankAccount.TabStop = false;
            this.grpBankAccount.Text = "Bank Account";
            // 
            // txtInterestRateOrFee
            // 
            this.txtInterestRateOrFee.Location = new System.Drawing.Point(158, 102);
            this.txtInterestRateOrFee.Name = "txtInterestRateOrFee";
            this.txtInterestRateOrFee.Size = new System.Drawing.Size(100, 22);
            this.txtInterestRateOrFee.TabIndex = 3;
            this.txtInterestRateOrFee.TextChanged += new System.EventHandler(this.txtInterestRateOrFee_TextChanged);
            // 
            // lblInterestRateOrFee
            // 
            this.lblInterestRateOrFee.Location = new System.Drawing.Point(20, 104);
            this.lblInterestRateOrFee.Name = "lblInterestRateOrFee";
            this.lblInterestRateOrFee.Size = new System.Drawing.Size(132, 19);
            this.lblInterestRateOrFee.TabIndex = 14;
            this.lblInterestRateOrFee.Text = "Interest Rate : ";
            this.lblInterestRateOrFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rdoSavingsAccount
            // 
            this.rdoSavingsAccount.AutoSize = true;
            this.rdoSavingsAccount.Location = new System.Drawing.Point(19, 35);
            this.rdoSavingsAccount.Name = "rdoSavingsAccount";
            this.rdoSavingsAccount.Size = new System.Drawing.Size(127, 21);
            this.rdoSavingsAccount.TabIndex = 0;
            this.rdoSavingsAccount.TabStop = true;
            this.rdoSavingsAccount.Text = "Saving Account";
            this.rdoSavingsAccount.UseVisualStyleBackColor = true;
            this.rdoSavingsAccount.CheckedChanged += new System.EventHandler(this.rdoSavingsAccount_CheckedChanged);
            // 
            // rdoCheckingAccount
            // 
            this.rdoCheckingAccount.AutoSize = true;
            this.rdoCheckingAccount.Location = new System.Drawing.Point(162, 35);
            this.rdoCheckingAccount.Name = "rdoCheckingAccount";
            this.rdoCheckingAccount.Size = new System.Drawing.Size(142, 21);
            this.rdoCheckingAccount.TabIndex = 1;
            this.rdoCheckingAccount.TabStop = true;
            this.rdoCheckingAccount.Text = "Checking Account";
            this.rdoCheckingAccount.UseVisualStyleBackColor = true;
            this.rdoCheckingAccount.CheckedChanged += new System.EventHandler(this.rdoCheckingAccount_CheckedChanged);
            // 
            // txtCredit
            // 
            this.txtCredit.Location = new System.Drawing.Point(158, 23);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(100, 22);
            this.txtCredit.TabIndex = 4;
            this.txtCredit.TextChanged += new System.EventHandler(this.txtCredit_TextChanged);
            // 
            // lblCredit
            // 
            this.lblCredit.Location = new System.Drawing.Point(20, 25);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(132, 19);
            this.lblCredit.TabIndex = 15;
            this.lblCredit.Text = "Credit :";
            this.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDebit
            // 
            this.txtDebit.Location = new System.Drawing.Point(158, 49);
            this.txtDebit.Name = "txtDebit";
            this.txtDebit.Size = new System.Drawing.Size(100, 22);
            this.txtDebit.TabIndex = 5;
            this.txtDebit.TextChanged += new System.EventHandler(this.txtDebit_TextChanged);
            // 
            // lblDebit
            // 
            this.lblDebit.Location = new System.Drawing.Point(20, 51);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(132, 19);
            this.lblDebit.TabIndex = 16;
            this.lblDebit.Text = "Debit :";
            this.lblDebit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpTransactions
            // 
            this.grpTransactions.Controls.Add(this.lblCredit);
            this.grpTransactions.Controls.Add(this.txtDebit);
            this.grpTransactions.Controls.Add(this.txtCredit);
            this.grpTransactions.Controls.Add(this.lblDebit);
            this.grpTransactions.Location = new System.Drawing.Point(12, 166);
            this.grpTransactions.Name = "grpTransactions";
            this.grpTransactions.Size = new System.Drawing.Size(318, 82);
            this.grpTransactions.TabIndex = 10;
            this.grpTransactions.TabStop = false;
            this.grpTransactions.Text = "Transaction";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 18;
            this.label5.Text = "Current Balance :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(170, 291);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.ReadOnly = true;
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentBalance.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtCurrentBalance, "Initial Balance + Credit - Debit will be calculated first\r\nbefore adding interest" +
        " rate or subtracting fee");
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(32, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 19);
            this.label6.TabIndex = 18;
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalInterestOrFee
            // 
            this.lblTotalInterestOrFee.Location = new System.Drawing.Point(32, 266);
            this.lblTotalInterestOrFee.Name = "lblTotalInterestOrFee";
            this.lblTotalInterestOrFee.Size = new System.Drawing.Size(132, 19);
            this.lblTotalInterestOrFee.TabIndex = 17;
            this.lblTotalInterestOrFee.Text = "Total Interest :";
            this.lblTotalInterestOrFee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTotalInterestOrFee
            // 
            this.txtTotalInterestOrFee.Location = new System.Drawing.Point(170, 263);
            this.txtTotalInterestOrFee.Name = "txtTotalInterestOrFee";
            this.txtTotalInterestOrFee.ReadOnly = true;
            this.txtTotalInterestOrFee.Size = new System.Drawing.Size(100, 22);
            this.txtTotalInterestOrFee.TabIndex = 11;
            // 
            // frmBankAccount
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(478, 325);
            this.Controls.Add(this.lblTotalInterestOrFee);
            this.Controls.Add(this.txtTotalInterestOrFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grpTransactions);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.grpBankAccount);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "frmBankAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank Account";
            this.Load += new System.EventHandler(this.frmBankAccount_Load);
            this.grpBankAccount.ResumeLayout(false);
            this.grpBankAccount.PerformLayout();
            this.grpTransactions.ResumeLayout(false);
            this.grpTransactions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.GroupBox grpBankAccount;
        private System.Windows.Forms.TextBox txtInterestRateOrFee;
        private System.Windows.Forms.Label lblInterestRateOrFee;
        private System.Windows.Forms.RadioButton rdoSavingsAccount;
        private System.Windows.Forms.RadioButton rdoCheckingAccount;
        private System.Windows.Forms.TextBox txtCredit;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.TextBox txtDebit;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.GroupBox grpTransactions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTotalInterestOrFee;
        private System.Windows.Forms.TextBox txtTotalInterestOrFee;
        private System.Windows.Forms.Label lblInitialBalance;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

