using System.Collections.Generic;

namespace HashTables
{
    
    internal class CharFinder
    {

        //Поиск первого неповторяемого символа с помощью цикла
        public char GetFirstUnrepeatedCharacter(string input)
        {
            bool repeated = false;
            string s = input.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                repeated = false;

                if (s[i] == ' ')
                    continue;

                for (int j = 0; j < s.Length; j++)
                {
                    if ((i == j) || (s[j] == ' '))
                        continue;

                    if (s[i] == s[j])
                    {
                        repeated = true;
                        break;
                    }
                }
                if (!repeated)
                {
                    return s[i];
                }

            }

            return char.MinValue;

        }

        ////Поиск первого неповторяемого символа с помощью Dictionary
        public char GetFirstUnrepeatedCharacterWithDictionary(string input)
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            string s = input.ToLower();


            foreach (char c in s)
            {
                if (dictionary.ContainsKey(c))
                {
                    dictionary[c] = dictionary[c] + 1;
                }
                else
                {
                    dictionary.Add(c, 1);
                }
            }

            foreach(char c in s)
            {
                if (dictionary[c] == 1)
                    return c;
            }

            return char.MinValue;
        }

        //Поиск первого повторяемого символа
        public char GetFirstRepeatedCharacter(string s)
        {
            HashSet<char> hs = new HashSet<char>();

            foreach (char c in s)
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