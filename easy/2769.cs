namespace leetcode.easy;

public partial class Solution
{
    public int TheMaximumAchievableX(int num, int t)
    {
        return unchecked(num + (t * 2));
    }
}
