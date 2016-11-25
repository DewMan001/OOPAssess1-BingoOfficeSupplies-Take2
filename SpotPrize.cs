using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    class SpotPrize : bigSpender
    {
        public string prodOfDayCode { get; set; }

        public SpotPrize()
        {
            prodOfDayCode = "";
        }

        public override double calculateTotalValue(double individualPrice, int prodStockDesired)
        {
            double totalValue;

            totalValue = individualPrice * prodStockDesired * bigSpenderDiscount - (individualPrice * 0.5);

            return totalValue;
        }
    }
}
