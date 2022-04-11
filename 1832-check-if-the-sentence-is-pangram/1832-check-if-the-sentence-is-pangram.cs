public class Solution
{
    public bool CheckIfPangram(string sentence)
    {
        return sentence.Distinct().Count() == 26 ? true : false;
    }
}