namespace leetcode.easy;

public partial class Solution {
    public bool AreNumbersAscending(string s) {
        List<int> nums = new();

        var tokens = s.Split(" ");
        foreach (var token in tokens) {
          if (int.TryParse(token, out _))
            nums.Add(int.Parse(token));
        }

        for (int i = 1; i < nums.Count; i++)
          if (nums[i - 1] >= nums[i]) return false;

        return true;
    }
}