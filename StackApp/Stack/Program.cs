using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(String.Join(",", stack.ToArray()));

            String s = "hello";

            char[] sa = s.ToCharArray();
            //char[] rsa;

            Stack<char> cS = new Stack<char>();

            //foreach (char c in sa)
            //    cS.Push(c);
            //rsa = cS.ToArray();

            for(int i=0; i<s.Length; i++)
            {
                cS.Push(s[i]);
            }

            Console.WriteLine(new string(cS.ToArray()));


            //string expression = "<>(1+2){}(";
            string expression = ")(";

            Console.WriteLine(ValidateExpression.Validate(expression));


            Stack mStack = new Stack();
            mStack.Push(1);
            mStack.Push(2);
            mStack.Push(3);
            mStack.Push(4);
            mStack.Push(5);
            mStack.Push(6);
            mStack.Push(7);
            mStack.Push(8);
            mStack.Push(9);
            mStack.Push(10);

            Console.WriteLine(mStack.Pop());
            Console.WriteLine(mStack.Pop());
            Console.WriteLine(mStack.Pop());
            Console.WriteLine(mStack.Peek());
        }
    }
}
