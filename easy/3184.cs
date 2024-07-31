namespace leetcode.easy;

public partial class Solution {
    public int CountCompleteDayPairs(int[] hours) {
        var days = 0;

        for (int i = 0; i < hours.Length; i++) {

            for (int j = i + 1; j < hours.Length; j++) {
                if (i < j && (hours[i] + hours[j]) % 24 == 0) days++; 
            }
        }

        return days;
    }
}