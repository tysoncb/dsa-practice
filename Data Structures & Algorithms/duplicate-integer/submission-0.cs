public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool found = false;
        Dictionary<int,int> appeared = new Dictionary<int,int>();
        for (int i=0; i < nums.Length; i++) {
            if(appeared.ContainsKey(nums[i])) {
                found = true;
                break;
            }
            else appeared[nums[i]] = i;
        }
        return found;
    }
}