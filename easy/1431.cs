namespace leetcode.easy;

public partial class Solution
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        List<bool> result = new();

        int greatest = 0;
        for (int i = 0; i < candies.Length; i++)
            greatest = Math.Max(greatest, candies[i]);

        for (int i = 0; i < candies.Length; i++)
            result.Add((candies[i] + extraCandies) >= greatest);

        return result;
    }
}
