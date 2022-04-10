public class Solution
{
    public int NumberOfBeams(string[] bank)
    {
        var result = 0;
        var beforeLaserCount = 0;

        foreach (var item in bank)
        {
            var laserCount = item.Count(x => x == '1');

            if (laserCount > 0)
            {
                result += laserCount * beforeLaserCount;
                beforeLaserCount = laserCount;
            }
        }

        return result;
    }
}