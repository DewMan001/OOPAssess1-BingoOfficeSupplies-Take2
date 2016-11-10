using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssess1_BingoOfficeSupplies_Take2
{
    class passThrough
    {
        int stockDesired;
        int stockRemaining;
        double totalPrice;

        private void setStockDesired(int input)
        {
            stockDesired = input;
        }

        private int getStockDesired()
        {
            return stockDesired;
        }
    }
}
