namespace leetcode.easy;

public partial class Solution {
    public int MaxWidthOfVerticalArea(int[][] points) {
        Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
        
        int result = 0;
        for (int i = 0; i < points.Length - 1; i++)
          result = Math.Max(points[i + 1][0] - points[i][0], result);

        return result;
    }
}