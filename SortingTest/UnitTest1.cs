using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithims;

namespace SortingTest
{
    [TestClass]
    public class UnitTest1
    {

        private QuickSort Experiment;
        
    
       public int[] fillArrayRandom(int length)
        {
            int[] array = new int [length];
            Random rnd = new Random();
            for (int c = 0; c < array.Length; c++)
            {

                array[c] = rnd.Next(1,100);
                Console.WriteLine(array[c]);
            }
            return array;
        }

        public int [] fillArrayAcending(int length)
        {
            int[] array = new int[length];
           
            for (int c = 0; c < array.Length; c++)
            {
                array[c] = c;
                Console.WriteLine(array[c]);
            }
            return array;
        }

        public int[] fillArrayDecending(int length) {
            int[] array = new int[length];

            for (int c = array.Length-1; c <=0 ; c--)
            {
                array[c] = c;
                Console.WriteLine(array[c]);
            }
            return array;
        }

        [TestMethod]
        public void length10Random()
        {
          
            Experiment =new QuickSort();
            int[] arr = fillArrayRandom(10);
            Experiment.AQuickSort(arr, 0, arr.Length-1);

            for (int i = 0; i < arr.Length -1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1] )
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length1000Random()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayRandom(1000);
            Experiment.AQuickSort(arr,0, arr.Length-1);
            for (int c = 0; c < arr.Length -1 ; c++)
            {
                Console.WriteLine(arr[c] + "  " + arr[c + 1]);
                if (arr[c] > arr[c + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
         }

        [TestMethod]
        public void length100000Random()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayRandom(100000);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);
            for (int c = 0; c < arr.Length - 1; c++)
            {
                Console.WriteLine(arr[c] + "  " + arr[c + 1]);
                if (arr[c] > arr[c + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

       [TestMethod]
       public void length10Acending()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayAcending(10);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length1000Acending()
        {

            Experiment = new QuickSort();
            int[] arr = fillArrayAcending(1000);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length100000Acending()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayAcending(1000000);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length10Decending()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayDecending(10);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length1000Decending()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayDecending(1000);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void length100000Decending()
        {
            Experiment = new QuickSort();
            int[] arr = fillArrayDecending(100000);
            Experiment.AQuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i] + "  " + arr[i + 1]);
                if (arr[i] > arr[i + 1])
                {
                    Assert.Fail("The array was not ordered properly");
                }
            }
            Assert.IsTrue(true);
        }
    }
}
