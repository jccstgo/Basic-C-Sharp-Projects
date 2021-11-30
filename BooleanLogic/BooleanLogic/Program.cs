using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BOOLEAN LOGIC SUBMISSION");
            Console.WriteLine("What is your age?");
            //Read and convert to int the age 
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI?, Answer \"true\" or \"false\"");
            //Read and convert to bool the dui 
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            //Read and convert to int the tickets 
            int tickets = Convert.ToInt32(Console.ReadLine());
            //Compare if the age is over 15 years old AND not have any DUI's AND not have more than 3 speeding tickets
            bool qualified = (age > 15) && (!dui) && (tickets<3);
            Console.WriteLine("Qualified?");
            Console.WriteLine(qualified);

            Console.ReadLine();
        }
    }
}
