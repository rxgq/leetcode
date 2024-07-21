namespace leetcode.medium;

public partial class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        List<char> seen = new();
        int left = 0;
        int longest = 0;

        for (int right = 0; right < s.Length; right++)
        {
            char currentChar = s[right];

            while (seen.Contains(currentChar))
            {
                seen.Remove(s[left]);
                left++;
            }

            seen.Add(currentChar);
            longest = Math.Max(longest, right - left + 1);
        }

        return longest;
    }
}
