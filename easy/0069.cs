namespace leetcode.easy;

public partial class Solution {
    public int MySqrt(int x) {
        if (x == 0) return 0;

        int left = 0; int right = x;
        while (left <= right) {
            int mid = (left + right) / 2;

            if (mid * mid == x) return mid;
            else if (mid * mid < x) left = mid + 1;
            else right = mid - 1;
        }

        return right;
    }
}