using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ask the user about the current day
                Console.WriteLine("Input the current day of the week");
                string currentDay = Console.ReadLine();//Read the answer (string)
                DaysOfTheWeek dotw = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), currentDay);//Parse the "cyrrentDay" to a type DaysOfTheWeek
                Console.WriteLine("\n\nThe current day is: "+dotw);//Prints the day of the week
                Console.ReadLine();
            }
            catch (Exception ex) //If occurs an error with the parse the next code is executed
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }

            
        }
        public enum DaysOfTheWeek 
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday, 
            Saturday        
        }
    }
}
