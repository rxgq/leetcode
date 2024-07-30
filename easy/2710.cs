namespace leetcode.easy;

public partial class Solution {
    public string RemoveTrailingZeros(string num) {
        string ans = "";

        int curr = num.Length - 1;
        while (num[curr] == '0') {
            curr--;  
        }

        return num.Substring(0, curr + 1);
    }
}