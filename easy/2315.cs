namespace leetcode.easy;

public partial class Solution
{
    public int CountAsterisks(string s)
    {
        int count = 0;
        bool isIncluded = true;

        foreach (char c in s)
        {
            if (c == '|')
                isIncluded = !isIncluded;

            if (c == '*' && isIncluded)
                count++;
        }

        return count;
    }
}
