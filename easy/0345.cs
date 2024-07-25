namespace leetcode.easy;

public partial class Solution
{
    public string ReverseVowels(string s)
    {
        if (s == null || s.Length == 0) return s;

        int i = 0; int j = s.Length - 1;
        string vowels = "aeiouAEIOU";

        char[] arr = s.ToCharArray();

        while (i < j)
        {
            if (!vowels.Contains(arr[i]))
                i++;
            else if (!vowels.Contains(arr[j]))
                j--;

            else
            {
                (arr[j], arr[i]) = (arr[i], arr[j]);
                i++; j--;
            }
        }

        return new string(arr);
    }
}
