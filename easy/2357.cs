namespace leetcode.easy;

public partial class Solution {
    public int MinimumOperations2(int[] nums) {
        var ops = 0;

        while (nums.Sum() != 0) {
            int min = nums.Where(n => n != 0).Min();

            for (int i = 0; i < nums.Length; i++)
                if (nums[i] - min >= 0) nums[i] -= min;

            ops++;
        }

        return ops;
    }
}