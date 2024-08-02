namespace leetcode.easy;

public partial class Solution {
    public int[] RowAndMaximumOnes(int[][] mat) {
        int maxCount = 0;
        int maxIndex = 0;

        for (int i = 0; i < mat.Length; i++) {

            int count = 0;
            foreach (int num in mat[i])
                if (num == 1) count++;

            if (count > maxCount) {
                maxCount = count;
                maxIndex = i;
            }
        }

        return new int[2] { maxIndex, maxCount };
    }
}