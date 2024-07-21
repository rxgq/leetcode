namespace leetcode.easy;

public partial class Solution
{
    public int SumIndicesWithKSetBits(IList<int> nums, int k)
    {
        int count = 0;
        for (int i = 0; i < nums.Count; i++)
        {
            string binary = Convert.ToString(i, 2);
            int setBits = 0;

            foreach (char s in binary)
                if (s == '1') setBits++;

            if (setBits == k) count += nums[i];
        }

        return count;
    }
}
