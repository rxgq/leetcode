namespace leetcode.easy;

public partial class Solution {
    public bool IsCircularSentence(string sentence) {
        int i = 0;
        while (i < sentence.Length - 1) {
            if (sentence[i] == ' ')
                if (sentence[i - 1] != sentence[i + 1]) return false;

            i++;
        }

        return sentence[i] == sentence[0];
    }
}