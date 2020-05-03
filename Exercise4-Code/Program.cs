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
        const int RANDOM_MAX = 100;

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] nums = new int[ARRAY_SIZE];
            for (int i = 0; i < ARRAY_SIZE; i++)
                // randomly generate an integer beteen 0 and RAMDOM_MAX
                nums[i] = rand.Next(RANDOM_MAX);


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


            // workshop question 
            int[] example = { 13,57,39,85,70,22,64,48};
            Console.WriteLine();
            Console.WriteLine("workshop question before heap sorting:");
            for (int i = 0; i < example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }

            HeapSort(example);

            Console.WriteLine();
            Console.WriteLine("after heap sorting:");
            for (int i = 0; i < example.Length; i++)
            {
                Console.WriteLine(example[i]);
            }

            Console.ReadLine();
        }

        // convert a complete binary tree into a heap
        static void HeapBottomUp(int[] H)  //Note: In the algorithm, the array index starts from 1
        {
            int n = H.Length;
            for (int i = (n - 1) / 2; i >= 0; i--)
            {
                // to be completed
                int k = i;
                int v = H[i];
                bool heap = false;
                while(!heap && ((2 * k+1) <= (n-1)))
                {
                    int j = 2 * k + 1; // left child 

                    if (j < (n-1))
                    {
                        if (H[j] < H[j + 1])
                        {
                            j=j+1;
                        }
                    }
                    if (v>= H[j])
                    {
                        heap = true;
                    } 
                    else
                    {
                        H[k] = H[j];
                        k = j;

                    }

                }
                H[k] = v;
            }
        }

        // sort the elements in an array 
        static void HeapSort(int[] data)
        {
            
             //Use the HeapBottomUp procedure to convert the array, data, into a heap
            //To be completed
            HeapBottomUp(data);
            //repeatly remove the maximum key from the heap and then rebuild the heap
            //To be completed
            for(int i = 0; i <=( data.Length-2); i++)
            {
                MaxKeyDelete(data, data.Length-i);
            }
        }

        //delete the maximum key and rebuild the heap
        static void MaxKeyDelete(int[] data, int size)
        {
            //Exchange the root’s key with the last key K of the heap;
            int temp = data[0];
            data[0] = data[size - 1];
            data[size - 1] = temp;

            // decrease heap's size by 1
            int n = size - 1;
            
            
            //“Heapify” the complete binary tree.
            // to be completed
            bool heap = false;
            int k = 0;
            int v = data[0];
            while((!heap) && ((2 * k + 1) <= (n-1)))
            {

                int j = 2 * k + 1;//left child
                if (j<(n-1))
                {
                    if (data[j] < data[j + 1]) // compare children 
                    {
                        j = j + 1; // j is the bigger child of k :3
                    }
                }
                if (v >= data[j])
                {
                    heap = true;
                }
                else
                {
                    data[k] = data[j];
                    k = j;
                }
            }
            data[k] = v; 
            
        }
    }
}





