namespace leetcode.easy;

public partial class Solution {
    public int[] KWeakestRows(int[][] mat, int k) {
        int m = mat.Length;
        int n = mat[0].Length;

        var rows = new Dictionary<int, int>();

        int CountSoldiers(int[] row) {
          int left = 0; 
          int right = row.Length;

          while (left < right) {
            int mid = (left + right) / 2;
            if (row[mid] == 0) right = mid;
            else left = mid + 1;
          }

          return left;
        }

        for (int i = 0; i < m; i++) {
          rows[i] = CountSoldiers(mat[i]);
        }

        var sortedRows = rows.OrderBy(r => r.Value).ThenBy(r => r.Key).ToList();
        int[] result = sortedRows.Take(k).Select(r => r.Key).ToArray();

        return result;
    }
}