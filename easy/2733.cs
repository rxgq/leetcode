namespace leetcode.easy;

public partial class Solution {
    public int FindNonMinOrMax(int[] nums) {
        if (nums.Length < 3) return -1;

        int min = Math.Min(nums[0], nums[1]);
        int max = Math.Max(nums[0], nums[1]);

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > min && nums[i] < max) return nums[i];
            else if (nums[i] > max) return max;
            else if (nums[i] < min) return min; 
        }

        return -1;
    }
}