using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public void calculationLogic()
        {
            //initialsing variables to use in the program
            int n1 = 0, n2 = 1, n3, i, number;

            //taking in input from the user
            Console.Write("Enter the number of elements: ");
            number = Convert.ToInt32(Console.ReadLine());

            //printing 0 and 1 which are the initial values of the series
            Console.Write(n1 + " " + n2 + " ");

            //Main Logic loop, loop starts from 2 because 0 and 1 are already printed
            for (i = 2; i < number; ++i)     
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
