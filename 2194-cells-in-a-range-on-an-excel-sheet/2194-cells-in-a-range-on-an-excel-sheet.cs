public class Solution
{
    public IList<string> CellsInRange(string s)
    {
        var result = new List<string>();

        var startCellCharacter = s[0];
        var startCellIndex = s[1];
        var endCellCharacter = s[3];
        var endCellIndex = s[4];

        for (int i = startCellCharacter; i <= endCellCharacter; i++)
        {
            for (int j = startCellIndex; j <= endCellIndex; j++)
            {
                result.Add($"{(char)i}{(char)j}");
            }
        }

        return result;
    }
}