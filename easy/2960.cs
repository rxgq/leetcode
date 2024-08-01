namespace leetcode.easy;

public partial class Solution {
    public int CountTestedDevices(int[] batteryPercentages) {
        var count = 0;

        for (int i = 0; i < batteryPercentages.Length; i++)
            if (batteryPercentages[i] - count > 0) count++;

        return count;
    }
}