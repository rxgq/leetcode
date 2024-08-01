namespace leetcode.easy;

public partial class Solution {
    public int CountSeniors(string[] details) {
        int count = 0;

        foreach (var detail in details) {
            if (int.Parse(detail.Substring(11, 2)) < 61)
                continue;

            count++;
        }

        return count;
    }
}