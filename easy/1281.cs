namespace leetcode.easy;

public partial class Solution
{
    public int SubtractProductAndSum(int n)
    {
        int product = 1;
        int sum = 0;

        string nStr = n.ToString();

        for (int i = 0; i < nStr.Length; i++)
            product *= int.Parse(nStr[i].ToString());

        for (int i = 0; i < nStr.Length; i++)
            sum += int.Parse(nStr[i].ToString());

        return product - sum;
    }
}
