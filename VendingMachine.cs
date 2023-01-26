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

        public Product VendItem(string code, List<int> money)
        {
         /////// VALIDATION OF CODE INSERTED BY THE CUSTOMER
                if (!Inventory.Any(i => i.Key.Code == code))
                {
                    Console.WriteLine($"Error, no item with code \"{code}\"");
                }

                //////// VALIDATION OF THE STOCK PRODUCT
                Product product = Inventory.First(i => i.Key.Code == code).Key;

                int quantity = Inventory[product];

                if (quantity == 0)
                {
                    Console.WriteLine("Error: Item is out of stock");
                }

                /////// VALIDATION OF MONEY INSERTED
                int totalMoney = money.Sum();

                if (totalMoney < product.Price)
                {
                    Console.WriteLine("Error: insufficient money provided");
                
                }

                /////// RUNNING TRANSACTION
                int change = totalMoney - product.Price;

                Inventory[product]--;

                string changeString = "";

                foreach (var item in MoneyFloat)
                {
                    int denomination = item.Key;

                    int denominationQuantity = item.Value;

                    while (change >= denomination && denominationQuantity > 0)
                    {
                        change -= denomination;

                        denominationQuantity--;

                        MoneyFloat[denomination]--;

                        changeString += $"{denomination} ";
                    }
                }
                string completedTransaction = $"Please enjoy your {product.Name} and take your change of ${changeString}";

                Console.WriteLine(completedTransaction);
            
            

            return null;
        }
    }
}
