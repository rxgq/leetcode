namespace leetcode.easy;

public partial class Solution {
    public int[] FinalPrices(int[] prices) {
        var answer = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++) {

            var minIdx = -1;
            for (int j = i; j < prices.Length; j++) {
                if (j > i && prices[j] <= prices[i]) {
                    minIdx = j;
                    break;
                }
            }

            answer[i] = minIdx == -1 ? prices[i] : prices[i] - prices[minIdx];
        }

        return answer;
    }
}