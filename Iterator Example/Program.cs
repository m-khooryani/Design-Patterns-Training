using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree(TraversalAlgorithm.InOrder)
            {
                1,
                2,
                3
            };
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
            foreach (var item in tree)
            {
                Console.WriteLine(item);
            }
        }
    }

    class Tree : IEnumerable
    {
        private readonly TraversalAlgorithm traversalAlgorithm;
        private Node root;

        public Tree(TraversalAlgorithm traversalAlgorithm)
        {
            this.traversalAlgorithm = traversalAlgorithm;
        }

        public void Add(int item)
        {
            this.Add(item, root);
        }

        private void Add(int item, Node node)
        {
            Node temp = null;
            while (node != null)
            {
                temp = node;
                if (item < node.Data)
                {
                    node = node.Left;
                }
                else if (item > node.Data)
                {
                    node = node.Right;
                }
                else
                {
                    return;
                }
            }
            if (temp == null)
            {
                this.root = new Node(item);
                return;
            }
            if (item < temp.Data)
            {
                temp.Left = new Node(item);
            }
            else if (item > temp.Data)
            {
                temp.Right = new Node(item);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return new InOrderEnumerator(root);
        }
    }

    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    class InOrderEnumerator : IEnumerator
    {
        private readonly List<int> data;
        private int index = -1;

        public InOrderEnumerator(Node root)
        {
            Node node = root;

            List<Node> list = new List<Node>();
            this.data = new List<int>();
            while (node != null || list.Count > 0)
            {
                while (node != null)
                {
                    list.Add(node);
                    node = node.Left;
                }
                node = list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
                data.Add(node.Data);
                node = node.Right;
            }
        }

        public object Current => data[index];

        public bool MoveNext()
        {
            if (index < this.data.Count - 1)
            {
                index++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            index = -1;
        }
    }

    enum TraversalAlgorithm
    {
        Dfs, Bfs, InOrder
    }
}
