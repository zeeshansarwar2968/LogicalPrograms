using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        internal static void StopwatchSimulator()
        {
            //Importing Stopwatch class and creating an instance of it
            Stopwatch stopwatch = new Stopwatch();
            validation1:

            //User input to start the stopwatch
            Console.Write("To start the stopwatch enter S or s : ");
            char start = Convert.ToChar(Console.ReadLine());
            
            //Starting the stopwatch
            stopwatch.Start();

            //running conditional loop for stopping the stopwatch
            if (start == 's' || start == 'S')
            {
            validation2:
                Console.Write("To stop the stopwatch enter Q or q : ");
                char end = Convert.ToChar(Console.ReadLine());
                if (end == 'q' || end == 'Q')
                {
                    stopwatch.Stop();
                    //TimeSpan timeS = stopwatch.Elapsed;
                    //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", timeS.Hours, timeS.Minutes, timeS.Seconds, timeS.Milliseconds / 10);
                    Console.WriteLine("");
                    Console.WriteLine("stopwatch stopped, the elapsed time is : " + stopwatch.Elapsed);
                }
                else
                {
                    Console.WriteLine("Wrong Input");
                    goto validation2;
                }
            }
            else
            {
                stopwatch.Stop();
                Console.WriteLine("Wrong Input");
                goto validation1;
            }
        }
    }
}
