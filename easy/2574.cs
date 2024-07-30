namespace leetcode.easy;

public partial class Solution {
    public int[] LeftRightDifference(int[] nums) {
        int[] left = new int[nums.Length];
        for (int i = 1; i < nums.Length - 1; i++) 
          left[i] = nums[i - 1] + left[i - 1];

        int[] right = new int[nums.Length];
        for (int i = nums.Length - 2; i >= 0; i--)
          right[i] = nums[i + 1] + right[i + 1];

        int[] ans = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
          ans[i] = Math.Abs(left[i] - right[i]);

        return ans;
    }
}