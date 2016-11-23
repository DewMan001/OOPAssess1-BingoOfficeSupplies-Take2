using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    class bigSpender : SalesInvoice
    {
        string customerName { get; set; }
        int customerPhoneNum { get; set; }
        string customerAddress1 { get; set; }
        string customerEmail { get; set; }
        double bigSpenderDiscount { get; set; }
        
        bigSpender()
        {
            customerName = "";
            customerPhoneNum = 0;
            customerAddress1 = "";
            customerEmail = "";
            bigSpenderDiscount = 0.05;
        }

        public override double calculateTotalValue(int individualPrice, int prodStockDesired)
        {
            int totalValue;
            totalValue = individualPrice * prodStockDesired;
            return totalValue;
        }
    }
}
