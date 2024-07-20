namespace leetcode;

public partial class Solution
{
    public int SingleNumber(int[] nums)
    {
        int result = 0;
        foreach (var num in nums)
            result = num ^ result;

        return result;
    }
}
