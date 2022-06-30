using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceLineItems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<LineItem> lineItemList = LineItemDB.GetLineItems();
            List<Invoice> invoiceList = InvoiceDB.GetInvoices();

            var invoices = from lineItem in lineItemList
                           join invoice in invoiceList
                           on lineItem.InvoiceID equals invoice.InvoiceID
                           orderby invoice.InvoiceDate
                           select new
                           {
                               lineItem.InvoiceID,
                               invoice.InvoiceDate,
                               invoice.InvoiceTotal,
                               lineItem.ProductCode,
                               lineItem.UnitPrice,
                               lineItem.Quantity,
                               lineItem.ItemTotal
                           };

            // Initialize value to check for duplicate data
            int invoiceID = 0;
            DateTime invoiceDate = new DateTime(0001, 01, 01);
            decimal invoiceTotal = 0.00m;
            int i = 0;
            foreach (var invoice in invoices)
            {
                // New invoiceID
                if (invoice.InvoiceID != invoiceID)
                {
                    lvInvoices.Items.Add(invoice.InvoiceID.ToString());
                    // Update invoiceID
                    invoiceID = invoice.InvoiceID;

                    lvInvoices.Items[i].SubItems.Add(
                        Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());
                    // Update invoiceDate
                    invoiceDate = invoice.InvoiceDate;

                    lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                    // Update invoiceTotal
                    invoiceTotal = invoice.InvoiceTotal;
                }
                else
                {
                    lvInvoices.Items.Add("");// For the same invoiceDate
                    // New invoiceDate
                    if (invoice.InvoiceDate != invoiceDate)
                    {
                        lvInvoices.Items[i].SubItems.Add(
                            Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());
                        invoiceDate = invoice.InvoiceDate;

                        lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                        //Update invoiceTotal
                        invoiceTotal = invoice.InvoiceTotal;
                    }
                    else
                    {
                        lvInvoices.Items[i].SubItems.Add("");

                        // For the same invoice Total
                        if (invoice.InvoiceTotal != invoiceTotal)
                        {
                            lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                            invoiceTotal = invoice.InvoiceTotal;
                        }
                        else
                        {
                            lvInvoices.Items[i].SubItems.Add("");
                        }
                    }
                }

                //lvInvoices.Items[i].SubItems.Add(
                //    Convert.ToDateTime(invoice.InvoiceDate).ToShortDateString());
                //lvInvoices.Items[i].SubItems.Add(invoice.InvoiceTotal.ToString("c"));
                lvInvoices.Items[i].SubItems.Add(invoice.ProductCode);
                lvInvoices.Items[i].SubItems.Add(invoice.UnitPrice.ToString("c"));
                lvInvoices.Items[i].SubItems.Add(invoice.Quantity.ToString());
                lvInvoices.Items[i].SubItems.Add(invoice.ItemTotal.ToString("c"));
                i += 1;
            }
        }
    }
}
