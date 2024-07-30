namespace leetcode.easy;

public partial class Solution {
    public bool SquareIsWhite(string coordinates) {
        int file = coordinates[0] - 'a';
        int rank = coordinates[1] - '1';

        return (file % 2) != (rank % 2);
    }
}