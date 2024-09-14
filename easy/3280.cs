namespace leetcode.easy;

public partial class Solution {
    public string ConvertDateToBinary(string date) {
        string[] parts = date.Split("-");
        
        string binDate = "";
        foreach (string part in parts)
            binDate += Convert.ToString(int.Parse(part), 2) + "-";

        return binDate.Substring(0, binDate.Length - 1);
    }
}