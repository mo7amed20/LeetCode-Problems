public class Solution {
        public int CountSegments(string s)
        {
            int segment = 0;

           string[] array = s.Split(" ");

            foreach (string item in array)
            {
                if (item.Length != 0)
                    segment++;
            }
            return segment;
        }

}