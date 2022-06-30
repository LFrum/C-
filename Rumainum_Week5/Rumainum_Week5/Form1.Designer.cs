namespace Rumainum_Week5
{
    partial class frmCloneCustomer
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
            this.lblCustomerList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCopyNum = new System.Windows.Forms.TextBox();
            this.lstCloneCustomers = new System.Windows.Forms.ListBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerList
            // 
            this.lblCustomerList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerList.Location = new System.Drawing.Point(28, 19);
            this.lblCustomerList.Name = "lblCustomerList";
            this.lblCustomerList.Size = new System.Drawing.Size(420, 93);
            this.lblCustomerList.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(25, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copies:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCopyNum
            // 
            this.txtCopyNum.Location = new System.Drawing.Point(131, 136);
            this.txtCopyNum.Name = "txtCopyNum";
            this.txtCopyNum.Size = new System.Drawing.Size(88, 22);
            this.txtCopyNum.TabIndex = 2;
            this.txtCopyNum.TextChanged += new System.EventHandler(this.txtCopyNum_TextChanged);
            // 
            // lstCloneCustomers
            // 
            this.lstCloneCustomers.FormattingEnabled = true;
            this.lstCloneCustomers.ItemHeight = 16;
            this.lstCloneCustomers.Location = new System.Drawing.Point(28, 173);
            this.lstCloneCustomers.Name = "lstCloneCustomers";
            this.lstCloneCustomers.Size = new System.Drawing.Size(419, 148);
            this.lstCloneCustomers.TabIndex = 3;
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(245, 132);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(125, 30);
            this.btnClone.TabIndex = 4;
            this.btnClone.Text = "&Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(466, 291);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCloneCustomer
            // 
            this.AcceptButton = this.btnClone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(607, 338);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.lstCloneCustomers);
            this.Controls.Add(this.txtCopyNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCustomerList);
            this.Name = "frmCloneCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone Customer";
            this.Load += new System.EventHandler(this.frmCloneCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCopyNum;
        private System.Windows.Forms.ListBox lstCloneCustomers;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.Button btnExit;
    }
}

