namespace leetcode.easy;

public partial class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;

        for (int i = 0; i < details.Length; i++)
            if ((details[i][11] - '0') * 10 + (details[i][12] - '0') > 60) count++;

        return count;
    }
}
