namespace leetcode.easy;

public partial class Solution {
    public int NumMagicSquaresInside(int[][] grid) {
        int count = 0;
        
        for (int i = 0; i <= grid.Length - 3; i++) {

            for (int j = 0; j <= grid[0].Length - 3; j++) {
                if (IsMagicSquare(grid, i, j)) count++;
            }
        }
        
        return count;
    }

    private bool IsMagicSquare(int[][] grid, int r, int c) {
        bool[] seen = new bool[16];
        
        for (int i = r; i < r + 3; i++) {

            for (int j = c; j < c + 3; j++) {
                int num = grid[i][j];

                if (num < 1 || num > 9 || seen[num]) return false;
                seen[num] = true;
            }
        }
        
        int targetSum = grid[r][c] + grid[r][c+1] + grid[r][c+2];
        
        for (int i = r + 1; i < r + 3; i++) {
            int rowSum = grid[i][c] + grid[i][c+1] + grid[i][c+2];
            if (rowSum != targetSum) return false;
        }
        
        for (int j = c; j < c + 3; j++) {
            int colSum = grid[r][j] + grid[r+1][j] + grid[r+2][j];
            if (colSum != targetSum) return false;
        }
        
        int diag1Sum = grid[r][c] + grid[r+1][c+1] + grid[r+2][c+2];
        int diag2Sum = grid[r][c+2] + grid[r+1][c+1] + grid[r+2][c];
        
        return diag1Sum == targetSum && diag2Sum == targetSum;
    }
}