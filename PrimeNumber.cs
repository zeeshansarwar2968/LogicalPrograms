using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        internal static void Check_Prime()
        {
            //taking in input from the user
            Console.Write("Enter the number to check for prime : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int flag = 0;

            //logic to mete out the check for prime number on the given input
            for (int i = 2; i < number/2; i++)
            {

                if (number % i == 0)
                {
                    Console.WriteLine("{0} is not a prime number", number);
                    flag = 1;
                    break;
                }
            }

            if (flag==0)
            {
                Console.WriteLine("{0} is a prime number", number);
            }
            
        }
    }
}
