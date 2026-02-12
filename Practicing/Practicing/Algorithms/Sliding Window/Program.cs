using Practicing.Algorithhms.Sliding_Window;
using Practicing.Algorithms.Sliding_Window;
using Practicing.Sorting_Algorithms.Quick_Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.Algorithns.Sliding_Window
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FixedSlidingWindow
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            int k = 5;
            Console.WriteLine($"Maximum amount subarray: {FixedSlidingWindow.MaxOfSubArray(arr, k)}");
            Console.WriteLine($"Minimum amount subarray: {FixedSlidingWindow.MinOfSubArray(arr, k)}");


            //DynamicSlidingWindow
            string s = "dasdasvcbffadfds";
            Console.WriteLine($"Length longest substring without repeating: {DynamicSlidingWindow.LengthLongestSubstring(s)}");



            int[] arr2 = { 5, 1, 5, 6, 8, 9, 11, 14, 15, 19, 2, 4, 5, 1, 5, 6, 7, 8, 4, 65, 3 };
            QuickSort.QuickSort4(arr2, 0, arr2.Length - 1);
            foreach( int i in arr2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
