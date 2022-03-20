using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class PerfectNumber
    {
        public static void Perfectnumber(int no)
        {
            int sum = 0,actualnum;
            actualnum = no;
            for (int i = 1; i < no; i++)
            {
                if (no % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == actualnum)
            {
                Console.WriteLine($"{actualnum} number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"{actualnum} number is not a perfect number");
                Console.ReadLine();
            }

        }
    }
}
