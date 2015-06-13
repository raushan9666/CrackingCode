using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrackingTheCoding
{
    class Program
    {
        static void Main(string[] args)
        {
            replaceAllEmptyWith obj = new replaceAllEmptyWith();
            Console.WriteLine(obj.replace("Mr John Smith"));
            Console.WriteLine(obj.replace("Mr  John Smith"));
            Console.ReadLine();
        }
    }
}
