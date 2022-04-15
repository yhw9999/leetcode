public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        var result = start ^ goal;

        result = (result & 0x55555555) + ((result >> 1) & 0x55555555);
        result = (result & 0x33333333) + ((result >> 2) & 0x33333333);
        result = (result & 0x0f0f0f0f) + ((result >> 4) & 0x0f0f0f0f);
        result = (result & 0x00ff00ff) + ((result >> 8) & 0x00ff00ff);
        result = (result & 0x0000ffff) + ((result >> 16) & 0x0000ffff);

        return result;
    }
}