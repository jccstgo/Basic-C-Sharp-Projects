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
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rate1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            int annualSalary1 = rate1 * hoursPerWeek1*52;
            Console.WriteLine("Annual Salary of Person 1: "+annualSalary1);
            int annualSalary2 = rate2 * hoursPerWeek2*52;
            Console.WriteLine("Annual Salary of Person 2: "+annualSalary2);
            bool trueOrFalseMoney = annualSalary1 > annualSalary2;
            Console.WriteLine("Does Person 1 make more money than Person 2?"+trueOrFalseMoney);
            Console.ReadLine();
        }
    }
}
