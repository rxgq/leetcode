namespace leetcode.easy;

public partial class Solution {
    public bool IsPowerOfTwo(int n) {
        // iff n (base 2) has a single '1' then it is a power of 2
        // 0001, 0010, 0100, 1000, etc (1, 2, 4, 8)
        //
        // therefore (n - 1 & n) == 0 is the solution
        // with 0 as an edge case
        return n > 0 && (n - 1 & n) == 0;
    }
}