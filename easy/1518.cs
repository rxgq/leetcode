namespace leetcode.easy;

public partial class Solution {
    public int NumWaterBottles(int numBottles, int numExchange) {
        int drank = 0;
        int empty = 0;

        while (numBottles > 0) {
            drank += numBottles;
            empty += numBottles;

            numBottles = empty / numExchange;
            empty = empty % numExchange;
        }

        return drank;
    }
}
