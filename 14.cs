namespace leetcode;

public partial class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        string longest_prefix = strs[0];

        for (int i = 0; i < strs.Length; i++)
        {
            while (strs[i].IndexOf(longest_prefix) != 0) 
                longest_prefix = longest_prefix[..^1];
        }

        return longest_prefix;
    }
}