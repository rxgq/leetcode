namespace leetcode.easy;

public partial class Solution {
    public int Tribonacci(int n) {
        if (n == 0) return 0;

        int t1 = 0;
        int t2 = 1;
        int t3 = 1;

        for (int i = 3; i <= n; i++) {
          int tx = t1 + t2 + t3;
          t1 = t2;
          t2 = t3;
          t3 = tx;
        }

        return t3;
    }
}