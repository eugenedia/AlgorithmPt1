using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{
    class Program : CharFinder
    {
        static void Main(string[] args)
        {
            

            string s = "A Green Apple";

            CharFinder cf = new CharFinder();

            Console.WriteLine($"First non repeated char {cf.GetFirstUnrepeatedCharacter(s)}");
            Console.WriteLine($"First non repeated char {cf.GetFirstUnrepeatedCharacterWithDictionary(s)}");


            Console.WriteLine($"First repeated char {cf.GetFirstRepeatedCharacter(s)}");

        }
    }
}
