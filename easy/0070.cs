namespace leetcode.easy;

public partial class Solution {
    public int ClimbStairs(int n) {
        int prev = 1;
        int curr = 1;
        for (int i = 1; i < n; i++) {
            int temp = curr;
            curr += prev;
            prev = temp;
        }

        return curr;
    }
}