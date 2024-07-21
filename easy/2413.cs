namespace leetcode.easy;

public partial class Solution
{
    public int SmallestEvenMultiple(int n)
    {
        return n % 2 == 0 ? n : 2 * n;
    }
}
