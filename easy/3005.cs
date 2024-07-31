namespace leetcode.easy;

public partial class Solution {
    public int MaxFrequencyElements(int[] nums) {
        var freq = new Dictionary<int, int>();
        
        int maxFreq = 0;
        foreach (int num in nums) {
            if (!freq.ContainsKey(num)) freq[num] = 1;
            else freq[num]++;
        
            maxFreq = Math.Max(maxFreq, freq[num]);
        }

        int sum = 0;
        foreach (var kvp in freq) {
            if (kvp.Value == maxFreq) sum += kvp.Value;
        }

        return sum;
    }
}