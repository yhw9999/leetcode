public class Solution
{
    public int HeightChecker(int[] heights)
    {
        var newArr = heights.ToArray();
        Array.Sort(newArr);

        var result = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            if (newArr[i] != heights[i]) result++;
        }

        return result;
    }
}