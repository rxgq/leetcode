namespace leetcode.easy;

public partial class Solution {
    public int NumUniqueEmails(string[] emails) {
        var uniqueEmails = new HashSet<string>();

        foreach (var email in emails) {
          var local = email.Split("@")[0];
          var domain = email.Split("@")[1];
          
          local = local.Replace(".", "");

          var plus = local.IndexOf("+");
          var trueLocal = "";
          if (plus != -1) {
            trueLocal = local.Substring(0, plus) + '@' + domain;
          } else {
            trueLocal = local + '@' + domain; 
          }

          uniqueEmails.Add(trueLocal);
        }

        return uniqueEmails.Count;
    }
}