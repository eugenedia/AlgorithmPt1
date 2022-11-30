using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Задания по работе с очередями
namespace Queue
{
    class Program : QueueReverse
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

            //Реализация очереди с использованием circular массива
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

            ///////////////////////
            /// Реализация очереди с использованием стека

            Console.WriteLine("----- Реализация очереди с использованием стека");

            QueueWithTwoStacks sq = new QueueWithTwoStacks();
            sq.Enqueue(1);
            sq.Enqueue(2);
            sq.Enqueue(3);
            sq.Enqueue(4);
            sq.Enqueue(5);
            sq.Dequeue();
            sq.Dequeue();
            sq.Enqueue(6);
            sq.Enqueue(7);

            while (!sq.IsEmpty())
            {
                Console.Write(sq.Dequeue() + " ");
            }

            Console.WriteLine();

            sq.Enqueue(1);
            sq.Enqueue(2);
            sq.Enqueue(3);
            sq.Enqueue(4);
            sq.Enqueue(5);
            sq.Dequeue();

            Console.WriteLine($"Peek:  {sq.Peek()}");

            while (!sq.IsEmpty())
            {
                Console.Write(sq.Dequeue() + " ");
            }

            //sq.Dequeue();

            Console.WriteLine();
        }
    }
}
