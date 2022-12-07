using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Trees
{
    //Реализация бинарного дерева
    public class Tree
    {
        private class Node
        {
            public int Value { get; set; }
            public Node LeftChild { get; set; }
            public Node RightChild { get; set; }

            public Node(int value)
            {
                Value = value;
            }

            public override string ToString()
            {
                return "Node=" + Value;
            }
        }

        private Node root;

        //Вставка в дерево
        public void Insert(int value)
        {
            Node node = new Node(value);

            if(root == null)
            {
                root = node;
                return;
            }

            Node current = root;
            while (current != null)
            {
                if (current.Value == value)
                    return;

                if(value < current.Value)
                {
                    if (current.LeftChild == null)
                    {
                        current.LeftChild = node;
                        return;
                    }
                        
                    current = current.LeftChild;

                    continue;
                }

                if(value > current.Value)
                {
                    if (current.RightChild == null)
                    {
                        current.RightChild = node;
                        return;
                    }

                    current = current.RightChild;
                }
            }

        }

        //Проверка наличия элемента в дереве
        public bool Find(int value)
        {
            
            if(root == null)
            {
                throw new InvalidOperationException();
            }
            
            Node current = root;

            while( current != null)
            {
                if (current.Value == value)
                    return true;

                if (value < current.Value)
                {
                    current = current.LeftChild;
                    continue;
                }
                    

                if (value > current.Value) 
                {
                    current = current.RightChild;
                    continue;
                }

            }

            return false;

        }

        //Обход дерева в порядке - root, left, right PreOrderTraversal
        private void TraversePreOrder(Node node)
        {
            if (node == null)
                return;

            Console.WriteLine(node);

            TraversePreOrder(node.LeftChild);
            TraversePreOrder(node.RightChild);

        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        //Обход дерева в порядке left, root, right InOrderTraversal
        private void TraverseInOrder(Node node)
        {
            if (node == null)
                return;
            
            TraverseInOrder(node.LeftChild);

            Console.WriteLine(node);

            TraverseInOrder(node.RightChild);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        //Обход дерева в порядке left, right, root TraversePostOrder
        private void TraversePostOrder(Node node)
        {
            if (node == null)
                return;
            
            TraversePostOrder(node.LeftChild);
            TraversePostOrder(node.RightChild);
            
            Console.WriteLine(node);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }
        
    }
}
