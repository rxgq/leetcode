namespace leetcode.easy;

public partial class Solution
{
    public IList<string> FizzBuzz(int n)
    {
        List<string> x = new();

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                x.Add("FizzBuzz");

            else if (i % 3 == 0)
                x.Add("Fizz");

            else if (i % 5 == 0)
                x.Add("Buzz");

            else
                x.Add(i.ToString());
        }

        return x;
    }
}
