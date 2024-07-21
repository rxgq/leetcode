namespace leetcode.easy;

public partial class Solution
{
    public int XorOperation(int n, int start)
    {
        int xor = 0;
        for (int i = 0; i < n; i++)
            xor ^= start + 2 * i;

        return xor;
    }
}
