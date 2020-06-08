using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cashRegister = new CashRegister(new Dictionary<string, double>
                {{"Bread", 39.0}, {"Tomato", 20.0}, {"Garlic", 15.0}});

            cashRegister.AddProduct("Bread", 2);
            cashRegister.AddProduct("Tomato", 3);
            cashRegister.AddProduct("Garlic", 1);

            Console.WriteLine(cashRegister.GetReceipt());
            Console.ReadKey();
        }
    }
}
