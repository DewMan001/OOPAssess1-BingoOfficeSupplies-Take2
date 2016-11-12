using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    class SalesInvoice
    {
        int userInvoiceNumber;
        string userProductNumber;
        double userSalePrice;
        int userAmtPurchased;
        double userSaleValue;

        public SalesInvoice(int invoiceNumber, string productNumber, int salePrice, int amtPurchased, int saleValue)
        {
            userInvoiceNumber = invoiceNumber;
            userProductNumber = productNumber;
            userSalePrice = salePrice;
            userAmtPurchased = amtPurchased;
            userSaleValue = saleValue;
        }

        public SalesInvoice()
        { }

        public int InvoiceNumber
        {
            set { userInvoiceNumber = value; }
            get { return userInvoiceNumber; }
        }

        public string ProductNumber
        {
            set { userProductNumber = value; }
            get { return userProductNumber; }
        }

        public int SalePrice
        {
            set { userSalePrice = value; }
            get { return userSalePrice; }
        }

        public int AmtPurchased
        {
            set { userAmtPurchased = value; }
            get { return userAmtPurchased; }
        }

        public int SaleValue
        {
            set { userSaleValue = value; }
            get { return userSaleValue; }
        }

        public int SaleTotal(int SalePrice, int AmountPurchased)
        {
            int TotalPrice;

            TotalPrice = SalePrice * AmountPurchased;

            return TotalPrice;
        }
    }

}
