namespace leetcode.medium;

public partial class Solution {
    public int MaxArea(int[] height) {
        int l = 0; int r = height.Length - 1;

        var largestArea = 0;
        while (l < r) {
          var smallest = Math.Min(height[l], height[r]);
          
          var area = smallest * (r-l);
          largestArea = Math.Max(area, largestArea);

          if (height[l] < height[r]) {
            l++;
          } else r--;
        }

        return largestArea;
    }
}