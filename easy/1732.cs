namespace leetcode.easy;

public partial class Solution
{
    public int LargestAltitude(int[] gain)
    {
        int max = 0;
        int altitude = 0;

        foreach (var alt in gain)
        {
            altitude += alt;
            max = Math.Max(altitude, max);
        }

        return max;
    }
}
