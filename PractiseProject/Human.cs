using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProject
{
    internal class Human
    {
        public string Name = "Madhavee";
        public long phonenumber = 9999999999;

        public static void Speak()
        {
            Console.WriteLine("He/She can speak");
        }
        public void HumanDetails()
        {
            Console.WriteLine($"Name : {Name}  PhoneNumber : {phonenumber}");
        }
    }
}
