using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                MyClass myClass = new MyClass();//Instanse to the Class "MyCalss"

                //The user have to input a integer number
                Console.WriteLine("Select a integer number: ");
                int selectedNumber = Convert.ToInt32(Console.ReadLine());

                int outputNumber = 0;
                //This method have two parameter one is the input (selectedNumber) and the other is the output (outputNumber)
                myClass.DivideByTwo(selectedNumber, out outputNumber);
                Console.WriteLine("The result of divide the number by 2 is: " + outputNumber);//Print the result of the operation

                //This is an example about overload a method, the first method don't have parameters and the other have one parameter of input
                myClass.MultiplyByTwo();//The result of this method is printed in the class "MyClass"
                myClass.MultiplyByTwo(9);//The result of this method is printed in the class "MyClass

                MyStaticClass.AddTwo(19);//This is an example when a Class is static, we only use the methos without instances 
                


            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadLine();
        }
    }
}
