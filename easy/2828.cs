namespace leetcode.easy;

public partial class Solution
{
    public bool IsAcronym(IList<string> words, string s)
    {
        string acr = "";
        foreach (string word in words)
            acr += word[0];

        return acr == s;
    }
}
