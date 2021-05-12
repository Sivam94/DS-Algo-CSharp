using System;

namespace DS_Algo_CSharp
{
    /// Operations - Enqueue, Dequeue, Peek
    public class Queue
    {
        public int Count { get; set; }
        private SinglyLinkedList list;

        public Queue()
        {
            list = new SinglyLinkedList();
        }

        /// Time - O(1)
        public void Enqueue(int item)
        {
            list.Append(item);
            Count++;
        }

        /// Time - O(1)
        public void Dequeue()
        {
            if (Count == 0)
            {
                throw new Exception("Queue underflow");
            }

            list.PopFirst();
            Count--;
        }


        /// Time - O(1)
        public int Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Queue underflow");
            }

            return list.Head.Data;
        }
    }
}