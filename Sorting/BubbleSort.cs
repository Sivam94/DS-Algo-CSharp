namespace DS_Algo_CSharp.Sorting
{
    public class BubbleSort
    {
        /// Time - O(n^2)
        /// Time - O(n) if already sorted
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            bool swapped = true;

            for (int i = 0; i < n - 1 && swapped; i++)
            {
                swapped = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                        swapped = true;
                    }
                }
            }
        }
    }
}