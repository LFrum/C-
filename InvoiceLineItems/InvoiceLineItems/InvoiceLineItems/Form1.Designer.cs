namespace InvoiceLineItems
{
    partial class Form1
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
            this.lvInvoices = new System.Windows.Forms.ListView();
            this.InvoiceID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InvoiceTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UnitPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ItemTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInvoices
            // 
            this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InvoiceID,
            this.InvoiceDate,
            this.InvoiceTotal,
            this.ProductCode,
            this.UnitPrice,
            this.Quantity,
            this.ItemTotal});
            this.lvInvoices.Location = new System.Drawing.Point(6, 2);
            this.lvInvoices.Name = "lvInvoices";
            this.lvInvoices.Size = new System.Drawing.Size(938, 576);
            this.lvInvoices.TabIndex = 0;
            this.lvInvoices.UseCompatibleStateImageBehavior = false;
            this.lvInvoices.View = System.Windows.Forms.View.Details;
            // 
            // InvoiceID
            // 
            this.InvoiceID.Text = "Invoice ID";
            this.InvoiceID.Width = 85;
            // 
            // InvoiceDate
            // 
            this.InvoiceDate.Text = "Invoice Date";
            this.InvoiceDate.Width = 100;
            // 
            // InvoiceTotal
            // 
            this.InvoiceTotal.Text = "Invoice Total";
            this.InvoiceTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InvoiceTotal.Width = 100;
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product Code";
            this.ProductCode.Width = 100;
            // 
            // UnitPrice
            // 
            this.UnitPrice.Text = "Unit Price";
            this.UnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UnitPrice.Width = 100;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Quantity.Width = 80;
            // 
            // ItemTotal
            // 
            this.ItemTotal.Text = "Item Total";
            this.ItemTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ItemTotal.Width = 100;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 590);
            this.Controls.Add(this.lvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Line Items by Invoice Date";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader InvoiceID;
        private System.Windows.Forms.ColumnHeader InvoiceDate;
        private System.Windows.Forms.ColumnHeader InvoiceTotal;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader UnitPrice;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader ItemTotal;
    }
}

