using System;

namespace DS_Algo_CSharp
{
    /// Operations - Add, Pop, InsertAt, DeleteAt, Clear
    public class DynamicArray
    {
        public int InitialArraySize { get; set; }
        private int[] array;
        private int arraySize;
        public int Length { get; set; }

        public DynamicArray(int initialArraySize = 2)
        {
            if (initialArraySize < 2)
            {
                throw new Exception("Array Size should be greater than 1");
            }

            this.InitialArraySize = initialArraySize;
            arraySize = initialArraySize;
            array = new int[arraySize];
        }

        /// Time - O(1) amortized
        public void Add(int item)
        {
            grow();

            array[Length] = item;
            Length++;
        }

        /// Time - O(1) amortized
        public void Pop()
        {
            if (Length < 1)
            {
                throw new Exception("Empty Array");
            }

            Length--;

            shrink();
        }

        /// Time - O(n)
        public void InsertAt(int item, int index)
        {
            if (index >= Length || index < 1)
            {
                throw new Exception("Index out of range");
            }

            grow();

            Array.Copy(array, index, array, index + 1, Length - index);
            array[index] = item;
            Length++;
        }

        /// Time - O(n)
        public void RemoveAt(int index)
        {
            if (index >= Length || index < 1)
            {
                throw new Exception("Index out of range");
            }

            for (int i = index; i < Length; i++)
            {
                array[i] = array[i + 1];
            }
            Length--;

            shrink();
        }

        /// Time - O(1)
        public void Clear()
        {
            arraySize = InitialArraySize;
            array = new int[arraySize];
            Length = 0;
        }

        private void grow()
        {
            if (Length < arraySize)
            {
                return;
            }

            arraySize *= 2;

            var bigArray = new int[arraySize];
            Array.Copy(array, 0, bigArray, 0, Length);
            array = bigArray;
        }

        private void shrink()
        {
            if (Length < arraySize / 2 || arraySize == InitialArraySize)
            {
                return;
            }

            arraySize /= 2;

            var smallArray = new int[arraySize];
            Array.Copy(array, 0, smallArray, 0, Length);
            array = smallArray;
        }
    }
}