namespace leetcode.easy;

public partial class Solution {
    public int FindGCD(int[] nums) {
        var max = nums.Max();
        var min = nums.Min();

        for (int i = min; i > 0; i--)
          if (max % i == 0 && min % i == 0) return i;

        return -1;
    }
}