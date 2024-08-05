namespace leetcode.easy;

public partial class Solution {
    public int FindFinalValue(int[] nums, int original) {
        int num = original;

        while (nums.Contains(num))
          num *= 2;

        return num;
    }
}