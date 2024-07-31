namespace leetcode.easy;

public partial class Solution {
    public int DuplicateNumbersXOR(int[] nums) {
        var seen = new HashSet<int>();
        var duplicates = new List<int>();

        foreach (int num in nums) {
            if (!seen.Add(num)) duplicates.Add(num);
        }

        int xorSum = 0;
        foreach (int num in duplicates)
            xorSum ^= num;

        return xorSum;
    }
}