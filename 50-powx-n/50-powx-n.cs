public class Solution
{
    public double MyPow(double x, int n)
    {
        if(Math.Abs(x) == 1)
        {
            if(x < 0){
                return n > 0 ? x : -x;
            }
            
            return x;
        }
        
        var result = x;

        if (n > 0)
        {
            while (--n > 0)
            {
                result *= x;
            }

            return result;
        }
        else if (n < 0)
        {
            while (n++ <= 0)
            {
                if(result == 0)
                {
                    return result;
                }
                
                result /= x;
            }

            return result;
        }
        else
        {
            return 1d;
        }
    }
}