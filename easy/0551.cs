namespace leetcode.easy;

public partial class Solution {
    public bool CheckRecord(string s) {
        var absences = 0;
        int lateStreak = 0;

        for (int i = 0; i < s.Length; i++) {
            if (s[i] == 'A') {
                absences++;
                lateStreak = 0;
            }
            else if (s[i] == 'L') {
                lateStreak++;

                if (lateStreak == 3) return false;
            } else lateStreak = 0;
        }

        return absences < 2;
    }
}