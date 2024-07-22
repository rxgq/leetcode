namespace leetcode.easy;

public partial class Solution
{
    public int HammingWeight(int n)
    {
        int count = 0;
        for (; n > 0; count += n & 1, n >>= 1) ;
        return count;
    }
}
