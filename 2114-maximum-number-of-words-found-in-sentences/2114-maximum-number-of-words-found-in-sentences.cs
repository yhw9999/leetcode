public class Solution
{
    public int MostWordsFound(string[] sentences)
    {
        return sentences.Max(sentence => sentence.Split(' ').Length);
    }
}