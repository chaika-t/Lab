using System;
using System.Threading;

namespace Lab7
{
    class PiThread
    {
        private Thread _thread;
        private long _iterations;
        private long _points;

        public PiThread(long iterations)
        {
            _iterations = iterations;
            _thread = new Thread(Run);
            Points = 0;
        }

        public long Points
        {
            get => _points;
            private set => _points = value;
        }

        public void Join() => _thread.Join();
        public void Start() => _thread.Start();

        private void Run()
        {
            double r = 1.0;
            double x = 0;
            double y = 0;
            double distance = 0;
            Random random = new Random();

            for (var i = 0; i < _iterations; i++)
            {
                x = random.NextDouble();
                y = random.NextDouble();
                distance = x*x + y*y;

                if (distance < r) Points++;
            }
        }
    }
}
