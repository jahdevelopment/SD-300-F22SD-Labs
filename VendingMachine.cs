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

            Inventory = new Dictionary<Product, int>();

            Console.WriteLine($"\nStarting Operation of the Vending Machine #{serialnumber}\n");
        }

        
        // METHODS

        public string StockItem(Product product, int productquantity)
        {
            string fillingInventory = "";

            if (Inventory.ContainsKey(product))
            {
                Inventory[product] += productquantity;
            }
            else
            {
                Inventory.Add(product, productquantity);
            }
            
            fillingInventory = $"New product available: {product.Name}, code \"{product.Code}\", by ${product.Price}. There are {productquantity} units.";
            
            Console.WriteLine(fillingInventory);
            
            return fillingInventory;
        }

        public string StockFloat(int moneydenomination, int coinsquantity)
        {
            string moneyAdded = "";
            MoneyDenomination = moneydenomination;

            CoinsQuantity = coinsquantity;

            if (MoneyFloat.ContainsKey(moneydenomination))
            {
                MoneyFloat[moneydenomination] += coinsquantity;
                moneyAdded = $"Filling the ${moneydenomination} denomination with {coinsquantity} coins.";
            }
            else
            {
                MoneyFloat.Add(moneydenomination, coinsquantity);
                moneyAdded = $"Added {coinsquantity} coins of ${moneydenomination} denomination.";
            }
            Console.WriteLine(moneyAdded);
            return moneyAdded;
        }

        public string VendItem(string code, List<int> money)
        {
            string transactionMessage = "";

            money = new List<int>();

            foreach(var j in Inventory)
            {
                if (!j.Key.Equals(code))
                {
                    transactionMessage = $"Error, no item with code {code}";
                }
            }

            





            Console.WriteLine(transactionMessage);
            return  transactionMessage;
        }

        

        
    }
}
