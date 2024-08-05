namespace leetcode.easy;

public partial class Solution {
    public int ArraySign(int[] nums) {
        int negative = 0;
        foreach (int num in nums) {
            if (num == 0) return 0;
            negative += (num < 0 ? 1 : 0);
        }

        return negative % 2 == 0 ? 1 : -1;
    }
}
