namespace leetcode.easy;

public partial class Solution {
    public int HeightChecker(int[] heights) {
        var expected = (int[])heights.Clone();
        Array.Sort(expected);

        int nonMatches = 0;
        for (int i = 0; i < heights.Length; i++)
            if (heights[i] != expected[i]) nonMatches++;

        return nonMatches;
    }
}