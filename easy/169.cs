namespace leetcode.easy;

public partial class Solution
{
    public int MajorityElement(int[] nums)
    {
        int result = 0;
        int count = 0;

        foreach (var num in nums)
        {
            if (count == 0)
                result = num;

            count += result == num ? 1 : -1;
        }

        return result;
    }
}
