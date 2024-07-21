namespace leetcode.easy;

public partial class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int num = 0;

        foreach (string word in words)
        {
            bool isConsistent = true;

            foreach (char c in word)
            {
                if (!allowed.Contains(c))
                {
                    isConsistent = false;
                    break;
                }
            }

            if (isConsistent) num++;
        }

        return num;
    }
}
