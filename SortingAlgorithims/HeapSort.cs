using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithims
{
   public class HeapSort
    {
        public static DateTime reference = DateTime.UtcNow;

        public void AQuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    AQuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    AQuickSort(arr, pivot + 1, right);
                }
            }

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        public static void heapSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
                heapify(arr, n, i);
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = arr[0];
                arr[0] = arr[i];
                arr[i] = temp;
                heapify(arr, i, 0);
            }
        }
        public static void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                heapify(arr, n, largest);
            }
        }

        public static void Main(String[] args)
        {
            String file = "C:/Users/Usuario/Desktop/xx.csv";
            int[] arr = null;
            String line = "";
            System.IO.StreamWriter wr;
            wr = new System.IO.StreamWriter(file);

            wr.WriteLine("10R,1000R,100000R,10A,1000A,100000A,10D,1000D,100000D");

            for (int i=0; i<1000; i++)
            {
                line = "";

                //Length 10 random
                reference = DateTime.UtcNow;
                arr = fillArrayRandom(10);
                HeapSort.heapSort(arr);;
                line += Time();

                //Length 1000 random
                reference = DateTime.UtcNow;
                arr = fillArrayRandom(1000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 100000 random
                reference = DateTime.UtcNow;
                arr = fillArrayRandom(100000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 10 ascending
                reference = DateTime.UtcNow;
                arr = fillArrayAcending(10);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 1000 ascending
                reference = DateTime.UtcNow;
                arr = fillArrayAcending(1000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 100000 ascending
                reference = DateTime.UtcNow;
                arr = fillArrayAcending(100000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 10 descending
                reference = DateTime.UtcNow;
                arr = fillArrayDecending(10);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 1000 descending
                reference = DateTime.UtcNow;
                arr = fillArrayDecending(1000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                //Length 100000 descending
                reference = DateTime.UtcNow;
                arr = fillArrayDecending(100000);
                HeapSort.heapSort(arr);
                line += "," + Time();

                Console.WriteLine(line);
                wr.WriteLine(line);
            }

            wr.Close();

        }

        public static int[] fillArrayRandom(int length)
        {
            List<int> listNumbers = new List<int>();
            int[] array = new int[length];
            Random rnd = new Random();
            for (int c = 0; c < array.Length; c++)
            {
                int random = rnd.Next(1, 100);
                if (!listNumbers.Contains(random))
                {
                    array[c] = random;
                    listNumbers.Add(random);
                }

            }
            return array;
        }

        public static int[] fillArrayAcending(int length)
        {
            int[] array = new int[length];

            for (int c = 0; c < array.Length; c++)
            {
                array[c] = c;
                //Console.WriteLine(array[c]);
            }
            return array;
        }

        public static int[] fillArrayDecending(int length)
        {
            int[] array = new int[length];

            for (int c = array.Length - 1; c <= 0; c--)
            {
                array[c] = c;
                //Console.WriteLine(array[c]);
            }
            return array;
        }

        public static long Time()
        {
            return (long)(DateTime.UtcNow - reference).TotalMilliseconds;
        }

    }
}
