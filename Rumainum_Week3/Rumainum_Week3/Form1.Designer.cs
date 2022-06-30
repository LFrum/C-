namespace Rumainum_Week3
{
    partial class frmLunchOrder
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
            this.grpMainCourse = new System.Windows.Forms.GroupBox();
            this.rdoSalad = new System.Windows.Forms.RadioButton();
            this.rdoPizza = new System.Windows.Forms.RadioButton();
            this.rdoHamburger = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpAddOn = new System.Windows.Forms.GroupBox();
            this.chkFrenchFriesOlivesBreadSticks = new System.Windows.Forms.CheckBox();
            this.chkKetchupSausageBaconBits = new System.Windows.Forms.CheckBox();
            this.chkLettucePepperoniCroutons = new System.Windows.Forms.CheckBox();
            this.grpOrderTotal = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTaxTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpMainCourse.SuspendLayout();
            this.grpAddOn.SuspendLayout();
            this.grpOrderTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpMainCourse
            // 
            this.grpMainCourse.Controls.Add(this.rdoSalad);
            this.grpMainCourse.Controls.Add(this.rdoPizza);
            this.grpMainCourse.Controls.Add(this.rdoHamburger);
            this.grpMainCourse.Location = new System.Drawing.Point(17, 27);
            this.grpMainCourse.Name = "grpMainCourse";
            this.grpMainCourse.Size = new System.Drawing.Size(162, 100);
            this.grpMainCourse.TabIndex = 2;
            this.grpMainCourse.TabStop = false;
            this.grpMainCourse.Text = "Main course";
            // 
            // rdoSalad
            // 
            this.rdoSalad.AutoSize = true;
            this.rdoSalad.Location = new System.Drawing.Point(6, 73);
            this.rdoSalad.Name = "rdoSalad";
            this.rdoSalad.Size = new System.Drawing.Size(114, 21);
            this.rdoSalad.TabIndex = 5;
            this.rdoSalad.TabStop = true;
            this.rdoSalad.Text = "Salad - $4.95";
            this.rdoSalad.UseVisualStyleBackColor = true;
            this.rdoSalad.CheckedChanged += new System.EventHandler(this.rdoSalad_CheckedChanged);
            // 
            // rdoPizza
            // 
            this.rdoPizza.AutoSize = true;
            this.rdoPizza.Location = new System.Drawing.Point(6, 48);
            this.rdoPizza.Name = "rdoPizza";
            this.rdoPizza.Size = new System.Drawing.Size(112, 21);
            this.rdoPizza.TabIndex = 4;
            this.rdoPizza.TabStop = true;
            this.rdoPizza.Text = "Pizza - $5.95";
            this.rdoPizza.UseVisualStyleBackColor = true;
            this.rdoPizza.CheckedChanged += new System.EventHandler(this.rdoPizza_CheckedChanged);
            // 
            // rdoHamburger
            // 
            this.rdoHamburger.AutoSize = true;
            this.rdoHamburger.Location = new System.Drawing.Point(6, 21);
            this.rdoHamburger.Name = "rdoHamburger";
            this.rdoHamburger.Size = new System.Drawing.Size(149, 21);
            this.rdoHamburger.TabIndex = 3;
            this.rdoHamburger.TabStop = true;
            this.rdoHamburger.Text = "Hamburger - $6.95";
            this.rdoHamburger.UseVisualStyleBackColor = true;
            this.rdoHamburger.CheckedChanged += new System.EventHandler(this.rdoHamburger_CheckedChanged);
            // 
            // grpAddOn
            // 
            this.grpAddOn.Controls.Add(this.chkFrenchFriesOlivesBreadSticks);
            this.grpAddOn.Controls.Add(this.chkKetchupSausageBaconBits);
            this.grpAddOn.Controls.Add(this.chkLettucePepperoniCroutons);
            this.grpAddOn.Location = new System.Drawing.Point(198, 27);
            this.grpAddOn.Name = "grpAddOn";
            this.grpAddOn.Size = new System.Drawing.Size(238, 100);
            this.grpAddOn.TabIndex = 6;
            this.grpAddOn.TabStop = false;
            this.grpAddOn.Text = "Add-on items ($0.75/each)";
            // 
            // chkFrenchFriesOlivesBreadSticks
            // 
            this.chkFrenchFriesOlivesBreadSticks.AutoSize = true;
            this.chkFrenchFriesOlivesBreadSticks.Location = new System.Drawing.Point(17, 73);
            this.chkFrenchFriesOlivesBreadSticks.Name = "chkFrenchFriesOlivesBreadSticks";
            this.chkFrenchFriesOlivesBreadSticks.Size = new System.Drawing.Size(105, 21);
            this.chkFrenchFriesOlivesBreadSticks.TabIndex = 9;
            this.chkFrenchFriesOlivesBreadSticks.Text = "French fries";
            this.chkFrenchFriesOlivesBreadSticks.UseVisualStyleBackColor = true;
            this.chkFrenchFriesOlivesBreadSticks.CheckedChanged += new System.EventHandler(this.chkFrenchFriesOlivesBreadSticks_CheckedChanged);
            // 
            // chkKetchupSausageBaconBits
            // 
            this.chkKetchupSausageBaconBits.AutoSize = true;
            this.chkKetchupSausageBaconBits.Location = new System.Drawing.Point(17, 48);
            this.chkKetchupSausageBaconBits.Name = "chkKetchupSausageBaconBits";
            this.chkKetchupSausageBaconBits.Size = new System.Drawing.Size(211, 21);
            this.chkKetchupSausageBaconBits.TabIndex = 8;
            this.chkKetchupSausageBaconBits.Text = "Ketchup, mustard, and mayo";
            this.chkKetchupSausageBaconBits.UseVisualStyleBackColor = true;
            this.chkKetchupSausageBaconBits.CheckedChanged += new System.EventHandler(this.chkKetchupSausageBaconBits_CheckedChanged);
            // 
            // chkLettucePepperoniCroutons
            // 
            this.chkLettucePepperoniCroutons.AutoSize = true;
            this.chkLettucePepperoniCroutons.Location = new System.Drawing.Point(17, 24);
            this.chkLettucePepperoniCroutons.Name = "chkLettucePepperoniCroutons";
            this.chkLettucePepperoniCroutons.Size = new System.Drawing.Size(206, 21);
            this.chkLettucePepperoniCroutons.TabIndex = 7;
            this.chkLettucePepperoniCroutons.Text = "Lettuce, tomato, and onions";
            this.chkLettucePepperoniCroutons.UseVisualStyleBackColor = true;
            this.chkLettucePepperoniCroutons.CheckedChanged += new System.EventHandler(this.chkLettucePepperoniCroutons_CheckedChanged);
            // 
            // grpOrderTotal
            // 
            this.grpOrderTotal.Controls.Add(this.txtOrderTotal);
            this.grpOrderTotal.Controls.Add(this.txtTaxTotal);
            this.grpOrderTotal.Controls.Add(this.txtSubtotal);
            this.grpOrderTotal.Controls.Add(this.label3);
            this.grpOrderTotal.Controls.Add(this.label2);
            this.grpOrderTotal.Controls.Add(this.label1);
            this.grpOrderTotal.Location = new System.Drawing.Point(17, 145);
            this.grpOrderTotal.Name = "grpOrderTotal";
            this.grpOrderTotal.Size = new System.Drawing.Size(249, 135);
            this.grpOrderTotal.TabIndex = 10;
            this.grpOrderTotal.TabStop = false;
            this.grpOrderTotal.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Location = new System.Drawing.Point(124, 96);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.ReadOnly = true;
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 22);
            this.txtOrderTotal.TabIndex = 16;
            // 
            // txtTaxTotal
            // 
            this.txtTaxTotal.Location = new System.Drawing.Point(124, 62);
            this.txtTaxTotal.Name = "txtTaxTotal";
            this.txtTaxTotal.ReadOnly = true;
            this.txtTaxTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTaxTotal.TabIndex = 14;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(124, 28);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtSubtotal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Order Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tax (7.75%) :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Subtotal :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(296, 154);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(140, 30);
            this.btnPlaceOrder.TabIndex = 0;
            this.btnPlaceOrder.Text = "&Place order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(296, 250);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 30);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(463, 300);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.grpOrderTotal);
            this.Controls.Add(this.grpAddOn);
            this.Controls.Add(this.grpMainCourse);
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.grpMainCourse.ResumeLayout(false);
            this.grpMainCourse.PerformLayout();
            this.grpAddOn.ResumeLayout(false);
            this.grpAddOn.PerformLayout();
            this.grpOrderTotal.ResumeLayout(false);
            this.grpOrderTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMainCourse;
        private System.Windows.Forms.RadioButton rdoSalad;
        private System.Windows.Forms.RadioButton rdoPizza;
        private System.Windows.Forms.RadioButton rdoHamburger;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpAddOn;
        private System.Windows.Forms.CheckBox chkFrenchFriesOlivesBreadSticks;
        private System.Windows.Forms.CheckBox chkKetchupSausageBaconBits;
        private System.Windows.Forms.CheckBox chkLettucePepperoniCroutons;
        private System.Windows.Forms.GroupBox grpOrderTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTaxTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
    }
}

