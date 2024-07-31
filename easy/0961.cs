namespace leetcode.easy;''

public partial class Solution {
    public int RepeatedNTimes(int[] nums) {
        var freq = new Dictionary<int, int>();

        foreach (var num in nums) {
          if (!freq.ContainsKey(num)) freq[num] = 1;
          else freq[num]++;
        }

        var result = 0;
        foreach (var kvp in freq) {
          if (kvp.Value == nums.Length / 2) result = kvp.Key;
        }

        return result;
    }
}