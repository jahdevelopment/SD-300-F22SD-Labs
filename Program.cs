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
            VendingMachine myVending = new VendingMachine(100);

            

            myVending.StockItem( "Snickers" ,10);

            myVending.StockFloat(20,10);
        }
    }

}



