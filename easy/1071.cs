namespace leetcode.easy;

public partial class Solution
{
    public string GcdOfStrings(string str1, string str2)
    {
        int Gcd(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        if (str1 + str2 != str2 + str1)
            return "";

        int gcd = Gcd(str1.Length, str2.Length);
        return str1.Substring(0, gcd);
    }
}
