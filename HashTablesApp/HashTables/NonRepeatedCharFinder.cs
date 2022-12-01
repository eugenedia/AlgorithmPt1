using System.Collections.Generic;

namespace HashTables
{
    //Поиск первой неповторяемой буквы в строке без учета регистра
    internal class NonRepeatedCharFinder
    {

        //С помощью цикла
        public char GetCharManual(string input)
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

        //С помощью dictionary
        public char GetCharWithDictionary(string input)
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
    }
}