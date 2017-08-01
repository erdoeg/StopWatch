using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Cxercicio_Stopwhatch
{
    public class StopWatch
    {
        private readonly TimeSpan _duration;
        private DateTime _startNow;
        private DateTime _endNow;
        private bool _isRunning;

        public StopWatch()
        {
            _duration = new TimeSpan(0, 0, 0);
        }

        public void StartWatch()
        {

            if (!_isRunning)
            {
                _startNow = DateTime.Now;
                _isRunning = true;
                Console.WriteLine("STOPWATCH starts!");
            }
            else
            {
                throw new InvalidOperationException("StopWatch Already Started");
            }

        }

        public void EndWatch()
        {
            if (_isRunning)
            {
                _endNow = DateTime.Now;
                _isRunning = false;
                Console.WriteLine("STOPWATCH ends");
            }

        }

        public void Duration()
        {
            Console.WriteLine("Duration: " + (_endNow - _startNow).ToString());
        }
    }
}
