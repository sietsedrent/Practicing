using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.Algorithms.Sliding_Window
{
    public static class FixedSlidingWindow
    {
        public static int MaxOfSubArray(int[] arr, int k) 
        {
            //Check if k > arr.Length
            if (k > arr.Length) throw new ArgumentException();

            //Calculate sum first Window
            int windowSum = 0;
            for(int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }
            int maxSum = windowSum;

            //Slide window over array
            for (int i = k; i < arr.Length; i++)
            {
                //Subtract element leaving the window and add the new element
                windowSum += arr[i] - arr[i - k];
                maxSum = Math.Max(maxSum, windowSum);
            }
            return maxSum;
        }

        public static int MinOfSubArray(int[] arr, int k)
        {
            if (k > arr.Length) throw new ArgumentException();

            int windowSum = 0;
            for(int i = 0; i < k; i++)
            {
                windowSum += arr[i];
            }
            int minSum = windowSum;

            for(int i = k; i < arr.Length; i++)
            {
                windowSum += arr[i] - arr[i - k];
                minSum = Math.Min(minSum, windowSum);
            }

            return minSum;
        }
    }
}
