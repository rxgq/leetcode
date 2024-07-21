public partial class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        var seenCharacters = new HashSet<char>();

        foreach (char c in sentence)
            if (c >= 'a' && c <= 'z') seenCharacters.Add(c);

        return seenCharacters.Count == 26;
    }
}
