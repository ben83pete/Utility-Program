using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenUtilityLibrary;

namespace TestBenUtility
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = Strings.EqualIgnoreCase("ABC", "abc");
            if (result) { // [ if (result) ] is the same as [ if (result == true) ]
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("not Equal");
            }
            Console.ReadKey();
        }
    }
}
