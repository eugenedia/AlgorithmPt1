using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program : NonRepeatedCharFinder
    {
        static void Main(string[] args)
        {
            

            string s = "A Green Apple";

            NonRepeatedCharFinder nr = new NonRepeatedCharFinder();

            Console.WriteLine($"First non repeated char {nr.GetCharManual(s)}");
            Console.WriteLine($"First non repeated char {nr.GetCharWithDictionary(s)}");

            RepeatedCharFinder rc = new RepeatedCharFinder();

            Console.WriteLine($"First repeated char {rc.GetCharWithSet(s)}");

        }
    }
}
