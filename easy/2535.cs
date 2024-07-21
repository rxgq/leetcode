namespace leetcode.easy;

public partial class Solution
{
    public int DifferenceOfSum(int[] nums)
    {
        int sum = 0;
        int digitSum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            string numStr = nums[i].ToString();
            for (int j = 0; j < numStr.Length; j++)
                digitSum += numStr[j] - '0';
        }

        return sum - digitSum;
    }
}
