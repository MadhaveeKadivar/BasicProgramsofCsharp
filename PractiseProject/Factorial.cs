using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    class Factorial
    {
      
        public static void FindFactorial(int n)
        {
            int fact = 1;

           

            if (n == 0 || n == 1)
            {
                Console.WriteLine($"Factorial of {n} is : 1");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }
                Console.WriteLine($"Factorial of {n} is : {fact}");
            }
           
        }
    }
}
