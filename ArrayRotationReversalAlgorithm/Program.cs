using System;

namespace ArrayRotationReversalAlgorithm
{
    class Program
    {
        public void leftRotate(int[] arr, int d)
        {
            int len = arr.Length;

            if (d == 0)
                return;

            d = d % len;
            reverseArray(arr, 0, d - 1);
            reverseArray(arr, d, len - 1);
            reverseArray(arr, 0, len - 1);

        }

        public void reverseArray(int[] arr, int start, int end)
        {
            int temp;

            while (start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public void printArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + ", ");
        }

        static void Main(string[] args)
        {
            Program program = new Program();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int d = 0;

            program.leftRotate(arr, d);
            program.printArray(arr);
        }
    }
}
