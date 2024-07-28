namespace leetcode.easy;

public partial class Solution {
    public int[] NumberOfLines(int[] widths, string s) {
        var result = new int[2];

        var lines = 1;
        int currWidth = 0;

        foreach (char c in s) {
          int width = widths[c - 'a'];

          if (currWidth + width > 100) {
            lines++;
            currWidth = width;
          } else {
            currWidth += width;
          }
        }

        result[0] = lines;
        result[1] = currWidth;
        return result;
    }
}