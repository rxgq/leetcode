namespace leetcode.easy;

public partial class Solution {
    public int NumOfStrings(string[] patterns, string word) {
        int count = 0;

        foreach (var p in patterns)
          if (word.Contains(p)) count++;

        return count;
    }
}