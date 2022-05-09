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

            FibonacciSeries series = new FibonacciSeries();
            series.calculationLogic();

            Console.ReadKey();
        }
    }
}
