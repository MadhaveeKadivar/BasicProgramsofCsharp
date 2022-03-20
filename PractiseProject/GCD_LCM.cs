using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class GCD_LCM
    {
        public static void GCD(int no1,int no2)
        {
            int gcd=1 ;
            for (int i = 1; i <= no1 && i <= no2; i++)
            {
                if (no1 % i == 0 && no2 % i == 0)
                {
                    gcd = i;
                }

            }
            Console.WriteLine($"GCD of {no1} and {no2} is : {gcd}");

        }
        public static void LCM(int no1, int no2)
        {
            int gcd = 1,lcm=0;
            for (int i = 1; i <= no1 && i <= no2; i++)
            {
                if (no1 % i == 0 && no2 % i == 0)
                {
                    gcd = i;
                }
            }
            lcm = (no1 * no2) / gcd;
            Console.WriteLine($"LCM of {no1} and {no2} is : {lcm}");

        }
    }
}
