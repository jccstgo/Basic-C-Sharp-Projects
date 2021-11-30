using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Person 1 section
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());//We read and convert the string input to int (Rate)
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());//We read and convert the string input to int (Hours per week)
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());//We read and convert the string input to int (Rate)
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());//We read and convert the string input to int (Hours per week)
            int annualSalary1 = rate1 * hoursPerWeek1*52;//Multiply the hours, rate and 52 (weeks per year) Person 1
            Console.WriteLine("Annual Salary of Person 1: "+annualSalary1);
            int annualSalary2 = rate2 * hoursPerWeek2*52;//Multiply the hours, rate and 52 (weeks per year) Person 2
            Console.WriteLine("Annual Salary of Person 2: "+annualSalary2);
            bool trueOrFalseMoney = annualSalary1 > annualSalary2; // Comparition betwen annual salary of Person 1 and Person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?"+trueOrFalseMoney);
            Console.ReadLine();
        }
    }
}
