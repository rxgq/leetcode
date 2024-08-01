namespace leetcode.medium;

public partial class Solution {
    public int MaxOperations(int[] nums, int k) {
        int count = 0;
        var freq = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!freq.ContainsKey(num)) freq[num] = 1;
            else freq[num]++;
        }

        foreach (int num in freq.Keys.ToList()) {
            int complement = k - num;

            if (freq.ContainsKey(complement)) {
                if (num == complement) count += freq[num] / 2;
                else count += Math.Min(freq[num], freq[complement]);

                freq.Remove(num);
                freq.Remove(complement);
            }
        }

        return count;
    }
}
