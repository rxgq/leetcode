namespace leetcode.easy;

public partial class Solution {
    public bool IsPowerOfTwo(int n) {
        return n > 0 && (n - 1 & n) == 0;
    }
}