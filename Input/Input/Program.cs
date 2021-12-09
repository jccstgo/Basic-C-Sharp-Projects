using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter logFileNumber = new StreamWriter(@"C:\Users\Jose Carlos\Documents\Log Number.txt", true))
            {
                logFileNumber.WriteLine(number);
            }
            string textFile = File.ReadAllText(@"C:\Users\Jose Carlos\Documents\Log Number.txt");
            Console.WriteLine("\n\n"+textFile);
            Console.Read();
        }
    }
}
