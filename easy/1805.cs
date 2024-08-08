using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public int NumDifferentIntegers(string word) {
        var freq = new HashSet<string>();

        for (int i = 0; i < word.Length; i++) {
            if (char.IsDigit(word[i])) {
                var sb = new StringBuilder();

                while (i < word.Length && char.IsDigit(word[i])) {
                    sb.Append(word[i]);
                    i++;
                }

                freq.Add(sb.ToString().TrimStart('0'));
            }
        }

        return freq.Count;
    }
}