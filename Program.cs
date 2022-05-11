using System;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("\t\t\tLogical Programs in C#");
            Console.WriteLine("");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("");
            Console.WriteLine("2. Perfect Number");
            Console.WriteLine("");
            Console.WriteLine("3. Prime Number");
            Console.WriteLine("");
            Console.WriteLine("4. Reverse the Number");
            Console.WriteLine("");
            Console.WriteLine("5. Coupon Numbers");
            Console.WriteLine("");
            Console.WriteLine("6. Stopwatch Simulator");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t Please press 0 to exit");
            Console.WriteLine("");
            //FibonacciSeries series = new FibonacciSeries();
            //series.calculationLogic();
            
            int flag = 0;
            while (flag == 0)
            {
                Console.Write("\nPlease Enter Your Option to choose the program to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FibonacciSeries series = new FibonacciSeries();
                        series.calculationLogic();
                        break;
                    case 2:
                        PerfectNumber perfectNumber = new PerfectNumber();
                        perfectNumber.PerfectNumberLogic();
                        break;
                    case 3:
                        PrimeNumber.Check_Prime();
                        break;
                    case 4:
                        ReverseNumber.ReverseLogic();
                        break;
                    case 5:
                        CouponNumbers.CouponGenerator();
                        break;
                    case 6:
                        StopWatch.StopwatchSimulator();
                        break;  
                    case 0:
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Please Enter from the given choice");
                        break;
                  

                }

            }
            

            
            
        }
    }
}
