using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            float weight = float.Parse(Console.ReadLine());//Read the weight and convert the string to float
            if (weight > 50) {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            Console.WriteLine("Please enter the package width:");
            float width = float.Parse(Console.ReadLine());//Read the width and convert the string to float
            Console.WriteLine("Please enter the package height:");
            float height = float.Parse(Console.ReadLine());//Read the height and convert the string to float
            Console.WriteLine("Please enter the package length:");
            float lenght = float.Parse(Console.ReadLine());//Read the length and convert the string to float
            float dimension = width * height * lenght;//Calculate the dimension
            if (dimension > 50){
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            float quote = (weight * dimension) / 100;//Calculate the quote
            Console.WriteLine("Your estimated total for shipping this package is: $"+quote);//Print the result of the quote
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
