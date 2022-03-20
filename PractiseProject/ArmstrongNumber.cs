using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class ArmstrongNumber
    {
      
        public void Armstrong(int num)
        {
            int sum = 0, actualnum, rem;
           
            actualnum = num;
            while (num > 0)
            {
                rem = num % 10;
                sum = sum + (rem*rem*rem);
                num = num / 10;
            }
            if (actualnum == sum)
            {
                Console.WriteLine($"{actualnum} is Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{actualnum} is not a Armstrong Number");
            }
        }
    }
}
