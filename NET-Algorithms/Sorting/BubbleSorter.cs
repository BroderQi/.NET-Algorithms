using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsTest.Sorting
{
    public static class BubbleSorter
    {
        /// <summary>
        /// 冒泡排序重复地遍历要排序的数组，比较相邻元素，并按照升序或降序交换它们
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    // 如果相邻元素顺序错误，则交换它们
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// 改进的冒泡排序是通过增加一个标志位来优化冒泡排序的过程。如果某一轮遍历没有发生交换，说明数组已经有序，可以提前结束排序。
        /// </summary>
        /// <param name="array"></param>
        public static void ImprovedBubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool flag = false; // 初始化标志位
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                        flag = true;  // 记录交换元素
                    }
                }
                if (!flag)
                    break;     // 内循环未交换任何元素，则跳出
            }
        }

        /// <summary>
        /// 鸡尾酒排序：鸡尾酒排序是冒泡排序的一种变体，它从数组的两端同时进行遍历和交换。该算法先从左往右遍历，然后再从右往左遍历，以此类推。这种算法的命名通常为CocktailSort。
        /// </summary>
        /// <param name="array"></param>
        public static void CocktailSort(int[] array)
        {
            bool swapped;
            int start = 0;
            int end = array.Length - 1;

            do
            {
                swapped = false;

                // 从左往右遍历，将较大元素交换到末尾
                for (int i = start; i < end; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                if (!swapped)
                    break;

                swapped = false;

                // 从右往左遍历，将较小元素交换到开头
                for (int i = end - 1; i >= start; i--)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                        swapped = true;
                    }
                }

                start++;
                end--;
            } while (swapped);
        }

        /// <summary>
        /// 鸟巢排序：鸟巢排序是一种结合了冒泡排序和插入排序思想的排序算法。它通过不断地比较相邻元素，并将较大元素向右移动，较小元素向左移动，从而逐步将最大元素移到正确位置
        /// </summary>
        /// <param name="array"></param>
        public static void GnomeSort(int[] array)
        {
            int n = array.Length;
            int index = 0;

            while (index < n)
            {
                if (index == 0 || array[index] >= array[index - 1])
                {
                    index++;
                }
                else
                {
                    Swap(array, index, index - 1);
                    index--;
                }
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
