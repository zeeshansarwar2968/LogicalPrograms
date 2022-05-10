using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PerfectNumber
    {
        public void PerfectNumberLogic()
        {
            //initialsing variables to use in the program
            int sum=0, number;
            string divisors = "";
            //taking in input from the user
            Console.Write("Enter the number to check for perfect number: ");
            number = Convert.ToInt32(Console.ReadLine());

            //initiating a for loop for times as inut by the user encomposing the logic
            for (int i = 1; i < number; i++)
            {   
                if (number % i == 0)    //if he number is divisible by i, then add to the sum and append that to the divisors string
                {
                    sum += i;
                    divisors += i.ToString() + "+";
                }
            }
            //To remove the last "+" appended in the string divisors
            divisors = divisors.Remove(divisors.Length - 1, 1);

            Console.WriteLine(divisors + " = " + sum);

            //To check if the number is perfect and log the output
            if (sum == number)
            {
                Console.WriteLine("Thus , " + number + " Is A Perfect Number");
            }
            else
                Console.WriteLine("Thus , " + number + " Is Not A Perfect Number");
        }
    }
}
