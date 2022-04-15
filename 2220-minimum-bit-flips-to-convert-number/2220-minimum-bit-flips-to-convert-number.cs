public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        start ^= goal;

        start = (start & 0x55555555) + ((start >> 1) & 0x55555555);
        start = (start & 0x33333333) + ((start >> 2) & 0x33333333);
        start = (start & 0x0f0f0f0f) + ((start >> 4) & 0x0f0f0f0f);
        start = (start & 0x00ff00ff) + ((start >> 8) & 0x00ff00ff);
        start = (start & 0x0000ffff) + ((start >> 16) & 0x0000ffff);

        return start;
    }
}