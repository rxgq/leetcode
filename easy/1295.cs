namespace leetcode.easy;

public partial class Solution {
    public int FindNumbers(int[] nums) {
        int count = 0;

        for (int i = 0; i < nums.Length; i++) {
            var digits = Math.Floor(Math.Log10(nums[i]) + 1);
            if (digits % 2 == 0) count++;
        }

        return count;
    }
}