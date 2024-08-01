namespace leetcode.easy;

public partial class Solution {
    public int CommonFactors(int a, int b) {
        int count = 0;

        for (int i = 1; i <= Math.Max(a, b); i++)
          if (a % i == 0 && b % i == 0) count++;

        return count;
    }
}