namespace leetcode.easy;

public partial class Solution
{
    public int NumJewelsInStones(string jewels, string stones)
    {
        int count = 0;

        for (int i = 0; i < jewels.Length; i++)
        {
            for (int j = 0; j < stones.Length; j++)
                if (stones[j] == jewels[i])
                    count++;
        }

        return count;
    }
}
