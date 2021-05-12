using System;

namespace DS_Algo_CSharp
{
    /// Operations - Push, Pop, Peek
    public class Stack
    {
        public int Count { get; set; }
        private SinglyLinkedList list;

        public Stack()
        {
            list = new SinglyLinkedList();
        }

        /// Time - O(1)
        public void Push(int item)
        {
            list.Prepend(item);
            Count++;
        }

        /// Time - O(1)
        public void Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Stack underflow");
            }

            list.PopFirst();
            Count--;
        }

        /// Time - O(1)
        public int Peek()
        {
            if (Count == 0)
            {
                throw new Exception("Stack underflow");
            }

            return list.Head.Data;
        }
    }
}