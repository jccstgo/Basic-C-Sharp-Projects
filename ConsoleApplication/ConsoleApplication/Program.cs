using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int multiplies = input % 7;
            Console.WriteLine("Result Multiplies: "+multiplies);
            Console.ReadLine();
            
        }
    }
}
