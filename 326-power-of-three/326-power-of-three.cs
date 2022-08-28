public class Solution {
    public bool IsPowerOfThree(int n) {
        
    if (n == 1)
    {
        return true;
    }
        
    if ((n % 3 > 0 && n % 3 < 3) ||
        n == 0)
    {
        return false;
    }

    return IsPowerOfThree(n / 3);
    }
}