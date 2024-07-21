namespace leetcode.easy;

public partial class Solution
{
    public int CountDigits(int num)
    {
        string numStr = num.ToString();
        int count = 0;

        for (int i = 0; i < numStr.Length; i++)
        {
            int digit = numStr[i] - '0';

            if (num % digit == 0)
                count++;
        }

        return count;
    }
}
