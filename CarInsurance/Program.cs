using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsurance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to the basic approval program. Please find out if you qaulify for car insurance that you want to select.");
            Console.WriteLine("What is your age please?");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt16(ageStr);

            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\".");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr);

            Console.WriteLine("How many speeding tickets do you have it right now?");
            string speedStr = Console.ReadLine();
            int speed = Convert.ToInt16(speedStr);

            bool qualified = (age > 15 && dui == false && speed <= 3);
            Console.WriteLine("Please see below if you qualify for car insurance or not:");
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
