namespace leetcode.easy;

public partial class Solution
{
    public string FinalString(string s)
    {
        string typedString = "";

        foreach (char c in s)
        {
            if (c == 'i')
            {
                char[] arr = typedString.ToCharArray();
                Array.Reverse(arr);
                typedString = new string(arr);
            }
            else
            {
                typedString += c;
            }
        }

        return typedString;
    }
}
