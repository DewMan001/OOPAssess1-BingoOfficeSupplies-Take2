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
            string productNumber = Form1.sentProdNum;
            int productStock = Form1.sentProdStock;
            int stockDesired = Form1.sentStockDesired;
            string productName = Form1.sentProductName;
            double productPrice = Form1.sentProductPrice;
            double totalPrice = Form1.sentTotalPrice;

            //creating a string for the label text
            string lblText;
            lblText = "ORDER NUMBER: " + invoiceNumber
                + "\n \n PRODUCT: " + productName
                + "\n \n PRODUCT NUMBER" + productNumber
                + "\n AMOUNT BEING ORDERED: " + stockDesired
                + "\n STOCK REMAINING: " + productStock
                + "\n INDIVIDUAL UNIT PRICE: " + productPrice
                + "\n FULL ORDER PRICE: " + totalPrice
                + "\n \n \n Are you sure you wish to go ahead with this order?";

            //setting the label on the form to lblText
            lbl_TextDisplay.Text = lblText;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Form1.sentInvoiceNumber = 0;
            Form1.sentProdStock = 0;
            Form1.sentProdNum = "";
            Form1.sentStockDesired = 0;
            Form1.sentProductName = "";
            Form1.sentProductPrice = 0.0;
            Form1.sentTotalPrice = 0.0;

            //closing the form
            this.Close();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            //reducing the stock
            //variables declaration
            int stockDesired = Form1.sentStockDesired;
            int prodStock = Form1.sentProdStock;

            int indexCount = Form1.currentInvoice;

            SalesInvoice invoiceGrab = new SalesInvoice();

            bigSpender bigBigWinner = new bigSpender(); 

            //reducing the stock
            Form1.sentProdStock = prodStock - stockDesired;


            invoiceGrab = Form1.storeData(Form1.invoiceNum, Form1.sentProductName, Form1.sentProductPrice, Form1.sentStockDesired, Form1.sentTotalPrice, Form1.sentProdStock, Form1.sentCurrentItemIndex, invoiceGrab, Form1.sentProdNum);

            if(invoiceGrab.orderTotalValue >= 20)
            {
                bigBigWinner.customerName = Microsoft.VisualBasic.Interaction.InputBox("What is the customer's name?", "Customer's Name", "", 0, 0);
                bigBigWinner.customerEmail = Microsoft.VisualBasic.Interaction.InputBox("What is the customer's email address?", "Customer's Email", "", 0, 0);

                Form1.spenderStore = bigBigWinner;

                Form1.isCusBigSpender = true;
                
            }

            Form1.invoiceGrab = invoiceGrab;

            Form1.salesInvoiceArray[indexCount] = invoiceGrab;

            Form1.saleSuccessfulOpen = false;

            this.Close();

            
        }
    }
}
