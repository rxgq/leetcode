﻿namespace leetcode.easy;

public partial class Solution
{
    public int Fib(int n)
    {
        if (n < 2) return n;

        int a = 0;
        int b = 1;
        int c = 1;

        for (int i = 2; i <= n; ++i)
        {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}
