namespace leetcode.easy;

public partial class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int, int>();

        foreach (int num in nums) {
          if (!freq.ContainsKey(num)) freq[num] = 1;
          else freq[num]++;
        }

        var elements = new List<int>();
        var sortedFreq = freq.OrderByDescending(pair => pair.Value);

        foreach (var kvp in sortedFreq) {
          if (elements.Count < k)
            elements.Add(kvp.Key);
        }

        return elements.ToArray();
    }
}