using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Construct
    {
        //Constructor chained to the other constructur in the class, but with one parameter, the other by default is "Domingo"
        public Construct(string element1) : this(element1, "Domingo")
        { 
        }
        //Constructor of the class with two parameters
        public Construct(string element1, string element2)
        {
            Console.WriteLine("The element 1 is: {0} and the element 2 is: {1}\n\n",element1, element2);
            Console.Read();
        }
    }
}
