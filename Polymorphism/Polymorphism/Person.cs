using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Person
    {
        //Properties of the class
        public string firstName { get; set; }
        public string lastName { get; set; }


        public abstract void SayName();//Abstract method that must be implemented in inherit clases



    }
}