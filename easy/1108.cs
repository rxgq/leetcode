namespace leetcode.easy;

public partial class Solution
{
    public string DefangIPaddr(string address)
    {
        string defanged = "";

        for (int i = 0; i < address.Length; i++)
        {
            if (address[i] == '.')
            
                defanged += "[.]";

            else
                defanged += address[i];
        }

        return defanged;
    }
}
