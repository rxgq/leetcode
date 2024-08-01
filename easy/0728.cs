namespace leetcode.easy;

public partial class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        var nums = new List<int>();

        for (int i = left; i <= right; i++) {
            int num = i;
            bool isSelfDividing = true;

            int original = num;
            while (num > 0) {
                int digit = num % 10;
                
                if (digit == 0 || original % digit != 0) {
                    isSelfDividing = false;
                    break;
                }

                num /= 10;
            }

            if (isSelfDividing)
                nums.Add(i);
        }

        return nums;
    }
}
