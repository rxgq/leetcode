namespace leetcode.easy;

public partial class Solution {
    public string ConvertToTitle(int num) {
        var sb = new StringBuilder();

        while (num > 0) {
          sb.Insert(0, (char)(((num - 1) % 26) + 'A');
          num = (num - 1) / 26;
        }

        return sb.ToString();
    }
}