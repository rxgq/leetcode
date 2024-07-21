namespace leetcode.easy;

public partial class Solution
{
    public double[] ConvertTemperature(double celsius)
    {
        return [celsius + 273.15, celsius * 1.8 + 32];
    }
}
