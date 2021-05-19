using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
	class QuickSort : SortAlgorithm
    {
        public override void Sort(int[] array)
        {
            QuickSortM(array, 0, array.Length - 1);
        }

        void QuickSortM(int[] array, int Left, int Right)
        {
            int L = Left;
            int R = Right;
            int pivotValue = array[(Left + Right) / 2];

            do
            {
                while (array[L] < pivotValue)
                {
                    L++;
                }
                while (pivotValue < array[R])
                {
                    R--;
                }

                if (L <= R)
                {
                    Swap(L, R, array);
                    L++;
                    R--;
                }
            } while (L < R);

            if (Left < R)
            {
                QuickSortM(array, Left, R);
            }
            if (L < Right)
            {
                QuickSortM(array, L, Right);
            }
        }
        public override string ToString()
        {
            return "QuickSort";
        }
    }
}
