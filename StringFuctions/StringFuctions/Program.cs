using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFuctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Carlos";
            //string quote = "The man said, \"Hello\"";
            //string fileName = @"\:a|";
            //bool tf = name.Contains("s");
            //string r = name.ToUpper();
            //Console.WriteLine(r);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            sb.Append("My name is Carlos");
            sb.Append("My lastname is Cruz");
            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
