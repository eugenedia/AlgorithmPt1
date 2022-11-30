using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    //Реализация очереди с использованием двух стеков
    public class QueueWithTwoStacks
    {
        private Stack<int> inStack = new Stack<int>();
        private Stack<int> outStack = new Stack<int>();


        public void Enqueue(int i)
        {
            inStack.Push(i);
        }


        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (outStack.Count == 0)
            {
                while (inStack.Count != 0)
                {
                    outStack.Push(inStack.Pop());
                }
            }

            return outStack.Pop();
        }

        public bool IsEmpty()
        {
            return outStack.Count == 0 && inStack.Count == 0;
        }


        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            CopyStacks();

            return outStack.Peek();
        }

        private void CopyStacks()
        {
            if (outStack.Count == 0)
            {
                while (inStack.Count != 0)
                {
                    outStack.Push(inStack.Pop());
                }
            }
        }
    }
}
