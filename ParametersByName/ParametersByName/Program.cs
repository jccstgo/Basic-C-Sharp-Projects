using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersByName
{
    class Program
    {
        static void Main(string[] args)
        {
            Names name = new Names();//Intantiate the Class "Names"
            name.Operation(number_1: 3, number_2: 13);//Call the method "Operations" specifying the parameters by name
        }
    }
}
