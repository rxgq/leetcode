namespace leetcode.easy;

public partial class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;

        int repeating = -1;
        int missing = -1;

        var seen = new HashSet<int>();
        var expected = new HashSet<int>();

        for (int i = 0; i < n; i++) {
          for (int j = 0; j < n; j++) {
            int num = grid[i][j];

            if (!seen.Add(num)) repeating = num;
            expected.Add(num);
          }
        }

        var expectedNumbers = new HashSet<int>();
        for (int i = 1; i <= n*n; i++)
            expectedNumbers.Add(i);

        foreach (int num in seen)
            expectedNumbers.Remove(num);

        if (expectedNumbers.Count > 0)
            missing = expectedNumbers.First();

        return new int[2] { repeating, missing };
    }
}