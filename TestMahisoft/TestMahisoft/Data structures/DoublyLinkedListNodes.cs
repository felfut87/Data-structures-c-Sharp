using System;
using System.Collections.Generic;

namespace TestMahisoft.Data_structures
{
    public class DoublyLinkedListNodes<T>
    {
        public int count { get; set; }
        public Node<T> Head { get; set; }

        public Node<T> Tail { get; set; }

        private Node<T> previousNode;

        public void Add(Node<T> node)
        {
            if (count == 0)
            {
                Head = node;
                Tail = null;
            }
            else
            {
                TraverseNodes(Head, node);

            }
            count++;
        }

        public void Remove(Node<T> lastNode, Node<T> node)
        {
            if (lastNode == Tail)
                previousNode = null;

            if (EqualityComparer<T>.Default.Equals(lastNode.Data, node.Data))
            {
                if (lastNode.Previous == null && previousNode == null)
                {
                    Head = null;
                    return;

                }
                if (lastNode.Previous == null && previousNode != null)
                {

                    Head = previousNode;
                    previousNode.Previous = null;
                    return;
                }
                else
                {
                    previousNode.Previous = node.Previous;
                    node.Previous.Next = previousNode;
                    return;
                }
            }
            previousNode = lastNode;

            Remove(lastNode.Previous, node);

        }

        private void TraverseNodes(Node<T> initialNode, Node<T> node)
        {
            if (initialNode.Next == null)
            {
                initialNode.Next = node;
                node.Previous = initialNode;
                Tail = node;
                return;
            }
            else
            {

                TraverseNodes(initialNode.Next, node);
            }

        }

        public void PrintNodesForward(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            if (node == Tail)
            {
                return;
            }

            PrintNodesForward(node.Next);
        }

        public void AddLast(Node<T> node)
        {
            if (Tail == null)
            {
                Head.Next = node;
                node.Previous = Head;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

        }

        public void RemoveLast()
        {

            if (Tail == null)
            {
                Head = null;
            }
            else
            {

                Tail = Tail.Previous;
                Tail.Next.Previous = null;
                Tail.Next = null;
            }
        }
        public void PrintNodesBackwards(Node<T> node)
        {
            if (node == null)
            {
                return;
            }
            Console.WriteLine(node.Data);
            if (node == Head)
            {
                return;
            }

            PrintNodesBackwards(node.Previous);
        }
    }
}
