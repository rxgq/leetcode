namespace leetcode;

public partial class Solution
{
    public int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>{
        {'I',1}, {'V',5},{'X',10}, {'L',50},
        {'C',100},{'M',1000}, {'D',500},
    };

        var result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && dict[s[i]] < dict[s[i + 1]])
                result -= dict[s[i]];
            else
                result += dict[s[i]];
        }

        return result;
    }
}