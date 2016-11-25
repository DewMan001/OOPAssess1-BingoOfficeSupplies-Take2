using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    public class SalesInvoice
    {
      
        public SalesInvoice()
        {
            InvoiceNumber = 0;
            prodNum = "";
            prodName = null;
            prodPrice = 0.0;
            prodStockDesired = 0;
            orderTotalValue = 0.0;
        }

       

        public int InvoiceNumber { get; set; }
        public string prodNum { get; set; }
        public string prodName { get; set; }
        public double prodPrice { get; set; }
        public int prodStockDesired { get; set; }
        public double orderTotalValue { get; set; }

        public virtual double  calculateTotalValue(double individualPrice, int prodStockDesired)
        {
            double totalValue;
            totalValue = individualPrice * prodStockDesired;
            return totalValue;
        }

    }

}
