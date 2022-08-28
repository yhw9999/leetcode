public class Solution {
    public int MaximumGroups(int[] grades)
{
    var expectedGroupCount = 0;
    var beforeIndex = 0;

    for (int i = 1; i <= grades.Length; i++)
    {
        if (i - beforeIndex > expectedGroupCount)
        {
            expectedGroupCount++;
            beforeIndex = i;
            continue;
        }
    }

    return expectedGroupCount;
}
}