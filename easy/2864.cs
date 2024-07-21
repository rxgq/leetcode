namespace leetcode.easy;

public partial class Solution
{
    public string MaximumOddBinaryNumber(string s)
    {
        int oneCount = 0;
        int zeroCount = 0;

        foreach (char c in s)
            if (c == '1') oneCount++;
            else zeroCount++;

        string result = new string('1', oneCount - 1) + new string('0', zeroCount) + "1";
        return result;
    }
}
