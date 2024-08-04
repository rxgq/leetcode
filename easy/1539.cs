namespace leetcode.easy;

public partial class Solution {
    public int FindKthPositive(int[] arr, int k) {
        var missing = 0;

        int i = 1;
        while (true) {
          if (!arr.Contains(i)) missing++;
          if (missing == k) return i;

          i++;
        }

        return -1;
    }
}