namespace leetcode.easy;

public partial class Solution {
    public bool IsSameAfterReversals(int n)
      => n == 0 || n % 10 != 0;
}