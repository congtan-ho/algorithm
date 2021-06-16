using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoan_Vi;

namespace TT_quickSort
{
    public class QuickSort
    {
        public static int partation(int[] A, int left, int right)
        {
            int pivot = A[right];
            int index = left - 1;
            for (int i = left; i < right; i++)
            {
                if (A[i] < pivot)
                {
                    index++;
                    Swap.swap(ref A[i], ref A[index]);
                }
            }
            index = index + 1;
            Swap.swap(ref A[index], ref A[right]);
            return index;
        }
        public static void quickSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int index = partation(A, left, right);
                quickSort(A, left, index - 1);
                quickSort(A, index + 1, right);
            }

        }
    }
}
