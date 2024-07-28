namespace leetcode.easy;

public partial class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        var punctuations = new char[] { '!', '?', ',', ';', '.', '\'' };
        foreach (char c in punctuations) {
            paragraph = paragraph.Replace(c, ' ');
        }

        var words = paragraph.ToLower().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var bannedSet = new HashSet<string>(banned.Select(b => b.ToLower()));

        var freq = new Dictionary<string, int>();
        foreach (var word in words) {
          if (bannedSet.Contains(word))
            continue;

          if (freq.ContainsKey(word)) {
            freq[word] += 1;
          } else {
            freq[word] = 1;
          }
        }

        int mostFreq = 0;
        string ans = "";
        foreach (var kvp in freq) {
          if (kvp.Value > mostFreq) {
            mostFreq = kvp.Value;
            ans = kvp.Key;
          }
        }

        return ans;
    }
}