namespace leetcode.easy;

public partial class Solution {
    public int SumOfEncryptedInt(int[] nums) {
        var encrypted = new List<int>();

        foreach (int num in nums) {
            var numStr = num.ToString();
            var max = int.Parse(numStr.Max().ToString());

            var newStr = "";
            for (int i = 0; i < numStr.Length; i++)
                newStr += max.ToString();

            encrypted.Add(int.Parse(newStr));
        }

        return encrypted.Sum();
    }
}