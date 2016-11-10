using System;
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
            int invoiceNumber = frm1.sentInvoiceNumber;
            int productStock = frm1.sentProdStock;
            int stockDesired = frm1.sentStockDesired;
            string productName = frm1.sentProductName;
            double productPrice = frm1.sentProductPrice;
            double totalPrice = frm1.sentTotalPrice;
        }
    }
}
