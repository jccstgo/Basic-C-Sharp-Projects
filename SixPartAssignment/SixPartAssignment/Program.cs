using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixPartAssignment
{
    class Program
    {
        static void Main()
        {
            //One-dimensional array of strings
            string[] myStrings = new string[] { "Cero", "One", "Two", "Three", "Four", "Five" };

            //Ask the user to input some text
            Console.WriteLine("\nInput some text: ");
            string text = Console.ReadLine();

            //In this for statement add the user's text to each string in the array myStrings
            for (int i = 0; i < myStrings.Length; i++)
            {
                myStrings[i] += " " + text;
            }

            //This loop (foreach statement) prints off each string in the array
            foreach (string myString in myStrings)
            {
                Console.WriteLine(myString + "\n");
            }

            int j = 0;
            //This do while statement prints 5 times "Loop fixed"
            do
            {
                Console.WriteLine("Loop fixed");
                j += 1;//If this line is eliminated the loop is infinite
            } while (j < 5);

            //This loop use the "<" operator 
            int k = 0;
            while (k < 3)
            {
                Console.WriteLine("The index \"k\" is equal to: " + k);
                k += 1;
            }

            //This loop use the "<=" operator
            int l = 0;
            while (l <= 3)
            {
                Console.WriteLine("The index \"l\" is equal to: " + l);
                l += 1;
            }

            //List of strings where each item in the list is unique
            List<string> myListStrings = new List<string>() { "alfa", "beta", "gama", "delta", "epsilon", "dseta", "eta" };
            //Ask the user to input some text to search for in the list of strings YOU CULD SEARCH "et" FOR EXAMPLE
            Console.WriteLine("\nInput text to search for in the list of strings: ");
            string text2 = Console.ReadLine();
            bool textIsInTheList = false;//This is a flag to know if the text exist in the list
            for (int m = 0; m < myListStrings.Count; m++)
            {
                if (myListStrings[m].Contains(text2))//Compare if the element in the list contains the user's text
                {
                    Console.WriteLine("The index is: " + m);
                    textIsInTheList = true;//Flag that indicate that a match has been found
                    break;//Stop the for loop when once a match has been found
                }
                //Compare the flag "textIsInTheList" is "false" and if it is the last element in the list (in order to show only one time the advise)
                else if ((!textIsInTheList) && (m + 1 == myListStrings.Count))
                {
                    Console.WriteLine("Input text is not in the list");
                }
            }

            //List of strings that has identical strings in the list
            List<string> myStringTwoIdenticals = new List<string>() { "JOSE", "CARLOS", "CRUZ", "SANTIAGO", "CARLOS", "CRUZ" };
            Console.WriteLine("\nInput a text to search for in a new list that has identical strings: ");
            string text3 = Console.ReadLine();
            bool textIsInTheList2 = false;//This is a flag to know if the text exist in the list
            //Loop iterate through the list and display the indices of the items matching th user selected text.
            for (int n = 0; n < myStringTwoIdenticals.Count; n++)
            {
                //Change the input text to uppercase and compare if is contained for the element in the list
                if (myStringTwoIdenticals[n].Contains(text3.ToUpper()))
                {
                    Console.WriteLine("The index found is: " + n);
                    textIsInTheList2 = true;//Flag that indicate that a match has been found
                }
                // Compare the flag "textIsInTheList2" is "false" and if it is the last element in the list(in order to show only one time the advise)
                else if ((!textIsInTheList2) && (n + 1 == myStringTwoIdenticals.Count))
                {
                    Console.WriteLine("Input text is not in the list =)");
                }
            }

            //List of strings that has identical strings in the list
            List<string> myStringTwoIdenticals_2 = new List<string>() { "aries", "taurus", "gemini", "cancer", "leo", "virgo", "aries", "taurus", "gemini","aries" };
            List<string> myNewString = new List<string>();
            //This foreach evaluates each item in the string list 
            foreach (string myStringTwoIdentical2 in myStringTwoIdenticals_2) 
            {
                Console.WriteLine("\nThe element in the list is: " + myStringTwoIdentical2);//Print the element in the list
                //This if evaluuates if the element already appeared in the list and show the advise
                if (myNewString.Contains(myStringTwoIdentical2))
                {
                  
                    Console.WriteLine("This element already has appeared in the list");
                }
                //The element is added to another list in order to know if this element is new in the list or already appeared previously
                else
                {
                    myNewString.Add(myStringTwoIdentical2);
                }
            }

            Console.ReadLine();

        }
    }
}
