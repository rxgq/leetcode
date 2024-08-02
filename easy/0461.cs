namespace leetcode.easy;

public partial class Solution {
    public int HammingDistance(int x, int y) {
        int res = 0;
        int num = x ^ y;

        while (num != 0) {
            res += num & 1;
            num >>= 1;
        }

        return res;
    }
}