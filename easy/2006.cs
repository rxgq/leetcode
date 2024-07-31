namespace leetcode.easy;

public partial class Solution {
    public int CountKDifference(int[] nums, int k) {
        int pairs = 0;

        for (int i = 0; i < nums.Length; i++) {

            for (int j = i + 1; j < nums.Length; j++) {
                if (Math.Abs(nums[i] - nums[j]) == k) pairs++;
            }
        }

        return pairs;
    }
}