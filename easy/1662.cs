namespace leetcode.easy;

public partial class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        string x = string.Join("", word1);
        string y = string.Join("", word2);

        return x == y;
    }
}
