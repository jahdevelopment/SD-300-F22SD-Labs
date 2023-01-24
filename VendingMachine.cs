using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SD_300_F22SD_Labs
{
    public class VendingMachine
    {
        // PROPERTIES
        public int SerialNumber { get; set; }

        public int MoneyDenomination { get; set; }

        public int CoinsQuantity { get; set; }

        public int ProductQuantity { get; set; }

        public string Code { get; set; }

        public List<int> Money { get; set; }

        Dictionary<int, int> MoneyFloat { get; }

        Dictionary<Product, int> Inventory { get; set; }

        public string code { get; set; }

        public List<int> money { get; set; }

        
        // CONSTRUCTOR

        public VendingMachine(int serialnumber)
        {
            SerialNumber = serialnumber;

            MoneyFloat = new Dictionary<int, int>();

            Inventory= new Dictionary<Product, int>();

        }

        
        // METHODS

        public string StockItem(Product product, int productquantity)
        {
            if (Inventory.ContainsKey(product))
            {
                Inventory[product] += productquantity;
            }
            else
            {
                Inventory.Add(product, productquantity);
            }

            return $"New product available{product.Name}, code{product.Code}, just by ${product.Price}";
        }

        public string StockFloat(int moneydenomination, int coinsquantity)
        {
            MoneyDenomination= moneydenomination;

            CoinsQuantity= coinsquantity;

            Dictionary<int, int> MoneyFloat = new Dictionary<int, int>();

            MoneyFloat.Add(moneydenomination, coinsquantity);

            string moneyAdded = "";

            foreach(var item in MoneyFloat)
            {
                moneyAdded = $"Added {item.Value} coins of ${item.Key} denomination.";
                Console.WriteLine(moneyAdded);
            }
            
            return moneyAdded;
        }

        public string VendItem(string code, List<int> money)
        {
            Code= code;

            Money= money;

            int totalMoney = 0;

            foreach(var item in Money)
            {
                totalMoney += item;
            }

            bool succesfullTransaction = false;

            foreach(var item in Inventory)
            {
                if (item.Key.Equals(code)) 
                { 
                    succesfullTransaction= true;
                }
                else
                {
                    Console.WriteLine($"Error: {item.Key} is out of stock");
                }

                if (item.Value < totalMoney)
                {
                    succesfullTransaction = true;
                }
                else
                {
                    Console.WriteLine($"Error: insufficient money provided");
                }
            }
            
            string transactionCompleted = "";

            if (succesfullTransaction)
            {
                foreach(var i in Inventory)
                {
                    if (i.Key.Equals(code))
                    {
                        transactionCompleted = $"Please enjoy your {i} and take your change of $0.60";
                    };
                }
            }
            return transactionCompleted;
        }

        

        
    }
}
