using SD_300_F22SD_Labs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Sales
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Console.WriteLine("Insert the code of the Vending Machine:");
            int vmCode = Int32.Parse(Console.ReadLine());
            VendingMachine myVending = new VendingMachine(vmCode);



            Product Snickers = new Product("Snickers", 2, "A01");
            Product MilkyWay = new Product("MilkyWay", 1, "A02");
            Product Mars = new Product("Mars", 3, "A03");
            Product Toblerone = new Product("Toblerone", 2, "A04");
            Product Babyruth = new Product("Babyruth", 4, "A05");

            myVending.StockItem( Snickers ,10);
            myVending.StockItem(MilkyWay, 10);
            myVending.StockItem(Mars, 10);
            myVending.StockItem(Toblerone, 10);
            myVending.StockItem(Babyruth, 10);

            myVending.StockFloat(20,5);
            myVending.StockFloat(10, 10);
            myVending.StockFloat(5, 20);
            myVending.StockFloat(2, 30);
            myVending.StockFloat(1, 40);
            myVending.StockFloat(20, 5);

            List<int> money = new List<int> { 20 };
            myVending.VendItem("A07", money);

        }
    }

}



