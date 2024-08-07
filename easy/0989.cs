namespace leetcode.easy;

public partial class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        List<int> result = new List<int>();
        int carry = 0;
        
        int n = num.Length;
        int i = n - 1;

        while (i >= 0 || k > 0 || carry > 0) {
            int sum = carry;
            if (i >= 0) {
                sum += num[i];
                i--;
            }
            if (k > 0) {
                sum += k % 10;
                k /= 10;
            }
            
            carry = sum / 10;
            result.Add(sum % 10);
        }

        result.Reverse();
        return result;
    }
}
