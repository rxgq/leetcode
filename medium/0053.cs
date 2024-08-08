namespace leetcode.easy;

public partial class Solution {
    public int MaxSubArray(int[] nums) {
        int max = nums[0];

        int curr = 0;
        for (int i = 0; i < nums.Length; i++) {
          if (curr < 0) curr = 0;
          curr += nums[i];

          max = Math.Max(curr, max);
        }

        return max;
    }
}