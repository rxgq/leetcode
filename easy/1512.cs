namespace leetcode.easy;

public partial class Solution
{
    public int NumIdenticalPairs(int[] nums)
    {
        var count = new Dictionary<int, int>();
        int result = 0;

        foreach (var num in nums)
        {
            if (count.ContainsKey(num))
            {
                result += count[num];
                count[num]++;
            }
            else
                count[num] = 1;
        }

        return result;
    }
}
