namespace leetcode.easy;

public partial class Solution {
    public bool IsPowerOfThree(int n) 
        => n > 0 && Math.Pow(3, Math.Round(Math.Log(n, 3))) == n;

}