namespace leetcode.easy;

public partial class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int count = 0;

        foreach (List<string> item in items) {
          if (ruleKey == "type" && item[0] == ruleValue || 
              ruleKey == "color" && item[1] == ruleValue ||
              ruleKey == "name" && item[2] == ruleValue) {
                count++;
              }
        }

        return count;
    }
}