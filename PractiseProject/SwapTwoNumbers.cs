using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class SwapTwoNumbers
    {
        public int first, second, temp;

        public void SwapNumbers()
        {
            Console.WriteLine("Enter first number : ");
            first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number : ");
            second = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swapping ");

            Console.WriteLine("First number = " + first);
            Console.WriteLine("Second number = " + second);
            temp = first;
            first = second;
            second = temp;

            Console.WriteLine("After Swapped ");

            Console.WriteLine("First number = " + first);
            Console.WriteLine("Second number = " + second);
        }
    }
}
