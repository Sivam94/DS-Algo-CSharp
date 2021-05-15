namespace DS_Algo_CSharp.Sorting
{
    public class SelectionSort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            int minIndex;

            for (int i = 0; i < n; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[minIndex] > arr[j])
                    {
                        minIndex = j;
                    }
                }

                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    }
}