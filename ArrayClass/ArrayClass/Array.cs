using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    /// <summary>
    /// Реализация динамического массива
    /// </summary>
    public class Array
    {
        private int [] array;

        private int lastElement = 0;

        public Array(int n)
        {
            array = new int[n];
        }

        public void Insert(int element)
        {
            if(lastElement < array.Length)
                array[lastElement++] = element;
            else
            {
                int[] internalArray = new int[array.Length*2];
                for(int i = 0; i < array.Length; i++)
                {
                    internalArray[i] = array[i];
                }
                internalArray[lastElement++] = element;
                array = internalArray;
            }
        }

        public void Print()
        {

            for(int i = 0;  i < lastElement; i++)
            {
                if (i == lastElement - 1)
                {
                    Console.Write(array[i]);
                    continue;
                }

                Console.Write(array[i] + ", ");
            }

            Console.Write("\n");
        }

        public void RemoveAt(int index)
        {
            if (index <= 0 || index >= lastElement)
                throw new ArgumentOutOfRangeException();
            
            if( index == lastElement - 1)
            {
                array[--lastElement] = 0;
                return;
            }

            int[] internalArray = new int[array.Length - 1];
            int j = 0;
            for(int i=0; i< array.Length; i++)
            {
                if (i == index)
                    continue;
                internalArray[j++] = array[i];
            }
            array = internalArray;
            lastElement--;
        }

        public int IndexOf(int element)
        {
            int i = 0;

            foreach(int item in array)
            {
                if (item == element)
                    return i;
                i++;
            }
            return -1;
        }
    }
}
