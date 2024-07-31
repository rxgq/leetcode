namespace leetcode.easy;

public partial class Solution {
    public int[] FrequencySort(int[] nums) {
        var freq = new Dictionary<int, int>();

        foreach (int num in nums) {
            if (!freq.ContainsKey(num)) {
                freq[num] = 1;
            } else freq[num]++;
        }

        var freqList = new List<KeyValuePair<int, int>>(freq);

        freqList.Sort((a, b) => {
            int freqComparison = a.Value.CompareTo(b.Value);
            if (freqComparison == 0) {
                return b.Key.CompareTo(a.Key);
            }
            return freqComparison;
        });

        var result = new List<int>();
        foreach (var pair in freqList) {
            
            for (int i = 0; i < pair.Value; i++)
                result.Add(pair.Key);
        }

        return result.ToArray();
    }
}