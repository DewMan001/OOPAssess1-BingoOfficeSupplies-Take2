﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    public partial class saleSuccessful : Form
    {
        public saleSuccessful()
        {
            InitializeComponent();
        }

        public Form1 frm1 { get; set; }

        private void saleSuccessful_Load(object sender, EventArgs e)
        {

            //pulling in all the variables from the first form
            int invoiceNumber = Form1.sentInvoiceNumber;
            int productStock = Form1.sentProdStock;
            int stockDesired = Form1.sentStockDesired;
            string productName = Form1.sentProductName;
            double productPrice = Form1.sentProductPrice;
            double totalPrice = Form1.sentTotalPrice;

            //creating a string for the label text
            string lblText;
            lblText = "ORDER NUMBER: " + invoiceNumber
                + "\n \n PRODUCT: " + productName
                + "\n AMOUNT BEING ORDERED: " + stockDesired
                + "\n STOCK REMAINING: " + productStock
                + "\n INDIVIDUAL UNIT PRICE: " + productPrice
                + "\n FULL ORDER PRICE: " + totalPrice
                + "\n \n \n Are you sure you wish to go ahead with this order?";

            //setting the label on the form to lblText
            lbl_TextDisplay.Text = lblText;
        }
    }
}
