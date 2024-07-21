namespace leetcode.medium;

public partial class Solution
{
    public int[] FindArray(int[] pref)
    {
        int n = pref.Length;
        int[] arr = new int[n];

        arr[0] = pref[0];
        for (int i = 1; i < n; i++)
            arr[i] = pref[i] ^ pref[i - 1];

        return arr;
    }
}
