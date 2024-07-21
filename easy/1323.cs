namespace leetcode.easy;

public partial class Solution
{
    public int Maximum69Number(int num)
    {
        char[] s = num.ToString().ToCharArray();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '6')
            {
                s[i] = '9';
                return int.Parse(s);
            }
        }

        return num;
    }
}
