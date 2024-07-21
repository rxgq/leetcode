namespace leetcode.easy;

public partial class Solution
{
    public int SumOfTheDigitsOfHarshadNumber(int x)
    {
        string xStr = x.ToString();

        int xSum = 0;
        foreach (char c in xStr)
            xSum += c - '0';

        return x % xSum != 0 ? -1 : xSum;
    }
}
