using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public abstract class Person
    {
        //Properties of the class
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public abstract void SayName();//Abstract method that must be implemented in inherit clases


    }
}