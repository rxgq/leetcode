namespace leetcode.easy;

public partial class Solution
{
    public IList<int> FindWordsContaining(string[] words, char x)
    {
        var nums = new List<int>();

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Contains(x))
            {
                nums.Add(i);
            }
        }

        return nums;
    }
}
