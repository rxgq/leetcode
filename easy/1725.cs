namespace leetcode.easy;

public partial class Solution {
    public int CountGoodRectangles(int[][] rectangles) {
        int maxLen = 0;

        foreach (var rectangle in rectangles) {
          int max = Math.Min(rectangle[0], rectangle[1]);
          maxLen = Math.Max(max, maxLen);
        }

        int count = 0;
        foreach (var num in rectangles)
          if (Math.Min(num[0], num[1]) == maxLen) count++;

        return count;
    }
}