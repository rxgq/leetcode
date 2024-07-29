namespace leetcode.easy;

public partial class Solution {
    public IList<string> CellsInRange(string s) {
        var result = new List<string>();

        for (char st = s[0]; st <= s[3]; st++) {
            
            for (char en = s[1]; en <= s[4]; en++)
                result.Add($"{st}{en}");
        }

        return result;
    }
}