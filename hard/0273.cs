namespace leetcode.easy;

public partial class Solution
{
    private static string[] Ones = { 
      "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", 
      "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };

    private static string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

    public string NumberToWords(int num) {
        if (num == 0) return "Zero";
        return ConvertToWords(num).Trim();
    }

    private string ConvertToWords(int num) {
        if (num < 20)
            return Ones[num];

        if (num < 100)
            return $"{Tens[num / 10]} {Ones[num % 10]}".Trim();

        if (num < 1000)
            return $"{Ones[num / 100]} Hundred {ConvertToWords(num % 100)}".Trim();

        if (num < 1000000)
            return $"{ConvertToWords(num / 1000)} Thousand {ConvertToWords(num % 1000)}".Trim();

        if (num < 1000000000)
            return $"{ConvertToWords(num / 1000000)} Million {ConvertToWords(num % 1000000)}".Trim();

        return $"{ConvertToWords(num / 1000000000)} Billion {ConvertToWords(num % 1000000000)}".Trim();
    }
}
