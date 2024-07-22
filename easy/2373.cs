namespace leetcode.easy;

public partial class Solution
{
    public int[][] LargestLocal(int[][] grid)
    {
        int n = grid.Length;
        int[][] maxLocal = new int[n - 2][];

        for (int i = 0; i < n - 2; i++)
        {
            maxLocal[i] = new int[n - 2];

            for (int j = 0; j < n - 2; j++)
            {
                int maxVal = int.MinValue;

                for (int x = i; x < i + 3; x++)
                    for (int y = j; y < j + 3; y++)
                        if (grid[x][y] > maxVal) maxVal = grid[x][y];

                maxLocal[i][j] = maxVal;
            }
        }

        return maxLocal;
    }
}
