using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private int[] array = new int[2];
        private int count = 0;

        public void Push(int e)
        {
            if (count >= array.Length)
                ResizeArray();
            array[count++] = e;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new ArgumentNullException();

            int v = array[count - 1];
            array[count-- - 1] = 0;

            return v;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new ArgumentNullException();

            return array[count - 1];
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        private void ResizeArray()
        {
            int[] a = new int[count*2];

            for (int i = 0; i < count; i++)
                a[i] = array[i];

            array = a;
        }
    }
}
