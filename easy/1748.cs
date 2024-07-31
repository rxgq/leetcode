namespace leetcode.easy;

public partial class Solution {
    public int SumOfUnique(int[] nums) {
        int sum = 0;

        var freq = new Dictionary<int, int>();
        foreach (int num in nums) {
            if (!freq.ContainsKey(num)) freq[num] = 1;
            else freq[num]++;
        }

        foreach (var kvp in freq) {
            if (kvp.Value == 1) sum += kvp.Key;
        }

        return sum;
    }
}