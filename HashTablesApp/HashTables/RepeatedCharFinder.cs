using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTables
{ 
    // Задача по возвращению первого повторяющегося символа
    class RepeatedCharFinder
    {
        public char GetCharWithSet(string s)
        {
            HashSet<char> hs = new HashSet<char>();

            foreach(char c in s)
            {
                if (hs.Contains(c) && c != ' ')
                    return c;
                else
                    hs.Add(c);
            }

            return char.MinValue;
        }
    }
}
