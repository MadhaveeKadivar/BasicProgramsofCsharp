using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    class ReverseNumber
    {
        
        public static void FindReverseofNumber(int number)
        {
            int reverse = 0, actualnumber;
            actualnumber = number;
            while (number > 0)
            {
                reverse = (reverse * 10);
                reverse = reverse + (number % 10);
                number = number / 10;
            }
            Console.WriteLine($"The reverse of {actualnumber} is : {reverse}");
        }
    }
}
