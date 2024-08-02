namespace leetcode.easy;

public partial class Solution {
    public int[] NumberOfPairs(int[] nums) {
        var freq = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!freq.ContainsKey(num)) freq[num] = 1;
            else freq[num]++;
        }

        int count = 0;
        int leftOver = 0;
        foreach (var kvp in freq) {
            count += kvp.Value / 2;
            if (kvp.Value % 2 != 0) leftOver++;
        }

        return new int[2] { count, leftOver };
    }
}