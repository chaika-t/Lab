using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            const int iterations = 1000000000;

            var start = Environment.TickCount;
            var pi = new PiCalculator().Calculate(iterations);
            var finish = Environment.TickCount;

            Console.WriteLine($"Pi : {pi}");
            Console.WriteLine($"Time: {finish - start}ms");
            Console.WriteLine($"Iterations: {iterations}");
            Console.ReadKey();
        }
    }
}
