namespace leetcode.easy;

public partial class Solution {
    public int SplitNum(int num) {
        var n = num.ToString().ToCharArray();
        Array.Sort(n);

        string sum = "";
        string sum2 = "";

        for (int i = 0; i < n.Length; i++) {
            if (i % 2 == 0) sum += n[i];
            else sum2 += n[i];
        }

        return int.Parse(sum) + int.Parse(sum2);
    }
}