namespace leetcode.easy;

public partial class Solution {
    public bool JudgeCircle(string moves) {
        int x = 0; int y = 0;

        foreach (char c in moves) {
            if (c == 'L') x--;
            if (c == 'R') x++;
            if (c == 'U') y++;
            if (c == 'D') y--;
        }

        return x == 0 && y == 0;
    }
}