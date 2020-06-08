using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class CashRegister
    {
        private Dictionary<string, double> _prices;
        private Dictionary<string, int> _products;

        public CashRegister(Dictionary<string, double> prices)
        {
            _products = new Dictionary<string, int>();
            _prices = prices;
        }

        public Dictionary<string, double> Prices => _prices;

        public void AddProduct(string productName, int quantity)
        {
            if (!_products.ContainsKey(productName))
            {
                _products.Add(productName, quantity);
            }
            else
            {
                _products[productName] = quantity + _products[productName];
            }
        }

        public string GetReceipt()
        {
            var products = new SortedDictionary<string, int>(_products);
            var stringBuilder = new StringBuilder();
            double totalPrice = 0;

            foreach (var key in products.Keys)
            {
                stringBuilder.AppendLine(key +
                                     " " +
                                     products[key] +
                                     " * " +
                                     Prices[key] +
                                     " = " +
                                     products[key] * Prices[key]);
                totalPrice += products[key] * Prices[key];
            }

            stringBuilder.AppendLine($"Total price ={totalPrice}");

            return stringBuilder.ToString();
        }
    }
}
