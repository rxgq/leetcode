namespace leetcode.easy;

public partial class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;

        foreach (var op in operations)
        {
            if (op[0] == '+' || op[2] == '+')
                x++;

            else
                x--;
        }

        return x;
    }
}
