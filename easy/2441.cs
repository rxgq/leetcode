namespace leetcode.easy;

public partial class Solution {
    public int FindMaxK(int[] nums) {
        int max = -1;

        foreach (int num in nums) {
            if (nums.Contains(-num))
                max = Math.Max(max, num);
        }

        return max;
    }
}