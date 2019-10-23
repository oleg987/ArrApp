using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[] arr = new int[size];
            arr[0] = 1;
            arr[1] = 2;
            arr[3] = 3;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }


            int oldSize = arr.Length;
            Array.Resize(ref arr, arr.Length + 5);


            for (int i = 0; i < 5; i++)
            {
                arr[oldSize + i] = 15;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }


            int[] arr1 = new int[10];
            int[] arr2 = new int[5];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = 1;
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                arr2[i] = 2;
            }

            Console.WriteLine();

            oldSize = arr1.Length;
            Array.Resize(ref arr1, arr1.Length + arr2.Length);

            for (int i = 0; i < arr2.Length; i++)
            {
                arr1[oldSize + i] = arr2[i];
            }

            foreach (int item in arr1)
            {
                Console.WriteLine(item);
            }

            int[,] arr2d = new int[5, 5];            

            for (int i = 0; i < arr2d.GetLength(0); i++)
            {
                for (int j = 0; j < arr2d.GetLength(1); j++)
                {
                    arr2d[i, j] = 8;
                }
            }
            Console.WriteLine(arr2d);

            //int[][] jaggedArr = new int[2][];
            //jaggedArr[0] = new int[5];
            //jaggedArr[1] = new int[3];

            //Console.WriteLine(jaggedArr);

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next() % 50;
            }

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
