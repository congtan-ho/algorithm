using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT_bubbleSort;
using TT_insertionSort;
using TT_interchangeSort;
using TT_mergeSort;
using TT_quickSort;
using TT_selectionSort;


namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new[] { 0, 14, 8, 26, 10, 15, 7, 21, 6, 5, 11 };
            //InterchangeSort.interchangeSort(myArray);
            //SelectionSort.selectionSort(myArray);
            //QuickSort.quickSort(myArray, 0, myArray.Length-1);
            //MergeSort.mergeSort(myArray, 0, myArray.Length);
            //BubbleSort.bubbleSort(myArray);
            InsertionSort.insertionSort(myArray);

            foreach(int item in myArray)
            {
                Console.Write(" " + item);
            }
            Console.ReadLine();
        }
    }
}
