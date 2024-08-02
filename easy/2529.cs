namespace leetcode.easy;g

public partial class Solution {
    public int MaximumCount(int[] nums) {
        int posCount = 0;
        int negCount = 0;

        foreach (var num in nums) {
            if (num > 0) posCount++;
            else if (num < 0) negCount++;
        }

        return Math.Max(posCount, negCount);
    }
}