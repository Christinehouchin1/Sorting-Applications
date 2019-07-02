using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SortApp2
{
    class Program
    {
        //Insertion sort solution example by CSharpstar https://www.csharpstar.com/csharp-program-to-perform-insertion-sort/
        // This Insertion sort is a notation of O(n2)
        static void Main(string[] args)
        {
            //Small Set
            //int[] arr = new int[26] { 12, 11, 11, 11, 23, 23, 19, 18, 19, 19, 17, 17, 15, 15, 19, 19, 11, 11, 10, 10, 12, 12, 9, 9, 31, 30 };

            //Medium Set
           //int[] arr = new int[58] { 12, 141, 121, 11, 23, 23, 19, 18, 19, 19, 17, 17, 15, 15, 19, 19, 4, 13, 8, 10, 12, 12, 9, 9, 31, 30, 14, 15, 16, 16, 35, 35, 20, 20, 36, 36, 25, 24, 18, 18, 8, 8, 214, 23, 8, 7, 12, 11, 19, 18, 33, 32, 13, 12, 19, 18, 1, 5 };

            //Large Set
            int[] arr = new int[124] { 12, 11, 11, 11, 23, 23, 19, 18, 19, 19, 17, 17, 15, 15, 19, 19, 11, 11, 10, 10, 12, 12, 9, 9, 31, 30, 14, 15, 16, 16, 32, 35, 20, 21, 36, 32, 26, 24, 18, 184, 8, 82, 22, 23, 88, 7, 12, 11, 19, 16, 33, 35, 13, 12, 19, 18, 9, 9, 21, 24, 23, 21, 116, 6, 16, 47, 87, 67, 8, 7, 67, 9, 7, 34, 3, 33, 933, 1,32, 911, 8, 11, 733, 2, 32, 523, 1, 22, 325, 9, 25, 417, 2, 17, 22, 5, 22, 39, 6, 9, 323, 323, 9, 1, 9, 9, 31, 30, 14, 15, 16, 16, 32, 35, 20, 21, 36, 32, 26, 24, 18, 184, 8, 82 };
            int i;
            Console.WriteLine("The Array is :");
            //for (i = 0; i < 26; i++)
           //for (i = 0; i < 58; i++)
            for (i = 0; i < 124; i++)
            {
                Console.WriteLine(arr[i]);
            }
            //insertsort(arr, 26);
            //insertsort(arr, 58);
            insertsort(arr, 124);
            Console.WriteLine("The Sorted Array is :");
            //for (i = 0; i < 26; i++)
            //for (i = 0; i < 58; i++)
            for (i = 0; i < 124; i++)
                        Console.WriteLine(arr[i]);
            Console.ReadLine();
        }
        static void insertsort(int[] data, int n)
        {
            int i, j;
            for (i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (j = i - 1; j >= 0 && ins != 1;)
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
        }
    }
}
