public class Solution {
        public int PivotIndex(int[] nums)
        {
            int LeftSum = 0;
            var total = nums.Sum();

            for (int i = 0; i < nums.Length; i++)
            {
                if(i!=0)
                {
                    LeftSum += nums[i - 1];
                }

                if (LeftSum == total - LeftSum - nums[i])
                {
                    return i;
                }
            }

            return -1;
        }

}