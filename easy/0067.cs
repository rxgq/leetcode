using System.Text;

namespace leetcode.easy;

public partial class Solution {
    public string AddBinary(string a, string b) {
        int i = a.Length - 1;
        int j = b.Length - 1;
        int carry = 0;

        var result = new StringBuilder();
        
        while (i >= 0 || j >= 0) {
            int sum = carry;
            if (i >= 0) sum += a[i--] - '0';
            if (j >= 0) sum += b[j--] - '0';

            result.Insert(0, sum % 2);
            carry = sum / 2;
        }
        
        if (carry > 0)
            result.Insert(0, '1');
        
        return result.ToString();
    }
}