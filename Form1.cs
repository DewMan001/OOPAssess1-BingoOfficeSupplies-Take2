using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //string for the path of products.txt
            string productsPath = "../../Resources/Products.txt";
            buildArray(productsPath);

            btn_closeOfBusiness.Hide();
        }




        //the various arrays for the product attributes
        string[] prodNumArray = new string[20];
        string[] prodNameArray = new string[20];
        static int[] prodStockArray = new int[20];
        double[] prodPriceArray = new double[20];
        string[] prodPicArray = new string[20];


        //public values for passing values between forms
        public static int sentCurrentItemIndex { get; set; }
        public static int sentInvoiceNumber { get; set; }
        public static int sentProdStock { get; set; }
        public static int sentStockDesired { get; set; }
        public static string sentProductName { get; set; }
        public static double sentTotalPrice { get; set; }
        public static double sentProductPrice { get; set; }

        //values for the salesInvoice
        public static int invInvoiceNumber { get; set; }
        public static string invProdName { get; set; }
        public static double invProdPrice { get; set; }
        public static int invStockDesired { get; set; }
        public static double invTotalPrice { get; set; }

        public static SalesInvoice invoiceGrab = new SalesInvoice();

        public static SalesInvoice[] salesInvoiceArray = new SalesInvoice[20];

        //bool for when the saleSuccessful form is open
        public static bool saleSuccessfulOpen;

        //an integer for the invoice number
        public static int invoiceNum = 000000;

        //int for current order of the day
        static int currentOrder = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
           lBox_ProductsDisplay.SelectedIndex = 1;
          
        }

        

        private double calcSalePrice(double originalPrice)
        {
            //setting up a variable to store the mark up
            double markUp;
            //calculating the markup
            markUp = originalPrice * 0.60;

            //creating a variable to keep in the sale price
            double salePrice;
            //calculating the sale price
            salePrice = originalPrice + markUp;


            //sending back the sale price
            return salePrice;
        }

        public void buildArray(string pathOfFile)
        {
            //making a string to read in each line
            string nextLine;

            //and a string for the file path
            string filePath;
            filePath = pathOfFile;
            //MessageBox.Show(filePath);

            //and a streamreader to pipe in the data
            StreamReader pipeIn;

            //finally a string array to hold the split up line
            string[] splitString = new string[5];

            //checking if the data file exists
            if (File.Exists(filePath))
            {
                //popping open the text file to read things from it
                pipeIn = File.OpenText(filePath);

                //reading in the next line
                nextLine = pipeIn.ReadLine();
                int count = 0;
                //as long as the next line in the text file isn't empty...
                while (nextLine != null)
                {
                    //making a temporary array to store the split up line
                    string[] lineArray = new string[5];
                    //break up the next line by the commas
                    lineArray = nextLine.Split(',');

                    //order of the fields: product code, product name, amount of stock, individual sale price, image name
                    prodNumArray[count] = lineArray[0];
                    prodNameArray[count] = lineArray[1];
                    prodStockArray[count] = Int32.Parse(lineArray[2]);
                    prodPriceArray[count] = double.Parse(lineArray[3]);
                    prodPicArray[count] = lineArray[4];
                    nextLine = pipeIn.ReadLine();
                    count++;

                    lBox_ProductsDisplay.Items.Add(lineArray[1]);
                }

            }

        }

        private void btn_Sale_Click(object sender, EventArgs e)
        {
            saleSuccessful nextForm = new saleSuccessful();
            //incrementing the invoice number by one
            invoiceNum = invoiceNum + 1;

            //pulling in the currently selected item
            int selectedItem = lBox_ProductsDisplay.SelectedIndex;

            //using that index to pick out which stock to edit
            int prodStock = prodStockArray[selectedItem];

            //picking up the stock the customer wants
            int stockDesired = Int32.Parse(Microsoft.VisualBasic.Interaction.InputBox("How much stock is desired?" + invoiceNum, "Stock desired", "1", 0, 0));

            //pulling in the price of an individual unit
            double productPrice = prodPriceArray[selectedItem];

            //pulling in the name of the product
            string productName = prodNameArray[selectedItem];

            //calculating the full price
            double fullPrice;
            fullPrice = stockDesired * prodPriceArray[selectedItem];

            

            //comparing the stockDesired to the stockRemaining
            if (stockDesired <= prodStock)
            {
                sentCurrentItemIndex = selectedItem;
                sentInvoiceNumber = invoiceNum;
                sentProdStock = prodStock;
                sentProductName = productName;
                sentStockDesired = stockDesired;
                sentTotalPrice = fullPrice;
                sentProductPrice = productPrice;

                nextForm.ShowDialog();

                while (saleSuccessfulOpen == false)
                {
                    string ResponseString = "You just sold the following:" +
                    "\n \n" +
                    "INVOICE NUMBER: " + invoiceGrab.InvoiceNumber + "\n" +
                    "PRODUCT NAME: " + invoiceGrab.prodName + "\n" +
                    "INDIVIDUAL PRICE" + invoiceGrab.prodPrice + "\n" +
                    "AMOUNT ORDERED: " + invoiceGrab.prodStockDesired + "\n" +
                    "TOTAL ORDER: " + invoiceGrab.orderTotalValue + "\n \n \n \n" +
                    "Thank you for placing this order!";

                    MessageBox.Show(ResponseString);

                    saleSuccessfulOpen = true;
                }

                btn_closeOfBusiness.Show();

                

                
            }
            else if (stockDesired > prodStock)
            {
                MessageBox.Show("There is not enough stock. \n \n You tried to order " + stockDesired + ", but unfortunately we only have " + prodStock + ".");
            }


        }


        private void txt_AmountOrdered_TextChanged(object sender, EventArgs e)
        {       

        }

        private void lBox_ProductsDisplay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedItem = lBox_ProductsDisplay.SelectedIndex;

            double salePrice = calcSalePrice(prodPriceArray[selectedItem]);

            lbl_SalePrice.Text = salePrice.ToString();

            //file path for the image
            string imgPath = "../../Resources/" + prodPicArray[selectedItem];

            imgBox_Display.Image = Image.FromFile(imgPath);
        }

        public static void storeData(int invoiceNumber, string productName, double productPrice, int stockDesired, double totalPrice, int remainderStock, int selectedItemIndex)
        {
            selectedItemIndex = sentCurrentItemIndex;
            invoiceGrab.InvoiceNumber = invoiceNumber;
            invoiceGrab.prodName = productName;
            invoiceGrab.prodPrice = productPrice;
            invoiceGrab.prodStockDesired = stockDesired;
            invoiceGrab.orderTotalValue = totalPrice;

            prodStockArray[selectedItemIndex] = remainderStock;

            //putting InvoiceGrab into the salesInvoice Array
           salesInvoiceArray[currentOrder] = invoiceGrab;

            //incrementing currentOrder up by one
            currentOrder++;

        }

        private void btn_closeOfBusiness_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            int daysStock = 0;
            double daysValue = 0;

            //for loop for deterimining the stock sold over the course of the day
            for (int count = 0; count <= salesInvoiceArray.Length; count++)
            {
                daysStock = daysStock + salesInvoiceArray[count].prodStockDesired;
            }

            //for loop for determining the total value of the products sold that day
            for (int count = 0; count <= salesInvoiceArray.Length; count++)
            {
                daysValue = daysValue + salesInvoiceArray[count].orderTotalValue;
            }

            SalesInvoice cobFinalInvoice = new SalesInvoice();

            cobFinalInvoice.InvoiceNumber = 999;
            cobFinalInvoice.prodName = "Total Sales for: " + currentDateTime;
            cobFinalInvoice.prodPrice = 0;
            cobFinalInvoice.prodStockDesired = daysStock;
            cobFinalInvoice.orderTotalValue = daysValue;

            StreamWriter overWriteProducts = new StreamWriter("../../Resources/Products.txt");

            for (int count = 0; count <= prodNumArray.Length; count++)
            {
                if (prodNumArray[count] == null || prodNameArray[count] == null || prodStockArray[count] == null || prodPriceArray == null)
                {
                    count = prodNumArray.Length + 1;
                }
                else
                {
                    string newLine;
                    newLine = prodNumArray[count] + "," + prodNameArray[count] + "," + prodStockArray[count] + "," + prodPriceArray[count] + "," + prodPicArray[count];
                }
            }

            //getting in the date time for the date review sheet
            DateTime todaysDate = DateTime.Now;

            //turning that date into a string
            string todaysDateString = todaysDate.ToLongDateString();

            StreamWriter writeDaysReview = new StreamWriter("../../Resources/salesReview" + todaysDateString + ".txt");



        }
    }
}
