using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class CouponNumbers
    {
        public static void CouponGenerator()
        {
            int distinct = 0, count = 0;

            //taking in input from the user
            //Input ->N Distinct Coupon Number
            Console.Write("Enter a number of given distinct coupons: ");
            int couponNo = Convert.ToInt32(Console.ReadLine());

            //In this step we are taking an array to store boolean values with size of the input couponNo
            bool[] isCollected = new bool[couponNo];

            //The main logic here is to run a loop while distinct < couponNo is false
            //Then to generate a new coupon using random class
            //Next we check if the randomly genrated coupon is in the isCollected array
            //Since the array contains bool values, if not present we change the value to true
            //At the same time we are incrementing the counter with every positive iteration
            
            while (distinct < couponNo)
            {
                Random random = new Random();
                int newCoupon = (int)(random.NextDouble() * couponNo);
                count++;
                //c. Logic -> repeatedly choose a random number and check whether it's a new one.
                if (!isCollected[newCoupon])
                {
                    distinct++;
                    isCollected[newCoupon] = true;
                }
            }

            //O/P -> total random number needed to have all distinct numbers.
            Console.WriteLine("Total random number needed to have all distinct coupons:" + count);
        }
    }
}
