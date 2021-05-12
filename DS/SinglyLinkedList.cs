using System;

namespace DS_Algo_CSharp
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            this.Data = data;
        }
    }

    /// Operations - Prepend, Append, Pop, PopFirst, Length, Clear
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        /// Time - O(1)
        public void Prepend(int item)
        {
            var newNode = new Node(item);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            newNode.Next = Head;
            Head = newNode;
        }

        /// Time - O(1)
        public void Append(int item)
        {
            var newNode = new Node(item);

            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }

            Tail.Next = newNode;
        }

        /// Time - O(n)
        public void Pop()
        {
            if (Head == null)
            {
                throw new Exception("Empty List");
            }

            var current = Head;
            Node previous = null;

            while (current != null && current.Next != null)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = null;
            Tail = previous;
        }

        /// Time - O(1)
        public void PopFirst()
        {
            if (Head == null)
            {
                throw new Exception("Empty List");
            }

            Head = Head.Next;
        }

        /// Time - O(n)
        public int Length()
        {
            var current = Head;
            int length = 0;

            while (current != null)
            {
                ++length;
                current = current.Next;
            }

            return length;
        }

        /// Time - O(1)
        public void Clear()
        {
            if (Head == null)
            {
                throw new Exception("Empty List");
            }

            Head = null;
        }
    }
}