namespace leetcode;

public partial class Solution
{
    public int LengthOfLastWord(string s)
    {
        for (int i = s.Length - 1; i < s.Length; i--) 
        {
            if (s[i] != ' ')
            {
                var space = s.LastIndexOf(' ');
                return s.Length - space - 1;
            }
            else 
                s = s.Remove(i);
        }

        return -1;
    }
}
