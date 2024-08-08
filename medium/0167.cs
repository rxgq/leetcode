namespace leetcode.easy;

public partial class Solution {
    public int[] TwoSum(int[] nums, int target) {
      int l = 0; int r = nums.Length - 1;

      while (l < r) {
        int currSum = nums[l] + nums[r];

        if (currSum > target) r--;
        else if (currSum < target) l++;

        else return new int[] {l + 1, r + 1};
      }

      return new int[2] {-1, -1};
    }
}