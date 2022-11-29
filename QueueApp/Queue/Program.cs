using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задания по работе с очередями
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача по обращению очереди
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Print();

            Reverse(queue);

            queue.Print();

            /////////////////

            //Реализация очереди с использованием массива
            ArrayQueue aq = new ArrayQueue(5);

            aq.Enqueue(1);
            aq.Enqueue(2);
            aq.Enqueue(3);
            aq.Enqueue(4);
            aq.Enqueue(5);
            //aq.Enqueue(6);

            while (!aq.IsEmpty())
            {
                Console.Write(aq.Dequeue() + ", ");
            }

            aq.Enqueue(1);
            aq.Enqueue(2);
            aq.Enqueue(3);
            aq.Enqueue(4);
            aq.Enqueue(5);
            aq.Dequeue();
            aq.Dequeue();
            aq.Enqueue(6); 
            aq.Enqueue(7);
            Console.WriteLine($"Внутренний массив: {aq.ToString()}");
            Console.WriteLine($"Deque: {aq.Dequeue()}");
            Console.WriteLine($"Внутренний массив: {aq.ToString()}");
        }


        // Задача по обращению очереди
        public static void Reverse(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while(queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }

            while(stack.Count != 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

    }
}
