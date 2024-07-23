namespace leetcode.medium;

public partial class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 0;
        int right = 0;

        for (int i = 0; i < piles.Length; i++)
            right = Math.Max(right, piles[i]);

        while (left <= right)
        {
            int mid = (left + right) / 2;

            if (canEatAll(piles, h, mid)) right = mid - 1;
            else left = mid + 1;
        }

        return left;
    }

    private bool canEatAll(int[] piles, int h, int k)
    {
        int hoursNeeded = 0;

        for (int i = 0; i < piles.Length; i++)
            hoursNeeded += (int)Math.Ceiling((double)piles[i] / k);

        return hoursNeeded <= h;
    }
}
