using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMahisoft.Data_structures
{
    public class QueueNodes<T>
    {
        LinkedListNodes<T> linkedList = new LinkedListNodes<T>();


        public void Enqueue(Node<T> item)
        {
            linkedList.AddFirst(item);

        }

        public Node<T> Dequeue()
        {
            Node<T> enqueueItem;

            if (linkedList.Head == null)
            {
                throw new ArgumentException("The queue is empty");
            }

            enqueueItem = linkedList.GetLast();

            linkedList.RemoveLast();

            return enqueueItem;

        }

    }
}
