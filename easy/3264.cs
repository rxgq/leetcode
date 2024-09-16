namespace leetcode.easy;

public partial class Solution {
    public int[] GetFinalState(int[] nums, int k, int mult) {
        for (int i = 0; i < k; i++) {
            var min = nums.Min();
            var idx = Array.IndexOf(nums, min);

            nums[idx] = nums[idx] * mult;
        }

        return nums;
    }
}