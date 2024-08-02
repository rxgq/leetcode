using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public string CapitalizeTitle(string title) {
        title = title.ToLower();
        
        var words = title.Split(' ');
        var sb = new StringBuilder();

        foreach (var word in words) {
            if (word.Length > 2) {
                sb.Append(char.ToUpper(word[0]));
                sb.Append(word[1..]);
            } else sb.Append(word);
            
            sb.Append(' ');
        }

        return sb.ToString()[..^1];
    }
}