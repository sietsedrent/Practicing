using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing.Sorting_Algorithms.Quick_Sort
{
    public class QuickSort
    {
        //Practice

        public static void QuickSorts(int[] arr,  int start, int end)
        {
            if(end < start) return;
            var pivot = Partition(arr, start, end);
            QuickSorts(arr, start, pivot - 1);
            QuickSorts(arr, pivot + 1, end);
        }
        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;
            for(int j = start; j <= end -1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);

                }
            }
            i++;
            (arr[i], arr[end]) = (arr[end], arr[i]);

            return i;
        }



        //als end kleiner is dan start return

        //array scheiden in linker en rechterdeel
        //Eerst wordt links volledig gedaan voordat aan rechts wordt begonnen (de methode hervat op die regel)
        //Eerste keer wordt Partition aangeroepen met het einde van de array
        //Daarna is het einde op basis van waar de vorige pivot eindigde in de array

        //De pivot wordt het einde van array[end]
        //i wordt array start - 1
        //temp wordt 0

        //Daarna wordt de subarray doorlopen en worden de waarden gewisseld indien j lager is dan de pivot veranderd me de vorige i (degene die wel groter was, want i++ is sindsdien niet aangeroepen)

        //Aan het eind verander je de pivot nog met de i en return je i;

        private static void QuickSorts2(int[] arr, int start, int end)
        {
            if (end < start) return;
            int pivot = Partition2(arr, start, end); //deelt op in 2 arrays
            QuickSorts2(arr, start, pivot - 1); //roept recursief de linkerkant aan
            QuickSorts2(arr, pivot + 1, end); //roept recursief de rechterkant aan
        }
        private static int Partition2(int[] arr, int start, int end)
        {
            int pivot = arr[end]; //pivot zetten op het einde van de subarray
            int i = start - 1; //i op start -1
            for(int j = start; j <= end - 1; j++) //doorloop de subarray
            {
                if (arr[j] <= pivot) //als j kleiner is dan de pivot -> i verhogen en verwisselen met de laatste i
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]); //i en j switchen
                }
            }
            i++;
            (arr[i], arr[end]) = (arr[end], arr[i]);

            return i;
        }


        //[1, 7, 4, 7, 3, 2, 6, 5]
        //j = 1 i = 1 pivot = 5 switch i = arr[0]
        //j = 7 i = 1
        //j = 4 i = 7 switch -> [1,4,7,7,3,2,6,5] (i = arr[1])
        //j = 7 i = 4
        //j = 3 i = 7 switch [1,4,3,7,7,2,6,5] (i = arr[2])
        //j = 2 i = 7 switch [1,4,3,2,7,7,6,5] (i = arr[3])



        //QuickSorts3
        public static void QuickSorts3(int[] arr, int start, int end)
        {
            if (end < start) return;
            var pivot = Partition(arr, start, end);
            QuickSorts3(arr, start, pivot - 1);
            QuickSorts3(arr, pivot + 1, end);

        }
        public static int Partition3(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start - 1;
            for(int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            i++;
            (arr[i], arr[end]) = (arr[end], arr[i]);

            return i;
        }







        //4
        public static void QuickSort4(int[] arr, int start, int end)
        {
            if (end < start) return;
            int pivot = Partition4(arr, start, end);
            QuickSort4(arr, start, pivot - 1);
            QuickSort4(arr, pivot + 1, end);
        }

        public static int Partition4(int[] arr, int start, int end)
        {
            var pivot = arr[end];
            var i = start - 1;
            for(int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                }
            }
            i++;
            (arr[i], arr[end]) = (arr[end], arr[i]);
            return i;
        }
    }
}
