using System.Collections.Generic;

namespace Queue
{
    internal class QueueReverse
    {


        // Задача по обращению очереди
        public static void Reverse(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count != 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
    }
}