namespace leetcode.easy;

public partial class Solution
{
    public int FinalValueAfterOperations(string[] operations)
    {
        int x = 0;
        foreach (var op in operations)
            x += op[0] == '+' || op[2] == '+' ? 1 : -1;

        return x;
    }
}