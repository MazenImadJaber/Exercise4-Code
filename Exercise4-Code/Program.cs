using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4_Code
{
    class Program
    {
        const int ARRAY_SIZE = 10;
        const int RANDOM_MAX = 10000;

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] nums = new int[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
                // randomly generate an integer beteen 0 and RAMDOM_MAX
                nums[i] = rand.Next(100);


            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("before heap sorting:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine(nums[i]);
            }

            HeapSort(nums);

            Console.WriteLine();
            Console.WriteLine("after heap sorting:");
            for (int i = 0; i < ARRAY_SIZE; i++)
            {
                Console.WriteLine(nums[i]);
            }

            Console.ReadLine();
        }

        // convert a complete binary tree into a heap
        static void HeapBottomUp(int[] data)  //Note: In the algorithm, the array index starts from 1
        {
            int n = data.Length;
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                // to be completed
            }
        }

        // sort the elements in an array 
        static void HeapSort(int[] data)
        {
            //Use the HeapBottomUp procedure to convert the array, data, into a heap
            //To be completed

            //repeatly remove the maximum key from the heap and then rebuild the heap
            //To be completed
        }

        //delete the maximum key and rebuild the heap
        static void MaxKeyDelete(int[] data, int size)
        {
            //Exchange the root’s key with the last key K of the heap;
            int temp = data[0];
            data[0] = data[size - 1];
            data[size - 1] = temp;


            //“Heapify” the complete binary tree.
            // to be completed
        }
    }
}





