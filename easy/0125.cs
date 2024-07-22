using System.Text;

namespace leetcode.easy;

public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        s = s.ToLower();

        StringBuilder sb = new StringBuilder();
        foreach (char c in s)
            if (Char.IsLetterOrDigit(c))
                sb.Append(c);

        s = sb.ToString();

        int left = 0;
        int right = s.Length - 1;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[left] != s[right]) return false;
            left++; right--;
        }

        return true;
    }
}
