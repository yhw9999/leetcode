public class Solution {
    public bool IsPowerOfThree(int n) {
    
    if(n == 0)
    {
        return false;
    }
        
    while(n > 2)
    {
        if(n % 3 == 0)
        {
            n /= 3;
            continue;
        }
        else{
            return false;
        }
    }

    return n == 1;
    }
}