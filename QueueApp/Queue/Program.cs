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

            QueueWithTwoStacks qwts = new QueueWithTwoStacks();
            qwts.Enqueue(1);
            qwts.Enqueue(2);
            qwts.Enqueue(3);
            qwts.Enqueue(4);
            qwts.Enqueue(5);
            qwts.Dequeue();
            qwts.Dequeue();
            qwts.Enqueue(6);
            qwts.Enqueue(7);

            while (!qwts.IsEmpty())
            {
                Console.Write(qwts.Dequeue() + " ");
            }

            Console.WriteLine();

            qwts.Enqueue(1);
            qwts.Enqueue(2);
            qwts.Enqueue(3);
            qwts.Enqueue(4);
            qwts.Enqueue(5);
            qwts.Dequeue();

            Console.WriteLine($"Peek:  {qwts.Peek()}");

            while (!qwts.IsEmpty())
            {
                Console.Write(qwts.Dequeue() + " ");
            }

            //sq.Dequeue();

            Console.WriteLine();

            PriorityQueueWithArray pq = new PriorityQueueWithArray(6);

            pq.Enqueue(5);
            pq.Enqueue(3);
            pq.Enqueue(2);
            pq.Enqueue(1);
            pq.Enqueue(6);
            pq.Enqueue(7);

            Console.WriteLine($"PriorityQueueWithArray: {pq.ToString()}");
            Console.ReadLine();

        }
    }
}
