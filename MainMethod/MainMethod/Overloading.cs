using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Overloading
    {
        //First method that recives an integer
        public int Operation(int number) 
        {
            number += 2;//Add 2
            return number;//return the result as a integer
        }

        //Second method that recives an decimal
        public int Operation(decimal number)
        {
            number *= 2;//Multiply the number (decimal) by 2
            return (int)number;//Explicit cast to int, in order to return an integer
        }

        //The third method that recives an string
        public int Operation(string number)
        {            
            int tmpNumber = Convert.ToInt32(number)-2;//Converts an the string to integer an subtract 2
            return tmpNumber;//return the result as a integer
        }
    }
}
