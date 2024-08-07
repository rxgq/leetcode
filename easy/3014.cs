namespace leetcode.easy;

public partial class Solution {
    public int MinimumPushes1(string word) {
        int groups = word.Length / 8;
        
        int ans = 0;
        for (int i = 0; i < groups; i++)
            ans += 8 * (i + 1);

        if (word.Length % 8 > 0)
            ans += (word.Length % 8) * (groups + 1);

        return ans;
    }
}