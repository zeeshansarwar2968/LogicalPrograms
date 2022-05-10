using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void ReverseLogic()
        {
            //initialsing variables to use in the program
            int InputNum, revNum = 0, remainder;

            //taking in input from the user
            Console.Write("Enter the number to be reversed : ");
            InputNum = Convert.ToInt32(Console.ReadLine());
            
            //Logic to reverse the input number
            while (InputNum != 0)
            {
                remainder = InputNum % 10;
                revNum = (revNum*10) + remainder;
                InputNum /= 10;

            }

            Console.WriteLine("The reverse of the provided number is : "+revNum);
        }
    }
}
