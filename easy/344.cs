namespace leetcode.easy;

public partial class Solution
{
    public void ReverseString(char[] s)
    {
        int l = 0; int r = s.Length - 1;
        while (l < r)
        {
            (s[l], s[r]) = (s[r], s[l]);
            l++; r--;
        }
    }
}
