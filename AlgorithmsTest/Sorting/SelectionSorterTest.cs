using NET_Algorithms.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AlgorithmsTest.Sorting
{
    public class SelectionSorterTest
    {
        [Fact]
        public static void SelectionSortTest()
        {
            int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
            SelectionSorter.SelectionSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
            SelectionSorter.SelectionSort(array2);

        }
    }
}
