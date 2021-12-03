using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOptionalParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Optional optional = new Optional();//Instantiate the Class "Optional"
            
            Console.WriteLine("This program calculates if two years is a leap year.");
            
            //Ask and read the first year
            Console.Write("\n\nInput the firs year: ");
            int year_1 = Convert.ToInt32(Console.ReadLine());//Convert the input in type integer

            //Aks the user if want to introduce another year
            Console.WriteLine("\n\nIf you want to introduce another year, write: \"Yes\"");
            string another = Console.ReadLine().ToUpper();//Read and convert to upper case the answer 


            if (another == "YES")//If the user wants to introduce another year, we ask for this
            {
                Console.WriteLine("\nInput the second year(is optional introduce it): ");
                int year_2 = Convert.ToInt32(Console.ReadLine());//Convert the input in type integer
                int isLeap = optional.LeapYear(year_1, year_2);//WE USE THE METHOD "LeapYear" WITH TWO PARAMETERS
                if (isLeap == 1)//If the variable "isLeap" is 1 the year_1 and year_2 are leap
                {
                    Console.WriteLine("The years " + year_1 + " and " + year_2 + " are leap");
                }
                else if (isLeap == 2)//If the variable "isLeap" is 2 only the year_1 is leap
                {
                    Console.WriteLine("The year " + year_1 + " is leap and the year " + year_2 + " isn't leap");
                }
                else if (isLeap == 3)//If the variable "isLeap" is 3 only the year_2 is leap
                {
                    Console.WriteLine("The year " + year_2 + " is leap and the year " + year_1 + " isn't leap");
                }
                else//Else, no one of the years are leap
                {
                    Console.WriteLine("The year " + year_1 + " and " + year_2 + "aren't leap");
                }
            }
            else //And the other hand if the user only want use a number we do 
            {
                optional.LeapYear(year_1);
                int isLeap = optional.LeapYear(year_1);//WE USE THE METHOD "LeapYear" WITH ONE PARAMETERS
                if (isLeap == 1)//If the variable "isLeap" is 1 the year_1 and year_2 are leap
                {
                    Console.WriteLine("The years " + year_1 + " and 2022 are leap");
                }
                else if (isLeap == 2)//If the variable "isLeap" is 2 only the year_1 is leap
                {
                    Console.WriteLine("The year " + year_1 + " is leap and the year 2022 isn't leap");
                }
                else if (isLeap == 3)//If the variable "isLeap" is 3 only the year_2 is leap
                {
                    Console.WriteLine("The year 2022 is leap and the year " + year_1 + " isn't leap");
                }
                else//Else, no one of the years are leap
                {
                    Console.WriteLine("The year " + year_1 + " and 2022 aren't leap");
                }
            }
            Console.ReadLine();
            

        }
    }
}
