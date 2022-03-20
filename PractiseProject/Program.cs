using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int choice,c=1;
            while (c==1)
            {
                Console.WriteLine();
                Console.WriteLine("*********Basic C sharp Program**********");
                Console.Write("1.HumanDetails \n2.Swap Two Numbers \n3.Find Factorial of Number\n");
                Console.Write("4.Find Reverse of Number\n5.Find number is Prime or not\n");
                Console.WriteLine("6.Find Number is Armstrong or not\n7.Find number is Perfect or not\n8.GCD and LCM of two number");
                Console.WriteLine("Enter any choice : ");
                choice=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        Human human = new Human();
                        human.HumanDetails();
                        Human.Speak();
                        break;
                    case 2:
                        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                        swapTwoNumbers.SwapNumbers();
                        break;
                    case 3:
                        Console.WriteLine("Enter Any you want to get factorial : ");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        Factorial.FindFactorial(numb);
                        break;
                    case 4:
                        Console.WriteLine("Enter any number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        ReverseNumber.FindReverseofNumber(num);
                        break;
                    case 5:
                        Console.WriteLine("Enter any number : ");
                        int no = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber.Prime(no);
                        break;
                    case 6:
                        ArmstrongNumber armstrongNumber = new ArmstrongNumber();                 
                        Console.WriteLine("Enter any number : ");
                        int number = Convert.ToInt32(Console.ReadLine());
                        armstrongNumber.Armstrong(number);
                        break;
                    case 7:
                        Console.WriteLine("Enter any number : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber.Perfectnumber(n);
                        break;
                    case 8:
                        Console.WriteLine("Enter first number : ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter second number : ");
                        int n2 = Convert.ToInt32(Console.ReadLine());
                        GCD_LCM.GCD(n1,n2);
                        GCD_LCM.LCM(n1, n2);
                        break;

                default:

                        Console.WriteLine("Please enter valid option");
                        break;
                }
                   
                Console.WriteLine("\nPress 1 to continue or Press any key to exit");
                c = Convert.ToInt32(Console.ReadLine());        
            }
            Console.Read();
            //Console.WriteLine("Practise Project");
            //Console.WriteLine("Adding just one line from local");
            //Console.WriteLine("Adding just one line from remote");
            //Console.WriteLine("Creating conflict from local");
            //Console.WriteLine("Creating conflict from remote");






        }
    }
}

