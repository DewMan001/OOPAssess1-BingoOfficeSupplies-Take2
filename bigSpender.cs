using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    public class bigSpender : SalesInvoice
    {
        public string customerName { get; set; }
        public int customerPhoneNum { get; set; }
        public string customerAddress1 { get; set; }
        public string customerEmail { get; set; }
        public double bigSpenderDiscount { get; set; }
        
        public bigSpender()
        {
            customerName = "";
            customerPhoneNum = 0;
            customerAddress1 = "";
            customerEmail = "";
            bigSpenderDiscount = 0.05;
        }

        public override double calculateTotalValue(double individualPrice, int prodStockDesired)
        {
            double totalPrice = base.calculateTotalValue(individualPrice, prodStockDesired);
            return totalPrice;
        }
    }
}
