namespace leetcode;

public partial class Solution {
    public bool IsPalindrome(int x) {
        string strX = x.ToString();
        char[] xArr = strX.ToCharArray();
        Array.Reverse(xArr);

        return new string(xArr) == strX;
    }
}