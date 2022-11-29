using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    //Реализация очереди с использованием circular массива
    public class ArrayQueue
    {
        private int[] array;

        private int begin = 0;
        private int end = 0;
        private int count = 0;

        public ArrayQueue(int size)
        {
            array = new int[size];
        }

        public void Enqueue(int i)
        {
            if (count == array.Length)
                throw new InvalidOperationException();

            array[end] = i;
            end = (end + 1) % array.Length;
            count++;
        }

        public int Dequeue()
        {
            int val = array[begin];
            array[begin] = 0;
            count--;
            begin = (begin + 1) % array.Length;
            return val;

        }

        public int Peek()
        {
            return array[begin];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == array.Length;
        }

        public override string ToString()
        {
            return string.Join(",", array);
        }

    }
}
