namespace leetcode.easy;

public partial class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        int pos = 0;
        
        foreach (var command in commands) {
            pos += command[0] switch {
                'R' =>  1,
                'L' => -1,
                'U' => -n,
                'D' =>  n,
                _   =>  0
            };
        }

        return pos;
    }
}