namespace leetcode.easy;

public partial class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var dictS = new Dictionary<char, int>();
        var dictT = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            char charS = s[i];
            char charT = t[i];

            if (!dictS.ContainsKey(charS))
                dictS[charS] = 0;
            dictS[charS]++;

            if (!dictT.ContainsKey(charT))
                dictT[charT] = 0;
            dictT[charT]++;
        }

        foreach (var kvp in dictS)
        {
            if (!dictT.TryGetValue(kvp.Key, out int countT) || countT != kvp.Value)
            {
                return false;
            }
        }

        return true;
    }
}
