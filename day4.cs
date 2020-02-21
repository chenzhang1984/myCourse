using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace myCourse
{
    class Solution_Day4
    {
        /// <summary>
        /// 283.移动0 双指针法
        /// </summary>
        /// <param name="nums"></param>
        public void MoveZeroes(int[] nums)
        {
            if (nums.Length == 0)
            {
                return;
            }

            int index_nums = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    nums[index_nums] = nums[i];
                    index_nums++;
                }
            }

            for (; index_nums < nums.Length; index_nums++)
            {
                nums[index_nums] = 0;
            }
        }

        /// <summary>       
        /// 题目：1.两数之和
        ///算法1:暴力算法，嵌套循环遍历数组，时间复杂度O（n^2）
        ///算法2：哈希表法，遍历数组，将数组的值保存在哈希表的key中，判断表中是否有key与当前值相加等于target
        ///没有就存入哈希表中，key为nums[i]，value为index,当遇到target-nums[i] 存在于表中，返回当前i与表中的value即可
        ///
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum(int[] nums, int target)
        {
            int[] res = { 0, 0 };
            Hashtable table = new Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (table.Contains(target - nums[i]))
                {
                    res[0] = i;
                    res[1] = (int)table[target - nums[i]];
                }
                else
                {
                    if (!table.Contains(nums[i]))//哈希表key唯一，要考虑到，排除干扰项输入
                    {
                        table.Add(nums[i], i);
                    }
                }
            }
            return res;
        }
    }
}
