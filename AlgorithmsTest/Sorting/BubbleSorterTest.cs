using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Threading.Tasks;
using AlgorithmsTest.Sorting;

namespace NET_Algorithms.Sorting
{
    public static class BubbleSorterTest
    {
        [Fact]
        public static void BubbleSortTest()
        {
            int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSorter.BubbleSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
            BubbleSorter.BubbleSort(array2);

        }

        [Fact]
        public static void ImprovedBubbleSortTest()
        {
            int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSorter.ImprovedBubbleSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
            BubbleSorter.ImprovedBubbleSort(array2);
        }

        [Fact]
        public static void CocktailSortTest()
        {
            int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSorter.CocktailSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
            BubbleSorter.CocktailSort(array2);
        }

        [Fact]
        public static void GnomeSortTest()
        {
            int[] array1 = { 64, 34, 25, 12, 22, 11, 90 };
            BubbleSorter.GnomeSort(array1);

            int[] array2 = { 1, 2, 3, 4, 5, 6, 7 };
            BubbleSorter.GnomeSort(array2);
        }
    }
}
