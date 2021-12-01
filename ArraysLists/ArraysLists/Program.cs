using System;
using System.Collections.Generic;

namespace ArraysLists
{
    class Program
    {
        static void Main()
        {
            //Create the Array of Strings
            string[] myArrayString = new string[] { "Cero", "One", "Two", "Three", "Four", "Five" };
            bool selection1 = true;
            Console.WriteLine("*****Array String Section*****");
            //The next do while statement check if the index selected exist, otherwise ask for other index
            do
            {
                Console.WriteLine("\nChoose a number betwen 0 to 5 ");
                int stringSelected = Convert.ToInt32(Console.ReadLine());
                if (stringSelected >= 0 && stringSelected <= 5)
                {
                    //If the index exist print the index selected
                    Console.WriteLine("You choose: " + myArrayString[stringSelected]);
                    selection1 = false;
                }
                else
                {
                    //The advise that the index doesn't exist
                    Console.WriteLine("The index doesn't exist");
                }
            } while (selection1);

            //Create the Array of Integers
            int[] myArrayInt = new int[] { 0, 10, 200, 300, 400, 50, 60 };
            bool selection2 = true;
            Console.WriteLine("\n\n\n*****Array Int Section*****");
            //The next do while statement check if the index selected exist, otherwise ask for other index
            do
            {
                Console.WriteLine("\nChoose a number betwen 0 to 6");
                int intSelected = Convert.ToInt32(Console.ReadLine());
                if (intSelected >= 0 && intSelected <= 6)
                {
                    //If the index exist print the index selected
                    Console.WriteLine("You choose: " + myArrayInt[intSelected]);
                    selection2 = false;
                }
                else
                {
                    //The advise that the index doesn't exist
                    Console.WriteLine("The index doesn't exist");
                }
            } while (selection2);

            List<string> stringList = new List<string>() {"CERO","UNO","DOS","TRES","CUATRO","CINCO","SEIS"};
            Console.WriteLine("\n\n\n*****List String Section*****");
            bool selection3 = true;
            //The next do while statement check if the index selected exist, otherwise ask for other index
            do
            {
                Console.WriteLine("\nChoose a number betwen 0 to 6");
                int listStringSelected = Convert.ToInt32(Console.ReadLine());
                if (listStringSelected >= 0 && listStringSelected<=6)
                {
                    //If the index exist print the index selected
                    Console.WriteLine("You choose: "+stringList[listStringSelected]);
                    selection3 = false;
                }
                else 
                {
                    //The advise that the index doesn't exist
                    Console.WriteLine("The index doesn't exist");
                }
            } while (selection3);
           

            //Wait to see the result
            Console.ReadLine();

        }
    }
}
