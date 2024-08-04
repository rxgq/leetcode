namespace leetcode.easy;

public partial class Solution {
    public int MinOperations(int[] nums) {
        int count = 0;

        for (int i = 1; i < nums.Length; i++) {
          if (nums[i - 1] >= nums[i]) {
            var x = nums[i - 1] - nums[i] + 1;

            count += x;
            nums[i] += x;
          }
        }

        return count;
    }
}