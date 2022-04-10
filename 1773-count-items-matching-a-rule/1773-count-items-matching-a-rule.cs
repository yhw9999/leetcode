public class Solution
{
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
    {
        switch (ruleKey)
        {
            case "type":
                return items.Count(x => x[0] == ruleValue);
            case "color":
                return items.Count(x => x[1] == ruleValue);
            case "name":
                return items.Count(x => x[2] == ruleValue);
        }

        return 0;
    }
}