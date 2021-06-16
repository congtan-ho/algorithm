using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hoan_Vi;

namespace TT_interchangeSort
{
    public class InterchangeSort
    {
        public static void interchangeSort(int[] A)
        {
            for (int i = 0; i < A.Length - 1; i++)
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] < A[i])
                    {
                        Swap.swap(ref A[j], ref A[i]);
                    }
                }
        }
    }
}
