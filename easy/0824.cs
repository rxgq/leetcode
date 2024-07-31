namespace leetcode.easy;

public partial class Solution {
    public string ToGoatLatin(string sentence) {
        string goatLatin = "";
        var words = sentence.Split(" ");

        string vowels = "aeiouAEIOU";

        int aCounter = 1;
        foreach (string word in words) {
            string goatLatinWord = "";
            
            if (vowels.Contains(word[0])) {
                goatLatinWord = word;
                goatLatinWord += "ma";
            } else {
                goatLatinWord += word[1..(word.Length)] + word[0] + "ma";
            }

            for (int i = 0; i < aCounter; i++)
                goatLatinWord += "a";

            goatLatin += goatLatinWord + " ";
            aCounter++;
        }

        return goatLatin[0..(goatLatin.Length - 1)];
    }
}