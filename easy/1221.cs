namespace leetcode.easy;

public partial class Solution
{
    public int BalancedStringSplit(string s)
    {
        int balance = 0;
        int count = 0;

        foreach (char c in s)
        {
            balance += c == 'R' ? 1 : -1;
            if (balance == 0) count++;
        }

        return count;
    }
}
