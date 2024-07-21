namespace leetcode.easy;

public partial class Solution
{
    public int MinimumSum(int num)
    {
        char[] digits = num.ToString().ToCharArray();

        Array.Sort(digits);

        int new1 = (digits[0] - '0') * 10 + (digits[2] - '0');
        int new2 = (digits[1] - '0') * 10 + (digits[3] - '0');

        return new1 + new2;
    }
}
