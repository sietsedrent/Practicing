using Practicing.Algorithhms.Sliding_Window;
using Practicing.Algorithms.Sliding_Window;
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
        }
    }
}
