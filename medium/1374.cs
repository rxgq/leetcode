namespace leetcode.easy;

public partial class Solution {
    public string GenerateTheString(int n) {
        var str = "";

        for (int i = 0; i < (n % 2 == 0 ? n - 1 : n); i++)
          str += "a";

        return n % 2 == 0 ? str + "b" : str;
    }
}