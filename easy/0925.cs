namespace leetcode.easy;

public partial class Solution {
    public bool IsLongPressedName(string name, string typed) {
        
        int idx = 0;
        for (int i = 0; i < typed.Length; i++) {
            if (idx < name.Length && name[idx] == typed[i]) {
                idx++; 
                continue;
            }

            if (idx > 0 && name[idx - 1] == typed[i]) continue;

            return false;
        }

        return idx >= name.Length;
    }
}