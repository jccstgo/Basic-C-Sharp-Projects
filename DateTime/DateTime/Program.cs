using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current date is: "+ DateTime.Now);//Prints the current date and time 
            
            //Get a number from the user
            Console.WriteLine("\n\nWrite a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Adds the number (to the hours) to the current date  
            Console.WriteLine("in {0} hours the date will be: {1}", number,DateTime.Now.AddHours(number));
            Console.Read();
        }
    }
}
