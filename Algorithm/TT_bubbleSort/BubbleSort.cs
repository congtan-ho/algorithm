using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoan_Vi;

namespace TT_bubbleSort
{
    public class BubbleSort
    {
        public static void bubbleSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
                for (int j = A.Length - 1; j >= i + 1; j--)
                    if (A[j - 1] > A[j])
                        Swap.swap(ref A[j - 1], ref A[j]);
        }
    }
}
