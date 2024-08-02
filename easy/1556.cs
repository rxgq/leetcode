using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public string ThousandSeparator(int n) {
        var sb = new StringBuilder();
        string nStr = n.ToString();
        
        int count = 0;
        for (int i = nStr.Length - 1; i >= 0; i--) {
            sb.Insert(0, nStr[i]);
            count++;

            if (count % 3 == 0 && i != 0)
                sb.Insert(0, '.');
        }

        return sb.ToString();
    }
}