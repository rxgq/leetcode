namespace leetcode.easy;

public partial class Solution {
    public int CountWords(string[] words1, string[] words2) {
        var words1Freq = new Dictionary<string, int>();
        var words2Freq = new Dictionary<string, int>();

        foreach (var word in words1)
            words1Freq[word] = words1Freq.TryGetValue(word, out int val) ? ++val : 1;

        foreach (var word in words2)
            words2Freq[word] = words2Freq.TryGetValue(word, out int val) ? ++val : 1;

        int count = 0;
        foreach (var kvp in words1Freq) {
            if (kvp.Value == 1 && words2Freq.TryGetValue(kvp.Key, out int value) && value == 1) {
                count++;
            }
        }

        return count;
    }
}