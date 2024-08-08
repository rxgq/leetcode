namespace leetcode.easy;

public partial class Solution {
    public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart) {
        int[][] directions = new int[][] {
            new int[] {0, 1}, new int[] {1, 0}, new int[] {0, -1}, new int[] {-1, 0} 
        };

        int[][] result = new int[rows * cols][];
        
        int r = rStart;
        int c = cStart;
        int steps = 1;
        int i = 0;
        int count = 0;
        
        while (count < rows * cols) {
            for (int l = 0; l < 2; l++) {
                for (int j = 0; j < steps; j++) {
                    if (r >= 0 && r < rows && c >= 0 && c < cols) {
                        result[count++] = new int[] {r, c};
                    }
                    r += directions[i][0];
                    c += directions[i][1];
                }
                i = (i + 1) % 4;
            }
            steps++;
        }

        return result;
    }
}
