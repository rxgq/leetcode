namespace leetcode.easy;

public partial class Solution {
    public bool IsSumEqual(string firstWord, string secondWord, string targetWord) {
        return SumOfWord(firstWord) + SumOfWord(secondWord) == SumOfWord(targetWord);
    }

    public int SumOfWord(string word) {
        string sum = "";

        foreach (char c in word) {
            var val = c - 97;
            sum += val.ToString();
        }

        return int.Parse(sum);
    }
}