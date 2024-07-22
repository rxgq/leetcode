namespace leetcode.easy;

public partial class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        List<char> list = new List<char>(magazine);

        for (int i = 0; i < ransomNote.Length; i++)
            if (!list.Remove(ransomNote[i]))
                return false;

        return true;
    }
}
