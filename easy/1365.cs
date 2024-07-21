namespace leetcode.easy;

public partial class Solution
{
    public int[] SmallerNumbersThanCurrent(int[] nums)
    {
        int[] arr = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] < nums[i])
                    count++;

                arr[i] = count;
            }
        }

        return arr;
    }
}
