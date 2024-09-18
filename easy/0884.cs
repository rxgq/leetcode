namespace leetcode.easy;

public partial class Solution {
    public string[] UncommonFromSentences(string s1, string s2) {
        var words = s1.Split(" ").Concat(s2.Split(" "));

        return words.GroupBy(w => w)
            .Where(w => w.Count() == 1).Select(w => w.Key)
            .ToArray();
    }
}