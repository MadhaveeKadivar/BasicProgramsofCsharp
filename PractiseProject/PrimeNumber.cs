using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class PrimeNumber
    {
        public static void Prime(int no)
        {
            int prime = 0;

            if (no == 0 || no == 1)
            {
                Console.WriteLine($"{no} is not a Prime Number");
            }
            else
            {
                for (int i = 2; i < no; i++)
                {
                    if ((no % i) == 0)
                    {
                        prime = 0;
                        break;
                    }
                    else
                    {
                        prime = 1;
                    }
                }

                if (prime == 1)
                {
                    Console.WriteLine($"{no} is a Prime Number");
                }
                else
                {
                    Console.WriteLine($"{no} is not a Prime Number");
                }
            }
            
        }


    }
}