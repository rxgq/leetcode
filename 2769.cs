namespace leetcode;

public partial class Solution
{
    public int TheMaximumAchievableX(int num, int t)
    {
        return unchecked(num + (t * 2));
    }
}
