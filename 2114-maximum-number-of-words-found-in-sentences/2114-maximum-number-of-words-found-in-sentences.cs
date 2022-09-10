public class Solution {
 public  int MostWordsFound(string[] sentences)
        {
            int[] Strings = new int[sentences.Length];

            for (int i = 0; i < sentences.Length; i++)
            {
               Strings[i] =  sentences[i].Split().Length;
            }

            return Strings.Max();
        }

        
}