namespace leetcode.easy;

public partial class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        for (int i = 0; i < image.Length; i++) {
          int l = 0; int r = image.Length - 1;

          while (l <= r) {
            if (l == r) image[i][l] ^= 1;

            else {
              var temp = image[i][l] ^ 1;
              image[i][l] = image[i][r] ^ 1;
              image[i][r] = temp;
            }

              l++; r--;
          }
        }

        return image;
    }
}