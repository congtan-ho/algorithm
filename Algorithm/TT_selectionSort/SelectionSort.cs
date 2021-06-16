using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoan_Vi;

namespace TT_selectionSort
{
    public class SelectionSort
    {
        public static void selectionSort(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                int index_Min = i;
                for (int j = i; j < A.Length; j++)
                {
                    if (A[j] < A[index_Min])
                        index_Min = j;
                }
                Swap.swap(ref A[i], ref A[index_Min]);
            }
        }
    }
}
