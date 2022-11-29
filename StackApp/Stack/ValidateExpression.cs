using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class ValidateExpression
    {
        public static bool Validate(string s)
        {
            Stack<char> st = new Stack<char>();
            string openBrackets = "[{<(";
            string closeBrackets = "]}>)";

            foreach (char c in s.ToCharArray())
            {
                if (openBrackets.Contains(c))
                {
                    st.Push(c);
                    continue;
                }

                if (closeBrackets.Contains(c))
                {
                    if (st.Count == 0)
                        return false;

                    char ob = st.Pop();
                    int obi = openBrackets.IndexOf(ob);
                    int cbi = closeBrackets.IndexOf(c);

                    if (obi == cbi)
                        continue;
                    else
                        return false;
                }

            }
            return st.Count == 0;
        }
    }
}
