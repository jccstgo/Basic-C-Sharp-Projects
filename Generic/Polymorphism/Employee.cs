﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Employee<T> : Person, IQuittable//Inherit from the Class Person and the IQuittable interface (must be implemented the method Quit)
    {
        public void Quit(string message)//This method is mandatory due to the implementation of the interface IQuittable 
        {
            Console.WriteLine(message);//Print the message
        }

        public int Id { get; set; }//This is a property named "Id"
        public List<T> Things { get; set; }//This property is a generic list

        public override void SayName()//Override the SayName method from the abstract method in the Class Person
        {
            Console.WriteLine("The name is====>");
            Console.WriteLine("Name: " + firstName + " " + lastName+" Id: "+ Id+"\n\n");   //Print the name of the employee     
        }

        

    }
}