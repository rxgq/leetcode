namespace leetcode.easy;

public partial class Solution {
    public int[] SortByBits(int[] arr) {
        return arr.OrderBy(x => CountBits(x)).ThenBy(x => x).ToArray();
    }

    private int CountBits(int num) {
        return Convert.ToString(num, 2).Count(c => c == '1');
    }
}
