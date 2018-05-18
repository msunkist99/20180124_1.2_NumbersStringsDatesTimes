using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20180124_1._2_NumbersStringsDatesTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadLine();

            Console.WriteLine("Hello Mary!");
            Console.ReadLine();

            var name = "Mary - using variable";
            Console.WriteLine("Hello " + name + "!");
            Console.ReadLine();

            Console.WriteLine($"Hello {name} - using string interpolation");
            Console.ReadLine();

            Console.WriteLine($"Hello {name.ToUpper()} all UPPER case this time");
            Console.ReadLine();

            var names = new List<string> { "Mary", "Felipe", "Emillia" };
            foreach (var individualName in names)
            {
                Console.WriteLine($"Hello {individualName} from foreach loop");

            }
            Console.ReadLine();
        }
    }
}
