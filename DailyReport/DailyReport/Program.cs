using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            //This program is a Daily Report Submission
            Console.WriteLine("The Tech Academy.\n");
            Console.WriteLine("Student Daily Report.");
            
            //Questions/Answers section
            Console.WriteLine("What is your name?"); //Print the Question
            string name = Console.ReadLine(); //Read the answer
            
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
            string help = Console.ReadLine();
            //This convert the string answer to boolean
            bool helpAnswer = Convert.ToBoolean(help);
            
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            
            Console.WriteLine("How many hours did you study today?");
            string hours = Console.ReadLine();
            //End of the Questions/Answers section 
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            
            Console.ReadLine();//We wait until a key is pressed
        }
    }
}
