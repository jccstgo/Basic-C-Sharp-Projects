using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputParameters
{
    public static class MyStaticClass//This class is static
    {
        public static void AddTwo(int number) //We need to do the method static, this method receive a integer number
        {
            int result = number + 2;
            Console.WriteLine(number+" + 2 = "+result);
        }
    }
}
