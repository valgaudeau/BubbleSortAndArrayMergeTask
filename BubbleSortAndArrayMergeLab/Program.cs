namespace BubbleSortAndArrayMergeLab
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] arr = { 5, 2, 8, 3, 1, 6 }; 
            BubbleSort(arr);
            foreach(int i in arr) 
            { 
                Console.Write(i + " ");
            }
            */

            int[] arrOne = { 5, 2, 8, 3, 1, 6 };
            int[] arr2 = { 1, 7, 9, 10 };
            int[] merge = ArrayMerge(arrOne, arr2);
            foreach (int i in merge)
            {
                Console.Write(i + " ");
            }
        }

        public static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++) 
            {
                for (int j = 0; j < n - i - 1; j++) // the biggest number will always go the last position
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static int[] ArrayMerge(int[] arrOne, int[] arrTwo)
        {
            if ((arrOne == null) || (arrTwo == null)) throw new ArgumentException("You passed a null array");

            int[] combined = arrOne.Concat(arrTwo).ToArray();
            BubbleSort(combined);
            return combined;
        }

    }
}