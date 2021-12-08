using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of employees 
            List<Employee> employees = new List<Employee>()
            {
                new Employee() {FirstName = "Joe", LastName="Cruz", Id=1 },
                new Employee() {FirstName = "Jose", LastName="Santiago", Id=2 },
                new Employee() {FirstName = "Joe", LastName="Santiago", Id=3 },
                new Employee() {FirstName = "Carlos", LastName="Casique", Id=4 },
                new Employee() {FirstName = "Karim", LastName="Bollas", Id=5 },
                new Employee() {FirstName = "David", LastName="Smith", Id=6 },
                new Employee() {FirstName = "Joe", LastName="Reyes", Id=7 },
                new Employee() {FirstName = "Engels", LastName="Molina", Id=8 },
                new Employee() {FirstName = "Mayra", LastName="Sanchez", Id=9 },
                new Employee() {FirstName = "Karen", LastName="Perez", Id=10 }
            };

            //In this section we create a new list of employees with the first name "Joe" 
            Employee tmpEmployee;
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")//If the first name is Joe then add to tmpEmployee
                {
                    tmpEmployee = employee;
                    Console.WriteLine("The new employee in the list: "+tmpEmployee.FirstName+" "+tmpEmployee.LastName+" "+tmpEmployee.Id+ "\n");
                }                    
            }

            Console.WriteLine("\n\n*******LAMBDA**********");
            
            //Lambda statement that create a new list of employees with the firs name "Joe" 
            List<Employee> listJoe = employees.Where(x => x.FirstName == "Joe").ToList();
            
            Console.WriteLine("\n*******JOE**********");
            //This prints the elements in "listJoe"
            foreach (Employee employeeLambda in listJoe) 
            {
                Console.WriteLine("\nThe new employee in the list: " + employeeLambda.FirstName + " " + employeeLambda.LastName + " " + employeeLambda.Id);
            }


            //Lambda statement that create a new list of employees with an Id number greater than 5.
            List<Employee> listGrather5 = employees.Where(x => x.Id > 5).ToList();

            Console.WriteLine("\n\n*******GRATHER 5**********");
            //This prints the elements in "listGrather5"
            foreach (Employee listGratherLambda in listGrather5)
            {
                Console.WriteLine("\nThe new employee in the list: " + listGratherLambda.FirstName + " " + listGratherLambda.LastName + " " + listGratherLambda.Id);
            }

            Console.ReadLine();
        }
    }
}
