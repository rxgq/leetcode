namespace leetcode.easy;

public partial class Solution {
    public int MinChanges(int n, int k) {
        return (n & k) == k ? Convert.ToString(n ^ k, 2).Count(c => c == '1') : -1;
    }
}