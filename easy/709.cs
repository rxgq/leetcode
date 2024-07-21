namespace leetcode.easy;

public partial class Solution
{
    public string ToLowerCase(string s)
    {
        var sb = new StringBuilder();

        foreach (char c in s)
        {
            if (c >= 'A' && c <= 'Z')
            {
                int lower = ((int)c) + 32;
                sb.Append(Convert.ToChar(lower));
            }
            else
            {
                sb.Append(c);
            }

        }

        return sb.ToString();
    }
}
