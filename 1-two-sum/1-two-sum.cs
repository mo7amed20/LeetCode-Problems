public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int, int> Hashmap = new Dictionary<int , int>(); 
            
            for (int i = 0; i < nums.Length; i++)
            {
                int diff = target - nums[i];
                if (Hashmap.ContainsKey(diff))
                {
                    return new int[] { Hashmap[diff], i };
                }
                else
                {
                    Hashmap[nums[i]] = i;
                }
            }
            throw new Exception("Not Found");
        }
        
    
}