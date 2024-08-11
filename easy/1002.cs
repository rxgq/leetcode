namespace leetcode.easy;

public partial class Solution {
    public IList<string> CommonChars(string[] words) {
        var freq = new Dictionary<char, int>();
        foreach (char c in words[0])
            freq[c] = freq.TryGetValue(c, out int val) ? ++val : 1;

        for (int i = 1; i < words.Length; i++) {
            var currFreq = new Dictionary<char, int>();
            foreach (char c in words[i])
                currFreq[c] = currFreq.TryGetValue(c, out int val) ? ++val : 1;
                
            foreach (var kvp in freq.Keys.ToList()) {
                if (currFreq.TryGetValue(kvp, out int count)) {
                    freq[kvp] = Math.Min(freq[kvp], count);
                } else freq[kvp] = 0;
            }
        }

        var result = new List<string>();
        foreach (var kvp in freq) {

            for (int i = 0; i < kvp.Value; i++)
                result.Add(kvp.Key.ToString());
        }

        return result;
    }
}