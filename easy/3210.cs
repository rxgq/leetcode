using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public string GetEncryptedString(string s, int k) {
        k = k % s.Length;
        
        var sb = new StringBuilder();

        sb.Append(s.Substring(k));
        sb.Append(s.Substring(0, k));

        return sb.ToString();
    }
}
