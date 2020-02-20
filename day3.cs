using System;
/// <summary>
/// Summary description for Class1
/// </summary>
namespace myCourse
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len = m + n - 1, len1 = m - 1, len2 = n - 1;

            while (len1 >= 0 && len2 >= 0)
            {
                nums1[len--] = nums1[len1] > nums2[len2] ? nums1[len1--] : nums2[len2--];
            }

            Array.Copy(nums2, nums1, len2 + 1);
        }
    }
}
