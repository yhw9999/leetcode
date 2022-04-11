public class Solution {
    public int NumberOfMatches(int n) {
        var result = 0;
        
        do
        {
            if(n % 2 == 0){
                result += n / 2;
                n = n / 2;
            }
            else{
                result += (n - 1) / 2;
                n = (n - 1) / 2 + 1;
            }
        }
        while(n > 1);
        
        return result;
    }
}