using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    class Person
    {
        //Property of the class
        public string FistName { get; set; }
        public string LastName { get; set; }

        public void SayName() //This method prints the complete name of the person, using the properties above
        {
            Console.WriteLine("Name: [" + FistName + " " + LastName + "]");
        }
    }
}
