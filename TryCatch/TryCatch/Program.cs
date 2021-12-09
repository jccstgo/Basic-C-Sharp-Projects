using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What is your age? ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                DateTime year = DateTime.Now.AddYears(-age);
                Console.WriteLine("You was born in the year: {0}", year.Year);
                Console.ReadLine();
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The age must be a positive number");
                Console.ReadLine();
            }
            catch (Exception) 
            {
                Console.WriteLine("An error occurring");
                Console.ReadLine();
            }
            
        }
    }
}
