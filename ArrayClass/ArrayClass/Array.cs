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

        private int lastIndex = 0;

        public Array(int n)
        {
            array = new int[n];
        }

        public void Insert(int element)
        {
            if(array.Length == lastIndex)
            {
                int[] internalArray = new int[array.Length * 2];
                for (int i = 0; i < array.Length; i++)
                {
                    internalArray[i] = array[i];
                }
                array = internalArray;
            }
            
            array[lastIndex++] = element;
            
        }

        public void Print()
        {

            for(int i = 0;  i < lastIndex; i++)
            {
                if (i == lastIndex - 1)
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
            if (index <= 0 || index >= lastIndex)
                throw new ArgumentOutOfRangeException();
            
            if( index == lastIndex - 1)
            {
                array[--lastIndex] = 0;
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
            lastIndex--;
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
