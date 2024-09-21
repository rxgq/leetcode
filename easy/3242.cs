namespace leetcode.easy;

public partial class NeighborSum {
    Dictionary<int, int> adjacentSum;
    Dictionary<int, int> diagonalSum;

    public NeighborSum(int[][] grid) {
        adjacentSum = new Dictionary<int, int>();
        diagonalSum = new Dictionary<int, int>();
        var m = grid.Length;
        var n = grid.Length;
        for (var i = 0; i < m; i++)
            for (var j = 0; j < n; j++) {
                var value = grid[i][j]; 
                adjacentSum.Add(value, 0);
                adjacentSum[value] += i - 1 >= 0 ? grid[i - 1][j] : 0;
                adjacentSum[value] += i + 1 <  m ? grid[i + 1][j] : 0;
                adjacentSum[value] += j - 1 >= 0 ? grid[i][j - 1] : 0;
                adjacentSum[value] += j + 1 <  n ? grid[i][j + 1] : 0;

                diagonalSum.Add(value, 0);
                diagonalSum[value] += i + 1 < m  && j + 1 < n  ? grid[i + 1][j + 1] : 0;
                diagonalSum[value] += i + 1 < m  && j - 1 >= 0 ? grid[i + 1][j - 1] : 0;
                diagonalSum[value] += i - 1 >= 0 && j - 1 >= 0 ? grid[i - 1][j - 1] : 0;
                diagonalSum[value] += i - 1 >= 0 && j + 1 < n  ? grid[i - 1][j + 1] : 0;
            }
    }
    
    public int AdjacentSum(int value) {
        return adjacentSum[value];
    }
    
    public int DiagonalSum(int value) {   
        return diagonalSum[value]; 
    }
}