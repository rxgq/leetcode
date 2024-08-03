namespace leetcode.easy;

public partial class Solution {
    public int ArithmeticTriplets(int[] nums, int diff) {
        var set = new HashSet<int>(nums);
        int res = 0;

        for (int i = 0; i < nums.Length; i++)
          if (set.Contains(nums[i] - diff) && set.Contains(nums[i] + diff)) res++;

        return res;
    }
}