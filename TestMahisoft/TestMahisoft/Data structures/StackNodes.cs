using System;

namespace TestMahisoft.Data_structures
{
    public class StackNodes<T>
    {
        LinkedListNodes<T> linkedList = new LinkedListNodes<T>();
        public bool Push(Node<T> node)
        {
            linkedList.AddFirst(node);
            return linkedList.GetFirst() != null;
        }

        public Node<T> Pop()
        {
            Node<T> nodePopped;

            nodePopped = linkedList.GetFirst();

            if (nodePopped == null)
            {

                throw new ArgumentException("The stack is empty");
            }
            linkedList.RemoveFirst();
            return nodePopped;
        }

        public Node<T> Peek()
        {
            if (linkedList.Head == null)
            {
                throw new ArgumentException("The stack is empty");
            }

            return linkedList.GetFirst();

        }

    }

}
