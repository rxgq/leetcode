namespace leetcode.easy;

public partial class Solution {
    public string LargestGoodInteger(string num) {
        string largestGood = "";

        for (int i = 2; i < num.Length; i++) {
            if (num[i] == num[i - 1] && num[i] == num[i - 2]) {
                var goodNum = num.Substring(i - 2, 3);
                
                if (largestGood == "" || string.Compare(goodNum, largestGood) > 0) 
                    largestGood = goodNum;
            }
        }

        return largestGood;
    }
}