using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = {"test", "string" };
            string[] res = StringChecker.FindMoreThanAverage(stringArr);

            foreach (var str in res)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}
