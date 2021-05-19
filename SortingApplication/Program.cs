using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SortAlgorithm bubbleSort = new BubbleSort();
            SortingAlgorithmTester tester = new SortingAlgorithmTester(bubbleSort);
            tester.Test();
            tester.SortMethod = new ShakerSort();
            tester.Test();
            tester.SortMethod = new QuickSort();
            tester.Test();
			Console.ReadLine();
        }
    }
}
