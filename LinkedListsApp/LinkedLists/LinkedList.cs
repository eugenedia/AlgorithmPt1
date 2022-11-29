using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class LinkedList
    {
        private Node first;
        private Node last;

        private int size;

        public void AddFirst(Node node)
        {
            if (first == null)
            {
                first = node;
                last = node;
                size++;
                return;
            }

            Node next = first;

            node.next = first;
            first = node;

            size++;
        }

        public void AddLast(Node node)
        {
            if (last == null)
            {
                last = node;
                first = node;
                size++;
                return;
            }


            last.next = node;
            last = node;

            size++;
                
        }

        public void DeleteFirst()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
            {
                first = last = null;
                size = 0;
                return;
            }

            Node node = first.next;

            first.next = null;

            first = node;
            size--;
        }

        public void DeleteLast()
        {
            if (IsEmpty())
                throw new InvalidOperationException();

            if (first == last)
            {
                first = last = null;
                size = 0;
                return;
            }
            
            Node node = first;
            Node penalt; // предпоследняя нода.

            while(node != null)
            {
                penalt = node;
                node = node.next;

                if (node == last)
                {
                    last = penalt;
                    last.next = null;
                    size--;
                    return;
                }
                    
            }
        }

        public bool Contains(int value)
        {
            Node node = first;

            do
            {
                if (node.value == value)
                    return true;
                node = node.next;
            } while (node != null);

            return false;
        }

        public int IndexOf(int value)
        {
            Node node = first;
            int i = 0;

            while (true)
            {
                if (node.value == value)
                    return i;

                if (node == last)
                    break;

                node = node.next;
                i++;
            }
            return -1;
        }

        

        public void Print()
        {
            Node node = first;
            do
            {
                Console.WriteLine("node value = " + node.value);
                

                if (node == last)
                    break;

                node = node.next;
            } while (true);

            Console.WriteLine("--------------");
        }

        public int Size()
        {
            return size;
        }

        private bool IsEmpty()
        {
            return first == null;
        }

        public int [] ToArray()
        {
            int[] array = new int[size];
            int i = 0;

            Node node = first;

            while(node != null)
            {
                array[i++] = node.value;
                node = node.next;
            }

            return array;
        }


        public void Reverse()
        {
            Node firstOfReverse = null;
            //firstOfReverse.value = last.value;
            Node lastOfReverse = null;

            Node node = first;

            while(node != null )
            {
                Node reverseNode = new Node(node.value);
                if (node == first)
                    lastOfReverse = reverseNode;

                reverseNode.next = firstOfReverse;
                firstOfReverse = reverseNode;

                node = node.next;
            }

            first = firstOfReverse;
            last = lastOfReverse;
        }


        public void Reverse1()
        {
            Node node = first;
            last = first;

            while(node != null)
            {
                if (node == first)
                {
                    node = node.next;
                    first.next = null;
                    continue;
                }

                Node newNode = new Node(node.value);
                newNode.next = first;
                first = newNode;

                //node.next
                
                node = node.next;


            }

            
        }

        public void Reverse2()
        {
            Node node = first;
            last = first;
            Node nextNode;

            while (node != null)
            {
                if (node == first)
                {
                    node = node.next;
                    first.next = null;
                    continue;
                }


                nextNode = node.next;

                node.next = first;
                first = node;

                node = nextNode;

            }


        }

        public int NthNodeFromEnd(int nodeNumber)
        {
            Node fp = first;
            Node sp = first;

            if (IsEmpty())
                throw new InvalidOperationException();

            if (nodeNumber > size)
                throw new ArgumentOutOfRangeException();

            while (nodeNumber - 1 > 0)
            {
                sp = sp.next;
                nodeNumber--;
                if (sp == null)
                    return -1;
            }
                
            while (sp != null)
            {
                sp = sp.next;
                
                if (sp == null)
                    return fp.value;
                fp = fp.next;
            }

            return -1;
        }

    }
}
