using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TT_insertionSort
{
    public class InsertionSort
    {
        public static void insertionSort(int[] A)
        {
            int k = 1;

            while (k <= A.Length - 1)
            {
                int X = A[k];
                int index = k - 1;
                for (; index >= 0 && A[index] > X; index--)
                {
                    A[index + 1] = A[index];
                }
                A[index + 1] = X;
                k++;

            }
        }
    }
}
