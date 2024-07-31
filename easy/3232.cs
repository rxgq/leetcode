namespace leetcode.easy;

public partial class Solution {
    public bool CanAliceWin(int[] nums) {
        int singleSum = 0;
        int doubleSum = 0;

        foreach (int num in nums) {
            int n = (num.ToString()).Length;
            if (n == 2) doubleSum += num;
            else singleSum += num;
        }

        return singleSum != doubleSum;
    }
}