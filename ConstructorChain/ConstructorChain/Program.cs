using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            const string constante = "This is an example about const variable";//Const variable of type string
            Console.WriteLine(constante);//Print the const named "constante"

            //Create a variable (List of strings) using "var"
            var variable = new List<string>() {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes","Sabado" };
            Construct construct1 = new Construct(variable[0]);
            Construct construct2 = new Construct(variable[0], variable[3]);

        }
    }
}
