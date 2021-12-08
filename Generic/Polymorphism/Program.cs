using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee1 = new Employee<string>();
            Employee<int> employee2 = new Employee<int>();

            //employee1.Things.Add("Element 1");
            //for (int i = 0; i < 5;  i++)  
            //{
            //    employee1.Things.Add("Thing "+i);//This assign a list of strings as the property value of "Things"
            //    employee2.Things.Add(i);//This assign a list of integers as the property value of "Things"
                
            //}
                                    
            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine(employee1.Things[j]);
                Console.WriteLine(employee2.Things[j]);
            }
            

           

            Console.ReadLine();
        }
    }
}
