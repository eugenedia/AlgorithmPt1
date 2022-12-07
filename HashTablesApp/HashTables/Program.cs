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


            /// Проверка работы HashTable

            HashTable ht = new HashTable(5);
            ht.Put(1, "Один");
            ht.Put(2, "Два");
            ht.Put(3, "Три");
            ht.Put(4, "Четыре");
            ht.Put(5, "Пять");
            ht.Put(6, "Шесть");
            ht.Put(7, "Семь");


            for(int i=1; i<=7; i++)
            {
                Console.WriteLine($"for key {i} value is {ht.Get(i)}");
            }

            Console.WriteLine();

            ht.Remove(3);
            ht.Put(3, "еще 3");
            ht.Put(3, "снова 3");

            for (int i = 1; i <= 7; i++)
            {
                Console.WriteLine($"for key {i} value is {ht.Get(i)}");
            }

            ht.Remove(3);
            Console.WriteLine($"for key {3} value is {ht.Get(3)}");

        }
    }
}
