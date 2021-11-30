using System;


namespace MathChallenge
{
    class Program
    {
        static void Main()
        {
            int numA = 6;
            int numB = 2;
            int totalAdd = numA + numB;
            Console.WriteLine("Add: "+totalAdd);
            int totalSubstract = numA - numB;
            Console.WriteLine("Substract: "+totalSubstract);
            int totalMultiply = numA * numB;
            Console.WriteLine("Multiply: "+ totalMultiply);
            int totalDivide = numA / numB;
            Console.WriteLine("Divide: " + totalDivide);
            Console.ReadLine();
        }
    }
}
