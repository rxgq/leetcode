namespace leetcode.easy;

public partial class Solution {
    public string ReverseOnlyLetters(string s) {
        char[] sArr = s.ToCharArray();

        int l = 0; int r = s.Length - 1;
        while (l < r) {
            if (char.IsLetter(sArr[l]) && char.IsLetter(sArr[r])) {
                (sArr[l], sArr[r]) = (sArr[r], sArr[l]);
                l++; r--;
            }

            if (!char.IsLetter(sArr[l])) l++;
            if (!char.IsLetter(sArr[r])) r--;
        }

        return new string(sArr);
    }
}