public class Solution {
       public int PivotIndex(int[] nums)
        {
            int LeftSum = 0;
            var total = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                int RightSum = total - LeftSum - nums[i] ;
                
                if(LeftSum==RightSum)
                {
                    return i;
                }
                else
                {
                    LeftSum += nums[i];
                }
            }

            return  -1;
        }
}