using System;
using System.Collections.Generic;

namespace TestMahisoft.Data_structures
{
    public class LinkedListNodes<T>
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

        public void Remove(Node<T> initialNode, Node<T> node)
        {
            if (initialNode == Head)
                previousNode = null;

            if (EqualityComparer<T>.Default.Equals(initialNode.Data, node.Data))
            {
                if (previousNode == null)
                {
                    Head = null;
                    return;

                }
                if (initialNode.Next == null)
                {

                    Tail = previousNode;
                    previousNode.Next = null;
                    return;
                }
                else
                {
                    previousNode.Next = node.Next;
                    return;
                }
            }
            previousNode = initialNode;

            Remove(initialNode.Next, node);

        }

        private void TraverseNodes(Node<T> initialNode, Node<T> node)
        {
            if (initialNode.Next == null)
            {
                initialNode.Next = node;
                Tail = node;
                return;
            }
            else
            {

                TraverseNodes(initialNode.Next, node);
            }

        }

        public void PrintNodes(Node<T> node)
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

            PrintNodes(node.Next);
        }

        public void AddFirst(Node<T> node)
        {

            if (Head == null)
            {
                Head = node;

            }

            else
            {
                if (Head.Next == null)
                {
                    Tail = Head;
                }

                node.Next = Head;
                Head = node;
            }

        }
        public void RemoveFirst()
        {
            Node<T> temp;
            if (Head == null)
            {
                return;
            }
            else
            {
                if (Head.Next == null)
                {
                    Head = null;

                }
                else
                {
                    temp = Head;
                    Head = temp.Next;
                    temp.Next = null;

                    if (Head.Next == null)
                    {
                        Tail = null;
                    }
                }
            }

        }

        public void RemoveLast()
        {
            Node<T> temp;
            if (Tail == null)
            {
                if (Head == null)
                {
                    return;
                }
                else
                {
                    Head = null;
                }
            }
            else
            {
                previousNode = null;
                TraverseLast(Head);


            }

        }


        private void TraverseLast(Node<T> node)
        {
            if (node.Next == null)
            {
                Tail = previousNode;
                previousNode.Next = null;
                if (Tail == Head)
                {
                    Tail = null;
                }
                return;
            }
            else
            {
                previousNode = node;
                TraverseLast(node.Next);
            }

        }

        public Node<T> GetFirst()
        {
            return Head;
        }

        public Node<T> GetLast()
        {
            Node<T> last = null;

            if (Tail == null)
            {
                if (Head != null)
                {
                    last = Head;
                }
            }
            else
            {
                last = Tail;
            }

            return last;

        }

    }
}
