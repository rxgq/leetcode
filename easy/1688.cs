namespace leetcode.easy;

public partial class Solution
{
    public int NumberOfMatches(int n)
    {
        int matches = 0;

        while (n != 1)
        {
            if (n % 2 == 0)
            {
                matches += n / 2;
                n = n / 2;
            }
            else
            {
                matches += (n - 1) / 2;
                n = (n - 1) / 2 + 1;
            }
        }

        return matches;
        // alternatively: return n - 1;
    }
}
