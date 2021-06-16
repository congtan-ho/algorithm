using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TT_mergeSort
{
    public class MergeSort
    {
        public static void mergeArray(int[] A, int n, int[] B, int m, int[] C, ref int p)
        {
            int i = 0;
            int j = 0;
            p = 0;
            while (!(i >= n && j >= m))
            {
                if (i < n && j < m && A[i] < B[j] || j >= m)
                    C[p++] = A[i++];
                else
                    C[p++] = B[j++];
            }
        }
        public static void merge(int[] A, int left, int mid, int right)
        {
            //Left....Mid
            int[] B = new int[mid - left + 1];
            int k;
            //Mid+1.......Right
            int[] C = new int[right - mid];
            int l;
            //Left........Right
            int[] Temp = new int[right - left + 1];
            int m = 0;
            k = 0;
            for (int i = left; i <= mid; i++)
                B[k++] = A[i];
            l = 0;
            for (int i = mid + 1; i <= right; i++)
            {
                C[l] = A[i];
                l++;
            }

            mergeArray(B, k, C, l, Temp, ref m);
            for (int i = 0; i < m; i++)
                A[left + i] = Temp[i];
        }
        public static void mergeSort(int[] A, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                mergeSort(A, left, mid);
                mergeSort(A, mid + 1, right);
                merge(A, left, mid, right);
            }
        }
    }
}
