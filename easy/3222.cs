namespace leetcode.easy;

public partial class Solution {
    public string LosingPlayer(int x, int y) {
        return Math.Min(x, y / 4) % 2 == 0 ? "Bob" : "Alice";
    }
}