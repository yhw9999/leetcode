public class Solution
{
    public string SortSentence(string s)
    {
        var ordered = s.Split(' ').OrderBy(x => x.Last());
        var sb = new StringBuilder();

        foreach (var item in ordered)
        {
            sb.Append(item, 0, item.Length - 1);
            sb.Append(' ');
        }

        sb.Remove(sb.Length - 1, 1);

        return sb.ToString();
    }
}