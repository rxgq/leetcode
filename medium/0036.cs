namespace leetcode.easy;

public partial class Solution {
    public bool IsValidSudoku(char[][] board) {
      
      // validate rows
      for (int i = 0; i < board.Length; i++) {
        var seen = new HashSet<int>();

        for (int j = 0; j < board.Length; j++) {
          if (board[i][j] != '.' && !seen.Add(board[i][j]))
            return false;
        }
      }

      // validate columns
      for (int i = 0; i < board.Length; i++) {
        var seen = new HashSet<int>();

        for (int j = 0; j < board.Length; j++) {
          if (board[j][i] != '.' && !seen.Add(board[j][i]))
            return false;
        }
      }

      // validate 3x3 grids
      for (int gridRow = 0; gridRow < 9; gridRow += 3) {
        
        for (int gridCol = 0; gridCol < 9; gridCol += 3) {
          var seen = new HashSet<int>();

          for (int i = gridRow; i < gridRow + 3; i++) {
            for (int j = gridCol; j < gridCol + 3; j++) {
              if (board[i][j] != '.' && !seen.Add(board[i][j]))
                return false;
            }
          }
        }
      }

      return true;
    }
}