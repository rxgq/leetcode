namespace leetcode.easy;

public partial class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) {
        var lucky = new List<int>();

        for (int i = 0; i < matrix.Length; i++) {
            int rowMin = int.MaxValue;
            int colMax = int.MinValue;

            int colIdx = -1;
            for (int j = 0; j < matrix[i].Length; j++) {
                if (matrix[i][j] < rowMin) {
                    rowMin = matrix[i][j];
                    colIdx = j;
                }
            }

            for (int k = 0; k < matrix.Length; k++) {
                colMax = Math.Max(colMax, matrix[k][colIdx]);
            }

            if (rowMin == colMax) lucky.Add(colMax);
        }

        return lucky;
    }
}