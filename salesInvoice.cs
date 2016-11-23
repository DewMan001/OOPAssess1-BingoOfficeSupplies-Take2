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
            prodName = null;
            prodPrice = 0.0;
            prodStockDesired = 0;
            orderTotalValue = 0.0;
        }

       

        public int InvoiceNumber { get; set; }
        public string prodName { get; set; }
        public double prodPrice { get; set; }
        public int? prodStockDesired { get; set; }
        public double orderTotalValue { get; set; }

        public int calculateTotalValue(int individualPrice, int prodStockDesired)
        {
            int totalValue;
            totalValue = individualPrice * prodStockDesired;
            return totalValue;
        }

    }

}
