using System;
namespace Leetcode
{
    internal class Program
    {
        static void main(string[] arg)
        {

        }
        public static void Merge()
        {
            // 填充
            // for(int i=0; i<nums2.Length; i++) {
            //     nums1[m+i] = nums2[i];
            // }
            // nums1排序
            // 使用C#提供的排序方法
            // Array.Sort(nums1);
            // 冒泡排序
            // int k = 0,j = 0;
            // int temp;
            // for(k=0; k<nums1.Length; k++) {
            //     for(j=0; j<nums1.Length - k - 1; j++) {
            //         if (nums1[j] > nums1[j+1]) {
            //             temp = nums1[j];
            //             nums1[j] = nums1[j+1];
            //             nums1[j+1] = temp;
            //         }
            //     }
            // }
            // 选择排序
            // int k = 0,j = 0;
            // int temp, minIndex;
            // for (k = 0; k < nums1.Length - 1; k++) {
            //     minIndex = k;
            //     for (j = k + 1; j < nums1.Length; j++) {
            //         if (nums1[minIndex] > nums1[j]) {
            //             minIndex = j;
            //         }
            //     }
            //     temp = nums1[minIndex];
            //     nums1[minIndex] = nums1[k];
            //     nums1[k] = temp;
            // }
            // 插入排序，扑克算法
            // int j, k, temp = 0;
            // for(k = 0; k < nums1.Length; k++) {
            //     temp = nums1[k];
            //     for (j = k - 1; j >= 0; j--) {
            //         if (nums1[j] > temp) {
            //             nums1[j + 1] = nums1[j];
            //             nums1[j] = temp; 
            //         } else {
            //             break;
            //         }
            //     }
            // }
            // 希尔排序
            // int k, j, temp = 0;
            // int gap = 1;
            // // 分gap
            // while(gap < nums1.Length) {
            //     gap  = gap * 3 + 1;
            // }
            // while (gap >= 1) {
            //     for (k = gap; k< nums1.Length; k++) {
            //         for (j = k; j >= gap && nums1[j] < nums1[j-gap]; j-=gap) {
            //             temp = nums1[j];
            //             nums1[j] = nums1[j-gap];
            //             nums1[j-gap] = temp;
            //         }
            //     }
            //     gap /= 3;
            // }
            // 归并排序，写不了好像
            // List<int> n1 = new List<int>(nums1);
            // List<int> n2 = new List<int>(nums2);
            // List<int> res = new List<int>();
            // int k = m - n;
            // while(n1.Count > k && n2.Count > 0) {
            //     if (n1[0] <= n2[0]) {
            //         res.Add(n1[0]);
            //         n1.RemoveAt(0);
            //     } else {
            //         res.Add(n2[0]);
            //         n2.RemoveAt(0);
            //     }
            // }
            // while(n1.Count > 0) {
            //     res.Add(n1[0]);
            //     n1.RemoveAt(0);
            // }
            // while(n2.Count > 0) {
            //     res.Add(n2[0]);
            //     n2.RemoveAt(0);
            // }
            // nums1 = res.ToArray();
        }
    }
}