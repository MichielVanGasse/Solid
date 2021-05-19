using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class SortingAlgorithmTester
    {
        public SortAlgorithm SortMethod { get; set; }
        public SortingAlgorithmTester(SortAlgorithm sortMethod)
        {
            SortMethod = sortMethod;
        }

        public void Test()
        {
                int[] array = { 88, 12, 55, 105, 48, 84, 66, 35, 57, 89, 74, 106, 200, 541, 1, 9, 7, 55, 405, 13 };
                SortMethod.Sort(array);
                Console.WriteLine($"sorting done using {SortMethod}, needed {SortMethod.swapped} swaps to sort the array");
        }
	}
}
