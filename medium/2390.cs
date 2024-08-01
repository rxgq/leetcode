using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public string RemoveStars(string s) {
        var ans = new StringBuilder();
        
        for (int i = 0; i < s.Length; i++) {
            if (s[i] == '*') {
                if (ans.Length > 0) ans.Remove(ans.Length - 1, 1);
            }
            else ans.Append(s[i]);
        }  

        return ans.ToString();
    } 
}