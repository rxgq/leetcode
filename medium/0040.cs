namespace leetcode.easy;

public partial class Solution {
    IList<IList<int>> result;
    public IList<IList<int>> CombinationSum2(int[] candidates, int target) {
        result = new List<IList<int>>();
        Array.Sort(candidates);
        GenerateCombinations(candidates, target, 0, new bool[candidates.Length], new List<int>());
        return result;
    }

    private void GenerateCombinations(int[] candidates, int remaining, int idx, bool[] used, IList<int> tempList) {
        if(remaining < 0) return;
        else if(remaining == 0) result.Add(tempList.ToList());

        else {
            for( int i = idx; i < candidates.Length; i++) {
    
                if(used[i] || (i > idx && candidates[i] == candidates[i - 1] && !used[i]))
                    continue;
                
                tempList.Add(candidates[i]);
                used[i] = true;
                GenerateCombinations(candidates, remaining-candidates[i], i + 1, used, tempList);
                tempList.RemoveAt(tempList.Count - 1);
                used[i] = false;
            }
        }
    }
}