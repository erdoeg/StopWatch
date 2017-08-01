using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Cxercicio_Stopwhatch
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("-------------------------");
                Console.WriteLine("--- S T O P W A T C H ---");
                Console.WriteLine("Press ENTER to start - other key to exit");

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    var firstStopW = new StopWatch();
                    firstStopW.StartWatch();
                    Console.WriteLine("Press ENTER to stop - other key to exit");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        firstStopW.EndWatch();
                        firstStopW.Duration();
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("\nThanks for using STOPWATCH");

            




        }
    }
}
