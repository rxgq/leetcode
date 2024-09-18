namespace leetcode.easy;

public partial class Solution {
    public string[] FindRelativeRanks(int[] score) {
        int n = score.Length;
        string[] result = new string[n];

        var scoreWithIndex = score
            .Select((value, index) => new { value, index })
            .OrderByDescending(item => item.value)
            .ToList();

        for (int i = 0; i < scoreWithIndex.Count; i++) {
            var index = scoreWithIndex[i].index;

            if (i == 0) {
                result[index] = "Gold Medal";
            } else if (i == 1) {
                result[index] = "Silver Medal";
            } else if (i == 2) {
                result[index] = "Bronze Medal";
            } else {
                result[index] = (i + 1).ToString();
            }
        }

        return result;
    }
}
