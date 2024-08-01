namespace leetcode.easy;

public partial class Solution {
    public int mySqrt(int x) {
        if (x == 0) return 0;
        if (x == 1) return 1;

        long left = 0;
        long right = x;
        
        while (left <= right) {
            long mid = left + (right - left) / 2;
            long midSquared = mid * mid;
            
            if (midSquared == x) return (int) mid;
            else if (midSquared < x) left = mid + 1;
            else right = mid - 1;
        }
        
        return (int)right;
    }
}
