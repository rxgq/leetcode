namespace leetcode.easy;

public partial class Solution
{
    public int[] PlusOne(int[] digits)
    {
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (digits[i]++ < 9) return digits;
            digits[i] = 0;
        }

        int[] newDigits = new int[digits.Length + 1];
        newDigits[0] = 1;

        return newDigits;
    }
}
