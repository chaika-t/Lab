using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class PiCalculator
    {
        public double Calculate(long iterations)
        {
            var processorCount = Environment.ProcessorCount;
            var threads = new PiThread[processorCount];
            var iterationsNumber = iterations / processorCount;
            
            for (var i = 0; i < processorCount; i++)
            {
                threads[i] = new PiThread(iterationsNumber);
                threads[i].Start();
            }

            long pointsResult = 0;
            var threadsCount = threads.Length;
            for (var i = 0; i < threadsCount; i++)
            {
                threads[i].Join();
                pointsResult += threads[i].Points;
            }

            return (double)pointsResult / iterations * 4.0;
        }
    }
}
