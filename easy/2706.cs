namespace leetcode.easy;

public partial class Solution {
    public int BuyChoco(int[] prices, int money) {
        int firstSmall = int.MaxValue;
        int secondSmall = int.MaxValue;

        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < firstSmall) {
                secondSmall = firstSmall;
                firstSmall = prices[i];
            } else secondSmall = prices[i];
        }

        int sum = firstSmall + secondSmall;
        return sum > money ? money : money - sum;
    }
}