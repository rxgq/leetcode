namespace leetcode.easy;

public partial class Solution {
    public int BusyStudent(int[] startTime, int[] endTime, int queryTime) {
        int count = 0;

        for (int i = 0; i < startTime.Length; i++)
            if (startTime[i] <= queryTime && endTime[i] >= queryTime) count++;

        return count;
    }
}